# Topomatic.Sfc.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Sfc.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Sfc.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Sfc.Controller.dll` |

---
## Namespace: `Topomatic.Cad.View.Hints`

### `StructureLineArcCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.StructureLineArcCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.StructureLineArcCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LengthHint` | `DoubleHint` | `get` | No | `` |
| `RadiusHint` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetArc` | `GetPointResult` | `Vector2D startPoint, Vector2D prevPoint, ref Vector3D[] arcPoints` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

### `StructureLineLinearCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.StructureLineLinearCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`
        - `Topomatic.Cad.View.Hints.StructureLineLinearCursor`

#### Constructors (1)

- `.ctor(CadView cadView, Double prevAngle, Boolean lockAngle, String message, String[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleHint` | `AngleHint` | `get` | No | `` |
| `LengthHint` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

---
## Namespace: `Topomatic.Sfc.Controller`

### `CadViewExtentions` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.CadViewExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePolyline` | `Boolean` | `CadView cadView, DrawCursorEvent draw, Action<Vector3D[]> initialize, List<Vector3D> pline` | `` |

### `CoupleHint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.CoupleHint` |
| **Base Type** | `Topomatic.Cad.View.Hints.DoubleHint` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadHint`
      - `Topomatic.Cad.View.Hints.ReadOnlyHint`
        - `Topomatic.Cad.View.Hints.EditHint`
          - `Topomatic.Cad.View.Hints.DoubleHint`
            - `Topomatic.Sfc.Controller.CoupleHint`

#### Constructors (1)

- `.ctor(CadView cadView, Double minRadius, Double maxRadius)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SfcControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.SfcControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Sfc.Controller.SfcControllerPluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SurfacePlanchet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.SurfacePlanchet` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Sfc.Controller.SurfacePlanchet`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Sfc.Controller.Dbf`

### `Field` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Dbf.Field` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Dbf.Field`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLength` | `Int32` | `` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AutoIncrement` | `Int32` | No | `` | `` |
| `Index` | `Boolean` | No | `` | `` |
| `Length` | `Int32` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Number` | `Int32` | No | `` | `` |
| `Type` | `FieldType` | No | `` | `` |

### `FieldCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Dbf.FieldCollection` |
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
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Field` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Field field` | `` |
| `Clear` | `Void` | `` | `` |

### `FieldType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Dbf.FieldType` |
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
      - `Topomatic.Sfc.Controller.Dbf.FieldType`

#### Fields (19)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Autoincrement` | `FieldType` | Yes | `Autoincrement` | `` |
| `Binary` | `FieldType` | Yes | `Binary` | `` |
| `Blob` | `FieldType` | Yes | `Blob` | `` |
| `Char` | `FieldType` | Yes | `Char` | `` |
| `Currency` | `FieldType` | Yes | `Currency` | `` |
| `Date` | `FieldType` | Yes | `Date` | `` |
| `DateTime` | `FieldType` | Yes | `DateTime` | `` |
| `Double7` | `FieldType` | Yes | `Double7` | `` |
| `Float` | `FieldType` | Yes | `Float` | `` |
| `Global` | `FieldType` | Yes | `Global` | `` |
| `Integer` | `FieldType` | Yes | `Integer` | `` |
| `Logical` | `FieldType` | Yes | `Logical` | `` |
| `Memo` | `FieldType` | Yes | `Memo` | `` |
| `Numeric` | `FieldType` | Yes | `Numeric` | `` |
| `Picture` | `FieldType` | Yes | `Picture` | `` |
| `Timestamp` | `FieldType` | Yes | `Timestamp` | `` |
| `value__` | `Byte` | No | `` | `` |
| `Varbinary` | `FieldType` | Yes | `Varbinary` | `` |
| `Varchar` | `FieldType` | Yes | `Varchar` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Autoincrement` | `43` |
| `Timestamp` | `64` |
| `Binary` | `66` |
| `Char` | `67` |
| `Date` | `68` |
| `Float` | `70` |
| `Global` | `71` |
| `Integer` | `73` |
| `Logical` | `76` |
| `Memo` | `77` |
| `Numeric` | `78` |
| `Double7` | `79` |
| `Picture` | `80` |
| `Varbinary` | `81` |
| `DateTime` | `84` |
| `Varchar` | `86` |
| `Blob` | `87` |
| `Currency` | `89` |

**Underlying Type**: `System.Byte`

### `Row` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Dbf.Row` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Table table)`

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ReadAsBool` | `Boolean` | `Int32 i` | `` |
| `ReadAsBytes` | `Byte[]` | `Int32 i` | `` |
| `ReadAsDate` | `DateTime` | `Int32 i` | `` |
| `ReadAsDouble` | `Double` | `Int32 i` | `` |
| `ReadAsLong` | `Int64` | `Int32 i` | `` |
| `ReadAsString` | `String` | `Int32 i` | `` |
| `Write` | `Void` | `Int32 i, Double number` | `` |
| `Write` | `Void` | `Int32 i, DateTime dateTime` | `` |
| `Write` | `Void` | `Int32 i, Boolean boolean` | `` |
| `Write` | `Void` | `Int32 i, Byte[] bytes` | `` |
| `Write` | `Void` | `Int32 i, String str` | `` |
| `Write` | `Void` | `Int32 i, Int64 number` | `` |

### `Table` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Dbf.Table` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String path)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Encoding` | `Encoding` | `get/set` | No | `` |
| `Fields` | `FieldCollection` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Close` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `Read` | `Row` | `Int32 i` | `` |
| `ReadHeader` | `Void` | `` | `` |
| `Write` | `Void` | `Int32 i, Row row` | `` |
| `WriteHeader` | `Void` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CODE_PAGE_IDS` | `Dictionary<Int32 Byte>` | Yes | `` | `` |
| `CODE_PAGES` | `Dictionary<Byte Int32>` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.Sfc.Controller.Import`

### `SurfaceFormatException` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Import.SurfaceFormatException` |
| **Base Type** | `System.FormatException` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `System.SystemException`
      - `System.FormatException`
        - `Topomatic.Sfc.Controller.Import.SurfaceFormatException`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String message)`
- `.ctor(String message, Exception inner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Sfc.Controller.Shape`

### `MultiPatch` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.MultiPatch` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.MultiPatch`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `MArray` | `Double[]` | No | `` | `` |
| `MRange` | `Double[]` | No | `` | `` |
| `Parts` | `Int32[]` | No | `` | `` |
| `PartTypes` | `PartType[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |
| `ZArray` | `Double[]` | No | `` | `` |
| `ZRange` | `Double[]` | No | `` | `` |

### `MultiPoint` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.MultiPoint` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.MultiPoint`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |

### `MultiPointM` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.MultiPointM` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.MultiPointM`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `MArray` | `Double[]` | No | `` | `` |
| `MRange` | `Double[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |

### `MultiPointZ` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.MultiPointZ` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.MultiPointZ`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `MArray` | `Double[]` | No | `` | `` |
| `MRange` | `Double[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |
| `ZArray` | `Double[]` | No | `` | `` |
| `ZRange` | `Double[]` | No | `` | `` |

### `PartType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PartType` |
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
      - `Topomatic.Sfc.Controller.Shape.PartType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FirstRing` | `PartType` | Yes | `FirstRing` | `` |
| `InnerRing` | `PartType` | Yes | `InnerRing` | `` |
| `OuterRing` | `PartType` | Yes | `OuterRing` | `` |
| `Ring` | `PartType` | Yes | `Ring` | `` |
| `TriangleFan` | `PartType` | Yes | `TriangleFan` | `` |
| `TriangleStrip` | `PartType` | Yes | `TriangleStrip` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TriangleStrip` | `0` |
| `TriangleFan` | `1` |
| `OuterRing` | `2` |
| `InnerRing` | `3` |
| `FirstRing` | `4` |
| `Ring` | `5` |

**Underlying Type**: `System.Int32`

### `Point` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.Point` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.Point`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |

### `PointM` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PointM` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.PointM`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `M` | `Double` | No | `` | `` |
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |

### `PointZ` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PointZ` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.PointZ`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `M` | `Double` | No | `` | `` |
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |
| `Z` | `Double` | No | `` | `` |

### `Polygon` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.Polygon` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.Polygon`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `Parts` | `Int32[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |

### `PolygonM` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PolygonM` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.PolygonM`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `MArray` | `Double[]` | No | `` | `` |
| `MRange` | `Double[]` | No | `` | `` |
| `Parts` | `Int32[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |

### `PolygonZ` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PolygonZ` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.PolygonZ`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `MArray` | `Double[]` | No | `` | `` |
| `MRange` | `Double[]` | No | `` | `` |
| `Parts` | `Int32[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |
| `ZArray` | `Double[]` | No | `` | `` |
| `ZRange` | `Double[]` | No | `` | `` |

### `PolyLine` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PolyLine` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.PolyLine`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `Parts` | `Int32[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |

### `PolyLineM` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PolyLineM` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.PolyLineM`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `MArray` | `Double[]` | No | `` | `` |
| `MRange` | `Double[]` | No | `` | `` |
| `Parts` | `Int32[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |

### `PolyLineZ` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.PolyLineZ` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Controller.Shape.PolyLineZ`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `Double[]` | No | `` | `` |
| `MArray` | `Double[]` | No | `` | `` |
| `MRange` | `Double[]` | No | `` | `` |
| `Parts` | `Int32[]` | No | `` | `` |
| `Points` | `Point[]` | No | `` | `` |
| `ZArray` | `Double[]` | No | `` | `` |
| `ZRange` | `Double[]` | No | `` | `` |

### `Shape` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.Shape` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(String path)`
- `.ctor(String path, Boolean useIndex)`
- `.ctor(String path, Boolean useIndex, Boolean writeM)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MaxM` | `Double` | `get` | No | `` |
| `MaxX` | `Double` | `get` | No | `` |
| `MaxY` | `Double` | `get` | No | `` |
| `MaxZ` | `Double` | `get` | No | `` |
| `MinM` | `Double` | `get` | No | `` |
| `MinX` | `Double` | `get` | No | `` |
| `MinY` | `Double` | `get` | No | `` |
| `MinZ` | `Double` | `get` | No | `` |
| `ShapeType` | `ShapeType` | `get` | No | `` |

#### Instance Methods (32)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanRead` | `Boolean` | `` | `` |
| `Close` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `Read` | `Boolean` | `ref MultiPoint multiPoint` | `` |
| `Read` | `Boolean` | `ref PolygonZ polygon` | `` |
| `Read` | `Boolean` | `ref PolygonM polygon` | `` |
| `Read` | `Boolean` | `ref MultiPatch multiPatch` | `` |
| `Read` | `Boolean` | `ref MultiPointZ multiPoint` | `` |
| `Read` | `Boolean` | `ref MultiPointM multiPoint` | `` |
| `Read` | `Boolean` | `ref Polygon polygon` | `` |
| `Read` | `Boolean` | `ref PointZ point` | `` |
| `Read` | `Boolean` | `ref PointM point` | `` |
| `Read` | `Boolean` | `ref Point point` | `` |
| `Read` | `Boolean` | `ref PolyLineZ polyline` | `` |
| `Read` | `Boolean` | `ref PolyLineM polyline` | `` |
| `Read` | `Boolean` | `ref PolyLine polyline` | `` |
| `ReadHeader` | `Void` | `` | `` |
| `Write` | `Void` | `ref PolygonZ polygon` | `` |
| `Write` | `Void` | `ref PolygonM polygon` | `` |
| `Write` | `Void` | `ref Polygon polygon` | `` |
| `Write` | `Void` | `ref MultiPoint multiPoint` | `` |
| `Write` | `Void` | `ref MultiPatch multiPatch` | `` |
| `Write` | `Void` | `ref MultiPointZ multiPoint` | `` |
| `Write` | `Void` | `ref MultiPointM multiPoint` | `` |
| `Write` | `Void` | `ref PolyLineZ polyline` | `` |
| `Write` | `Void` | `ref PointM point` | `` |
| `Write` | `Void` | `ref Point point` | `` |
| `Write` | `Void` | `` | `` |
| `Write` | `Void` | `ref PolyLineM polyline` | `` |
| `Write` | `Void` | `ref PolyLine polyline` | `` |
| `Write` | `Void` | `ref PointZ point` | `` |
| `WriteHeader` | `Void` | `ShapeType shapeType` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `ShapeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Shape.ShapeType` |
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
      - `Topomatic.Sfc.Controller.Shape.ShapeType`

#### Fields (15)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MultiPatch` | `ShapeType` | Yes | `MultiPatch` | `` |
| `MultiPoint` | `ShapeType` | Yes | `MultiPoint` | `` |
| `MultiPointM` | `ShapeType` | Yes | `MultiPointM` | `` |
| `MultiPointZ` | `ShapeType` | Yes | `MultiPointZ` | `` |
| `NullShape` | `ShapeType` | Yes | `NullShape` | `` |
| `Point` | `ShapeType` | Yes | `Point` | `` |
| `PointM` | `ShapeType` | Yes | `PointM` | `` |
| `PointZ` | `ShapeType` | Yes | `PointZ` | `` |
| `Polygon` | `ShapeType` | Yes | `Polygon` | `` |
| `PolygonM` | `ShapeType` | Yes | `PolygonM` | `` |
| `PolygonZ` | `ShapeType` | Yes | `PolygonZ` | `` |
| `PolyLine` | `ShapeType` | Yes | `PolyLine` | `` |
| `PolyLineM` | `ShapeType` | Yes | `PolyLineM` | `` |
| `PolyLineZ` | `ShapeType` | Yes | `PolyLineZ` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NullShape` | `0` |
| `Point` | `1` |
| `PolyLine` | `3` |
| `Polygon` | `5` |
| `MultiPoint` | `8` |
| `PointZ` | `11` |
| `PolyLineZ` | `13` |
| `PolygonZ` | `15` |
| `MultiPointZ` | `18` |
| `PointM` | `21` |
| `PolyLineM` | `23` |
| `PolygonM` | `25` |
| `MultiPointM` | `28` |
| `MultiPatch` | `31` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Sfc.Controller.Wrappers`

### `StructureLineElevationsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Controller.Wrappers.StructureLineElevationsWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Sfc.Controller.Wrappers.StructureLineElevationsWrapper`

#### Constructors (1)

- `.ctor(StructureLine structureLine)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 29 |
| **Classes** | 11 |
| **Interfaces** | 0 |
| **Enums** | 3 |
| **Structs** | 14 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 60 |
| **Total Properties** | 19 |
| **Total Fields** | 108 |
| **Total Events** | 0 |
| **Total Constructors** | 15 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


