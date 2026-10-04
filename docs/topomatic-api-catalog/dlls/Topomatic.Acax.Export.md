# Topomatic.Acax.Export

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Acax.Export` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Acax.Export, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Acax.Export.dll` |

---
## Namespace: `Topomatic.Acax.Export`

### `AcaxExporter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.AcaxExporter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExportWithDialog` | `Boolean` | `ref String defaultFilename, Drawing drawing, StgDocumentOperationEventHandler additionalSettings, String[] exclude` | `` |
| `ExportWithDialog` | `Boolean` | `ref String defaultFilename, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |

### `AcaxFormat` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.AcaxFormat` |
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
      - `Topomatic.Acax.Export.AcaxFormat`

#### Fields (23)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ac2000_dwg` | `AcaxFormat` | Yes | `acR15_dwg` | `` |
| `ac2000_dxf` | `AcaxFormat` | Yes | `ac2000_dxf` | `` |
| `ac2000_Template` | `AcaxFormat` | Yes | `acR15_Template` | `` |
| `ac2004_dwg` | `AcaxFormat` | Yes | `ac2004_dwg` | `` |
| `ac2004_dxf` | `AcaxFormat` | Yes | `ac2004_dxf` | `` |
| `ac2004_Template` | `AcaxFormat` | Yes | `acR18_Template` | `` |
| `ac2007_dwg` | `AcaxFormat` | Yes | `acNative` | `` |
| `ac2007_dxf` | `AcaxFormat` | Yes | `ac2007_dxf` | `` |
| `ac2007_Template` | `AcaxFormat` | Yes | `ac2007_Template` | `` |
| `acNative` | `AcaxFormat` | Yes | `acNative` | `` |
| `acR12_dxf` | `AcaxFormat` | Yes | `acR12_dxf` | `` |
| `acR13_dwg` | `AcaxFormat` | Yes | `acR13_dwg` | `` |
| `acR13_dxf` | `AcaxFormat` | Yes | `acR13_dxf` | `` |
| `acR14_dwg` | `AcaxFormat` | Yes | `acR14_dwg` | `` |
| `acR14_dxf` | `AcaxFormat` | Yes | `acR14_dxf` | `` |
| `acR15_dwg` | `AcaxFormat` | Yes | `acR15_dwg` | `` |
| `acR15_dxf` | `AcaxFormat` | Yes | `ac2000_dxf` | `` |
| `acR15_Template` | `AcaxFormat` | Yes | `acR15_Template` | `` |
| `acR18_dwg` | `AcaxFormat` | Yes | `ac2004_dwg` | `` |
| `acR18_dxf` | `AcaxFormat` | Yes | `ac2004_dxf` | `` |
| `acR18_Template` | `AcaxFormat` | Yes | `acR18_Template` | `` |
| `acUnknown` | `AcaxFormat` | Yes | `acUnknown` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `acR12_dxf` | `1` |
| `acR13_dwg` | `4` |
| `acR13_dxf` | `5` |
| `acR14_dwg` | `8` |
| `acR14_dxf` | `9` |
| `acR15_dwg` | `12` |
| `ac2000_dwg` | `12` |
| `ac2000_dxf` | `13` |
| `acR15_dxf` | `13` |
| `ac2000_Template` | `14` |
| `acR15_Template` | `14` |
| `ac2004_dwg` | `24` |
| `acR18_dwg` | `24` |
| `ac2004_dxf` | `25` |
| `acR18_dxf` | `25` |
| `ac2004_Template` | `26` |
| `acR18_Template` | `26` |
| `acNative` | `36` |
| `ac2007_dwg` | `36` |
| `ac2007_dxf` | `37` |
| `ac2007_Template` | `38` |
| `acUnknown` | `-1` |

**Underlying Type**: `System.Int32`

### `DrawingExportProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.DrawingExportProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Extention` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToFile` | `Void` | `String path, Drawing drawing` | `` |
| `SaveToFile` | `Void` | `String path, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPreferedProvider` | `DrawingExportProvider` | `` | `` |
| `GetProvider` | `DrawingExportProvider` | `String alias` | `` |
| `GetProviders` | `IDictionary<String DrawingExportProvider>` | `` | `` |
| `IsSupported` | `Boolean` | `String alias` | `` |

### `DwrExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.DwrExportProvider` |
| **Base Type** | `Topomatic.Acax.Export.DrawingExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Acax.Export.DrawingExportProvider`
    - `Topomatic.Acax.Export.DwrExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Extention` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |

### `DwrWriter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.DwrWriter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToFile` | `Void` | `String filename, Drawing drawing, Int32 version` | `` |
| `SaveToFile` | `Void` | `String filename, Drawing drawing` | `` |
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, Int32 version` | `` |
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing` | `` |

### `Dxf2000ExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.Dxf2000ExportProvider` |
| **Base Type** | `Topomatic.Acax.Export.DrawingExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Acax.Export.DrawingExportProvider`
    - `Topomatic.Acax.Export.Dxf2000ExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Extention` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |

### `DxfR12ExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.DxfR12ExportProvider` |
| **Base Type** | `Topomatic.Acax.Export.DrawingExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Acax.Export.DrawingExportProvider`
    - `Topomatic.Acax.Export.DxfR12ExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Extention` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |

### `DxfWriter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.DxfWriter` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String fileName)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Digits` | `Int32` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginBlock` | `Void` | `String name` | `` |
| `BeginSection` | `Void` | `String name` | `` |
| `BeginTable` | `Void` | `String name, Int32 size` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndBlock` | `Void` | `` | `` |
| `EndSection` | `Void` | `` | `` |
| `EndTable` | `Void` | `` | `` |
| `WriteDouble` | `Void` | `Int32 code, Double value` | `` |
| `WriteInteger` | `Void` | `Int32 code, Int32 value` | `` |
| `WriteLayer` | `Void` | `String name, CadColor color` | `` |
| `WriteString` | `Void` | `Int32 code, String s` | `` |
| `WriteVector` | `Void` | `Int32 code, Vector3D v` | `` |
| `WriteVector` | `Void` | `Int32 code, Double x, Double y, Double z` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `DxfZipExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.DxfZipExportProvider` |
| **Base Type** | `Topomatic.Acax.Export.DrawingExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Acax.Export.DrawingExportProvider`
    - `Topomatic.Acax.Export.DxfZipExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Extention` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |

### `NativeDwpExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.NativeDwpExportProvider` |
| **Base Type** | `Topomatic.Acax.Export.DrawingExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Acax.Export.DrawingExportProvider`
    - `Topomatic.Acax.Export.NativeDwpExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Extention` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |

### `NativeXmlExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.NativeXmlExportProvider` |
| **Base Type** | `Topomatic.Acax.Export.DrawingExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Acax.Export.DrawingExportProvider`
    - `Topomatic.Acax.Export.NativeXmlExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Extention` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStream` | `Void` | `Stream stream, Drawing drawing, StgDocumentOperationEventHandler additionalSettings` | `` |

### `SimpleArray`1<T where ValueType, struct, ValueType>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.SimpleArray`1` |
| **Base Type** | `` |
| **Implements** | `, , , System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, , ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Acax.Export.SimpleArray`1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromFile` | `Void` | `String path` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `SaveToFile` | `Void` | `String path` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UnsupportedArrayVersionException` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Export.UnsupportedArrayVersionException` |
| **Base Type** | `System.InvalidOperationException` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `System.SystemException`
      - `System.InvalidOperationException`
        - `Topomatic.Acax.Export.UnsupportedArrayVersionException`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String message)`
- `.ctor(String message, Exception inner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 13 |
| **Classes** | 10 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 1 |
| **Total Methods** | 37 |
| **Total Properties** | 29 |
| **Total Fields** | 23 |
| **Total Events** | 0 |
| **Total Constructors** | 12 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


