# Topomatic.Acax.Import.Dxf

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Acax.Import.Dxf` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Acax.Import.Dxf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Acax.Import.Dxf.dll` |

---
## Namespace: `Topomatic.Acax.Import.Dxf`

### `AcaxImporter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Import.Dxf.AcaxImporter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SupportDwg` | `Boolean` | `get` | Yes | `` |

#### Static Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Import` | `Void` | `Drawing drawing, String path, ProgressChangedEventHandler progress` | `` |
| `Import` | `Void` | `Drawing drawing, String path, Boolean logging, ProgressChangedEventHandler progress` | `` |
| `Import` | `Void` | `Drawing drawing, String path` | `` |
| `Import` | `Void` | `Drawing drawing, String path, Boolean logging` | `` |
| `ImportDwg` | `Void` | `Drawing drawing, Stream stream` | `` |
| `ImportDwg` | `Void` | `Drawing drawing, Stream stream, Boolean logging` | `` |
| `ImportDxf` | `Void` | `Drawing drawing, Stream stream` | `` |
| `ImportDxf` | `Void` | `Drawing drawing, Stream stream, Boolean logging` | `` |
| `ImportWithDialog` | `Boolean` | `Drawing drawing, ref String path` | `` |
| `ImportWithDialogMultiple` | `Boolean` | `Drawing drawing` | `` |
| `LoadUnfoundShapes` | `Void` | `Drawing drawing` | `` |
| `LoadXref` | `Void` | `Drawing drawing, DwgBlock block, String path, String prefix, Boolean recursive` | `` |
| `LoadXrefs` | `Void` | `Drawing drawing, String path` | `` |

### `DwrReader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Import.Dxf.DwrReader` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromFile` | `Void` | `String path, Drawing drawing` | `` |
| `LoadFromStream` | `Void` | `Stream stream, Drawing drawing` | `` |

### `DxfReader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Import.Dxf.DxfReader` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Stream stream)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LastCode` | `Int32` | `get` | No | `` |
| `LastDouble` | `Double` | `get` | No | `` |
| `LastInt` | `Int32` | `get` | No | `` |
| `LastString` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Read` | `Int32` | `` | `` |
| `SkeepEntity` | `Boolean` | `` | `` |
| `SkeepSection` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `InvalidDrawingException` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Import.Dxf.InvalidDrawingException` |
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
        - `Topomatic.Acax.Import.Dxf.InvalidDrawingException`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String message)`
- `.ctor(String message, Exception inner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InvalidSignatureException` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Import.Dxf.InvalidSignatureException` |
| **Base Type** | `Topomatic.Acax.Import.Dxf.InvalidDrawingException` |
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
        - `Topomatic.Acax.Import.Dxf.InvalidDrawingException`
          - `Topomatic.Acax.Import.Dxf.InvalidSignatureException`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String message)`
- `.ctor(String message, Exception inner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InvalidVersionException` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Import.Dxf.InvalidVersionException` |
| **Base Type** | `Topomatic.Acax.Import.Dxf.InvalidDrawingException` |
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
        - `Topomatic.Acax.Import.Dxf.InvalidDrawingException`
          - `Topomatic.Acax.Import.Dxf.InvalidVersionException`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String message)`
- `.ctor(String message, Exception inner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SimpleArray`1<T where ValueType, struct, ValueType>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Acax.Import.Dxf.SimpleArray`1` |
| **Base Type** | `` |
| **Implements** | `, , , System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, , ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Acax.Import.Dxf.SimpleArray`1`

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
| **Full Name** | `Topomatic.Acax.Import.Dxf.UnsupportedArrayVersionException` |
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
        - `Topomatic.Acax.Import.Dxf.UnsupportedArrayVersionException`

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
| **Total Types** | 8 |
| **Classes** | 7 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 23 |
| **Total Properties** | 5 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 15 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


