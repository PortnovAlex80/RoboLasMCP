# Topomatic.Stg.Thumbnail

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Stg.Thumbnail` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Stg.Thumbnail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Stg.Thumbnail.dll` |

---
## Namespace: `Topomatic.Stg.Thumbnail`

### `IEIFLAG` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.Thumbnail.IEIFLAG` |
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
      - `Topomatic.Stg.Thumbnail.IEIFLAG`

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IEIFLAG_ASPECT` | `IEIFLAG` | Yes | `IEIFLAG_ASPECT` | `` |
| `IEIFLAG_ASYNC` | `IEIFLAG` | Yes | `IEIFLAG_ASYNC` | `` |
| `IEIFLAG_CACHE` | `IEIFLAG` | Yes | `IEIFLAG_CACHE` | `` |
| `IEIFLAG_GLEAM` | `IEIFLAG` | Yes | `IEIFLAG_GLEAM` | `` |
| `IEIFLAG_NOBORDER` | `IEIFLAG` | Yes | `IEIFLAG_NOBORDER` | `` |
| `IEIFLAG_NOSTAMP` | `IEIFLAG` | Yes | `IEIFLAG_NOSTAMP` | `` |
| `IEIFLAG_OFFLINE` | `IEIFLAG` | Yes | `IEIFLAG_OFFLINE` | `` |
| `IEIFLAG_ORIGSIZE` | `IEIFLAG` | Yes | `IEIFLAG_ORIGSIZE` | `` |
| `IEIFLAG_QUALITY` | `IEIFLAG` | Yes | `IEIFLAG_QUALITY` | `` |
| `IEIFLAG_REFRESH` | `IEIFLAG` | Yes | `IEIFLAG_REFRESH` | `` |
| `IEIFLAG_SCREEN` | `IEIFLAG` | Yes | `IEIFLAG_SCREEN` | `` |
| `value__` | `UInt32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `IEIFLAG_ASYNC` | `1` |
| `IEIFLAG_CACHE` | `2` |
| `IEIFLAG_ASPECT` | `4` |
| `IEIFLAG_OFFLINE` | `8` |
| `IEIFLAG_GLEAM` | `16` |
| `IEIFLAG_SCREEN` | `32` |
| `IEIFLAG_ORIGSIZE` | `64` |
| `IEIFLAG_NOSTAMP` | `128` |
| `IEIFLAG_NOBORDER` | `256` |
| `IEIFLAG_QUALITY` | `512` |
| `IEIFLAG_REFRESH` | `1024` |

**Underlying Type**: `System.UInt32`

### `IExtractImage` (interface)

**Attributes**: [Guid, InterfaceType, ComConversionLoss, ComImport]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.Thumbnail.IExtractImage` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Extract` | `Void` | `ref IntPtr phBmpThumbnail` | `` |
| `GetLocation` | `Void` | `String pszPathBuffer, UInt32 cch, ref UInt32 pdwPriority, ref SIZE prgSize, UInt32 dwRecClrDepth, ref IEIFLAG pdwFlags` | `` |

### `IThumbnailExtractor` (interface)

**Attributes**: [Guid]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.Thumbnail.IThumbnailExtractor` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBinaryHBITMAP` | `Boolean` | `String filename, Int32 size, ref IntPtr phBmpThumbnail` | `` |
| `GetXmlHBITMAP` | `Boolean` | `String filename, Int32 size, ref IntPtr phBmpThumbnail` | `` |

### `SIZE` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.Thumbnail.SIZE` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Stg.Thumbnail.SIZE`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cx` | `Int32` | No | `` | `` |
| `cy` | `Int32` | No | `` | `` |

### `StgThrumbnail` (class)

**Attributes**: [Guid]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.Thumbnail.StgThrumbnail` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Runtime.InteropServices.ComTypes.IPersistFile, Topomatic.Stg.Thumbnail.IExtractImage, Topomatic.Stg.Thumbnail.IExtractImage2` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Extract` | `Void` | `ref IntPtr phBmpThumbnail` | `` |
| `GetClassID` | `Void` | `ref Guid pClassID` | `` |
| `GetCurFile` | `Void` | `ref String ppszFileName` | `` |
| `GetDateStamp` | `Void` | `IntPtr pDateStamp` | `` |
| `GetLocation` | `Void` | `String pszPathBuffer, UInt32 cch, ref UInt32 pdwPriority, ref SIZE prgSize, UInt32 dwRecClrDepth, ref IEIFLAG pdwFlags` | `` |
| `IsDirty` | `Int32` | `` | `` |
| `Load` | `Void` | `String pszFileName, Int32 dwMode` | `` |
| `Save` | `Void` | `String pszFileName, Boolean fRemember` | `` |
| `SaveCompleted` | `Void` | `String pszFileName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPersistFile` | `GetClassID` |
| `IPersistFile` | `IsDirty` |
| `IPersistFile` | `Load` |
| `IPersistFile` | `Save` |
| `IPersistFile` | `SaveCompleted` |
| `IPersistFile` | `GetCurFile` |
| `IExtractImage` | `GetLocation` |
| `IExtractImage` | `Extract` |
| `IExtractImage2` | `GetDateStamp` |

### `ThumbnailExtractor` (class)

**Attributes**: [Guid, ClassInterface]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Stg.Thumbnail.ThumbnailExtractor` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.Thumbnail.IThumbnailExtractor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBinaryHBITMAP` | `Boolean` | `String filename, Int32 size, ref IntPtr phBmpThumbnail` | `` |
| `GetXmlHBITMAP` | `Boolean` | `String filename, Int32 size, ref IntPtr phBmpThumbnail` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IThumbnailExtractor` | `GetBinaryHBITMAP` |
| `IThumbnailExtractor` | `GetXmlHBITMAP` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 2 |
| **Interfaces** | 2 |
| **Enums** | 1 |
| **Structs** | 1 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 15 |
| **Total Properties** | 0 |
| **Total Fields** | 14 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


