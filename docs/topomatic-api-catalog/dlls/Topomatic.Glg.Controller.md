# Topomatic.Glg.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Glg.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Glg.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Glg.Controller.dll` |

---
## Namespace: `Topomatic.Glg.Controller`

### `Geology3dModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Geology3dModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Glg.Controller.Geology3dModule`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `UpdateAlignment` | `Void` | `AlignmentModel model` | `cmd` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgControllerModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.GlgControllerModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Glg.Controller.GlgControllerModule`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SerializationKey` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawHint` | `Void` | `CadView cadView, CadPen pen, Vector2D pos, String text, Image icon` | `` |
| `FindOutSideContourByPosEx` | `Boolean` | `Vector2D sp, Vector2D ep, GeologyContour root, GeologyContour controlContour, IList<SegmentStruc> inputList, ref GeologyContour contour` | `` |
| `GetLineSpec` | `GetPointResult` | `CadView cadview, DrawCursorEvent dynamic_draw_common, DrawCursorEvent dynamic_draw_shifted, Nullable<Vector3D> startPoint, ref Vector3D point, ref Double shift, String message, String[] args` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GlgControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.GlgControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Glg.Controller.GlgControllerPluginHost`

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

---
## Namespace: `Topomatic.Glg.Controller.Design`

### `AreaSignWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.AreaSignWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Guid id)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `AreaSign` | `get` | No | `` |
| `Caption` | `String` | `get` | No | `` |
| `Id` | `Guid` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `BoreholeFrostLevelsTableEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.BoreholeFrostLevelsTableEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Glg.Controller.Design.BoreholeFrostLevelsTableEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `BoreholeFrostLevelsTableEditorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.BoreholeFrostLevelsTableEditorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditorAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyEditorAttribute`
      - `Topomatic.Glg.Controller.Design.BoreholeFrostLevelsTableEditorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BoreholeGuidWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.BoreholeGuidWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Borehole borehole)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | No | `` | `` |
| `Number` | `String` | No | `` | `` |

### `BoreholeWaterPlaneLevelsTableEditorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.BoreholeWaterPlaneLevelsTableEditorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditorAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyEditorAttribute`
      - `Topomatic.Glg.Controller.Design.BoreholeWaterPlaneLevelsTableEditorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CadColorSemanticDataStyleProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.CadColorSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Glg.Controller.Design.CadColorSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `ContourGroundEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.ContourGroundEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Glg.Controller.Design.ContourGroundEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `DoubleDigitsConverter` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.DoubleDigitsConverter` |
| **Base Type** | `Topomatic.ComponentModel.DoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Glg.Controller.Design.DoubleDigitsConverter`

#### Constructors (1)

- `.ctor(Nullable<Int32> digits)`

### `ElevationCalcerEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.ElevationCalcerEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Glg.Controller.Design.ElevationCalcerEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `ElevationCalcerEditorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.ElevationCalcerEditorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditorAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyEditorAttribute`
      - `Topomatic.Glg.Controller.Design.ElevationCalcerEditorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImpellerKeyEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.ImpellerKeyEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Glg.Controller.Design.ImpellerKeyEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `ImpellerKeyEditorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.ImpellerKeyEditorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditorAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyEditorAttribute`
      - `Topomatic.Glg.Controller.Design.ImpellerKeyEditorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IntColorConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.IntColorConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Glg.Controller.Design.IntColorConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `IntColorEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.IntColorEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Glg.Controller.Design.IntColorEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsDropDownResizable` | `Boolean` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |
| `GetPaintValueSupported` | `Boolean` | `IPropertyTypeDescriptorContext context` | `` |
| `GetPreferedPaintWidth` | `Int32` | `Int32 height` | `` |
| `PaintValue` | `Void` | `Rectangle bounds, Graphics g, IPropertyTypeDescriptorContext context` | `` |

### `MultiStringConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Design.MultiStringConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Glg.Controller.Design.MultiStringConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

---
## Namespace: `Topomatic.Glg.Controller.Dialogs`

### `BoreholeExtendedPropertiesDialog` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.BoreholeExtendedPropertiesDialog` |
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
                  - `Topomatic.Glg.Controller.Dialogs.BoreholeExtendedPropertiesDialog`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Borehole` | `Borehole` | `get/set` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExecuteEditable` | `Boolean` | `Borehole borehole` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BoreholeGroundExtendedPropertiesDialog` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.BoreholeGroundExtendedPropertiesDialog` |
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
                  - `Topomatic.Glg.Controller.Dialogs.BoreholeGroundExtendedPropertiesDialog`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeGround` | `BoreholeGround` | `get/set` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExecuteEditable` | `Boolean` | `BoreholeGround boreholeGround` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConnectGroundOptionsDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.ConnectGroundOptionsDlg` |
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
                - `Topomatic.Glg.Controller.Dialogs.ConnectGroundOptionsDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConsiderBeddingGroups` | `Boolean` | `get/set` | No | `` |
| `RemoveZeroGroundChangingEnabled` | `Boolean` | `get/set` | No | `` |
| `RemoveZeroGrounds` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CreateReferencesMessageDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.CreateReferencesMessageDlg` |
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
              - `Topomatic.Glg.Controller.Dialogs.CreateReferencesMessageDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Result` | `QuestionResult` | `get/set` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ShowQuestionDialog` | `QuestionResult` | `` | `` |

#### Nested Types (1)

- `QuestionResult` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EnviConePenetrationDataImportDialog` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.EnviConePenetrationDataImportDialog` |
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
              - `Topomatic.Glg.Controller.Dialogs.EnviConePenetrationDataImportDialog`

#### Constructors (1)

- `.ctor(String filePath, RawConePenetrationData[] rawTests)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DepthIndex` | `Int32` | `get` | No | `` |
| `FilePath` | `String` | `get` | No | `` |
| `FsIndex` | `Int32` | `get` | No | `` |
| `LastClickedColumnIndex` | `Int32` | `get` | No | `` |
| `QcIndex` | `Int32` | `get` | No | `` |
| `RawTests` | `RawConePenetrationData[]` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Geology3DLayerSelector` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.Geology3DLayerSelector` |
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
                - `Topomatic.Glg.Controller.Dialogs.Geology3DLayerSelector`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectedLayer` | `KeyValuePair<Ground UInt32>` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `KeyValuePair<Ground UInt32>` | `GeologyModel model` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GroundPropertiesApplyToBoreholesMessageDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.GroundPropertiesApplyToBoreholesMessageDlg` |
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
              - `Topomatic.Glg.Controller.Dialogs.GroundPropertiesApplyToBoreholesMessageDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `Ground ground, String boreholeNumber, ref Boolean forAll` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `QuestionResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Dialogs.CreateReferencesMessageDlg+QuestionResult` |
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
      - `Topomatic.Glg.Controller.Dialogs.CreateReferencesMessageDlg+QuestionResult`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cancel` | `QuestionResult` | Yes | `Cancel` | `` |
| `Copy` | `QuestionResult` | Yes | `Copy` | `` |
| `Rewrite` | `QuestionResult` | Yes | `Rewrite` | `` |
| `Skip` | `QuestionResult` | Yes | `Skip` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Rewrite` | `0` |
| `Copy` | `1` |
| `Skip` | `2` |
| `Cancel` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Glg.Controller.DwpToPatConverter`

### `DwpToPatConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.DwpToPatConverter.DwpToPatConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name, DwgEntities entities, Double screenRatio, DwgPolyline boundingLine)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Convert` | `Void` | `` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AppendToFile` | `Boolean` | Yes | `` | `` |
| `ImitationPointSegmentLength` | `Double` | Yes | `` | `` |
| `MaxPeriodicFactor` | `Int32` | Yes | `` | `` |
| `Path` | `String` | Yes | `` | `` |
| `PointsInsteadIncorrectSegments` | `Boolean` | Yes | `` | `` |
| `Tesselation` | `Int32` | Yes | `` | `` |
| `VerticalTraceStep` | `Double` | Yes | `` | `` |

### `DwpToPatConverterParamsDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.DwpToPatConverter.DwpToPatConverterParamsDlg` |
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
                - `Topomatic.Glg.Controller.DwpToPatConverter.DwpToPatConverterParamsDlg`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Controller.Geology3d`

### `GlgSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Geology3d.GlgSection` |
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
| `Execute` | `Void` | `Alignment source, Alignment destination, Boolean onlyMarked` | `` |
| `Execute` | `Void` | `Alignment source, Int32 fromSection, Int32 toSection` | `` |
| `Execute` | `Void` | `Alignment source, Alignment destination, Int32 fromSection, Int32 toSection, Boolean onlyMarked` | `` |

---
## Namespace: `Topomatic.Glg.Controller.ServiceClasses`

### `ConfidenceProbability` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.ServiceClasses.ConfidenceProbability` |
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
      - `Topomatic.Glg.Controller.ServiceClasses.ConfidenceProbability`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `a85` | `ConfidenceProbability` | Yes | `a85` | `` |
| `a90` | `ConfidenceProbability` | Yes | `a90` | `` |
| `a95` | `ConfidenceProbability` | Yes | `a95` | `` |
| `a975` | `ConfidenceProbability` | Yes | `a975` | `` |
| `a98` | `ConfidenceProbability` | Yes | `a98` | `` |
| `a99` | `ConfidenceProbability` | Yes | `a99` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `a85` | `0` |
| `a90` | `1` |
| `a95` | `2` |
| `a975` | `3` |
| `a98` | `4` |
| `a99` | `5` |

**Underlying Type**: `System.Int32`

### `LtgMap` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.ServiceClasses.LtgMap` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dictionary` | `Dictionary<String String>` | Yes | `` | `` |

### `ProbesSectHelper` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.ServiceClasses.ProbesSectHelper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ProbeInSegment` | `Boolean` | `LabTable labTable, Int32 index, Double c, Double d` | `` |
| `ProbeInSegmentEx` | `Boolean` | `String depthStr, String depthEndStr, Double c, Double d` | `` |
| `ProbeTouchSegmentsList` | `Boolean` | `LabTable labTable, Int32 index, IList<KeyValuePair<Double Double>> list` | `` |
| `ProbeTouchSegmentsListEx` | `Boolean` | `String depthStr, String depthEndStr, IList<KeyValuePair<Double Double>> list` | `` |

### `RawConePenetrationData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.ServiceClasses.RawConePenetrationData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Date` | `String` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `Values` | `String[]` | `get/set` | No | `` |

---
## Namespace: `Topomatic.Glg.Controller.Settings`

### `CommonScalesEnvironmentSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Settings.CommonScalesEnvironmentSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DepthScaleCpt` | `Double` | `get/set` | No | `` |
| `DepthScaleIt` | `Double` | `get/set` | No | `` |
| `FsScale` | `Double` | `get/set` | No | `` |
| `QcScale` | `Double` | `get/set` | No | `` |
| `QsScale` | `Double` | `get/set` | No | `` |
| `RfScale` | `Double` | `get/set` | No | `` |
| `TScale` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Instance` | `CommonScalesEnvironmentSettings` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GlgTestPrefixesEnvironmentSettingsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Settings.GlgTestPrefixesEnvironmentSettingsFrame` |
| **Base Type** | `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel` |
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
                - `Topomatic.Glg.Controller.Settings.GlgTestPrefixesEnvironmentSettingsFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Controller.Sheets`

### `GlgLocalConePenetrationTestSheetFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Sheets.GlgLocalConePenetrationTestSheetFrame` |
| **Base Type** | `Topomatic.Tables.Export.UserSheetWizardFrame` |
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
              - `Topomatic.Tables.Export.UserSheetWizardFrame`
                - `Topomatic.Glg.Controller.Sheets.GlgLocalConePenetrationTestSheetFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Boolean` | `UserSheet sheet` | `` |
| `OnInitialize` | `Void` | `UserSheet sheet` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TablesImpService` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Sheets.TablesImpService` |
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
| `ImportData` | `TablesDocument` | `String path` | `` |

---
## Namespace: `Topomatic.Glg.Controller.Wrappers`

### `AssayRecordWrappersCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.AssayRecordWrappersCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, Topomatic.ComponentModel.IActivator, Topomatic.Glg.ILabTableContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(LabTable table, Func<List<KeyValuePair<Double Double>>> getDepthsForSelectedGroundsInGrid)`
- `.ctor(LabTable table, IEnumerable<Int32> filterIndexes, Func<List<KeyValuePair<Double Double>>> getDepthsForSelectedGroundsInGrid)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `LabTable` | `LabTable` | `get` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object item` | `` |
| `Clear` | `Void` | `` | `` |
| `Commit` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object item` | `` |
| `OnChanged` | `Void` | `` | `` |
| `Remove` | `Void` | `Object item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ILabTableContainer` | `get_LabTable` |

### `BoreholeFrostLevelsTableWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.BoreholeFrostLevelsTableWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Glg.Controller.Wrappers.BoreholeFrostLevelsTableWrapper`

#### Constructors (1)

- `.ctor(BoreholeFrostLevelsTable frostLevelTable, Boolean readOnly)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `DTRowWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.DTRowWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DTRowWrappersCollection parent, Int32 index)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get/set` | No | `Browsable` |
| `Table` | `DataTable` | `get` | No | `PropertyProvider` |

### `DTRowWrappersCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.DTRowWrappersCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DataTable table)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |
| `Table` | `DataTable` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object item` | `` |
| `Remove` | `Void` | `Object item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `GroundParameterColumnWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.GroundParameterColumnWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(TreeNode node, GroundParameterColumn column)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Category` | `String` | `get` | No | `` |
| `ColumnRef` | `String` | `get/set` | No | `` |
| `Format` | `String` | `get/set` | No | `` |
| `Formula` | `String` | `get/set` | No | `` |
| `Identifier` | `String` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `ParameterColumn` | `GroundParameterColumn` | `get` | No | `Browsable` |
| `SummaryFormat` | `String` | `get/set` | No | `` |
| `SummaryFormula` | `String` | `get/set` | No | `` |
| `Visibility` | `Boolean` | `get/set` | No | `` |

### `RowWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.RowWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(RowWrappersCollection parent, Int32 index)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get/set` | No | `Browsable` |
| `Table` | `Table` | `get` | No | `PropertyProvider` |

### `RowWrappersCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.RowWrappersCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Table table)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |
| `Table` | `Table` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object item` | `` |
| `Remove` | `Void` | `Object item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `SmdxGroundWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Controller.Wrappers.SmdxGroundWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Ground ground, GroundParamsEqualityChecker paramChecker)`
- `.ctor(GroundReference groundReference, GroundParamsEqualityChecker paramChecker)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `AreaSignWrapper` | `get/set` | No | `` |
| `AreaSignEx` | `AreaSignWrapper` | `get/set` | No | `` |
| `AreaSignExScale` | `Double` | `get/set` | No | `DefaultDouble` |
| `AreaSignScale` | `Double` | `get/set` | No | `DefaultDouble` |
| `Ground` | `UpdatableTypedObjectWrapper` | `get` | No | `TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |
| `GroundColor` | `CadColor` | `get/set` | No | `ByBlock, ByLayer` |
| `HatchExScale` | `CadColor` | `get/set` | No | `ByLayer, ByBlock` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 45 |
| **Classes** | 41 |
| **Interfaces** | 0 |
| **Enums** | 2 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 2 |
| **Total Methods** | 87 |
| **Total Properties** | 76 |
| **Total Fields** | 23 |
| **Total Events** | 1 |
| **Total Constructors** | 42 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


