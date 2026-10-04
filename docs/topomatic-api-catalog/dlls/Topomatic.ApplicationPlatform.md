# Topomatic.ApplicationPlatform

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.ApplicationPlatform` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.ApplicationPlatform, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.ApplicationPlatform.dll` |

---
## Namespace: ``

### `MethodProtectionAttributes` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `MethodProtectionAttributes` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `MethodProtectionAttributes`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FeatureId` | `Int32` | `get/set` | No | `` |
| `Protect` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.ApplicationPlatform`

### `ApplicationHost` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ApplicationHost` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonAppDataRegistryReadOnlyMode` | `RegistryKey` | `get` | Yes | `` |
| `CommonAppDataRegistryWithoutVersion32` | `RegistryKey` | `get` | Yes | `` |
| `Current` | `IApplicationHost` | `get/set` | Yes | `` |
| `UserAppDataRegistryWithoutVersion` | `RegistryKey` | `get` | Yes | `` |

### `ComboItemDrawEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ComboItemDrawEventArgs` |
| **Base Type** | `System.Windows.Forms.DrawItemEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `System.Windows.Forms.DrawItemEventArgs`
      - `Topomatic.ApplicationPlatform.ComboItemDrawEventArgs`

#### Constructors (1)

- `.ctor(Graphics graphics, Font font, Rectangle rect, DrawItemState state, Color foreColor, Color backColor)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawDefault` | `Void` | `Object item` | `` |

### `ComboItemMouseEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ComboItemMouseEventArgs` |
| **Base Type** | `System.Windows.Forms.MouseEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `System.Windows.Forms.MouseEventArgs`
      - `Topomatic.ApplicationPlatform.ComboItemMouseEventArgs`

#### Constructors (1)

- `.ctor(MouseButtons button, Int32 clicks, Int32 x, Int32 y, Int32 delta, Object obj, Size size)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CloseDropDown` | `Boolean` | `get/set` | No | `` |
| `InvalidateRect` | `Nullable<Rectangle>` | `get/set` | No | `` |
| `Object` | `Object` | `get` | No | `` |
| `Size` | `Size` | `get` | No | `` |
| `UpdateItems` | `Boolean` | `get/set` | No | `` |

### `Consts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Consts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ModelGuidToId` | `String` | `String id` | `` |
| `ShortcutToString` | `String` | `Keys s` | `` |

#### Fields (32)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BroadcastAddFrame` | `String` | Yes | `` | `` |
| `BroadcastAddLayer` | `String` | Yes | `` | `` |
| `BroadcastAddWindow` | `String` | Yes | `` | `` |
| `BroadcastEnvironmentChanged` | `String` | Yes | `` | `` |
| `BroadcastProjectClose` | `String` | Yes | `` | `` |
| `BroadcastProjectOpened` | `String` | Yes | `` | `` |
| `BroadcastProjectSaved` | `String` | Yes | `` | `` |
| `BroadcastRemoveFrame` | `String` | Yes | `` | `` |
| `BroadcastRemoveLayer` | `String` | Yes | `` | `` |
| `BroadcastRemoveWindow` | `String` | Yes | `` | `` |
| `CommonCommandWindow` | `String` | Yes | `` | `` |
| `CommonComponentInspectorWindow` | `String` | Yes | `` | `` |
| `CommonPropertyGridWindow` | `String` | Yes | `` | `` |
| `CommonPropertyInspectorWindow` | `String` | Yes | `` | `` |
| `CrossWindow` | `String` | Yes | `` | `` |
| `ErrorsList` | `String` | Yes | `` | `` |
| `FunctionAddItem` | `String` | Yes | `` | `` |
| `FunctionGetName` | `String` | Yes | `` | `` |
| `FunctionMakeItem` | `String` | Yes | `` | `` |
| `FunctionOpen` | `String` | Yes | `` | `` |
| `HistoryWindow` | `String` | Yes | `` | `` |
| `MainForm` | `String` | Yes | `` | `` |
| `ModelFrame` | `String` | Yes | `` | `` |
| `ModelsLayer` | `Guid` | Yes | `` | `` |
| `ModelTypeFolder` | `String` | Yes | `` | `` |
| `PlanWindow` | `String` | Yes | `` | `` |
| `ProfileWindow` | `String` | Yes | `` | `` |
| `ProjectExplorerWindow` | `String` | Yes | `` | `` |
| `RelatedDocumentsWindow` | `String` | Yes | `` | `` |
| `TaskUpdateDwl` | `String` | Yes | `` | `` |
| `TaskUpdateModel` | `String` | Yes | `` | `` |
| `VolumeWindow` | `String` | Yes | `` | `` |

### `EnvironmentList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.EnvironmentList` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.Generic.IDictionary`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Project project)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `Keys` | `ICollection<String>` | `get` | No | `` |
| `Values` | `ICollection<Object>` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `KeyValuePair<String Object> item` | `` |
| `Add` | `Void` | `String key, Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `KeyValuePair<String Object> item` | `` |
| `ContainsKey` | `Boolean` | `String key` | `` |
| `CopyTo` | `Void` | `KeyValuePair<String Object>[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String Object>>` | `` | `` |
| `Remove` | `Boolean` | `KeyValuePair<String Object> item` | `` |
| `Remove` | `Boolean` | `String key` | `` |
| `TryGetValue` | `Boolean` | `String key, ref T value` | `` |
| `TryGetValue` | `Boolean` | `String key, ref Object value` | `` |

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
| `IDictionary`2` | `get_Item` |
| `IDictionary`2` | `set_Item` |
| `IDictionary`2` | `get_Keys` |
| `IDictionary`2` | `get_Values` |
| `IDictionary`2` | `ContainsKey` |
| `IDictionary`2` | `Add` |
| `IDictionary`2` | `Remove` |
| `IDictionary`2` | `TryGetValue` |

### `FrameEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.FrameEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.ApplicationPlatform.FrameEventArgs`

#### Constructors (1)

- `.ctor(String uid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `UID` | `String` | `get` | No | `` |

### `IApplicationHost` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IApplicationHost` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveDocument` | `IDocumentWindow` | `get` | No | `` |
| `ActiveProject` | `Project` | `get` | No | `` |
| `ActiveWindow` | `Object` | `get` | No | `` |
| `AssemblyTitle` | `String` | `get` | No | `` |
| `DefaultProjectDirectory` | `String` | `get` | No | `` |
| `DefaultSettingsPath` | `String` | `get` | No | `` |
| `InstalledTemplatePath` | `String` | `get` | No | `` |
| `Log` | `IApplicationLog` | `get` | No | `` |
| `MainForm` | `IMainForm` | `get` | No | `` |
| `MyExportedTemplatesPath` | `String` | `get` | No | `` |
| `Plugins` | `PluginManager` | `get` | No | `` |
| `ProjectList` | `IProjectList` | `get` | No | `` |
| `ReadyForAsyncWork` | `Boolean` | `get` | No | `` |
| `Settings` | `Settings` | `get` | No | `` |
| `UserDocumentsDirectory` | `String` | `get` | No | `` |
| `UserId` | `String` | `get` | No | `` |
| `UserTemplatesPath` | `String` | `get` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloseAllProjects` | `Boolean` | `` | `` |
| `CreateProject` | `Project` | `String alias` | `` |
| `CreateProject` | `Project` | `String templatePath, String name, String location, String alias, Boolean readOnly` | `` |
| `CreateProjectImp` | `IProjectImp` | `Project project` | `` |
| `GetAvailableModelTypes` | `IEnumerable<String>` | `` | `` |
| `GetConfiguredFeatures` | `Guid[]` | `` | `` |
| `GetProjectInfo` | `ProjectTypeInfo` | `String alias` | `` |
| `GetTemplateInfo` | `Template` | `String path` | `` |
| `InvokeDelayed` | `Int64` | `Int32 milliseconds, Action callback, Boolean regular, Boolean ui` | `` |
| `LoadIcon` | `Image` | `String name, String plugin, Int32 sizedp` | `` |
| `LoadIcon` | `Image` | `String name, Int32 sizedp` | `` |
| `RefreshGui` | `Void` | `` | `` |
| `RegisterRemoteService` | `Void` | `MarshalByRefObject service` | `` |
| `RevokeDelayed` | `Boolean` | `Int64 id` | `` |
| `ShowSettings` | `Boolean` | `IEnumerable settings, String caption, Boolean expand` | `` |
| `ShowSettings` | `Boolean` | `IEnumerable settings, String caption, Boolean expand, String root, String[] hidden` | `` |
| `ShowSettings` | `Boolean` | `IEnumerable settings, String caption, Boolean expand, String root, String active, String[] hidden` | `` |
| `TryGetRemoteServices` | `Boolean` | `Type key, ref MarshalByRefObject service` | `` |

### `IApplicationLog` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IApplicationLog` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginWrite` | `Void` | `` | `` |
| `EndWrite` | `Void` | `` | `` |
| `WriteLine` | `Void` | `String s` | `` |

### `ICommonWindow` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ICommonWindow` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `UserControl` | `Control` | `get` | No | `` |

### `ICommonWindows` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ICommonWindows` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ICommonWindow` | `get` | No | `` |
| `Keys` | `ICollection<String>` | `get` | No | `` |
| `Values` | `ICollection<ICommonWindow>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ContainsKey` | `Boolean` | `String key` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String ICommonWindow>>` | `` | `` |
| `TryGetValue` | `Boolean` | `String key, ref ICommonWindow value` | `` |

### `ICompoundComboItem` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ICompoundComboItem` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `ComboItemDrawEventArgs e` | `` |
| `MouseDown` | `Void` | `ComboItemMouseEventArgs e` | `` |

### `IDocumentWindow` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IDocumentWindow` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ClassUID` | `String` | `get` | No | `` |
| `CloseButton` | `Boolean` | `get/set` | No | `` |
| `Icon` | `Icon` | `get/set` | No | `` |
| `Project` | `Project` | `get` | No | `` |
| `Text` | `String` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `UID` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Activate` | `Void` | `` | `` |
| `Close` | `Boolean` | `` | `` |
| `Close` | `Void` | `FormClosingEventArgs e` | `` |
| `Maximize` | `Void` | `` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `FormClosing` | `FormClosingEventHandler` | No | `` |
| `Load` | `EventHandler` | No | `` |

### `IDocumentWindowFrame` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IDocumentWindowFrame` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Cad.View.ICadViewForm, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |
| `Control` | `Control` | `get` | No | `` |
| `Document` | `IFramableDocumentWindow` | `get` | No | `` |
| `LayoutStorage` | `ILayoutStorage` | `get/set` | No | `` |
| `SupportClose` | `Boolean` | `get/set` | No | `` |
| `SupportRename` | `Boolean` | `get/set` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |
| `UID` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Close` | `Boolean` | `` | `` |
| `DoCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `Rename` | `Void` | `` | `` |

#### Events (3)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterRename` | `EventHandler` | No | `` |
| `Closing` | `CancelEventHandler` | No | `` |
| `CreateMenu` | `CreateMenuEventHandler` | No | `` |

### `IFramableDocumentWindow` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IFramableDocumentWindow` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.ApplicationPlatform.IDocumentWindow, Topomatic.Cad.View.ICadViewForm` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveFrame` | `IDocumentWindowFrame` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `DisplayTabs` | `Boolean` | `get/set` | No | `` |
| `Item` | `IDocumentWindowFrame` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddCadViewFrame` | `IDocumentWindowFrame` | `String uid, String caption, IFrameInitializer initializer` | `` |
| `AddCadViewFrame` | `IDocumentWindowFrame` | `String uid, String caption` | `` |
| `AddFrame` | `IDocumentWindowFrame` | `String uid, String caption` | `` |
| `AddFrame` | `IDocumentWindowFrame` | `String uid, String caption, ILayoutStorage layout` | `` |
| `ClearFrames` | `Void` | `` | `` |
| `Contains` | `Boolean` | `String uid` | `` |
| `Contains` | `Boolean` | `IDocumentWindowFrame frame` | `` |
| `GetFrames` | `IEnumerable<IDocumentWindowFrame>` | `` | `` |
| `Remove` | `Void` | `IDocumentWindowFrame frame` | `` |

#### Events (4)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `ActiveFrameChanged` | `EventHandler` | No | `` |
| `AfterAddFrame` | `EventHandler<FrameEventArgs>` | No | `` |
| `BeforeRemoveFrame` | `EventHandler<FrameEventArgs>` | No | `` |
| `CreateMenu` | `CreateMenuEventHandler` | No | `` |

### `IFrameInitializer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IFrameInitializer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `Void` | `IDocumentWindowFrame frame, Boolean existent` | `` |

### `ILayoutStorage` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ILayoutStorage` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Applay` | `Boolean` | `StgNode node, IDocumentWindowFrame frame` | `` |
| `Scrape` | `Boolean` | `StgNode node, StgNode old, IDocumentWindowFrame frame` | `` |

### `IMainForm` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IMainForm` |
| **Base Type** | `none` |
| **Implements** | `System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonWindows` | `ICommonWindows` | `get` | No | `` |
| `IsHandleCreated` | `Boolean` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Activate` | `Void` | `` | `` |
| `BeginInvoke` | `IAsyncResult` | `Delegate method` | `` |
| `Invoke` | `Object` | `Delegate method` | `` |
| `OrganizeWindows` | `Void` | `KeyValuePair<String RectangleF>[] windows` | `` |
| `SelectObjects` | `Void` | `IEnumerable collection, Boolean display, SelectMode mode` | `` |
| `ShowNotifyMessage` | `Void` | `String title, String message, Int32 timeout` | `` |

### `IProjectImp` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IProjectImp` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveDocument` | `IDocumentWindow` | `get` | No | `` |
| `EnvironmentList` | `EnvironmentList` | `get` | No | `` |
| `Item` | `IDocumentWindow` | `get` | No | `` |
| `TransactionManager` | `TransactionManager` | `get` | No | `` |
| `WindowsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDocumentWindow` | `IFramableDocumentWindow` | `String uid, String classUid, Boolean ownerTransactionManager` | `` |
| `Close` | `Boolean` | `` | `` |
| `ContainsWindow` | `Boolean` | `String uid` | `` |
| `GetWindows` | `IEnumerable<IDocumentWindow>` | `` | `` |
| `RemoveWindow` | `Void` | `IDocumentWindow window` | `` |
| `TryGetWindow` | `Boolean` | `String uid, ref IDocumentWindow window` | `` |

### `IProjectList` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.IProjectList` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Project` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<Project>` | `` | `` |
| `IndexOf` | `Int32` | `Project item` | `` |

### `MessageException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.MessageException` |
| **Base Type** | `System.Exception` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.ApplicationPlatform.MessageException`

#### Constructors (2)

- `.ctor(String message)`
- `.ctor(String message, Exception innerException)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Project` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Project` |
| **Base Type** | `System.MarshalByRefObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `Topomatic.ApplicationPlatform.Project`

#### Constructors (1)

- `.ctor(String alias)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Active` | `Boolean` | `get` | No | `` |
| `ActiveDocument` | `IDocumentWindow` | `get` | No | `` |
| `Alias` | `String` | `get` | No | `` |
| `EnvironmentList` | `EnvironmentList` | `get` | No | `` |
| `Imp` | `IProjectImp` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `IDocumentWindow` | `get` | No | `` |
| `Settings` | `Settings` | `get` | No | `` |
| `TargetProjectUri` | `URI` | `get/set` | No | `` |
| `TransactionManager` | `TransactionManager` | `get` | No | `` |
| `WindowsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Activate` | `Void` | `` | `` |
| `AddDocumentWindow` | `IFramableDocumentWindow` | `String uid` | `` |
| `AddDocumentWindow` | `IFramableDocumentWindow` | `String uid, String classUid, Boolean ownerTransactionManager` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Close` | `Boolean` | `` | `` |
| `ContainsWindow` | `Boolean` | `String uid` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetLinkedFiles` | `IEnumerable<FileEntry>` | `` | `` |
| `GetWindows` | `IEnumerable<IDocumentWindow>` | `` | `` |
| `RemoveWindow` | `Void` | `IDocumentWindow window` | `` |
| `SaveRequest` | `DialogResult` | `` | `` |
| `TryGetWindow` | `Boolean` | `String uid, ref IDocumentWindow window` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `Topomatic.FoundationClasses.Undo.ITransactable.get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `ProjectTypeInfo` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ProjectTypeInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultExtention` | `String` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `JuxtaposedExtensions` | `KeyValuePair<String String[]>[]` | `get` | No | `` |
| `ProjectFilter` | `String` | `get` | No | `` |
| `ProvideDefaultTemplate` | `Boolean` | `get` | No | `` |
| `RootProjectGroup` | `String` | `get` | No | `` |
| `RootProjectGroupSortOrder` | `Int32` | `get` | No | `` |
| `SupportMultiProject` | `Boolean` | `get` | No | `` |
| `SupportTemporary` | `Boolean` | `get` | No | `` |
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Project` | `` | `` |
| `InitializeDefaultTemplate` | `Void` | `Template template` | `` |
| `IsMatchExtension` | `Boolean` | `String extension` | `` |
| `ReplaceParameters` | `Void` | `String location, String name, IDictionary<String String> parameters` | `` |

### `RemoteApplicationHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.RemoteApplicationHost` |
| **Base Type** | `System.MarshalByRefObject` |
| **Implements** | `System.IServiceProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `Topomatic.ApplicationPlatform.RemoteApplicationHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurrentHost` | `IApplicationHost` | `get` | No | `` |
| `IsReady` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetService` | `Object` | `Type serviceType` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IServiceProvider` | `GetService` |

### `SelectedChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.SelectedChangedEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.ApplicationPlatform.SelectedChangedEventArgs`

#### Constructors (1)

- `.ctor(Object selected)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Selected` | `Object` | `get` | No | `` |

---
## Namespace: `Topomatic.ApplicationPlatform.Core`

### `AccessIntent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+AccessIntent` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Metadata metadata, IHashCalculator hasher)`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Error` | `SynchronizationException` | No | `` | `` |
| `Fullpath` | `String` | No | `` | `` |
| `Hasher` | `IHashCalculator` | No | `` | `` |
| `Metadata` | `Metadata` | No | `` | `` |

### `Attributes` (class)

**Attributes**: [DefaultMember, AutoCreateValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.Attributes` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Stg.IStgSerializable, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AsBool` | `Boolean` | `String key, Boolean def` | `` |
| `AsDouble` | `Double` | `String key, Double def` | `` |
| `AsInt` | `Int32` | `String key, Int32 def` | `` |
| `AsString` | `String` | `String key, String def` | `` |
| `Clone` | `Object` | `` | `` |
| `ContainsKey` | `Boolean` | `String key` | `` |
| `Edit` | `Dictionary<String Object>` | `` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String Object>>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Save` | `Void` | `JsonWriter json` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `Attributes` | `JsonReader json` | `` |
| `Create` | `Attributes` | `Object[] args` | `` |
| `Create` | `Attributes` | `IDictionary<String Object> values` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICloneable` | `Clone` |

### `DocumentModelEditor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.DocumentModelEditor` |
| **Base Type** | `Topomatic.ApplicationPlatform.Core.ModelEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Open` | `IEditorResult` | `IProjectModel model` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindActiveModel` | `IProjectModel` | `` | `` |

#### Nested Types (1)

- `EditorResult` (class)

### `DriveReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+DriveReference` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Directory` | `URI` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Root` | `IResource` | `get/set` | No | `` |
| `URI` | `URI` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `EditorResult` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.DocumentModelEditor+EditorResult` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.Core.IEditorResult` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IFramableDocumentWindow window, DocumentModelEditor editor, IProjectModel model, Boolean locked)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Opened` | `Boolean` | `get` | No | `` |
| `Readonly` | `Boolean` | `get` | No | `` |
| `Window` | `IFramableDocumentWindow` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Close` | `Void` | `` | `` |
| `Reload` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEditorResult` | `get_Opened` |
| `IEditorResult` | `Close` |
| `IEditorResult` | `Reload` |

### `ETagHashCalculator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+ETagHashCalculator` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.Core.FileManager+IHashCalculator` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FileHash` | `String` | `String lpath` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `ETagHashCalculator` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHashCalculator` | `FileHash` |

### `FileManager` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DisableOffline` | `Boolean` | `get/set` | Yes | `` |

#### Static Methods (31)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Accessable` | `Boolean` | `String uri` | `` |
| `Accessable` | `Boolean` | `String uri, ref Boolean folder` | `` |
| `AddDrive` | `Void` | `URI uri, String path, String name` | `` |
| `AddListener` | `Void` | `IFileManagerListener listener` | `` |
| `Combine` | `String` | `String baseUri, String child` | `` |
| `CreateFolder` | `Void` | `String uri` | `` |
| `Finallize` | `Void` | `` | `` |
| `FindDrive` | `DriveReference` | `URI uri` | `` |
| `FindSchemeProvider` | `IScheme` | `String scheme` | `` |
| `GetDriveReferences` | `IEnumerable<DriveReference>` | `` | `` |
| `GetSchemes` | `IEnumerable<IScheme>` | `` | `` |
| `HasDrive` | `Boolean` | `URI uri` | `` |
| `HasUnresolvedConflicts` | `Boolean` | `String uri` | `` |
| `Initialize` | `Void` | `` | `` |
| `ListFolder` | `URI[]` | `URI uri` | `` |
| `ListFolder` | `URI[]` | `URI uri, Boolean recursive` | `` |
| `LocalDatabasePath` | `String` | `String uri` | `` |
| `LockWrite` | `Metadata` | `String uri, Int32 timeout` | `` |
| `LockWrite` | `Metadata` | `String uri` | `` |
| `Modifed` | `Nullable<DateTime>` | `String uri` | `` |
| `Open` | `IResource` | `String uri` | `` |
| `Read` | `IAsyncResult` | `String uri, Action<AccessIntent> callback` | `` |
| `RefreshFolder` | `Void` | `URI uri, Boolean progress` | `` |
| `RefreshFolder` | `Void` | `URI uri, Boolean progress, Nullable<Int32> depth, Predicate<IResource> filter` | `` |
| `Remove` | `IAsyncResult` | `String uri` | `` |
| `RemoveListener` | `Boolean` | `IFileManagerListener listener` | `` |
| `RemoveTransactable` | `IAsyncResult` | `String uri, ref ICommand cmd` | `` |
| `SynchronizeAllDrives` | `Void` | `Boolean download` | `` |
| `SyncRead` | `String` | `String uri, ref Metadata metadata` | `` |
| `UnlockWrite` | `Void` | `String uri` | `` |
| `Write` | `IAsyncResult` | `String uri, Action<AccessIntent> callback` | `` |

#### Nested Types (16)

- `AccessIntent` (class)
- `DriveReference` (class)
- `ETagHashCalculator` (class)
- `FileNotFoundSynchronizationException` (class)
- `IFileManagerListener` (interface)
- `IHashCalculator` (interface)
- `IResource` (interface)
- `IResource2` (interface)
- `IResource3` (interface)
- `IResourceObserver` (interface)
- `IScheme` (interface)
- `Md5HashCalculator` (class)
- `Metadata` (class)
- `ResourceLockerSynchronizationException` (class)
- `Sha1HashCalculator` (class)
- `SynchronizationException` (class)

### `FileNotFoundSynchronizationException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+FileNotFoundSynchronizationException` |
| **Base Type** | `Topomatic.ApplicationPlatform.Core.FileManager+SynchronizationException` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.ApplicationPlatform.Core.FileManager+SynchronizationException`
      - `Topomatic.ApplicationPlatform.Core.FileManager+FileNotFoundSynchronizationException`

#### Constructors (1)

- `.ctor(String uri)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Resolve` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IEditorResult` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.IEditorResult` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Opened` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Close` | `Void` | `` | `` |
| `Reload` | `Void` | `` | `` |

### `IFileManagerListener` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+IFileManagerListener` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.ApplicationPlatform.Core.FileManager+IResourceObserver` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AfterSynchronizeChanges` | `Void` | `URI uri, String lpath` | `` |
| `AfterWriteLocalChanges` | `Void` | `URI uri, String lpath` | `` |
| `BeforeWriteLocalChanges` | `Void` | `URI uri, String lpath` | `` |
| `HandleError` | `Void` | `IResource res` | `` |
| `HandleSuccess` | `Void` | `IResource res` | `` |
| `ResolveConflict` | `Boolean` | `IResource remote, String local, String origin` | `` |

### `IHashCalculator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+IHashCalculator` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FileHash` | `String` | `String lpath` | `` |

### `IProjectModel` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.IProjectModel` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Hash` | `String` | `get` | No | `` |
| `IsLockedWrite` | `Boolean` | `get` | No | `` |
| `LockedException` | `ResourceLockedException` | `get` | No | `` |
| `Model` | `Object` | `get` | No | `` |
| `ModelType` | `String` | `get` | No | `` |
| `Modified` | `Boolean` | `get/set` | No | `` |
| `Project` | `ModelProject` | `get` | No | `` |
| `ReferencesModified` | `Boolean` | `get/set` | No | `` |
| `Status` | `Int32` | `get` | No | `` |
| `Uri` | `URI` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `IProjectModel` | `URI uri, String modelType` | `` |
| `Add` | `IProjectModel` | `URI uri` | `` |
| `GetChilds` | `IProjectModel[]` | `` | `` |
| `LockRead` | `Object` | `` | `` |
| `LockReadAsync` | `Void` | `Action<Object Exception> callback` | `` |
| `LockWrite` | `Void` | `` | `` |
| `Move` | `Void` | `URI uri, Int32 index` | `` |
| `Reload` | `Void` | `` | `` |
| `Remove` | `Void` | `IProjectModel model, Boolean removeFile` | `` |
| `Save` | `IAsyncResult` | `Boolean forced` | `` |
| `TrimAccess` | `Void` | `` | `` |
| `UnlockWrite` | `Void` | `` | `` |

### `IResource` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+IResource` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Exists` | `Boolean` | `get` | No | `` |
| `Folder` | `Boolean` | `get` | No | `` |
| `Hash` | `String` | `get` | No | `` |
| `Hasher` | `IHashCalculator` | `get` | No | `` |
| `Modifed` | `DateTime` | `get` | No | `` |
| `Size` | `Int64` | `get` | No | `` |
| `Url` | `URI` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Delete` | `Void` | `` | `` |
| `Download` | `Void` | `String origin, String fullpath` | `` |
| `List` | `IEnumerable<IResource>` | `` | `` |
| `LockWrite` | `Void` | `` | `` |
| `Open` | `IResource` | `String uri` | `` |
| `UnlockWrite` | `Void` | `` | `` |
| `Upload` | `Void` | `String fullpath` | `` |

### `IResource2` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+IResource2` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckOnline` | `Boolean` | `` | `` |
| `ClearCache` | `Void` | `` | `` |
| `CreateFolder` | `IResource` | `String name` | `` |

### `IResource3` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+IResource3` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Explore` | `Void` | `` | `` |

### `IResourceObserver` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+IResourceObserver` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Created` | `Void` | `String uri` | `` |
| `Modifed` | `Void` | `String uri` | `` |
| `Removed` | `Void` | `String uri` | `` |

### `IScheme` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+IScheme` |
| **Base Type** | `none` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Hasher` | `IHashCalculator` | `get` | No | `` |
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Connect` | `String` | `` | `` |
| `Open` | `IResource` | `String uri, IResourceObserver observer` | `` |

### `LayerState` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ProjectStateConfiguration+LayerState` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layers` | `IList<LayerState>` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

### `Md5HashCalculator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+Md5HashCalculator` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.Core.FileManager+IHashCalculator` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FileHash` | `String` | `String lpath` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `Md5HashCalculator` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHashCalculator` | `FileHash` |

### `Metadata` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+Metadata` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Base` | `String` | `get/set` | No | `` |
| `ETag` | `String` | `get/set` | No | `` |
| `Item` | `String` | `get/set` | No | `` |
| `Local` | `String` | `get/set` | No | `` |
| `Modifed` | `String` | `get/set` | No | `` |
| `Remote` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<KeyValuePair<String String>>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `ModelEditor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ModelEditor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSoftReference` | `Void` | `IProjectModel model, URI uri, String modelType` | `` |
| `GetHardReferences` | `ModelHardReference[]` | `IProjectModel model` | `` |
| `GetSoftReferences` | `ModelSoftReference[]` | `Object model` | `` |
| `LoadFromFile` | `Object` | `String fullpath` | `` |
| `MoveSoftReference` | `Void` | `IProjectModel root, URI uri, Int32 index` | `` |
| `Open` | `IEditorResult` | `IProjectModel model` | `` |
| `RemoveSoftReference` | `Void` | `IProjectModel root, IProjectModel model` | `` |
| `ReplaceModelHardReference` | `Void` | `IProjectModel model, URI oldValue, URI newValue` | `` |
| `ReplaceObjectHardReference` | `Void` | `Object model, URI oldValue, URI newValue` | `` |
| `SaveToFile` | `Void` | `Object model, String fullpath` | `` |

### `ModelEditorInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ModelEditorInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String filter, String extension, String title, String description, String activator)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Activator` | `String` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `Filter` | `String` | `get` | No | `` |
| `IsReplateParameters` | `Boolean` | `get/set` | No | `` |
| `JuxtaposedExtensions` | `KeyValuePair<String String[]>[]` | `get` | No | `` |
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsMatchExtension` | `Boolean` | `String extension` | `` |

### `ModelHardReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ModelHardReference` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(URI uri)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Uri` | `URI` | `get/set` | No | `` |

### `ModelMasterStatus` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ModelMasterStatus` |
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
      - `Topomatic.ApplicationPlatform.Core.ModelMasterStatus`

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AddedLocal` | `ModelMasterStatus` | Yes | `AddedLocal` | `` |
| `AddedRemote` | `ModelMasterStatus` | Yes | `AddedRemote` | `` |
| `Equality` | `ModelMasterStatus` | Yes | `Equality` | `` |
| `Error` | `ModelMasterStatus` | Yes | `Error` | `` |
| `MasterOnly` | `ModelMasterStatus` | Yes | `MasterOnly` | `` |
| `ModifedConflict` | `ModelMasterStatus` | Yes | `ModifedConflict` | `` |
| `ModifedLocal` | `ModelMasterStatus` | Yes | `ModifedLocal` | `` |
| `ModifedRemote` | `ModelMasterStatus` | Yes | `ModifedRemote` | `` |
| `RemovedLocal` | `ModelMasterStatus` | Yes | `RemovedLocal` | `` |
| `RemovedRemote` | `ModelMasterStatus` | Yes | `RemovedRemote` | `` |
| `Undefined` | `ModelMasterStatus` | Yes | `Undefined` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Undefined` | `0` |
| `Error` | `1` |
| `Equality` | `2` |
| `ModifedLocal` | `3` |
| `ModifedRemote` | `4` |
| `ModifedConflict` | `5` |
| `AddedLocal` | `6` |
| `AddedRemote` | `7` |
| `RemovedLocal` | `8` |
| `RemovedRemote` | `9` |
| `MasterOnly` | `10` |

**Underlying Type**: `System.Int32`

### `ModelProject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ModelProject` |
| **Base Type** | `Topomatic.ApplicationPlatform.Project` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `Topomatic.ApplicationPlatform.Project`
      - `Topomatic.ApplicationPlatform.Core.ModelProject`

#### Constructors (1)

- `.ctor(String alias)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonSettings` | `Settings` | `get` | No | `` |
| `Model` | `IProjectModel` | `get` | No | `` |
| `Modified` | `Boolean` | `get/set` | No | `` |
| `TargetProjectUri` | `URI` | `get/set` | No | `` |

#### Instance Methods (24)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginCommonSettingsChanges` | `Void` | `` | `` |
| `CloseModel` | `Boolean` | `IProjectModel model` | `` |
| `CreateEditor` | `ModelEditor` | `String modelType` | `` |
| `EndCommonSettingsChanges` | `Void` | `` | `` |
| `FindModelType` | `String` | `URI uri` | `` |
| `FindOpenedModel` | `IEditorResult` | `IProjectModel model` | `` |
| `GetCommonModelAttributes` | `Attributes` | `URI uri, String task` | `` |
| `GetLinkedFiles` | `IEnumerable<FileEntry>` | `` | `` |
| `GetModelId` | `String` | `URI uri, Boolean create` | `` |
| `GetModelId` | `String` | `URI uri` | `` |
| `GetModelIds` | `IEnumerable<KeyValuePair<String IProjectModel>>` | `` | `` |
| `GetModelStatus` | `ModelMasterStatus` | `IProjectModel model` | `` |
| `GetModelTemplate` | `Object` | `String modelType` | `` |
| `GetOpenedModels` | `IEnumerable<KeyValuePair<IProjectModel IEditorResult>>` | `` | `` |
| `GetUserModelAttributes` | `Attributes` | `URI uri, String task` | `` |
| `IsModelOpened` | `Boolean` | `IProjectModel model` | `` |
| `LoadModelFromFile` | `Object` | `IProjectModel model, ModelEditor editor, String fullpath, ref Boolean readOnly` | `` |
| `OpenModel` | `IEditorResult` | `IProjectModel model` | `` |
| `Save` | `Boolean` | `` | `` |
| `SaveCommonModelTemplate` | `Void` | `String modelType, Object template` | `` |
| `SaveRequest` | `DialogResult` | `` | `` |
| `SetCommonModelAttributes` | `Void` | `URI uri, String task, Attributes attrs` | `` |
| `SetUserModelAttributes` | `Void` | `URI uri, String task, Attributes attrs` | `` |
| `UpdateModelsMasterStatus` | `Void` | `Action callback` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModelSoftReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ModelSoftReference` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(URI uri)`
- `.ctor(URI uri, String modelType)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ModelType` | `String` | `get/set` | No | `` |
| `Uri` | `URI` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `ModelState` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ProjectStateConfiguration+ModelState` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get/set` | No | `` |
| `Layers` | `IList<LayerState>` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

### `PlanModelEditor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.PlanModelEditor` |
| **Base Type** | `Topomatic.ApplicationPlatform.Core.ModelEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.PlanModelEditor`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Activate` | `Boolean` | `IProjectModel model` | `` |
| `Open` | `IEditorResult` | `IProjectModel model` | `` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindActiveLayer` | `CadViewLayer` | `Boolean useReadOnly` | `` |
| `FindActiveModel` | `IProjectModel` | `ModelProject project, ref Boolean readOnly` | `` |
| `FindActiveModel` | `IProjectModel` | `ref Boolean readOnly` | `` |
| `FindOpenedPlanLayers` | `IEnumerable<KeyValuePair<CadViewLayer IProjectModel>>` | `` | `` |
| `FindOpenedPlanLayers` | `IEnumerable<KeyValuePair<CadViewLayer IProjectModel>>` | `ModelProject project` | `` |
| `FindPlanLayer` | `CadViewLayer` | `Predicate<CadViewLayer> layerComparer` | `` |
| `FindPlanLayers` | `IEnumerable<CadViewLayer>` | `` | `` |
| `IsModelsLayer` | `Boolean` | `CadViewLayer layer` | `` |
| `IsRootPlanLayer` | `IProjectModel` | `CadViewLayer layer` | `` |
| `SortLayers` | `Void` | `ModelProject project` | `` |

### `ProjectStateConfiguration` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ProjectStateConfiguration` |
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
| `Models` | `IList<ModelState>` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Applay` | `Void` | `ModelProject project` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromStg` | `Void` | `IStgArray marray, IDictionary<Int32 String> names` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `IStgArray marray, IDictionary<String Int32> names` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `ProjectStateConfiguration` | `ModelProject project` | `` |
| `Push` | `IDisposable` | `` | `` |
| `Push` | `IDisposable` | `ModelProject project` | `` |

#### Nested Types (2)

- `LayerState` (class)
- `ModelState` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ResourceLockedException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.ResourceLockedException` |
| **Base Type** | `System.Exception` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.ApplicationPlatform.Core.ResourceLockedException`

#### Constructors (3)

- `.ctor(String message)`
- `.ctor(String user, String computer)`
- `.ctor(String user, String computer, String ip)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Address` | `String` | `get/set` | No | `` |
| `Computer` | `String` | `get/set` | No | `` |
| `User` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ResourceLockerSynchronizationException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+ResourceLockerSynchronizationException` |
| **Base Type** | `Topomatic.ApplicationPlatform.Core.FileManager+SynchronizationException` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.ApplicationPlatform.Core.FileManager+SynchronizationException`
      - `Topomatic.ApplicationPlatform.Core.FileManager+ResourceLockerSynchronizationException`

#### Constructors (1)

- `.ctor(String uri)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Resolve` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Sha1HashCalculator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+Sha1HashCalculator` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.Core.FileManager+IHashCalculator` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FileHash` | `String` | `String lpath` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `Sha1HashCalculator` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHashCalculator` | `FileHash` |

### `SynchronizationException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Core.FileManager+SynchronizationException` |
| **Base Type** | `System.Exception` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.ApplicationPlatform.Core.FileManager+SynchronizationException`

#### Constructors (1)

- `.ctor(String lpath, IResource resource)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Resolve` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.ApplicationPlatform.Plugins`

### `cmdAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.cmdAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ApplicationPlatform.Plugins.cmdAttribute`

#### Constructors (1)

- `.ctor(String cmd)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cmd` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IPluginInitializator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `Void` | `PluginFactory factory` | `` |

### `PluginCoreOps` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.PluginCoreOps` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (39)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPermission` | `Void` | `IProjectModel model, String permission` | `` |
| `AddPermission` | `Void` | `IProjectModel model, String permission, Boolean reload` | `` |
| `AddRelatedDocument` | `Void` | `IProjectModel model, String doc` | `` |
| `CreateFolder` | `IProjectModel` | `IProjectModel folderModel, String folderName` | `` |
| `CreateFolder` | `IProjectModel` | `String[] subFolders` | `` |
| `CreateModel` | `IProjectModel` | `IProjectModel folderModel, String modelType` | `` |
| `CreateModel` | `IProjectModel` | `IProjectModel folderModel, String modelType, String prefferedName` | `` |
| `FilterModels` | `Void` | `Predicate<IProjectModel> filter` | `` |
| `FilterOpenedModels` | `Void` | `Predicate<IProjectModel> filter` | `` |
| `FindAuxiliaryModel` | `IProjectModel` | `Predicate<IProjectModel> match` | `` |
| `FindFolderModel` | `IProjectModel` | `IProjectModel model` | `` |
| `FindModel` | `IProjectModel` | `Object model` | `` |
| `FindModel` | `IProjectModel` | `String pathid` | `` |
| `FindModel` | `IProjectModel` | `URI folderUri, String relativePath` | `` |
| `FindModel` | `IProjectModel` | `ModelProject project, String pathid` | `` |
| `FindModel` | `IProjectModel` | `IProjectModel baseModel, String relativePath` | `` |
| `FindModelFromFullPath` | `IProjectModel` | `ModelProject project, URI uri` | `` |
| `FindModelFromFullPath` | `IProjectModel` | `URI uri` | `` |
| `FindModelPathId` | `String` | `IProjectModel model` | `` |
| `FindModelProjectRelativePath` | `String` | `IProjectModel model` | `` |
| `FindModelRelativePath` | `String` | `IProjectModel baseModel, IProjectModel model` | `` |
| `FindModelRelativePath` | `String[]` | `IProjectModel baseModel, IProjectModel[] models` | `` |
| `FindModels` | `IProjectModel[]` | `String modelType` | `` |
| `FindModels` | `IProjectModel[]` | `String[] modelType` | `` |
| `FindModels` | `IProjectModel[]` | `URI folderUri, String[] relativePaths` | `` |
| `FindModels` | `IProjectModel[]` | `IProjectModel baseModel, String[] relativePaths` | `` |
| `FindOpenedModels` | `IProjectModel[]` | `String modelType` | `` |
| `FindOpenedModels` | `IProjectModel[]` | `String[] modelType` | `` |
| `GetFileName` | `String` | `IProjectModel model` | `` |
| `GetRelatedDocuments` | `String` | `IProjectModel model` | `` |
| `HasPermission` | `Boolean` | `IProjectModel model, String permission` | `` |
| `IsProjectPath` | `Boolean` | `URI baseFolderPath, URI path, ref String relativePath` | `` |
| `LockReadContainer` | `T` | `IProjectModel model` | `Extension` |
| `ParseFolderTemplate` | `String[]` | `IProjectModel model, String template` | `` |
| `PathToMoniker` | `String` | `IProjectModel model, String relativePath, Boolean addGuid` | `` |
| `RemovePermission` | `Void` | `IProjectModel model, String permission` | `` |
| `RemovePermission` | `Void` | `IProjectModel model, String permission, Boolean reload` | `` |
| `RemoveRelatedDocument` | `Void` | `IProjectModel model, String doc` | `` |
| `SetRelatedDocuments` | `Void` | `IProjectModel model, String value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EDITOR_PERMISSION` | `String` | Yes | `"editor"` | `` |

### `PluginFactory` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.PluginFactory` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RegisterFunction` | `Void` | `String name, PluginFunction function` | `` |
| `RegisterLoader` | `Void` | `String extension, String func` | `` |
| `RegisterModelEditor` | `Void` | `String modelType, ModelEditorInfo info` | `` |
| `RegisterProjectSettings` | `Void` | `String id, String func` | `` |
| `RegisterTask` | `Void` | `String id, String value` | `` |
| `RegisterType` | `Void` | `String id, Type type` | `` |

### `PluginFactoryWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.PluginFactoryWrapper` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginFactory` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginFactory`
    - `Topomatic.ApplicationPlatform.Plugins.PluginFactoryWrapper`

#### Constructors (1)

- `.ctor(PluginFactory factory)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RegisterFunction` | `Void` | `String name, PluginFunction function` | `` |
| `RegisterLoader` | `Void` | `String extension, String func` | `` |
| `RegisterModelEditor` | `Void` | `String modelType, ModelEditorInfo info` | `` |
| `RegisterProjectSettings` | `Void` | `String id, String func` | `` |
| `RegisterTask` | `Void` | `String id, String value` | `` |
| `RegisterType` | `Void` | `String id, Type type` | `` |

### `PluginFunction` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.PluginFunction` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Object` | `Object[] args` | `` |

### `PluginHostInitializator` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `Void` | `PluginFactory factory` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |

### `PluginInitializator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `` |
| `SerializationKey` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ActivateWindow` | `Void` | `Func<IDocumentWindow Boolean> filter` | `` |
| `Initialize` | `Void` | `PluginFactory factory` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PluginManager` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Plugins.PluginManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Broadcast` | `Void` | `String uid, String[] registers, Object[] args` | `` |
| `Execute` | `Object` | `String uid` | `` |
| `Execute` | `Object` | `String uid, Object[] args` | `` |
| `GenerateMenu` | `Void` | `String uid, String[] registers, String[] ctx, MenuAction root` | `` |
| `GenerateMenu` | `Void` | `String uid, String[] registers, MenuAction root` | `` |
| `GetTasks` | `KeyValuePair<String String>[]` | `String uid` | `` |
| `InvokeAction` | `Void` | `String uid, String plugin` | `` |

---
## Namespace: `Topomatic.ApplicationPlatform.Remote`

### `IRemoteDrive` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Remote.IRemoteDrive` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFolder` | `Void` | `String name` | `` |
| `GetDirectories` | `String[]` | `` | `` |
| `GetFiles` | `String[]` | `` | `` |
| `Hashsum` | `Guid` | `String name` | `` |
| `Lock` | `Void` | `String name` | `` |
| `Open` | `IRemoteDrive` | `String path` | `` |
| `ReadFromRemote` | `Void` | `String name, String fullpath` | `` |
| `Unlock` | `Void` | `String name` | `` |
| `WriteToRemote` | `Void` | `String name, String fullpath` | `` |

### `UrlInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Remote.UrlInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(String url)`
- `.ctor(IProjectModel model)`
- `.ctor(UrlInfo root, String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsExists` | `Boolean` | `get` | No | `` |
| `IsFolder` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginWrite` | `String` | `` | `` |
| `EndWrite` | `Void` | `String filename` | `` |

---
## Namespace: `Topomatic.ApplicationPlatform.ServiceClasses`

### `ActiveModelReceiver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver` |
| **Base Type** | `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver`
    - `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver`

#### Constructors (2)

- `.ctor(Predicate<IProjectModel> match, Boolean readOnly)`
- `.ctor(Predicate<IProjectModel> match, Boolean readOnly, Boolean mustExists)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModelFinder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ServiceClasses.ModelFinder` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IModelFinder, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindHardReferences` | `IEnumerable<Object>` | `Object model` | `` |
| `FindModelFromPath` | `Object` | `String relativePath` | `` |
| `FindModelFromUid` | `Object` | `String modelUid` | `` |
| `FindModelType` | `String` | `Object model` | `` |
| `FindModelUid` | `String` | `Object model` | `` |
| `FindRelativePath` | `String` | `Object model` | `` |
| `ReadModelFromPath` | `T` | `String relativePath` | `` |
| `ReadModelFromUid` | `T` | `String modelUid` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IModelFinder` | `FindModelUid` |
| `IModelFinder` | `FindRelativePath` |
| `IModelFinder` | `FindModelType` |
| `IModelFinder` | `FindModelFromPath` |
| `IModelFinder` | `FindModelFromUid` |
| `IModelFinder` | `ReadModelFromPath` |
| `IModelFinder` | `ReadModelFromUid` |
| `IModelFinder` | `FindHardReferences` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ModelReceiver` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `ProjectModel` | `IProjectModel` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetFolderModel` | `IProjectModel` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `MultiplyModelsWorker` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ServiceClasses.MultiplyModelsWorker` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(IProjectModel[] lockedModels)`
- `.ctor(Object modelOwner, String[] relativePaths)`
- `.ctor(Object modelOwner, Predicate<IProjectModel> match, String[] relativePaths)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Object` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetName` | `String` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `SingletonModelReceiver` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.ServiceClasses.SingletonModelReceiver` |
| **Base Type** | `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver`
    - `Topomatic.ApplicationPlatform.ServiceClasses.SingletonModelReceiver`

#### Constructors (1)

- `.ctor(Boolean readOnly)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommitAlways` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.ApplicationPlatform.Templates`

### `FileEntry` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Templates.FileEntry` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String fullName, Boolean replaceParameters)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FullName` | `String` | `get/set` | No | `` |
| `ReplaceParameters` | `Boolean` | `get/set` | No | `` |

### `Template` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Templates.Template` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Configuration` | `Nullable<Guid>` | `get/set` | No | `` |
| `CreateNewFolder` | `Boolean` | `get/set` | No | `` |
| `DefaultName` | `String` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `EnableLocationBrowseButton` | `Boolean` | `get/set` | No | `` |
| `Hiden` | `Boolean` | `get/set` | No | `` |
| `Icon` | `Icon` | `get/set` | No | `` |
| `IconName` | `String` | `get/set` | No | `` |
| `LocationField` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `NumberOfParentCategoriesToRollUp` | `Int32` | `get/set` | No | `` |
| `ProjectFile` | `String` | `get/set` | No | `` |
| `ProjectItems` | `List<TemplateItem>` | `get` | No | `` |
| `ProjectType` | `String` | `get/set` | No | `` |
| `ProvideDefaultName` | `Boolean` | `get/set` | No | `` |
| `SortOrder` | `Int32` | `get/set` | No | `` |
| `SubtypeCategory` | `String` | `get/set` | No | `` |
| `Type` | `TemplateType` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TemplateItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Templates.TemplateItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ReplaceParameters` | `Boolean` | `get/set` | No | `` |
| `SourceFileName` | `String` | `get/set` | No | `` |
| `SubType` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TemplateType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Templates.TemplateType` |
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
      - `Topomatic.ApplicationPlatform.Templates.TemplateType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Item` | `TemplateType` | Yes | `Item` | `` |
| `Project` | `TemplateType` | Yes | `Project` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Project` | `0` |
| `Item` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.ApplicationPlatform.UserSettings`

### `AutoCreateValueAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.AutoCreateValueAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ApplicationPlatform.UserSettings.AutoCreateValueAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BooleanSettings` (class)

**Attributes**: [AutoCreateValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.BooleanSettings` |
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
| `Value` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CommitEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.CommitEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.ApplicationPlatform.UserSettings.CommitEventArgs`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShouldRestart` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetShouldRestart` | `Void` | `` | `` |

### `IUpdatableSettings` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.IUpdatableSettings` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Update` | `Void` | `` | `` |

### `IUserSettingsProvider` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

### `Settings` (class)

**Attributes**: [AutoCreateValue, DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.Settings` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IDictionary`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.ApplicationPlatform.UserSettings.IUpdatableSettings, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String text)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `Keys` | `ICollection<String>` | `get` | No | `` |
| `Text` | `String` | `get` | No | `` |
| `Values` | `ICollection<Object>` | `get` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `KeyValuePair<String Object> item` | `` |
| `Add` | `Void` | `String key, Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `KeyValuePair<String Object> item` | `` |
| `ContainsKey` | `Boolean` | `String key` | `` |
| `ContainsMissedSettings` | `Boolean` | `String key` | `` |
| `CopyTo` | `Void` | `KeyValuePair<String Object>[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String Object>>` | `` | `` |
| `LoadFromFileAsBinary` | `Void` | `String path` | `` |
| `LoadFromFileAsXml` | `Void` | `String path` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `KeyValuePair<String Object> item` | `` |
| `Remove` | `Boolean` | `String key` | `` |
| `SaveToFileAsBinary` | `Void` | `String path` | `` |
| `SaveToFileAsXml` | `Void` | `String path` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `String key, ref Object value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IDictionary`2` | `get_Item` |
| `IDictionary`2` | `set_Item` |
| `IDictionary`2` | `get_Keys` |
| `IDictionary`2` | `get_Values` |
| `IDictionary`2` | `ContainsKey` |
| `IDictionary`2` | `Add` |
| `IDictionary`2` | `Remove` |
| `IDictionary`2` | `TryGetValue` |
| `IUpdatableSettings` | `Topomatic.ApplicationPlatform.UserSettings.IUpdatableSettings.Update` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SimpleUserSettings` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.SimpleUserSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `StringSettings` (class)

**Attributes**: [AutoCreateValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.StringSettings` |
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
| `Value` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `UserSettingsPanel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel` |
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
              - `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MaximumSize` | `Size` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `MinimumSize` | `Size` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.ApplicationPlatform.Vcs`

### `IConflictResolver` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationPlatform.Vcs.IConflictResolver` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResolveConflict` | `Object` | `IProjectModel model, Object origin, Object local, Object remote, LogWriter writer` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 88 |
| **Classes** | 42 |
| **Interfaces** | 27 |
| **Enums** | 2 |
| **Structs** | 0 |
| **Abstract Classes** | 13 |
| **Static Classes** | 4 |
| **Total Methods** | 365 |
| **Total Properties** | 197 |
| **Total Fields** | 55 |
| **Total Events** | 9 |
| **Total Constructors** | 54 |
| **Nested Types** | 19 |
| **Extension Methods** | 0 |


