# Topomatic.Controls

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Controls` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Controls, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Controls.dll` |

---
## Namespace: `Topomatic.Controls`

### `Clipboard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Clipboard` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ContainsBinary` | `Boolean` | `` | `` |
| `ContainsDocument` | `Boolean` | `String[] alias` | `` |
| `ContainsRtfText` | `Boolean` | `` | `` |
| `ContainsText` | `Boolean` | `` | `` |
| `GetBinary` | `Byte[]` | `` | `` |
| `GetDocument` | `StgDocument` | `String alias` | `` |
| `GetDocument` | `StgDocument` | `String alias, Boolean headerOnly` | `` |
| `GetRtfText` | `String` | `` | `` |
| `GetText` | `String` | `` | `` |
| `SetBinary` | `Void` | `Byte[] data` | `` |
| `SetDocument` | `Void` | `StgDocument document, String alias` | `` |
| `SetRtfText` | `Void` | `String value` | `` |
| `SetText` | `Void` | `String value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Current` | `Clipboard` | Yes | `` | `` |

### `COMRECT` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+COMRECT` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Rectangle r)`
- `.ctor(Int32 left, Int32 top, Int32 right, Int32 bottom)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromXYWH` | `COMRECT` | `Int32 x, Int32 y, Int32 width, Int32 height` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `bottom` | `Int32` | No | `` | `` |
| `left` | `Int32` | No | `` | `` |
| `right` | `Int32` | No | `` | `` |
| `top` | `Int32` | No | `` | `` |

### `CreateMenuEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.CreateMenuEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.CreateMenuEventArgs`

#### Constructors (1)

- `.ctor(MenuAction root)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Root` | `MenuAction` | `get` | No | `` |

### `CreateMenuEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.CreateMenuEventHandler` |
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
      - `Topomatic.Controls.CreateMenuEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, CreateMenuEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, CreateMenuEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlobalHourGlassCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.GlobalHourGlassCursor` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enabled` | `Boolean` | `get/set` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `HD_HITTESTINFO` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+HD_HITTESTINFO` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+HD_HITTESTINFO`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `flags` | `UInt32` | No | `` | `` |
| `iItem` | `Int32` | No | `` | `` |
| `pt` | `POINT` | No | `` | `` |

### `HD_ITEM` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+HD_ITEM` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+HD_ITEM`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cchTextMax` | `Int32` | No | `` | `` |
| `cxy` | `Int32` | No | `` | `` |
| `fmt` | `Int32` | No | `` | `` |
| `hbm` | `IntPtr` | No | `` | `` |
| `iImage` | `Int32` | No | `` | `` |
| `iOrder` | `Int32` | No | `` | `` |
| `lParam` | `Int32` | No | `` | `` |
| `mask` | `Int32` | No | `` | `` |
| `pszText` | `String` | No | `` | `MarshalAs` |
| `pvFilter` | `IntPtr` | No | `` | `` |
| `type` | `Int32` | No | `` | `` |

### `HourGlassCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.HourGlassCursor` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enabled` | `Boolean` | `get/set` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `IMenuCreator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.IMenuCreator` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateMenuActions` | `Void` | `Object sender, CreateMenuEventArgs e` | `` |

### `ISupportAutoFill` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ISupportAutoFill` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanAutoFill` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AutoFill` | `Boolean` | `` | `` |

### `Keyboard` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Keyboard` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsKeyDown` | `Boolean` | `Keys vk` | `` |
| `IsKeyDown` | `Boolean` | `Char chr` | `` |
| `KeyPressed` | `Int32` | `Int32 min` | `` |

### `MenuAction` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.MenuAction` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Checked` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `DefaultItem` | `Boolean` | `get/set` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Hint` | `String` | `get/set` | No | `` |
| `Image` | `Image` | `get/set` | No | `` |
| `Item` | `MenuAction` | `get` | No | `` |
| `RadioCheck` | `Boolean` | `get/set` | No | `` |
| `Shortcut` | `Keys` | `get/set` | No | `` |
| `ShowShortcut` | `Boolean` | `get/set` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `MenuAction` | `String text, EventHandler<MenuActionEventArgs> onClick, Object tag, Boolean enable, Boolean check` | `` |
| `Add` | `MenuAction` | `String text, EventHandler<MenuActionEventArgs> onClick, Object tag` | `` |
| `Add` | `MenuAction` | `String text, EventHandler<MenuActionEventArgs> onClick` | `` |
| `AddSeparator` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `FillMenu` | `Void` | `ToolStripItemCollection menu` | `` |
| `GetDefaultMenu` | `MenuAction` | `` | `` |
| `Insert` | `MenuAction` | `Int32 index, String text, EventHandler<MenuActionEventArgs> onClick` | `` |
| `InsertSeparator` | `Void` | `Int32 index` | `` |
| `PerformClick` | `Void` | `Object sender, MenuActionEventArgs e` | `` |
| `PerformClick` | `Void` | `` | `` |
| `PerformClick` | `Void` | `Object sender` | `` |
| `Remove` | `Boolean` | `MenuAction item` | `` |
| `ToString` | `String` | `` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Click` | `EventHandler<MenuActionEventArgs>` | No | `` |

### `MenuActionEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.MenuActionEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.MenuActionEventArgs`

#### Constructors (1)

- `.ctor(Object tag)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Tag` | `Object` | `get` | No | `` |

### `MENUITEMINFO` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WinConst+MENUITEMINFO` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cbSize` | `Int32` | No | `` | `` |
| `cch` | `Int32` | No | `` | `` |
| `dwItemData` | `UInt32` | No | `` | `` |
| `dwTypeData` | `String` | No | `` | `` |
| `fMask` | `MIIMask` | No | `` | `` |
| `fState` | `MFState` | No | `` | `` |
| `fType` | `MFType` | No | `` | `` |
| `hbmpChecked` | `IntPtr` | No | `` | `` |
| `hbmpItem` | `IntPtr` | No | `` | `` |
| `hbmpUnchecked` | `IntPtr` | No | `` | `` |
| `hSubMenu` | `IntPtr` | No | `` | `` |
| `wID` | `Int32` | No | `` | `` |

### `MFState` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WinConst+MFState` |
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
      - `Topomatic.Controls.WinConst+MFState`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MFS_CHECKED` | `MFState` | Yes | `MFS_UNCHECKED, MFS_ENABLED, MFS_CHECKED` | `` |
| `MFS_DEFAULT` | `MFState` | Yes | `MFS_UNCHECKED, MFS_ENABLED, MFS_DEFAULT` | `` |
| `MFS_DISABLED` | `MFState` | Yes | `MFS_UNCHECKED, MFS_ENABLED, MFS_DISABLED` | `` |
| `MFS_ENABLED` | `MFState` | Yes | `MFS_UNHILITE` | `` |
| `MFS_GRAYED` | `MFState` | Yes | `MFS_UNCHECKED, MFS_ENABLED, MFS_DISABLED` | `` |
| `MFS_HILITE` | `MFState` | Yes | `MFS_UNCHECKED, MFS_ENABLED, MFS_HILITE` | `` |
| `MFS_UNCHECKED` | `MFState` | Yes | `MFS_UNHILITE` | `` |
| `MFS_UNHILITE` | `MFState` | Yes | `MFS_UNHILITE` | `` |
| `value__` | `UInt32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `MFS_UNHILITE` | `0` |
| `MFS_UNCHECKED` | `0` |
| `MFS_ENABLED` | `0` |
| `MFS_GRAYED` | `3` |
| `MFS_DISABLED` | `3` |
| `MFS_CHECKED` | `8` |
| `MFS_HILITE` | `128` |
| `MFS_DEFAULT` | `4096` |

**Underlying Type**: `System.UInt32`

### `MFType` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WinConst+MFType` |
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
      - `Topomatic.Controls.WinConst+MFType`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MFT_BITMAP` | `MFType` | Yes | `MFT_BITMAP` | `` |
| `MFT_MENUBARBREAK` | `MFType` | Yes | `MFT_MENUBARBREAK` | `` |
| `MFT_MENUBREAK` | `MFType` | Yes | `MFT_MENUBREAK` | `` |
| `MFT_OWNERDRAW` | `MFType` | Yes | `MFT_OWNERDRAW` | `` |
| `MFT_RADIOCHECK` | `MFType` | Yes | `MFT_RADIOCHECK` | `` |
| `MFT_RIGHTJUSTIFY` | `MFType` | Yes | `MFT_RIGHTJUSTIFY` | `` |
| `MFT_RIGHTORDER` | `MFType` | Yes | `MFT_RIGHTORDER` | `` |
| `MFT_SEPARATOR` | `MFType` | Yes | `MFT_SEPARATOR` | `` |
| `MFT_STRING` | `MFType` | Yes | `MFT_STRING` | `` |
| `value__` | `UInt32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `MFT_STRING` | `0` |
| `MFT_BITMAP` | `4` |
| `MFT_MENUBARBREAK` | `32` |
| `MFT_MENUBREAK` | `64` |
| `MFT_OWNERDRAW` | `256` |
| `MFT_RADIOCHECK` | `512` |
| `MFT_SEPARATOR` | `2048` |
| `MFT_RIGHTORDER` | `8192` |
| `MFT_RIGHTJUSTIFY` | `16384` |

**Underlying Type**: `System.UInt32`

### `MIIMask` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WinConst+MIIMask` |
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
      - `Topomatic.Controls.WinConst+MIIMask`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MIIM_BITMAP` | `MIIMask` | Yes | `MIIM_BITMAP` | `` |
| `MIIM_CHECKMARKS` | `MIIMask` | Yes | `MIIM_CHECKMARKS` | `` |
| `MIIM_DATA` | `MIIMask` | Yes | `MIIM_DATA` | `` |
| `MIIM_FTYPE` | `MIIMask` | Yes | `MIIM_FTYPE` | `` |
| `MIIM_ID` | `MIIMask` | Yes | `MIIM_ID` | `` |
| `MIIM_STATE` | `MIIMask` | Yes | `MIIM_STATE` | `` |
| `MIIM_STRING` | `MIIMask` | Yes | `MIIM_STRING` | `` |
| `MIIM_SUBMENU` | `MIIMask` | Yes | `MIIM_SUBMENU` | `` |
| `MIIM_TYPE` | `MIIMask` | Yes | `MIIM_TYPE` | `` |
| `value__` | `UInt32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `MIIM_STATE` | `1` |
| `MIIM_ID` | `2` |
| `MIIM_SUBMENU` | `4` |
| `MIIM_CHECKMARKS` | `8` |
| `MIIM_TYPE` | `16` |
| `MIIM_DATA` | `32` |
| `MIIM_STRING` | `64` |
| `MIIM_BITMAP` | `128` |
| `MIIM_FTYPE` | `256` |

**Underlying Type**: `System.UInt32`

### `MONITORINFO` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+MONITORINFO` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+MONITORINFO`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cbSize` | `Int32` | No | `` | `` |
| `dwFlags` | `Int32` | No | `` | `` |
| `rcMonitor` | `RECT` | No | `` | `` |
| `rcWork` | `RECT` | No | `` | `` |

### `Msg` (struct)

**Attributes**: [ComVisible, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+Msg` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+Msg`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `hwnd` | `IntPtr` | No | `` | `` |
| `lParam` | `IntPtr` | No | `` | `` |
| `message` | `Int32` | No | `` | `` |
| `pt_x` | `Int32` | No | `` | `` |
| `pt_y` | `Int32` | No | `` | `` |
| `time` | `Int32` | No | `` | `` |
| `wParam` | `IntPtr` | No | `` | `` |

### `NativeMethods` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (82)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginPaint` | `IntPtr` | `HandleRef hWnd, ref PAINTSTRUCT lpPaint` | `DllImport, PreserveSig` |
| `BitBlt` | `Boolean` | `HandleRef hDC, Int32 x, Int32 y, Int32 nWidth, Int32 nHeight, HandleRef hSrcDC, Int32 xSrc, Int32 ySrc, Int32 dwRop` | `DllImport, PreserveSig` |
| `CloseTouchInputHandle` | `Boolean` | `IntPtr hTouchInput` | `DllImport, PreserveSig` |
| `CreatePen` | `IntPtr` | `Int32 fnPenStyle, Int32 nWidth, Int32 crColor` | `DllImport, PreserveSig` |
| `DeleteObject` | `Boolean` | `IntPtr hObject` | `DllImport, PreserveSig` |
| `DestroyIcon` | `Int32` | `IntPtr hIcon` | `DllImport, PreserveSig` |
| `DestroyPropertySheetPage` | `Boolean` | `IntPtr psp` | `` |
| `DispatchMessage` | `IntPtr` | `ref Msg msg` | `DllImport, PreserveSig` |
| `DispatchMessageA` | `IntPtr` | `ref Msg msg` | `DllImport, PreserveSig` |
| `DispatchMessageW` | `IntPtr` | `ref Msg msg` | `DllImport, PreserveSig` |
| `DrawReversibleLine` | `Void` | `Int32 x1, Int32 y1, Int32 x2, Int32 y2, Int32 width, Graphics g, Color BackColor` | `` |
| `EndPaint` | `Boolean` | `HandleRef hWnd, ref PAINTSTRUCT lpPaint` | `DllImport, PreserveSig` |
| `EnumChildWindows` | `Boolean` | `HandleRef hWndParent, IntPtr lpEnumFunc, HandleRef lParam` | `DllImport, PreserveSig` |
| `ExtractIconEx` | `Int32` | `String lpszFile, Int32 nIconIndex, ref IntPtr phiconLarge, ref IntPtr phiconSmall, Int32 nIcons` | `DllImport, PreserveSig` |
| `GetAncestor` | `IntPtr` | `HandleRef hWnd, Int32 flags` | `DllImport, PreserveSig` |
| `GetAsyncKeyState` | `Int16` | `Int32 vKey` | `DllImport, PreserveSig` |
| `GetColorRop` | `Int32` | `Color color, Int32 darkROP, Int32 lightROP` | `` |
| `GetDeviceCaps` | `Int32` | `HandleRef hDC, Int32 nIndex` | `DllImport, PreserveSig` |
| `GetDialogBaseUnits` | `Int32` | `` | `DllImport, PreserveSig` |
| `GetMenuItemInfo` | `Boolean` | `HandleRef hMenu, Int32 uItem, Boolean fByPosition, MENUITEMINFO lpmii` | `DllImport, PreserveSig` |
| `GetMenuItemRect` | `Boolean` | `IntPtr hWnd, IntPtr hMenu, Int32 uItem, ref RECT lprcItem` | `DllImport, PreserveSig` |
| `GetMessageA` | `Boolean` | `ref Msg msg, HandleRef hWnd, Int32 uMsgFilterMin, Int32 uMsgFilterMax` | `DllImport, PreserveSig` |
| `GetMessageW` | `Boolean` | `ref Msg msg, HandleRef hWnd, Int32 uMsgFilterMin, Int32 uMsgFilterMax` | `DllImport, PreserveSig` |
| `GetMonitorInfo` | `Boolean` | `IntPtr hMonitor, ref MONITORINFO lpmi` | `` |
| `GetParent` | `IntPtr` | `IntPtr hWnd` | `DllImport, PreserveSig` |
| `GetScrollInfo` | `Int32` | `IntPtr hwnd, Int32 fnBar, ref SCROLLINFO lpsi` | `DllImport, PreserveSig` |
| `GetScrollPos` | `Int32` | `IntPtr hWnd, Int32 nBar` | `DllImport, PreserveSig` |
| `GetStockObject` | `IntPtr` | `Int32 fnObject` | `DllImport, PreserveSig` |
| `GetSysColor` | `Int32` | `Int32 nIndex` | `DllImport, PreserveSig` |
| `GetSystemMetrics` | `Int32` | `Int32 nIndex` | `DllImport, PreserveSig` |
| `GetTouchInputInfo` | `Boolean` | `IntPtr hTouchInput, UInt32 cInputs, TOUCHINPUT[] pInputs, Int32 cbSize` | `DllImport, PreserveSig` |
| `GetWindowDC` | `IntPtr` | `IntPtr hwnd` | `DllImport, PreserveSig` |
| `GetWindowLong` | `IntPtr` | `HandleRef hWnd, Int32 nIndex` | `` |
| `GetWindowLongPtr32` | `IntPtr` | `HandleRef hWnd, Int32 nIndex` | `DllImport, PreserveSig` |
| `GetWindowLongPtr64` | `IntPtr` | `HandleRef hWnd, Int32 nIndex` | `DllImport, PreserveSig` |
| `GetWindowRect` | `Boolean` | `IntPtr hWnd, ref RECT lpRect` | `DllImport, PreserveSig` |
| `InvalidateRect` | `Boolean` | `HandleRef hWnd, COMRECT rect, Boolean erase` | `DllImport, PreserveSig` |
| `IsDialogMessage` | `Boolean` | `HandleRef hWndDlg, ref Msg msg` | `DllImport, PreserveSig` |
| `IsWindowUnicode` | `Boolean` | `HandleRef hWnd` | `DllImport, PreserveSig` |
| `LineTo` | `Boolean` | `IntPtr hdc, Int32 nXEnd, Int32 nYEnd` | `DllImport, PreserveSig` |
| `MonitorFromPoint` | `IntPtr` | `POINT pt, Int32 dwFlags` | `DllImport, PreserveSig` |
| `MonitorFromRect` | `IntPtr` | `ref RECT lprc, Int32 dwFlags` | `DllImport, PreserveSig` |
| `MonitorFromWindow` | `IntPtr` | `HandleRef hwnd, Int32 dwFlags` | `DllImport, PreserveSig` |
| `MoveToEx` | `Boolean` | `IntPtr hdc, Int32 X, Int32 Y, POINT pt` | `DllImport, PreserveSig` |
| `MoveWindow` | `Boolean` | `IntPtr hWnd, Int32 X, Int32 Y, Int32 nWidth, Int32 nHeight, Boolean bRepaint` | `DllImport, PreserveSig` |
| `MsgWaitForMultipleObjects` | `Int32` | `Int32 nCount, IntPtr pHandles, Boolean fWaitAll, Int32 dwMilliseconds, Int32 dwWakeMask` | `DllImport, PreserveSig` |
| `MulDiv` | `Int32` | `Int32 nNumber, Int32 nNumerator, Int32 nDenominator` | `DllImport, PreserveSig` |
| `PeekMessage` | `Boolean` | `ref Msg msg, HandleRef hwnd, Int32 msgMin, Int32 msgMax, Int32 remove` | `DllImport, PreserveSig` |
| `PostMessage` | `IntPtr` | `HandleRef hwnd, Int32 msg, IntPtr wparam, IntPtr lparam` | `DllImport, PreserveSig` |
| `ProgressMessage` | `Void` | `` | `` |
| `RealizePalette` | `Int32` | `HandleRef hDC` | `DllImport, PreserveSig` |
| `RedrawWindow` | `Boolean` | `HandleRef hwnd, COMRECT rcUpdate, HandleRef hrgnUpdate, Int32 flags` | `DllImport, PreserveSig` |
| `RegisterTouchWindow` | `Boolean` | `HandleRef hWnd, UInt64 ulFlags` | `DllImport, PreserveSig` |
| `ReleaseCapture` | `Boolean` | `` | `DllImport, PreserveSig` |
| `ScrollWindow` | `Boolean` | `HandleRef hWnd, Int32 nXAmount, Int32 nYAmount, ref RECT rectScrollRegion, ref RECT rectClip` | `DllImport, PreserveSig` |
| `SelectObject` | `IntPtr` | `IntPtr hdc, IntPtr hgdiobj` | `DllImport, PreserveSig` |
| `SelectPalette` | `IntPtr` | `HandleRef hdc, HandleRef hpal, Int32 bForceBackground` | `DllImport, PreserveSig` |
| `SendMessage` | `IntPtr` | `IntPtr hWnd, Int32 msg, IntPtr wp, IntPtr lp` | `DllImport, PreserveSig` |
| `SendMessage` | `IntPtr` | `HandleRef hWnd, Int32 msg, IntPtr wParam, ref HD_HITTESTINFO lParam` | `DllImport, PreserveSig` |
| `SendMessage` | `Int32` | `IntPtr hWnd, Int32 Msg, IntPtr wParam, ref HD_ITEM hdi` | `DllImport, PreserveSig` |
| `SendMessage` | `IntPtr` | `HandleRef hWnd, Int32 msg, IntPtr wParam, IntPtr lParam` | `DllImport, PreserveSig` |
| `SendMessage` | `IntPtr` | `HandleRef hWnd, Int32 msg, Int32 wParam, Int32[] lParam` | `DllImport, PreserveSig` |
| `SetActiveWindow` | `IntPtr` | `IntPtr hWnd` | `DllImport, PreserveSig` |
| `SetCapture` | `IntPtr` | `IntPtr hwnd` | `DllImport, PreserveSig` |
| `SetFocus` | `IntPtr` | `IntPtr hwnd` | `DllImport, PreserveSig` |
| `SetMenuItemInfo` | `Boolean` | `HandleRef hMenu, Int32 uItem, Boolean fByPosition, MENUITEMINFO lpmii` | `DllImport, PreserveSig` |
| `SetParent` | `Int32` | `IntPtr hWndChild, IntPtr hWndNewParent` | `DllImport, PreserveSig` |
| `SetROP2` | `Int32` | `IntPtr hdc, Int32 fnDrawMode` | `DllImport, PreserveSig` |
| `SetScrollInfo` | `Int32` | `HandleRef hWnd, Int32 fnBar, SCROLLINFO si, Boolean redraw` | `DllImport, PreserveSig` |
| `SetScrollPos` | `Int32` | `HandleRef hWnd, Int32 nBar, Int32 nPos, Boolean bRedraw` | `DllImport, PreserveSig` |
| `SetWindowLong` | `IntPtr` | `HandleRef hWnd, Int32 nIndex, HandleRef dwNewLong` | `` |
| `SetWindowLong` | `Int64` | `IntPtr hWnd, Int32 nIndex, Int32 dwNewLong` | `DllImport, PreserveSig` |
| `SetWindowLongPtr32` | `IntPtr` | `HandleRef hWnd, Int32 nIndex, HandleRef dwNewLong` | `DllImport, PreserveSig` |
| `SetWindowLongPtr64` | `IntPtr` | `HandleRef hWnd, Int32 nIndex, HandleRef dwNewLong` | `DllImport, PreserveSig` |
| `SetWindowPos` | `Boolean` | `IntPtr hWnd, IntPtr hWndInsertAfter, Int32 X, Int32 Y, Int32 cx, Int32 cy, UInt32 uFlags` | `DllImport, PreserveSig` |
| `SetWindowTheme` | `Int32` | `IntPtr hWnd, String textSubAppName, String textSubIdList` | `DllImport, PreserveSig` |
| `SHGetFileInfo` | `IntPtr` | `String pszPath, UInt32 dwFileAttributes, ref SHFILEINFO psfi, UInt32 cbSizeFileInfo, UInt32 uFlags` | `DllImport, PreserveSig` |
| `ShowWindow` | `Boolean` | `HandleRef hWnd, Int32 nCmdShow` | `DllImport, PreserveSig` |
| `TranslateMessage` | `Boolean` | `ref Msg msg` | `DllImport, PreserveSig` |
| `UpdateWindow` | `Boolean` | `HandleRef hWnd` | `DllImport, PreserveSig` |
| `WaitMessage` | `Boolean` | `` | `DllImport, PreserveSig` |
| `WindowFromPoint` | `IntPtr` | `WIN32POINT point` | `DllImport, PreserveSig` |

#### Nested Types (14)

- `COMRECT` (class)
- `HD_HITTESTINFO` (struct)
- `HD_ITEM` (struct)
- `MONITORINFO` (struct)
- `Msg` (struct)
- `NMHDR` (struct)
- `NMHEADER` (struct)
- `PAINTSTRUCT` (struct)
- `POINT` (class)
- `RECT` (struct)
- `SCROLLINFO` (class)
- `SHFILEINFO` (struct)
- `TOUCHINPUT` (struct)
- `WIN32POINT` (struct)

### `NMHDR` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+NMHDR` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+NMHDR`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `code` | `Int32` | No | `` | `` |
| `hwndFrom` | `IntPtr` | No | `` | `` |
| `idFrom` | `IntPtr` | No | `` | `` |

### `NMHEADER` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+NMHEADER` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+NMHEADER`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `hdr` | `NMHDR` | No | `` | `` |
| `iButton` | `Int32` | No | `` | `` |
| `iItem` | `Int32` | No | `` | `` |
| `pitem` | `IntPtr` | No | `` | `` |

### `PAINTSTRUCT` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+PAINTSTRUCT` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+PAINTSTRUCT`

#### Fields (16)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `fErase` | `Boolean` | No | `` | `` |
| `fIncUpdate` | `Boolean` | No | `` | `` |
| `fRestore` | `Boolean` | No | `` | `` |
| `hdc` | `IntPtr` | No | `` | `` |
| `rcPaint_bottom` | `Int32` | No | `` | `` |
| `rcPaint_left` | `Int32` | No | `` | `` |
| `rcPaint_right` | `Int32` | No | `` | `` |
| `rcPaint_top` | `Int32` | No | `` | `` |
| `reserved1` | `Int32` | No | `` | `` |
| `reserved2` | `Int32` | No | `` | `` |
| `reserved3` | `Int32` | No | `` | `` |
| `reserved4` | `Int32` | No | `` | `` |
| `reserved5` | `Int32` | No | `` | `` |
| `reserved6` | `Int32` | No | `` | `` |
| `reserved7` | `Int32` | No | `` | `` |
| `reserved8` | `Int32` | No | `` | `` |

### `POINT` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+POINT` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 x, Int32 y)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `x` | `Int32` | No | `` | `` |
| `y` | `Int32` | No | `` | `` |

### `RECT` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+RECT` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+RECT`

#### Constructors (2)

- `.ctor(Rectangle r)`
- `.ctor(Int32 left, Int32 top, Int32 right, Int32 bottom)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Size` | `Size` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromXYWH` | `RECT` | `Int32 x, Int32 y, Int32 width, Int32 height` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `bottom` | `Int32` | No | `` | `` |
| `left` | `Int32` | No | `` | `` |
| `right` | `Int32` | No | `` | `` |
| `top` | `Int32` | No | `` | `` |

### `SCROLLINFO` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+SCROLLINFO` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 mask, Int32 min, Int32 max, Int32 page, Int32 pos)`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cbSize` | `Int32` | No | `` | `` |
| `fMask` | `Int32` | No | `` | `` |
| `nMax` | `Int32` | No | `` | `` |
| `nMin` | `Int32` | No | `` | `` |
| `nPage` | `Int32` | No | `` | `` |
| `nPos` | `Int32` | No | `` | `` |
| `nTrackPos` | `Int32` | No | `` | `` |

### `SHFILEINFO` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+SHFILEINFO` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+SHFILEINFO`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `dwAttributes` | `UInt32` | No | `` | `` |
| `hIcon` | `IntPtr` | No | `` | `` |
| `iIcon` | `IntPtr` | No | `` | `` |
| `szDisplayName` | `String` | No | `` | `MarshalAs` |
| `szTypeName` | `String` | No | `` | `MarshalAs` |

### `TextValidator` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.TextValidator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ShowErrorBalloon` | `Void` | `Control sender, String title, String text` | `` |
| `ValidateAngle` | `Void` | `Object sender, EventArgs e` | `` |
| `ValidateDouble` | `Void` | `Object sender, EventArgs e` | `` |
| `ValidateDoubleInRange` | `Void` | `Object sender, EventArgs e, Double min, Double max` | `` |
| `ValidateFileName` | `Void` | `Object sender, EventArgs e` | `` |
| `ValidateInteger` | `Void` | `Object sender, EventArgs e` | `` |
| `ValidateIntegerInRange` | `Void` | `Object sender, EventArgs e, Int32 min, Int32 max` | `` |
| `ValidatePositiveDouble` | `Void` | `Object sender, EventArgs e` | `` |
| `ValidatePositiveInteger` | `Void` | `Object sender, EventArgs e` | `` |

### `TOUCHINPUT` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+TOUCHINPUT` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+TOUCHINPUT`

### `WaitProgress` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WaitProgress` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CancellationPending` | `Boolean` | `get` | Yes | `` |

#### Static Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginProgress` | `Void` | `String caption, MethodInvoker method, Boolean canCancel` | `` |
| `BeginProgressList` | `Void` | `String caption, Action<T> method, T[] args, Boolean canCancel` | `` |
| `BeginProgressSync` | `Void` | `String caption, MethodInvoker method, Boolean canCancel` | `` |
| `ProgressChange` | `Void` | `Single progressPercentage` | `` |
| `SetProgressCaption` | `Void` | `String value` | `` |
| `WaitForProgress` | `Void` | `MethodInvoker method` | `` |
| `WaitForProgress` | `Void` | `MethodInvoker method, Boolean canCancel` | `` |
| `WaitForProgress` | `Void` | `MethodInvoker method, String caption, UInt32 tick` | `` |
| `WaitForProgress` | `Void` | `MethodInvoker method, String caption, UInt32 tick, Boolean canCancel` | `` |
| `WaitForProgressList` | `Void` | `Action<T> method, T[] args, String caption, UInt32 tick, Boolean canCancel` | `` |
| `WaitForProgressList` | `Void` | `Action<T> method, T[] args` | `` |
| `WaitForProgressList` | `Void` | `IEnumerable<Action> methods` | `` |

### `WIN32POINT` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.NativeMethods+WIN32POINT` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.NativeMethods+WIN32POINT`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `x` | `Int32` | No | `` | `` |
| `y` | `Int32` | No | `` | `` |

### `WinConst` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WinConst` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (146)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EM_SETCUEBANNER` | `Int32` | Yes | `5377` | `` |
| `GWL_EXSTYLE` | `Int32` | Yes | `-20` | `` |
| `GWL_HINSTANCE` | `Int32` | Yes | `-6` | `` |
| `GWL_HWNDPARENT` | `Int32` | Yes | `-8` | `` |
| `GWL_ID` | `Int32` | Yes | `-12` | `` |
| `GWL_STYLE` | `Int32` | Yes | `-16` | `` |
| `GWL_USERDATA` | `Int32` | Yes | `-21` | `` |
| `GWL_WNDPROC` | `Int32` | Yes | `-4` | `` |
| `HDF_BITMAP` | `Int32` | Yes | `8192` | `` |
| `HDF_BITMAP_ON_RIGHT` | `Int32` | Yes | `4096` | `` |
| `HDF_CENTER` | `Int32` | Yes | `2` | `` |
| `HDF_IMAGE` | `Int32` | Yes | `2048` | `` |
| `HDF_JUSTIFYMASK` | `Int32` | Yes | `3` | `` |
| `HDF_LEFT` | `Int32` | Yes | `0` | `` |
| `HDF_OWNERDRAW` | `Int32` | Yes | `32768` | `` |
| `HDF_RIGHT` | `Int32` | Yes | `1` | `` |
| `HDF_RTLREADING` | `Int32` | Yes | `4` | `` |
| `HDF_SORTDOWN` | `Int32` | Yes | `512` | `` |
| `HDF_SORTUP` | `Int32` | Yes | `1024` | `` |
| `HDF_STRING` | `Int32` | Yes | `16384` | `` |
| `HDI_BITMAP` | `Int32` | Yes | `16` | `` |
| `HDI_DI_SETITEM` | `Int32` | Yes | `64` | `` |
| `HDI_FILTER` | `Int32` | Yes | `256` | `` |
| `HDI_FORMAT` | `Int32` | Yes | `4` | `` |
| `HDI_HEIGHT` | `Int32` | Yes | `1` | `` |
| `HDI_IMAGE` | `Int32` | Yes | `32` | `` |
| `HDI_LPARAM` | `Int32` | Yes | `8` | `` |
| `HDI_ORDER` | `Int32` | Yes | `128` | `` |
| `HDI_TEXT` | `Int32` | Yes | `2` | `` |
| `HDI_WIDTH` | `Int32` | Yes | `1` | `` |
| `HDM_DELETEITEM` | `Int32` | Yes | `4610` | `` |
| `HDM_FIRST` | `Int32` | Yes | `4608` | `` |
| `HDM_GETITEM` | `Int32` | Yes | `4619` | `` |
| `HDM_GETITEMCOUNT` | `Int32` | Yes | `4608` | `` |
| `HDM_HITTEST` | `Int32` | Yes | `4614` | `` |
| `HDM_INSERTITEM` | `Int32` | Yes | `4618` | `` |
| `HDM_SETITEM` | `Int32` | Yes | `4620` | `` |
| `HDN_BEGINDRAG` | `Int32` | Yes | `-310` | `` |
| `HDN_BEGINTRACK` | `Int32` | Yes | `-326` | `` |
| `HDN_DIVIDERDBLCLICK` | `Int32` | Yes | `-325` | `` |
| `HDN_ENDDRAG` | `Int32` | Yes | `-311` | `` |
| `HDN_ENDTRACK` | `Int32` | Yes | `-327` | `` |
| `HDN_FILTERBTNCLICK` | `Int32` | Yes | `-313` | `` |
| `HDN_FILTERCHANGE` | `Int32` | Yes | `-312` | `` |
| `HDN_FIRST` | `Int32` | Yes | `-300` | `` |
| `HDN_GETDISPINFO` | `Int32` | Yes | `-329` | `` |
| `HDN_ITEMCHANGED` | `Int32` | Yes | `-321` | `` |
| `HDN_ITEMCHANGING` | `Int32` | Yes | `-320` | `` |
| `HDN_ITEMCLICK` | `Int32` | Yes | `-322` | `` |
| `HDN_ITEMDBLCLICK` | `Int32` | Yes | `-323` | `` |
| `HDN_TRACK` | `Int32` | Yes | `-328` | `` |
| `HDS_BUTTONS` | `Int32` | Yes | `2` | `` |
| `HDS_DRAGDROP` | `Int32` | Yes | `64` | `` |
| `HDS_FILTERBAR` | `Int32` | Yes | `256` | `` |
| `HDS_FLAT` | `Int32` | Yes | `512` | `` |
| `HDS_FULLDRAG` | `Int32` | Yes | `128` | `` |
| `HDS_HIDDEN` | `Int32` | Yes | `8` | `` |
| `HDS_HORZ` | `Int32` | Yes | `0` | `` |
| `HDS_HOTTRACK` | `Int32` | Yes | `4` | `` |
| `HHT_ABOVE` | `Int32` | Yes | `256` | `` |
| `HHT_BELOW` | `Int32` | Yes | `512` | `` |
| `HHT_NOWHERE` | `Int32` | Yes | `1` | `` |
| `HHT_ONDIVIDER` | `Int32` | Yes | `4` | `` |
| `HHT_ONDIVOPEN` | `Int32` | Yes | `8` | `` |
| `HHT_ONHEADER` | `Int32` | Yes | `2` | `` |
| `HHT_TOLEFT` | `Int32` | Yes | `2048` | `` |
| `HHT_TORIGHT` | `Int32` | Yes | `1024` | `` |
| `HWND_BOTTOM` | `IntPtr` | Yes | `` | `` |
| `HWND_NOTOPMOST` | `IntPtr` | Yes | `` | `` |
| `HWND_TOP` | `IntPtr` | Yes | `` | `` |
| `HWND_TOPMOST` | `IntPtr` | Yes | `` | `` |
| `MA_ACTIVATE` | `UInt32` | Yes | `1` | `` |
| `MA_ACTIVATEANDEAT` | `UInt32` | Yes | `2` | `` |
| `MA_NOACTIVATE` | `UInt32` | Yes | `3` | `` |
| `MA_NOACTIVATEANDEAT` | `UInt32` | Yes | `4` | `` |
| `MONITOR_DEFAULTTONEAREST` | `Int32` | Yes | `2` | `` |
| `MONITOR_DEFAULTTONULL` | `Int32` | Yes | `0` | `` |
| `MONITOR_DEFAULTTOPRIMARY` | `Int32` | Yes | `1` | `` |
| `OCM__BASE` | `Int32` | Yes | `8192` | `` |
| `OCM_NOTIFY` | `Int32` | Yes | `8270` | `` |
| `PM_REMOVE` | `Int32` | Yes | `1` | `` |
| `SB_HORZ` | `Int32` | Yes | `0` | `` |
| `SB_VERT` | `Int32` | Yes | `1` | `` |
| `SHGFI_DISPLAYNAME` | `UInt32` | Yes | `512` | `` |
| `SHGFI_ICON` | `UInt32` | Yes | `256` | `` |
| `SHGFI_LARGEICON` | `UInt32` | Yes | `0` | `` |
| `SHGFI_SMALLICON` | `UInt32` | Yes | `1` | `` |
| `SHGFI_TYPENAME` | `UInt32` | Yes | `1024` | `` |
| `SM_CXSIZE` | `Int32` | Yes | `30` | `` |
| `SM_CYSIZE` | `Int32` | Yes | `31` | `` |
| `SWP_ASYNCWINDOWPOS` | `UInt32` | Yes | `16384` | `` |
| `SWP_DEFERERASE` | `UInt32` | Yes | `8192` | `` |
| `SWP_DRAWFRAME` | `UInt32` | Yes | `32` | `` |
| `SWP_FRAMECHANGED` | `UInt32` | Yes | `32` | `` |
| `SWP_HIDEWINDOW` | `UInt32` | Yes | `128` | `` |
| `SWP_NOACTIVATE` | `UInt32` | Yes | `16` | `` |
| `SWP_NOCOPYBITS` | `UInt32` | Yes | `256` | `` |
| `SWP_NOMOVE` | `UInt32` | Yes | `2` | `` |
| `SWP_NOOWNERZORDER` | `UInt32` | Yes | `512` | `` |
| `SWP_NOREDRAW` | `UInt32` | Yes | `8` | `` |
| `SWP_NOREPOSITION` | `UInt32` | Yes | `512` | `` |
| `SWP_NOSENDCHANGING` | `UInt32` | Yes | `1024` | `` |
| `SWP_NOSIZE` | `UInt32` | Yes | `1` | `` |
| `SWP_NOZORDER` | `UInt32` | Yes | `4` | `` |
| `SWP_SHOWWINDOW` | `UInt32` | Yes | `64` | `` |
| `TVS_EX_AUTOHSCROLL` | `Int32` | Yes | `32` | `` |
| `TVS_EX_DIMMEDCHECKBOXES` | `Int32` | Yes | `512` | `` |
| `TVS_EX_DOUBLEBUFFER` | `Int32` | Yes | `4` | `` |
| `TVS_EX_DRAWIMAGEASYNC` | `Int32` | Yes | `1024` | `` |
| `TVS_EX_EXCLUSIONCHECKBOXES` | `Int32` | Yes | `256` | `` |
| `TVS_EX_FADEINOUTEXPANDOS` | `Int32` | Yes | `64` | `` |
| `TVS_EX_MULTISELECT` | `Int32` | Yes | `2` | `` |
| `TVS_EX_NOINDENTSTATE` | `Int32` | Yes | `8` | `` |
| `TVS_EX_PARTIALCHECKBOXES` | `Int32` | Yes | `128` | `` |
| `TVS_EX_RICHTOOLTIP` | `Int32` | Yes | `16` | `` |
| `VK_LBUTTON` | `Int32` | Yes | `1` | `` |
| `WM_ACTIVATE` | `Int32` | Yes | `134` | `` |
| `WM_ERASEBKGND` | `Int32` | Yes | `20` | `` |
| `WM_GETTEXT` | `Int32` | Yes | `13` | `` |
| `WM_KEYDOWN` | `Int32` | Yes | `256` | `` |
| `WM_LBUTTONDBLCLK` | `Int32` | Yes | `515` | `` |
| `WM_LBUTTONDOWN` | `Int32` | Yes | `513` | `` |
| `WM_LBUTTONUP` | `Int32` | Yes | `514` | `` |
| `WM_MOUSEACTIVATE` | `Int32` | Yes | `33` | `` |
| `WM_MOUSEMOVE` | `Int32` | Yes | `512` | `` |
| `WM_MOUSEWHEEL` | `Int32` | Yes | `522` | `` |
| `WM_MOVE` | `Int32` | Yes | `3` | `` |
| `WM_NCACTIVATE` | `Int32` | Yes | `134` | `` |
| `WM_NCCREATE` | `Int32` | Yes | `129` | `` |
| `WM_NCHITTEST` | `Int32` | Yes | `132` | `` |
| `WM_NCLBUTTONDBLCLK` | `Int32` | Yes | `163` | `` |
| `WM_NCLBUTTONDOWN` | `Int32` | Yes | `161` | `` |
| `WM_NCLBUTTONUP` | `Int32` | Yes | `162` | `` |
| `WM_NCMOUSEMOVE` | `Int32` | Yes | `160` | `` |
| `WM_NCPAINT` | `Int32` | Yes | `133` | `` |
| `WM_NOTIFY` | `Int32` | Yes | `78` | `` |
| `WM_PAINT` | `Int32` | Yes | `15` | `` |
| `WM_SETCURSOR` | `Int32` | Yes | `32` | `` |
| `WM_SETFONT` | `Int32` | Yes | `48` | `` |
| `WM_SIZE` | `Int32` | Yes | `5` | `` |
| `WM_SYNCPAINT` | `Int32` | Yes | `136` | `` |
| `WM_TOUCH` | `Int32` | Yes | `576` | `` |
| `WM_USER` | `Int32` | Yes | `1024` | `` |
| `WM_WINDOWPOSCHANGING` | `Int32` | Yes | `70` | `` |
| `WS_CHILD` | `Int32` | Yes | `1073741824` | `` |
| `WS_VISIBLE` | `Int32` | Yes | `268435456` | `` |

#### Nested Types (4)

- `MENUITEMINFO` (class)
- `MFState` (enum)
- `MFType` (enum)
- `MIIMask` (enum)

### `WindowsMessageEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WindowsMessageEventArgs` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Message msg)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Handled` | `Boolean` | `get/set` | No | `` |
| `Message` | `Message` | `get/set` | No | `` |

### `WindowsMessageEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.WindowsMessageEventHandler` |
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
      - `Topomatic.Controls.WindowsMessageEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, WindowsMessageEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, WindowsMessageEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Controls.Common`

### `CanChangeSelectedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.CanChangeSelectedEventArgs` |
| **Base Type** | `System.ComponentModel.CancelEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `System.ComponentModel.CancelEventArgs`
      - `Topomatic.Controls.Common.CanChangeSelectedEventArgs`

#### Constructors (1)

- `.ctor(Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |

### `ContextMenuEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ContextMenuEx` |
| **Base Type** | `System.Windows.Forms.ContextMenuStrip` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.ISupportToolStripPanel` |
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
          - `System.Windows.Forms.ToolStrip`
            - `System.Windows.Forms.ToolStripDropDown`
              - `System.Windows.Forms.ToolStripDropDownMenu`
                - `System.Windows.Forms.ContextMenuStrip`
                  - `Topomatic.Controls.Common.ContextMenuEx`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(MenuItemEx[] menuItems)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DividerDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.DividerLine+DividerDirection` |
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
      - `Topomatic.Controls.Common.DividerLine+DividerDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Horizontal` | `DividerDirection` | Yes | `Horizontal` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Vertical` | `DividerDirection` | Yes | `Vertical` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Vertical` | `0` |
| `Horizontal` | `1` |

**Underlying Type**: `System.Int32`

### `DividerLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.DividerLine` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.DividerLine`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackColor` | `Color` | `get/set` | No | `Browsable, EditorBrowsable, Bindable` |
| `BackgroundImage` | `Image` | `get/set` | No | `EditorBrowsable, Browsable, Bindable` |
| `BackgroundImageLayout` | `ImageLayout` | `get/set` | No | `Browsable, Bindable, EditorBrowsable` |
| `Direction` | `DividerDirection` | `get/set` | No | `` |
| `Font` | `Font` | `get/set` | No | `Browsable, Bindable, EditorBrowsable` |
| `ForeColor` | `Color` | `get/set` | No | `Bindable, Browsable, EditorBrowsable` |
| `TabStop` | `Boolean` | `get/set` | No | `Bindable, EditorBrowsable, Browsable` |
| `Text` | `String` | `get/set` | No | `EditorBrowsable, Bindable, Browsable` |

#### Nested Types (1)

- `DividerDirection` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DockDirection` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.DockDirection` |
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
      - `Topomatic.Controls.Common.DockDirection`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `DockDirection` | Yes | `All` | `` |
| `Bottom` | `DockDirection` | Yes | `Bottom` | `` |
| `Horizontal` | `DockDirection` | Yes | `Horizontal` | `` |
| `Left` | `DockDirection` | Yes | `Left` | `` |
| `Right` | `DockDirection` | Yes | `Right` | `` |
| `Top` | `DockDirection` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Vertical` | `DockDirection` | Yes | `Vertical` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `1` |
| `Right` | `2` |
| `Horizontal` | `3` |
| `Top` | `4` |
| `Bottom` | `8` |
| `Vertical` | `12` |
| `All` | `15` |

**Underlying Type**: `System.Int32`

### `DockPanel` (class)

**Attributes**: [ToolboxItem]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.DockPanel` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanClose` | `Boolean` | `get/set` | No | `` |
| `DockDirection` | `DockDirection` | `get/set` | No | `` |
| `DockState` | `DockState` | `get/set` | No | `` |
| `FloatingRect` | `Rectangle` | `get/set` | No | `` |
| `Image` | `Image` | `get/set` | No | `` |
| `Owner` | `MultiDock` | `get/set` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |
| `UserControl` | `Control` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `VisibleCoreChanged` | `EventHandler` | No | `` |

### `DockState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.DockState` |
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
      - `Topomatic.Controls.Common.DockState`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dockable` | `DockState` | Yes | `Dockable` | `` |
| `Floating` | `DockState` | Yes | `Floating` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Floating` | `0` |
| `Dockable` | `1` |

**Underlying Type**: `System.Int32`

### `DoubleBufferedListViewEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.DoubleBufferedListViewEx` |
| **Base Type** | `Topomatic.Controls.Common.ListViewEx` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ListView`
          - `Topomatic.Controls.Common.ListViewEx`
            - `Topomatic.Controls.Common.DoubleBufferedListViewEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FilterableCheckedListBox` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.FilterableCheckedListBox` |
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
              - `Topomatic.Controls.Common.FilterableCheckedListBox`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `IEnumerable<T>` | `` | `` |
| `Filter` | `Void` | `String pattern` | `` |
| `GetFilteredIndexes` | `Int32[]` | `ref Int32[] selectedIndex` | `` |
| `Init` | `Void` | `IEnumerable<KeyValuePair<T Boolean>> items, String pattern, Int32 selectIndex` | `` |
| `Init` | `Void` | `IEnumerable<KeyValuePair<T Boolean>> items` | `` |
| `Init` | `Void` | `IEnumerable<KeyValuePair<T Boolean>> items, IEnumerable<Int32> locked, String lockedMsg, String pattern, Int32 selectIndex` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `CheckedChanged` | `EventHandler<FilterableCheckedListBoxCheckedChangeEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FilterableCheckedListBoxCheckedChangeEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.FilterableCheckedListBoxCheckedChangeEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.Common.FilterableCheckedListBoxCheckedChangeEventArgs`

#### Constructors (1)

- `.ctor(Object item, Int32 index, Boolean isChecked)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Checked` | `Boolean` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `Item` | `Object` | `get` | No | `` |

### `FormHeaderControl` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.FormHeaderControl` |
| **Base Type** | `System.Windows.Forms.NativeWindow` |
| **Implements** | `System.Windows.Forms.IWin32Window` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.Windows.Forms.NativeWindow`
      - `Topomatic.Controls.Common.FormHeaderControl`

#### Constructors (1)

- `.ctor(Form parent)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackColor` | `Color` | `get/set` | No | `` |
| `BorderSize` | `Int32` | `get` | No | `` |
| `Capture` | `Boolean` | `get` | No | `` |
| `ClientRectangle` | `Rectangle` | `get` | No | `` |
| `ClientSize` | `Size` | `get/set` | No | `` |
| `HeaderSize` | `Int32` | `get` | No | `` |
| `Height` | `Int32` | `get/set` | No | `` |
| `Left` | `Int32` | `get/set` | No | `` |
| `Location` | `Point` | `get/set` | No | `` |
| `Parent` | `Form` | `get` | No | `` |
| `Pressed` | `Boolean` | `get` | No | `` |
| `Top` | `Int32` | `get/set` | No | `` |
| `Width` | `Int32` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Refresh` | `Void` | `` | `` |

#### Events (3)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Click` | `EventHandler` | No | `` |
| `Paint` | `PaintEventHandler` | No | `` |
| `PaintBackground` | `PaintEventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GdiHelp` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.GdiHelp` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (39)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateBorderPath` | `GraphicsPath` | `Rectangle rect, Single cut` | `` |
| `CreateBottomRoundRectangle` | `GraphicsPath` | `Rectangle rectangle, Int32 radius` | `` |
| `CreateClipBorderPath` | `GraphicsPath` | `Rectangle rect, Single cut` | `` |
| `CreateInsideBorderPath` | `GraphicsPath` | `Rectangle rect, Single cut` | `` |
| `CreateRoundRectangle` | `GraphicsPath` | `Rectangle rectangle, Int32 radius` | `` |
| `CreateScaledSize` | `Size` | `Int32 width, Int32 height` | `` |
| `CreateTopRoundRectangle` | `GraphicsPath` | `Rectangle rectangle, Int32 radius` | `` |
| `DrawAeroHilighted` | `Void` | `Graphics g, Rectangle bounds, Int32 alpha` | `` |
| `DrawArrowDown` | `Void` | `Graphics g, Color color, Int32 x, Int32 y` | `` |
| `DrawArrowLeft` | `Void` | `Graphics g, Color color, Int32 x, Int32 y` | `` |
| `DrawArrowRight` | `Void` | `Graphics g, Color color, Int32 x, Int32 y` | `` |
| `DrawArrowUp` | `Void` | `Graphics g, Color color, Int32 x, Int32 y` | `` |
| `DrawBody` | `Void` | `Graphics g, Rectangle rect, Image image` | `` |
| `DrawButtonBody` | `Void` | `Graphics g, Rectangle rect, PushButtonState state, Single cut, Boolean horizontal` | `` |
| `DrawButtonBody` | `Void` | `Graphics g, Rectangle rect, PushButtonState state, Single cut` | `` |
| `DrawButtonBody` | `Void` | `Graphics g, Rectangle rect, PushButtonState state` | `` |
| `DrawButtonImage` | `Void` | `Graphics g, Rectangle buttonRect, Image image, Boolean enabled` | `` |
| `DrawDropDownButton` | `Void` | `Graphics g, Rectangle rect, PushButtonState state` | `` |
| `DrawGradientBorderHorizontal` | `Void` | `Graphics g, Rectangle bounds, GradientItemColors colors, Single cut` | `` |
| `DrawGradientItem` | `Void` | `Graphics g, GraphicsPath path, GradientItemColors colors, Single offset` | `` |
| `DrawGradientItem` | `Void` | `Graphics g, Rectangle backRect, GradientItemColors colors, Single cut, Single offset` | `` |
| `DrawGradientItem` | `Void` | `Graphics g, Rectangle backRect, GradientItemColors colors, Single cut, Single offset, Boolean horizontal` | `` |
| `DrawGridFitText` | `Void` | `Graphics g, String text, Font font, Single x, Single y, Color color` | `` |
| `DrawImageScaled` | `Void` | `Graphics self, Image image, Single x, Single y, Single w, Single h` | `Extension` |
| `DrawModalButton` | `Void` | `Graphics g, Rectangle rect, PushButtonState state` | `` |
| `DrawSeparator` | `Void` | `Graphics g, Boolean vertical, Rectangle rect, Pen lightPen, Pen darkPen, Int32 horizontalInsetLeft, Int32 horizontalInsetRight, Boolean rtl` | `` |
| `DrawShadow` | `Void` | `Graphics g, Rectangle rect, Int32 size` | `` |
| `FillBackground` | `Void` | `Graphics g, Rectangle bounds, Color backColor` | `` |
| `GetCurrentDpi` | `SizeF` | `Control control` | `` |
| `GetGuiScaling` | `Single` | `` | `` |
| `GetScaleFactor` | `SizeF` | `Control control` | `` |
| `GetSingleLineString` | `String` | `String s` | `` |
| `MeasureCaption` | `String` | `String s, Font font, Int32 width` | `` |
| `MeasurePath` | `String` | `String s, Font font, Int32 width, Char delimer` | `` |
| `MeasureText` | `Size` | `String text, Font font, Boolean fit` | `` |
| `MeasureText` | `Size` | `String text, Font font` | `` |
| `MeasureTextF` | `SizeF` | `String text, Font font, Boolean fit` | `` |
| `RenderSmall3DBorderInternal` | `Void` | `Graphics g, Rectangle bounds, ToolBarState state, Boolean rightToLeft` | `` |
| `ToRectangle` | `Rectangle` | `RectangleF self` | `Extension` |

### `GradientItemColors` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.GradientItemColors` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Color insideTop1, Color insideTop2, Color insideBottom1, Color insideBottom2, Color fillTop1, Color fillTop2, Color fillBottom1, Color fillBottom2, Color border1, Color border2)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemAeroMenuPressed` | `GradientItemColors` | `get` | Yes | `` |
| `ItemBlueMenuHot` | `GradientItemColors` | `get` | Yes | `` |
| `ItemBlueMenuPressed` | `GradientItemColors` | `get` | Yes | `` |
| `ItemGrayColors` | `GradientItemColors` | `get` | Yes | `` |
| `ItemOrangeHot` | `GradientItemColors` | `get` | Yes | `` |
| `ItemSilverDisabled` | `GradientItemColors` | `get` | Yes | `` |
| `ItemSilverHot` | `GradientItemColors` | `get` | Yes | `` |
| `ItemSilverNormal` | `GradientItemColors` | `get` | Yes | `` |
| `ItemSilverPressed` | `GradientItemColors` | `get` | Yes | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Border1` | `Color` | No | `` | `` |
| `Border2` | `Color` | No | `` | `` |
| `FillBottom1` | `Color` | No | `` | `` |
| `FillBottom2` | `Color` | No | `` | `` |
| `FillTop1` | `Color` | No | `` | `` |
| `FillTop2` | `Color` | No | `` | `` |
| `InsideBottom1` | `Color` | No | `` | `` |
| `InsideBottom2` | `Color` | No | `` | `` |
| `InsideTop1` | `Color` | No | `` | `` |
| `InsideTop2` | `Color` | No | `` | `` |

### `GroupPanel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.GroupPanel` |
| **Base Type** | `System.Windows.Forms.Panel` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
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
          - `System.Windows.Forms.Panel`
            - `Topomatic.Controls.Common.GroupPanel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackColor` | `Color` | `get/set` | No | `Bindable, DesignerSerializationVisibility, EditorBrowsable, Browsable` |
| `EndForeColor` | `Color` | `get/set` | No | `Category` |
| `StartForeColor` | `Color` | `get/set` | No | `Category` |
| `Text` | `String` | `get/set` | No | `EditorBrowsable, Browsable, Localizable, DesignerSerializationVisibility, Bindable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeaderButton` (class)

**Attributes**: [ToolboxItem]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HeaderButton` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.HeaderButton`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Image` | `Image` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeaderControl` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HeaderControl` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.HeaderControl`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Clickable` | `Boolean` | `get/set` | No | `DefaultValue` |
| `DragReorder` | `Boolean` | `get/set` | No | `DefaultValue` |
| `Filterbar` | `Boolean` | `get/set` | No | `DefaultValue` |
| `Flat` | `Boolean` | `get/set` | No | `DefaultValue` |
| `FullDrag` | `Boolean` | `get/set` | No | `DefaultValue` |
| `Hidden` | `Boolean` | `get/set` | No | `DefaultValue` |
| `HotTrack` | `Boolean` | `get/set` | No | `DefaultValue` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `String text, HorizontalAlignment align, Int32 width, HeaderSortMarker sortMarker` | `` |
| `Delete` | `Void` | `Int32 index` | `` |
| `GetCount` | `Int32` | `` | `` |
| `GetSortMarker` | `HeaderSortMarker` | `Int32 index` | `` |
| `GetState` | `Void` | `Int32 index, ref String text, ref HorizontalAlignment align, ref Int32 width, ref HeaderSortMarker sortMarker` | `` |
| `GetWidth` | `Int32` | `Int32 index` | `` |
| `Insert` | `Int32` | `Int32 index, String text, HorizontalAlignment align, Int32 width, HeaderSortMarker sortMarker` | `` |
| `SetSortMarker` | `Void` | `Int32 index, HeaderSortMarker sortMarker` | `` |
| `SetState` | `Void` | `Int32 index, String text, HorizontalAlignment align, Int32 width, HeaderSortMarker sortMarker` | `` |
| `SetWidth` | `Void` | `Int32 index, Int32 width` | `` |

#### Events (7)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `HeaderAfterTrack` | `HeaderControlEventHandler` | No | `` |
| `HeaderBeforeTrack` | `HeaderControlCancelEventHandler` | No | `` |
| `HeaderClick` | `HeaderControlEventHandler` | No | `` |
| `HeaderDoubleClick` | `HeaderControlEventHandler` | No | `` |
| `HeaderTracking` | `HeaderControlEventHandler` | No | `` |
| `ItemChanged` | `HeaderControlEventHandler` | No | `` |
| `ItemChanging` | `HeaderControlCancelEventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeaderControlCancelEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HeaderControlCancelEventArgs` |
| **Base Type** | `Topomatic.Controls.Common.HeaderControlEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.Common.HeaderControlEventArgs`
      - `Topomatic.Controls.Common.HeaderControlCancelEventArgs`

#### Constructors (1)

- `.ctor(Int32 index, MouseButtons button, Boolean cancel)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cancel` | `Boolean` | `get/set` | No | `` |

### `HeaderControlCancelEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HeaderControlCancelEventHandler` |
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
      - `Topomatic.Controls.Common.HeaderControlCancelEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, HeaderControlCancelEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, HeaderControlCancelEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeaderControlEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HeaderControlEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.Common.HeaderControlEventArgs`

#### Constructors (1)

- `.ctor(Int32 index, MouseButtons button)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Button` | `MouseButtons` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |

### `HeaderControlEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HeaderControlEventHandler` |
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
      - `Topomatic.Controls.Common.HeaderControlEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, HeaderControlEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, HeaderControlEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeaderSortMarker` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HeaderSortMarker` |
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
      - `Topomatic.Controls.Common.HeaderSortMarker`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Down` | `HeaderSortMarker` | Yes | `Down` | `` |
| `None` | `HeaderSortMarker` | Yes | `None` | `` |
| `Up` | `HeaderSortMarker` | Yes | `Up` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Down` | `512` |
| `Up` | `1024` |

**Underlying Type**: `System.Int32`

### `HiddenCheckBoxNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.TreeViewEx+HiddenCheckBoxNode` |
| **Base Type** | `System.Windows.Forms.TreeNode` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.Windows.Forms.TreeNode`
      - `Topomatic.Controls.Common.TreeViewEx+HiddenCheckBoxNode`

#### Constructors (5)

- `.ctor()` - **Default constructor**
- `.ctor(String text)`
- `.ctor(String text, TreeNode[] children)`
- `.ctor(String text, Int32 imageIndex, Int32 selectedImageIndex)`
- `.ctor(String text, Int32 imageIndex, Int32 selectedImageIndex, TreeNode[] children)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HighSpeedAntiAlias` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.HighSpeedAntiAlias` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Graphics g)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `IAppend<T where class>` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.TreeViewIndex`1+IAppend` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Append` | `IAppend<T>` | `String caption, T value` | `` |

### `IconExtensions` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.IconExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExtractAssociatedDisplayName` | `String` | `String path` | `` |
| `ExtractAssociatedIcon` | `Icon` | `String path, Boolean small` | `` |
| `ExtractAssociatedTypeName` | `String` | `String path` | `` |
| `ExtractLargeIcon` | `Icon` | `Icon icon` | `` |
| `ExtractSmallIcon` | `Icon` | `String file` | `` |
| `ExtractSmallIcon` | `Icon` | `Icon icon` | `` |

### `InitializeFloatFormEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.InitializeFloatFormEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.Common.InitializeFloatFormEventArgs`

#### Constructors (1)

- `.ctor(Form floatForm)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FloatForm` | `Form` | `get` | No | `` |

### `InitializeFloatFormEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.InitializeFloatFormEventHandler` |
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
      - `Topomatic.Controls.Common.InitializeFloatFormEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, InitializeFloatFormEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, InitializeFloatFormEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ListViewEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ListViewEx` |
| **Base Type** | `System.Windows.Forms.ListView` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ListView`
          - `Topomatic.Controls.Common.ListViewEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Focused` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `UpdateTheme` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MenuItemEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MenuItemEx` |
| **Base Type** | `System.Windows.Forms.ToolStripMenuItem` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.IDropTarget, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.ToolStripItem`
        - `System.Windows.Forms.ToolStripDropDownItem`
          - `System.Windows.Forms.ToolStripMenuItem`
            - `Topomatic.Controls.Common.MenuItemEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultItem` | `Boolean` | `get/set` | No | `` |
| `RadioCheck` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MenuStripEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MenuStripEx` |
| **Base Type** | `System.Windows.Forms.MenuStrip` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.ISupportToolStripPanel` |
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
          - `System.Windows.Forms.ToolStrip`
            - `System.Windows.Forms.MenuStrip`
              - `Topomatic.Controls.Common.MenuStripEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MultiDock` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MultiDock` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.MultiDock`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActivePanel` | `DockPanel` | `get/set` | No | `DesignerSerializationVisibility` |
| `AutoHide` | `Boolean` | `get/set` | No | `` |
| `Dock` | `DockStyle` | `get/set` | No | `` |
| `Focused` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `DockPanel` | `String text, Image image, Control userControl` | `` |
| `IndexOf` | `Int32` | `DockPanel panel` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MultiDockHeader` (class)

**Attributes**: [ToolboxItem]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MultiDockHeader` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.MultiDockHeader`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CloseButton` | `HeaderButton` | `get` | No | `` |
| `CloseButtonVisible` | `Boolean` | `get/set` | No | `` |
| `Collapsed` | `Boolean` | `get/set` | No | `` |
| `DockButton` | `HeaderButton` | `get` | No | `` |
| `DockButtonVisible` | `Boolean` | `get/set` | No | `` |
| `DrawBorder` | `Boolean` | `get/set` | No | `` |
| `MenuButton` | `HeaderButton` | `get` | No | `` |
| `MenuButtonVisible` | `Boolean` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MultiDockTab` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MultiDockTab` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Image` | `Image` | `get/set` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

### `MultiDockTabCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MultiDockTabCollection` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `MultiDockTab` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `MultiDockTab` | `String text` | `` |
| `Add` | `MultiDockTab` | `String text, Image image` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `MultiDockTab item` | `` |
| `CopyTo` | `Void` | `MultiDockTab[] array, Int32 arrayIndex` | `` |
| `IndexOf` | `Int32` | `MultiDockTab item` | `` |
| `Remove` | `Boolean` | `MultiDockTab item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

### `MultiDockTabs` (class)

**Attributes**: [ToolboxItem, DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MultiDockTabs` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.MultiDockTabs`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanSelectTab` | `Boolean` | `get/set` | No | `` |
| `Direction` | `MultiDockTabsDirection` | `get/set` | No | `` |
| `HighlitedTab` | `MultiDockTab` | `get/set` | No | `` |
| `Item` | `MultiDockTab` | `get` | No | `` |
| `Items` | `MultiDockTabCollection` | `get` | No | `` |
| `SelectedIndex` | `Int32` | `get/set` | No | `` |
| `SelectedTab` | `MultiDockTab` | `get/set` | No | `` |

#### Events (4)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AddTab` | `EventHandler` | No | `` |
| `HighlinedTabChange` | `EventHandler` | No | `` |
| `RemoveTab` | `EventHandler` | No | `` |
| `SelectedChange` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MultiDockTabsDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.MultiDockTabsDirection` |
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
      - `Topomatic.Controls.Common.MultiDockTabsDirection`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `MultiDockTabsDirection` | Yes | `Bottom` | `` |
| `Left` | `MultiDockTabsDirection` | Yes | `Left` | `` |
| `Right` | `MultiDockTabsDirection` | Yes | `Right` | `` |
| `Top` | `MultiDockTabsDirection` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Top` | `0` |
| `Bottom` | `1` |
| `Left` | `2` |
| `Right` | `3` |

**Underlying Type**: `System.Int32`

### `PageItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.PageItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String caption)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |
| `Key` | `Object` | `get/set` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |

### `Pages` (class)

**Attributes**: [DefaultMember, ToolboxBitmap]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.Pages` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.Pages`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `HilightedPageIndex` | `Int32` | `get/set` | No | `` |
| `Item` | `PageItem` | `get` | No | `` |
| `MaximumSize` | `Size` | `get/set` | No | `` |
| `MinimumSize` | `Size` | `get/set` | No | `` |
| `PreferedHeight` | `Int32` | `get` | No | `` |
| `SelectedItem` | `PageItem` | `get` | No | `` |
| `SelectedPageIndex` | `Int32` | `get/set` | No | `` |
| `SupportRename` | `Boolean` | `get/set` | No | `DefaultValue` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `PageItem` | `String caption` | `` |
| `Add` | `Void` | `PageItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `GetButtonIndex` | `Int32` | `Point location` | `` |
| `GetPageIndex` | `Int32` | `Point location` | `` |
| `IndexOf` | `Int32` | `PageItem item` | `` |
| `Remove` | `Void` | `PageItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Rename` | `Void` | `` | `` |

#### Events (5)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterRename` | `EventHandler` | No | `` |
| `BeforeRename` | `CancelEventHandler` | No | `` |
| `CanChangeSelected` | `EventHandler<CanChangeSelectedEventArgs>` | No | `` |
| `HilightedPageChanged` | `EventHandler` | No | `` |
| `SelectedPageChange` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PageScroll` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.PageScroll` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.PageScroll`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Pages` | `Pages` | `get` | No | `` |
| `RightOffset` | `Int32` | `get/set` | No | `` |
| `ScrollBar` | `ScrollBar` | `get` | No | `` |
| `Separator` | `Single` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlaceHolderTextBox` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.PlaceHolderTextBox` |
| **Base Type** | `System.Windows.Forms.TextBox` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.TextBoxBase`
          - `System.Windows.Forms.TextBox`
            - `Topomatic.Controls.Common.PlaceHolderTextBox`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Placeholder` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ResizeSplitter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ResizeSplitter` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.ResizeSplitter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScrollBar` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ScrollBar` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.ScrollBar`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Dirrection` | `ScrollDirrection` | `get/set` | No | `` |
| `Maximum` | `Int32` | `get/set` | No | `` |
| `ScrollButtonScale` | `Single` | `get/set` | No | `` |
| `SmallStep` | `Int32` | `get/set` | No | `` |
| `Value` | `Int32` | `get/set` | No | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `UserValueChanged` | `EventHandler` | No | `` |
| `ValueChanged` | `EventHandler` | No | `` |

#### Nested Types (1)

- `ScrollDirrection` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScrollDirrection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ScrollBar+ScrollDirrection` |
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
      - `Topomatic.Controls.Common.ScrollBar+ScrollDirrection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Horizontal` | `ScrollDirrection` | Yes | `Horizontal` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Vertical` | `ScrollDirrection` | Yes | `Vertical` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Horizontal` | `0` |
| `Vertical` | `1` |

**Underlying Type**: `System.Int32`

### `SearchTextBox` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.SearchTextBox` |
| **Base Type** | `System.Windows.Forms.TextBox` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.TextBoxBase`
          - `System.Windows.Forms.TextBox`
            - `Topomatic.Controls.Common.SearchTextBox`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `SearchImageMouseClick` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Separator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.Separator` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.Common.Separator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Horizontal` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SolidToolStripRender` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.SolidToolStripRender` |
| **Base Type** | `System.Windows.Forms.ToolStripSystemRenderer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Windows.Forms.ToolStripRenderer`
    - `System.Windows.Forms.ToolStripSystemRenderer`
      - `Topomatic.Controls.Common.SolidToolStripRender`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StatusTreeNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.StatusTreeNode` |
| **Base Type** | `System.Windows.Forms.TreeNode` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.Windows.Forms.TreeNode`
      - `Topomatic.Controls.Common.StatusTreeNode`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String text)`
- `.ctor(String text, StatusTreeNode[] children)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Image` | `Image` | `get/set` | No | `` |
| `Status` | `StatusTreeNodeState` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StatusTreeNodeState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.StatusTreeNodeState` |
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
      - `Topomatic.Controls.Common.StatusTreeNodeState`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ArrowLink` | `StatusTreeNodeState` | Yes | `ArrowLink` | `` |
| `Complete` | `StatusTreeNodeState` | Yes | `Complete` | `` |
| `Error` | `StatusTreeNodeState` | Yes | `Error` | `` |
| `Imposible` | `StatusTreeNodeState` | Yes | `Imposible` | `` |
| `Normal` | `StatusTreeNodeState` | Yes | `Normal` | `` |
| `Stop` | `StatusTreeNodeState` | Yes | `Stop` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Warning` | `StatusTreeNodeState` | Yes | `Warning` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Normal` | `0` |
| `Complete` | `1` |
| `Error` | `2` |
| `Warning` | `3` |
| `Imposible` | `4` |
| `Stop` | `5` |
| `ArrowLink` | `6` |

**Underlying Type**: `System.Int32`

### `ToolStripEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ToolStripEx` |
| **Base Type** | `System.Windows.Forms.ToolStrip` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.ISupportToolStripPanel` |
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
          - `System.Windows.Forms.ToolStrip`
            - `Topomatic.Controls.Common.ToolStripEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanClose` | `Boolean` | `get/set` | No | `DefaultValue` |
| `FloatFormLocation` | `Point` | `get/set` | No | `` |
| `FloatMode` | `ToolStripFloatMode` | `get/set` | No | `` |
| `ItemsSize` | `Size` | `get` | No | `` |
| `Location` | `Point` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DisplayFloatForm` | `Void` | `` | `` |
| `GetPreferredSize` | `Size` | `Size proposedSize` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Close` | `EventHandler` | No | `` |
| `InitializeFloatForm` | `InitializeFloatFormEventHandler` | No | `` |

#### Nested Types (1)

- `ToolStripFloatMode` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IArrangedElement` | `GetPreferredSize` |

### `ToolStripFloatForm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ToolStripFloatForm` |
| **Base Type** | `System.Windows.Forms.Form` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Common.ToolStripFloatForm`

#### Constructors (1)

- `.ctor(ToolStripEx toolStrip)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ReorderClientSize` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ToolStripFloatMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ToolStripEx+ToolStripFloatMode` |
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
      - `Topomatic.Controls.Common.ToolStripEx+ToolStripFloatMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dock` | `ToolStripFloatMode` | Yes | `Dock` | `` |
| `Floating` | `ToolStripFloatMode` | Yes | `Floating` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Dock` | `0` |
| `Floating` | `1` |

**Underlying Type**: `System.Int32`

### `ToolStripMenuRendererEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ToolStripMenuRendererEx` |
| **Base Type** | `System.Windows.Forms.ToolStripSystemRenderer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Windows.Forms.ToolStripRenderer`
    - `System.Windows.Forms.ToolStripSystemRenderer`
      - `Topomatic.Controls.Common.ToolStripMenuRendererEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ToolStripToolRendererEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.ToolStripToolRendererEx` |
| **Base Type** | `System.Windows.Forms.ToolStripSystemRenderer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Windows.Forms.ToolStripRenderer`
    - `System.Windows.Forms.ToolStripSystemRenderer`
      - `Topomatic.Controls.Common.ToolStripToolRendererEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TooltipEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.TooltipEx` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomTitle` | `String` | `get/set` | No | `` |
| `BottomTitleIcon` | `Image` | `get/set` | No | `` |
| `BottomTooltip` | `String` | `get/set` | No | `` |
| `ExtendedIcon` | `Image` | `get/set` | No | `` |
| `ExtendedTooltip` | `String` | `get/set` | No | `` |
| `MaximumWidth` | `Int32` | `get/set` | No | `` |
| `Title` | `String` | `get/set` | No | `` |
| `TitleIcon` | `Image` | `get/set` | No | `` |
| `Tooltip` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Display` | `Void` | `IWin32Window owner` | `` |
| `Display` | `Void` | `Control control, Point location` | `` |
| `Hide` | `Void` | `IWin32Window owner` | `` |
| `Reset` | `Void` | `` | `` |

### `TrackBarTransparent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.TrackBarTransparent` |
| **Base Type** | `System.Windows.Forms.TrackBar` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.ComponentModel.ISupportInitialize` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.TrackBar`
          - `Topomatic.Controls.Common.TrackBarTransparent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackColor` | `Color` | `get/set` | No | `Localizable, Browsable, DesignerSerializationVisibility` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TreeViewEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.TreeViewEx` |
| **Base Type** | `System.Windows.Forms.TreeView` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.TreeView`
          - `Topomatic.Controls.Common.TreeViewEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HotTracking` | `Boolean` | `get/set` | No | `DefaultValue, DesignerSerializationVisibility` |
| `ShowLines` | `Boolean` | `get/set` | No | `DesignerSerializationVisibility, DefaultValue` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ProcessNodes` | `Void` | `Action<TreeNode> action` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SendMessage` | `IntPtr` | `HandleRef hWnd, Int32 msg, Int32 wParam, ref TV_ITEM lParam` | `DllImport, PreserveSig` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TVIF_STATE` | `Int32` | Yes | `8` | `` |
| `TVIS_STATEIMAGEMASK` | `Int32` | Yes | `61440` | `` |
| `TVM_GETITEM` | `Int32` | Yes | `4364` | `` |
| `TVM_SETITEM` | `Int32` | Yes | `4365` | `` |
| `TVM_SETITEMA` | `Int32` | Yes | `4365` | `` |
| `TVM_SETITEMW` | `Int32` | Yes | `4415` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `DefaultAction` | `HandledEventHandler` | No | `` |

#### Nested Types (2)

- `HiddenCheckBoxNode` (class)
- `TV_ITEM` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TreeViewIndex`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.TreeViewIndex`1` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (2)

- `.ctor(TreeView treeView, Action<TreeNode T Boolean> prepare)`
- `.ctor(TreeView treeView, Action<TreeNode T Boolean> prepare, Predicate<T> hide)`

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `IAppend<T>` | `TreeNode node` | `` |
| `Append` | `IAppend<T>` | `String caption, T value` | `` |
| `AppendPath` | `Void` | `String path, T value` | `` |
| `Clear` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `Expand` | `TreeNode` | `Predicate<KeyValuePair<String T>> match, Boolean isFolder` | `` |
| `Expand` | `Void` | `TreeNode node` | `` |
| `Init` | `Void` | `` | `` |
| `Refill` | `IAppend<T>` | `TreeNode node` | `` |
| `Remove` | `Void` | `TreeNode node` | `` |
| `Rename` | `Void` | `TreeNode node` | `` |

#### Nested Types (1)

- `IAppend` (interface)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `TV_ITEM` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.TreeViewEx+TV_ITEM` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.Common.TreeViewEx+TV_ITEM`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Children` | `Int32` | No | `` | `` |
| `Image` | `Int32` | No | `` | `` |
| `ItemHandle` | `IntPtr` | No | `` | `` |
| `LParam` | `IntPtr` | No | `` | `` |
| `Mask` | `Int32` | No | `` | `` |
| `SelectedImage` | `Int32` | No | `` | `` |
| `State` | `Int32` | No | `` | `` |
| `StateMask` | `Int32` | No | `` | `` |
| `TextMax` | `Int32` | No | `` | `` |
| `TextPtr` | `IntPtr` | No | `` | `` |

### `UseAntiAlias` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.UseAntiAlias` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Graphics g)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `UseClearTypeGridFit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.UseClearTypeGridFit` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Graphics g)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `UseClipping` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Common.UseClipping` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Graphics g, Region region)`
- `.ctor(Graphics g, GraphicsPath path)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.Controls.Core`

### `ModelsView` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Core.ModelsView` |
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
              - `Topomatic.Controls.Core.ModelsView`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Items` | `IEnumerable<ModelsViewItem>` | `get` | No | `` |
| `MultiSelect` | `Boolean` | `get/set` | No | `` |
| `SelectedItems` | `IEnumerable<ModelsViewItem>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddItem` | `Void` | `ModelsViewItem item, Boolean expand` | `` |
| `Initalize` | `Void` | `ModelsViewItem[] items, Image[] images, Int32 selectedIndex` | `` |
| `Initalize` | `Void` | `ModelsViewItem[] items, Image[] images, Predicate<ModelsViewItem> select` | `` |
| `RemoveItem` | `Boolean` | `ModelsViewItem item` | `` |
| `SelectItems` | `Void` | `Predicate<ModelsViewItem> match` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `ItemBeforeChange` | `EventHandler<ModelsViewItemChangedCancelEventArgs>` | No | `` |
| `ItemChanged` | `EventHandler<ModelsViewItemChangedEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModelsViewItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Core.ModelsViewItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.Core.ModelsViewItem`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ImageIndex` | `Int32` | No | `` | `` |
| `ModelIndex` | `Int32` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Path` | `String` | No | `` | `` |

### `ModelsViewItemChangedCancelEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Core.ModelsViewItemChangedCancelEventArgs` |
| **Base Type** | `System.ComponentModel.CancelEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `System.ComponentModel.CancelEventArgs`
      - `Topomatic.Controls.Core.ModelsViewItemChangedCancelEventArgs`

#### Constructors (1)

- `.ctor(Nullable<ModelsViewItem> oldValue, Nullable<ModelsViewItem> newValue)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `NewValue` | `Nullable<ModelsViewItem>` | `get` | No | `` |
| `OldValue` | `Nullable<ModelsViewItem>` | `get` | No | `` |

### `ModelsViewItemChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Core.ModelsViewItemChangedEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.Core.ModelsViewItemChangedEventArgs`

#### Constructors (1)

- `.ctor(Nullable<ModelsViewItem> item)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Nullable<ModelsViewItem>` | `get` | No | `` |

---
## Namespace: `Topomatic.Controls.Dialogs`

### `ColumnValue` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.CsvImportDlg+ColumnValue` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.Dialogs.CsvImportDlg+ColumnValue`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Caption` | `String` | No | `` | `` |
| `Group` | `String` | No | `` | `` |

### `CsvImportDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.CsvImportDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.CsvImportDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Nullable<SchemaPattern>` | `String caption, String fileName, Encoding encoding, ColumnValue[] columns, String schemaPrefix` | `` |
| `Execute` | `Nullable<SchemaPattern>` | `String caption, String fileName, ColumnValue[] columns, SchemaCollection schemaCollection, SchemaPattern pattern` | `` |
| `Execute` | `Nullable<SchemaPattern>` | `String caption, String fileName, Encoding encoding, ColumnValue[] columns, SchemaCollection schemaCollection, SchemaPattern pattern` | `` |
| `Execute` | `Nullable<SchemaPattern>` | `String caption, String fileName, ColumnValue[] columns, SchemaPattern pattern` | `` |
| `Execute` | `Nullable<SchemaPattern>` | `String caption, String fileName, Encoding encoding, ColumnValue[] columns, SchemaPattern pattern` | `` |
| `Execute` | `Nullable<SchemaPattern>` | `String caption, String fileName, ColumnValue[] columns, String schemaPrefix` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MISSED_INDEX` | `Int32` | Yes | `-1` | `` |

#### Nested Types (3)

- `ColumnValue` (struct)
- `SchemaCollection` (class)
- `SchemaPattern` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EditTableDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.EditTableDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Controls.Dialogs.EditTableDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `String caption, IEnumerable wrapper, Boolean readOnly, Boolean maximized, Int32 selected, Int32 count` | `` |
| `Execute` | `Boolean` | `String caption, IEnumerable wrapper, Boolean readOnly, Boolean maximized, Boolean allowMoveRows, Int32 selected, Int32 count` | `` |
| `Execute` | `Boolean` | `String caption, IEnumerable wrapper, Boolean readOnly, Boolean maximized` | `` |
| `Execute` | `Boolean` | `String caption, IEnumerable wrapper, Boolean readOnly, Boolean maximized, Int32 selected` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EditTableFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.EditTableFrame` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleFrame` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.Controls.Dialogs.IManagedControl` |
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
              - `Topomatic.Controls.Dialogs.SimpleFrame`
                - `Topomatic.Controls.Dialogs.EditTableFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowMoveLines` | `Boolean` | `get/set` | No | `` |
| `Modified` | `Boolean` | `get` | No | `` |
| `ReadOnlyMode` | `Boolean` | `get/set` | No | `` |
| `Selected` | `Int32` | `get/set` | No | `` |
| `SelectedCount` | `Int32` | `get/set` | No | `` |
| `Wrapper` | `IEnumerable` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RefreshButtons` | `Void` | `` | `` |
| `RefreshData` | `Void` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `roburPropertyGrid` | `PropertyGrid` | No | `` | `` |
| `toolStrip` | `ToolStrip` | No | `` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `OnRefreshButtons` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EditTableFrameRefreshEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.EditTableFrameRefreshEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.Dialogs.EditTableFrameRefreshEventArgs`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SelectedIndicies` | `List<Int32>` | No | `` | `` |

### `IManagedControl` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.IManagedControl` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `Boolean` | `` | `` |
| `GetModifiedWarning` | `Boolean` | `` | `` |
| `Init` | `Void` | `` | `` |
| `Rollback` | `Void` | `` | `` |

### `InputBoxDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.InputBoxDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.InputBoxDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `String caption, ref String input` | `` |
| `Execute` | `Boolean` | `String caption, Predicate<String> match, ref String input` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IWizardController` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Active` | `WizardFrame` | `get` | No | `` |
| `State` | `WizardState` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GoFinish` | `Void` | `` | `` |
| `GoNext` | `Void` | `` | `` |
| `GoPrevious` | `Void` | `` | `` |
| `Initialize` | `Void` | `Wizard wizard` | `` |
| `Validate` | `Boolean` | `Object arg` | `` |

### `MessageDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.MessageDlg` |
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
| `Show` | `DialogResult` | `String text, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton` | `` |
| `Show` | `DialogResult` | `String text, MessageBoxButtons buttons, MessageBoxIcon icon` | `` |
| `Show` | `DialogResult` | `String text` | `` |

### `Mode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.UpdateDwlDlg+Mode` |
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
      - `Topomatic.Controls.Dialogs.UpdateDwlDlg+Mode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Regen` | `Mode` | Yes | `Regen` | `` |
| `Update` | `Mode` | Yes | `Update` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Regen` | `1` |
| `Update` | `2` |

**Underlying Type**: `System.Int32`

### `SaveWriteProtectedFileDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.SaveWriteProtectedFileDlg` |
| **Base Type** | `System.Windows.Forms.Form` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SaveWriteProtectedFileDlg`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Show` | `SaveWriteProtectedResult` | `String filename` | `` |

#### Nested Types (1)

- `SaveWriteProtectedResult` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SaveWriteProtectedResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.SaveWriteProtectedFileDlg+SaveWriteProtectedResult` |
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
      - `Topomatic.Controls.Dialogs.SaveWriteProtectedFileDlg+SaveWriteProtectedResult`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cancel` | `SaveWriteProtectedResult` | Yes | `Cancel` | `` |
| `No` | `SaveWriteProtectedResult` | Yes | `No` | `` |
| `Overwrite` | `SaveWriteProtectedResult` | Yes | `Overwrite` | `` |
| `SaveAs` | `SaveWriteProtectedResult` | Yes | `SaveAs` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SaveAs` | `0` |
| `Overwrite` | `1` |
| `No` | `2` |
| `Cancel` | `3` |

**Underlying Type**: `System.Int32`

### `SchemaCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.CsvImportDlg+SchemaCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `SchemaPattern` | `get` | No | `` |
| `SystemCount` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Append` | `Void` | `SchemaPattern pattern` | `` |
| `Dispose` | `Void` | `` | `` |
| `Flush` | `Void` | `` | `` |
| `RemoveAt` | `Boolean` | `Int32 index` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSchema` | `SchemaCollection` | `String schemaPrefix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `SchemaPattern` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.CsvImportDlg+SchemaPattern` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.Dialogs.CsvImportDlg+SchemaPattern`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Name` | `String` | No | `` | `` |
| `Pattern` | `Int32[]` | No | `` | `` |
| `SkeepEmpty` | `Boolean` | No | `` | `` |
| `StartsWith` | `Int32` | No | `` | `` |

### `SimpleDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Base Type** | `System.Windows.Forms.Form` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicationSmallIcon` | `Icon` | `get` | Yes | `` |
| `Font` | `Font` | `get/set` | No | `DesignerSerializationVisibility, Localizable` |
| `Icon` | `Icon` | `get/set` | No | `Localizable, DesignerSerializationVisibility, Browsable` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `btnCancel` | `Button` | No | `` | `` |
| `btnOk` | `Button` | No | `` | `` |
| `dividerLine` | `DividerLine` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SimpleFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.SimpleFrame` |
| **Base Type** | `System.Windows.Forms.UserControl` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.Controls.Dialogs.IManagedControl` |
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
              - `Topomatic.Controls.Dialogs.SimpleFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `Boolean` | `` | `` |
| `GetModifiedWarning` | `Boolean` | `` | `` |
| `Init` | `Void` | `` | `` |
| `Rollback` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IManagedControl` | `Init` |
| `IManagedControl` | `Commit` |
| `IManagedControl` | `Rollback` |
| `IManagedControl` | `GetModifiedWarning` |

### `SimpleWizardController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.SimpleWizardController` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(WizardFrame[] frames)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Active` | `WizardFrame` | `get` | No | `` |
| `State` | `WizardState` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GoFinish` | `Void` | `` | `` |
| `GoNext` | `Void` | `` | `` |
| `GoPrevious` | `Void` | `` | `` |
| `Initialize` | `Void` | `Wizard wizard` | `` |
| `Validate` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWizardController` | `get_Active` |
| `IWizardController` | `get_State` |
| `IWizardController` | `Initialize` |
| `IWizardController` | `Validate` |
| `IWizardController` | `GoNext` |
| `IWizardController` | `GoPrevious` |
| `IWizardController` | `GoFinish` |

### `StoredDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UpdateDwlDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.UpdateDwlDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Controls.Dialogs.UpdateDwlDlg`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `ref Mode mode` | `` |

#### Nested Types (1)

- `Mode` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Wizard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.Wizard` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.Wizard`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GoNext` | `Void` | `` | `` |
| `GoPrevious` | `Void` | `` | `` |
| `UpdateState` | `Void` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `String text, IWizardController controller, Object arg` | `` |
| `Execute` | `Boolean` | `IWizardController controller, Object arg` | `` |
| `PostExecute` | `Boolean` | `String caption, IWizardController controller, Object arg` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `caption` | `Label` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WizardDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.WizardDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.WizardDlg`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurrentPage` | `WizardPage` | `get` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExecuteWizard` | `DialogResult` | `WizardPage startPage, String captionText, IWin32Window owner` | `` |
| `ExecuteWizard` | `DialogResult` | `WizardPage startPage, String captionText` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `btnNext` | `Button` | No | `` | `` |
| `btnPrevious` | `Button` | No | `` | `` |
| `wizardPageContainer` | `Panel` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.WizardFrame` |
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
              - `Topomatic.Controls.Dialogs.WizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Object arg, Boolean committing` | `` |
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WizardPage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.WizardPage` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleFrame` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.Controls.Dialogs.IManagedControl` |
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
              - `Topomatic.Controls.Dialogs.SimpleFrame`
                - `Topomatic.Controls.Dialogs.WizardPage`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PageState` | `WizardPageState` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WizardPageEx` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.WizardPageEx` |
| **Base Type** | `Topomatic.Controls.Dialogs.WizardPage` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.Controls.Dialogs.IManagedControl` |
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
              - `Topomatic.Controls.Dialogs.SimpleFrame`
                - `Topomatic.Controls.Dialogs.WizardPage`
                  - `Topomatic.Controls.Dialogs.WizardPageEx`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HeaderTitle` | `String` | `get/set` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ShowWizard` | `Boolean` | `IWin32Window hwndParent, String caption, WizardPageEx[] pages` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WizardPageState` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.WizardPageState` |
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
      - `Topomatic.Controls.Dialogs.WizardPageState`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `WizardPageState` | Yes | `All` | `` |
| `CanCommitWizard` | `WizardPageState` | Yes | `CanCommitWizard` | `` |
| `CanMoveToNextPage` | `WizardPageState` | Yes | `CanMoveToNextPage` | `` |
| `CanMoveToPreviousPage` | `WizardPageState` | Yes | `CanMoveToPreviousPage` | `` |
| `Default` | `WizardPageState` | Yes | `Default` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CanMoveToPreviousPage` | `1` |
| `CanMoveToNextPage` | `2` |
| `Default` | `3` |
| `CanCommitWizard` | `4` |
| `All` | `7` |

**Underlying Type**: `System.Int32`

### `WizardState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Dialogs.WizardState` |
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
      - `Topomatic.Controls.Dialogs.WizardState`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cGoFinish` | `WizardState` | Yes | `cGoFinish` | `` |
| `cGoNext` | `WizardState` | Yes | `cGoNext` | `` |
| `cGoPrevious` | `WizardState` | Yes | `cGoPrevious` | `` |
| `cNone` | `WizardState` | Yes | `cNone` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `cNone` | `0` |
| `cGoNext` | `1` |
| `cGoPrevious` | `2` |
| `cGoFinish` | `4` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Controls.ObjectInspection`

### `BeginUpdateEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.BeginUpdateEventHandler` |
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
      - `Topomatic.Controls.ObjectInspection.BeginUpdateEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, UpdateEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `ITransactionManager` | `IAsyncResult result` | `` |
| `Invoke` | `ITransactionManager` | `Object sender, UpdateEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EndUpdateEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.EndUpdateEventHandler` |
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
      - `Topomatic.Controls.ObjectInspection.EndUpdateEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, UpdateEventArgs e, ITransactionManager manager, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, UpdateEventArgs e, ITransactionManager manager` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PropertyGridUpdateEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGridUpdateEventArgs` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PropertyGridUpdateReason reason, Object[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ObjectParams` | `Object[]` | `get` | No | `` |
| `UpdateReason` | `PropertyGridUpdateReason` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetInsertOrDeleteCount` | `Boolean` | `ref Int32 count` | `` |
| `TryGetPropertyDisplayName` | `Boolean` | `ref String displayName` | `` |

### `PropertyGridUpdateEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGridUpdateEventHandler` |
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
      - `Topomatic.Controls.ObjectInspection.PropertyGridUpdateEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, PropertyGridUpdateEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, PropertyGridUpdateEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ReadOnlyIndexesEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.ReadOnlyIndexesEventHandler` |
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
      - `Topomatic.Controls.ObjectInspection.ReadOnlyIndexesEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, UpdateEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `IEnumerable<Int32>` | `IAsyncResult result` | `` |
| `Invoke` | `IEnumerable<Int32>` | `Object sender, UpdateEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UpdateEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.UpdateEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.ObjectInspection.UpdateEventArgs`

#### Constructors (1)

- `.ctor(IPropertyTypeDescriptorContext context)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Context` | `IPropertyTypeDescriptorContext` | `get` | No | `` |

---
## Namespace: `Topomatic.Controls.ObjectInspection.PropertyGrid`

### `AfterPropertyUpdateEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.AfterPropertyUpdateEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Controls.ObjectInspection.PropertyGrid.AfterPropertyUpdateEventArgs`

#### Constructors (1)

- `.ctor(MultiProperty property)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Property` | `MultiProperty` | `get` | No | `` |

### `PermittedHotKeys` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGrid+PermittedHotKeys` |
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
      - `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGrid+PermittedHotKeys`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ALL` | `PermittedHotKeys` | Yes | `ALL` | `` |
| `CopyPasteCellValue` | `PermittedHotKeys` | Yes | `CopyPasteCellValue` | `` |
| `Delete` | `PermittedHotKeys` | Yes | `Delete` | `` |
| `Insert` | `PermittedHotKeys` | Yes | `Insert` | `` |
| `InsertInterpolate` | `PermittedHotKeys` | Yes | `InsertInterpolate` | `` |
| `None` | `PermittedHotKeys` | Yes | `None` | `` |
| `UndoRedo` | `PermittedHotKeys` | Yes | `UndoRedo` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `UndoRedo` | `1` |
| `Insert` | `2` |
| `Delete` | `4` |
| `InsertInterpolate` | `8` |
| `CopyPasteCellValue` | `16` |
| `ALL` | `31` |

**Underlying Type**: `System.Int32`

### `PropertyGrid` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGrid` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, Topomatic.ComponentModel.IPropertyWindowsFormsEditorService` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGrid`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (27)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanAppendItem` | `Boolean` | `get` | No | `` |
| `CanCopyRows` | `Boolean` | `get` | No | `` |
| `CanInsertInterpolate` | `Boolean` | `get` | No | `` |
| `CanMoveDown` | `Boolean` | `get` | No | `` |
| `CanMoveUp` | `Boolean` | `get` | No | `` |
| `CanPasteRows` | `Boolean` | `get` | No | `` |
| `CanRedo` | `Boolean` | `get` | No | `` |
| `CanUndo` | `Boolean` | `get` | No | `` |
| `DisplayNumerator` | `Boolean` | `get/set` | No | `DefaultValue` |
| `DisplaySequenceNumber` | `Boolean` | `get/set` | No | `DefaultValue` |
| `FixedSizeMode` | `Boolean` | `get/set` | No | `DefaultValue` |
| `Font` | `Font` | `get/set` | No | `Browsable, DesignerSerializationVisibility, Localizable` |
| `Header` | `PropertyGridHeader` | `get` | No | `` |
| `HorizontalScrollBarVisible` | `Boolean` | `get/set` | No | `` |
| `HScrollBar` | `HScrollBar` | `get` | No | `` |
| `LeftOffset` | `Int32` | `get/set` | No | `` |
| `Modified` | `Boolean` | `get` | No | `` |
| `Permitted_HotKeys` | `PermittedHotKeys` | `get/set` | No | `DefaultValue, Description, Editor` |
| `PermitUndoEditValue` | `Boolean` | `get/set` | No | `DefaultValue` |
| `ReadOnlyMode` | `Boolean` | `get/set` | No | `DefaultValue` |
| `SelectedColumn` | `PropertyGridColumn` | `get/set` | No | `` |
| `SelectedRow` | `Int32` | `get/set` | No | `` |
| `SelectionCount` | `Int32` | `get` | No | `` |
| `Sortable` | `Boolean` | `get/set` | No | `DefaultValue` |
| `StartRow` | `Int32` | `get/set` | No | `` |
| `VerticalScrollBarVisible` | `Boolean` | `get/set` | No | `` |
| `VScrollBar` | `VScrollBar` | `get` | No | `` |

#### Instance Methods (30)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AppendInstance` | `Void` | `Object obj` | `` |
| `BeginChange` | `Void` | `` | `` |
| `ClearUndo` | `Void` | `` | `` |
| `CloseDropDownControl` | `Void` | `DialogResult result` | `` |
| `CommitEdit` | `Boolean` | `` | `` |
| `CopyRows` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `DeleteSelected` | `Void` | `` | `` |
| `DropDownControl` | `DialogResult` | `Control control` | `` |
| `EditValue` | `Void` | `Int32 button` | `` |
| `EndChange` | `Void` | `` | `` |
| `Initialize` | `Void` | `` | `` |
| `InsertInterpolateItem` | `Boolean` | `Int32 index, Object obj` | `` |
| `InsertInterpolateItem` | `Void` | `` | `` |
| `InsertItem` | `Boolean` | `` | `` |
| `InsertItem` | `Void` | `Int32 index, Object obj` | `` |
| `MoveDown` | `Void` | `` | `` |
| `MoveUp` | `Void` | `` | `` |
| `PasteRows` | `Void` | `` | `` |
| `Redo` | `Void` | `` | `` |
| `ReplaceRows` | `Void` | `` | `` |
| `ResetColumns` | `Void` | `` | `` |
| `ScrollToRow` | `Void` | `Int32 index` | `` |
| `SelectAll` | `Void` | `Boolean value` | `` |
| `SelectAll` | `Void` | `` | `` |
| `SelectObjects` | `Void` | `IEnumerable items` | `` |
| `SetStringValue` | `Void` | `PropertyGridColumn c, String str` | `` |
| `SetupColumns` | `Void` | `` | `` |
| `ShowDialog` | `DialogResult` | `Form dialog` | `` |
| `Undo` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `HeaderDataSize` | `SizeF` | `String text` | `` |
| `RowDataSize` | `SizeF` | `String text` | `` |

#### Events (8)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterPropertyUpdate` | `EventHandler<AfterPropertyUpdateEventArgs>` | No | `` |
| `BeginUpdate` | `PropertyGridUpdateEventHandler` | No | `` |
| `CreateMenu` | `EventHandler<CreateMenuEventArgs>` | No | `` |
| `EndUpdate` | `PropertyGridUpdateEventHandler` | No | `` |
| `SelectedColumnChanged` | `EventHandler` | No | `` |
| `SelectedRowChanged` | `EventHandler` | No | `` |
| `SelectedRowsChanged` | `EventHandler` | No | `` |
| `UpdateScrolls` | `EventHandler` | No | `` |

#### Nested Types (1)

- `PermittedHotKeys` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPropertyWindowsFormsEditorService` | `DropDownControl` |
| `IPropertyWindowsFormsEditorService` | `CloseDropDownControl` |
| `IPropertyWindowsFormsEditorService` | `ShowDialog` |

### `PropertyGridColumn` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridColumn` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ChildCount` | `Int32` | `get` | No | `` |
| `ClientRect` | `RectangleF` | `get` | No | `` |
| `FullHeight` | `Single` | `get/set` | No | `` |
| `FullText` | `String` | `get` | No | `` |
| `Height` | `Single` | `get/set` | No | `` |
| `Item` | `PropertyGridColumn` | `get` | No | `` |
| `Location` | `PointF` | `get/set` | No | `` |
| `Parent` | `PropertyGridColumn` | `get` | No | `` |
| `Property` | `MultiProperty` | `get/set` | No | `` |
| `RowsCount` | `Int32` | `get` | No | `` |
| `Selected` | `Boolean` | `get/set` | No | `` |
| `SharedProperty` | `Boolean` | `get` | No | `` |
| `Text` | `String` | `get/set` | No | `` |
| `Width` | `Single` | `get/set` | No | `` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearCache` | `Void` | `` | `` |
| `ClickEdit` | `Object` | `IPropertyWindowsFormsEditorService editorService, Int32 index` | `` |
| `DoubleClickEdit` | `Object` | `IPropertyWindowsFormsEditorService editorService, Int32 index` | `` |
| `EditValue` | `Object` | `IPropertyWindowsFormsEditorService editorService, Int32 button, Int32 index` | `` |
| `GetBackGroundColor` | `Color` | `Int32 index, Color defaultValue, Boolean selected` | `` |
| `GetCustomButtons` | `Image[]` | `Int32 index, Int32 size` | `` |
| `GetEditor` | `PropertyEditor` | `Int32 index` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `Int32 index` | `` |
| `GetStringValue` | `String` | `Int32 index` | `` |
| `GetTextAlign` | `VisualStyleAlign` | `Int32 index, VisualStyleAlign defaultValue, Boolean selected` | `` |
| `GetTextColor` | `Color` | `Int32 index, Color defaultValue, Boolean selected` | `` |
| `GetValue` | `Object` | `Int32 index` | `` |
| `IsReadOnly` | `Boolean` | `Int32 index` | `` |
| `PaintSupport` | `Boolean` | `Int32 index` | `` |
| `PaintValue` | `Void` | `Rectangle bounds, Graphics g, Int32 index` | `` |
| `PrefferedPaintWidth` | `Single` | `Int32 height, Int32 index` | `` |
| `RefreshCache` | `Void` | `Int32 index` | `` |
| `SetStringValue` | `Void` | `Int32 index, String value` | `` |
| `SetValue` | `Void` | `Object value, Int32 index` | `` |

### `PropertyGridColumnsSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridColumnsSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `PropertyGridColumnsSettings` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `SettingValues` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PropertyGridExportFrameFileName` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridExportFrameFileName` |
| **Base Type** | `Topomatic.Controls.Dialogs.WizardPageEx` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.Controls.Dialogs.IManagedControl` |
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
              - `Topomatic.Controls.Dialogs.SimpleFrame`
                - `Topomatic.Controls.Dialogs.WizardPage`
                  - `Topomatic.Controls.Dialogs.WizardPageEx`
                    - `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridExportFrameFileName`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Service` | `PropertyGridExportService` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PropertyGridExportService` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridExportService` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |
| `Enable` | `Boolean` | `get` | No | `` |
| `FileName` | `String` | `get/set` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `IsExportToFile` | `Boolean` | `get` | No | `` |
| `LoadedServices` | `IEnumerable<PropertyGridExportService>` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Export` | `Void` | `PropertyGridHeader header, Boolean showDialog` | `` |

### `PropertyGridHeader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridHeader` |
| **Base Type** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridColumn` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridColumn`
    - `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridHeader`

#### Constructors (1)

- `.ctor(IEnumerable instance)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Rows` | `RecordsCollection` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ArrangeSize` | `Void` | `TextSizeDelegate headerSize, TextSizeDelegate rowsSize, Int32 maxRowCount, Int32 startRow, Boolean textOnly, Single imagePadding` | `` |
| `Clone` | `Object` | `` | `` |
| `GetColumns` | `IEnumerable<PropertyGridColumn>` | `` | `` |
| `GetDataColumns` | `IEnumerable<PropertyGridColumn>` | `` | `` |

#### Nested Types (1)

- `RecordsCollection` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `Clone` |

### `PropertyGridRow` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridRow` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get/set` | No | `` |
| `Selected` | `Boolean` | `get/set` | No | `` |

### `PropertyGridUpdateReason` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridUpdateReason` |
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
      - `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridUpdateReason`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DeleteRows` | `PropertyGridUpdateReason` | Yes | `DeleteRows` | `` |
| `ImportRows` | `PropertyGridUpdateReason` | Yes | `ImportRows` | `` |
| `InsertRows` | `PropertyGridUpdateReason` | Yes | `InsertRows` | `` |
| `PasteRows` | `PropertyGridUpdateReason` | Yes | `PasteRows` | `` |
| `Redo` | `PropertyGridUpdateReason` | Yes | `Redo` | `` |
| `ReplaceMultiply` | `PropertyGridUpdateReason` | Yes | `ReplaceMultiply` | `` |
| `SetCellValue` | `PropertyGridUpdateReason` | Yes | `SetCellValue` | `` |
| `Undo` | `PropertyGridUpdateReason` | Yes | `Undo` | `` |
| `UserChange` | `PropertyGridUpdateReason` | Yes | `UserChange` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SetCellValue` | `0` |
| `Undo` | `1` |
| `Redo` | `2` |
| `InsertRows` | `3` |
| `DeleteRows` | `4` |
| `PasteRows` | `5` |
| `ReplaceMultiply` | `6` |
| `ImportRows` | `7` |
| `UserChange` | `-1` |

**Underlying Type**: `System.Int32`

### `RecordsCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridHeader+RecordsCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridRow, Topomatic.Controls, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridRow, Topomatic.Controls, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridRow, Topomatic.Controls, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Collection` | `List<PropertyGridRow>` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `PropertyGridRow` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `PropertyGridRow item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `PropertyGridRow item` | `` |
| `CopyTo` | `Void` | `PropertyGridRow[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<PropertyGridRow>` | `` | `` |
| `IndexOf` | `Int32` | `PropertyGridRow item` | `` |
| `Insert` | `Void` | `Int32 index, PropertyGridRow item` | `` |
| `Remove` | `Boolean` | `PropertyGridRow item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SetReadOnly` | `Void` | `Boolean value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |

### `SettingValues` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridColumnsSettings+SettingValues` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Controls.ObjectInspection.PropertyGrid.PropertyGridColumnsSettings+SettingValues`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Visible` | `Nullable<Boolean>` | No | `` | `` |
| `Width` | `Nullable<Single>` | No | `` | `` |

### `TextSizeDelegate` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.TextSizeDelegate` |
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
      - `Topomatic.Controls.ObjectInspection.PropertyGrid.TextSizeDelegate`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `String text, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `SizeF` | `IAsyncResult result` | `` |
| `Invoke` | `SizeF` | `String text` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Controls.ObjectInspection.PropertyGrid.FlagEnumEditor`

### `FlagCheckedListBox` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.FlagEnumEditor.FlagCheckedListBox` |
| **Base Type** | `System.Windows.Forms.CheckedListBox` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ListControl`
          - `System.Windows.Forms.ListBox`
            - `System.Windows.Forms.CheckedListBox`
              - `Topomatic.Controls.ObjectInspection.PropertyGrid.FlagEnumEditor.FlagCheckedListBox`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EnumValue` | `Enum` | `get/set` | No | `DesignerSerializationVisibility` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `FlagCheckedListBoxItem` | `FlagCheckedListBoxItem item` | `` |
| `Add` | `FlagCheckedListBoxItem` | `Int32 v, String c` | `` |
| `GetCurrentValue` | `Int32` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FlagCheckedListBoxItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.FlagEnumEditor.FlagCheckedListBoxItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Int32 v, String c)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsFlag` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsMemberFlag` | `Boolean` | `FlagCheckedListBoxItem composite` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `caption` | `String` | No | `` | `` |
| `value` | `Int32` | No | `` | `` |

### `FlagEnumUIEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyGrid.FlagEnumEditor.FlagEnumUIEditor` |
| **Base Type** | `System.Drawing.Design.UITypeEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Drawing.Design.UITypeEditor`
    - `Topomatic.Controls.ObjectInspection.PropertyGrid.FlagEnumEditor.FlagEnumUIEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `ITypeDescriptorContext context, IServiceProvider provider, Object value` | `` |
| `GetEditStyle` | `UITypeEditorEditStyle` | `ITypeDescriptorContext context` | `` |

---
## Namespace: `Topomatic.Controls.ObjectInspection.PropertyInspector`

### `PropertyInspector` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyInspector.PropertyInspector` |
| **Base Type** | `System.Windows.Forms.UserControl` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.ComponentModel.ILongSetterAsyncWorker` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
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
              - `Topomatic.Controls.ObjectInspection.PropertyInspector.PropertyInspector`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DescriptionVisible` | `Boolean` | `get/set` | No | `DefaultValue` |
| `Font` | `Font` | `get/set` | No | `Localizable, DesignerSerializationVisibility` |
| `GridItemSize` | `Int32` | `get` | No | `` |
| `PropertyCount` | `Int32` | `get` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `DefaultValue` |
| `SelectedIndex` | `Int32` | `get/set` | No | `` |
| `SelectedObjects` | `IEnumerable` | `get/set` | No | `DefaultValue, Browsable` |
| `SelectedProperty` | `MultiProperty` | `get` | No | `` |
| `SelectMode` | `SelectMode` | `get/set` | No | `` |
| `SpliterPosition` | `Int32` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearCache` | `Void` | `` | `` |
| `CollapseGroup` | `Void` | `Int32 index, Boolean collapse` | `` |
| `CommitEdit` | `Void` | `` | `` |
| `Initialize` | `Void` | `` | `` |
| `ProcessTab` | `Void` | `Boolean forward` | `` |
| `Redraw` | `Void` | `` | `` |

#### Events (3)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `BeginUpdate` | `BeginUpdateEventHandler` | No | `` |
| `EndUpdate` | `EndUpdateEventHandler` | No | `` |
| `ReadOnlyIndexes` | `ReadOnlyIndexesEventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILongSetterAsyncWorker` | `Topomatic.ComponentModel.ILongSetterAsyncWorker.BeginProgress` |
| `ILongSetterAsyncWorker` | `Topomatic.ComponentModel.ILongSetterAsyncWorker.ProgressChange` |
| `ILongSetterAsyncWorker` | `Topomatic.ComponentModel.ILongSetterAsyncWorker.get_CancellationPending` |

### `SelectMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertyInspector.SelectMode` |
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
      - `Topomatic.Controls.ObjectInspection.PropertyInspector.SelectMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Consistently` | `SelectMode` | Yes | `Consistently` | `` |
| `Parallel` | `SelectMode` | Yes | `Parallel` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Parallel` | `0` |
| `Consistently` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Controls.ObjectInspection.PropertySelector`

### `Selector` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertySelector.Selector` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Select` | `List<SelectorModel>` | `String sql, IEnumerable<SelectorModel> selectable, IEnumerable<SelectorModel> selected` | `` |

### `SelectorDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.ObjectInspection.PropertySelector.SelectorDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Controls.ObjectInspection.PropertySelector.SelectorDlg`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `String` | `IEnumerable<SelectorModel> selectable, IEnumerable<SelectorModel> selected` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Controls.Rtf`

### `RtfAlignedNode` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfAlignedNode` |
| **Base Type** | `Topomatic.Controls.Rtf.RtfDocumentNode` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Rtf.RtfDocumentNode`
    - `Topomatic.Controls.Rtf.RtfAlignedNode`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `RtfTextAlignment` | `get/set` | No | `` |

### `RtfCellBorders` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfCellBorders` |
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
      - `Topomatic.Controls.Rtf.RtfCellBorders`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `RtfCellBorders` | Yes | `All` | `` |
| `Bottom` | `RtfCellBorders` | Yes | `Bottom` | `` |
| `Left` | `RtfCellBorders` | Yes | `Left` | `` |
| `None` | `RtfCellBorders` | Yes | `None` | `` |
| `Right` | `RtfCellBorders` | Yes | `Right` | `` |
| `Top` | `RtfCellBorders` | Yes | `Top` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Left` | `1` |
| `Right` | `2` |
| `Top` | `4` |
| `Bottom` | `8` |
| `All` | `15` |

**Underlying Type**: `System.Byte`

### `RtfCellNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfCellNode` |
| **Base Type** | `Topomatic.Controls.Rtf.RtfAlignedNode` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Rtf.RtfDocumentNode`
    - `Topomatic.Controls.Rtf.RtfAlignedNode`
      - `Topomatic.Controls.Rtf.RtfCellNode`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bold` | `Boolean` | `get/set` | No | `` |
| `Borders` | `RtfCellBorders` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `` |
| `Column` | `Int32` | `get` | No | `` |
| `Columns` | `Int32` | `get` | No | `` |
| `Row` | `Int32` | `get` | No | `` |
| `Rows` | `Int32` | `get` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

### `RtfDocument` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfDocument` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Nodes` | `IEnumerable<RtfDocumentNode>` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddLine` | `RtfTextNode` | `String text, RtfTextAlignment alignemnt, Boolean bold` | `` |
| `AddLine` | `RtfTextNode` | `String text, RtfTextAlignment alignment, Color color, Boolean bold` | `` |
| `AddLine` | `RtfTextNode` | `String text` | `` |
| `AddLine` | `RtfTextNode` | `String text, RtfTextAlignment alignemnt` | `` |
| `AddTable` | `RtfTableNode` | `Color color` | `` |
| `AddTable` | `RtfTableNode` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `RtfDocumentNode` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfDocumentNode` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `NodeType` | `RtfDocumentNodeType` | `get` | No | `` |

### `RtfDocumentNodeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfDocumentNodeType` |
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
      - `Topomatic.Controls.Rtf.RtfDocumentNodeType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cell` | `RtfDocumentNodeType` | Yes | `Cell` | `` |
| `Formula` | `RtfDocumentNodeType` | Yes | `Formula` | `` |
| `Table` | `RtfDocumentNodeType` | Yes | `Table` | `` |
| `Text` | `RtfDocumentNodeType` | Yes | `Text` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Text` | `0` |
| `Table` | `1` |
| `Cell` | `2` |
| `Formula` | `3` |

**Underlying Type**: `System.Int32`

### `RtfDocumentViewer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfDocumentViewer` |
| **Base Type** | `System.Windows.Forms.ScrollableControl` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
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
          - `Topomatic.Controls.Rtf.RtfDocumentViewer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Document` | `RtfDocument` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RtfExport` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfExport` |
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
| `Export` | `Void` | `String fileName, RtfDocument document, Boolean open` | `` |

### `RtfTableNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfTableNode` |
| **Base Type** | `Topomatic.Controls.Rtf.RtfDocumentNode` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Rtf.RtfDocumentNode`
    - `Topomatic.Controls.Rtf.RtfTableNode`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `RtfTableNodeAlignment` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `` |
| `ColumnsCount` | `Int32` | `get` | No | `` |
| `Nodes` | `IEnumerable<RtfCellNode>` | `get` | No | `` |
| `RowsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddCell` | `RtfCellNode` | `Int32 row, Int32 column, Int32 rows, Int32 columns, String text, RtfTextAlignment textAlignment` | `` |
| `AddCell` | `RtfCellNode` | `Int32 row, Int32 column, Int32 rows, Int32 columns, String text, RtfTextAlignment alignment, Color color` | `` |
| `AddCell` | `RtfCellNode` | `Int32 row, Int32 column, Int32 rows, Int32 columns, String text` | `` |
| `AddCell` | `RtfCellNode` | `Int32 row, Int32 column, String text` | `` |
| `AddCell` | `RtfCellNode` | `Int32 row, Int32 column, String text, RtfTextAlignment textAlignment` | `` |
| `ColumnWidth` | `Void` | `Int32 column, Int32 value` | `` |
| `ColumnWidth` | `Int32` | `Int32 column` | `` |
| `RowHeight` | `Void` | `Int32 row, Int32 value` | `` |
| `RowHeight` | `Int32` | `Int32 row` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultColumnWidth` | `Int32` | Yes | `100` | `` |
| `DefaultRowHeight` | `Int32` | Yes | `20` | `` |

### `RtfTableNodeAlignment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfTableNodeAlignment` |
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
      - `Topomatic.Controls.Rtf.RtfTableNodeAlignment`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `RtfTableNodeAlignment` | Yes | `Center` | `` |
| `Left` | `RtfTableNodeAlignment` | Yes | `Left` | `` |
| `Right` | `RtfTableNodeAlignment` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Center` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `RtfTextAlignment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfTextAlignment` |
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
      - `Topomatic.Controls.Rtf.RtfTextAlignment`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CenterBottom` | `RtfTextAlignment` | Yes | `CenterBottom` | `` |
| `CenterMiddle` | `RtfTextAlignment` | Yes | `CenterMiddle` | `` |
| `CenterTop` | `RtfTextAlignment` | Yes | `CenterTop` | `` |
| `LeftBottom` | `RtfTextAlignment` | Yes | `LeftBottom` | `` |
| `LeftMiddle` | `RtfTextAlignment` | Yes | `LeftMiddle` | `` |
| `LeftTop` | `RtfTextAlignment` | Yes | `LeftTop` | `` |
| `RightBottom` | `RtfTextAlignment` | Yes | `RightBottom` | `` |
| `RightMiddle` | `RtfTextAlignment` | Yes | `RightMiddle` | `` |
| `RightTop` | `RtfTextAlignment` | Yes | `RightTop` | `` |
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

### `RtfTextNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Controls.Rtf.RtfTextNode` |
| **Base Type** | `Topomatic.Controls.Rtf.RtfAlignedNode` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Rtf.RtfDocumentNode`
    - `Topomatic.Controls.Rtf.RtfAlignedNode`
      - `Topomatic.Controls.Rtf.RtfTextNode`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bold` | `Boolean` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `` |
| `LineSpacing` | `Single` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 163 |
| **Classes** | 111 |
| **Interfaces** | 5 |
| **Enums** | 22 |
| **Structs** | 16 |
| **Abstract Classes** | 3 |
| **Static Classes** | 6 |
| **Total Methods** | 439 |
| **Total Properties** | 274 |
| **Total Fields** | 416 |
| **Total Events** | 42 |
| **Total Constructors** | 112 |
| **Nested Types** | 32 |
| **Extension Methods** | 0 |


