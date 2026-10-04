# Topomatic.Pipes.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Pipes.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Pipes.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Pipes.Runtime.dll` |

---
## Namespace: `Topomatic.Pipes.Runtime`

### `ArcPrepareType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ArcPrepareType` |
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
      - `Topomatic.Pipes.Runtime.ArcPrepareType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HeightChord` | `ArcPrepareType` | Yes | `HeightChord` | `` |
| `StepLength` | `ArcPrepareType` | Yes | `StepLength` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `HeightChord` | `0` |
| `StepLength` | `1` |

**Underlying Type**: `System.Int32`

### `ContourLabelsInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.LandAllotmentZone+ContourLabelsInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Runtime.LandAllotmentZone+ContourLabelsInfo`

#### Constructors (1)

- `.ctor(Boolean forward)`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Forward` | `Boolean` | No | `` | `` |
| `StartIndex` | `Int32` | No | `` | `` |
| `StartNumber` | `Int32` | No | `` | `` |

### `DwgPipeLeader` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.DwgPipeLeader` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Pipes.Runtime.DwgPipeLeader`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Vector2D pos, Double rotation)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EditedLabelsInSign` | `IDictionary<Int32 EditedLabel>` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `LayerId` | `UInt32` | `get/set` | No | `Browsable` |
| `LineId` | `UInt32` | `get/set` | No | `Browsable` |
| `LineName` | `String` | `get/set` | No | `ReadOnly` |
| `ModelUid` | `String` | `get/set` | No | `Browsable` |
| `NetworkName` | `String` | `get/set` | No | `ReadOnly` |
| `PipeIndex` | `Int32` | `get/set` | No | `Browsable` |
| `PipeName` | `String` | `get/set` | No | `ReadOnly` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `Browsable` |
| `PlanSignName` | `String` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `Pos` | `Vector2D` | `get/set` | No | `Browsable` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLabels` | `List<DwgEntity>` | `Double annotationScale` | `` |
| `GetRegulars` | `List<DwgEntity>` | `Double annotationScale` | `` |
| `InvalidateCache` | `Void` | `` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ParseTextString` | `String` | `String s` | `` |
| `RefreshCache` | `Void` | `Double annotationScale` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CharacterPoint` | `String` | No | `` | `Browsable` |
| `EBotInner` | `String` | No | `` | `Browsable` |
| `EBotOuter` | `String` | No | `` | `Browsable` |
| `ElevationCharacterPoint` | `String` | No | `` | `Browsable` |
| `EMiddle` | `String` | No | `` | `Browsable` |
| `ETopInner` | `String` | No | `` | `Browsable` |
| `ETopOuter` | `String` | No | `` | `Browsable` |
| `InnerDiameter` | `String` | No | `` | `Browsable` |
| `NetworkTypeDesignation` | `String` | No | `` | `Browsable` |
| `OuterDiameter` | `String` | No | `` | `Browsable` |
| `PlanPipeName` | `String` | No | `` | `Browsable` |
| `ValidData` | `Boolean` | No | `` | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `DwgPipeLeaderController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.DwgPipeLeaderController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Pipes.Runtime.DwgPipeLeaderController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindTruePipe` | `PnSegment` | `PnLine line, Int32 index, Vector2D linePos` | `` |
| `GetEntityPosition` | `Vector2D` | `DwgEntity entity` | `` |
| `GetEntityTextLength` | `Double` | `DwgEntity entity, Double annotationScale, DwgPipeLeader pipeLeader` | `` |

#### Nested Types (2)

- `PipeLeaderTextFlipGrip` (class)
- `PipeLeaderTextMirrorGrip` (class)

### `IsSimpleComplexType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.IsSimpleComplexType` |
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
      - `Topomatic.Pipes.Runtime.IsSimpleComplexType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsAny` | `IsSimpleComplexType` | Yes | `IsAny` | `` |
| `IsComplex` | `IsSimpleComplexType` | Yes | `IsComplex` | `` |
| `IsSimple` | `IsSimpleComplexType` | Yes | `IsSimple` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `IsSimple` | `0` |
| `IsComplex` | `1` |
| `IsAny` | `2` |

**Underlying Type**: `System.Int32`

### `LandAllotmentSignEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.LandAllotmentSignEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Pipes.Runtime.LandAllotmentSignEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `LandAllotmentZone` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.LandAllotmentZone` |
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
      - `Topomatic.Pipes.Runtime.LandAllotmentZone`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(List<LineInfo> axis, Double offset, Double screenRotation)`

#### Properties (35)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArcPreparePrecision` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `ArcPrepareType` | `ArcPrepareType` | `get/set` | No | `ConditionalBrowsable, PropertyTypeConverter, PropertyUpdateSequence` |
| `Area` | `Double` | `get` | No | `` |
| `Axis` | `List<LineInfo>` | `get` | No | `Browsable` |
| `CalcPipeRadius` | `Boolean` | `get/set` | No | `ConditionalBrowsable` |
| `Contours` | `List<List<Vector2D>>` | `get` | No | `Browsable` |
| `DrawAuxiliary` | `Boolean` | `get/set` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `HeightChord` | `Double` | `get` | No | `Browsable` |
| `IncludingLineColor` | `CadColor` | `get/set` | No | `ByBlock` |
| `Name` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `Note` | `String` | `get/set` | No | `` |
| `NumberingInfo` | `Dictionary<Int32 ContourLabelsInfo>` | `get` | No | `Browsable` |
| `OffsetBackward` | `Double` | `get/set` | No | `` |
| `OffsetForward` | `Double` | `get/set` | No | `` |
| `OffsetLeft` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `OffsetRight` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `ParentLineColor` | `CadColor` | `get/set` | No | `ByBlock` |
| `Pivot` | `Vector2D` | `get` | No | `Browsable` |
| `PlanSignName` | `String` | `get/set` | No | `PropertyEditor` |
| `ResultContourAlpha` | `Int32` | `get/set` | No | `` |
| `ResultContourAlphaValue` | `Int32` | `get` | No | `Browsable` |
| `ResultContourStrip` | `Vector2F[]` | `get` | No | `Browsable` |
| `ResultZoneColor` | `CadColor` | `get/set` | No | `ByBlock` |
| `ScreenRotation` | `Double` | `get/set` | No | `Browsable` |
| `ShowDiameter` | `Boolean` | `get/set` | No | `Browsable` |
| `ShowOffset` | `Boolean` | `get/set` | No | `Browsable` |
| `SimpleOrComplexZone` | `IsSimpleComplexType` | `get` | No | `Browsable` |
| `StepLength` | `Double` | `get` | No | `Browsable` |
| `TrimContourAlpha` | `Int32` | `get/set` | No | `` |
| `TrimContourAlphaValue` | `Int32` | `get` | No | `Browsable` |
| `TrimContourColor` | `CadColor` | `get/set` | No | `ByBlock` |
| `TrimContours` | `List<List<Vector2D>>` | `get` | No | `Browsable` |
| `TrimContourStrip` | `Vector2F[]` | `get` | No | `Browsable` |
| `TrimLineColor` | `CadColor` | `get/set` | No | `ByBlock` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAxleLine` | `Void` | `LineInfo info` | `` |
| `AddAxleLines` | `Void` | `List<LineInfo> lines` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetVertexPosition` | `Vector2D` | `Int32 m_Index` | `` |
| `InvalidateCache` | `Void` | `` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ParseTextString` | `String` | `String s, Vector2D pos, Int32 index, Int32 count, ContourLabelsInfo info` | `` |
| `SetBounds` | `Void` | `BoundingBox2D bounds` | `` |
| `ToString` | `String` | `` | `` |
| `UpdateLineStrip` | `Void` | `` | `` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPositions` | `Void` | `List<BugleVector2D> positions, ref List<List<Vector2D>> contours` | `` |
| `AddPositions` | `Void` | `List<Vector2D> positions, ref List<List<Vector2D>> contours` | `` |
| `CalcArea` | `Double` | `Vector2F[] resultContourStrip` | `` |
| `GetZones` | `List<ZoneContours>` | `List<LineInfo> axis` | `` |
| `IsSimpleZone` | `IsSimpleComplexType` | `List<LineInfo> axis` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultHeightChord` | `Double` | Yes | `0.01` | `` |
| `DefaultStepLength` | `Double` | Yes | `1` | `` |
| `EPSILON_PRECISION` | `Double` | Yes | `0.01` | `` |
| `StartNumbering` | `Int32` | Yes | `1` | `` |
| `UndefinedBlock` | `String` | Yes | `` | `` |
| `VertexNumderTag` | `String` | Yes | `"%VertexNumber%"` | `` |
| `VertexXTag` | `String` | Yes | `"%VertexX%"` | `` |
| `VertexYTag` | `String` | Yes | `"%VertexY%"` | `` |

#### Nested Types (1)

- `ContourLabelsInfo` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `LandAllotmentZoneController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.LandAllotmentZoneController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Pipes.Runtime.LandAllotmentZoneController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `LandCalculator` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.LandCalculator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcContours` | `Boolean` | `LandAllotmentZone zone` | `Extension` |

### `PipeLeaderTextFlipGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.DwgPipeLeaderController+PipeLeaderTextFlipGrip` |
| **Base Type** | `Topomatic.Cad.View.ClickGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.ClickGrip`
    - `Topomatic.Pipes.Runtime.DwgPipeLeaderController+PipeLeaderTextFlipGrip`

#### Constructors (1)

- `.ctor(CadView cadView, DwgPipeLeader leader, DwgEntity entity, Int32 entityIndex)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |

### `PipeLeaderTextMirrorGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.DwgPipeLeaderController+PipeLeaderTextMirrorGrip` |
| **Base Type** | `Topomatic.Cad.View.ClickGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.ClickGrip`
    - `Topomatic.Pipes.Runtime.DwgPipeLeaderController+PipeLeaderTextMirrorGrip`

#### Constructors (1)

- `.ctor(CadView cadView, DwgPipeLeader leader, DwgEntity entity, Int32 entityIndex)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |

### `RuntimeTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.RuntimeTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCacheContainer` | `PlanLayerCacheContainer` | `PipeNetwork network` | `` |
| `GetAlignmentById` | `Alignment` | `PipeNetwork pipeNetwork, String algId` | `` |
| `GetAllPipeNetworks` | `List<PipeNetworkInfo>` | `Boolean openedOnly` | `` |
| `GetBasisAlignment` | `Alignment` | `PipeNetwork pipeNetwork` | `` |
| `GetBasisInfoByPos` | `BasisPointInfo` | `Object obj, Vector2D pos` | `` |
| `GetDiamemetrs` | `Void` | `PnSegment pipe, ref String outer, ref String inner` | `` |
| `GetModelName` | `String` | `IOwned obj` | `` |
| `GetModelName` | `String` | `Object obj` | `` |
| `GetNodeReference` | `Object` | `ReferenceNodeData referenceData` | `` |
| `GetPipeElevations` | `Void` | `PnSegment pipe, Double sta, ref String eTopOuter, ref String eTopInner, ref String eMiddle, ref String eBotInner, ref String eBotOuter` | `` |
| `GetPlanLayer` | `PlanLayer` | `` | `` |
| `GetProfileLayer` | `ProfileCompoundLayer` | `` | `` |
| `GetProfileWindow` | `IFramableDocumentWindow` | `` | `` |
| `GetSurfaces` | `List<KeyValuePair<String Surface>>` | `PipeNetwork pipeNetwork, IList<String> surfaceIDs` | `` |
| `PrepareGeology` | `Void` | `IDictionary<String Object> dataManager, PipeNetwork network, ProfileNetworkCachesDictionary cachesDict, PnLine line` | `` |
| `RefreshAllPipesLeader` | `Void` | `` | `` |
| `TryGetPipe` | `Boolean` | `PnLine line, Double station, ref PnSegment pipe` | `` |
| `TryGetPlanCadViewIfNull` | `Boolean` | `ref CadView cadView` | `` |

### `SurfaceFill` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.SurfaceFill` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Pipes.Runtime.SurfaceFill`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcComplexLandAllotment` | `Boolean` | `List<ZoneContours> zones, ref List<List<Vector2D>> resultContours, ref List<List<Vector2D>> trims` | `` |
| `CalcComplexLineStrip` | `Void` | `List<List<Vector2D>> inputContours, List<ZoneContours> zones, ref List<Vector2F> parentStrip, ref Vector2D pivot` | `` |
| `CalcSimpleLineStrips` | `Void` | `List<List<Vector2D>> inputContours, List<List<Vector2D>> trimContours, ref List<Vector2F> parentStrip, ref List<Vector2F> trimStrip, ref Vector2D pivot` | `` |
| `CalcSimpleParentContours` | `Boolean` | `List<List<Vector2D>> inputContours, List<List<Vector2D>> trimContours, ref List<List<Vector2D>> resultContours, ref List<List<Vector2D>> trims` | `` |

### `ZoneContours` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ZoneContours` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(List<List<Vector2D>> contours)`

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Contours` | `List<List<Vector2D>>` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Runtime.Communication`

### `PipeNetworkCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Communication.PipeNetworkCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double station, Double elevation, PnSegment pipe, Shell shell)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `Elevation` | `Double` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `PipeNetworkLayoutCrutchCommunications` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Communication.PipeNetworkLayoutCrutchCommunications` |
| **Base Type** | `Topomatic.Alg.Runtime.Communications.Communications` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.ILinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Runtime.Communications.Communications`
      - `Topomatic.Pipes.Runtime.Communication.PipeNetworkLayoutCrutchCommunications`

#### Constructors (1)

- `.ctor(PnLine pnLine, ProfileNodeCacheDict nodeCacheDict)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Double` | `Double station` | `` |
| `GetIntersections` | `Void` | `Vector2D a, Vector2D b, IList<Double> stations` | `` |
| `GetIntersections` | `Void` | `Vector2D center, Double radius, Double sangle, Double eangle, IList<Double> stations` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `StationToPos` | `Vector2D` | `Double station` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `ILinearObject` | `GetPolyline` |

---
## Namespace: `Topomatic.Pipes.Runtime.ContourInfo`

### `AlgInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.AlgInfo` |
| **Base Type** | `Topomatic.Pipes.Runtime.ContourInfo.LineInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Runtime.ContourInfo.LineInfo`
    - `Topomatic.Pipes.Runtime.ContourInfo.AlgInfo`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String relativePath, Boolean closed, AxleType axleType)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `Axle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.Axle` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(List<BugleVector2D> positions, Double offset)`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Offset` | `Double` | No | `` | `` |
| `ParentPositions` | `List<BugleVector2D>` | No | `` | `` |
| `Positions` | `List<Vector2D>` | No | `` | `` |

### `AxleType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.AxleType` |
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
      - `Topomatic.Pipes.Runtime.ContourInfo.AxleType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Including` | `AxleType` | Yes | `Including` | `` |
| `Parent` | `AxleType` | Yes | `Parent` | `` |
| `Trim` | `AxleType` | Yes | `Trim` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Zone` | `AxleType` | Yes | `Zone` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Parent` | `0` |
| `Including` | `1` |
| `Trim` | `2` |
| `Zone` | `3` |

**Underlying Type**: `System.Int32`

### `CopyGeometryInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.CopyGeometryInfo` |
| **Base Type** | `Topomatic.Pipes.Runtime.ContourInfo.LineInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Runtime.ContourInfo.LineInfo`
    - `Topomatic.Pipes.Runtime.ContourInfo.CopyGeometryInfo`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String relativePath, Boolean closed, AxleType axleType)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `DwgPolylineInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.DwgPolylineInfo` |
| **Base Type** | `Topomatic.Pipes.Runtime.ContourInfo.LineInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Runtime.ContourInfo.LineInfo`
    - `Topomatic.Pipes.Runtime.ContourInfo.DwgPolylineInfo`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String relativePath, UInt32 DwgObjectId, Boolean closed, AxleType axleType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `LineInfo info` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `InfoType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.InfoType` |
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
      - `Topomatic.Pipes.Runtime.ContourInfo.InfoType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Alignment` | `InfoType` | Yes | `Alignment` | `` |
| `CopyGeometry` | `InfoType` | Yes | `CopyGeometry` | `` |
| `DwgPolyline` | `InfoType` | Yes | `DwgPolyline` | `` |
| `LandAllotmentZone` | `InfoType` | Yes | `LandAllotmentZone` | `` |
| `PnLine` | `InfoType` | Yes | `PnLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Alignment` | `0` |
| `DwgPolyline` | `1` |
| `PnLine` | `2` |
| `CopyGeometry` | `3` |
| `LandAllotmentZone` | `4` |

**Underlying Type**: `System.Int32`

### `LineInfo` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.LineInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String relativePath, Boolean closed, InfoType contourType, AxleType axleType)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Axis` | `List<Axle>` | `get` | No | `` |
| `AxleType` | `AxleType` | `get/set` | No | `` |
| `ContourType` | `InfoType` | `get` | No | `` |
| `RelativePath` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `LineInfo info` | `` |
| `AssignAxis` | `Void` | `List<Axle> axis, Boolean closed` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsSimpleAxle` | `Boolean` | `LineInfo axle` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsClosed` | `Boolean` | No | `` | `` |
| `IsSavedGeometry` | `Boolean` | No | `` | `` |
| `m_AxleType` | `AxleType` | No | `` | `` |

### `PnLineInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.PnLineInfo` |
| **Base Type** | `Topomatic.Pipes.Runtime.ContourInfo.LineInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Runtime.ContourInfo.LineInfo`
    - `Topomatic.Pipes.Runtime.ContourInfo.PnLineInfo`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String relativePath, UInt32 Id, AxleType axleType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `LineInfo info` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `ZoneInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ContourInfo.ZoneInfo` |
| **Base Type** | `Topomatic.Pipes.Runtime.ContourInfo.LineInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Runtime.ContourInfo.LineInfo`
    - `Topomatic.Pipes.Runtime.ContourInfo.ZoneInfo`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String relativePath, UInt32 DwgObjectId, Boolean closed, AxleType axleType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `LineInfo info` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

---
## Namespace: `Topomatic.Pipes.Runtime.InvokeWrapper`

### `ActionInvokeArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.InvokeWrapper.ActionInvokeArgs` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView, PipeNetworkReceiver receiver, Object[] args)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Network` | `PipeNetwork` | `get` | No | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Args` | `Object[]` | No | `` | `` |
| `CadView` | `CadView` | No | `` | `` |
| `Receiver` | `PipeNetworkReceiver` | No | `` | `` |

### `ActionInvoker` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.InvokeWrapper.ActionInvoker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvokeControllerAction` | `Void` | `CadView cadView, Action<ActionInvokeArgs> action, Object[] args` | `` |
| `InvokeControllerAction` | `Void` | `CadView cadView, Action<ActionInvokeArgs> action` | `` |
| `InvokeControllerBoolAction` | `Void` | `CadView cadView, Func<ActionInvokeArgs Boolean> action, Object[] args` | `` |
| `InvokeControllerBoolAction` | `Void` | `CadView cadView, Func<ActionInvokeArgs Boolean> action` | `` |
| `InvokeStructureAction` | `Void` | `Object[] args, Func<ActionStructureArgs Boolean> action` | `` |

### `ActionStructureArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.InvokeWrapper.ActionStructureArgs` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork network, Boolean isActive)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsActive` | `Boolean` | No | `` | `` |
| `Network` | `PipeNetwork` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Runtime.Mockup`

### `PipeProfileMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Mockup.PipeProfileMockupLayer` |
| **Base Type** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`
        - `Topomatic.Pipes.Runtime.Mockup.PipeProfileMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanCrossMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Mockup.PlanCrossMockupLayer` |
| **Base Type** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`
        - `Topomatic.Pipes.Runtime.Mockup.PlanCrossMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Runtime.Plt`

### `PipeNetworkField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PipeNetworkField` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Pipes.Runtime.Plt.PipeNetworkField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalScale` | `Double` | `get` | No | `` |
| `VerticalOffset` | `Double` | `get` | No | `` |
| `VerticalScale` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeNetworkShaftField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PipeNetworkShaftField` |
| **Base Type** | `Topomatic.Pipes.Runtime.Plt.PipeNetworkField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Pipes.Runtime.Plt.PipeNetworkField`
      - `Topomatic.Pipes.Runtime.Plt.PipeNetworkShaftField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeNetworkTemplateDwgGenerator` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PipeNetworkTemplateDwgGenerator` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Pipes.Runtime.Plt.PipeNetworkTemplateDwgGenerator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

### `PltConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PltConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (19)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CROSS_CACHE_DICT` | `String` | Yes | `` | `` |
| `LINE_ID` | `String` | Yes | `` | `` |
| `NODE_ID` | `String` | Yes | `` | `` |
| `PIPE_INDEX` | `String` | Yes | `` | `` |
| `PIPE_NETWORK` | `String` | Yes | `` | `` |
| `PIPE_NETWORK_UID` | `String` | Yes | `` | `` |
| `PIPES_DICT` | `String` | Yes | `` | `` |
| `PLAN_NODES_CACHE_DICT` | `String` | Yes | `` | `` |
| `PROFILE_NODES_CACHE_DICT` | `String` | Yes | `` | `` |
| `PROFILE_STA` | `String` | Yes | `` | `` |
| `PROFILE_STEP` | `String` | Yes | `` | `` |
| `SEGMENT_CACHES_DICT` | `String` | Yes | `` | `` |
| `SFC_CACHE_DICT` | `String` | Yes | `` | `` |
| `SHEET_LINE_ID` | `String` | Yes | `` | `` |
| `SHEET_PIPE_DICTIONARY` | `String` | Yes | `` | `` |
| `SHEET_PIPE_ID` | `String` | Yes | `` | `` |
| `SHEETS` | `String` | Yes | `` | `` |
| `SHELLS_DICT` | `String` | Yes | `` | `` |
| `TYPE_DESCRIPTION` | `String` | Yes | `` | `` |

### `PltExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PltExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

---
## Namespace: `Topomatic.Pipes.Runtime.Plt.CommonFileds`

### `ScaleH` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.CommonFileds.ScaleH` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Pipes.Runtime.Plt.CommonFileds.ScaleH`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScaleV` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.CommonFileds.ScaleV` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Pipes.Runtime.Plt.CommonFileds.ScaleV`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Runtime.Plt.Fields.Profile`

### `FieldProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Fields.Profile.FieldProvider` |
| **Base Type** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.TemplateFieldProvider`
    - `Topomatic.Pipes.Runtime.Plt.Fields.Profile.FieldProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

### `PltCommonVariablesProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Fields.Profile.PltCommonVariablesProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Pipes.Runtime.Plt.Fields.Profile.PltCommonVariablesProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `ProfileTemplateDwgGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Fields.Profile.ProfileTemplateDwgGenerator` |
| **Base Type** | `Topomatic.Pipes.Runtime.Plt.PipeNetworkTemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Pipes.Runtime.Plt.PipeNetworkTemplateDwgGenerator`
        - `Topomatic.Pipes.Runtime.Plt.Fields.Profile.ProfileTemplateDwgGenerator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |
| `Sheets` | `IList<Int32>` | `get/set` | No | `` |

---
## Namespace: `Topomatic.Pipes.Runtime.Plt.PlanCross`

### `FieldProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.FieldProvider` |
| **Base Type** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.TemplateFieldProvider`
    - `Topomatic.Pipes.Runtime.Plt.PlanCross.FieldProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

### `LineSurfaceKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.LineSurfaceKey` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String relativePath, UInt32 lineId)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LineId` | `UInt32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ModelUid` | `String` | No | `` | `` |

### `PlanCrossDwgGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.PlanCrossDwgGenerator` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Pipes.Runtime.Plt.PlanCross.PlanCrossDwgGenerator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |
| `PlanCrossItems` | `List<PlanCrossSurfaceData>` | `get/set` | No | `` |

### `PlanCrossPltConsts` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.PlanCrossPltConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (31)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LINE_SURFACE_DICT` | `String` | Yes | `"LINE_SURFACE_DICT"` | `` |
| `ONE_CROSS_ON_DRAWING` | `String` | Yes | `"ONE_CROSS_ON_DRAWING"` | `` |
| `PADDING_BOT` | `String` | Yes | `"PADDING_BOT"` | `` |
| `PADDING_LEFT` | `String` | Yes | `"PADDING_LEFT"` | `` |
| `PADDING_RIGHT` | `String` | Yes | `"PADDING_RIGHT"` | `` |
| `PADDING_TOP` | `String` | Yes | `"PADDING_TOP"` | `` |
| `PaddingBottom` | `String` | Yes | `"PaddingBottom"` | `` |
| `PaddingLeft` | `String` | Yes | `"PaddingLeft"` | `` |
| `PaddingRight` | `String` | Yes | `"PaddingRight"` | `` |
| `PaddingTop` | `String` | Yes | `"PaddingTop"` | `` |
| `PLAN_CROSS_INDEX` | `String` | Yes | `"PLAN_CROSS_INDEX"` | `` |
| `PLAN_CROSS_ITEM` | `String` | Yes | `"PLAN_CROSS_ITEM"` | `` |
| `PLAN_CROSS_ITEMS` | `String` | Yes | `"PLAN_CROSS_ITEMS"` | `` |
| `PLAN_CROSS_TITLE_NAME` | `String` | Yes | `"NAME"` | `` |
| `PLAN_PNLINE_CROSS_CACHE_DICT` | `String` | Yes | `"PLAN_PNLINE_CROSS_CACHE_DICT"` | `` |
| `ProfileEndStation` | `String` | Yes | `"ProfileEndStation"` | `` |
| `ProfileStartStation` | `String` | Yes | `"ProfileStartStation"` | `` |
| `ProfileWidth` | `String` | Yes | `"ProfileWidth"` | `` |
| `SCALE` | `String` | Yes | `"SCALE"` | `` |
| `SCALES` | `Double[]` | Yes | `` | `` |
| `SectionEndStation` | `String` | Yes | `"SectionEndStation"` | `` |
| `SectionStartStation` | `String` | Yes | `"SectionStartStation"` | `` |
| `SectionWidth` | `String` | Yes | `"SectionWidth"` | `` |
| `SheetHeightFirst` | `String` | Yes | `"LV1"` | `` |
| `SheetHeightSecond` | `String` | Yes | `"LV2"` | `` |
| `SheetWidthFirst` | `String` | Yes | `"LH1"` | `` |
| `SheetWidthSecond` | `String` | Yes | `"LH2"` | `` |
| `SpaceBeetwinDrawings` | `String` | Yes | `"SpaceBeetwinDrawings"` | `` |
| `TemplateFirst` | `String` | Yes | `"LT1"` | `` |
| `TemplateSecond` | `String` | Yes | `"LT2"` | `` |
| `TEXT_HEIGHT_SCALE` | `String` | Yes | `"TEXT_HEIGHT_SCALE"` | `` |

### `PlanCrossSurfaceData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.PlanCrossSurfaceData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnEiPlanCrossAtPipeKey key, PnEiPlanCrossAtPipeItem item, IList<LineSurfacePoint> profilePg, IList<LineSurfacePoint> profileEg, IList<LineSurfacePoint> sectionPg, IList<LineSurfacePoint> sectionEg, PlanCrossCacheData dataCahe, Double profileWidth, Double sectionWidth, String name)`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Item` | `PnEiPlanCrossAtPipeItem` | No | `` | `` |
| `Key` | `PnEiPlanCrossAtPipeKey` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `PlanCrossPipeDataCache` | `PlanCrossCacheData` | No | `` | `` |
| `ProfileEg` | `IList<LineSurfacePoint>` | No | `` | `` |
| `ProfilePg` | `IList<LineSurfacePoint>` | No | `` | `` |
| `ProfileWidth` | `Double` | No | `` | `` |
| `SectionEg` | `IList<LineSurfacePoint>` | No | `` | `` |
| `SectionPg` | `IList<LineSurfacePoint>` | No | `` | `` |
| `SectionWidth` | `Double` | No | `` | `` |

### `PlanCrossTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.PlanCrossTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckPipeInLineStartStationAndEndStation` | `Void` | `PnSegment pipe, ref Double ss, ref Double es` | `` |
| `CheckPipeStartStationAndEndStation` | `Void` | `PnSegment pipe, ref Double ss, ref Double es` | `` |
| `GetPlanCrossItems` | `List<PlanCrossSurfaceData>` | `PipeNetwork pipeNetwork` | `` |

### `VariablesProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.VariablesProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Pipes.Runtime.Plt.PlanCross.VariablesProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

---
## Namespace: `Topomatic.Pipes.Runtime.Plt.PlanCross.DescrEnumConverters`

### `ElevationPipeProfileEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.DescrEnumConverters.ElevationPipeProfileEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.PlanCross.DescrEnumConverters.ElevationPipeProfileEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PIPE_BOT_INNER` | `ElevationPipeProfileEnum` | Yes | `PIPE_BOT_INNER` | `` |
| `PIPE_BOT_OUTER` | `ElevationPipeProfileEnum` | Yes | `PIPE_BOT_OUTER` | `` |
| `PIPE_CP` | `ElevationPipeProfileEnum` | Yes | `PIPE_CP` | `` |
| `PIPE_MIDDLE` | `ElevationPipeProfileEnum` | Yes | `PIPE_MIDDLE` | `` |
| `PIPE_TOP_INNER` | `ElevationPipeProfileEnum` | Yes | `PIPE_TOP_INNER` | `` |
| `PIPE_TOP_OUTER` | `ElevationPipeProfileEnum` | Yes | `PIPE_TOP_OUTER` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PIPE_CP` | `0` |
| `PIPE_TOP_OUTER` | `1` |
| `PIPE_TOP_INNER` | `2` |
| `PIPE_MIDDLE` | `3` |
| `PIPE_BOT_INNER` | `4` |
| `PIPE_BOT_OUTER` | `5` |

**Underlying Type**: `System.Int32`

### `ElevationSourcePipeEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.DescrEnumConverters.ElevationSourcePipeEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.PlanCross.DescrEnumConverters.ElevationSourcePipeEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CROSS` | `ElevationSourcePipeEnum` | Yes | `CROSS` | `` |
| `MAIN` | `ElevationSourcePipeEnum` | Yes | `MAIN` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `MAIN` | `0` |
| `CROSS` | `1` |

**Underlying Type**: `System.Int32`

### `SurfaceEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.DescrEnumConverters.SurfaceEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.PlanCross.DescrEnumConverters.SurfaceEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EG` | `SurfaceEnum` | Yes | `EG` | `` |
| `PG` | `SurfaceEnum` | Yes | `PG` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `EG` | `0` |
| `PG` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Pipes.Runtime.Plt.PlanCross.Fields`

### `BasePlanCrossField` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.Fields.BasePlanCrossField` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Pipes.Runtime.Plt.PlanCross.Fields.BasePlanCrossField`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalScale` | `Double` | `get` | No | `` |
| `VerticalOffset` | `Double` | `get` | No | `` |
| `VerticalScale` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.PlanCross.Fields.PipeField` |
| **Base Type** | `Topomatic.Pipes.Runtime.Plt.PlanCross.Fields.BasePlanCrossField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Pipes.Runtime.Plt.PlanCross.Fields.BasePlanCrossField`
      - `Topomatic.Pipes.Runtime.Plt.PlanCross.Fields.PipeField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters`

### `DepthSourceEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.DepthSourceEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.DepthSourceEnum`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DITCH_BOT` | `DepthSourceEnum` | Yes | `DITCH_BOT` | `` |
| `NOMINAL_DITCH_BOT` | `DepthSourceEnum` | Yes | `NOMINAL_DITCH_BOT` | `` |
| `PIPE_BOT_INNER` | `DepthSourceEnum` | Yes | `PIPE_BOT_INNER` | `` |
| `PIPE_BOT_OUTER` | `DepthSourceEnum` | Yes | `PIPE_BOT_OUTER` | `` |
| `PIPE_MIDDLE` | `DepthSourceEnum` | Yes | `PIPE_MIDDLE` | `` |
| `PIPE_TOP_INNER` | `DepthSourceEnum` | Yes | `PIPE_TOP_INNER` | `` |
| `PIPE_TOP_OUTER` | `DepthSourceEnum` | Yes | `PIPE_TOP_OUTER` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PIPE_TOP_OUTER` | `0` |
| `PIPE_TOP_INNER` | `1` |
| `PIPE_MIDDLE` | `2` |
| `PIPE_BOT_INNER` | `3` |
| `PIPE_BOT_OUTER` | `4` |
| `NOMINAL_DITCH_BOT` | `5` |
| `DITCH_BOT` | `6` |

**Underlying Type**: `System.Int32`

### `DepthSurfaceEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.DepthSurfaceEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.DepthSurfaceEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EG` | `DepthSurfaceEnum` | Yes | `EG` | `` |
| `PG` | `DepthSurfaceEnum` | Yes | `PG` | `` |
| `PG_AND_EG` | `DepthSurfaceEnum` | Yes | `PG_AND_EG` | `` |
| `PG_EG` | `DepthSurfaceEnum` | Yes | `PG_EG` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PG_EG` | `0` |
| `EG` | `1` |
| `PG` | `2` |
| `PG_AND_EG` | `3` |

**Underlying Type**: `System.Int32`

### `ElevationSourceEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.ElevationSourceEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.ElevationSourceEnum`

#### Fields (23)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DICTH_BOT` | `ElevationSourceEnum` | Yes | `DICTH_BOT` | `` |
| `EG` | `ElevationSourceEnum` | Yes | `EG` | `` |
| `NOMINAL_DITCH_BOT` | `ElevationSourceEnum` | Yes | `NOMINAL_DITCH_BOT` | `` |
| `PG` | `ElevationSourceEnum` | Yes | `PG` | `` |
| `PIPE_BOT_INNER` | `ElevationSourceEnum` | Yes | `PIPE_BOT_INNER` | `` |
| `PIPE_BOT_OUTER` | `ElevationSourceEnum` | Yes | `PIPE_BOT_OUTER` | `` |
| `PIPE_MIDDLE` | `ElevationSourceEnum` | Yes | `PIPE_MIDDLE` | `` |
| `PIPE_TOP_INNER` | `ElevationSourceEnum` | Yes | `PIPE_TOP_INNER` | `` |
| `PIPE_TOP_OUTER` | `ElevationSourceEnum` | Yes | `PIPE_TOP_OUTER` | `` |
| `SEGMENT_CRS_USER_PROFILE` | `ElevationSourceEnum` | Yes | `SEGMENT_CRS_USER_PROFILE` | `` |
| `SEGMENT_PROFILE_1` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_1` | `` |
| `SEGMENT_PROFILE_10` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_10` | `` |
| `SEGMENT_PROFILE_2` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_2` | `` |
| `SEGMENT_PROFILE_3` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_3` | `` |
| `SEGMENT_PROFILE_4` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_4` | `` |
| `SEGMENT_PROFILE_5` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_5` | `` |
| `SEGMENT_PROFILE_6` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_6` | `` |
| `SEGMENT_PROFILE_7` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_7` | `` |
| `SEGMENT_PROFILE_8` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_8` | `` |
| `SEGMENT_PROFILE_9` | `ElevationSourceEnum` | Yes | `SEGMENT_PROFILE_9` | `` |
| `SHAFT_BOT` | `ElevationSourceEnum` | Yes | `SHAFT_BOT` | `` |
| `SHAFT_TOP` | `ElevationSourceEnum` | Yes | `SHAFT_TOP` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PIPE_TOP_OUTER` | `0` |
| `PIPE_TOP_INNER` | `1` |
| `PIPE_MIDDLE` | `2` |
| `PIPE_BOT_INNER` | `3` |
| `PIPE_BOT_OUTER` | `4` |
| `EG` | `5` |
| `PG` | `6` |
| `NOMINAL_DITCH_BOT` | `7` |
| `SHAFT_TOP` | `8` |
| `SHAFT_BOT` | `9` |
| `SEGMENT_CRS_USER_PROFILE` | `10` |
| `DICTH_BOT` | `11` |
| `SEGMENT_PROFILE_1` | `20` |
| `SEGMENT_PROFILE_2` | `21` |
| `SEGMENT_PROFILE_3` | `22` |
| `SEGMENT_PROFILE_4` | `23` |
| `SEGMENT_PROFILE_5` | `24` |
| `SEGMENT_PROFILE_6` | `25` |
| `SEGMENT_PROFILE_7` | `26` |
| `SEGMENT_PROFILE_8` | `27` |
| `SEGMENT_PROFILE_9` | `28` |
| `SEGMENT_PROFILE_10` | `29` |

**Underlying Type**: `System.Int32`

### `GradeLengthEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.GradeLengthEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.GradeLengthEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LENGTH2D` | `GradeLengthEnum` | Yes | `LENGTH2D` | `` |
| `LENGTH3D` | `GradeLengthEnum` | Yes | `LENGTH3D` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LENGTH2D` | `0` |
| `LENGTH3D` | `1` |

**Underlying Type**: `System.Int32`

### `GradeLengthEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.GradeLengthEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.GradeLengthEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GradeSourceEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.GradeSourceEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.GradeSourceEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EG` | `GradeSourceEnum` | Yes | `EG` | `` |
| `PG` | `GradeSourceEnum` | Yes | `PG` | `` |
| `PIPE_MIDDLE` | `GradeSourceEnum` | Yes | `PIPE_MIDDLE` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PIPE_MIDDLE` | `0` |
| `EG` | `1` |
| `PG` | `2` |

**Underlying Type**: `System.Int32`

### `LengthGradeFormatEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.LengthGradeFormatEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.LengthGradeFormatEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FULL` | `LengthGradeFormatEnum` | Yes | `FULL` | `` |
| `PERMILLE` | `LengthGradeFormatEnum` | Yes | `PERMILLE` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PERMILLE` | `0` |
| `FULL` | `1` |

**Underlying Type**: `System.Int32`

### `LengthGradeFormatEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.LengthGradeFormatEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.LengthGradeFormatEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `LengthSourceEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.LengthSourceEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.LengthSourceEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EG` | `LengthSourceEnum` | Yes | `EG` | `` |
| `PG` | `LengthSourceEnum` | Yes | `PG` | `` |
| `PIPE_MIDDLE` | `LengthSourceEnum` | Yes | `PIPE_MIDDLE` | `` |
| `PIPE_MIDDLE_CROSS` | `LengthSourceEnum` | Yes | `PIPE_MIDDLE_CROSS` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PIPE_MIDDLE` | `0` |
| `PIPE_MIDDLE_CROSS` | `1` |
| `EG` | `2` |
| `PG` | `3` |

**Underlying Type**: `System.Int32`

### `PipeNameLengthEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.PipeNameLengthEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.PipeNameLengthEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NO_LENGTH` | `PipeNameLengthEnum` | Yes | `NO_LENGTH` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WITH_LENGTH` | `PipeNameLengthEnum` | Yes | `WITH_LENGTH` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NO_LENGTH` | `0` |
| `WITH_LENGTH` | `1` |

**Underlying Type**: `System.Int32`

### `SurfaceSourceEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.SurfaceSourceEnum` |
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
      - `Topomatic.Pipes.Runtime.Plt.Profile.DescrEnumConverters.SurfaceSourceEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CR` | `SurfaceSourceEnum` | Yes | `CR` | `` |
| `EG` | `SurfaceSourceEnum` | Yes | `EG` | `` |
| `FD` | `SurfaceSourceEnum` | Yes | `FD` | `` |
| `PG` | `SurfaceSourceEnum` | Yes | `PG` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `EG` | `0` |
| `PG` | `1` |
| `CR` | `2` |
| `FD` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Pipes.Runtime.ServiceClasses`

### `PipeNetworkReceiver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ServiceClasses.PipeNetworkReceiver` |
| **Base Type** | `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver`
    - `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver`
      - `Topomatic.Pipes.Runtime.ServiceClasses.PipeNetworkReceiver`

#### Constructors (1)

- `.ctor(Boolean readOnly)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `RailContactNetworkModelsResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Runtime.ServiceClasses.RailContactNetworkModelsResolver` |
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
| `FillBasisInfo` | `Boolean` | `IModelFinder modelFinder, Object obj, Vector2D pos, ref BasisPointInfo info` | `` |
| `GetAlignmentById` | `Boolean` | `IModelFinder modelFinder, String id, ref Alignment alignment` | `` |
| `GetNetworkFromObject` | `PipeNetwork` | `Object obj` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 65 |
| **Classes** | 39 |
| **Interfaces** | 0 |
| **Enums** | 16 |
| **Structs** | 1 |
| **Abstract Classes** | 3 |
| **Static Classes** | 6 |
| **Total Methods** | 112 |
| **Total Properties** | 76 |
| **Total Fields** | 186 |
| **Total Events** | 0 |
| **Total Constructors** | 50 |
| **Nested Types** | 3 |
| **Extension Methods** | 0 |


