# Topomatic.Stg

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Stg` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Stg.dll` |

---
## Namespace: `Topomatic.Stg`

### `IStgArray` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.IStgArray` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Stg.IStgElement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArrayDataType` | `StgType` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Object` | `get` | No | `` |
| `ItemsName` | `String` | `get/set` | No | `` |

#### Instance Methods (37)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddArray` | `IStgArray` | `StgType dataType` | `` |
| `AddBoolean` | `Void` | `Boolean value` | `` |
| `AddBoolean` | `Void` | `Boolean[] values` | `` |
| `AddByte` | `Void` | `Byte value` | `` |
| `AddByte` | `Void` | `Byte[] values, Int32 index, Int32 count` | `` |
| `AddByte` | `Void` | `Byte[] values` | `` |
| `AddChar` | `Void` | `Char value` | `` |
| `AddChar` | `Void` | `Char[] values` | `` |
| `AddDouble` | `Void` | `Double[] values` | `` |
| `AddDouble` | `Void` | `Double value` | `` |
| `AddInt16` | `Void` | `Int16[] values` | `` |
| `AddInt16` | `Void` | `Int16 value` | `` |
| `AddInt32` | `Void` | `Int32 value` | `` |
| `AddInt32` | `Void` | `Int32[] values` | `` |
| `AddInt64` | `Void` | `Int64 value` | `` |
| `AddInt64` | `Void` | `Int64[] values` | `` |
| `AddNode` | `StgNode` | `` | `` |
| `AddSingle` | `Void` | `Single value` | `` |
| `AddSingle` | `Void` | `Single[] values` | `` |
| `AddString` | `Void` | `String value` | `` |
| `AddString` | `Void` | `String[] values` | `` |
| `Copy` | `Void` | `IStgArray array` | `` |
| `EnsureCapacity` | `Void` | `Int32 capacity` | `` |
| `GetArray` | `IStgArray` | `Int32 index, StgType dataType` | `` |
| `GetBoolean` | `Boolean` | `Int32 index` | `` |
| `GetByte` | `Byte` | `Int32 index` | `` |
| `GetChar` | `Char` | `Int32 index` | `` |
| `GetDouble` | `Double` | `Int32 index` | `` |
| `GetInt16` | `Int16` | `Int32 index` | `` |
| `GetInt32` | `Int32` | `Int32 index` | `` |
| `GetInt64` | `Int64` | `Int32 index` | `` |
| `GetNode` | `StgNode` | `Int32 index` | `` |
| `GetSingle` | `Single` | `Int32 index` | `` |
| `GetString` | `String` | `Int32 index` | `` |
| `Pack` | `Void` | `Int32 index` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `RemoveRange` | `Void` | `Int32 index, Int32 count` | `` |

### `IStgDocument` (interface)

**Attributes**: [Guid]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.IStgDocument` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `StgNode` | `get` | No | `` |
| `Header` | `StgNode` | `get` | No | `` |

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ContainsClipboardRecord` | `Boolean` | `String alias` | `` |
| `LoadFromClipboard` | `Boolean` | `String alias` | `Obsolete(Message: `Use Topomatic.Controls.Clipboard LoadFromClipboard instead`)` |
| `LoadFromClipboard` | `Boolean` | `String alias, Boolean headerOnly` | `Obsolete(Message: `Use Topomatic.Controls.Clipboard LoadFromClipboard instead`)` |
| `LoadFromFileAsBinary` | `Void` | `String path` | `` |
| `LoadFromFileAsBinary` | `Void` | `String path, Boolean headerOnly, Char[] password` | `` |
| `LoadFromFileAsBinary` | `Void` | `String path, Boolean headerOnly` | `` |
| `LoadFromFileAsXml` | `Void` | `String path, Boolean headerOnly` | `` |
| `LoadFromFileAsXml` | `Void` | `String path` | `` |
| `LoadFromStreamAsBinary` | `Void` | `Stream stream, Boolean headerOnly, Char[] password` | `` |
| `LoadFromStreamAsBinary` | `Void` | `Stream stream, Boolean headerOnly` | `` |
| `LoadFromStreamAsBinary` | `Void` | `Stream stream` | `` |
| `LoadFromStreamAsXml` | `Void` | `Stream stream, Boolean headerOnly` | `` |
| `LoadFromStreamAsXml` | `Void` | `Stream stream` | `` |
| `SaveToClipboard` | `Void` | `String alias` | `Obsolete(Message: `Use Topomatic.Controls.Clipboard SaveToClipboard instead`)` |
| `SaveToFileAsBinary` | `Void` | `String path, Boolean compress, Char[] password` | `` |
| `SaveToFileAsBinary` | `Void` | `String path` | `` |
| `SaveToFileAsXml` | `Void` | `String path` | `` |
| `SaveToStreamAsBinary` | `Void` | `Stream stream` | `` |
| `SaveToStreamAsBinary` | `Void` | `Stream stream, Boolean compress, Char[] password` | `` |
| `SaveToStreamAsXml` | `Void` | `Stream stream` | `` |

### `IStgElement` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.IStgElement` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElementType` | `StgType` | `get` | No | `` |
| `Optional` | `Boolean` | `get` | No | `` |

### `IStgSerializable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.IStgSerializable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `StgArray`1<T where class>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgArray`1` |
| **Base Type** | `` |
| **Implements** | `Topomatic.Stg.IStgElement, Topomatic.Stg.IStgArray` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Stg.StgArray`1`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArrayDataType` | `StgType` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `ElementType` | `StgType` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |
| `ItemsName` | `String` | `get/set` | No | `` |
| `Optional` | `Boolean` | `get` | No | `` |

#### Instance Methods (37)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddArray` | `IStgArray` | `StgType dataType` | `` |
| `AddBoolean` | `Void` | `Boolean[] values` | `` |
| `AddBoolean` | `Void` | `Boolean value` | `` |
| `AddByte` | `Void` | `Byte[] values, Int32 index, Int32 count` | `` |
| `AddByte` | `Void` | `Byte[] values` | `` |
| `AddByte` | `Void` | `Byte value` | `` |
| `AddChar` | `Void` | `Char[] values` | `` |
| `AddChar` | `Void` | `Char value` | `` |
| `AddDouble` | `Void` | `Double[] values` | `` |
| `AddDouble` | `Void` | `Double value` | `` |
| `AddInt16` | `Void` | `Int16 value` | `` |
| `AddInt16` | `Void` | `Int16[] values` | `` |
| `AddInt32` | `Void` | `Int32[] values` | `` |
| `AddInt32` | `Void` | `Int32 value` | `` |
| `AddInt64` | `Void` | `Int64 value` | `` |
| `AddInt64` | `Void` | `Int64[] values` | `` |
| `AddNode` | `StgNode` | `` | `` |
| `AddSingle` | `Void` | `Single value` | `` |
| `AddSingle` | `Void` | `Single[] values` | `` |
| `AddString` | `Void` | `String value` | `` |
| `AddString` | `Void` | `String[] values` | `` |
| `Copy` | `Void` | `IStgArray array` | `` |
| `EnsureCapacity` | `Void` | `Int32 capacity` | `` |
| `GetArray` | `IStgArray` | `Int32 index, StgType dataType` | `` |
| `GetBoolean` | `Boolean` | `Int32 index` | `` |
| `GetByte` | `Byte` | `Int32 index` | `` |
| `GetChar` | `Char` | `Int32 index` | `` |
| `GetDouble` | `Double` | `Int32 index` | `` |
| `GetInt16` | `Int16` | `Int32 index` | `` |
| `GetInt32` | `Int32` | `Int32 index` | `` |
| `GetInt64` | `Int64` | `Int32 index` | `` |
| `GetNode` | `StgNode` | `Int32 index` | `` |
| `GetSingle` | `Single` | `Int32 index` | `` |
| `GetString` | `String` | `Int32 index` | `` |
| `Pack` | `Void` | `Int32 index` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `RemoveRange` | `Void` | `Int32 index, Int32 count` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgElement` | `get_ElementType` |
| `IStgElement` | `get_Optional` |
| `IStgArray` | `get_ArrayDataType` |
| `IStgArray` | `AddBoolean` |
| `IStgArray` | `AddBoolean` |
| `IStgArray` | `AddByte` |
| `IStgArray` | `AddByte` |
| `IStgArray` | `AddByte` |
| `IStgArray` | `AddChar` |
| `IStgArray` | `AddChar` |
| `IStgArray` | `AddDouble` |
| `IStgArray` | `AddDouble` |
| `IStgArray` | `AddSingle` |
| `IStgArray` | `AddSingle` |
| `IStgArray` | `AddInt16` |
| `IStgArray` | `AddInt16` |
| `IStgArray` | `AddInt32` |
| `IStgArray` | `AddInt32` |
| `IStgArray` | `AddInt64` |
| `IStgArray` | `AddInt64` |
| `IStgArray` | `AddString` |
| `IStgArray` | `AddString` |
| `IStgArray` | `AddArray` |
| `IStgArray` | `AddNode` |
| `IStgArray` | `GetBoolean` |
| `IStgArray` | `GetByte` |
| `IStgArray` | `GetChar` |
| `IStgArray` | `GetDouble` |
| `IStgArray` | `GetSingle` |
| `IStgArray` | `GetInt16` |
| `IStgArray` | `GetInt32` |
| `IStgArray` | `GetInt64` |
| `IStgArray` | `GetString` |
| `IStgArray` | `GetNode` |
| `IStgArray` | `GetArray` |
| `IStgArray` | `get_ItemsName` |
| `IStgArray` | `set_ItemsName` |
| `IStgArray` | `get_Count` |
| `IStgArray` | `EnsureCapacity` |
| `IStgArray` | `Topomatic.Stg.IStgArray.get_Item` |
| `IStgArray` | `Copy` |
| `IStgArray` | `Pack` |
| `IStgArray` | `RemoveAt` |
| `IStgArray` | `RemoveRange` |

### `StgCollection` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgCollection` |
| **Base Type** | `Topomatic.Stg.StgElement`1[[System.Collections.Generic.Dictionary`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgElement, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `Topomatic.Stg.IStgElement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Stg.StgElement`1[[System.Collections.Generic.Dictionary`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgElement, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Stg.StgCollection`

#### Instance Methods (42)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBoolean` | `Void` | `String name, Boolean value` | `` |
| `AddBoolean` | `Void` | `String name, Boolean value, Boolean optional` | `` |
| `AddByte` | `Void` | `String name, Byte value, Byte optional` | `` |
| `AddByte` | `Void` | `String name, Byte value` | `` |
| `AddChar` | `Void` | `String name, Char value, Char optional` | `` |
| `AddChar` | `Void` | `String name, Char value` | `` |
| `AddDouble` | `Void` | `String name, Double value, Double optional` | `` |
| `AddDouble` | `Void` | `String name, Double value` | `` |
| `AddInt16` | `Void` | `String name, Int16 value, Int16 optional` | `` |
| `AddInt16` | `Void` | `String name, Int16 value` | `` |
| `AddInt32` | `Void` | `String name, Int32 value, Int32 optional` | `` |
| `AddInt32` | `Void` | `String name, Int32 value` | `` |
| `AddInt64` | `Void` | `String name, Int64 value, Int64 optional` | `` |
| `AddInt64` | `Void` | `String name, Int64 value` | `` |
| `AddSingle` | `Void` | `String name, Single value, Single optional` | `` |
| `AddSingle` | `Void` | `String name, Single value` | `` |
| `AddString` | `Void` | `String name, String value` | `` |
| `AddString` | `Void` | `String name, String value, String optional` | `` |
| `AddUInt32` | `Void` | `String name, UInt32 value` | `` |
| `AddUInt32` | `Void` | `String name, UInt32 value, UInt32 optional` | `` |
| `GetBoolean` | `Boolean` | `String name, Boolean defaultValue` | `` |
| `GetBoolean` | `Boolean` | `String name` | `` |
| `GetByte` | `Byte` | `String name` | `` |
| `GetByte` | `Byte` | `String name, Byte defaultValue` | `` |
| `GetChar` | `Char` | `String name` | `` |
| `GetChar` | `Char` | `String name, Char defaultValue` | `` |
| `GetDouble` | `Double` | `String name` | `` |
| `GetDouble` | `Double` | `String name, Double defaultValue` | `` |
| `GetInt16` | `Int16` | `String name, Int16 defaultValue` | `` |
| `GetInt16` | `Int16` | `String name` | `` |
| `GetInt32` | `Int32` | `String name, Int32 defaultValue` | `` |
| `GetInt32` | `Int32` | `String name` | `` |
| `GetInt64` | `Int64` | `String name` | `` |
| `GetInt64` | `Int64` | `String name, Int64 defaultValue` | `` |
| `GetName` | `String` | `Int32 id` | `` |
| `GetSingle` | `Single` | `String name` | `` |
| `GetSingle` | `Single` | `String name, Single defaultValue` | `` |
| `GetString` | `String` | `String name, String defaultValue` | `` |
| `GetString` | `String` | `String name` | `` |
| `GetUInt32` | `UInt32` | `String name` | `` |
| `GetUInt32` | `UInt32` | `String name, UInt32 defaultValue` | `` |
| `IsExists` | `Boolean` | `String name` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StgDocument` (class)

**Attributes**: [Guid]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgDocument` |
| **Base Type** | `System.MarshalByRefObject` |
| **Implements** | `Topomatic.Stg.IStgDocument` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `Topomatic.Stg.StgDocument`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `StgNode` | `get` | No | `` |
| `BodyName` | `String` | `get/set` | No | `` |
| `Header` | `StgNode` | `get` | No | `` |
| `HeaderName` | `String` | `get/set` | No | `` |

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ContainsClipboardRecord` | `Boolean` | `String alias` | `Obsolete(Message: `Use Topomatic.Cad.View.Clipboard Clipboard instead`)` |
| `LoadFromClipboard` | `Boolean` | `String alias, Boolean headerOnly` | `Obsolete(Message: `Use Topomatic.Cad.View.Clipboard GetDocument instead`)` |
| `LoadFromClipboard` | `Boolean` | `String alias` | `Obsolete(Message: `Use Topomatic.Cad.View.Clipboard GetDocument instead`)` |
| `LoadFromFileAsBinary` | `Void` | `String path, Boolean headerOnly, Char[] password` | `` |
| `LoadFromFileAsBinary` | `Void` | `String path` | `` |
| `LoadFromFileAsBinary` | `Void` | `String path, Boolean headerOnly` | `` |
| `LoadFromFileAsXml` | `Void` | `String path` | `` |
| `LoadFromFileAsXml` | `Void` | `String path, Boolean headerOnly` | `` |
| `LoadFromStreamAsBinary` | `Void` | `Stream stream, Boolean headerOnly, Char[] password` | `` |
| `LoadFromStreamAsBinary` | `Void` | `Stream stream, Boolean headerOnly` | `` |
| `LoadFromStreamAsBinary` | `Void` | `Stream stream` | `` |
| `LoadFromStreamAsXml` | `Void` | `Stream stream, Boolean headerOnly` | `` |
| `LoadFromStreamAsXml` | `Void` | `Stream stream` | `` |
| `SaveToClipboard` | `Void` | `String alias` | `Obsolete(Message: `Use Topomatic.Cad.View.Clipboard SetDocument instead`)` |
| `SaveToFileAsBinary` | `Void` | `String path` | `` |
| `SaveToFileAsBinary` | `Void` | `String path, Boolean compress, Char[] password` | `` |
| `SaveToFileAsXml` | `Void` | `String path` | `` |
| `SaveToStreamAsBinary` | `Void` | `Stream stream` | `` |
| `SaveToStreamAsBinary` | `Void` | `Stream stream, Boolean compress, Char[] password` | `` |
| `SaveToStreamAsXml` | `Void` | `Stream stream` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsContainsClipboardRecord` | `Boolean` | `String alias` | `Obsolete(Message: `Use Topomatic.Cad.View.Clipboard Clipboard instead`)` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgDocument` | `get_Body` |
| `IStgDocument` | `ContainsClipboardRecord` |
| `IStgDocument` | `get_Header` |
| `IStgDocument` | `LoadFromClipboard` |
| `IStgDocument` | `LoadFromClipboard` |
| `IStgDocument` | `LoadFromFileAsBinary` |
| `IStgDocument` | `LoadFromFileAsBinary` |
| `IStgDocument` | `LoadFromFileAsBinary` |
| `IStgDocument` | `LoadFromFileAsXml` |
| `IStgDocument` | `LoadFromFileAsXml` |
| `IStgDocument` | `LoadFromStreamAsBinary` |
| `IStgDocument` | `LoadFromStreamAsBinary` |
| `IStgDocument` | `LoadFromStreamAsBinary` |
| `IStgDocument` | `LoadFromStreamAsXml` |
| `IStgDocument` | `LoadFromStreamAsXml` |
| `IStgDocument` | `SaveToClipboard` |
| `IStgDocument` | `SaveToFileAsBinary` |
| `IStgDocument` | `SaveToFileAsBinary` |
| `IStgDocument` | `SaveToFileAsXml` |
| `IStgDocument` | `SaveToStreamAsBinary` |
| `IStgDocument` | `SaveToStreamAsBinary` |
| `IStgDocument` | `SaveToStreamAsXml` |

### `StgDocumentOperationEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgDocumentOperationEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Stg.StgDocumentOperationEventArgs`

#### Constructors (1)

- `.ctor(StgDocument doc, String filename)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Document` | `StgDocument` | `get` | No | `` |
| `FileName` | `String` | `get` | No | `` |

### `StgDocumentOperationEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgDocumentOperationEventHandler` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Stg.StgDocumentOperationEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, StgDocumentOperationEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, StgDocumentOperationEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StgElement`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgElement`1` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgElement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElementType` | `StgType` | `get` | No | `` |
| `Optional` | `Boolean` | `get` | No | `` |
| `Target` | `T` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgElement` | `get_ElementType` |
| `IStgElement` | `get_Optional` |

### `StgHexWriter` (static class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgHexWriter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BytesToString` | `String` | `Byte[] buffer` | `` |
| `StringToByte` | `Byte[]` | `String s` | `` |

### `StgNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgNode` |
| **Base Type** | `Topomatic.Stg.StgCollection` |
| **Implements** | `Topomatic.Stg.IStgElement` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Stg.StgElement`1[[System.Collections.Generic.Dictionary`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgElement, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Stg.StgCollection`
      - `Topomatic.Stg.StgNode`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Attribute` | `StgCollection` | `get` | No | `` |
| `ElementType` | `StgType` | `get` | No | `` |
| `IsAttributeExists` | `Boolean` | `get` | No | `` |
| `Optional` | `Boolean` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddArray` | `IStgArray` | `String name, StgType dataType` | `` |
| `AddNode` | `StgNode` | `String name` | `` |
| `Copy` | `Void` | `StgNode node` | `` |
| `GetArray` | `IStgArray` | `String name, StgType dataType` | `` |
| `GetNode` | `StgNode` | `String name` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgElement` | `get_ElementType` |
| `IStgElement` | `get_Optional` |

### `StgType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StgType` |
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
      - `Topomatic.Stg.StgType`

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Array` | `StgType` | Yes | `Array` | `` |
| `Boolean` | `StgType` | Yes | `Boolean` | `` |
| `Byte` | `StgType` | Yes | `Byte` | `` |
| `Char` | `StgType` | Yes | `Char` | `` |
| `Double` | `StgType` | Yes | `Double` | `` |
| `Int16` | `StgType` | Yes | `Int16` | `` |
| `Int32` | `StgType` | Yes | `Int32` | `` |
| `Int64` | `StgType` | Yes | `Int64` | `` |
| `Node` | `StgType` | Yes | `Node` | `` |
| `Single` | `StgType` | Yes | `Single` | `` |
| `String` | `StgType` | Yes | `String` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Node` | `0` |
| `Array` | `1` |
| `Boolean` | `2` |
| `Byte` | `3` |
| `Char` | `4` |
| `Int16` | `5` |
| `Int32` | `6` |
| `Int64` | `7` |
| `Single` | `8` |
| `Double` | `9` |
| `String` | `10` |

**Underlying Type**: `System.Byte`

### `StreamExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.StreamExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FlushFile` | `Void` | `FileStream stream` | `Extension` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 14 |
| **Classes** | 6 |
| **Interfaces** | 4 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 2 |
| **Total Methods** | 171 |
| **Total Properties** | 27 |
| **Total Fields** | 12 |
| **Total Events** | 0 |
| **Total Constructors** | 3 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


