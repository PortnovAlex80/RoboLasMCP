# Topomatic.Plt

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Plt` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Plt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Plt.dll` |

---
## Namespace: `Topomatic.Plt`

### `DictionaryExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.DictionaryExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyFrom` | `Void` | `DwgDictionary dst, DynamicDictionary src` | `Extension` |
| `CopyFrom` | `Void` | `DwgDictionary dst, DynamicList src` | `Extension` |
| `CopyFrom` | `Void` | `DynamicDictionary dst, DwgDictionary src` | `Extension` |
| `CopyFrom` | `Void` | `DynamicList dst, DwgDictionary src` | `Extension` |

### `DwgGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.DwgGenerator` |
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
| `Drawing` | `Drawing` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateDrawing` | `Boolean` | `` | `` |

### `DwgTag` (class)

**Attributes**: [EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.DwgTag` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgText` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Entities.DwgEntity, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Dwg.Entities.DwgText`
        - `Topomatic.Plt.DwgTag`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Content` | `String` | `get/set` | No | `ReadOnly` |
| `Descriptor` | `SimpleTagDescriptor` | `get/set` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `Field` | `TemplateField` | `get/set` | No | `PropertyProvider` |
| `IsBackgroud` | `Boolean` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Type` | `String` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<DwgEntity>` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `SyncField` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `DwgTagController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.DwgTagController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Plt.DwgTagController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `MockupUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.MockupUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvalidateMockupLayers` | `Void` | `IFramableDocumentWindow wnd` | `` |
| `ReplaceTagWithText` | `Void` | `Drawing dwg` | `` |
| `ReplaceTextWithTag` | `Void` | `Drawing dwg` | `` |
| `WriteMockupVariablesToDrawing` | `Void` | `DwgDictionary dict, Drawing dwg` | `` |

### `PltParamsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltParamsFrame` |
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
                - `Topomatic.Plt.PltParamsFrame`

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

### `PltSelectTemplateFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltSelectTemplateFrame` |
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
                - `Topomatic.Plt.PltSelectTemplateFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cbFormat` | `ComboBox` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PltSetting` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltSetting` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUserTemplate` | `Boolean` | `get/set` | No | `` |
| `Provider` | `String` | `get/set` | No | `` |
| `Template` | `DynamicDictionary` | `get` | No | `` |
| `TemplateName` | `String` | `get/set` | No | `` |
| `UserTemplateName` | `String` | `get/set` | No | `` |
| `Variables` | `DynamicDictionary` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `PltSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSetting` | `T` | `String model, String task` | `` |
| `HasSetting` | `Boolean` | `String model, String task` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetSettings` | `Void` | `String model, String task, T value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PltSimpleWizardController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltSimpleWizardController` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleWizardController` |
| **Implements** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Dialogs.SimpleWizardController`
    - `Topomatic.Plt.PltSimpleWizardController`

#### Constructors (1)

- `.ctor(WizardFrame[] frames)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Validate` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWizardController` | `Validate` |

### `PltStampFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltStampFrame` |
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
                - `Topomatic.Plt.PltStampFrame`

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

### `PltStamps` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltStamps` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStamp` | `StampData` | `String task` | `` |
| `HasStamp` | `Boolean` | `String task` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetStamp` | `Void` | `String task, StampData stamp` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PltTemplateStampFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.PltTemplateStampFrame` |
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
                - `Topomatic.Plt.PltTemplateStampFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Plt.Design`

### `PltTemplateValueEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Design.PltTemplateValueEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Plt.Design.PltTemplateValueEditor`

#### Constructors (1)

- `.ctor(String hvar, String vvar)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |

---
## Namespace: `Topomatic.Plt.Mockup`

### `IMockupable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Mockup.IMockupable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginMockup` | `Void` | `DynamicDictionary key, Vector2D pos` | `` |
| `BeginMockupDelayed` | `MockupItem` | `DynamicDictionary key, Vector2D pos` | `` |
| `ContainsMockupItem` | `Boolean` | `DynamicDictionary key` | `` |
| `EndMockup` | `Void` | `` | `` |
| `EndMockupDelayed` | `Void` | `` | `` |
| `MockupEntity` | `Void` | `DwgEntity entity` | `` |
| `TryGetChangedItem` | `Boolean` | `DynamicDictionary key, ref MockupItem item` | `` |

### `MockupGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Mockup.MockupGenerator` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Plt.Mockup.MockupGenerator`

#### Constructors (1)

- `.ctor(UInt32 id)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareFields` | `Void` | `` | `` |
| `PrepareVariables` | `Void` | `` | `` |

### `MockupLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Base Type** | `Topomatic.Dwg.Layer.DrawingLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`

#### Constructors (2)

- `.ctor(TemplateDwgGenerator generator)`
- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveBlock` | `DwgBlock` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Origin` | `Vector2D` | `get/set` | No | `` |
| `SectionId` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMockupLayer` | `MockupLayer` | `CadView cadView` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `IDrawingContainer` | `get_Drawing` |

### `MockupText` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Mockup.MockupText` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Content` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Hidden` | `Boolean` | `get/set` | No | `` |
| `Justify` | `TextAlignment` | `get/set` | No | `` |
| `Layer` | `DwgLayer` | `get/set` | No | `` |
| `Offset` | `Vector3D` | `get` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Ratio` | `Double` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `TextLength` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Move` | `Void` | `Double dx, Double dy, Double dz` | `` |

---
## Namespace: `Topomatic.Plt.Stamp`

### `StampData` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Stamp.StampData` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(StampData data)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Attributes` | `Dictionary<String String>` | `get` | No | `` |
| `Item` | `String` | `get/set` | No | `` |
| `ProjectCipher` | `String` | `get/set` | No | `` |
| `ProjectDescription` | `String` | `get/set` | No | `` |
| `ProjectWorkDescription` | `String` | `get/set` | No | `` |
| `SheetCount` | `Int32` | `get/set` | No | `` |
| `SheetDescription` | `String` | `get/set` | No | `` |
| `SheetNum` | `Int32` | `get/set` | No | `` |
| `Stage` | `String` | `get/set` | No | `` |
| `Workers` | `WorkItem[]` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Applay` | `Void` | `DwgTemplateSheet sheet` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LogoPath` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StampDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Stamp.StampDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawArchiveStamp` | `Void` | `IEntityFactory factory, Double x, Double y` | `` |
| `DrawBigStamp` | `Void` | `IEntityFactory factory, Double x, Double y, ref StampData stampData` | `` |
| `DrawFormat` | `Void` | `DwgBlock block, BoundingBox2D bounds, Boolean smallStamp, ref StampData stampData` | `` |
| `DrawSmallStamp` | `Void` | `IEntityFactory factory, Double x, Double y, ref StampData stampData` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BIG_STAMP_HEIGHT` | `Double` | Yes | `60` | `` |
| `SMALL_STAMP_HEIGHT` | `Double` | Yes | `20` | `` |
| `STAMP_WIDTH` | `Double` | Yes | `185` | `` |

### `StampFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Stamp.StampFrame` |
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
              - `Topomatic.Plt.Stamp.StampFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Dictionary<String Object> attributes` | `` |
| `OnFinallize` | `Void` | `StampData stampData` | `` |
| `OnInitialize` | `Void` | `StampData stampData` | `` |
| `OnInitialize` | `Void` | `Dictionary<String Object> attributes, Dictionary<String Object> inherit` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillDefault` | `StampData` | `String projectName, String projectDescription, String person` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WorkItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Stamp.WorkItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Plt.Stamp.WorkItem`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Date` | `String` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Person` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Plt.SysClasses`

### `ProfileBreak` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.SysClasses.ProfileBreak` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Station` | `Double` | `get/set` | No | `` |
| `Type` | `ProfileBreakType` | `get/set` | No | `` |

### `ProfileBreakType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.SysClasses.ProfileBreakType` |
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
      - `Topomatic.Plt.SysClasses.ProfileBreakType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NewBreak` | `ProfileBreakType` | Yes | `NewBreak` | `` |
| `NewSheet` | `ProfileBreakType` | Yes | `NewSheet` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NewSheet` | `0` |
| `NewBreak` | `1` |

**Underlying Type**: `System.Int32`

### `StaRange` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.SysClasses.StaRange` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndSta` | `Double` | `get/set` | No | `` |
| `StartSta` | `Double` | `get/set` | No | `` |
| `TransitionIndex` | `Int32` | `get/set` | No | `` |

---
## Namespace: `Topomatic.Plt.Templates`

### `PltStandardValueEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.PltStandardValueEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Plt.Templates.PltStandardValueEditor`

#### Constructors (2)

- `.ctor(Double[] scales)`
- `.ctor(IEnumerable<Double> roadScales, IEnumerable<Double> railScales)`

### `TemplateFieldProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

---
## Namespace: `Topomatic.Plt.Templates.Common`

### `PltCommonVariablesProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltCommonVariablesProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Plt.Templates.Common.PltCommonVariablesProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `PltProperties` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltProperties` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(UInt32 id, IEnumerable<KeyValuePair<String PltVariable>> varialbes, Dictionary<String Object> modified)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `Browsable` |
| `Level` | `PltVariableLevel` | `get/set` | No | `Browsable` |
| `Modified` | `Dictionary<String Object>` | `get` | No | `Browsable` |
| `Variables` | `IEnumerable<KeyValuePair<String PltVariable>>` | `get` | No | `PropertyProvider` |

### `PltValidator` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltValidator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Validate` | `Nullable<KeyValuePair<PltValidType String>>` | `TemplateDwgGenerator tg` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetValidators` | `IEnumerable<PltValidator>` | `UInt32 task` | `` |
| `Register` | `Void` | `UInt32 task, PltValidator validator` | `` |

### `PltValidType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltValidType` |
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
      - `Topomatic.Plt.Templates.Common.PltValidType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Error` | `PltValidType` | Yes | `Error` | `` |
| `Info` | `PltValidType` | Yes | `Info` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Warning` | `PltValidType` | Yes | `Warning` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Error` | `0` |
| `Warning` | `1` |
| `Info` | `2` |

**Underlying Type**: `System.Int32`

### `PltVariable` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltVariable` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(String name, Object value)`
- `.ctor(String name, String category, Object value)`
- `.ctor(String name, String category, Object value, PropertyEditor editor)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Browsable` | `Boolean` | `get/set` | No | `` |
| `Category` | `String` | `get/set` | No | `` |
| `DisplayName` | `String` | `get/set` | No | `` |
| `Editor` | `PropertyEditor` | `get/set` | No | `` |
| `Level` | `PltVariableLevel` | `get/set` | No | `` |
| `Serializable` | `Boolean` | `get/set` | No | `` |
| `Value` | `Object` | `get/set` | No | `` |

### `PltVariableLevel` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltVariableLevel` |
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
      - `Topomatic.Plt.Templates.Common.PltVariableLevel`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `PltVariableLevel` | Yes | `All` | `` |
| `Drawing` | `PltVariableLevel` | Yes | `Drawing` | `` |
| `Mockup` | `PltVariableLevel` | Yes | `Mockup` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `All` | `0` |
| `Mockup` | `100` |
| `Drawing` | `300` |

**Underlying Type**: `System.Int32`

### `PltVariableProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `PltVariables` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.PltVariables` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Plt.Templates.Common.PltVariable, Topomatic.Plt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String tag, PltVariable variable` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String PltVariable>>` | `` | `` |
| `TryGetValue` | `Boolean` | `String name, ref PltVariable variable` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SimpleTagDescriptor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.TemplateProcessor+SimpleTagDescriptor` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(String className)`
- `.ctor(String className, String localizedName)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ClassName` | `String` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `LocalizedName` | `String` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String item` | `` |
| `Add` | `Void` | `String item, String associatedVariable` | `Obsolete(Message: `Используется для поддержки старого кода`)` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `String item` | `` |
| `CopyTo` | `Void` | `String[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<String>` | `` | `` |
| `Remove` | `Boolean` | `String item` | `` |

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

### `TemplateDwgGenerator` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Base Type** | `Topomatic.Plt.DwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CreateMockupBlockInsert` | `Boolean` | `get/set` | No | `` |
| `DataManager` | `IDictionary<String Object>` | `get` | No | `` |
| `FrameOnLayout` | `Boolean` | `get/set` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Mockup` | `DwgDictionary` | `get/set` | No | `` |
| `MockupItems` | `Dictionary<UInt32 Dictionary<DynamicDictionary MockupItemWrapper>>` | `get` | No | `` |
| `SeparateLayout` | `Boolean` | `get/set` | No | `` |
| `StampData` | `StampData` | `get/set` | No | `` |
| `Template` | `Drawing` | `get/set` | No | `` |
| `TemplateProcessor` | `TemplateProcessor` | `get` | No | `` |
| `Underlay` | `Boolean` | `get/set` | No | `` |
| `Variables` | `IEnumerable<KeyValuePair<String PltVariable>>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTemplateBlock` | `DwgBlock` | `Drawing template, String pathId, String modelId, DynamicDictionary settings, Vector2D origin` | `` |
| `GetVariable` | `Object` | `String name` | `` |

#### Fields (35)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ID_COMMON` | `Int32` | Yes | `983055` | `` |
| `ID_CRS_COMMON` | `Int32` | Yes | `983042` | `` |
| `ID_CRS_RAIL` | `Int32` | Yes | `131074` | `` |
| `ID_CRS_ROAD` | `Int32` | Yes | `65538` | `` |
| `ID_CRS_SRV` | `Int32` | Yes | `262146` | `` |
| `ID_PIPENETWORK_GNB` | `Int32` | Yes | `1048640` | `` |
| `ID_PIPENETWORK_PLAN_CROSS` | `Int32` | Yes | `1048704` | `` |
| `ID_PIPENETWORK_PRF` | `Int32` | Yes | `1048577` | `` |
| `ID_PIPENETWORK_SHAFT` | `Int32` | Yes | `1048608` | `` |
| `ID_PRF_COMMON` | `Int32` | Yes | `983041` | `` |
| `ID_PRF_RAIL` | `Int32` | Yes | `131073` | `` |
| `ID_PRF_ROAD` | `Int32` | Yes | `65537` | `` |
| `ID_PRF_SRV` | `Int32` | Yes | `262145` | `` |
| `MODEL_COMMON` | `Int32` | Yes | `983040` | `` |
| `MODEL_CULVERTS` | `Int32` | Yes | `4194304` | `` |
| `MODEL_GEOLOGY` | `Int32` | Yes | `2097152` | `` |
| `MODEL_MASK` | `Int32` | Yes | `-65536` | `` |
| `MODEL_NONE` | `Int32` | Yes | `524288` | `` |
| `MODEL_PIPENETWORK` | `Int32` | Yes | `1048576` | `` |
| `MODEL_RAIL` | `Int32` | Yes | `131072` | `` |
| `MODEL_ROAD` | `Int32` | Yes | `65536` | `` |
| `MODEL_SHR` | `Int32` | Yes | `16` | `` |
| `MODEL_SRV` | `Int32` | Yes | `262144` | `` |
| `TASK_COMMON` | `Int32` | Yes | `15` | `` |
| `TASK_CRS` | `Int32` | Yes | `2` | `` |
| `TASK_CULVERTS` | `Int32` | Yes | `1024` | `` |
| `TASK_MASK` | `Int32` | Yes | `65535` | `` |
| `TASK_PIPENETWORK_GNB` | `Int32` | Yes | `64` | `` |
| `TASK_PIPENETWORK_PLAN_CROSS` | `Int32` | Yes | `128` | `` |
| `TASK_POWERLINECROSS` | `Int32` | Yes | `8` | `` |
| `TASK_PRF` | `Int32` | Yes | `1` | `` |
| `TASK_SECTIONS` | `Int32` | Yes | `4` | `` |
| `TASK_SHAFTS` | `Int32` | Yes | `32` | `` |
| `TASK_SHR` | `Int32` | Yes | `0` | `` |
| `TASK_STATIONEDPLAN` | `Int32` | Yes | `512` | `` |

### `TemplateField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DataManager` | `IDictionary<String Object>` | `get` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `TagEntity` | `DwgEntity` | `get/set` | No | `` |
| `TagPosition` | `Vector3D` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginMockup` | `Void` | `DynamicDictionary key, Vector2D pos` | `` |
| `BeginMockupDelayed` | `MockupItem` | `DynamicDictionary key, Vector2D pos` | `` |
| `ContainsMockupItem` | `Boolean` | `DynamicDictionary key` | `` |
| `DrawField` | `Void` | `` | `` |
| `EndMockup` | `Void` | `` | `` |
| `EndMockupDelayed` | `Void` | `` | `` |
| `MockupEntity` | `Void` | `DwgEntity entity` | `` |
| `PrepareField` | `Void` | `TemplateDwgGenerator dwgGenerator` | `` |
| `TryGetChangedItem` | `Boolean` | `DynamicDictionary key, ref MockupItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IMockupable` | `BeginMockup` |
| `IMockupable` | `EndMockup` |
| `IMockupable` | `BeginMockupDelayed` |
| `IMockupable` | `EndMockupDelayed` |
| `IMockupable` | `MockupEntity` |
| `IMockupable` | `ContainsMockupItem` |
| `IMockupable` | `TryGetChangedItem` |

### `TemplateProcessor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.TemplateProcessor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(UInt32 id)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FieldAliases` | `IEnumerable<KeyValuePair<String SimpleTagDescriptor>>` | `get` | No | `` |
| `Fields` | `IEnumerable<TemplateField>` | `get` | No | `` |
| `Id` | `UInt32` | `get/set` | No | `` |
| `Template` | `Drawing` | `get/set` | No | `` |
| `Variables` | `PltVariables` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `` | `` |
| `GetVariable` | `Object` | `String name` | `` |
| `RegisterFieldAlias` | `SimpleTagDescriptor` | `String alias, String className, String localizedName` | `` |
| `RegisterFieldAlias` | `SimpleTagDescriptor` | `String alias, String className` | `` |
| `ReleaseFieldAlias` | `Void` | `String alias` | `` |

#### Nested Types (1)

- `SimpleTagDescriptor` (class)

---
## Namespace: `Topomatic.Plt.Templates.Common.Fields`

### `PltFieldTemplateInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.Fields.PltFieldTemplateInfo` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Common.Fields.PltFieldTemplateInfo`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Title` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Title` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Common.Fields.Title` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Common.Fields.Title`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Plt.Templates.Crs`

### `CrsField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Crs.CrsField` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Crs.CrsField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalScale` | `Double` | `get` | No | `` |
| `VerticalHatOffset` | `Double` | `get` | No | `` |
| `VerticalScale` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PltCrsConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Crs.PltCrsConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (25)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AlignElevations` | `String` | Yes | `` | `` |
| `Alignment` | `String` | Yes | `` | `` |
| `CUT` | `String` | Yes | `` | `` |
| `CUT_OFFSTE` | `String` | Yes | `` | `` |
| `ExportProvider` | `String` | Yes | `` | `` |
| `FrameOnLayout` | `String` | Yes | `` | `` |
| `HO` | `String` | Yes | `` | `` |
| `LH1` | `String` | Yes | `` | `` |
| `LH2` | `String` | Yes | `` | `` |
| `LT1` | `String` | Yes | `` | `` |
| `LT2` | `String` | Yes | `` | `` |
| `LV1` | `String` | Yes | `` | `` |
| `LV2` | `String` | Yes | `` | `` |
| `NEW_ROW` | `String` | Yes | `` | `` |
| `ONE` | `String` | Yes | `` | `` |
| `SectionBounds` | `String` | Yes | `` | `` |
| `SectionIndex` | `String` | Yes | `` | `` |
| `SectionNumber` | `String` | Yes | `` | `` |
| `SelectedSections` | `String` | Yes | `` | `` |
| `SeparateLayout` | `String` | Yes | `` | `` |
| `SH` | `String` | Yes | `` | `` |
| `SHEET_LAYOUT` | `String` | Yes | `` | `` |
| `Stamp` | `String` | Yes | `` | `` |
| `SV` | `String` | Yes | `` | `` |
| `Underlay` | `String` | Yes | `` | `` |

### `PltCrsVariableProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Crs.PltCrsVariableProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Plt.Templates.Crs.PltCrsVariableProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

---
## Namespace: `Topomatic.Plt.Templates.Prf`

### `PltPrfConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Prf.PltPrfConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (38)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ActiveTransition` | `String` | Yes | `` | `` |
| `AlignElevations` | `String` | Yes | `` | `` |
| `Alignment` | `String` | Yes | `` | `` |
| `ContractedProfileType` | `Int32` | Yes | `2` | `` |
| `DrainageProfileType` | `Int32` | Yes | `1` | `` |
| `EndSta` | `String` | Yes | `` | `` |
| `ExportProvider` | `String` | Yes | `` | `` |
| `HO` | `String` | Yes | `` | `` |
| `KapRemProfileType` | `Int32` | Yes | `4` | `` |
| `LV` | `String` | Yes | `` | `` |
| `MainAlignId` | `String` | Yes | `` | `` |
| `MainAlignIndex` | `Int32` | Yes | `2` | `` |
| `MainProjectId` | `String` | Yes | `` | `` |
| `MainProjectIndex` | `Int32` | Yes | `3` | `` |
| `Max` | `String` | Yes | `` | `` |
| `Min` | `String` | Yes | `` | `` |
| `Name` | `String` | Yes | `` | `` |
| `ProfileType` | `String` | Yes | `` | `` |
| `Range` | `String` | Yes | `` | `` |
| `Ranges` | `String` | Yes | `` | `` |
| `ReferenceAlignments` | `String` | Yes | `` | `` |
| `RegionIndex` | `String` | Yes | `` | `` |
| `Reverse` | `String` | Yes | `` | `` |
| `SecondProjectId` | `String` | Yes | `` | `` |
| `SecondProjectIndex` | `Int32` | Yes | `1` | `` |
| `SecondTrackProfileType` | `Int32` | Yes | `3` | `` |
| `SG` | `String` | Yes | `` | `` |
| `SH` | `String` | Yes | `` | `` |
| `Sheet` | `String` | Yes | `` | `` |
| `SheetEnd` | `String` | Yes | `` | `` |
| `SheetEndSta` | `String` | Yes | `` | `` |
| `Sheets` | `String` | Yes | `` | `` |
| `SheetStart` | `String` | Yes | `` | `` |
| `SheetStartSta` | `String` | Yes | `` | `` |
| `SimpleProfileType` | `Int32` | Yes | `0` | `` |
| `Stamp` | `String` | Yes | `` | `` |
| `StartSta` | `String` | Yes | `` | `` |
| `SV` | `String` | Yes | `` | `` |

### `PltPrfVariableProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Prf.PltPrfVariableProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Plt.Templates.Prf.PltPrfVariableProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `PrfField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndSta` | `Double` | `get` | No | `` |
| `HorizontalScale` | `Double` | `get` | No | `` |
| `StartSta` | `Double` | `get` | No | `` |
| `VerticalScale` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TemplateFieldProcessor`1<T where class>` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Templates.Prf.TemplateFieldProcessor`1` |
| **Base Type** | `System.ValueType` |
| **Implements** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Plt.Templates.Prf.TemplateFieldProcessor`1`

#### Constructors (1)

- `.ctor(Double station, T value, Int32 type)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompareTo` | `Int32` | `TemplateFieldProcessor<T> other` | `` |
| `GetDisplayPosition` | `Double` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AlignElevations` | `Void` | `List<TemplateFieldProcessor<T>> items, Int32 type, Double ts, Boolean alignElevations, Func<T T Boolean> equals` | `` |
| `AlignElevations` | `Void` | `List<TemplateFieldProcessor<T>> items, Int32 type, Double ts, Boolean alignElevations` | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FLAG_HIDDEN` | `Int32` | Yes | `256` | `` |
| `Flags` | `Int32` | No | `` | `` |
| `Offset` | `Single` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |
| `TYPE_EXISTING` | `Int32` | Yes | `0` | `` |
| `TYPE_MASK` | `Int32` | Yes | `255` | `` |
| `TYPE_PROJECT` | `Int32` | Yes | `1` | `` |
| `TYPE_SHR` | `Int32` | Yes | `0` | `` |
| `Value` | `T` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IComparable`1` | `CompareTo` |

---
## Namespace: `Topomatic.Plt.Wrappers`

### `PltProfileBreaksWrapper` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Wrappers.PltProfileBreaksWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IAlgStationing stationing, IList<ProfileBreak> breaks)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
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
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `StampWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Plt.Wrappers.StampWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(StampData data, String[] lists)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Fields` | `Object` | `get/set` | No | `PropertyProvider` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 50 |
| **Classes** | 34 |
| **Interfaces** | 1 |
| **Enums** | 3 |
| **Structs** | 2 |
| **Abstract Classes** | 5 |
| **Static Classes** | 5 |
| **Total Methods** | 117 |
| **Total Properties** | 101 |
| **Total Fields** | 126 |
| **Total Events** | 0 |
| **Total Constructors** | 42 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


