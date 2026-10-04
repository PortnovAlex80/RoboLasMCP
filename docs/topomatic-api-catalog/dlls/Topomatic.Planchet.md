# Topomatic.Planchet

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Planchet` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Planchet, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Planchet.dll` |

---
## Namespace: `Topomatic.Planchet`

### `Format` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Format` |
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
      - `Topomatic.Planchet.Format`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A0` | `Format` | Yes | `A0` | `` |
| `A1` | `Format` | Yes | `A1` | `` |
| `A2` | `Format` | Yes | `A2` | `` |
| `A3` | `Format` | Yes | `A3` | `` |
| `A4` | `Format` | Yes | `A4` | `` |
| `A5` | `Format` | Yes | `A5` | `` |
| `A6` | `Format` | Yes | `A6` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `A0` | `0` |
| `A1` | `1` |
| `A2` | `2` |
| `A3` | `3` |
| `A4` | `4` |
| `A5` | `5` |
| `A6` | `6` |

**Underlying Type**: `System.Int32`

### `IDwgSheet` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.IDwgSheet` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `InsertionPoint` | `Vector2D` | `get/set` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `` |
| `Nomenclature` | `String` | `get` | No | `` |
| `Number` | `String` | `get` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |
| `WorkingArea` | `BoundingBox2D` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FormatLayout` | `Void` | `DwgLayout layout` | `` |
| `IntersectWith` | `Boolean` | `BoundingBox2D box, Double scale` | `` |

### `SheetSettings` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.SheetSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `System.ICloneable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderThickness` | `Single` | `get/set` | No | `` |
| `CaptionTextFont` | `String` | `get/set` | No | `` |
| `CaptionTextHeight` | `Single` | `get/set` | No | `` |
| `CaptionTextOblique` | `Single` | `get/set` | No | `` |
| `CaptionTextRatio` | `Single` | `get/set` | No | `` |
| `DefaultLayer` | `String` | `get/set` | No | `` |
| `LargeCaptionTextFont` | `String` | `get/set` | No | `` |
| `LargeCaptionTextHeight` | `Single` | `get/set` | No | `` |
| `LargeCaptionTextOblique` | `Single` | `get/set` | No | `` |
| `LargeCaptionTextRatio` | `Single` | `get/set` | No | `` |
| `Nomenclature` | `String` | `get` | No | `` |
| `NomenclaturePattern` | `String` | `get/set` | No | `` |
| `TextFont` | `String` | `get/set` | No | `` |
| `TextHeight` | `Single` | `get/set` | No | `` |
| `TextOblique` | `Single` | `get/set` | No | `` |
| `TextRatio` | `Single` | `get/set` | No | `` |
| `VPortLayer` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SheetSettings settings` | `` |
| `Clone` | `Object` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `Clone` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SignAlignment` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.SignAlignment` |
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
      - `Topomatic.Planchet.SignAlignment`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BottomLeft` | `SignAlignment` | Yes | `BottomLeft` | `` |
| `BottomRight` | `SignAlignment` | Yes | `BottomRight` | `` |
| `TopLeft` | `SignAlignment` | Yes | `TopLeft` | `` |
| `TopRight` | `SignAlignment` | Yes | `TopRight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TopLeft` | `1` |
| `BottomLeft` | `2` |
| `BottomRight` | `4` |
| `TopRight` | `8` |

**Underlying Type**: `System.Int32`

### `StandardSheetDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.StandardSheetDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawSheet` | `Void` | `DwgBlock space, SheetSettings settings, Boolean vport` | `` |
| `DrawSheet` | `Void` | `DwgBlock space, SheetSettings settings` | `` |
| `GetWorkingArea` | `BoundingBox2D` | `SheetSettings settings` | `` |

### `StandardSheetSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.StandardSheetSettings` |
| **Base Type** | `Topomatic.Planchet.SheetSettings` |
| **Implements** | `System.ICloneable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Planchet.SheetSettings`
    - `Topomatic.Planchet.StandardSheetSettings`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CheckedBy` | `String` | `get/set` | No | `` |
| `CheckedByDate` | `DateTime` | `get/set` | No | `` |
| `ControledBy` | `String` | `get/set` | No | `` |
| `ControledByDate` | `DateTime` | `get/set` | No | `` |
| `DetachmentHead` | `String` | `get/set` | No | `` |
| `DetachmentHeadDate` | `DateTime` | `get/set` | No | `` |
| `DevelopedBy` | `String` | `get/set` | No | `` |
| `DevelopedByDate` | `DateTime` | `get/set` | No | `` |
| `Format` | `Format` | `get/set` | No | `` |
| `GeologistHead` | `String` | `get/set` | No | `` |
| `GeologistHeadDate` | `DateTime` | `get/set` | No | `` |
| `Gip` | `String` | `get/set` | No | `` |
| `GipDate` | `DateTime` | `get/set` | No | `` |
| `ImageDescription` | `String` | `get/set` | No | `` |
| `Nomenclature` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get/set` | No | `` |
| `ProjectDescription` | `String` | `get/set` | No | `` |
| `SheetNumber` | `Int32` | `get/set` | No | `` |
| `SheetsCount` | `Int32` | `get/set` | No | `` |
| `Stage` | `String` | `get/set` | No | `` |
| `Stamp` | `StandardStamp` | `get/set` | No | `` |
| `TradeDescription` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MatchFormat` | `Void` | `Double width, Double height` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StandardStamp` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.StandardStamp` |
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
      - `Topomatic.Planchet.StandardStamp`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Large` | `StandardStamp` | Yes | `Large` | `` |
| `None` | `StandardStamp` | Yes | `None` | `` |
| `Small` | `StandardStamp` | Yes | `Small` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Small` | `1` |
| `Large` | `2` |

**Underlying Type**: `System.Int32`

### `TopographicPlanchetSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.TopographicPlanchetSettings` |
| **Base Type** | `Topomatic.Planchet.SheetSettings` |
| **Implements** | `System.ICloneable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Planchet.SheetSettings`
    - `Topomatic.Planchet.TopographicPlanchetSettings`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Confirmed` | `String` | `get/set` | No | `` |
| `CoordinateSystem` | `String` | `get/set` | No | `` |
| `District` | `String` | `get/set` | No | `` |
| `ElevationSystem` | `String` | `get/set` | No | `` |
| `Height` | `Single` | `get/set` | No | `` |
| `HorizonalStep` | `String` | `get/set` | No | `` |
| `Leader1` | `String` | `get/set` | No | `` |
| `Leader2` | `String` | `get/set` | No | `` |
| `Leader3` | `String` | `get/set` | No | `` |
| `MappingScale` | `Single` | `get/set` | No | `` |
| `Nomenclature` | `String` | `get` | No | `` |
| `NumberX` | `String` | `get/set` | No | `` |
| `NumberY` | `String` | `get/set` | No | `` |
| `Organization1` | `String` | `get/set` | No | `` |
| `Organization2` | `String` | `get/set` | No | `` |
| `Organization3` | `String` | `get/set` | No | `` |
| `Permissions1` | `String` | `get/set` | No | `` |
| `Permissions2` | `String` | `get/set` | No | `` |
| `Permissions3` | `String` | `get/set` | No | `` |
| `Region` | `String` | `get/set` | No | `` |
| `Width` | `Single` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertNumberLetter` | `String` | `UInt32 number` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Planchet.Entities`

### `Attribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgTemplateSheet+Attribute` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `description` | `String` | No | `` | `` |
| `value` | `String` | No | `` | `` |

### `DwgSheet` (abstract class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgSheet` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject, Topomatic.Planchet.IDwgSheet` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Planchet.Entities.DwgSheet`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderThickness` | `Double` | `get/set` | No | `DefaultDouble` |
| `CaptionStyle` | `DwgStyle` | `get/set` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `InsertionPoint` | `Vector2D` | `get/set` | No | `` |
| `InvertMatrix` | `Matrix` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `LargeCaptionStyle` | `DwgStyle` | `get/set` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Nomenclature` | `String` | `get` | No | `` |
| `NomenclaturePattern` | `String` | `get/set` | No | `` |
| `Number` | `String` | `get` | No | `Browsable` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |
| `Scale` | `Double` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Sign` | `Drawing` | `get` | No | `Browsable` |
| `TextStyle` | `DwgStyle` | `get/set` | No | `` |
| `WorkingArea` | `BoundingBox2D` | `get` | No | `Browsable` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FormatLayout` | `Void` | `DwgLayout layout` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `IntersectWith` | `Boolean` | `BoundingBox2D box, Double scale` | `` |
| `NotifyChange` | `Void` | `DwgObject sender, EventArgs e` | `` |
| `UseReference` | `Boolean` | `DwgObject obj` | `` |

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
| `IPointObject` | `Topomatic.Cad.Foundation.IPointObject.get_BasePoint` |
| `IDwgSheet` | `get_WorkingArea` |
| `IDwgSheet` | `Topomatic.Planchet.IDwgSheet.get_Bounds` |
| `IDwgSheet` | `get_Nomenclature` |
| `IDwgSheet` | `get_Number` |
| `IDwgSheet` | `get_InsertionPoint` |
| `IDwgSheet` | `set_InsertionPoint` |
| `IDwgSheet` | `get_Scale` |
| `IDwgSheet` | `set_Scale` |
| `IDwgSheet` | `get_Rotation` |
| `IDwgSheet` | `set_Rotation` |
| `IDwgSheet` | `FormatLayout` |
| `IDwgSheet` | `IntersectWith` |
| `IDwgSheet` | `get_Matrix` |

### `DwgSheetController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgSheetController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Planchet.Entities.DwgSheetController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgSlope` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgSlope` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Planchet.Entities.DwgSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BuildingTechnique` | `SlopeBuildingTechnique` | `get/set` | No | `` |
| `DestinationLinetype` | `DwgLinetype` | `get/set` | No | `` |
| `DestPolyline` | `Polyline3D` | `get` | No | `Browsable` |
| `DisplayDestinationLinetype` | `Boolean` | `get/set` | No | `` |
| `DisplaySourceLinetype` | `Boolean` | `get/set` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `HideBackground` | `Boolean` | `get/set` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `LongStrokeSize` | `Double` | `get/set` | No | `` |
| `LongStrokeSizeType` | `StrokeSizeType` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `Browsable` |
| `ShortStrokeSize` | `Double` | `get/set` | No | `` |
| `ShortStrokeSizeType` | `StrokeSizeType` | `get/set` | No | `` |
| `SlopeType` | `SlopeType` | `get/set` | No | `` |
| `SourceLinetype` | `DwgLinetype` | `get/set` | No | `` |
| `SourcePolyline` | `Polyline3D` | `get` | No | `Browsable` |
| `Step` | `Double` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignDestPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `AssignSourcePolyline` | `Void` | `IPolyline3D polyline` | `` |
| `BreakedAt` | `IEnumerable<DwgSlope>` | `Vector2D pt` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToString` | `String` | `` | `` |
| `UseReference` | `Boolean` | `DwgObject obj` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareSlopePolylines` | `Void` | `Polyline3D source, Polyline3D dest` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwgSlopeController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgSlopeController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Planchet.Entities.DwgSlopeController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgStandardSheet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgStandardSheet` |
| **Base Type** | `Topomatic.Planchet.Entities.DwgSheet` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject, Topomatic.Planchet.IDwgSheet` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Planchet.Entities.DwgSheet`
        - `Topomatic.Planchet.Entities.DwgStandardSheet`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CheckedBy` | `String` | `get/set` | No | `` |
| `CheckedByDate` | `DateTime` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `ControledBy` | `String` | `get/set` | No | `` |
| `ControledByDate` | `DateTime` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `DetachmentHead` | `String` | `get/set` | No | `` |
| `DetachmentHeadDate` | `DateTime` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `DevelopedBy` | `String` | `get/set` | No | `` |
| `DevelopedByDate` | `DateTime` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Format` | `Format` | `get/set` | No | `` |
| `GeologistHead` | `String` | `get/set` | No | `` |
| `GeologistHeadDate` | `DateTime` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `Gip` | `String` | `get/set` | No | `` |
| `GipDate` | `DateTime` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `ImageDescription` | `String` | `get/set` | No | `` |
| `Number` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get/set` | No | `` |
| `ProjectDescription` | `String` | `get/set` | No | `` |
| `SheetNumber` | `Int32` | `get/set` | No | `` |
| `SheetsCount` | `Int32` | `get/set` | No | `` |
| `Stage` | `String` | `get/set` | No | `` |
| `Stamp` | `StandardStamp` | `get/set` | No | `` |
| `TradeDescription` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDwgSheet` | `get_Number` |

### `DwgTemplateSheet` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgTemplateSheet` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject, Topomatic.Planchet.IDwgSheet` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Planchet.Entities.DwgTemplateSheet`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Attributes` | `Dictionary<String Attribute>` | `get` | No | `PropertyProvider` |
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `InsertionPoint` | `Vector2D` | `get/set` | No | `` |
| `InvertMatrix` | `Matrix` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Nomenclature` | `String` | `get` | No | `Browsable` |
| `Number` | `String` | `get` | No | `Browsable` |
| `Order` | `Int32` | `get/set` | No | `` |
| `Paddings` | `BoundingBox2D` | `get/set` | No | `Browsable` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |
| `Scale` | `Double` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Sign` | `Drawing` | `get` | No | `Browsable` |
| `Width` | `Double` | `get/set` | No | `` |
| `WorkingArea` | `BoundingBox2D` | `get` | No | `Browsable` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FormatLayout` | `Void` | `DwgLayout layout` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `IntersectWith` | `Boolean` | `BoundingBox2D box, Double scale` | `` |
| `LoadTemplate` | `Void` | `String filename` | `` |
| `ToString` | `String` | `` | `` |

#### Nested Types (1)

- `Attribute` (class)

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
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `IPointObject` | `get_BasePoint` |
| `IDwgSheet` | `get_WorkingArea` |
| `IDwgSheet` | `Topomatic.Planchet.IDwgSheet.get_Bounds` |
| `IDwgSheet` | `get_Nomenclature` |
| `IDwgSheet` | `get_Number` |
| `IDwgSheet` | `get_InsertionPoint` |
| `IDwgSheet` | `set_InsertionPoint` |
| `IDwgSheet` | `get_Scale` |
| `IDwgSheet` | `set_Scale` |
| `IDwgSheet` | `get_Rotation` |
| `IDwgSheet` | `set_Rotation` |
| `IDwgSheet` | `FormatLayout` |
| `IDwgSheet` | `IntersectWith` |
| `IDwgSheet` | `get_Matrix` |

### `DwgTemplateSheetController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgTemplateSheetController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Planchet.Entities.DwgTemplateSheetController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgTopographicPlanchet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.DwgTopographicPlanchet` |
| **Base Type** | `Topomatic.Planchet.Entities.DwgSheet` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject, Topomatic.Planchet.IDwgSheet` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Planchet.Entities.DwgSheet`
        - `Topomatic.Planchet.Entities.DwgTopographicPlanchet`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Confirmed` | `String` | `get/set` | No | `` |
| `CoordinateSystem` | `String` | `get/set` | No | `` |
| `District` | `String` | `get/set` | No | `` |
| `ElevationSystem` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `DefaultDouble` |
| `HorizonalStep` | `String` | `get/set` | No | `` |
| `Leader1` | `String` | `get/set` | No | `` |
| `Leader2` | `String` | `get/set` | No | `` |
| `Leader3` | `String` | `get/set` | No | `` |
| `Number` | `String` | `get` | No | `` |
| `NumberX` | `String` | `get/set` | No | `` |
| `NumberY` | `String` | `get/set` | No | `` |
| `Organization1` | `String` | `get/set` | No | `` |
| `Organization2` | `String` | `get/set` | No | `` |
| `Organization3` | `String` | `get/set` | No | `` |
| `Permissions1` | `String` | `get/set` | No | `` |
| `Permissions2` | `String` | `get/set` | No | `` |
| `Permissions3` | `String` | `get/set` | No | `` |
| `Region` | `String` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `DefaultDouble` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FormatLayout` | `Void` | `DwgLayout layout` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDwgSheet` | `get_Number` |
| `IDwgSheet` | `FormatLayout` |

### `SlopeBuildingTechnique` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.SlopeBuildingTechnique` |
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
      - `Topomatic.Planchet.Entities.SlopeBuildingTechnique`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EqualApportionment` | `SlopeBuildingTechnique` | Yes | `EqualApportionment` | `` |
| `Perpendicular` | `SlopeBuildingTechnique` | Yes | `Perpendicular` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `EqualApportionment` | `0` |
| `Perpendicular` | `1` |

**Underlying Type**: `System.Byte`

### `SlopeType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.SlopeType` |
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
      - `Topomatic.Planchet.Entities.SlopeType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cutting` | `SlopeType` | Yes | `Cutting` | `` |
| `Fortified` | `SlopeType` | Yes | `Fortified` | `` |
| `Unfortified` | `SlopeType` | Yes | `Unfortified` | `` |
| `value__` | `Byte` | No | `` | `` |
| `Winning` | `SlopeType` | Yes | `Winning` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Unfortified` | `0` |
| `Fortified` | `1` |
| `Winning` | `2` |
| `Cutting` | `3` |

**Underlying Type**: `System.Byte`

### `StrokeSizeType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Entities.StrokeSizeType` |
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
      - `Topomatic.Planchet.Entities.StrokeSizeType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Fixed` | `StrokeSizeType` | Yes | `Fixed` | `` |
| `Persent` | `StrokeSizeType` | Yes | `Persent` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Fixed` | `0` |
| `Persent` | `1` |

**Underlying Type**: `System.Byte`

---
## Namespace: `Topomatic.Planchet.Leader`

### `DynamicLeader` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.DynamicLeader` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntities` | `Void` | `Drawing drawing, CadColor color, LeaderParams lp, ref List<DwgEntity> list` | `` |
| `AddEntities` | `Void` | `Drawing drawing, LeaderParams lp, ref List<DwgEntity> list` | `` |
| `Draw` | `Void` | `CadPen pen, LeaderParams lp` | `` |
| `Draw` | `Void` | `CadPen pen, Double screenRatio, LeaderParams lp` | `` |
| `TryGetBounds` | `Boolean` | `Double screenRatio, LeaderParams lp, ref BoundingBox2D bounds` | `` |
| `TryGetBounds` | `Boolean` | `LeaderParams lp, ref BoundingBox2D bounds` | `` |

### `LeaderAngleGrip` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderAngleGrip` |
| **Base Type** | `Topomatic.Planchet.Leader.LeaderGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Planchet.Leader.LeaderGrip`
      - `Topomatic.Planchet.Leader.LeaderAngleGrip`

#### Constructors (1)

- `.ctor(CadView cadView, LeaderParams leaderParams, CadColor color)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeforeDynamicDraw` | `Void` | `` | `` |
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |
| `ResetAngle` | `Void` | `` | `` |
| `SetAngle` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeaderClickGrip` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderClickGrip` |
| **Base Type** | `Topomatic.Cad.View.ClickGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.ClickGrip`
    - `Topomatic.Planchet.Leader.LeaderClickGrip`

#### Constructors (1)

- `.ctor(CadView cadView, LeaderParams leaderParams)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeaderFlipTextGrip` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderFlipTextGrip` |
| **Base Type** | `Topomatic.Planchet.Leader.LeaderClickGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.ClickGrip`
    - `Topomatic.Planchet.Leader.LeaderClickGrip`
      - `Topomatic.Planchet.Leader.LeaderFlipTextGrip`

#### Constructors (1)

- `.ctor(CadView cadView, LeaderParams leaderParams)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |
| `SetFlip` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |

### `LeaderGrip` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Planchet.Leader.LeaderGrip`

#### Constructors (1)

- `.ctor(CadView cadview, LeaderParams leaderParams, CadColor color)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeaderMirrorGrip` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderMirrorGrip` |
| **Base Type** | `Topomatic.Planchet.Leader.LeaderClickGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.ClickGrip`
    - `Topomatic.Planchet.Leader.LeaderClickGrip`
      - `Topomatic.Planchet.Leader.LeaderMirrorGrip`

#### Constructors (1)

- `.ctor(CadView cadView, LeaderParams leaderParams)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |
| `SetMirror` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |

### `LeaderParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `LeaderParams` | `LeaderParams other` | `` |

#### Fields (14)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AdditionalTextOffset` | `Double` | No | `` | `` |
| `Angle` | `Double` | No | `` | `` |
| `BasePos` | `Vector2D` | No | `` | `` |
| `BotText` | `String[]` | No | `` | `` |
| `FlipText` | `Boolean` | No | `` | `` |
| `Font` | `CadFont` | No | `` | `` |
| `Height` | `Double` | No | `` | `` |
| `LeaderType` | `LeaderType` | No | `` | `` |
| `Oblique` | `Double` | No | `` | `` |
| `Ratio` | `Double` | No | `` | `` |
| `TextAlignment` | `LeaderTextAlignment` | No | `` | `` |
| `TextPos` | `Vector2D` | No | `` | `` |
| `TopText` | `String[]` | No | `` | `` |
| `Wipeout` | `Boolean` | No | `` | `` |

### `LeaderPositionGrip` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderPositionGrip` |
| **Base Type** | `Topomatic.Planchet.Leader.LeaderGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Planchet.Leader.LeaderGrip`
      - `Topomatic.Planchet.Leader.LeaderPositionGrip`

#### Constructors (1)

- `.ctor(CadView cadView, LeaderParams leaderParams, CadColor color)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeforeDynamicDraw` | `Void` | `` | `` |
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |
| `ResetPosition` | `Void` | `` | `` |
| `SetPosition` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeaderTextAlignment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderTextAlignment` |
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
      - `Topomatic.Planchet.Leader.LeaderTextAlignment`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `LeaderTextAlignment` | Yes | `Left` | `` |
| `Middle` | `LeaderTextAlignment` | Yes | `Middle` | `` |
| `Right` | `LeaderTextAlignment` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Middle` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `LeaderType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Leader.LeaderType` |
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
      - `Topomatic.Planchet.Leader.LeaderType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arrow` | `LeaderType` | Yes | `Arrow` | `` |
| `Line` | `LeaderType` | Yes | `Line` | `` |
| `NoLine` | `LeaderType` | Yes | `NoLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Line` | `0` |
| `Arrow` | `1` |
| `NoLine` | `-1` |

**Underlying Type**: `System.Int32`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 30 |
| **Classes** | 11 |
| **Interfaces** | 1 |
| **Enums** | 8 |
| **Structs** | 0 |
| **Abstract Classes** | 8 |
| **Static Classes** | 2 |
| **Total Methods** | 75 |
| **Total Properties** | 162 |
| **Total Fields** | 52 |
| **Total Events** | 0 |
| **Total Constructors** | 19 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


