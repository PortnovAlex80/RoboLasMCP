# Topomatic.ExportDocumentation

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.ExportDocumentation` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.ExportDocumentation.dll` |

---
## Namespace: `Topomatic.ExportDocumentation`

### `Documentation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Documentation` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer, System.Collections.Generic.IEnumerable`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.ExportDocumentation.IDocumentationItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.ExportDocumentation.Documentation`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String outputFolder)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemType` | `String` | `get` | No | `` |
| `OutputPath` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DocumentationConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.DocumentationConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ARCHIVE_ITEM` | `String` | Yes | `"edocx_archive"` | `` |
| `DEFAULT_CONTAINER_CONTEXT` | `String` | Yes | `"ctx_edocx_container"` | `` |
| `DEFAULT_ITEM_CONTEXT` | `String` | Yes | `"ctx_edocx_item"` | `` |
| `DRAWING_ITEM` | `String` | Yes | `"edocx_drawing"` | `` |
| `DWL_FOLDER_LINK_ITEM` | `String` | Yes | `"edocx_folder_link_dwl"` | `` |
| `DWL_LINK_ITEM` | `String` | Yes | `"edocx_link_dwl"` | `` |
| `DWL_VOLUME_ITEM` | `String` | Yes | `"edocx_volume_dwl"` | `` |
| `DWP_VOLUME_FOLDER` | `String` | Yes | `"edocx_volume_folder"` | `` |
| `DWP_VOLUME_LINK` | `String` | Yes | `"edocx_volume_link"` | `` |
| `FILE_ITEM` | `String` | Yes | `"edocx_file"` | `` |
| `FOLDER_ITEM` | `String` | Yes | `"edocx_folder"` | `` |
| `MAPX_ITEM` | `String` | Yes | `"edocx_mapx"` | `` |
| `MODEL_TYPE` | `String` | Yes | `"application/edocx"` | `` |
| `ROOT` | `String` | Yes | `"edocx_documentation"` | `` |
| `TASK_BUILDERS` | `String` | Yes | `"edocxbuilders"` | `` |
| `UNKONOW_ITEM` | `String` | Yes | `"edocx_unkonow"` | `` |
| `WINDOW_ID` | `String` | Yes | `"edocx_window"` | `` |

### `DocumentationItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documentation` | `Documentation` | `get` | No | `` |
| `ItemType` | `String` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromJSON` | `Void` | `JsonReader reader` | `` |
| `SaveToJSON` | `Void` | `JsonWriter writer` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ThrowFormatError` | `Void` | `JsonReader reader` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IDocumentationContainer` | `get_Documentation` |

### `DocumentationItemsContainer`1<T where DocumentationItem, INamedTransactable, ITransactable, IUpdatable, IOwned, IDocumentationContainer, class, DocumentationItem>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.DocumentationItemsContainer`1` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer, System.Collections.Generic.IEnumerable`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.ExportDocumentation.IDocumentationItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.DocumentationItemsContainer`1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `CanContains` | `Boolean` | `Type type` | `` |
| `GetEnumerator` | `IEnumerator<DocumentationItem>` | `` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `LoadFromJSON` | `Void` | `JsonReader reader` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IDocumentationItemsContainer` | `CanContains` |

### `IDocumentationContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documentation` | `Documentation` | `get` | No | `` |

### `IDocumentationItemsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.IDocumentationItemsContainer` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanContains` | `Boolean` | `Type type` | `` |

---
## Namespace: `Topomatic.ExportDocumentation.Builder`

### `DocumentationContainerBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Builder.DocumentationContainerBuilder` |
| **Base Type** | `Topomatic.ExportDocumentation.Builder.DocumentationItemBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ExportDocumentation.Builder.DocumentationItemBuilder`
    - `Topomatic.ExportDocumentation.Builder.DocumentationContainerBuilder`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Context` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `IDocumentationItemsContainer container, DocumentationItem item` | `` |
| `CanAppendItem` | `Boolean` | `IDocumentationItemsContainer container, DocumentationItem item` | `` |
| `Insert` | `Void` | `IDocumentationItemsContainer container, DocumentationItem item, Int32 index` | `` |
| `PrepareDocumentationStorage` | `Void` | `IDocumentationItemsContainer container, String storage, String folder` | `` |
| `Remove` | `Boolean` | `IDocumentationItemsContainer container, DocumentationItem item` | `` |

### `DocumentationContainerBuilder`2<T where DocumentationItemsContainer`1, INamedTransactable, ITransactable, IUpdatable, IOwned, IDocumentationContainer, IEnumerable`1, IEnumerable, IDocumentationItemsContainer, class, DocumentationItemsContainer`1, U where DocumentationItem, INamedTransactable, ITransactable, IUpdatable, IOwned, IDocumentationContainer, class, DocumentationItem>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Builder.DocumentationContainerBuilder`2` |
| **Base Type** | `Topomatic.ExportDocumentation.Builder.DocumentationContainerBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ExportDocumentation.Builder.DocumentationItemBuilder`
    - `Topomatic.ExportDocumentation.Builder.DocumentationContainerBuilder`
      - `Topomatic.ExportDocumentation.Builder.DocumentationContainerBuilder`2`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `IDocumentationItemsContainer container, DocumentationItem item` | `` |
| `CanAppend` | `Boolean` | `IDocumentationItemsContainer container` | `` |
| `CreateItem` | `DocumentationItem` | `Object parent` | `` |
| `Insert` | `Void` | `IDocumentationItemsContainer container, DocumentationItem item, Int32 index` | `` |
| `Remove` | `Boolean` | `IDocumentationItemsContainer container, DocumentationItem item` | `` |

### `DocumentationItemBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Builder.DocumentationItemBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Context` | `String` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Icon` | `String` | `get` | No | `` |
| `ItemId` | `String` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignData` | `Void` | `DocumentationItem item, String pathid` | `` |
| `CanAppend` | `Boolean` | `IDocumentationItemsContainer container` | `` |
| `CanAssignData` | `Boolean` | `String modelType, String pathid` | `` |
| `CreateDocumentationStorage` | `String` | `DocumentationItem item, String folder` | `` |
| `CreateItem` | `DocumentationItem` | `Object parent` | `` |
| `CreateWrapper` | `DocumentationItemWrapper` | `DocumentationItem item` | `` |
| `IsEmpty` | `Boolean` | `DocumentationItem item` | `` |

### `DocumentationItemWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Builder.DocumentationItemWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `DocumentationItem` | `get` | No | `Browsable` |
| `ToolTip` | `String` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Refresh` | `Void` | `` | `` |

### `EditableDocumentaionItemWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Builder.EditableDocumentaionItemWrapper` |
| **Base Type** | `Topomatic.ExportDocumentation.Builder.DocumentationItemWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ExportDocumentation.Builder.DocumentationItemWrapper`
    - `Topomatic.ExportDocumentation.Builder.EditableDocumentaionItemWrapper`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EditableValue` | `String` | `get/set` | No | `` |

---
## Namespace: `Topomatic.ExportDocumentation.Items`

### `ArchiveDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.ArchiveDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer, System.Collections.Generic.IEnumerable`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.ExportDocumentation.IDocumentationItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.ExportDocumentation.Items.ArchiveDocumentationItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String archiveItem)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArchiveName` | `String` | `get/set` | No | `` |
| `ItemType` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrawingDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.DrawingDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.Items.DrawingDocumentationItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String name, String provider, String relativePath)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemType` | `String` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Provider` | `String` | `get/set` | No | `` |
| `RelativePath` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwlFolderLinkDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.DwlFolderLinkDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.Items.DwlLinkDocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.Items.DwlLinkDocumentationItem`
          - `Topomatic.ExportDocumentation.Items.DwlFolderLinkDocumentationItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String relativePath, String filter, Boolean subFolders)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Filter` | `String` | `get/set` | No | `` |
| `ItemType` | `String` | `get` | No | `` |
| `Subfolders` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwlLinkDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.DwlLinkDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.Items.DwlLinkDocumentationItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String relativePath)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemType` | `String` | `get` | No | `` |
| `RelativePath` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwlVolumeItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.DwlVolumeItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.Items.DwlLinkDocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer, System.Collections.Generic.IEnumerable`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.ExportDocumentation.IDocumentationItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.Items.DwlLinkDocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.ExportDocumentation.Items.DwlVolumeItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String fileName)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemType` | `String` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwpVolumeFolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.DwpVolumeFolder` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer, System.Collections.Generic.IEnumerable`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.ExportDocumentation.IDocumentationItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.ExportDocumentation.Items.DwpVolumeFolder`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String folderName)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FolderName` | `String` | `get/set` | No | `` |
| `ItemType` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanContains` | `Boolean` | `Type type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDocumentationItemsContainer` | `CanContains` |

### `DwpVolumeLink` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.DwpVolumeLink` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.Items.DwpVolumeLink`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String relativePath, String layout)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemType` | `String` | `get` | No | `` |
| `RelativePath` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FileDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.FileDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.Items.FileDocumentationItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String fileName, String relativePath)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get/set` | No | `` |
| `ItemType` | `String` | `get` | No | `` |
| `RelativePath` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FolderDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.FolderDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer, System.Collections.Generic.IEnumerable`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.ExportDocumentation.IDocumentationItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.DocumentationItemsContainer`1[[Topomatic.ExportDocumentation.DocumentationItem, Topomatic.ExportDocumentation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.ExportDocumentation.Items.FolderDocumentationItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String folderName)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FolderName` | `String` | `get/set` | No | `` |
| `ItemType` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MapxDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.MapxDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.Items.MapxDocumentationItem`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, String fileName, String relativePath)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemType` | `String` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `RelativePath` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UnkonwDocumentationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ExportDocumentation.Items.UnkonwDocumentationItem` |
| **Base Type** | `Topomatic.ExportDocumentation.DocumentationItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.ExportDocumentation.IDocumentationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.ExportDocumentation.DocumentationItem`
        - `Topomatic.ExportDocumentation.Items.UnkonwDocumentationItem`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemType` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToJSON` | `Void` | `JsonWriter writer` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 22 |
| **Classes** | 12 |
| **Interfaces** | 2 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 7 |
| **Static Classes** | 1 |
| **Total Methods** | 30 |
| **Total Properties** | 42 |
| **Total Fields** | 17 |
| **Total Events** | 0 |
| **Total Constructors** | 23 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


