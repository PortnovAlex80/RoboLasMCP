# Topomatic.Libx

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Libx` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Libx.dll` |

---
## Namespace: `Topomatic.Libx`

### `xLibrary` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Libx.xLibrary` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |
| `IsSatelite` | `Boolean` | `get` | No | `` |
| `Item` | `xLibraryNode` | `get` | No | `` |
| `Modified` | `Boolean` | `get` | No | `` |
| `Readonly` | `Boolean` | `get` | No | `` |
| `Root` | `xLibraryNode` | `get` | No | `` |
| `SateliteName` | `String` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddStream` | `Void` | `String name, Stream stream` | `` |
| `GetData` | `Byte[]` | `String name` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<Guid xLibraryNode>>` | `` | `` |
| `GetStream` | `Stream` | `String name` | `` |
| `GetThumbnail` | `Stream` | `Guid id, Single scale` | `` |
| `Modify` | `Void` | `` | `` |
| `RemoveStream` | `Void` | `String name` | `` |
| `TryGetValue` | `Boolean` | `Guid key, ref xLibraryNode value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `xLibraryCollection` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Libx.xLibraryCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibrary, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveSatelite` | `String` | `get/set` | No | `` |
| `Environment` | `String` | `get` | No | `` |
| `LibraryName` | `String` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddLastSelected` | `Void` | `Guid guid` | `` |
| `AddLibrary` | `xLibrary` | `String fileName, String env` | `` |
| `AddLibrary` | `xLibrary` | `String fileName, String env, Boolean readOnly` | `` |
| `AddLibrary` | `xLibrary` | `String fileName` | `` |
| `CommitChanges` | `Void` | `` | `` |
| `FetchSatelites` | `IEnumerable<String>` | `` | `` |
| `GetEnumerator` | `IEnumerator<xLibrary>` | `` | `` |
| `GetLastSelected` | `Guid[]` | `` | `` |
| `RallbackChanges` | `Void` | `` | `` |
| `RemoveLibrary` | `Boolean` | `xLibrary library` | `` |
| `SynchronizeLibraries` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `xLibraryCollection`1<T where xLibraryNode, IDisposable, IEnumerable`1, IEnumerable, class, xLibraryNode>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Libx.xLibraryCollection`1` |
| **Base Type** | `Topomatic.Libx.xLibraryCollection` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibrary, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryCollection`
    - `Topomatic.Libx.xLibraryCollection`1`

#### Constructors (1)

- `.ctor(String environment)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetValue` | `Boolean` | `Guid key, ref T value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `xLibraryNode` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Libx.xLibraryNode` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Guid` | `Guid` | `get/set` | No | `` |
| `IsFolder` | `Boolean` | `get` | No | `` |
| `Library` | `xLibrary` | `get/set` | No | `` |
| `Parent` | `xLibraryNode` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `xLibraryNode` | `String caption` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetAllSubNodes` | `IEnumerable<xLibraryNode>` | `` | `` |
| `GetEnumerator` | `IEnumerator<xLibraryNode>` | `` | `` |
| `Remove` | `Boolean` | `xLibraryNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

---
## Namespace: `Topomatic.Libx.Gui`

### `xLibrayDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Libx.Gui.xLibrayDlg` |
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
                  - `Topomatic.Libx.Gui.xLibrayDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LibraryCollection` | `xLibraryCollection` | `get/set` | No | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `listView` | `ListViewEx` | No | `` | `` |
| `splitContainer` | `SplitContainer` | No | `` | `` |
| `toolStrip` | `ToolStripEx` | No | `` | `` |
| `treeView` | `TreeViewEx` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 5 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 3 |
| **Static Classes** | 0 |
| **Total Methods** | 27 |
| **Total Properties** | 17 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


