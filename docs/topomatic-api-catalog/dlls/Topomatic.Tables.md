# Topomatic.Tables

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Tables` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Tables, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Tables.dll` |

---
## Namespace: `Topomatic.Tables`

### `Area` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Area` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 x1, Int32 x2, Int32 y1, Int32 y2)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ContainsCell` | `Boolean` | `Int32 rowIndex, Int32 columnIndex` | `` |
| `ContainsColumn` | `Boolean` | `Int32 columnIndex` | `` |
| `ContainsRow` | `Boolean` | `Int32 rowIndex` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X1` | `Int32` | No | `` | `` |
| `X2` | `Int32` | No | `` | `` |
| `Y1` | `Int32` | No | `` | `` |
| `Y2` | `Int32` | No | `` | `` |

### `Bracket` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Bracket` |
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
      - `Topomatic.Tables.Bracket`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Close` | `Bracket` | Yes | `Close` | `` |
| `Open` | `Bracket` | Yes | `Open` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Open` | `40` |
| `Close` | `41` |

**Underlying Type**: `System.Int32`

### `CrossingType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableUtils+CrossingType` |
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
      - `Topomatic.Tables.TableUtils+CrossingType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Contained` | `CrossingType` | Yes | `Contained` | `` |
| `Contains` | `CrossingType` | Yes | `Contains` | `` |
| `Intersects` | `CrossingType` | Yes | `Intersects` | `` |
| `None` | `CrossingType` | Yes | `None` | `` |
| `Same` | `CrossingType` | Yes | `Same` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Contains` | `1` |
| `Contained` | `2` |
| `Intersects` | `3` |
| `Same` | `4` |

**Underlying Type**: `System.Int32`

### `ElementType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.ElementType` |
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
      - `Topomatic.Tables.ElementType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BracketClose` | `ElementType` | Yes | `BracketClose` | `` |
| `BracketOpen` | `ElementType` | Yes | `BracketOpen` | `` |
| `None` | `ElementType` | Yes | `None` | `` |
| `Operand` | `ElementType` | Yes | `Operand` | `` |
| `Operator` | `ElementType` | Yes | `Operator` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Operator` | `1` |
| `Operand` | `2` |
| `BracketOpen` | `3` |
| `BracketClose` | `4` |

**Underlying Type**: `System.Int32`

### `ISheetEditorCell` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.ISheetEditorCell` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HighlightColor` | `CadColor` | `get/set` | No | `` |
| `IsHighlighted` | `Boolean` | `get` | No | `` |
| `MergedX1` | `Int32` | `get` | No | `` |
| `MergedX2` | `Int32` | `get` | No | `` |
| `MergedY1` | `Int32` | `get` | No | `` |
| `MergedY2` | `Int32` | `get` | No | `` |
| `SourceText` | `String` | `get/set` | No | `` |
| `Style` | `ISheetEditorCellStyle` | `get` | No | `` |
| `Text` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResetHighlightColor` | `Void` | `CadColor color` | `` |

### `ISheetEditorCellBorderStyle` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.ISheetEditorCellBorderStyle` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Lineweight` | `SheetEditorLineweight` | `get/set` | No | `` |

### `ISheetEditorCellStyle` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.ISheetEditorCellStyle` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bold` | `Boolean` | `get/set` | No | `` |
| `BorderStyleBottom` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BorderStyleLeft` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BorderStyleRight` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BorderStyleTop` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `FillColor` | `CadColor` | `get/set` | No | `` |
| `FloatDisplayStyleDigits` | `Int32` | `get/set` | No | `` |
| `HorizontalField` | `Double` | `get/set` | No | `` |
| `Italic` | `Boolean` | `get/set` | No | `` |
| `PreferableDisplayStyle` | `TableCellPreferableDisplayStyle` | `get/set` | No | `` |
| `TextAngle` | `Double` | `get/set` | No | `` |
| `TextColor` | `CadColor` | `get/set` | No | `` |
| `TextHeight` | `Double` | `get/set` | No | `` |
| `TextJustify` | `TextJustify` | `get/set` | No | `` |
| `TextStyleName` | `String` | `get/set` | No | `` |
| `VerticalField` | `Double` | `get/set` | No | `` |

### `ISheetEditorLayout` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.ISheetEditorLayout` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultColumnWidth` | `Double` | `get` | No | `` |
| `DefaultRowHeight` | `Double` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `Width` | `Double` | `get` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColumnAutoWidth` | `Boolean` | `Int32 columnIndex` | `` |
| `GetColumnOffset` | `Double` | `Int32 columnIndex` | `` |
| `GetColumnWidth` | `Double` | `Int32 columnIndex` | `` |
| `GetRowAutoHeight` | `Boolean` | `Int32 rowIndex` | `` |
| `GetRowHeight` | `Double` | `Int32 rowIndex` | `` |
| `GetRowOffset` | `Double` | `Int32 rowIndex` | `` |
| `IsColumnHidden` | `Boolean` | `Int32 columnIndex` | `` |
| `IsRowHidden` | `Boolean` | `Int32 rowIndex` | `` |
| `SetColumnAutoWidth` | `Void` | `Int32 columnIndex, Boolean value` | `` |
| `SetColumnHidden` | `Void` | `Int32 columnIndex, Boolean hidden` | `` |
| `SetColumnWidth` | `Void` | `Int32 columnIndex, Double value` | `` |
| `SetRowAutoHeight` | `Void` | `Int32 rowIndex, Boolean value` | `` |
| `SetRowHeight` | `Void` | `Int32 rowIndex, Double value` | `` |
| `SetRowHidden` | `Void` | `Int32 rowIndex, Boolean hidden` | `` |

### `ISheetEditorModel` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.ISheetEditorModel` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ColumnsCount` | `Int32` | `get` | No | `` |
| `Item` | `ISheetEditorCell` | `get` | No | `` |
| `RowsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `InsertColumn` | `Void` | `Int32 columnIndex` | `` |
| `InsertRow` | `Void` | `Int32 rowIndex` | `` |
| `MergeCells` | `Boolean` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `` |
| `RemoveColumnAt` | `Void` | `Int32 columnIndex` | `` |
| `RemoveRowAt` | `Void` | `Int32 rowIndex` | `` |
| `UnmergeCells` | `Boolean` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `` |

### `MathOperator` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathOperator` |
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
      - `Topomatic.Tables.MathOperator`

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

### `Option` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableRow+Option` |
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
      - `Topomatic.Tables.TableRow+Option`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AutoSize` | `Option` | Yes | `AutoSize` | `` |
| `Default` | `Option` | Yes | `AutoSize` | `` |
| `FixedSize` | `Option` | Yes | `FixedSize` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `1` |
| `AutoSize` | `1` |
| `FixedSize` | `2` |

**Underlying Type**: `System.Int32`

### `Option` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableColumn+Option` |
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
      - `Topomatic.Tables.TableColumn+Option`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AutoSize` | `Option` | Yes | `AutoSize` | `` |
| `Default` | `Option` | Yes | `AutoSize` | `` |
| `FixedSize` | `Option` | Yes | `FixedSize` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `1` |
| `AutoSize` | `1` |
| `FixedSize` | `2` |

**Underlying Type**: `System.Int32`

### `PolandNotation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.PolandNotation` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Result` | `List<PolandNotationElement>` | `get` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateExpression` | `Boolean` | `List<PolandNotationElement> expression, ref Double result` | `` |
| `Convert` | `Boolean` | `String data, ref List<PolandNotationElement> result` | `` |

### `PolandNotationBracket` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.PolandNotationBracket` |
| **Base Type** | `Topomatic.Tables.PolandNotationElement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.PolandNotationElement`
    - `Topomatic.Tables.PolandNotationBracket`

#### Constructors (1)

- `.ctor(Bracket bracket)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `m_Bracket` | `Bracket` | `get/set` | No | `` |

### `PolandNotationElement` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.PolandNotationElement` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `PolandNotationOperand` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.PolandNotationOperand` |
| **Base Type** | `Topomatic.Tables.PolandNotationElement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.PolandNotationElement`
    - `Topomatic.Tables.PolandNotationOperand`

#### Constructors (2)

- `.ctor(String operand)`
- `.ctor(Double value)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `m_Operand` | `String` | `get/set` | No | `` |
| `ParsedValue` | `Double` | `get/set` | No | `` |

### `PolandNotationOperator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.PolandNotationOperator` |
| **Base Type** | `Topomatic.Tables.PolandNotationElement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.PolandNotationElement`
    - `Topomatic.Tables.PolandNotationOperator`

#### Constructors (1)

- `.ctor(MathOperator mathOperator)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `m_MathOperator` | `MathOperator` | `get/set` | No | `` |

### `SheetEditorLineweight` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.SheetEditorLineweight` |
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
      - `Topomatic.Tables.SheetEditorLineweight`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `Int32` | No | `` | `` |
| `xlHairline` | `SheetEditorLineweight` | Yes | `xlHairline` | `` |
| `xlMedium` | `SheetEditorLineweight` | Yes | `xlMedium` | `` |
| `xlNone` | `SheetEditorLineweight` | Yes | `xlNone` | `` |
| `xlThick` | `SheetEditorLineweight` | Yes | `xlThick` | `` |
| `xlThin` | `SheetEditorLineweight` | Yes | `xlThin` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `xlNone` | `0` |
| `xlHairline` | `1` |
| `xlThin` | `2` |
| `xlMedium` | `4` |
| `xlThick` | `8` |

**Underlying Type**: `System.Int32`

### `StyleEqualityComparer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.StyleEqualityComparer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEqualityComparer`1[[Topomatic.Tables.TableCellStyle, Topomatic.Tables, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `TableCellStyle x, TableCellStyle y` | `` |
| `GetHashCode` | `Int32` | `TableCellStyle obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CurrentComparer` | `StyleEqualityComparer` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEqualityComparer`1` | `Equals` |
| `IEqualityComparer`1` | `GetHashCode` |

### `Table` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Table` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorModel` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Active` | `Boolean` | `get` | No | `` |
| `ColumnsCount` | `Int32` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Item` | `TableCell` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `RowsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `Cell` | `TableCell` | `Int32 row, Int32 column` | `` |
| `Column` | `TableColumn` | `Int32 index` | `` |
| `Copy` | `Void` | `Table table` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `InsertColumn` | `Void` | `Int32 columnIndex` | `` |
| `InsertColumn` | `Void` | `Int32 columnIndex, Option options, Double width` | `` |
| `InsertRow` | `Void` | `Int32 rowIndex` | `` |
| `InsertSubtableByColumns` | `Void` | `Table subtable, Int32 rowIndex, Int32 columnIndex` | `` |
| `Merge` | `TableCell` | `Int32 row, Int32 column, Int32 rows, Int32 columns` | `` |
| `MergeCells` | `Boolean` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `` |
| `RemoveColumnAt` | `Void` | `Int32 columnIndex` | `` |
| `RemoveRowAt` | `Void` | `Int32 rowIndex` | `` |
| `Row` | `TableRow` | `Int32 index` | `` |
| `SetBorderWidths` | `Void` | `Int32 row, Int32 column, Int32 rows, Int32 columns, Int32 BorderWidthSize` | `` |
| `SetStyle` | `Void` | `Int32 row, Int32 column, Int32 rows, Int32 columns, Action<TableCellStyle> action` | `` |
| `TryGetCell` | `Boolean` | `Int32 row, Int32 column, ref TableCell cell` | `` |
| `UnmergeCells` | `Boolean` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISheetEditorModel` | `Topomatic.Tables.ISheetEditorModel.get_Item` |
| `ISheetEditorModel` | `get_RowsCount` |
| `ISheetEditorModel` | `get_ColumnsCount` |
| `ISheetEditorModel` | `MergeCells` |
| `ISheetEditorModel` | `UnmergeCells` |
| `ISheetEditorModel` | `InsertRow` |
| `ISheetEditorModel` | `InsertColumn` |
| `ISheetEditorModel` | `RemoveRowAt` |
| `ISheetEditorModel` | `RemoveColumnAt` |
| `ISheetEditorModel` | `BeginUpdate` |
| `ISheetEditorModel` | `EndUpdate` |

### `TableCell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableCell` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorCell` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Column` | `Int32` | `get/set` | No | `` |
| `Columns` | `Int32` | `get/set` | No | `` |
| `HighlightColor` | `CadColor` | `get/set` | No | `` |
| `IsHighlighted` | `Boolean` | `get` | No | `` |
| `MergedX1` | `Int32` | `get` | No | `` |
| `MergedX2` | `Int32` | `get` | No | `` |
| `MergedY1` | `Int32` | `get` | No | `` |
| `MergedY2` | `Int32` | `get` | No | `` |
| `Row` | `Int32` | `get` | No | `` |
| `Rows` | `Int32` | `get` | No | `` |
| `SourceText` | `String` | `get/set` | No | `` |
| `Style` | `TableCellStyle` | `get/set` | No | `` |
| `Table` | `Table` | `get` | No | `` |
| `Text` | `String` | `get` | No | `` |
| `Value` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResetHighlightColor` | `Void` | `CadColor color` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISheetEditorCell` | `get_MergedX1` |
| `ISheetEditorCell` | `get_MergedY1` |
| `ISheetEditorCell` | `get_MergedX2` |
| `ISheetEditorCell` | `get_MergedY2` |
| `ISheetEditorCell` | `get_SourceText` |
| `ISheetEditorCell` | `set_SourceText` |
| `ISheetEditorCell` | `Topomatic.Tables.ISheetEditorCell.get_Text` |
| `ISheetEditorCell` | `Topomatic.Tables.ISheetEditorCell.get_Style` |
| `ISheetEditorCell` | `get_IsHighlighted` |
| `ISheetEditorCell` | `get_HighlightColor` |
| `ISheetEditorCell` | `set_HighlightColor` |
| `ISheetEditorCell` | `ResetHighlightColor` |

### `TableCellAlignment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableCellAlignment` |
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
      - `Topomatic.Tables.TableCellAlignment`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CenterBottom` | `TableCellAlignment` | Yes | `CenterBottom` | `` |
| `CenterMiddle` | `TableCellAlignment` | Yes | `CenterMiddle` | `` |
| `CenterTop` | `TableCellAlignment` | Yes | `CenterTop` | `` |
| `LeftBottom` | `TableCellAlignment` | Yes | `LeftBottom` | `` |
| `LeftMiddle` | `TableCellAlignment` | Yes | `LeftMiddle` | `` |
| `LeftTop` | `TableCellAlignment` | Yes | `LeftTop` | `` |
| `RightBottom` | `TableCellAlignment` | Yes | `RightBottom` | `` |
| `RightMiddle` | `TableCellAlignment` | Yes | `RightMiddle` | `` |
| `RightTop` | `TableCellAlignment` | Yes | `RightTop` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftTop` | `0` |
| `LeftMiddle` | `1` |
| `LeftBottom` | `2` |
| `CenterTop` | `3` |
| `CenterMiddle` | `4` |
| `CenterBottom` | `5` |
| `RightTop` | `6` |
| `RightMiddle` | `7` |
| `RightBottom` | `8` |

**Underlying Type**: `System.Int32`

### `TableCellBorderStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableCellBorderStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorCellBorderStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Lineweight` | `Int32` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Copy` | `Void` | `TableCellBorderStyle tableCellBorderStyle` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISheetEditorCellBorderStyle` | `get_Color` |
| `ISheetEditorCellBorderStyle` | `set_Color` |
| `ISheetEditorCellBorderStyle` | `Topomatic.Tables.ISheetEditorCellBorderStyle.get_Lineweight` |
| `ISheetEditorCellBorderStyle` | `Topomatic.Tables.ISheetEditorCellBorderStyle.set_Lineweight` |

### `TableCellPreferableDisplayStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableCellPreferableDisplayStyle` |
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
      - `Topomatic.Tables.TableCellPreferableDisplayStyle`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Float` | `TableCellPreferableDisplayStyle` | Yes | `Float` | `` |
| `Integer` | `TableCellPreferableDisplayStyle` | Yes | `Integer` | `` |
| `Text` | `TableCellPreferableDisplayStyle` | Yes | `Text` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Text` | `0` |
| `Integer` | `1` |
| `Float` | `2` |

**Underlying Type**: `System.Int32`

### `TableCellStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableCellStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorCellStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (27)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `TableCellAlignment` | `get/set` | No | `` |
| `Bold` | `Boolean` | `get/set` | No | `` |
| `BorderStyleBottom` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BorderStyleLeft` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BorderStyleRight` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BorderStyleTop` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BottomBorderColor` | `CadColor` | `get/set` | No | `` |
| `BottomBorderWidth` | `Int32` | `get/set` | No | `` |
| `Default` | `TableCellStyle` | `get` | Yes | `` |
| `FillColor` | `CadColor` | `get/set` | No | `` |
| `FloatDisplayStyleDigits` | `Int32` | `get/set` | No | `` |
| `HorizontalField` | `Double` | `get/set` | No | `` |
| `Italic` | `Boolean` | `get/set` | No | `` |
| `LeftBorderColor` | `CadColor` | `get/set` | No | `` |
| `LeftBorderWidth` | `Int32` | `get/set` | No | `` |
| `PreferableDisplayStyle` | `TableCellPreferableDisplayStyle` | `get/set` | No | `` |
| `RightBorderColor` | `CadColor` | `get/set` | No | `` |
| `RightBorderWidth` | `Int32` | `get/set` | No | `` |
| `RotationAngle` | `Int32` | `get/set` | No | `` |
| `TextAngle` | `Double` | `get/set` | No | `` |
| `TextColor` | `CadColor` | `get/set` | No | `` |
| `TextHeight` | `Double` | `get/set` | No | `` |
| `TextStyleName` | `String` | `get/set` | No | `` |
| `TopBorderColor` | `CadColor` | `get/set` | No | `` |
| `TopBorderWidth` | `Int32` | `get/set` | No | `` |
| `Transform` | `String` | `get/set` | No | `` |
| `VerticalField` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetBorderWidth` | `Void` | `Int32 left, Int32 right, Int32 top, Int32 bottom` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISheetEditorCellStyle` | `get_TextColor` |
| `ISheetEditorCellStyle` | `set_TextColor` |
| `ISheetEditorCellStyle` | `get_TextHeight` |
| `ISheetEditorCellStyle` | `set_TextHeight` |
| `ISheetEditorCellStyle` | `Topomatic.Tables.ISheetEditorCellStyle.get_TextJustify` |
| `ISheetEditorCellStyle` | `Topomatic.Tables.ISheetEditorCellStyle.set_TextJustify` |
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
| `ISheetEditorCellStyle` | `get_BorderStyleTop` |
| `ISheetEditorCellStyle` | `get_BorderStyleBottom` |
| `ISheetEditorCellStyle` | `get_BorderStyleLeft` |
| `ISheetEditorCellStyle` | `get_BorderStyleRight` |

### `TableCellStyles` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableCellStyles` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TableColumn` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableColumn` |
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
| `Options` | `Option` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Copy` | `Void` | `TableColumn column` | `` |

#### Nested Types (1)

- `Option` (enum)

### `TableConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TABLES_DWL_MODEL_TYPE` | `String` | Yes | `"application/sht-dwl"` | `` |
| `TABLES_SHEET_FUNCTION` | `String` | Yes | `"tables_single_sheet"` | `` |

### `TableRow` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableRow` |
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
| `Height` | `Double` | `get/set` | No | `` |
| `Options` | `Option` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Copy` | `Void` | `TableRow row` | `` |

#### Nested Types (1)

- `Option` (enum)

### `TablesDocument` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TablesDocument` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Tables.Table, Topomatic.Tables, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Table` | `get` | No | `` |
| `Item` | `Table` | `get` | No | `` |
| `TablesCount` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTable` | `Table` | `String name, String id, Boolean active` | `` |
| `AddTable` | `Table` | `String name, String id` | `` |
| `GetEnumerator` | `IEnumerator<Table>` | `` | `` |
| `RemoveTableAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `TablesExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TablesExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (24)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAttribute` | `Void` | `XmlNode node, String name, String value, String defaultValue` | `Extension` |
| `AddAttribute` | `Void` | `XmlNode node, String name, String value` | `Extension` |
| `AddAttributeBool` | `Void` | `XmlNode node, String name, Boolean value` | `Extension` |
| `AddAttributeFloat` | `Void` | `XmlNode node, String name, Single value` | `Extension` |
| `AddAttributeInt32` | `Void` | `XmlNode node, String name, Int32 value` | `Extension` |
| `AddAttributeInt32` | `Void` | `XmlNode node, String name, Int32 value, Int32 defaultValue` | `Extension` |
| `AddBool` | `Void` | `XmlNode node, String name, Boolean value` | `Extension` |
| `AddDouble` | `Void` | `XmlNode node, String name, Double value` | `Extension` |
| `AddInt32` | `Void` | `XmlNode node, String name, Int32 value, Int32 defaultValue` | `Extension` |
| `AddInt32` | `Void` | `XmlNode node, String name, Int32 value` | `Extension` |
| `AddValue` | `Void` | `XmlNode node, String name, String value, String defaultValue` | `Extension` |
| `AddValue` | `Void` | `XmlNode node, String name, String value` | `Extension` |
| `FloatToStr` | `String` | `Double value` | `` |
| `FloatToStr` | `String` | `Nullable<Double> value` | `` |
| `GetAttribute` | `String` | `XmlNode node, String name, String defaultValue` | `Extension` |
| `GetAttributeBool` | `Boolean` | `XmlNode node, String name, Boolean defaultValue` | `Extension` |
| `GetAttributeFloat` | `Single` | `XmlNode node, String name, Single defaultValue` | `Extension` |
| `GetAttributeInt32` | `Int32` | `XmlNode node, String name, Int32 defaultValue` | `Extension` |
| `GetBool` | `Boolean` | `XmlNode node, String name, Boolean defaultValue` | `Extension` |
| `GetDouble` | `Double` | `XmlNode node, String name, Double defaultValue` | `Extension` |
| `GetInt32` | `Int32` | `XmlNode node, String name, Int32 defaultValue` | `Extension` |
| `GetValue` | `String` | `XmlNode node, String name, String defaultValue` | `Extension` |
| `StrToFloat` | `Double` | `String value` | `` |
| `TryStrToFloat` | `Boolean` | `String value, ref Double result` | `` |

### `TableUtils` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.TableUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AnalyzeCrossings` | `CrossingType` | `Area selection1, Area selection2` | `` |
| `ColumnIndexByCode` | `Boolean` | `String code, ISheetEditorModel table, ref Int32 columnIndex` | `` |
| `ColumnIndexByCode` | `Boolean` | `String code, ref Int32 columnIndex` | `` |
| `ColumnNumberToString` | `String` | `Int32 columnNumber` | `` |
| `ExtractCellCode` | `Boolean` | `ISheetEditorModel table, String text, ref Int32 rowIndex, ref Int32 columnIndex` | `` |
| `ExtractColumnId` | `String` | `String value` | `` |
| `GenerateColumnContextExpression` | `String` | `String columnId` | `` |
| `ReplaceColumnCodesInExpression` | `Void` | `ISheetEditorModel table, ref String expression, Int32 dX, Int32 dY` | `` |

#### Nested Types (1)

- `CrossingType` (enum)

---
## Namespace: `Topomatic.Tables.MathProcessor`

### `CellIndex` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathProcessor.CellIndex` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Tables.MathProcessor.CellIndex`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ColumnIndex` | `Int32` | No | `` | `` |
| `RowIndex` | `Int32` | No | `` | `` |

### `CheckExpessionsMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathProcessor.CheckExpessionsMode` |
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
      - `Topomatic.Tables.MathProcessor.CheckExpessionsMode`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AllowDieselExpressions` | `CheckExpessionsMode` | Yes | `AllowDieselExpressions` | `` |
| `AllowOutOfRangeRows` | `CheckExpessionsMode` | Yes | `AllowOutOfRangeRows` | `` |
| `None` | `CheckExpessionsMode` | Yes | `None` | `` |
| `NotCalculate` | `CheckExpessionsMode` | Yes | `NotCalculate` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `AllowDieselExpressions` | `1` |
| `NotCalculate` | `2` |
| `AllowOutOfRangeRows` | `4` |

**Underlying Type**: `System.Int32`

### `ExpresionErrorsConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathProcessor.MathProcessor+ExpresionErrorsConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Tables.MathProcessor.MathProcessor+ExpresionErrorsConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ExpressionErrors` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathProcessor.ExpressionErrors` |
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
      - `Topomatic.Tables.MathProcessor.ExpressionErrors`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ColumnOutOfRange` | `ExpressionErrors` | Yes | `ColumnOutOfRange` | `` |
| `Cycle` | `ExpressionErrors` | Yes | `Cycle` | `` |
| `IncorrectArgument` | `ExpressionErrors` | Yes | `IncorrectArgument` | `` |
| `IncorrectExpression` | `ExpressionErrors` | Yes | `IncorrectExpression` | `` |
| `None` | `ExpressionErrors` | Yes | `None` | `` |
| `RowOutOfRange` | `ExpressionErrors` | Yes | `RowOutOfRange` | `` |
| `UnknownExpression` | `ExpressionErrors` | Yes | `UnknownExpression` | `` |
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
| `Cycle` | `4` |
| `UnknownExpression` | `8` |
| `ColumnOutOfRange` | `16` |
| `RowOutOfRange` | `32` |

**Underlying Type**: `System.Int32`

### `ExpressionProcessor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathProcessor.ExpressionProcessor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Check` | `ExpressionErrors` | `CellIndex cellIndex, String expression` | `` |
| `CheckOperand` | `ExpressionErrors` | `Int32 r, Int32 c, PolandNotationOperand polandNotationOperand` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetInstance` | `ExpressionProcessor` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MathProcessor` | `MathProcessor` | No | `` | `` |
| `StartSymbols` | `String` | No | `` | `` |

### `LinkedCellIndexes` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathProcessor.LinkedCellIndexes` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Tables.MathProcessor.LinkedCellIndexes`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LinkedCellIndex` | `CellIndex` | No | `` | `` |
| `OperandCellIndex` | `CellIndex` | No | `` | `` |

### `MathProcessor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.MathProcessor.MathProcessor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ISheetEditorModel table)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Table` | `ISheetEditorModel` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddExpressionChecker` | `Void` | `ExpressionProcessor expressionChecker` | `` |
| `AreaRemoved` | `Void` | `Int32 y1, Int32 x1, Int32 y2, Int32 x2` | `` |
| `CreateCellsLink` | `Void` | `CellIndex operandCellIndex` | `` |
| `ParseCellIndex` | `Boolean` | `String cellIndexText, ref CellIndex cellIndex, ref ExpressionErrors errorCode` | `` |
| `ProcessCell` | `ExpressionErrors` | `CellIndex cellIndex` | `` |
| `ProcessExpressions` | `Void` | `CheckExpessionsMode checkMode` | `` |
| `ProcessOperand` | `ExpressionErrors` | `PolandNotationOperand polandNotationOperand` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CheckExpressionMode` | `CheckExpessionsMode` | No | `` | `` |

#### Nested Types (1)

- `ExpresionErrorsConverter` (class)

---
## Namespace: `Topomatic.Tables.Sheets`

### `ColumnContextTag` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ColumnContextTag` |
| **Base Type** | `Topomatic.Tables.Sheets.ContextTag` |
| **Implements** | `System.IEquatable`1[[Topomatic.Tables.Sheets.ContextTag, Topomatic.Tables, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Sheets.ContextTag`
    - `Topomatic.Tables.Sheets.ColumnContextTag`

#### Constructors (1)

- `.ctor(String id, String tag, String description, String parentId)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ContextTag other` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_ParentId` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `ColumnContextTemplate` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ColumnContextTemplate` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Tables.Sheets.ColumnContextTemplate`

#### Constructors (2)

- `.ctor(XmlNode node)`
- `.ctor(String columnContextId, Area area)`

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Area` | `Area` | `get` | No | `` |
| `BottomBorderLevel` | `Int32` | `get` | No | `` |
| `ChildTemplates` | `ColumnContextTemplate[]` | `get` | No | `` |
| `ColumnContextId` | `String` | `get` | No | `` |
| `Height` | `Int32` | `get` | No | `` |
| `LeftBorderLevel` | `Int32` | `get` | No | `` |
| `Level` | `Int32` | `get` | No | `` |
| `MinPossibleOffsetArea` | `Area` | `get` | No | `` |
| `OffsetArea` | `Area` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Parent` | `ColumnContextTemplate` | `get` | No | `` |
| `RightBorderLevel` | `Int32` | `get` | No | `` |
| `Width` | `Int32` | `get` | No | `` |
| `X1` | `Int32` | `get` | No | `` |
| `X2` | `Int32` | `get/set` | No | `` |
| `X2Offset` | `Int32` | `get` | No | `` |
| `XOffset` | `Int32` | `get` | No | `` |
| `Y1` | `Int32` | `get` | No | `` |
| `Y2` | `Int32` | `get/set` | No | `` |
| `Y2Offset` | `Int32` | `get` | No | `` |
| `YOffset` | `Int32` | `get` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddChildColumnTemplate` | `Void` | `ColumnContextTemplate columnTemplate` | `` |
| `ExpandByX` | `Void` | `Int32 deltaX` | `` |
| `ExpandByY` | `Void` | `Int32 deltaY` | `` |
| `InsertColumn` | `Void` | `Int32 x` | `` |
| `InsertRow` | `Void` | `Int32 y` | `` |
| `IsAncestorOf` | `Boolean` | `ColumnContextTemplate columnContextTemplate` | `` |
| `LastLevelTemplateForArea` | `ColumnContextTemplate` | `Area area` | `` |
| `LoadFromXml` | `Void` | `XmlNode node` | `` |
| `MoveByX` | `Void` | `Int32 offset` | `` |
| `MoveByY` | `Void` | `Int32 offset` | `` |
| `RemoveChildTemplate` | `Void` | `ColumnContextTemplate template` | `` |
| `RemoveColumn` | `Void` | `Int32 x` | `` |
| `RemoveRow` | `Void` | `Int32 y` | `` |
| `SaveToXml` | `Void` | `XmlNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ColumnContextValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ColumnContextValue` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Description` | `String` | No | `` | `` |
| `m_Value` | `TableColumnContext` | No | `` | `` |

### `ContextFunction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ContextFunction` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String id, String name, String description, Byte paramsCount)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `ParamsCount` | `Byte` | `get` | No | `` |

### `ContextFunctionsList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ContextFunctionsList` |
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
| `Add` | `Void` | `ContextFunction contextFunction` | `` |
| `GetFunctionsForId` | `IEnumerable<ContextFunction>` | `String id` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |

### `ContextProcessor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ContextProcessor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Calculate` | `String` | `String[] prms` | `` |

### `ContextTag` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ContextTag` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IEquatable`1[[Topomatic.Tables.Sheets.ContextTag, Topomatic.Tables, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(String id, String tag, String description)`
- `.ctor(Boolean isSemantic, String id, String tag, String description)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ContextTag other` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Description` | `String` | No | `` | `` |
| `m_Id` | `String` | No | `` | `` |
| `m_isSemantic` | `Boolean` | No | `` | `` |
| `m_Tag` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `ContextTagList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ContextTagList` |
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
| `ColumnContextTags` | `IEnumerable<ContextTag>` | `get` | No | `` |
| `ContextTags` | `IEnumerable<ContextTag>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ContextTag contextTag` | `` |
| `AddColumnContextTag` | `Void` | `ColumnContextTag columnContextTag` | `` |
| `IsValidColumnRelation` | `Boolean` | `String columnIdParent, String columnIdChild` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |

### `ContextValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ContextValue` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Description` | `String` | No | `` | `` |
| `m_Value` | `String` | No | `` | `` |

### `DieselContextFunction` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.DieselContextFunction` |
| **Base Type** | `Topomatic.FoundationClasses.Diesel.DieselSimpleFunction` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Diesel.DieselFunction`
    - `Topomatic.FoundationClasses.Diesel.DieselSimpleFunction`
      - `Topomatic.Tables.Sheets.DieselContextFunction`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `ParamsCount` | `Byte` | `get` | No | `` |

### `IContextFunctionsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.IContextFunctionsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFunctions` | `IEnumerable<DieselContextFunction>` | `` | `` |

### `ITableColumnContextContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.ITableColumnContextContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TableColumnContexts` | `TableColumnContext[]` | `get` | No | `` |

### `RowData` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.RowData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String id)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColumnContextsTags` | `IEnumerable<ColumnContextTag>` | `` | `` |
| `GetColumns` | `TableColumnValue[]` | `String columnContextTag` | `` |
| `GetContextsTags` | `IEnumerable<ContextTag>` | `` | `` |
| `GetFunctions` | `IEnumerable<DieselContextFunction>` | `` | `` |
| `TryGetValue` | `Boolean` | `String name, ref String value` | `` |

### `SmdxSymbolContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.SmdxSymbolContext` |
| **Base Type** | `Topomatic.Tables.Sheets.SymbolContext` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Sheets.RowData`
    - `Topomatic.Tables.Sheets.SymbolContext`
      - `Topomatic.Tables.Sheets.SmdxSymbolContext`

#### Constructors (1)

- `.ctor(String id, Object contextObj, TypedObject tobject, String[] exluded)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetContextsTags` | `IEnumerable<ContextTag>` | `` | `` |
| `TryGetValue` | `Boolean` | `String name, ref String value` | `` |

### `SmtSymbolContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.SmtSymbolContext` |
| **Base Type** | `Topomatic.Tables.Sheets.SymbolContext` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Sheets.RowData`
    - `Topomatic.Tables.Sheets.SymbolContext`
      - `Topomatic.Tables.Sheets.SmtSymbolContext`

#### Constructors (1)

- `.ctor(String id, Object contextObj, SemanticDataSet smt)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetContextsTags` | `IEnumerable<ContextTag>` | `` | `` |
| `TryGetValue` | `Boolean` | `String name, ref String value` | `` |
| `TryGetValueSmt` | `Boolean` | `String name, ref String value` | `` |

### `SymbolContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.SymbolContext` |
| **Base Type** | `Topomatic.Tables.Sheets.RowData` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Sheets.RowData`
    - `Topomatic.Tables.Sheets.SymbolContext`

#### Constructors (1)

- `.ctor(String id, Object contextObj)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColumnContextsTags` | `IEnumerable<ColumnContextTag>` | `` | `` |
| `GetColumns` | `TableColumnValue[]` | `String name` | `` |
| `GetContextsTags` | `IEnumerable<ContextTag>` | `` | `` |
| `GetFunctions` | `IEnumerable<DieselContextFunction>` | `` | `` |
| `TryGetValue` | `Boolean` | `String name, ref String value` | `` |

### `TableColumnContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TableColumnContext` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String id, String description)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Values` | `TableColumnValue[]` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddValue` | `Void` | `TableColumnValue value` | `` |

### `TableColumnValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TableColumnValue` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(String value)`
- `.ctor(String value, TableColumnValue parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `TableColumnContext` | `get/set` | No | `` |
| `Parent` | `TableColumnValue` | `get` | No | `` |
| `Value` | `String` | `get` | No | `` |

### `TableContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TableContext` |
| **Base Type** | `Topomatic.Tables.Sheets.RowData` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Sheets.RowData`
    - `Topomatic.Tables.Sheets.TableContext`

#### Constructors (1)

- `.ctor(String id)`

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddColumnContext` | `Void` | `TableColumnContext tableColumnContext` | `` |
| `AddValue` | `Void` | `String name, String value` | `` |
| `AddValue` | `Void` | `String name, String value, String description` | `` |
| `GetColumnContextsTags` | `IEnumerable<ColumnContextTag>` | `` | `` |
| `GetColumns` | `TableColumnValue[]` | `String columnContextTag` | `` |
| `GetContextsTags` | `IEnumerable<ContextTag>` | `` | `` |
| `GetFunctions` | `IEnumerable<DieselContextFunction>` | `` | `` |
| `TryGetValue` | `Boolean` | `String name, ref String value` | `` |

### `TemplateProcessor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TemplateProcessor` |
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
| `Sheet` | `Table` | `get/set` | No | `` |
| `Template` | `TemplateSheet` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `IEnumerable<RowData> dataSet` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RowNubmerParamText` | `String` | Yes | `"rowNumber"` | `` |

### `TemplateSheet` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TemplateSheets+TemplateSheet` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Breakings` | `Dictionary<String List<String>>` | `get/set` | No | `` |
| `ColumnTemplates` | `ColumnContextTemplate[]` | `get/set` | No | `` |
| `ExcludedIds` | `String[]` | `get` | No | `` |
| `HeaderRowsCount` | `Int32` | `get` | No | `` |
| `Id` | `String` | `get/set` | No | `` |
| `Item` | `Table` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Subtables` | `IEnumerable<KeyValuePair<String Table>>` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Table` | `String id, String name, Boolean excluded` | `` |
| `Add` | `Table` | `String id, String name` | `` |
| `Add` | `Table` | `String id` | `` |
| `GetColunmContextTemplateBordersInSubtable` | `Boolean` | `ColumnContextTemplate columnContextTemplate, String subTableId, ref Int32 start, ref Int32 end` | `` |
| `GetExcludedTable` | `Table` | `String id` | `` |
| `GetSubTableByRowIndex` | `Table` | `Int32 rowIndex` | `` |
| `GetSubTableOffset` | `Int32` | `String subTableId` | `` |

### `TemplateSheets` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TemplateSheets` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Tables.Sheets.TemplateSheets+TemplateSheet, Topomatic.Tables, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `TemplateSheet` | `get` | No | `` |
| `Item` | `TemplateSheet` | `get` | No | `` |
| `Title` | `String` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `TemplateSheet` | `String name, String id` | `` |
| `AddTextStyle` | `Void` | `TemplateSheetTextStyle textStyle` | `` |
| `GetEnumerator` | `IEnumerator<TemplateSheet>` | `` | `` |
| `GetStyle` | `TableCellStyle` | `String name` | `` |
| `GetTextStyles` | `TemplateSheetTextStyle[]` | `` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `LoadFromXml` | `Void` | `String fileName` | `` |
| `SaveSheetToStream` | `Void` | `Stream stream, String id` | `` |
| `SaveSheetToXml` | `Void` | `String fileName, String id` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |
| `SaveToXml` | `Void` | `String fileName` | `` |

#### Nested Types (1)

- `TemplateSheet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `TemplateSheetTextStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TemplateSheetTextStyle` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Annotative` | `Boolean` | `get/set` | No | `` |
| `Backward` | `Boolean` | `get/set` | No | `` |
| `FileName` | `String` | `get/set` | No | `` |
| `Flags` | `TextFlags` | `get/set` | No | `` |
| `FontName` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `LastUsedHeight` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Oblique` | `Double` | `get/set` | No | `` |
| `Ratio` | `Double` | `get/set` | No | `` |
| `UpsideDown` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromXml` | `Void` | `XmlElement element` | `` |
| `SaveToXml` | `Void` | `XmlElement element` | `` |

#### Nested Types (1)

- `TextFlags` (enum)

### `TextFlags` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Sheets.TemplateSheetTextStyle+TextFlags` |
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
      - `Topomatic.Tables.Sheets.TemplateSheetTextStyle+TextFlags`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `TextFlags` | Yes | `Backward` | `` |
| `RefOneEntity` | `TextFlags` | Yes | `RefOneEntity` | `` |
| `Shape` | `TextFlags` | Yes | `Shape` | `` |
| `UpsideDown` | `TextFlags` | Yes | `UpsideDown` | `` |
| `value__` | `Int32` | No | `` | `` |
| `VerticalText` | `TextFlags` | Yes | `VerticalText` | `` |
| `xRef` | `TextFlags` | Yes | `xRef` | `` |
| `xRefSuccessfully` | `TextFlags` | Yes | `xRefSuccessfully` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Shape` | `1` |
| `VerticalText` | `4` |
| `xRef` | `16` |
| `xRefSuccessfully` | `32` |
| `RefOneEntity` | `64` |
| `Backward` | `128` |
| `UpsideDown` | `256` |

**Underlying Type**: `System.Int32`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 63 |
| **Classes** | 35 |
| **Interfaces** | 7 |
| **Enums** | 12 |
| **Structs** | 2 |
| **Abstract Classes** | 5 |
| **Static Classes** | 2 |
| **Total Methods** | 173 |
| **Total Properties** | 159 |
| **Total Fields** | 93 |
| **Total Events** | 0 |
| **Total Constructors** | 36 |
| **Nested Types** | 6 |
| **Extension Methods** | 0 |


