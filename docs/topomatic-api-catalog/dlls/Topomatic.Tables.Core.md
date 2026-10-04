# Topomatic.Tables.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Tables.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Tables.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Tables.Core.dll` |

---
## Namespace: `Topomatic.Cad.View.Hints`

### `InsertTableCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.InsertTableCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.InsertTableCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleHint` | `AngleHint` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAngle` | `GetPointResult` | `DwgTable dwgTable, ref Double angle` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

---
## Namespace: `Topomatic.Dwg.Layer`

### `DwgTableController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgTableController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgTableController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

---
## Namespace: `Topomatic.Tables.Core`

### `DwpEditorControl` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwpEditorControl` |
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
              - `Topomatic.Tables.Core.DwpEditorControl`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `DwgTable` | `get` | No | `` |
| `SelectedTable` | `DwgTable` | `get` | No | `` |
| `SheetsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyUserSettings` | `Void` | `DwpEditorUserSettings userSettings` | `` |
| `AutoScale` | `Void` | `` | `` |
| `Changed` | `Void` | `Object sender, EventArgs e` | `` |
| `GetScaleForSheet` | `Single` | `Int32 index` | `` |
| `GetUserSettings` | `DwpEditorUserSettings` | `` | `` |
| `RefreshPropertyInspector` | `Void` | `` | `` |
| `SaveTemplates` | `Void` | `` | `` |
| `SetData` | `Void` | `IEnumerable<DwgTable> dwgTables, Boolean readOnly` | `` |
| `Undo` | `Void` | `Object sender, EventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwpEditorUserSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwpEditorUserSettings` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSetting` | `Void` | `SheetEditorUserSettings sheetEditorUserSettings` | `` |
| `GetSetting` | `SheetEditorUserSettings` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_SelectedTable` | `Int32` | No | `` | `` |

### `DwpTemplateEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwpTemplateEditor` |
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
              - `Topomatic.Tables.Core.DwpTemplateEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ColumnTemplates` | `ColumnContextTemplate[]` | `get` | No | `` |
| `ContextFunctionsList` | `ContextFunctionsList` | `set` | No | `` |
| `ContextTagList` | `ContextTagList` | `set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTemplates` | `Void` | `List<TemplateSheetWrapper> templates, ColumnContextTemplate[] columnTemplates, Drawing srcDrawing` | `` |
| `GetTemplate` | `Void` | `Int32 n, ref String id, ref String name, ref Table subTable, ref Boolean included, ref Boolean breaking, ref String[] breakingExcludes` | `` |

#### Nested Types (1)

- `TemplateSheetWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwpTemplateSheetEditorFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwpTemplateSheetEditorFrame` |
| **Base Type** | `Topomatic.Tables.Core.SheetEditor.SheetEditorFrame` |
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
              - `Topomatic.Tables.Core.SheetEditor.SheetEditorFrame`
                - `Topomatic.Tables.Core.DwpTemplateSheetEditorFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ToolBarHeight` | `Int32` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ISheetEditorExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.ISheetEditorExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Merged` | `Boolean` | `ISheetEditorCell cell` | `Extension` |
| `MergedColumns` | `Int32` | `ISheetEditorCell cell` | `Extension` |
| `MergedRows` | `Int32` | `ISheetEditorCell cell` | `Extension` |

### `ShtExporter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.ShtExporter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExportWithDialog` | `Boolean` | `Drawing drawing, StgDocumentOperationEventHandler additionalSettings, Boolean useDrawingExportProviders, ref String defaultFilename` | `` |

### `TablesCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.TablesCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Tables.Core.TablesCorePluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `Void` | `PluginFactory factory` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |

### `TemplateSheetWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwpTemplateEditor+TemplateSheetWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String id, String name, Table table, Boolean included, Boolean breakBefore, String[] breakingExcludes)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BreakBefore` | `Boolean` | `get` | No | `` |
| `BreakingExcludes` | `String[]` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Included` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Table` | `Table` | `get` | No | `` |

---
## Namespace: `Topomatic.Tables.Core.CreationWizard`

### `CSVParamsWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.CreationWizard.CSVParamsWizardFrame` |
| **Base Type** | `Topomatic.Controls.Dialogs.WizardFrame` |
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
                - `Topomatic.Tables.Core.CreationWizard.CSVParamsWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ParamsWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.CreationWizard.ParamsWizardFrame` |
| **Base Type** | `Topomatic.Controls.Dialogs.WizardFrame` |
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
                - `Topomatic.Tables.Core.CreationWizard.ParamsWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PreViewWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.CreationWizard.PreViewWizardFrame` |
| **Base Type** | `Topomatic.Controls.Dialogs.WizardFrame` |
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
                - `Topomatic.Tables.Core.CreationWizard.PreViewWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectListWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.CreationWizard.SelectListWizardFrame` |
| **Base Type** | `Topomatic.Controls.Dialogs.WizardFrame` |
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
                - `Topomatic.Tables.Core.CreationWizard.SelectListWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Tables.Core.Design`

### `DwgTableCellsMergeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.Design.DwgTableCellsMergeType` |
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
      - `Topomatic.Tables.Core.Design.DwgTableCellsMergeType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `DwgTableCellsMergeType` | Yes | `All` | `` |
| `ByColumns` | `DwgTableCellsMergeType` | Yes | `ByColumns` | `` |
| `ByRows` | `DwgTableCellsMergeType` | Yes | `ByRows` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ByRows` | `0` |
| `ByColumns` | `1` |
| `All` | `2` |

**Underlying Type**: `System.Int32`

### `DwgTableCellsMergeTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.Design.DwgTableCellsMergeTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Tables.Core.Design.DwgTableCellsMergeTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DwgTableFillColorWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.Design.DwgTableFillColorWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object value)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `DifferrentColors` | `Boolean` | `get` | No | `` |
| `Selector` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `MathOperatorEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.Design.MathOperatorEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Tables.Core.Design.MathOperatorEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Tables.Core.DwgTableControls`

### `DwgTableFormatDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwgTableControls.DwgTableFormatDlg` |
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
              - `Topomatic.Tables.Core.DwgTableControls.DwgTableFormatDlg`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(DwgTableInputControl dwgTableInputControl)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetButtonsBySelectionArea` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DistanceToTable` | `Int32` | Yes | `10` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwgTableInputControl` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwgTableControls.DwgTableInputControl` |
| **Base Type** | `Topomatic.Cad.View.CadControl` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Tables.Core.DwgTableControls.DwgTableInputControl`

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowEditLinkData` | `Boolean` | `get` | No | `` |
| `AllowLinkCellData` | `Boolean` | `get` | No | `` |
| `AllowLoadFromSource` | `Boolean` | `get` | No | `` |
| `AllowMathOperation` | `Boolean` | `get` | No | `` |
| `AttachmentPoint` | `AttachmentPoint` | `get/set` | No | `` |
| `CadFocused` | `Boolean` | `get` | No | `` |
| `CanModal` | `Boolean` | `get` | No | `` |
| `Changed` | `Boolean` | `get` | No | `` |
| `Dlg` | `DwgTableFormatDlg` | `get` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `RulerVisible` | `Boolean` | `get/set` | Yes | `` |
| `SelectedDwgTable` | `DwgTable` | `get/set` | No | `` |
| `SlctArea` | `SelectionArea` | `get` | No | `` |
| `UserHeight` | `Double` | `get/set` | No | `` |
| `UserWidth` | `Double` | `get/set` | No | `` |

#### Instance Methods (28)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Accept` | `Void` | `` | `` |
| `AllowChangeCellsCount` | `Boolean` | `` | `` |
| `AllowColumnInsertLeft` | `Boolean` | `` | `` |
| `AllowColumnInsertRight` | `Boolean` | `` | `` |
| `AllowColumnsRemove` | `Boolean` | `` | `` |
| `AllowMerge` | `Boolean` | `` | `` |
| `AllowRowInsertBottom` | `Boolean` | `` | `` |
| `AllowRowInsertTop` | `Boolean` | `` | `` |
| `AllowRowsRemove` | `Boolean` | `` | `` |
| `AllowUnmerge` | `Boolean` | `` | `` |
| `Cancel` | `Void` | `` | `` |
| `ColumnInsertLeft` | `Void` | `` | `` |
| `ColumnInsertRight` | `Void` | `` | `` |
| `ColumnsRemove` | `Void` | `` | `` |
| `DataLink` | `Void` | `` | `` |
| `DataLinkEdit` | `Void` | `` | `` |
| `DataLinkRefreshData` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `MathOperation` | `Void` | `MathOperator mathOperator` | `` |
| `Merge` | `Void` | `` | `` |
| `MergeByColumns` | `Void` | `` | `` |
| `MergeByRows` | `Void` | `` | `` |
| `RefreshCadView` | `Void` | `` | `` |
| `RefreshPropertyInspector` | `Void` | `` | `` |
| `RowInsertBottom` | `Void` | `` | `` |
| `RowInsertTop` | `Void` | `` | `` |
| `RowsRemove` | `Void` | `` | `` |
| `UnMerge` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ColumnNumberToString` | `String` | `Int32 columnNumber` | `` |

#### Nested Types (2)

- `MenuItem` (struct)
- `SelectionArea` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `MenuItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwgTableControls.DwgTableInputControl+MenuItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Tables.Core.DwgTableControls.DwgTableInputControl+MenuItem`

#### Constructors (2)

- `.ctor(String text, Object tag)`
- `.ctor(String text, Object tag, Image image)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Contains` | `Boolean` | `String value` | `` |
| `Sort` | `Void` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Children` | `List<MenuItem>` | No | `` | `` |
| `m_Image` | `Image` | No | `` | `` |
| `m_Tag` | `Object` | No | `` | `` |
| `m_Text` | `String` | No | `` | `` |

### `SelectionArea` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwgTableControls.DwgTableInputControl+SelectionArea` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Heigth` | `Int32` | `get` | No | `` |
| `Width` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsEmpty` | `Boolean` | `` | `` |
| `Reset` | `Void` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X1` | `Int32` | No | `` | `` |
| `X2` | `Int32` | No | `` | `` |
| `Y1` | `Int32` | No | `` | `` |
| `Y2` | `Int32` | No | `` | `` |

---
## Namespace: `Topomatic.Tables.Core.DwgTableStyleControls`

### `DwgTableRowStyleEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.DwgTableStyleControls.DwgTableRowStyleEnum` |
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
      - `Topomatic.Tables.Core.DwgTableStyleControls.DwgTableRowStyleEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByRowAndColumn` | `DwgTableRowStyleEnum` | Yes | `ByRowAndColumn` | `` |
| `Data` | `DwgTableRowStyleEnum` | Yes | `Data` | `` |
| `Header` | `DwgTableRowStyleEnum` | Yes | `Header` | `` |
| `Title` | `DwgTableRowStyleEnum` | Yes | `Title` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Title` | `0` |
| `Header` | `1` |
| `Data` | `2` |
| `ByRowAndColumn` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Tables.Core.SheetEditor`

### `Changed` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorCellStyleExtended+Changed` |
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
      - `Topomatic.Tables.Core.SheetEditor.SheetEditorCellStyleExtended+Changed`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `Changed` | Yes | `All` | `` |
| `Bottom` | `Changed` | Yes | `Bottom` | `` |
| `Hor` | `Changed` | Yes | `Hor` | `` |
| `In` | `Changed` | Yes | `In` | `` |
| `Left` | `Changed` | Yes | `Left` | `` |
| `None` | `Changed` | Yes | `None` | `` |
| `Out` | `Changed` | Yes | `Out` | `` |
| `Right` | `Changed` | Yes | `Right` | `` |
| `Top` | `Changed` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Vert` | `Changed` | Yes | `Vert` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Top` | `1` |
| `Bottom` | `2` |
| `Left` | `4` |
| `Right` | `8` |
| `Out` | `15` |
| `Hor` | `16` |
| `Vert` | `32` |
| `In` | `48` |
| `All` | `63` |

**Underlying Type**: `System.Int32`

### `DwpSheetEditorFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.DwpSheetEditorFrame` |
| **Base Type** | `Topomatic.Tables.Core.SheetEditor.SheetEditorFrame` |
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
              - `Topomatic.Tables.Core.SheetEditor.SheetEditorFrame`
                - `Topomatic.Tables.Core.SheetEditor.DwpSheetEditorFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectionArea` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditor+SelectionArea` |
| **Base Type** | `Topomatic.Tables.Area` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Area`
    - `Topomatic.Tables.Core.SheetEditor.SheetEditor+SelectionArea`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FullColumns` | `Boolean` | `get/set` | No | `` |
| `FullRows` | `Boolean` | `get/set` | No | `` |
| `Heigth` | `Int32` | `get` | No | `` |
| `Width` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsEmpty` | `Boolean` | `` | `` |
| `Reset` | `Void` | `` | `` |

### `SheetEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditor` |
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
              - `Topomatic.Tables.Core.SheetEditor.SheetEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoScaling` | `Boolean` | `get/set` | No | `` |
| `ColumnInsertionLeftAllowed` | `Boolean` | `get` | No | `` |
| `ColumnInsertionRightAllowed` | `Boolean` | `get` | No | `` |
| `ColumnRemovingAllowed` | `Boolean` | `get` | No | `` |
| `ColumnsCount` | `Int32` | `get` | No | `` |
| `FirstColumn` | `Int32` | `get/set` | No | `Browsable` |
| `FirstRow` | `Int32` | `get/set` | No | `Browsable` |
| `LastColumn` | `Int32` | `get` | No | `Browsable` |
| `LastRow` | `Int32` | `get` | No | `Browsable` |
| `MergeAllowed` | `Boolean` | `get` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `RowInsertionBottomAllowed` | `Boolean` | `get` | No | `` |
| `RowInsertionTopAllowed` | `Boolean` | `get` | No | `` |
| `RowRemovingAllowed` | `Boolean` | `get` | No | `` |
| `RowsCount` | `Int32` | `get` | No | `` |
| `Scale` | `Single` | `get/set` | No | `` |
| `SelectOperandsMode` | `Boolean` | `get` | No | `` |
| `SlctArea` | `SelectionArea` | `get` | No | `Browsable` |
| `Table` | `ISheetEditorModel` | `get/set` | No | `` |
| `TableAreaHeight` | `Single` | `get` | No | `Browsable` |
| `TableAreaWidth` | `Single` | `get` | No | `Browsable` |
| `TableHeight` | `Single` | `get` | No | `Browsable` |
| `TableWidth` | `Single` | `get` | No | `Browsable` |
| `UnmergeAllowed` | `Boolean` | `get` | No | `` |

#### Instance Methods (102)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyUserSettings` | `Void` | `SheetEditorUserSettings userSettings` | `` |
| `AutoScale` | `Void` | `` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `ColumnInsert` | `Void` | `Int32 columnIndex` | `` |
| `ColumnInsertLeft` | `Void` | `` | `` |
| `ColumnInsertRight` | `Void` | `` | `` |
| `ColumnsRemove` | `Void` | `` | `` |
| `EditBorders` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetBold` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2` | `` |
| `GetBold` | `Boolean` | `` | `` |
| `GetCellHeight` | `Single` | `Int32 rowIndex, Int32 columnIndex` | `` |
| `GetCellHeight` | `Boolean` | `ref Double cellHeight` | `` |
| `GetCellHeight` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double height` | `` |
| `GetCellWidth` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double width` | `` |
| `GetCellWidth` | `Single` | `Int32 rowIndex, Int32 columnIndex` | `` |
| `GetCellWidth` | `Boolean` | `ref Double cellWidth` | `` |
| `GetColumnAutoWidth` | `Boolean` | `Int32 columnIndex` | `` |
| `GetColumnByX` | `Int32` | `Single x` | `` |
| `GetColumnOffset` | `Single` | `Int32 columnIndex` | `` |
| `GetColumnPosition` | `Single` | `Int32 columnIndex` | `` |
| `GetColumnWidth` | `Single` | `Int32 columnIndex` | `` |
| `GetContent` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref String value` | `` |
| `GetContent` | `Boolean` | `ref String content` | `` |
| `GetFillColor` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref CadColor fillColor` | `` |
| `GetFillColor` | `Boolean` | `ref CadColor fillColor` | `` |
| `GetHorizontalField` | `Boolean` | `ref Double horField` | `` |
| `GetHorizontalField` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double field` | `` |
| `GetItalic` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2` | `` |
| `GetItalic` | `Boolean` | `` | `` |
| `GetPreferableDisplayStyle` | `Boolean` | `ref TableCellPreferableDisplayStyle preferableDisplayStyle` | `` |
| `GetPreferableDisplayStyle` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref TableCellPreferableDisplayStyle preferableDisplayStyle` | `` |
| `GetPreferableDisplayStyleDigits` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Int32 preferableDisplayStyleDigits` | `` |
| `GetPreferableDisplayStyleDigits` | `Boolean` | `ref Int32 preferableDisplayStyleDigits` | `` |
| `GetRealCellHeight` | `Boolean` | `ref Double cellHeight` | `` |
| `GetRowAutoHeight` | `Boolean` | `Int32 rowIndex` | `` |
| `GetRowByY` | `Int32` | `Single y` | `` |
| `GetRowHeight` | `Single` | `Int32 rowIndex` | `` |
| `GetRowOffset` | `Single` | `Int32 rowIndex` | `` |
| `GetRowPosition` | `Int32` | `Int32 rowIndex` | `` |
| `GetTextAngle` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double textAngle` | `` |
| `GetTextAngle` | `Boolean` | `ref Double textAngle` | `` |
| `GetTextColor` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref CadColor textColor` | `` |
| `GetTextColor` | `Boolean` | `ref CadColor textColor` | `` |
| `GetTextHeight` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double textHeight` | `` |
| `GetTextHeight` | `Boolean` | `ref Double textHeight` | `` |
| `GetTextJustify` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref TextJustify textJustify` | `` |
| `GetTextJustify` | `Boolean` | `ref TextJustify textJustify` | `` |
| `GetTextStyleName` | `Boolean` | `ref String textStyleName` | `` |
| `GetTextStyleName` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref String textStyleName` | `` |
| `GetUserSettings` | `SheetEditorUserSettings` | `` | `` |
| `GetVerticalField` | `Boolean` | `ref Double vertField` | `` |
| `GetVerticalField` | `Boolean` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, ref Double field` | `` |
| `IsExistedCell` | `Boolean` | `Int32 rowIndex, Int32 columnIndex` | `` |
| `MathOperation` | `Void` | `MathOperator mathOperator` | `` |
| `MergeCells` | `Void` | `` | `` |
| `MergeCellsByColumns` | `Void` | `` | `` |
| `MergeCellsByRows` | `Void` | `` | `` |
| `Modified` | `Void` | `` | `` |
| `RowInsert` | `Void` | `Int32 rowIndex` | `` |
| `RowInsertBottom` | `Void` | `` | `` |
| `RowInsertTop` | `Void` | `` | `` |
| `RowRemoveAt` | `Void` | `Int32 rowIndex` | `` |
| `RowsRemove` | `Void` | `` | `` |
| `SetBold` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Boolean value` | `` |
| `SetBold` | `Void` | `Boolean value` | `` |
| `SetBorderStyles` | `Void` | `SheetEditorCellStyleExtended rowStyle, Int32 Y1, Int32 X1, Int32 Y2, Int32 X2` | `` |
| `SetCellHeight` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Double height` | `` |
| `SetCellHeight` | `Void` | `Double height` | `` |
| `SetCellWidth` | `Void` | `Double width` | `` |
| `SetCellWidth` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Double width` | `` |
| `SetColumnAutoWidth` | `Void` | `Int32 columnIndex, Boolean value` | `` |
| `SetColumnWidth` | `Void` | `Int32 columnIndex, Single value` | `` |
| `SetContent` | `Void` | `String content` | `` |
| `SetContent` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, String content` | `` |
| `SetFillColor` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, CadColor color` | `` |
| `SetFillColor` | `Void` | `CadColor color` | `` |
| `SetFloatDisplayStyleDigits` | `Void` | `Int32 digits` | `` |
| `SetFloatDisplayStyleDigits` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Int32 digits` | `` |
| `SetHorizontalField` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Double horField` | `` |
| `SetHorizontalField` | `Void` | `Double value` | `` |
| `SetItalic` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Boolean value` | `` |
| `SetItalic` | `Void` | `Boolean value` | `` |
| `SetPreferableDisplayStyle` | `Void` | `TableCellPreferableDisplayStyle preferableDisplayStyle` | `` |
| `SetPreferableDisplayStyle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, TableCellPreferableDisplayStyle preferableDisplayStyle` | `` |
| `SetRowAutoHeight` | `Void` | `Int32 rowIndex, Boolean value` | `` |
| `SetRowHeight` | `Void` | `Int32 rowIndex, Single value` | `` |
| `SetTextAngle` | `Void` | `Double textAngle` | `` |
| `SetTextAngle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Double textAngle` | `` |
| `SetTextColor` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, CadColor color` | `` |
| `SetTextColor` | `Void` | `CadColor color` | `` |
| `SetTextHeight` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Double height` | `` |
| `SetTextHeight` | `Void` | `Double height` | `` |
| `SetTextJustify` | `Void` | `TextJustify textJustify` | `` |
| `SetTextJustify` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, TextJustify textJustify` | `` |
| `SetTextStyle` | `Void` | `String textStyle` | `` |
| `SetTextStyle` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, String textStyle` | `` |
| `SetVerticalField` | `Void` | `Double value` | `` |
| `SetVerticalField` | `Void` | `Int32 rowIndex1, Int32 rowIndex2, Int32 columnIndex1, Int32 columnIndex2, Double vertField` | `` |
| `UnmergeByColumns` | `Void` | `` | `` |
| `UnmergeByRows` | `Void` | `` | `` |
| `UnmergeCells` | `Void` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MaxColumnsCount` | `Int32` | Yes | `16384` | `` |
| `MaxRowsCount` | `Int32` | Yes | `2097152` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |
| `RefreshPropertyInspector` | `EventHandler<SheetEditorPropertyRefreshEventArgs>` | No | `` |

#### Nested Types (1)

- `SelectionArea` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SheetEditorBordersLineweightWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorBordersLineweightWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(String value)`
- `.ctor(SheetEditorLineweight lineweight)`
- `.ctor(SheetEditorCellStyleExtended rowStyle)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Lineweight` | `SheetEditorLineweight` | `get` | No | `` |
| `Style` | `SheetEditorCellStyleExtended` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `SheetEditorBordersWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorBordersWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(String value)`
- `.ctor(CadColor color)`
- `.ctor(SheetEditorCellStyleExtended rowStyle)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `Style` | `SheetEditorCellStyleExtended` | `get` | No | `` |
| `Value` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `SheetEditorCellStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorCellStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Tables.ISheetEditorCellStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

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
| `ISheetEditorCellStyle` | `get_BorderStyleTop` |
| `ISheetEditorCellStyle` | `get_BorderStyleBottom` |
| `ISheetEditorCellStyle` | `get_BorderStyleLeft` |
| `ISheetEditorCellStyle` | `get_BorderStyleRight` |

### `SheetEditorCellStyleExtended` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorCellStyleExtended` |
| **Base Type** | `Topomatic.Tables.Core.SheetEditor.SheetEditorCellStyle` |
| **Implements** | `Topomatic.Tables.ISheetEditorCellStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Core.SheetEditor.SheetEditorCellStyle`
    - `Topomatic.Tables.Core.SheetEditor.SheetEditorCellStyleExtended`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderStyleHorizontalInside` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `BorderStyleVerticalInside` | `ISheetEditorCellBorderStyle` | `get` | No | `` |
| `ChangedFlags` | `Changed` | `get/set` | No | `` |

#### Nested Types (1)

- `Changed` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SheetEditorFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorFrame` |
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
              - `Topomatic.Tables.Core.SheetEditor.SheetEditorFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsRefreshing` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `tsmAlignment_CheckedChanged` | `Void` | `Object sender, EventArgs e` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `toolStrip` | `ToolStrip` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SheetEditorPropertyRefreshEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorPropertyRefreshEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Tables.Core.SheetEditor.SheetEditorPropertyRefreshEventArgs`

#### Constructors (1)

- `.ctor(SheetEditorSelectedBlock block)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Block` | `SheetEditorSelectedBlock` | `get` | No | `` |

### `SheetEditorSelectedBlock` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorSelectedBlock` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SheetEditor dwgTableInputControl)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderLineweight` | `SheetEditorBordersLineweightWrapper` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `BordersColor` | `SheetEditorBordersWrapper` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `CellHeight` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `CellWidth` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `Content` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `FillColor` | `DwgTableFillColorWrapper` | `get/set` | No | `PropertyEditor, PropertyUpdateSequence` |
| `FloatDisplayStyleDigits` | `String` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `HorizontalField` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `PreferableDisplayStyle` | `String` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `TextAngle` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `TextColor` | `DwgTableFillColorWrapper` | `get/set` | No | `PropertyEditor, PropertyUpdateSequence` |
| `TextHeight` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `TextJustify` | `String` | `get/set` | No | `PropertyEditor, PropertyUpdateSequence` |
| `VerticalField` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `X1` | `Int32` | `get/set` | No | `Browsable` |
| `X2` | `Int32` | `get/set` | No | `Browsable` |
| `Y1` | `Int32` | `get/set` | No | `Browsable` |
| `Y2` | `Int32` | `get/set` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `SheetEditorUserSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.SheetEditorUserSettings` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Scale` | `Single` | No | `` | `` |
| `m_X` | `Int32` | No | `` | `` |
| `m_Y` | `Int32` | No | `` | `` |

### `TablePaintArea` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.TablePaintArea` |
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
            - `Topomatic.Tables.Core.SheetEditor.TablePaintArea`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `KeyPressed` | `KeyPressEventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Thumb` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Tables.Core.SheetEditor.Thumb` |
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
            - `Topomatic.Tables.Core.SheetEditor.Thumb`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 37 |
| **Classes** | 30 |
| **Interfaces** | 0 |
| **Enums** | 3 |
| **Structs** | 1 |
| **Abstract Classes** | 1 |
| **Static Classes** | 2 |
| **Total Methods** | 176 |
| **Total Properties** | 108 |
| **Total Fields** | 36 |
| **Total Events** | 3 |
| **Total Constructors** | 38 |
| **Nested Types** | 5 |
| **Extension Methods** | 0 |


