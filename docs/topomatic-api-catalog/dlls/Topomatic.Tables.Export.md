# Topomatic.Tables.Export

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Tables.Export` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Tables.Export, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Tables.Export.dll` |

---
## Namespace: `Topomatic.Dwg`

### `BorderSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.DwgTableCellBordersStyle+BorderSide` |
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
      - `Topomatic.Dwg.DwgTableCellBordersStyle+BorderSide`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `BorderSide` | Yes | `Bottom` | `` |
| `Left` | `BorderSide` | Yes | `Left` | `` |
| `Right` | `BorderSide` | Yes | `Right` | `` |
| `Top` | `BorderSide` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Top` | `1` |
| `Bottom` | `2` |
| `Left` | `4` |
| `Right` | `8` |

**Underlying Type**: `System.Int32`

### `CellStyleOverrideFlags` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.CellStyleOverrideFlags` |
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
      - `Topomatic.Dwg.CellStyleOverrideFlags`

#### Fields (18)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BackgroundColorEnabled` | `CellStyleOverrideFlags` | Yes | `BackgroundColorEnabled` | `` |
| `Bold` | `CellStyleOverrideFlags` | Yes | `Bold` | `` |
| `BottomBorder` | `CellStyleOverrideFlags` | Yes | `BottomBorder` | `` |
| `FillColor` | `CellStyleOverrideFlags` | Yes | `FillColor` | `` |
| `FloatDisplayStyleDigits` | `CellStyleOverrideFlags` | Yes | `FloatDisplayStyleDigits` | `` |
| `HorizontalField` | `CellStyleOverrideFlags` | Yes | `HorizontalField` | `` |
| `Italic` | `CellStyleOverrideFlags` | Yes | `Italic` | `` |
| `LeftBorder` | `CellStyleOverrideFlags` | Yes | `LeftBorder` | `` |
| `PreferableDisplayStyle` | `CellStyleOverrideFlags` | Yes | `PreferableDisplayStyle` | `` |
| `RightBorder` | `CellStyleOverrideFlags` | Yes | `RightBorder` | `` |
| `TextAngle` | `CellStyleOverrideFlags` | Yes | `TextAngle` | `` |
| `TextColor` | `CellStyleOverrideFlags` | Yes | `TextColor` | `` |
| `TextHeight` | `CellStyleOverrideFlags` | Yes | `TextHeight` | `` |
| `TextJustify` | `CellStyleOverrideFlags` | Yes | `TextJustify` | `` |
| `TextStyle` | `CellStyleOverrideFlags` | Yes | `TextStyle` | `` |
| `TopBorder` | `CellStyleOverrideFlags` | Yes | `TopBorder` | `` |
| `value__` | `Int32` | No | `` | `` |
| `VerticalField` | `CellStyleOverrideFlags` | Yes | `VerticalField` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TopBorder` | `1` |
| `BottomBorder` | `2` |
| `LeftBorder` | `4` |
| `RightBorder` | `8` |
| `TextStyle` | `16` |
| `TextHeight` | `32` |
| `TextAngle` | `64` |
| `TextColor` | `128` |
| `TextJustify` | `256` |
| `FillColor` | `512` |
| `BackgroundColorEnabled` | `1024` |
| `VerticalField` | `2048` |
| `HorizontalField` | `4096` |
| `PreferableDisplayStyle` | `8192` |
| `FloatDisplayStyleDigits` | `16384` |
| `Bold` | `32768` |
| `Italic` | `65536` |

**Underlying Type**: `System.Int32`

### `DwgTableBreakDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.DwgTableBreakDirection` |
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
      - `Topomatic.Dwg.DwgTableBreakDirection`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `DwgTableBreakDirection` | Yes | `Bottom` | `` |
| `Left` | `DwgTableBreakDirection` | Yes | `Left` | `` |
| `Right` | `DwgTableBreakDirection` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Right` | `0` |
| `Left` | `1` |
| `Bottom` | `2` |

**Underlying Type**: `System.Int32`

### `DwgTableBreakDirectionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.DwgTableBreakDirectionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Dwg.DwgTableBreakDirectionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DwgTableCellBordersStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.DwgTableCellBordersStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorCellBorderStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DwgTableCell parent, BorderSide borderSide)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `DoubleBorders` | `Boolean` | `get/set` | No | `` |
| `IsVisible` | `Boolean` | `get/set` | No | `` |
| `Linetype` | `DwgLinetype` | `get/set` | No | `` |
| `Lineweight` | `Lineweight` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Copy` | `Void` | `DwgTableCellBordersStyle borderStyle` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `BorderSide` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISheetEditorCellBorderStyle` | `get_Color` |
| `ISheetEditorCellBorderStyle` | `set_Color` |
| `ISheetEditorCellBorderStyle` | `Topomatic.Tables.ISheetEditorCellBorderStyle.get_Lineweight` |
| `ISheetEditorCellBorderStyle` | `Topomatic.Tables.ISheetEditorCellBorderStyle.set_Lineweight` |

### `DwgTableCellStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.DwgTableCellStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorCellStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DwgTableCell cell)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackGroundColorEnabled` | `Boolean` | `get/set` | No | `` |
| `Bold` | `Boolean` | `get/set` | No | `` |
| `BorderStyleBottom` | `DwgTableCellBordersStyle` | `get` | No | `` |
| `BorderStyleLeft` | `DwgTableCellBordersStyle` | `get` | No | `` |
| `BorderStyleRight` | `DwgTableCellBordersStyle` | `get` | No | `` |
| `BorderStyleTop` | `DwgTableCellBordersStyle` | `get` | No | `` |
| `FillColor` | `CadColor` | `get/set` | No | `` |
| `FloatDisplayStyleDigits` | `Int32` | `get/set` | No | `` |
| `HorizontalField` | `Double` | `get/set` | No | `` |
| `Italic` | `Boolean` | `get/set` | No | `` |
| `PreferableDisplayStyle` | `TableCellPreferableDisplayStyle` | `get/set` | No | `` |
| `TextAngle` | `Double` | `get/set` | No | `` |
| `TextColor` | `CadColor` | `get/set` | No | `` |
| `TextHeight` | `Double` | `get/set` | No | `` |
| `TextJustify` | `TextJustify` | `get/set` | No | `` |
| `TextStyle` | `DwgStyle` | `get` | No | `` |
| `TextStyleName` | `String` | `get/set` | No | `` |
| `VerticalField` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Copy` | `Void` | `DwgTableCellStyle cellStyle` | `` |
| `CopyExtended` | `Void` | `DwgTableCellStyle cellStyle` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISheetEditorCellStyle` | `get_TextColor` |
| `ISheetEditorCellStyle` | `set_TextColor` |
| `ISheetEditorCellStyle` | `get_TextHeight` |
| `ISheetEditorCellStyle` | `set_TextHeight` |
| `ISheetEditorCellStyle` | `get_TextJustify` |
| `ISheetEditorCellStyle` | `set_TextJustify` |
| `ISheetEditorCellStyle` | `get_Bold` |
| `ISheetEditorCellStyle` | `set_Bold` |
| `ISheetEditorCellStyle` | `get_Italic` |
| `ISheetEditorCellStyle` | `set_Italic` |
| `ISheetEditorCellStyle` | `get_FillColor` |
| `ISheetEditorCellStyle` | `set_FillColor` |
| `ISheetEditorCellStyle` | `get_HorizontalField` |
| `ISheetEditorCellStyle` | `set_HorizontalField` |
| `ISheetEditorCellStyle` | `get_VerticalField` |
| `ISheetEditorCellStyle` | `set_VerticalField` |
| `ISheetEditorCellStyle` | `get_PreferableDisplayStyle` |
| `ISheetEditorCellStyle` | `set_PreferableDisplayStyle` |
| `ISheetEditorCellStyle` | `get_FloatDisplayStyleDigits` |
| `ISheetEditorCellStyle` | `set_FloatDisplayStyleDigits` |
| `ISheetEditorCellStyle` | `get_TextAngle` |
| `ISheetEditorCellStyle` | `set_TextAngle` |
| `ISheetEditorCellStyle` | `get_TextStyleName` |
| `ISheetEditorCellStyle` | `set_TextStyleName` |
| `ISheetEditorCellStyle` | `Topomatic.Tables.ISheetEditorCellStyle.get_BorderStyleTop` |
| `ISheetEditorCellStyle` | `Topomatic.Tables.ISheetEditorCellStyle.get_BorderStyleBottom` |
| `ISheetEditorCellStyle` | `Topomatic.Tables.ISheetEditorCellStyle.get_BorderStyleLeft` |
| `ISheetEditorCellStyle` | `Topomatic.Tables.ISheetEditorCellStyle.get_BorderStyleRight` |

### `DwgTableRowStyleCellsType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.DwgTableRowStyleCellsType` |
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
      - `Topomatic.Dwg.DwgTableRowStyleCellsType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByRowAndColumn` | `DwgTableRowStyleCellsType` | Yes | `ByRowAndColumn` | `` |
| `Different` | `DwgTableRowStyleCellsType` | Yes | `Different` | `` |
| `Same` | `DwgTableRowStyleCellsType` | Yes | `Same` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Same` | `0` |
| `Different` | `1` |
| `ByRowAndColumn` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Dwg.Entities`

### `DwgTable` (class)

**Attributes**: [DefaultMember, DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Entities.DwgTable` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgComplexEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Entities.DwgEntity, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Tables.ISheetEditorModel, Topomatic.Tables.ISheetEditorLayout` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Dwg.Entities.DwgComplexEntity`
        - `Topomatic.Dwg.Entities.DwgTable`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(DwgTableStyle dwgTableStyle)`
- `.ctor(DwgTableStyle dwgTableStyle, Int32 rowsCount, Int32 rowsHeight, Int32 columnsCount, Double columnWidth)`

#### Properties (32)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowCellsCalculations` | `Boolean` | `get/set` | No | `Browsable` |
| `BreakDirection` | `String` | `get/set` | No | `PropertyEditor` |
| `BreakHeaderRowsCount` | `Int32` | `get/set` | No | `` |
| `BreakHeaderRowsRealCount` | `Int32` | `get` | No | `Browsable` |
| `BreakHeight` | `Double` | `get/set` | No | `DefaultDouble` |
| `BreakInterval` | `Double` | `get/set` | No | `` |
| `BreakRows` | `Boolean` | `get/set` | No | `` |
| `BreakRowsCustomMode` | `Boolean` | `get/set` | No | `Browsable` |
| `Color` | `CadColor` | `get/set` | No | `Browsable` |
| `ColumnsCount` | `Int32` | `get` | No | `` |
| `DefaultColumnWidth` | `Double` | `get/set` | No | `Browsable` |
| `DefaultRowHeight` | `Int32` | `get/set` | No | `Browsable` |
| `Entities` | `EntityCollection<DwgEntity>` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `ForceRowAutoHeight` | `Boolean` | `get/set` | No | `Browsable` |
| `HeaderHeight` | `Double` | `get` | No | `Browsable` |
| `Height` | `Double` | `get` | No | `DefaultDouble` |
| `Item` | `DwgTableCell` | `get` | No | `` |
| `LinkedDataBlocks` | `List<DwgTableCellLinkedDataBlock>` | `get` | No | `Browsable` |
| `MergedBlocks` | `List<DwgTableCellMergedBlock>` | `get` | No | `Browsable` |
| `NotDisplayHighlights` | `Boolean` | `get/set` | No | `Browsable` |
| `NotRecalcCache` | `Boolean` | `get/set` | No | `Browsable` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `Browsable` |
| `Rotation` | `Double` | `get/set` | No | `DefaultDouble` |
| `RowsCount` | `Int32` | `get` | No | `` |
| `Scale` | `Vector3D` | `get/set` | No | `` |
| `SegmentsCount` | `Int32` | `get` | No | `Browsable` |
| `SegmentsHeight` | `Double` | `get` | No | `Browsable` |
| `SegmentsWidth` | `Double` | `get` | No | `Browsable` |
| `Style` | `DwgTableStyle` | `get/set` | No | `` |
| `Width` | `Double` | `get` | No | `DefaultDouble` |

#### Instance Methods (114)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddColumn` | `Void` | `` | `` |
| `AddColumn` | `Void` | `Double width` | `` |
| `AddLinkedDataBlock` | `Void` | `DwgTableCellLinkedDataBlock linkedDataBlock` | `` |
| `AddRow` | `Boolean` | `Int32 height, Boolean pureHeight` | `` |
| `AddRow` | `Boolean` | `Double pureHeight` | `` |
| `AddRow` | `Boolean` | `Int32 height` | `` |
| `AddRow` | `Boolean` | `` | `` |
| `AutoSizeColumns` | `Void` | `` | `` |
| `CadColorPrepareForExport` | `CadColor` | `CadColor cadColor` | `` |
| `CheckExpression` | `Boolean` | `Int32 rowIndex, Int32 columnIndex, Boolean isOperand, List<DwgTableCell> cells, ref ExpressionErrors err, CheckExpessionsMode checkMode` | `` |
| `CheckExpressions` | `Void` | `CheckExpessionsMode checkMode` | `` |
| `CheckExpressions` | `Void` | `` | `` |
| `CheckOperand` | `Boolean` | `PolandNotationOperand polandNotationOperand, List<DwgTableCell> cells, ref ExpressionErrors err, CheckExpessionsMode checkMode` | `` |
| `Drop` | `Void` | `` | `` |
| `EqualsData` | `Boolean` | `Table table` | `` |
| `ExportCellStyle` | `Void` | `TableCell destinationCell, Int32 rowIndex, Int32 columnIndex` | `` |
| `ExtractCellCode` | `Boolean` | `String text, ref Int32 rowIndex, ref Int32 columnIndex` | `` |
| `GetAreaPoints` | `Void` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2, Boolean transformed, ref Vector2D topLeftPoint, ref Vector2D topRightPoint, ref Vector2D bottomLeftPoint, ref Vector2D bottomRightPoint` | `` |
| `GetBold` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Boolean bold, ref Boolean isDifferent` | `` |
| `GetCellHeight` | `Double` | `Int32 r, Int32 c` | `` |
| `GetCellPoints` | `Void` | `Int32 r, Int32 c, Boolean transformed, ref Vector2D topLeftPoint, ref Vector2D topRightPoint, ref Vector2D bottomLeftPoint, ref Vector2D bottomRightPoint` | `` |
| `GetCellTextPosition` | `Vector3D` | `Int32 rowIndex, Int32 columnIndex, DwgMText mText` | `` |
| `GetCellTextPosition` | `Vector3D` | `Int32 rowIndex, Int32 columnIndex` | `` |
| `GetCellWidth` | `Double` | `Int32 r, Int32 c` | `` |
| `GetColumnAutoWidth` | `Boolean` | `Int32 columnIndex` | `` |
| `GetColumnEndOffset` | `Double` | `Int32 columnIndex` | `` |
| `GetColumnOffset` | `Double` | `Int32 columnIndex` | `` |
| `GetColumnTopLeftPosition` | `Vector3D` | `Int32 column, Int32 segment` | `` |
| `GetColumnTopRightPosition` | `Vector3D` | `Int32 column, Int32 segment` | `` |
| `GetColumnWidth` | `Double` | `Int32 columnIndex` | `` |
| `GetFillColor` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref CadColor fillColor, ref Boolean isDifferent` | `` |
| `GetHorizontalField` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double horizontalField, ref Boolean isDifferent` | `` |
| `GetItalic` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Boolean italic, ref Boolean isDifferent` | `` |
| `GetMinimumSegmentHeightForRow` | `Int32` | `Int32 rowIndex` | `` |
| `GetPreferableDisplayStyle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref TableCellPreferableDisplayStyle preferableDisplayStyle, ref Boolean isDifferent` | `` |
| `GetPreferableDisplayStyleDigits` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Int32 preferableDisplayStyleDigits, ref Boolean isDifferent` | `` |
| `GetPrevUnhideColumn` | `Int32` | `Int32 columnIndex` | `` |
| `GetPrevUnhidedRow` | `Int32` | `Int32 rowIndex` | `` |
| `GetRowAutoHeight` | `Boolean` | `Int32 rowIndex` | `` |
| `GetRowBottomLeftPosition` | `Vector3D` | `Int32 r` | `` |
| `GetRowBreakOffset` | `Void` | `Int32 r, ref Double dX, ref Double dY` | `` |
| `GetRowEndOffset` | `Double` | `Int32 rowIndex` | `` |
| `GetRowHeight` | `Double` | `Int32 rowIndex` | `` |
| `GetRowOffset` | `Double` | `Int32 rowIndex` | `` |
| `GetRowPositionInSegment` | `Int32` | `Int32 rowIndex` | `` |
| `GetRowStyle` | `DwgTableRowStyle` | `Int32 rowIndex` | `` |
| `GetRowStyle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref DwgTableRowStyle rowStyle, ref DwgTableRowStyleCellsType type` | `` |
| `GetRowTopLeftPosition` | `Vector3D` | `Int32 r` | `` |
| `GetSegmentBounds` | `BoundingBox2D` | `Int32 s` | `` |
| `GetSegmentByRowIndex` | `Int32` | `Int32 r` | `` |
| `GetSegmentFirstRow` | `Int32` | `Int32 segment` | `` |
| `GetSegmentHeight` | `Double` | `Int32 s` | `` |
| `GetSegmentLastRow` | `Int32` | `Int32 segment` | `` |
| `GetSegmentPosition` | `Vector3D` | `Int32 s, Boolean transformed` | `` |
| `GetTextAngle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double textAngle, ref Boolean isDifferent` | `` |
| `GetTextColor` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref CadColor textColor, ref Boolean isDifferent` | `` |
| `GetTextHeight` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double textHeight, ref Boolean isDifferent` | `` |
| `GetTextJustify` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref TextJustify textJustify, ref Boolean isDifferent` | `` |
| `GetTextStyle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref String textStyle, ref Boolean isDifferent` | `` |
| `GetVerticalField` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double verticalField, ref Boolean isDifferent` | `` |
| `ImportCellStyle` | `Void` | `TableCell sourceCell, Int32 rowIndex, Int32 columnIndex` | `` |
| `IndexOfCellByPosition` | `Int32` | `Double x, Double y, ref Int32 segment` | `` |
| `IndexOfCellByPosition` | `Int32` | `Double x, Double y` | `` |
| `IndexOfCellByPosition_IgnoreBreaking` | `Int32` | `Double x, Double y` | `` |
| `InsertColumn` | `Void` | `Int32 index` | `` |
| `InsertColumn` | `Void` | `Double width, Int32 index` | `` |
| `InsertRow` | `Void` | `Int32 height, Int32 index` | `` |
| `InsertRow` | `Void` | `Int32 index` | `` |
| `InsertTable` | `Void` | `DwgTable dwgTable, Int32 rowIndex, Int32 columnIndex, List<Int32> handledCells, Boolean overrideStyles` | `` |
| `IsColumnHidden` | `Boolean` | `Int32 columnIndex` | `` |
| `IsRowHidden` | `Boolean` | `Int32 rowIndex` | `` |
| `LineweightPrepareForExport` | `Lineweight` | `Lineweight lineweight` | `` |
| `LineweightToBorderWidth` | `Int32` | `Lineweight lineweight` | `` |
| `MergeCells` | `Boolean` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `` |
| `OptimizeCellStyles` | `Void` | `` | `` |
| `RecalcAllCaches` | `Void` | `` | `` |
| `RecalcAllCellsValues` | `Void` | `` | `` |
| `RecalcBordersCache` | `Void` | `Int32 rowIndex, Int32 columnIndex` | `` |
| `RecalcBordersCacheAll` | `Void` | `` | `` |
| `RecalcBordersCacheForCellGroup` | `Void` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `` |
| `RecalcBordersCacheForColumn` | `Void` | `Int32 columnIndex` | `` |
| `RecalcBordersCacheForRow` | `Void` | `Int32 rowIndex` | `` |
| `RecalcColumnsOffsetCache` | `Void` | `` | `` |
| `RecalcRowsOffsetCache` | `Void` | `` | `` |
| `RecalcSegmentsCache` | `Void` | `Int32[] breakRowsIndexes` | `` |
| `RecalcSegmentsCache` | `Void` | `` | `` |
| `ReCalcTextHeight` | `Void` | `Int32 row, Int32 column, Boolean notRecalcCaches` | `` |
| `ReCalcTextHeight` | `Void` | `Int32 row, Int32 column` | `` |
| `RemoveColumn` | `Void` | `` | `` |
| `RemoveColumnAt` | `Void` | `Int32 index` | `` |
| `RemoveRow` | `Void` | `` | `` |
| `RemoveRowAt` | `Void` | `Int32 index` | `` |
| `ResetAllHighlightCells` | `Void` | `` | `` |
| `ResetRowStyle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2` | `` |
| `SetBorderStyles` | `Void` | `DwgTableRowStyle rowStyle, List<DwgTableBorderStyleGroup> borders, Int32 Y1, Int32 X1, Int32 Y2, Int32 X2` | `` |
| `SetColumnAutoWidth` | `Void` | `Int32 columnIndex, Boolean value` | `` |
| `SetColumnHidden` | `Void` | `Int32 columnIndex, Boolean hidden` | `` |
| `SetColumnWidth` | `Void` | `Int32 columnIndex, Double value` | `` |
| `SetFillColor` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, CadColor color` | `` |
| `SetRowAutoHeight` | `Void` | `Int32 rowIndex, Boolean value` | `` |
| `SetRowHeight` | `Void` | `Int32 rowIndex, Double value` | `` |
| `SetRowHidden` | `Void` | `Int32 rowIndex, Boolean hidden` | `` |
| `SetRowStyle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, DwgTableRowStyle rowStyle` | `` |
| `SetRowStyle` | `Void` | `Int32 rowIndex, DwgTableRowStyle rowStyle` | `` |
| `SetSegmentEndRow` | `Void` | `Int32 segment, Int32 lastRow` | `` |
| `SetSegmentStartRow` | `Void` | `Int32 segment, Int32 startRow` | `` |
| `SetTextAngle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Double textAngle` | `` |
| `SetTextJustify` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, TextJustify textJustify` | `` |
| `ToString` | `String` | `` | `` |
| `ToTable` | `Void` | `Table table` | `` |
| `ToTable` | `Void` | `Table table, Single scale` | `` |
| `UnMergeAll` | `Void` | `Boolean recalcTextHeight` | `` |
| `UnmergeCells` | `Boolean` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `` |
| `UnsetHighlightColor` | `Void` | `Int32 rowIndex, Int32 columnIndex, CadColor color` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromTable` | `DwgTable` | `Drawing drawing, Table table` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MinColumnWidth` | `Int32` | Yes | `10` | `` |
| `MinRowHeight` | `Int32` | Yes | `5` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `ISheetEditorModel` | `Topomatic.Tables.ISheetEditorModel.get_Item` |
| `ISheetEditorModel` | `get_RowsCount` |
| `ISheetEditorModel` | `get_ColumnsCount` |
| `ISheetEditorModel` | `MergeCells` |
| `ISheetEditorModel` | `UnmergeCells` |
| `ISheetEditorModel` | `InsertRow` |
| `ISheetEditorModel` | `InsertColumn` |
| `ISheetEditorModel` | `RemoveRowAt` |
| `ISheetEditorModel` | `RemoveColumnAt` |
| `ISheetEditorLayout` | `GetRowHeight` |
| `ISheetEditorLayout` | `GetColumnWidth` |
| `ISheetEditorLayout` | `GetRowAutoHeight` |
| `ISheetEditorLayout` | `GetColumnAutoWidth` |
| `ISheetEditorLayout` | `Topomatic.Tables.ISheetEditorLayout.get_DefaultRowHeight` |
| `ISheetEditorLayout` | `get_DefaultColumnWidth` |
| `ISheetEditorLayout` | `get_Width` |
| `ISheetEditorLayout` | `get_Height` |
| `ISheetEditorLayout` | `GetColumnOffset` |
| `ISheetEditorLayout` | `GetRowOffset` |
| `ISheetEditorLayout` | `SetRowHeight` |
| `ISheetEditorLayout` | `SetColumnWidth` |
| `ISheetEditorLayout` | `SetColumnAutoWidth` |
| `ISheetEditorLayout` | `SetRowAutoHeight` |
| `ISheetEditorLayout` | `SetColumnHidden` |
| `ISheetEditorLayout` | `IsColumnHidden` |
| `ISheetEditorLayout` | `SetRowHidden` |
| `ISheetEditorLayout` | `IsRowHidden` |

### `DwgTableCell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Entities.DwgTableCell` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorCell` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(DwgTable dwgTable)`
- `.ctor(DwgTable parent, DwgTableCell cell)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Autofit` | `Boolean` | `get/set` | No | `` |
| `DwgMtext` | `DwgMText` | `get/set` | No | `` |
| `EdgeFlags` | `Byte` | `get/set` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `HighlightColor` | `CadColor` | `get/set` | No | `` |
| `IsHighlighted` | `Boolean` | `get` | No | `` |
| `MergeBlock` | `DwgTableCellMergedBlock` | `get/set` | No | `` |
| `Merged` | `Boolean` | `get/set` | No | `` |
| `MergedRootCell` | `DwgTableCell` | `get` | No | `` |
| `MergedX1` | `Int32` | `get` | No | `` |
| `MergedX2` | `Int32` | `get` | No | `` |
| `MergedY1` | `Int32` | `get` | No | `` |
| `MergedY2` | `Int32` | `get` | No | `` |
| `Parent` | `DwgTable` | `get` | No | `` |
| `RowStyle` | `DwgTableRowStyle` | `get/set` | No | `` |
| `SourceText` | `String` | `get/set` | No | `` |
| `Style` | `DwgTableCellStyle` | `get/set` | No | `` |
| `Text` | `String` | `get` | No | `` |
| `Width` | `Double` | `get` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculatePolandNotationExpression` | `Boolean` | `List<DwgTableCell> cells, ref Double result` | `` |
| `CalculateSUMM` | `Boolean` | `ref Double result` | `` |
| `GetFirstVisibleCellInBlock` | `Void` | `ref Int32 row, ref Int32 column` | `` |
| `HasOverrideFlags` | `Boolean` | `` | `` |
| `IsStyleOverrided` | `Boolean` | `CellStyleOverrideFlags flag` | `` |
| `LoadFromStg` | `Void` | `StgNode node, Int32 rowIndex, Int32 columnIndex` | `` |
| `RefreshBorders` | `Void` | `` | `` |
| `RefreshPreferableDisplayStyle` | `Void` | `` | `` |
| `RefreshStyle` | `Void` | `` | `` |
| `ResetHighlightColor` | `Void` | `CadColor highlightColor` | `` |
| `ResetHighlightColors` | `Void` | `` | `` |
| `ResetOverrideFlags` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetFlag` | `Void` | `CellStyleOverrideFlags flag, Boolean value` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_CachedColumn` | `Int32` | No | `` | `` |
| `m_CachedRow` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISheetEditorCell` | `get_MergedX1` |
| `ISheetEditorCell` | `get_MergedY1` |
| `ISheetEditorCell` | `get_MergedX2` |
| `ISheetEditorCell` | `get_MergedY2` |
| `ISheetEditorCell` | `get_SourceText` |
| `ISheetEditorCell` | `set_SourceText` |
| `ISheetEditorCell` | `get_Text` |
| `ISheetEditorCell` | `Topomatic.Tables.ISheetEditorCell.get_Style` |
| `ISheetEditorCell` | `get_IsHighlighted` |
| `ISheetEditorCell` | `get_HighlightColor` |
| `ISheetEditorCell` | `set_HighlightColor` |
| `ISheetEditorCell` | `ResetHighlightColor` |

### `DwgTableCellLinkedDataBlock` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Entities.DwgTableCellLinkedDataBlock` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgTableCellMergedBlock` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.Entities.DwgTableCellMergedBlock`
    - `Topomatic.Dwg.Entities.DwgTableCellLinkedDataBlock`

#### Constructors (3)

- `.ctor(DwgTable dwgTable)`
- `.ctor(DwgTable dwgTable, DwgTableCellLinkedDataBlock linkedDataBlock)`
- `.ctor(DwgTable dwgTable, DwgTableSourceData sourceData, Int32 x1, Int32 x2, Int32 y1, Int32 y2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HandledCells` | `List<Int32>` | `get` | No | `` |
| `SourceData` | `DwgTableSourceData` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `DwgTableCellMergedBlock` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Entities.DwgTableCellMergedBlock` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(DwgTableCellMergedBlock mergeBlock)`
- `.ctor(Int32 x1, Int32 x2, Int32 y1, Int32 y2)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Int32` | `get` | No | `` |
| `Width` | `Int32` | `get` | No | `` |
| `X1` | `Int32` | `get/set` | No | `` |
| `X2` | `Int32` | `get/set` | No | `` |
| `Y1` | `Int32` | `get/set` | No | `` |
| `Y2` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `DwgTableCellType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Entities.DwgTableCellType` |
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
      - `Topomatic.Dwg.Entities.DwgTableCellType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Block` | `DwgTableCellType` | Yes | `Block` | `` |
| `Text` | `DwgTableCellType` | Yes | `Text` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Text` | `1` |
| `Block` | `2` |

**Underlying Type**: `System.Int32`

### `MathOperator` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Entities.MathOperator` |
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
      - `Topomatic.Dwg.Entities.MathOperator`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Div` | `MathOperator` | Yes | `Div` | `` |
| `Minus` | `MathOperator` | Yes | `Minus` | `` |
| `Mult` | `MathOperator` | Yes | `Mult` | `` |
| `Plus` | `MathOperator` | Yes | `Plus` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Mult` | `42` |
| `Plus` | `43` |
| `Minus` | `45` |
| `Div` | `47` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Tables.Export`

### `DwgTableUtils` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.DwgTableUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DwgTableRefreshData` | `Void` | `DwgTable dwgTable` | `` |
| `DwgTablesRefreshDataForSheet` | `Void` | `IEnumerable<DwgTable> dwgTables` | `` |
| `GetModelById` | `IProjectModel` | `String modelId` | `` |
| `GetTableNameFromTemplate` | `String` | `DwgTable dwgTable` | `` |
| `GetTemplateFromTables` | `TemplateSheets` | `IEnumerable<DwgTable> dwgTables` | `` |
| `HasSource` | `Boolean` | `DwgTable dwgTable` | `` |
| `IsRefreshable` | `Boolean` | `DwgTable dwgTable` | `` |
| `NormalizeTables` | `Void` | `IEnumerable<DwgTable> dwgTables, Double distanceBetweenTables, Vector2D position, Double cadViewRotation` | `` |
| `NormalizeTables` | `Void` | `IEnumerable<DwgTable> dwgTables, Double distanceBetweenTables, Double cadViewRotation` | `` |
| `TemplatesSave` | `Void` | `IEnumerable<DwgTable> dwgTables` | `` |

### `TablesCSVExportService` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TablesCSVExportService` |
| **Base Type** | `Topomatic.Tables.Export.TablesExportService` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.TablesExportService`
    - `Topomatic.Tables.Export.TablesCSVExportService`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

### `TablesDrawingExportService` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TablesDrawingExportService` |
| **Base Type** | `Topomatic.Tables.Export.TablesExportService` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.TablesExportService`
    - `Topomatic.Tables.Export.TablesDrawingExportService`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ShowEnhancementSettings` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExportTable` | `Boolean` | `DwgBlock block, Table table, Double text_height, Double text_ratio, Double text_oblique` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

### `TablesDwgTableExportService` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TablesDwgTableExportService` |
| **Base Type** | `Topomatic.Tables.Export.TablesExportService` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.TablesExportService`
    - `Topomatic.Tables.Export.TablesDwgTableExportService`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DataSet` | `IDictionary<String TemplateSheetSymbols>` | `set` | No | `` |
| `DataStructure` | `IDictionary<String Dictionary<String List<String>>>` | `get/set` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `ModelType` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareData` | `Void` | `String modelId, String cmd, String[] prms, UserSheet sheet` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateTable` | `DwgTable` | `Table table, DwgTableStyle style, Drawing drawing, Int32 rowHeight, Double columnWidth` | `` |
| `RefreshDocument` | `Void` | `Table table, DwgTable dwgTable, IEnumerable<RowData> dataSet, TemplateSheet sheet, String[] rowIds` | `` |
| `RefreshTable` | `Boolean` | `Table table, DwgTable dwgTable` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

### `TablesExcelExportService` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TablesExcelExportService` |
| **Base Type** | `Topomatic.Tables.Export.TablesExportService` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.TablesExportService`
    - `Topomatic.Tables.Export.TablesExcelExportService`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

### `TablesExportService` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TablesExportService` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Guid id)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AbsoluteFilePath` | `Boolean` | `get/set` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Enable` | `Boolean` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `ModelType` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `URI` | `URI` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Export` | `Void` | `TablesDocument document` | `` |
| `PrepareData` | `Void` | `String modelId, String cmd, String[] args, UserSheet sheet` | `` |
| `ShowEnhancementSettings` | `Void` | `` | `` |

### `TablesExportServices` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TablesExportServices` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Tables.Export.TablesExportService, Topomatic.Tables.Export, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `TablesExportServices` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<TablesExportService>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `TablesOpenOfficeExportService` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TablesOpenOfficeExportService` |
| **Base Type** | `Topomatic.Tables.Export.TablesExportService` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.TablesExportService`
    - `Topomatic.Tables.Export.TablesOpenOfficeExportService`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

### `TemplateSheet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TemplateSheet` |
| **Base Type** | `Topomatic.Tables.Export.UserSheet` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.UserSheet`
    - `Topomatic.Tables.Export.TemplateSheet`

#### Constructors (1)

- `.ctor(String id, String caption, String fileName)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DataSet` | `IDictionary<String TemplateSheetSymbols>` | `get` | No | `` |
| `DataStructure` | `IDictionary<String Dictionary<String List<String>>>` | `get` | No | `` |
| `SelectedSheetIDs` | `String[]` | `get` | No | `` |
| `TemplateFileName` | `String` | `get/set` | No | `` |
| `TemplateRelativePath` | `String` | `get/set` | No | `` |
| `TemplateSheetsList` | `IEnumerable<KeyValuePair<String String>>` | `get` | No | `` |
| `TemplatesPath` | `String` | `get` | No | `` |
| `TemplatesSheets` | `TemplateSheets` | `get/set` | No | `` |
| `UserTemplatePath` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTemplateIdToCreate` | `Void` | `String sheetID` | `` |
| `ClearIDsToCreate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TemplateSheetSymbols` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.TemplateSheetSymbols` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IEnumerable<RowData> data)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Data` | `IEnumerable<RowData>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateTableName` | `String` | `String templateName` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_ID` | `String` | Yes | `"symbols"` | `` |

### `UserSheet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.UserSheet` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String id, String caption, String defaultName)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `DefaultName` | `String` | `get/set` | No | `` |
| `DwgTemplateSheetHeightFirst` | `Int32` | `get/set` | No | `` |
| `DwgTemplateSheetHeightOther` | `Int32` | `get/set` | No | `` |
| `DwgTemplateSheetNameFirst` | `String` | `get/set` | No | `` |
| `DwgTemplateSheetNameOther` | `String` | `get/set` | No | `` |
| `DwgTemplateSheetWidthFirst` | `Int32` | `get/set` | No | `` |
| `DwgTemplateSheetWidthOther` | `Int32` | `get/set` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `InCenter` | `Boolean` | `get/set` | No | `` |
| `OffsetFromWorkingArea` | `Boolean` | `get/set` | No | `` |
| `OffsetX` | `Double` | `get/set` | No | `` |
| `OffsetY` | `Double` | `get/set` | No | `` |
| `StampData` | `StampData` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanExecute` | `Boolean` | `` | `` |
| `CheckData` | `Boolean` | `` | `` |
| `Execute` | `Void` | `TablesExportService service, IList<URI> attachments` | `` |
| `Execute` | `Void` | `TablesExportService service, IList<URI> attachments, TablesDocument document` | `` |
| `Execute` | `Void` | `TablesDocument document` | `` |
| `GetFrame` | `UserSheetWizardFrame` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable<Object>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `PrepareData` | `Boolean` | `Boolean refresh` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `UserSheetWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.UserSheetWizardFrame` |
| **Base Type** | `System.Windows.Forms.UserControl` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.UserControl`
              - `Topomatic.Tables.Export.UserSheetWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Boolean` | `UserSheet sheet` | `` |
| `OnInitialize` | `Void` | `UserSheet sheet` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Tables.Export.Design`

### `TextJustifyConverter` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Design.TextJustifyConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAlignment` | `TableCellAlignment` | `TextJustify textJustify` | `` |
| `GetTextJustify` | `TextJustify` | `TableCellAlignment alignment` | `` |

---
## Namespace: `Topomatic.Tables.Export.Expressions`

### `CheckExpessionsMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Expressions.CheckExpessionsMode` |
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
      - `Topomatic.Tables.Export.Expressions.CheckExpessionsMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AllowDieselExpressions` | `CheckExpessionsMode` | Yes | `AllowDieselExpressions` | `` |
| `AllowOnlyCorrectColumnCode` | `CheckExpessionsMode` | Yes | `AllowOnlyCorrectColumnCode` | `` |
| `None` | `CheckExpessionsMode` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `AllowDieselExpressions` | `1` |
| `AllowOnlyCorrectColumnCode` | `2` |

**Underlying Type**: `System.Int32`

### `ExpresionErrorsConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Expressions.ExpresionErrorsConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Tables.Export.Expressions.ExpresionErrorsConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ExpressionErrors` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Expressions.ExpressionErrors` |
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
      - `Topomatic.Tables.Export.Expressions.ExpressionErrors`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cycle` | `ExpressionErrors` | Yes | `Cycle` | `` |
| `IncorrectArgument` | `ExpressionErrors` | Yes | `IncorrectArgument` | `` |
| `IncorrectExpression` | `ExpressionErrors` | Yes | `IncorrectExpression` | `` |
| `None` | `ExpressionErrors` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `IncorrectExpression` | `1` |
| `IncorrectArgument` | `2` |
| `Cycle` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Tables.Export.Import`

### `DwgTableImport` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Import.DwgTableImport` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateTable` | `DwgTable` | `DwgTableSourceData dwgTableSourceData, DwgTableStyle dwgTableStyle` | `` |
| `DwgTableRefreshDataFromSource` | `Void` | `DwgTable dwgTable, DwgTableCellLinkedDataBlock[] linkedDataBlocks` | `` |
| `DwgTableRefreshDataFromSource` | `Void` | `DwgTable dwgTable` | `` |
| `GetModel` | `IProjectModel` | `String modelId` | `` |
| `ImportTableStyle` | `DwgTableStyle` | `DwgTableStyle sourceStyle, Drawing drawing` | `` |

### `DwgTableSourceData` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Import.DwgTableSourceData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String modelId)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawBorder` | `Boolean` | `get` | No | `` |
| `ModelId` | `String` | `get` | No | `` |
| `OverrideStyles` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDwgTable` | `DwgTable` | `DwgTableStyle style` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFromStg` | `DwgTableSourceData` | `StgNode node` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_ColumnFrom` | `UInt32` | No | `` | `` |
| `m_ColumnTo` | `UInt32` | No | `` | `` |
| `m_ImportAll` | `Boolean` | No | `` | `` |
| `m_RowFrom` | `UInt32` | No | `` | `` |
| `m_RowTo` | `UInt32` | No | `` | `` |

### `DwgTableSourceDataCSV` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Import.DwgTableSourceDataCSV` |
| **Base Type** | `Topomatic.Tables.Export.Import.DwgTableSourceData` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.Import.DwgTableSourceData`
    - `Topomatic.Tables.Export.Import.DwgTableSourceDataCSV`

#### Constructors (1)

- `.ctor(String modelId)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDwgTable` | `DwgTable` | `DwgTableStyle style` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Commentary` | `Char` | No | `` | `` |
| `m_Delimeter` | `Char` | No | `` | `` |

### `DwgTableSourceDataDWP` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Import.DwgTableSourceDataDWP` |
| **Base Type** | `Topomatic.Tables.Export.Import.DwgTableSourceDataMultiSheet` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.Import.DwgTableSourceData`
    - `Topomatic.Tables.Export.Import.DwgTableSourceDataMultiSheet`
      - `Topomatic.Tables.Export.Import.DwgTableSourceDataDWP`

#### Constructors (1)

- `.ctor(String modelId)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawBorder` | `Boolean` | `get` | No | `` |
| `OverrideStyles` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDwgTable` | `DwgTable` | `DwgTableStyle style` | `` |
| `GetDwgTable` | `DwgTable` | `` | `` |

### `DwgTableSourceDataExcel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Import.DwgTableSourceDataExcel` |
| **Base Type** | `Topomatic.Tables.Export.Import.DwgTableSourceDataMultiSheet` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.Import.DwgTableSourceData`
    - `Topomatic.Tables.Export.Import.DwgTableSourceDataMultiSheet`
      - `Topomatic.Tables.Export.Import.DwgTableSourceDataExcel`

#### Constructors (1)

- `.ctor(String modelId)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `OverrideStyles` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDwgTable` | `DwgTable` | `DwgTableStyle style` | `` |

### `DwgTableSourceDataMultiSheet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Import.DwgTableSourceDataMultiSheet` |
| **Base Type** | `Topomatic.Tables.Export.Import.DwgTableSourceData` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.Import.DwgTableSourceData`
    - `Topomatic.Tables.Export.Import.DwgTableSourceDataMultiSheet`

#### Constructors (1)

- `.ctor(String modelId)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_SheetName` | `String` | No | `` | `` |

### `DwgTableSourceDataWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.Import.DwgTableSourceDataWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Drawing` | `Drawing` | No | `` | `` |
| `m_SourceData` | `DwgTableSourceData` | No | `` | `` |
| `m_Style` | `DwgTableStyle` | No | `` | `` |

---
## Namespace: `Topomatic.Tables.Export.ManagedExcel`

### `Application` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Application` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveSheet` | `Worksheet` | `get` | No | `` |
| `ActiveWindow` | `Window` | `get` | No | `` |
| `SheetsInNewWorkbook` | `Int32` | `get/set` | No | `` |
| `Version` | `String` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |
| `Workbooks` | `Workbooks` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ActiveWorkbook` | `Workbook` | `` | `` |
| `get_International` | `Object` | `Object Index` | `` |
| `Quit` | `Void` | `` | `` |

### `Border` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Border` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Object` | `get/set` | No | `` |
| `LineStyle` | `XlLineStyle` | `get/set` | No | `` |
| `Weight` | `XlBorderWeight` | `get/set` | No | `` |

### `Borders` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Borders` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable, Topomatic.Tables.Export.ManagedExcel.Collection, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Border` | `get` | No | `` |

### `Collection` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Collection` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RemoveAt` | `Void` | `Int32 index` | `` |

### `Common` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Common` |
| **Base Type** | `none` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Application` | `Application` | `get` | No | `` |
| `Parent` | `Object` | `get` | No | `` |

### `ExcelApplication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.ExcelApplication` |
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
| `Create` | `Application` | `` | `` |

### `Font` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Font` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Object` | `get/set` | No | `` |
| `Size` | `Double` | `get/set` | No | `` |

### `Interior` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Interior` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Object` | `get/set` | No | `` |

### `Range` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Range` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Borders` | `Borders` | `get` | No | `` |
| `Column` | `Int32` | `get` | No | `` |
| `Columns` | `Range` | `get` | No | `` |
| `ColumnWidth` | `Single` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Font` | `Font` | `get/set` | No | `` |
| `HorizontalAlignment` | `XlHAlign` | `get/set` | No | `` |
| `Interior` | `Interior` | `get/set` | No | `` |
| `Item` | `Range` | `get/set` | No | `` |
| `MergeArea` | `Range` | `get` | No | `` |
| `NumberFormat` | `String` | `get/set` | No | `` |
| `Orientation` | `Object` | `get/set` | No | `` |
| `Row` | `Int32` | `get` | No | `` |
| `RowHeight` | `Int32` | `get/set` | No | `` |
| `Rows` | `Range` | `get` | No | `` |
| `Text` | `String` | `get` | No | `` |
| `Value2` | `Object` | `get/set` | No | `` |
| `VerticalAlignment` | `XlVAlign` | `get/set` | No | `` |
| `WrapText` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AutoFit` | `Object` | `` | `` |
| `Merge` | `Void` | `Boolean Across` | `` |
| `Select` | `Object` | `` | `` |
| `SpecialCells` | `Range` | `XlCellType Type` | `` |

### `Window` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Window` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ScrollColumn` | `Int32` | `get/set` | No | `` |
| `ScrollRow` | `Int32` | `get/set` | No | `` |

### `Workbook` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Workbook` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveSheet` | `Object` | `get` | No | `` |
| `Saved` | `Boolean` | `get/set` | No | `` |
| `Sheets` | `Worksheets` | `get` | No | `` |
| `Title` | `String` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Close` | `Void` | `` | `` |
| `Close` | `Void` | `Boolean SaveChanges, String Filename, Object RouteWorkbook` | `` |
| `Save` | `Void` | `` | `` |
| `SaveAs` | `Void` | `String Filename` | `` |
| `SaveAs` | `Void` | `String Filename, XlFileFormat FileFormat, Object Password, Object WriteResPassword, Object ReadOnlyRecommended, Object CreateBackup, XlSaveAsAccessMode AccessMode, XlSaveConflictResolution ConflictResolution, Object AddToMru, Object TextCodepage, Object TextVisualLayout, Object lcid` | `` |

### `Workbooks` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Workbooks` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable, Topomatic.Tables.Export.ManagedExcel.Collection, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Workbook` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Workbook` | `Object Template` | `` |
| `Close` | `Void` | `` | `` |
| `Open` | `Workbook` | `String Filename` | `` |
| `Open` | `Workbook` | `String Filename, Object UpdateLinks, Object ReadOnly, Object Format, Object Password, Object WriteResPassword, Object IgnoreReadOnlyRecommended, Object Origin, Object Delimiter, Object Editable, Object Notify, Object Converter, Object AddToMru, Object Local, Object CorruptLoad` | `` |
| `OpenXML` | `Workbook` | `String Filename, Object Stylesheets, Object LoadOptions` | `` |

### `Worksheet` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Worksheet` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cells` | `Range` | `get` | No | `` |
| `Columns` | `Range` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Rows` | `Range` | `get` | No | `` |
| `UsedRange` | `Range` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Activate` | `Void` | `` | `` |
| `Close` | `Void` | `` | `` |
| `Delete` | `Void` | `` | `` |
| `get_Range` | `Range` | `Object Cell1, Object Cell2` | `` |

### `Worksheets` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.Worksheets` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Tables.Export.ManagedExcel.Common, System.IDisposable, Topomatic.Tables.Export.ManagedExcel.Collection, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Worksheet` | `get` | No | `` |
| `Item` | `Worksheet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Worksheet` | `Object Template` | `` |

### `XlBordersIndex` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlBordersIndex` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlBordersIndex`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlDiagonalDown` | `XlBordersIndex` | Yes | `xlDiagonalDown` | `` |
| `xlDiagonalUp` | `XlBordersIndex` | Yes | `xlDiagonalUp` | `` |
| `xlEdgeBottom` | `XlBordersIndex` | Yes | `xlEdgeBottom` | `` |
| `xlEdgeLeft` | `XlBordersIndex` | Yes | `xlEdgeLeft` | `` |
| `xlEdgeRight` | `XlBordersIndex` | Yes | `xlEdgeRight` | `` |
| `xlEdgeTop` | `XlBordersIndex` | Yes | `xlEdgeTop` | `` |
| `xlInsideHorizontal` | `XlBordersIndex` | Yes | `xlInsideHorizontal` | `` |
| `xlInsideVertical` | `XlBordersIndex` | Yes | `xlInsideVertical` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlDiagonalDown` | `5` |
| `xlDiagonalUp` | `6` |
| `xlEdgeLeft` | `7` |
| `xlEdgeTop` | `8` |
| `xlEdgeBottom` | `9` |
| `xlEdgeRight` | `10` |
| `xlInsideVertical` | `11` |
| `xlInsideHorizontal` | `12` |

**Underlying Type**: `System.Int32`

### `XlBorderWeight` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlBorderWeight` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlBorderWeight`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlHairline` | `XlBorderWeight` | Yes | `xlHairline` | `` |
| `xlMedium` | `XlBorderWeight` | Yes | `xlMedium` | `` |
| `xlThick` | `XlBorderWeight` | Yes | `xlThick` | `` |
| `xlThin` | `XlBorderWeight` | Yes | `xlThin` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlHairline` | `1` |
| `xlThin` | `2` |
| `xlThick` | `4` |
| `xlMedium` | `-4138` |

**Underlying Type**: `System.Int32`

### `XlCellType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlCellType` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlCellType`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlCellTypeAllFormatConditions` | `XlCellType` | Yes | `xlCellTypeAllFormatConditions` | `` |
| `xlCellTypeAllValidation` | `XlCellType` | Yes | `xlCellTypeAllValidation` | `` |
| `xlCellTypeBlanks` | `XlCellType` | Yes | `xlCellTypeBlanks` | `` |
| `xlCellTypeComments` | `XlCellType` | Yes | `xlCellTypeComments` | `` |
| `xlCellTypeConstants` | `XlCellType` | Yes | `xlCellTypeConstants` | `` |
| `xlCellTypeFormulas` | `XlCellType` | Yes | `xlCellTypeFormulas` | `` |
| `xlCellTypeLastCell` | `XlCellType` | Yes | `xlCellTypeLastCell` | `` |
| `xlCellTypeSameFormatConditions` | `XlCellType` | Yes | `xlCellTypeSameFormatConditions` | `` |
| `xlCellTypeSameValidation` | `XlCellType` | Yes | `xlCellTypeSameValidation` | `` |
| `xlCellTypeVisible` | `XlCellType` | Yes | `xlCellTypeVisible` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlCellTypeConstants` | `2` |
| `xlCellTypeBlanks` | `4` |
| `xlCellTypeLastCell` | `11` |
| `xlCellTypeVisible` | `12` |
| `xlCellTypeSameValidation` | `-4175` |
| `xlCellTypeAllValidation` | `-4174` |
| `xlCellTypeSameFormatConditions` | `-4173` |
| `xlCellTypeComments` | `-4144` |
| `xlCellTypeAllFormatConditions` | `-4142` |
| `xlCellTypeFormulas` | `-4123` |

**Underlying Type**: `System.Int32`

### `XlFileFormat` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlFileFormat` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlFileFormat`

#### Fields (44)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlAddIn` | `XlFileFormat` | Yes | `xlAddIn` | `` |
| `xlCSV` | `XlFileFormat` | Yes | `xlCSV` | `` |
| `xlCSVMac` | `XlFileFormat` | Yes | `xlCSVMac` | `` |
| `xlCSVMSDOS` | `XlFileFormat` | Yes | `xlCSVMSDOS` | `` |
| `xlCSVWindows` | `XlFileFormat` | Yes | `xlCSVWindows` | `` |
| `xlCurrentPlatformText` | `XlFileFormat` | Yes | `xlCurrentPlatformText` | `` |
| `xlDBF2` | `XlFileFormat` | Yes | `xlDBF2` | `` |
| `xlDBF3` | `XlFileFormat` | Yes | `xlDBF3` | `` |
| `xlDBF4` | `XlFileFormat` | Yes | `xlDBF4` | `` |
| `xlDIF` | `XlFileFormat` | Yes | `xlDIF` | `` |
| `xlExcel2` | `XlFileFormat` | Yes | `xlExcel2` | `` |
| `xlExcel2FarEast` | `XlFileFormat` | Yes | `xlExcel2FarEast` | `` |
| `xlExcel3` | `XlFileFormat` | Yes | `xlExcel3` | `` |
| `xlExcel4` | `XlFileFormat` | Yes | `xlExcel4` | `` |
| `xlExcel4Workbook` | `XlFileFormat` | Yes | `xlExcel4Workbook` | `` |
| `xlExcel5` | `XlFileFormat` | Yes | `xlExcel5` | `` |
| `xlExcel7` | `XlFileFormat` | Yes | `xlExcel5` | `` |
| `xlExcel9795` | `XlFileFormat` | Yes | `xlExcel9795` | `` |
| `xlHtml` | `XlFileFormat` | Yes | `xlHtml` | `` |
| `xlIntlAddIn` | `XlFileFormat` | Yes | `xlIntlAddIn` | `` |
| `xlIntlMacro` | `XlFileFormat` | Yes | `xlIntlMacro` | `` |
| `xlSYLK` | `XlFileFormat` | Yes | `xlSYLK` | `` |
| `xlTemplate` | `XlFileFormat` | Yes | `xlTemplate` | `` |
| `xlTextMac` | `XlFileFormat` | Yes | `xlTextMac` | `` |
| `xlTextMSDOS` | `XlFileFormat` | Yes | `xlTextMSDOS` | `` |
| `xlTextPrinter` | `XlFileFormat` | Yes | `xlTextPrinter` | `` |
| `xlTextWindows` | `XlFileFormat` | Yes | `xlTextWindows` | `` |
| `xlUnicodeText` | `XlFileFormat` | Yes | `xlUnicodeText` | `` |
| `xlWebArchive` | `XlFileFormat` | Yes | `xlWebArchive` | `` |
| `xlWJ2WD1` | `XlFileFormat` | Yes | `xlWJ2WD1` | `` |
| `xlWJ3` | `XlFileFormat` | Yes | `xlWJ3` | `` |
| `xlWJ3FJ3` | `XlFileFormat` | Yes | `xlWJ3FJ3` | `` |
| `xlWK1` | `XlFileFormat` | Yes | `xlWK1` | `` |
| `xlWK1ALL` | `XlFileFormat` | Yes | `xlWK1ALL` | `` |
| `xlWK1FMT` | `XlFileFormat` | Yes | `xlWK1FMT` | `` |
| `xlWK3` | `XlFileFormat` | Yes | `xlWK3` | `` |
| `xlWK3FM3` | `XlFileFormat` | Yes | `xlWK3FM3` | `` |
| `xlWK4` | `XlFileFormat` | Yes | `xlWK4` | `` |
| `xlWKS` | `XlFileFormat` | Yes | `xlWKS` | `` |
| `xlWorkbookNormal` | `XlFileFormat` | Yes | `xlWorkbookNormal` | `` |
| `xlWorks2FarEast` | `XlFileFormat` | Yes | `xlWorks2FarEast` | `` |
| `xlWQ1` | `XlFileFormat` | Yes | `xlWQ1` | `` |
| `xlXMLSpreadsheet` | `XlFileFormat` | Yes | `xlXMLSpreadsheet` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlSYLK` | `2` |
| `xlWKS` | `4` |
| `xlWK1` | `5` |
| `xlCSV` | `6` |
| `xlDBF2` | `7` |
| `xlDBF3` | `8` |
| `xlDIF` | `9` |
| `xlDBF4` | `11` |
| `xlWJ2WD1` | `14` |
| `xlWK3` | `15` |
| `xlExcel2` | `16` |
| `xlTemplate` | `17` |
| `xlAddIn` | `18` |
| `xlTextMac` | `19` |
| `xlTextWindows` | `20` |
| `xlTextMSDOS` | `21` |
| `xlCSVMac` | `22` |
| `xlCSVWindows` | `23` |
| `xlCSVMSDOS` | `24` |
| `xlIntlMacro` | `25` |
| `xlIntlAddIn` | `26` |
| `xlExcel2FarEast` | `27` |
| `xlWorks2FarEast` | `28` |
| `xlExcel3` | `29` |
| `xlWK1FMT` | `30` |
| `xlWK1ALL` | `31` |
| `xlWK3FM3` | `32` |
| `xlExcel4` | `33` |
| `xlWQ1` | `34` |
| `xlExcel4Workbook` | `35` |
| `xlTextPrinter` | `36` |
| `xlWK4` | `38` |
| `xlExcel5` | `39` |
| `xlExcel7` | `39` |
| `xlWJ3` | `40` |
| `xlWJ3FJ3` | `41` |
| `xlUnicodeText` | `42` |
| `xlExcel9795` | `43` |
| `xlHtml` | `44` |
| `xlWebArchive` | `45` |
| `xlXMLSpreadsheet` | `46` |
| `xlCurrentPlatformText` | `-4158` |
| `xlWorkbookNormal` | `-4143` |

**Underlying Type**: `System.Int32`

### `XlHAlign` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlHAlign` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlHAlign`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlHAlignCenter` | `XlHAlign` | Yes | `xlHAlignCenter` | `` |
| `xlHAlignCenterAcrossSelection` | `XlHAlign` | Yes | `xlHAlignCenterAcrossSelection` | `` |
| `xlHAlignDistributed` | `XlHAlign` | Yes | `xlHAlignDistributed` | `` |
| `xlHAlignFill` | `XlHAlign` | Yes | `xlHAlignFill` | `` |
| `xlHAlignGeneral` | `XlHAlign` | Yes | `xlHAlignGeneral` | `` |
| `xlHAlignJustify` | `XlHAlign` | Yes | `xlHAlignJustify` | `` |
| `xlHAlignLeft` | `XlHAlign` | Yes | `xlHAlignLeft` | `` |
| `xlHAlignRight` | `XlHAlign` | Yes | `xlHAlignRight` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlHAlignGeneral` | `1` |
| `xlHAlignFill` | `5` |
| `xlHAlignCenterAcrossSelection` | `7` |
| `xlHAlignRight` | `-4152` |
| `xlHAlignLeft` | `-4131` |
| `xlHAlignJustify` | `-4130` |
| `xlHAlignDistributed` | `-4117` |
| `xlHAlignCenter` | `-4108` |

**Underlying Type**: `System.Int32`

### `XlLineStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlLineStyle` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlLineStyle`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlContinuous` | `XlLineStyle` | Yes | `xlContinuous` | `` |
| `xlDash` | `XlLineStyle` | Yes | `xlDash` | `` |
| `xlDashDot` | `XlLineStyle` | Yes | `xlDashDot` | `` |
| `xlDashDotDot` | `XlLineStyle` | Yes | `xlDashDotDot` | `` |
| `xlDot` | `XlLineStyle` | Yes | `xlDot` | `` |
| `xlDouble` | `XlLineStyle` | Yes | `xlDouble` | `` |
| `xlLineStyleNone` | `XlLineStyle` | Yes | `xlLineStyleNone` | `` |
| `xlSlantDashDot` | `XlLineStyle` | Yes | `xlSlantDashDot` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlContinuous` | `1` |
| `xlDashDot` | `4` |
| `xlDashDotDot` | `5` |
| `xlSlantDashDot` | `13` |
| `xlLineStyleNone` | `-4142` |
| `xlDouble` | `-4119` |
| `xlDot` | `-4118` |
| `xlDash` | `-4115` |

**Underlying Type**: `System.Int32`

### `XlSaveAsAccessMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlSaveAsAccessMode` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlSaveAsAccessMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlExclusive` | `XlSaveAsAccessMode` | Yes | `xlExclusive` | `` |
| `xlNoChange` | `XlSaveAsAccessMode` | Yes | `xlNoChange` | `` |
| `xlShared` | `XlSaveAsAccessMode` | Yes | `xlShared` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlNoChange` | `1` |
| `xlShared` | `2` |
| `xlExclusive` | `3` |

**Underlying Type**: `System.Int32`

### `XlSaveConflictResolution` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlSaveConflictResolution` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlSaveConflictResolution`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlLocalSessionChanges` | `XlSaveConflictResolution` | Yes | `xlLocalSessionChanges` | `` |
| `xlOtherSessionChanges` | `XlSaveConflictResolution` | Yes | `xlOtherSessionChanges` | `` |
| `xlUserResolution` | `XlSaveConflictResolution` | Yes | `xlUserResolution` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlUserResolution` | `1` |
| `xlLocalSessionChanges` | `2` |
| `xlOtherSessionChanges` | `3` |

**Underlying Type**: `System.Int32`

### `XlVAlign` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ManagedExcel.XlVAlign` |
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
      - `Topomatic.Tables.Export.ManagedExcel.XlVAlign`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlVAlignBottom` | `XlVAlign` | Yes | `xlVAlignBottom` | `` |
| `xlVAlignCenter` | `XlVAlign` | Yes | `xlVAlignCenter` | `` |
| `xlVAlignDistributed` | `XlVAlign` | Yes | `xlVAlignDistributed` | `` |
| `xlVAlignJustify` | `XlVAlign` | Yes | `xlVAlignJustify` | `` |
| `xlVAlignTop` | `XlVAlign` | Yes | `xlVAlignTop` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlVAlignTop` | `-4160` |
| `xlVAlignJustify` | `-4130` |
| `xlVAlignDistributed` | `-4117` |
| `xlVAlignCenter` | `-4108` |
| `xlVAlignBottom` | `-4107` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Tables.Export.ServiceClasses`

### `ModelItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ServiceClasses.TablesModelsSelector+ModelItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Model` | `IProjectModel` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Selected` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `TablesModelsSelector` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Export.ServiceClasses.TablesModelsSelector` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `Void` | `IEnumerable<ModelItem> items` | `` |
| `GetModels` | `IEnumerable<IProjectModel>` | `Boolean selected` | `` |
| `Init` | `IEnumerable<ModelItem>` | `String[] modelTypes, Boolean defaultSelect` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `ModelItem` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 61 |
| **Classes** | 25 |
| **Interfaces** | 13 |
| **Enums** | 17 |
| **Structs** | 0 |
| **Abstract Classes** | 6 |
| **Static Classes** | 0 |
| **Total Methods** | 226 |
| **Total Properties** | 199 |
| **Total Fields** | 170 |
| **Total Events** | 0 |
| **Total Constructors** | 35 |
| **Nested Types** | 2 |
| **Extension Methods** | 0 |


