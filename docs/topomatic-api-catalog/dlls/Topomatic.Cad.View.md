# Topomatic.Cad.View

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Cad.View` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Cad.View.dll` |

---
## Namespace: `Topomatic.Cad.View`

### `AuxiliaryDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.AuxiliaryDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (29)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawAuxiliaryArc3d` | `Void` | `DeviceContext dc, Vector3D center, Double radius, Double startAngle, Double endAngle` | `` |
| `DrawAuxiliaryLine3d` | `Void` | `DeviceContext dc, Vector3D a, Vector3D b` | `` |
| `DrawAuxiliaryLine3d` | `Void` | `DeviceContext dc, Line3D line` | `` |
| `DrawAuxiliaryLine3d` | `Void` | `DeviceContext dc, Color color, Vector3D a, Vector3D b` | `` |
| `DrawAuxiliaryPolyline3d` | `Void` | `DeviceContext dc, IEnumerable<Vector3D> polyline` | `` |
| `DrawClickGrip3d` | `Void` | `DeviceContext dc, Vector3D position, GripState state` | `` |
| `DrawCursorMessageIcon3d` | `Void` | `DeviceContext dc, Vector3D position, MessageBoxIcon icon` | `` |
| `DrawDiamond3d` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `DrawDimmensionArc3d` | `Void` | `DeviceContext dc, Vector3D center, Double radius, Double startAngle, Double endAngle, String text` | `` |
| `DrawDimmensionArcAngular3d` | `Void` | `DeviceContext dc, Vector3D center, Double radius, Double startAngle, Double endAngle` | `` |
| `DrawDimmensionArcLinear3d` | `Void` | `DeviceContext dc, Vector3D center, Double radius, Double startAngle, Double endAngle` | `` |
| `DrawDimmention3d` | `Void` | `DeviceContext dc, Vector3D a, Vector3D b, String text` | `` |
| `DrawDimmention3d` | `Void` | `DeviceContext dc, Vector3D a, Vector3D b` | `` |
| `DrawDimmentionAngular3d` | `Void` | `DeviceContext dc, Vector3D startPoint, Vector3D endPoint` | `` |
| `DrawDimmentionAngular3d` | `Void` | `DeviceContext dc, Vector3D startPoint, Vector3D endPoint, String text` | `` |
| `DrawDimmentionLinear3d` | `Void` | `DeviceContext dc, Vector3D startPoint, Vector3D endPoint, String text, Int32 sign` | `` |
| `DrawDimmentionLinear3d` | `Void` | `DeviceContext dc, Vector3D startPoint, Vector3D endPoint, String text` | `` |
| `DrawDimmentionLinear3d` | `Void` | `DeviceContext dc, Vector3D startPoint, Vector3D endPoint` | `` |
| `DrawDimmentionLinear3d` | `Void` | `DeviceContext dc, Vector3D startPoint, Vector3D endPoint, Int32 sign` | `` |
| `DrawDoubleArrows3d` | `Void` | `DeviceContext dc, Vector3D position, Double angle, GripState state` | `` |
| `DrawGripArrow3d` | `Void` | `DeviceContext dc, Vector3D position, Double angle, GripState state` | `` |
| `DrawGripBox3d` | `Void` | `DeviceContext dc, Vector3D position, GripState state` | `` |
| `DrawGripDiamond3d` | `Void` | `DeviceContext dc, Vector3D position, GripState state` | `` |
| `DrawGripRotationRound3d` | `Void` | `DeviceContext dc, Vector3D position, Double angle, GripState state` | `` |
| `DrawGripRound3d` | `Void` | `DeviceContext dc, Vector3D position, GripState state` | `` |
| `DrawSnap3d` | `Void` | `DeviceContext dc, ObjectSnapFlags snap, Vector3D position` | `` |
| `DrawString3d` | `Void` | `DeviceContext dc, String text, Vector3D position` | `` |
| `GetGripForeColor` | `Color` | `GripState state` | `` |
| `PaintBugleSegment` | `Void` | `DeviceContext dc, Vector2D a, Vector2D b, Single bugle` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `GripArrowOffsetPix` | `Single` | Yes | `12.5` | `` |
| `GripArrowOffsetPix2` | `Single` | Yes | `10` | `` |

### `BaseCadView3d` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.BaseCadView3d` |
| **Base Type** | `Topomatic.Cad.View.Panel3d` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Cad.View.Panel3d`
          - `Topomatic.Cad.View.BaseCadView3d`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LastPoint` | `Vector3D` | `get/set` | No | `` |
| `Plane` | `Plane` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginSelect` | `Void` | `` | `` |
| `ClearSelection` | `Void` | `` | `` |
| `EndSelect` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetObjectsAtFrustum` | `IEnumerable<KeyValuePair<Vector3D Object>>` | `BoundingFrustum frustum, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtRay` | `IEnumerable<KeyValuePair<Double Object>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetPoint` | `GetPointResult` | `String message, ref Vector3D pos` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `GetSelected` | `IEnumerable` | `` | `` |
| `GetTrianglesAtRay` | `IEnumerable<KeyValuePair<Double Triangle3D>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `PickOneObjectAtScreen` | `Object` | `Predicate<Object> match, String message` | `` |
| `Select` | `Void` | `Object obj, Boolean flag` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Accepting` | `CancelEventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BimCamera` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Panel3d+BimCamera` |
| **Base Type** | `Topomatic.Cad.View.Panel3d+TransformationStyleCamera` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Panel3d+TransformationStyleCamera`
    - `Topomatic.Cad.View.Panel3d+BimCamera`

#### Constructors (1)

- `.ctor(Panel3d panel)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Axis` | `Vector3D` | `get` | No | `` |
| `Eye` | `Vector3D` | `get` | No | `` |
| `Forward` | `Vector3D` | `get` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `Up` | `Vector3D` | `get` | No | `` |

#### Instance Methods (41)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Back` | `Void` | `` | `` |
| `BackBottom` | `Void` | `` | `` |
| `BackTop` | `Void` | `` | `` |
| `Bottom` | `Void` | `` | `` |
| `Front` | `Void` | `` | `` |
| `FrontBottom` | `Void` | `` | `` |
| `FrontTop` | `Void` | `` | `` |
| `Left` | `Void` | `` | `` |
| `LeftBack` | `Void` | `` | `` |
| `LeftBackBottom` | `Void` | `` | `` |
| `LeftBackTop` | `Void` | `` | `` |
| `LeftBottom` | `Void` | `` | `` |
| `LeftFront` | `Void` | `` | `` |
| `LeftFrontBottom` | `Void` | `` | `` |
| `LeftFrontTop` | `Void` | `` | `` |
| `LeftTop` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `OnKeyDown` | `Void` | `KeyEventArgs e` | `` |
| `OnKeyPress` | `Void` | `KeyPressEventArgs e` | `` |
| `OnKeyUp` | `Void` | `KeyEventArgs e` | `` |
| `OnMouseDoubleClick` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseDown` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseMove` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseUp` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseWheel` | `Void` | `MouseEventArgs e` | `` |
| `OnPaint` | `Void` | `DeviceContext dc` | `` |
| `OnUpdate` | `Void` | `Single time` | `` |
| `Right` | `Void` | `` | `` |
| `RightBack` | `Void` | `` | `` |
| `RightBackBottom` | `Void` | `` | `` |
| `RightBackTop` | `Void` | `` | `` |
| `RightBottom` | `Void` | `` | `` |
| `RightFront` | `Void` | `` | `` |
| `RightFrontBottom` | `Void` | `` | `` |
| `RightFrontTop` | `Void` | `` | `` |
| `RightTop` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SolveLimits` | `Void` | `BoundingBox3D bounds` | `` |
| `SolveLimitsFromBack` | `Void` | `BoundingBox3D bounds` | `` |
| `Top` | `Void` | `` | `` |
| `TranslateGlobal` | `Void` | `Vector3D delta` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Angles` | `Void` | `Vector3D axis, Vector3D up, ref Double alpha, ref Double beta` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BoundDeviceContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.BoundDeviceContext` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Implements** | `System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Cad.View.BoundDeviceContext`

#### Constructors (1)

- `.ctor(CadView cadview)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `Projection` | `Matrix` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `BeginClip` | `Void` | `` | `` |
| `BeginRender` | `Void` | `` | `` |
| `EndClip` | `Void` | `` | `` |
| `gString` | `Void` | `Font font, String text` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `CadColorComboBox` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadColorComboBox` |
| **Base Type** | `System.Windows.Forms.ComboBox` |
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
          - `System.Windows.Forms.ComboBox`
            - `Topomatic.Cad.View.CadColorComboBox`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IContainer container)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurrentColor` | `CadColor` | `get/set` | No | `Localizable, Browsable, DesignerSerializationVisibility` |
| `IsBackgroundColor` | `Boolean` | `get/set` | No | `Localizable, Browsable, DesignerSerializationVisibility` |
| `Items` | `ObjectCollection` | `get` | No | `DesignerSerializationVisibility, Localizable, Browsable` |
| `LayerColor` | `CadColor` | `get/set` | No | `DesignerSerializationVisibility, Localizable, Browsable` |
| `SupportBackgroundColor` | `Boolean` | `get/set` | No | `` |
| `SupportByLayerByBlockColor` | `Boolean` | `get/set` | No | `` |
| `SupportNoneColor` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CadConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ObjectSnapToString` | `String` | `ObjectSnapFlags snap` | `` |

### `CadControl` (abstract class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadControl` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `Int32` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `CadFocused` | `Boolean` | `get` | No | `` |
| `CadView` | `CadView` | `get` | No | `` |
| `CanModal` | `Boolean` | `get` | No | `` |
| `ClientRect` | `Rectangle` | `get` | No | `` |
| `Dynamic` | `Boolean` | `get/set` | No | `` |
| `Focused` | `Boolean` | `get/set` | No | `` |
| `Height` | `Int32` | `get/set` | No | `` |
| `Left` | `Int32` | `get` | No | `` |
| `Location` | `Point` | `get/set` | No | `` |
| `Modal` | `Boolean` | `get/set` | No | `` |
| `Right` | `Int32` | `get` | No | `` |
| `Top` | `Int32` | `get` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |
| `Width` | `Int32` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ControlToView` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `DoValidate` | `Boolean` | `` | `` |
| `KeyPress` | `Void` | `CadKeyPressEventArgs e` | `` |
| `MouseDown` | `Void` | `MouseEventArgs e` | `` |
| `MouseMove` | `Void` | `MouseEventArgs e` | `` |
| `MouseUp` | `Void` | `MouseEventArgs e` | `` |
| `PreviewKeyDown` | `Void` | `CadPreviewKeyDownEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `CadFontComboBox` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadFontComboBox` |
| **Base Type** | `System.Windows.Forms.ComboBox` |
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
          - `System.Windows.Forms.ComboBox`
            - `Topomatic.Cad.View.CadFontComboBox`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IContainer container)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurrentFont` | `String` | `get/set` | No | `Browsable` |
| `Items` | `ObjectCollection` | `get` | No | `DesignerSerializationVisibility` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CadKeyPressEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadKeyPressEventArgs` |
| **Base Type** | `System.Windows.Forms.KeyPressEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `System.Windows.Forms.KeyPressEventArgs`
      - `Topomatic.Cad.View.CadKeyPressEventArgs`

#### Constructors (1)

- `.ctor(Char keyChar)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEnter` | `Boolean` | `get` | No | `` |
| `IsEscape` | `Boolean` | `get` | No | `` |
| `IsInputKey` | `Boolean` | `get` | No | `` |
| `IsTab` | `Boolean` | `get` | No | `` |
| `Key` | `Keys` | `get` | No | `` |

### `CadPreviewKeyDownEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadPreviewKeyDownEventArgs` |
| **Base Type** | `System.Windows.Forms.PreviewKeyDownEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `System.Windows.Forms.PreviewKeyDownEventArgs`
      - `Topomatic.Cad.View.CadPreviewKeyDownEventArgs`

#### Constructors (1)

- `.ctor(Keys keyData)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Handled` | `Boolean` | `get/set` | No | `` |

### `CadView` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadView` |
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
              - `Topomatic.Cad.View.CadView`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (51)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActionStackCount` | `Int32` | `get` | Yes | `` |
| `ActionTerminated` | `Boolean` | `get` | Yes | `` |
| `ActiveDriver` | `DriverName` | `get/set` | No | `` |
| `ActiveGrip` | `KeyValuePair<Object IGrip>` | `get/set` | No | `` |
| `AnnotationScale` | `Double` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `CompatabilityGraphics` | `Boolean` | `get/set` | Yes | `Browsable, DesignerSerializationVisibility` |
| `CurrentCursor` | `CadCursor` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `CurrentCursorPoint` | `Vector2D` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `CurrentCursorPointF` | `Vector3D` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `CurrentScale` | `Double` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `Cursor` | `Cursor` | `get/set` | No | `Browsable, DesignerSerializationVisibility, Localizable` |
| `CursorType` | `CursorView` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `DefaultProperty` | `IList` | `get` | No | `Browsable` |
| `DeviceContext` | `CadViewDeviceContext` | `get` | No | `Browsable, DesignerSerializationVisibility` |
| `DraftingSettings` | `DraftingSettings` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `FirstLinePoint` | `Nullable<Vector3D>` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `Font` | `Font` | `get/set` | No | `DesignerSerializationVisibility, Localizable` |
| `InverseViewProjection` | `Matrix` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `IsGettingValue` | `Boolean` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `IsLocked` | `Boolean` | `get` | No | `` |
| `IsModalEdit` | `Boolean` | `get` | No | `Browsable, DesignerSerializationVisibility` |
| `IsPainting` | `Boolean` | `get` | No | `Browsable, DesignerSerializationVisibility` |
| `Item` | `CadViewLayer` | `get` | No | `` |
| `LastMousePoint` | `Vector2D` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `LastObjectSnap` | `ObjectSnapFlags` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `LastPoint` | `Vector3D` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `LastUserCmd` | `String` | `get` | No | `Browsable, DesignerSerializationVisibility` |
| `Limits` | `BoundingBox2D` | `get` | No | `Browsable, DesignerSerializationVisibility` |
| `MultiSelect` | `Boolean` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `PopupMenuEnable` | `Boolean` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `PreviousFirstLinePoint` | `Nullable<Vector3D>` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `Projection` | `Matrix` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `ScreenRatio` | `Double` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `ScreenRotation` | `Double` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `SelectionSet` | `CompoundSelectionSet` | `get` | No | `Browsable, DesignerSerializationVisibility` |
| `ShowDriverSetting` | `Boolean` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `ShowScreenRotationSetting` | `Boolean` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `ShowScreenScaleRatio` | `Boolean` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `ShowUCSSetting` | `Boolean` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `SupportDrawAxes` | `Boolean` | `get/set` | No | `DefaultValue` |
| `SupportDynamicConsole` | `Boolean` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `TransactionManager` | `TransactionManager` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `Translation` | `Vector3D` | `get/set` | No | `DesignerSerializationVisibility, Browsable` |
| `UCSInsertion` | `Vector3D` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `UCSRotation` | `Double` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `UCSScale` | `Double` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `View` | `Matrix` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `ViewBounds` | `BoundingBox2D` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `ViewProjection` | `Matrix` | `get` | No | `Browsable, DesignerSerializationVisibility` |
| `WinCursor` | `Cursor` | `get/set` | No | `Browsable, DesignerSerializationVisibility` |
| `ZoomBoundsAnimationTime` | `Int32` | `get/set` | No | `DefaultValue` |

#### Instance Methods (56)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Accept` | `Void` | `` | `` |
| `AddLayer` | `Void` | `CadViewLayer layer` | `` |
| `BeginLock` | `Void` | `` | `` |
| `Cancel` | `Void` | `` | `` |
| `CanGetValue` | `Boolean` | `` | `` |
| `DisplayContextMenu` | `Void` | `MenuAction actions, Point location, Boolean quickAcess` | `` |
| `DisplayContextMenu` | `Void` | `MenuAction actions` | `` |
| `EndLock` | `Void` | `` | `` |
| `GetGraphicBuffer` | `Image` | `` | `` |
| `GetLayers` | `IEnumerable<CadViewLayer>` | `` | `` |
| `GetSelectable` | `IEnumerable<SelectorModel>` | `` | `` |
| `GetSelected` | `IEnumerable<SelectorModel>` | `` | `` |
| `GetThumbnailImage` | `Image` | `Int32 cx, Color backColor` | `` |
| `GetValue` | `GetPointResult` | `CursorView cv` | `` |
| `HandleCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `Invoke` | `Object` | `String uid, Object[] objects` | `` |
| `Lock` | `Void` | `` | `` |
| `MakeGripSearchBox` | `BoundingBox2D` | `Vector3D position` | `` |
| `MakeSearchBox` | `BoundingBox2D` | `Vector3D position` | `` |
| `MakeSearchRectangle` | `RectangleD` | `Vector3D position` | `` |
| `MakeSnapSearchBox` | `BoundingBox2D` | `Vector3D position` | `` |
| `MoveDown` | `Boolean` | `CadViewLayer layer` | `` |
| `MoveUp` | `Boolean` | `CadViewLayer layer` | `` |
| `PerformDynamicPaint3d` | `Void` | `DeviceContext dc, Ray3D ray, BoundingFrustum frustum` | `` |
| `PerformEnter` | `Void` | `` | `` |
| `PerformGetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `PerformGetLimits3d` | `Boolean` | `ref BoundingBox3D limits` | `` |
| `PerformHighlightObject3d` | `Void` | `DeviceContext dc, Object obj` | `` |
| `PerformPaint` | `Void` | `DeviceContext dc` | `` |
| `PerformPaint3d` | `Void` | `DeviceContext dc` | `` |
| `PopCursor` | `Void` | `` | `` |
| `PopDynamicDraw` | `Void` | `` | `` |
| `PreProcessMessage` | `Boolean` | `ref Message msg` | `` |
| `Print` | `Void` | `String name` | `` |
| `ProjectBox` | `BoundingBox2D` | `BoundingBox2D box` | `` |
| `ProjectBox3d` | `BoundingBox3D` | `BoundingBox3D box` | `` |
| `ProjectFromUCS` | `Vector3D` | `Vector3D position` | `` |
| `ProjectPoint` | `Vector3D` | `Vector3D position` | `` |
| `ProjectPoint` | `Vector2D` | `Vector2D position` | `` |
| `ProjectToUCS` | `Vector3D` | `Vector3D position` | `` |
| `PushCursor` | `Void` | `` | `` |
| `PushDynamicDraw` | `Void` | `` | `` |
| `RemoveLayer` | `Void` | `CadViewLayer layer` | `` |
| `RightButtonCancel` | `Void` | `` | `` |
| `SelectObjects` | `Void` | `IEnumerable<SelectorModel> select` | `` |
| `ShowWarning` | `Void` | `String message, MessageBoxIcon icon` | `` |
| `SolveLimits` | `Boolean` | `Boolean animate` | `` |
| `SolveLimits` | `Boolean` | `` | `` |
| `Unlock` | `Void` | `` | `` |
| `UnProjectBox` | `BoundingBox2D` | `BoundingBox2D box` | `` |
| `UnProjectPoint` | `Vector2D` | `Point position` | `` |
| `UnProjectPoint` | `Vector2D` | `Vector2D position` | `` |
| `UnProjectPoint` | `Vector3D` | `Vector3D position` | `` |
| `UserCommand` | `Void` | `String command, Boolean silent` | `` |
| `UserCommand` | `Void` | `String command` | `` |
| `ZoomBound` | `Void` | `BoundingBox2D bound, Boolean animate` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DoInvokeAction` | `Object` | `String uid, Object[] objects` | `` |
| `TerminateActions` | `Void` | `Boolean value` | `` |

#### Events (17)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Accepting` | `CancelEventHandler` | No | `` |
| `AuxiliaryDraw` | `RenderCursorEventHandler` | No | `` |
| `CreateMenu` | `CreateMenuEventHandler` | No | `` |
| `CreateSnapObject` | `ObjectSnapEventHandler` | No | `` |
| `CurrentCursorPointChanged` | `EventHandler` | No | `` |
| `DynamicDraw` | `DrawCursorEvent` | No | `` |
| `DynamicRender` | `RenderCursorEventHandler` | No | `` |
| `EmptyActionStack` | `EventHandler` | Yes | `` |
| `ExternalGetValue` | `CancelEventHandler` | No | `` |
| `GetValueStarted` | `EventHandler` | Yes | `` |
| `InvokeAction` | `InvokeActionEventHandler` | Yes | `` |
| `RenderCursor` | `RenderCursorEventHandler` | No | `` |
| `SelectedChanged` | `EventHandler` | No | `` |
| `StaticDraw` | `DrawCursorEvent` | No | `` |
| `StaticRender` | `RenderCursorEventHandler` | No | `` |
| `TranslationChanged` | `EventHandler` | No | `` |
| `UCSChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CadViewDeviceContext` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadViewDeviceContext` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Cad.View.CadViewDeviceContext`

#### Constructors (1)

- `.ctor(Control control)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadViewGraphics` | `Graphics` | `get/set` | No | `` |
| `Simplify` | `Boolean` | `get` | No | `` |
| `SupportRenderTexture` | `Boolean` | `get` | No | `` |
| `Terminated` | `Boolean` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BegingRenderTexture` | `Void` | `` | `` |
| `BeginRender` | `Void` | `` | `` |
| `EndRenderTexture` | `Void` | `` | `` |
| `RenderTexture` | `Void` | `Single xoffset, Single yoffset` | `` |
| `RequestRedraw` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CadViewExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadViewExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePolyline` | `Boolean` | `CadView cadview, DrawCursorEvent draw, Action initialize, List<Vector3D> pline` | `Extension` |

### `CadViewLayer` (abstract class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CadViewLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get/set` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Owner` | `CadViewLayer` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `BeginUpdate` | `Void` | `String caption` | `` |
| `Dispose` | `Void` | `` | `` |
| `EnableColors` | `Boolean` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `PerformGetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `PerformGetLimits3d` | `Boolean` | `ref BoundingBox3D limits` | `` |
| `PerformPaint` | `Void` | `CadPen pen` | `` |
| `PerformPaint3d` | `Void` | `DeviceContext dc` | `` |
| `PerformPrint` | `Void` | `CadPen pen, PrintPageEventArgs e` | `` |
| `ResolveActive` | `Boolean` | `` | `` |
| `ResolveEnable` | `Boolean` | `` | `` |
| `ResolveVisible` | `Boolean` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `EnableChange` | `EventHandler` | No | `` |
| `VisibleChange` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `INamedTransactable` | `BeginUpdate` |
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `ClickGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ClickGrip` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Location` | `Vector3D` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLocation` | `Vector3D` | `CadView cadview` | `` |
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `OnHighlight` | `Void` | `PaintGripEventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Click` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `GetLocation` |
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |
| `IGrip` | `OnHighlight` |
| `IGrip` | `OnCreateMenu` |

### `ColorsBrowserDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ColorsBrowserDlg` |
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
                  - `Topomatic.Cad.View.ColorsBrowserDlg`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectedColor` | `CadColor` | `get/set` | No | `` |
| `StoredColors` | `List<CadColor>` | `get` | Yes | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Object` | `CadColor color, Boolean indexPallet, Boolean rgbPallet, Boolean refButtons` | `` |
| `Execute` | `Boolean` | `ref CadColor color, CadColor layerColor, Boolean refButtons` | `` |
| `Execute` | `Boolean` | `ref CadColor color` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CompoundLayer` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`

#### Constructors (1)

- `.ctor(String name, Guid guid)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `CadViewLayer` | `get` | No | `` |
| `Item` | `CadViewLayer` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `CadViewLayer layer` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<CadViewLayer>` | `` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `MoveDown` | `Boolean` | `CadViewLayer layer` | `` |
| `MoveUp` | `Boolean` | `CadViewLayer layer` | `` |
| `Remove` | `Void` | `CadViewLayer layer` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CompoundSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CompoundSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Cad.View.CompoundSelectionSet`

#### Constructors (1)

- `.ctor(CompoundLayer layer)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CompoundLayer` | `CompoundLayer` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `SupportClipboard` | `Boolean` | `get` | No | `` |
| `SupportCopyTransform` | `Boolean` | `get` | No | `` |
| `SupportDragAndDrop` | `Boolean` | `get` | No | `` |
| `SupportTransform` | `Boolean` | `get` | No | `` |

#### Instance Methods (53)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Align` | `Void` | `Object data, Vector2D sourceA, Vector2D sourceB, Vector2D destA, Vector2D destB, Boolean scale, Boolean copy` | `` |
| `AlignSelected` | `Void` | `` | `` |
| `CanPaste` | `Boolean` | `` | `` |
| `CanPaste` | `Boolean` | `Guid[] layerGuids` | `` |
| `Clear` | `Void` | `` | `` |
| `ClearDisabledObjects` | `Void` | `` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `CopySelected` | `Void` | `` | `` |
| `CopySelectedBase` | `Void` | `` | `` |
| `CopyTransform` | `Void` | `` | `` |
| `CutSelected` | `Void` | `` | `` |
| `CutSelectedBase` | `Void` | `` | `` |
| `DragDrop` | `Boolean` | `String path` | `` |
| `DragOver` | `Boolean` | `String path` | `` |
| `Erase` | `Void` | `` | `` |
| `FilterSelected` | `Void` | `Predicate<Object> match` | `` |
| `FindOwner` | `CadViewLayer` | `Object obj` | `` |
| `FindOwner` | `CadViewLayer` | `Object obj, Boolean top` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetGrips` | `IEnumerable<KeyValuePair<Object IEnumerable<IGrip>>>` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtFrustum` | `IEnumerable<KeyValuePair<Vector3D Object>>` | `BoundingFrustum frustum, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtRay` | `IEnumerable<KeyValuePair<Double Object>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `GetTransformData` | `Object` | `` | `` |
| `GetTrianglesAtRay` | `IEnumerable<KeyValuePair<Double Triangle3D>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `IsValidClipboardCopySelection` | `Boolean` | `` | `` |
| `IsValidTransformSelection` | `Boolean` | `` | `` |
| `Mirror` | `Void` | `Object data, Vector2D a, Vector2D b, Boolean copy` | `` |
| `MirrorSelected` | `Void` | `` | `` |
| `Move` | `Void` | `Object data, Double x, Double y, Double z, Boolean copy` | `` |
| `MoveSelected` | `Void` | `` | `` |
| `PaintTransformData` | `Void` | `Object data, CadPen pen` | `` |
| `Paste` | `Void` | `` | `` |
| `PasteOrigin` | `Void` | `` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Rotate` | `Void` | `Object data, Vector2D basePoint, Double rotationAngle, Boolean copy` | `` |
| `RotateSelected` | `Void` | `` | `` |
| `Scale` | `Void` | `Object data, Vector2D basePoint, Double scaleFactorX, Double scaleFactorY, Boolean copy` | `` |
| `ScaleSelected` | `Void` | `` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `SelectAll` | `Void` | `` | `` |
| `SelectByFrame` | `Boolean` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Boolean select` | `` |
| `SelectByPolygon` | `Boolean` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EmptyTransformData` | `Object` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `ConsoleEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ConsoleEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.ConsoleEventArgs`

#### Constructors (1)

- `.ctor(String msg)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Message` | `String` | `get` | No | `` |

### `ConsoleListner` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ConsoleListner` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IConsole, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.IConsole, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Current` | `ConsoleListner` | `get` | Yes | `` |
| `Item` | `IConsole` | `get` | No | `` |
| `RequestString` | `String` | `get/set` | No | `` |
| `ResponseString` | `String` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `Void` | `Boolean silent` | `` |
| `Commit` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<IConsole>` | `` | `` |
| `Register` | `Void` | `IConsole listner` | `` |
| `Unregister` | `Void` | `IConsole listner` | `` |
| `Write` | `Void` | `String s` | `` |
| `WriteLine` | `Void` | `String s` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `CommitEvent` | `EventHandler<ConsoleEventArgs>` | No | `` |
| `ResponseChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IConsole` | `get_RequestString` |
| `IConsole` | `set_RequestString` |
| `IConsole` | `get_ResponseString` |
| `IConsole` | `set_ResponseString` |
| `IConsole` | `Commit` |
| `IConsole` | `Write` |
| `IConsole` | `WriteLine` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `ContextMenuBehavior` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ContextMenuBehavior` |
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
      - `Topomatic.Cad.View.ContextMenuBehavior`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ContextMenu` | `ContextMenuBehavior` | Yes | `ContextMenu` | `` |
| `ContextMenuIfSupported` | `ContextMenuBehavior` | Yes | `ContextMenuIfSupported` | `` |
| `Enter` | `ContextMenuBehavior` | Yes | `Enter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Enter` | `0` |
| `ContextMenu` | `1` |
| `ContextMenuIfSupported` | `2` |

**Underlying Type**: `System.Int32`

### `CursorView` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.CursorView` |
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
      - `Topomatic.Cad.View.CursorView`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cross` | `CursorView` | Yes | `Cross` | `` |
| `Default` | `CursorView` | Yes | `Default` | `` |
| `None` | `CursorView` | Yes | `None` | `` |
| `Rectangle` | `CursorView` | Yes | `Rectangle` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Default` | `1` |
| `Cross` | `2` |
| `Rectangle` | `3` |

**Underlying Type**: `System.Int32`

### `DefaultSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.DefaultSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Cad.View.DefaultSelectionSet`

#### Constructors (1)

- `.ctor(CadViewLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `DraftingSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.DraftingSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (69)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdaptiveGrid` | `Boolean` | `get/set` | No | `` |
| `AdditionalAngles` | `Double[]` | `get/set` | Yes | `` |
| `AuxiliaryDelay` | `Int32` | `get/set` | Yes | `` |
| `ClusteringGrid` | `Boolean` | `get/set` | No | `` |
| `CommandMode` | `ContextMenuBehavior` | `get/set` | Yes | `` |
| `ContainsColor` | `CadColor` | `get/set` | Yes | `` |
| `CopyTransformMuliple` | `Boolean` | `get/set` | Yes | `` |
| `CursorLineSize` | `Single` | `get/set` | Yes | `` |
| `CursorSize` | `Single` | `get/set` | Yes | `` |
| `DefaultFontSize` | `Int32` | `get/set` | Yes | `` |
| `DefaultLinearCursorType` | `Type` | `get/set` | Yes | `` |
| `DefaultPointCursorType` | `Type` | `get/set` | Yes | `` |
| `DefaultSmoothingMode` | `SmoothingMode` | `get/set` | Yes | `` |
| `DefaultTextRenderingHint` | `TextRenderingHint` | `get/set` | Yes | `` |
| `DisplayHints` | `Boolean` | `get/set` | Yes | `` |
| `DisplayMessage` | `Boolean` | `get/set` | Yes | `` |
| `DrawGrid` | `Boolean` | `get/set` | No | `` |
| `Driver` | `DriverName` | `get/set` | Yes | `` |
| `DynamicGripsMenu` | `Boolean` | `get/set` | No | `` |
| `EnablePointerInput` | `Boolean` | `get/set` | Yes | `` |
| `FillFrame` | `Boolean` | `get/set` | Yes | `` |
| `FillTransparent` | `Int32` | `get/set` | Yes | `` |
| `GridMajor` | `Int32` | `get/set` | No | `` |
| `GridStepX` | `Double` | `get/set` | No | `` |
| `GridStepY` | `Double` | `get/set` | No | `` |
| `GripBorderColor` | `CadColor` | `get/set` | Yes | `` |
| `GripBoxSize` | `Int32` | `get/set` | Yes | `` |
| `HighlightedGripColor` | `CadColor` | `get/set` | Yes | `` |
| `HintBackColor` | `CadColor` | `get/set` | Yes | `` |
| `HintBackColorValue` | `Color` | `get` | Yes | `` |
| `HintBorderColor` | `CadColor` | `get/set` | Yes | `` |
| `HintBorderColorValue` | `Color` | `get` | Yes | `` |
| `HintForeColor` | `CadColor` | `get/set` | Yes | `` |
| `HintForeColorValue` | `Color` | `get` | Yes | `` |
| `HintTransparent` | `Int32` | `get/set` | Yes | `` |
| `IntersectColor` | `CadColor` | `get/set` | Yes | `` |
| `Isometric` | `Boolean` | `get/set` | No | `` |
| `LayerSelectMode` | `LayerSelectMode` | `get/set` | Yes | `` |
| `MenuClickDuration` | `Int32` | `get/set` | Yes | `` |
| `Multisampling` | `Boolean` | `get/set` | Yes | `` |
| `NormalGripColor` | `CadColor` | `get/set` | Yes | `` |
| `ObjectSnap` | `ObjectSnapFlags` | `get/set` | Yes | `` |
| `Ortho` | `Boolean` | `get/set` | No | `` |
| `OSnap` | `Boolean` | `get/set` | Yes | `` |
| `OTracking` | `Boolean` | `get/set` | Yes | `` |
| `OTrackingOrthoOnly` | `Boolean` | `get/set` | Yes | `` |
| `PointerInputVisibility` | `UInt16` | `get/set` | Yes | `` |
| `PolarTracking` | `Boolean` | `get/set` | Yes | `` |
| `PolarTrackingAdditionalAngles` | `Boolean` | `get/set` | Yes | `` |
| `PolarTrackingAngleStep` | `Double` | `get/set` | Yes | `` |
| `SelectedGripColor` | `CadColor` | `get/set` | Yes | `` |
| `SelectingCirclingBoardAlignment` | `DynamicBoardAlignment` | `get/set` | Yes | `` |
| `SelectingCirclingBoardLocation` | `Point` | `get/set` | Yes | `` |
| `SelectingCirclingBoardOffset` | `Int32` | `get/set` | Yes | `` |
| `SelectingCirclingDisplayHeader` | `Boolean` | `get/set` | Yes | `` |
| `SelectionCircling` | `Boolean` | `get/set` | Yes | `` |
| `SelectMode` | `ContextMenuBehavior` | `get/set` | Yes | `` |
| `SnapColor` | `CadColor` | `get/set` | Yes | `` |
| `SnapDrawSize` | `Int32` | `get/set` | Yes | `` |
| `SnapLookupSize` | `Single` | `get/set` | Yes | `` |
| `SSnap` | `Boolean` | `get/set` | No | `` |
| `StepX` | `Double` | `get/set` | No | `` |
| `StepY` | `Double` | `get/set` | No | `` |
| `UnselectMode` | `ContextMenuBehavior` | `get/set` | Yes | `` |
| `UseContextMenu` | `Boolean` | `get/set` | Yes | `` |
| `UseDoubleClick` | `Boolean` | `get/set` | Yes | `` |
| `UseDynamicSearchFrame` | `Boolean` | `get/set` | Yes | `` |
| `UseMenuClickDuration` | `Boolean` | `get/set` | Yes | `` |
| `UseSearchFrame` | `Boolean` | `get/set` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `DraftingSettings settings` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `StaticLoadFromStg` | `Void` | `StgNode node` | `` |
| `StaticSaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DrawCursorEvent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.DrawCursorEvent` |
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
      - `Topomatic.Cad.View.DrawCursorEvent`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `CadPen pen, Vector3D vertex, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `CadPen pen, Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DriverName` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.DriverName` |
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
      - `Topomatic.Cad.View.DriverName`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Compatibility` | `DriverName` | Yes | `Compatibility` | `` |
| `Default` | `DriverName` | Yes | `Default` | `` |
| `Gdiplus` | `DriverName` | Yes | `Gdiplus` | `` |
| `OpenGL` | `DriverName` | Yes | `OpenGL` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `OpenGL` | `1` |
| `Gdiplus` | `2` |
| `Compatibility` | `3` |

**Underlying Type**: `System.Int32`

### `DynamicBoardAlignment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.DynamicBoardAlignment` |
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
      - `Topomatic.Cad.View.DynamicBoardAlignment`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BottomLeft` | `DynamicBoardAlignment` | Yes | `BottomLeft` | `` |
| `BottomRight` | `DynamicBoardAlignment` | Yes | `BottomRight` | `` |
| `Fixed` | `DynamicBoardAlignment` | Yes | `Fixed` | `` |
| `TopLeft` | `DynamicBoardAlignment` | Yes | `TopLeft` | `` |
| `TopRight` | `DynamicBoardAlignment` | Yes | `TopRight` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TopRight` | `0` |
| `TopLeft` | `1` |
| `BottomRight` | `2` |
| `BottomLeft` | `3` |
| `Fixed` | `255` |

**Underlying Type**: `System.Byte`

### `FreeOrbitCamera` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Panel3d+FreeOrbitCamera` |
| **Base Type** | `Topomatic.Cad.View.Panel3d+TransformationStyleCamera` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Panel3d+TransformationStyleCamera`
    - `Topomatic.Cad.View.Panel3d+FreeOrbitCamera`

#### Constructors (1)

- `.ctor(Panel3d panel)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Speed` | `Single` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnKeyDown` | `Void` | `KeyEventArgs e` | `` |
| `OnKeyPress` | `Void` | `KeyPressEventArgs e` | `` |
| `OnKeyUp` | `Void` | `KeyEventArgs e` | `` |
| `OnMouseDoubleClick` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseDown` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseMove` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseUp` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseWheel` | `Void` | `MouseEventArgs e` | `` |
| `OnPaint` | `Void` | `DeviceContext dc` | `` |
| `OnUpdate` | `Void` | `Single time` | `` |
| `SolveLimmits` | `Void` | `` | `` |
| `ZoomIn` | `Void` | `Double scale` | `` |
| `ZoomOut` | `Void` | `Double scale` | `` |

### `FullDeviceContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.FullDeviceContext` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Cad.View.FullDeviceContext`

#### Constructors (1)

- `.ctor(CadView cadview)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawn` | `Boolean` | `get/set` | No | `` |
| `FullDrawn` | `Boolean` | `get/set` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `Projection` | `Matrix` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `BeginClip` | `Void` | `` | `` |
| `BeginRender` | `Void` | `` | `` |
| `EndClip` | `Void` | `` | `` |
| `gRaster` | `Void` | `IRasterReference rst` | `` |
| `gString` | `Void` | `Font font, String text` | `` |
| `SetClipRect` | `Void` | `RectangleD value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GetPointResult` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.GetPointResult` |
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
      - `Topomatic.Cad.View.GetPointResult`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Accept` | `GetPointResult` | Yes | `Accept` | `` |
| `Cancel` | `GetPointResult` | Yes | `Cancel` | `` |
| `UserCmd` | `GetPointResult` | Yes | `UserCmd` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Cancel` | `0` |
| `Accept` | `1` |
| `UserCmd` | `2` |

**Underlying Type**: `System.Int32`

### `GraphicsDeviceContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.GraphicsDeviceContext` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Cad.View.GraphicsDeviceContext`

#### Constructors (1)

- `.ctor(Graphics graphics)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BrushStyle` | `BrushStyle` | `get/set` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `Projection` | `Matrix` | `get/set` | No | `` |
| `Round` | `Boolean` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count, Boolean mult` | `` |
| `BeginClip` | `Void` | `` | `` |
| `BeginRender` | `Void` | `` | `` |
| `EndClip` | `Void` | `` | `` |
| `gString` | `Void` | `Font font, String text` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateOrtho` | `GraphicsDeviceContext` | `Graphics graphics, BoundingBox2D bounds, Single width, Single height` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Grip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Grip` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadview)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `KeyValuePair<String String>` | `get/set` | No | `` |
| `GripAction` | `GripAction` | `get/set` | No | `` |
| `GripType` | `GripType` | `get/set` | No | `` |
| `Location` | `Vector3D` | `get/set` | No | `` |
| `Owner` | `Grip` | `get` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddGrip` | `Void` | `String caption, String keyword, IGrip grip` | `` |
| `GetLocation` | `Vector3D` | `CadView cadview` | `` |
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnHighlight` | `Void` | `PaintGripEventArgs e` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `DynamicRender` | `RenderCursorEventHandler` | No | `` |
| `Move` | `Action<Vector3D>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `GetLocation` |
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |
| `IGrip` | `OnHighlight` |
| `IGrip` | `OnCreateMenu` |

### `GripAction` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.GripAction` |
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
      - `Topomatic.Cad.View.GripAction`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `GripAction` | Yes | `Default` | `` |
| `DragAndDrop` | `GripAction` | Yes | `DragAndDrop` | `` |
| `MoveGrip` | `GripAction` | Yes | `MoveGrip` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `MoveGrip` | `1` |
| `DragAndDrop` | `2` |

**Underlying Type**: `System.Int32`

### `GripState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.GripState` |
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
      - `Topomatic.Cad.View.GripState`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Highlighted` | `GripState` | Yes | `Highlighted` | `` |
| `Normal` | `GripState` | Yes | `Normal` | `` |
| `Selected` | `GripState` | Yes | `Selected` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Normal` | `0` |
| `Highlighted` | `1` |
| `Selected` | `2` |

**Underlying Type**: `System.Int32`

### `GripType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.GripType` |
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
      - `Topomatic.Cad.View.GripType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arrow` | `GripType` | Yes | `Arrow` | `` |
| `Rectangular` | `GripType` | Yes | `Rectangular` | `` |
| `RotationRound` | `GripType` | Yes | `RotationRound` | `` |
| `Round` | `GripType` | Yes | `Round` | `` |
| `Simple` | `GripType` | Yes | `Simple` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Simple` | `0` |
| `Arrow` | `1` |
| `Round` | `2` |
| `Rectangular` | `3` |
| `RotationRound` | `4` |

**Underlying Type**: `System.Int32`

### `ICadViewForm` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ICadViewForm` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `` |

### `IGrip` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.IGrip` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLocation` | `Vector3D` | `CadView cadview` | `` |
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `OnHighlight` | `Void` | `PaintGripEventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |

### `IModelLayer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.IModelLayer` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.ILayer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Model` | `Object` | `get/set` | No | `` |

### `IntegralLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.IntegralLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IEnumerable<ILayer> layers)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `MergeLayers` | `IEnumerable<ILayer>` | `IEnumerable<ILayer> collection` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |

### `InvokeActionEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.InvokeActionEventHandler` |
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
      - `Topomatic.Cad.View.InvokeActionEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `String uid, Object[] objects, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Object` | `IAsyncResult result` | `` |
| `Invoke` | `Object` | `String uid, Object[] objects` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LayerSelectMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.LayerSelectMode` |
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
      - `Topomatic.Cad.View.LayerSelectMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Multi` | `LayerSelectMode` | Yes | `Multi` | `` |
| `Single` | `LayerSelectMode` | Yes | `Single` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Single` | `0` |
| `Multi` | `1` |

**Underlying Type**: `System.Int32`

### `MultiLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.MultiLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Cad.View.IModelLayer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.MultiLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `CadViewLayer` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Model` | `Object` | `get/set` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `CadViewLayer layer` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<CadViewLayer>` | `` | `` |
| `GetReverseEnumerator` | `IEnumerable<CadViewLayer>` | `` | `` |
| `GetReverseEnumerator` | `IEnumerable<CadViewLayer>` | `Int32 last` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `MoveDown` | `Boolean` | `CadViewLayer layer` | `` |
| `MoveUp` | `Boolean` | `CadViewLayer layer` | `` |
| `Remove` | `Void` | `CadViewLayer layer` | `` |
| `ResolveActive` | `CadViewLayer` | `` | `` |
| `SortLayers` | `Void` | `Comparison<CadViewLayer> comparison` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `ActiveLayerChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `GetSubLayers` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IModelLayer` | `get_Model` |
| `IModelLayer` | `set_Model` |
| `ILayerActivityController` | `Topomatic.FoundationClasses.ILayerActivityController.get_ActiveLayer` |
| `ILayerActivityController` | `Topomatic.FoundationClasses.ILayerActivityController.set_ActiveLayer` |
| `ILayerActivityController` | `Topomatic.FoundationClasses.ILayerActivityController.RemoveLayer` |

### `MultiLayerSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.MultiLayerSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Cad.View.MultiLayerSelectionSet`

#### Constructors (1)

- `.ctor(MultiLayer layer)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `SupportClipboard` | `Boolean` | `get` | No | `` |
| `SupportCopyTransform` | `Boolean` | `get` | No | `` |
| `SupportDragAndDrop` | `Boolean` | `get` | No | `` |
| `SupportTransform` | `Boolean` | `get` | No | `` |

#### Instance Methods (34)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Align` | `Void` | `Object data, Vector2D sourceA, Vector2D sourceB, Vector2D destA, Vector2D destB, Boolean scale, Boolean copy` | `` |
| `Clear` | `Void` | `` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `DragDrop` | `Boolean` | `String path` | `` |
| `DragOver` | `Boolean` | `String path` | `` |
| `Erase` | `Void` | `` | `` |
| `FilterSelected` | `Void` | `Predicate<Object> match` | `` |
| `FindOwner` | `CadViewLayer` | `Object obj` | `` |
| `FindOwner` | `CadViewLayer` | `Object obj, Boolean top` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtFrustum` | `IEnumerable<KeyValuePair<Vector3D Object>>` | `BoundingFrustum frustum, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtRay` | `IEnumerable<KeyValuePair<Double Object>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `GetTransformData` | `Object` | `` | `` |
| `GetTrianglesAtRay` | `IEnumerable<KeyValuePair<Double Triangle3D>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Mirror` | `Void` | `Object data, Vector2D a, Vector2D b, Boolean copy` | `` |
| `Move` | `Void` | `Object data, Double x, Double y, Double z, Boolean copy` | `` |
| `PaintTransformData` | `Void` | `Object data, CadPen pen` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Rotate` | `Void` | `Object data, Vector2D basePoint, Double rotationAngle, Boolean copy` | `` |
| `Scale` | `Void` | `Object data, Vector2D basePoint, Double scaleFactorX, Double scaleFactorY, Boolean copy` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `SelectByFrame` | `Boolean` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Boolean select` | `` |
| `SelectByPolygon` | `Boolean` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `NullDeviceContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.NullDeviceContext` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Cad.View.NullDeviceContext`

#### Constructors (1)

- `.ctor(CadView cadview, Boolean supportRasterGraphics)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DistanceSquared` | `Double` | `get` | No | `` |
| `Found` | `Boolean` | `get/set` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `Projection` | `Matrix` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `BeginClip` | `Void` | `` | `` |
| `BeginRender` | `Void` | `` | `` |
| `EndClip` | `Void` | `` | `` |
| `gRaster` | `Void` | `IRasterReference rst` | `` |
| `gString` | `Void` | `Font font, String text` | `` |
| `SetClipRect` | `Void` | `RectangleD value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `NullDeviceContext3D` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.NullDeviceContext3D` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Cad.View.NullDeviceContext3D`

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DistanceSquared` | `Double` | `get` | No | `` |
| `Found` | `Boolean` | `get/set` | No | `` |
| `FoundedTriangle` | `Nullable<Triangle3D>` | `get` | No | `` |
| `LocalRay` | `Ray3D` | `get` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `Ray` | `Ray3D` | `get/set` | No | `` |
| `SearchRadius` | `Double` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `BeginClip` | `Void` | `` | `` |
| `EndClip` | `Void` | `` | `` |
| `gString` | `Void` | `Font font, String text` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateLocalRay` | `Ray3D` | `Matrix world, Ray3D ray, Vector3D pivot` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ObjectSnapEventArgs` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ObjectSnapEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.ObjectSnapEventArgs`

#### Constructors (1)

- `.ctor(ObjectSnaps snaps, Vector3D sourcePoint, Nullable<Vector3D> firstLinePoint, BoundingBox2D bounds)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `FirstLinePoint` | `Nullable<Vector3D>` | `get` | No | `` |
| `SnapObjects` | `List<IObjectDisjoiner>` | `get` | No | `` |
| `SourcePoint` | `Vector3D` | `get` | No | `` |
| `SourceSnaps` | `ObjectSnaps` | `get` | No | `` |

### `ObjectSnapEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ObjectSnapEventHandler` |
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
      - `Topomatic.Cad.View.ObjectSnapEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, ObjectSnapEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, ObjectSnapEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ObjectSnapFlags` (enum)

**Attributes**: [ComVisible, Flags, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ObjectSnapFlags` |
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
      - `Topomatic.Cad.View.ObjectSnapFlags`

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `ObjectSnapFlags` | Yes | `Center` | `` |
| `Default` | `ObjectSnapFlags` | Yes | `Default` | `` |
| `EndPoint` | `ObjectSnapFlags` | Yes | `EndPoint` | `` |
| `Extension` | `ObjectSnapFlags` | Yes | `Extension` | `` |
| `Insertion` | `ObjectSnapFlags` | Yes | `Insertion` | `` |
| `Intersection` | `ObjectSnapFlags` | Yes | `Intersection` | `` |
| `MarkerSnap` | `ObjectSnapFlags` | Yes | `MarkerSnap` | `` |
| `MiddlePoint` | `ObjectSnapFlags` | Yes | `MiddlePoint` | `` |
| `Nearest` | `ObjectSnapFlags` | Yes | `Nearest` | `` |
| `Node` | `ObjectSnapFlags` | Yes | `Node` | `` |
| `None` | `ObjectSnapFlags` | Yes | `None` | `` |
| `Ortho` | `ObjectSnapFlags` | Yes | `Ortho` | `` |
| `Parallel` | `ObjectSnapFlags` | Yes | `Parallel` | `` |
| `Perpendicular` | `ObjectSnapFlags` | Yes | `Perpendicular` | `` |
| `Quadrant` | `ObjectSnapFlags` | Yes | `Quadrant` | `` |
| `Tangent` | `ObjectSnapFlags` | Yes | `Tangent` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `EndPoint` | `1` |
| `MiddlePoint` | `2` |
| `Center` | `4` |
| `Node` | `8` |
| `Quadrant` | `16` |
| `Intersection` | `32` |
| `Extension` | `64` |
| `Insertion` | `128` |
| `Perpendicular` | `256` |
| `Tangent` | `512` |
| `Nearest` | `1024` |
| `Default` | `1253` |
| `Parallel` | `2048` |
| `Ortho` | `4096` |
| `MarkerSnap` | `-1` |

**Underlying Type**: `System.Int32`

### `ObjectSnaps` (class)

**Attributes**: [ComVisible, DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.ObjectSnaps` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ObjectSnapFlags[] args)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Flags` | `ObjectSnapFlags` | `get/set` | No | `` |
| `Item` | `Boolean` | `get/set` | No | `` |
| `Terminated` | `Boolean` | `get` | No | `` |

### `OpenglDeviceContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.OpenglDeviceContext` |
| **Base Type** | `Topomatic.Cad.View.CadViewDeviceContext` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Cad.View.CadViewDeviceContext`
      - `Topomatic.Cad.View.OpenglDeviceContext`

#### Constructors (1)

- `.ctor(Control cadview)`

#### Properties (32)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackColor` | `Color` | `get/set` | No | `` |
| `BrushStyle` | `BrushStyle` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `` |
| `CompatabilityGraphics` | `Boolean` | `get/set` | No | `` |
| `DepthBias` | `Single` | `get/set` | No | `` |
| `DepthMask` | `Boolean` | `get/set` | No | `` |
| `DepthTest` | `Boolean` | `get/set` | No | `` |
| `FrontFaceCW` | `Boolean` | `get/set` | No | `` |
| `Light0` | `Vector3F` | `get/set` | No | `` |
| `LightDirection` | `Vector3F` | `get/set` | No | `` |
| `LightEnable` | `Boolean` | `get/set` | No | `` |
| `MaterialAmbint` | `Vector3F` | `get/set` | No | `` |
| `MaterialDiffuse` | `Vector3F` | `get/set` | No | `` |
| `MaterialShininess` | `Single` | `get/set` | No | `` |
| `MaterialSpecular` | `Vector3F` | `get/set` | No | `` |
| `MaterialTransparency` | `Single` | `get/set` | No | `` |
| `Model` | `Matrix` | `get/set` | No | `` |
| `Multisampling` | `Boolean` | `get/set` | No | `` |
| `Normal` | `Vector3F` | `get/set` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `PointSmooth` | `Boolean` | `get/set` | No | `` |
| `PolygonOffset` | `Boolean` | `get/set` | No | `` |
| `Projection` | `Matrix` | `get/set` | No | `` |
| `Shader` | `ShaderType` | `get/set` | No | `` |
| `SupportRenderTexture` | `Boolean` | `get` | No | `` |
| `Terminated` | `Boolean` | `get` | No | `` |
| `Texture0` | `Texture` | `get/set` | No | `` |
| `Thickness` | `Single` | `get/set` | No | `` |
| `VertexBuffer` | `VertexBuffer` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `WireFrame` | `Boolean` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `BeginClip` | `Void` | `` | `` |
| `BegingRenderTexture` | `Void` | `` | `` |
| `BeginRender` | `Void` | `` | `` |
| `ClearDepth` | `Void` | `` | `` |
| `DrawPrimitives` | `Void` | `PrimitiveType primitiveType, Int32 count` | `` |
| `EndClip` | `Void` | `` | `` |
| `EndRender` | `Void` | `` | `` |
| `EndRenderTexture` | `Void` | `` | `` |
| `FlushSimplify` | `Void` | `` | `` |
| `gString` | `Void` | `Font font, String text` | `` |
| `OnDrawUserIndexedPrimitives` | `Void` | `PrimitiveType primitiveType, Vector3F[] vertexData, Vector3F[] normalData, Byte[] colorData, Int32 vertexOffset, Int32 numVertices, Int32[] indexData, Int32 indexOffset, Int32 primitiveCount` | `` |
| `OnDrawUserIndexedPrimitives` | `Void` | `PrimitiveType primitiveType, Vector3F[] vertexData, Vector3F[] normalData, Int32 vertexOffset, Int32 numVertices, Int32[] indexData, Int32 indexOffset, Int32 primitiveCount` | `` |
| `RenderTexture` | `Void` | `Single xoffset, Single yoffset` | `` |
| `SimplifyBounds3d` | `Void` | `BoundingBox3D bounds, Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PaintGripEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.PaintGripEventArgs` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DeviceContext dc, GripState state, Double screenRotation)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DeviceContext` | `DeviceContext` | `get` | No | `` |
| `ScreenRotation` | `Double` | `get` | No | `` |
| `State` | `GripState` | `get` | No | `` |

### `Panel3d` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Panel3d` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Cad.View.Panel3d`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AspectRatio` | `Single` | `get` | No | `` |
| `BoundingBox` | `BoundingBox3D` | `get` | No | `` |
| `BoundingSphere` | `BoundingSphere3D` | `get` | No | `` |
| `Camera` | `TransformationStyleCamera` | `get/set` | No | `` |
| `DynamicHighlight` | `Boolean` | `get/set` | No | `` |
| `FieldOfView` | `Single` | `get/set` | No | `` |
| `IsPerspective` | `Boolean` | `get/set` | No | `` |
| `LastMousePoint` | `Point` | `get` | No | `` |
| `Mode` | `RenderMode` | `get/set` | No | `` |
| `Multisampling` | `Boolean` | `get/set` | No | `` |
| `PerspectiveSize` | `Single` | `get` | No | `` |
| `Projection` | `Matrix` | `get` | No | `` |
| `RedrawRequested` | `Boolean` | `get/set` | No | `` |
| `Simplify` | `Boolean` | `get/set` | No | `` |
| `Terminated` | `Boolean` | `get` | No | `` |
| `VerticalScale` | `Single` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `ViewHeight` | `Single` | `get/set` | No | `` |
| `ViewWidth` | `Single` | `get` | No | `` |
| `World` | `Matrix` | `get` | No | `` |
| `WorldView` | `Matrix` | `get` | No | `` |
| `WorldViewProjection` | `Matrix` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `BoundingBox3D` | `` | `` |
| `GetTransformedBoundingSphere` | `BoundingSphere3D` | `Matrix matrix` | `` |
| `Project` | `Vector3D` | `Vector3D source, Matrix wvp` | `` |
| `RequestRedraw` | `Void` | `` | `` |
| `ResetTimer` | `Void` | `` | `` |
| `ResetViewHeight` | `Void` | `` | `` |
| `Unlock` | `Void` | `` | `` |
| `Unproject` | `Vector3D` | `Vector3D source, Matrix wvp` | `` |

#### Events (3)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `CreateMenu` | `CreateMenuEventHandler` | No | `` |
| `DynamicRender` | `RenderCursor3dEventHandler` | No | `` |
| `StaticRender` | `RenderCursor3dEventHandler` | No | `` |

#### Nested Types (4)

- `BimCamera` (class)
- `FreeOrbitCamera` (class)
- `RenderMode` (enum)
- `TransformationStyleCamera` (abstract class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RenderCursor3dEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.RenderCursor3dEventHandler` |
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
      - `Topomatic.Cad.View.RenderCursor3dEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `DeviceContext dc, Ray3D ray, BoundingFrustum frustum, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `DeviceContext dc, Ray3D ray, BoundingFrustum frustum` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RenderCursorEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.RenderCursorEventHandler` |
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
      - `Topomatic.Cad.View.RenderCursorEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `DeviceContext dc, Vector3D position, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `DeviceContext dc, Vector3D position` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RenderEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.RenderEventHandler` |
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
      - `Topomatic.Cad.View.RenderEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `DeviceContext dc, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `DeviceContext dc` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RenderMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Panel3d+RenderMode` |
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
      - `Topomatic.Cad.View.Panel3d+RenderMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Solid` | `RenderMode` | Yes | `Solid` | `` |
| `Textured` | `RenderMode` | Yes | `Textured` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Wireframe` | `RenderMode` | Yes | `Wireframe` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Wireframe` | `0` |
| `Solid` | `1` |
| `Textured` | `2` |

**Underlying Type**: `System.Int32`

### `SelectionSet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.SelectionSet` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadViewLayer layer)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Layer` | `CadViewLayer` | `get` | No | `` |
| `SupportClipboard` | `Boolean` | `get` | No | `` |
| `SupportCopyTransform` | `Boolean` | `get` | No | `` |
| `SupportDragAndDrop` | `Boolean` | `get` | No | `` |
| `SupportTransform` | `Boolean` | `get` | No | `` |

#### Instance Methods (46)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Align` | `Void` | `Object data, Vector2D sourceA, Vector2D sourceB, Vector2D destA, Vector2D destB, Boolean scale, Boolean copy` | `` |
| `BeginSelect` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `CopyFrom` | `Void` | `SelectionSet other, Matrix transform, Vector2D basePoint, Boolean select` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `DragDrop` | `Boolean` | `String path` | `` |
| `DragOver` | `Boolean` | `String path` | `` |
| `EndSelect` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `FilterSelected` | `Void` | `Predicate<Object> match` | `` |
| `FindOwner` | `CadViewLayer` | `Object obj` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetMultipleObjectsAtPoint` | `List<Object>` | `Vector3D point, Predicate<Object> match, ref Int32 nearest` | `` |
| `GetObjectAtPoint` | `Object` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut, ref Boolean multiple` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtFrustum` | `IEnumerable<KeyValuePair<Vector3D Object>>` | `BoundingFrustum frustum, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtRay` | `IEnumerable<KeyValuePair<Double Object>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `GetTransformData` | `Object` | `` | `` |
| `GetTrianglesAtRay` | `IEnumerable<KeyValuePair<Double Triangle3D>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Mirror` | `Void` | `Object data, Vector2D a, Vector2D b, Boolean copy` | `` |
| `Move` | `Void` | `Object data, Double x, Double y, Double z, Boolean copy` | `` |
| `PaintTransformData` | `Void` | `Object data, CadPen pen` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `PickOneObjectAtScreen` | `Object` | `Predicate<Object> match, String message` | `` |
| `PickOneObjectAtScreen` | `GetPointResult` | `Predicate<Object> match, ref Object obj, String message, String[] args` | `` |
| `Rotate` | `Void` | `Object data, Vector2D basePoint, Double rotationAngle, Boolean copy` | `` |
| `Scale` | `Void` | `Object data, Vector2D basePoint, Double scaleFactorX, Double scaleFactorY, Boolean copy` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `SelectAtPoint` | `Boolean` | `Vector2D point, Predicate<Object> match` | `` |
| `SelectByFrame` | `Boolean` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Boolean select` | `` |
| `SelectByPolygon` | `Boolean` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match` | `` |
| `SelectObjectsAtScreen` | `GetPointResult` | `Predicate<Object> match, String message, String[] args` | `` |
| `SelectObjectsAtScreen` | `Boolean` | `Predicate<Object> match, String message` | `` |
| `SelectOneObjectAtScreen` | `GetPointResult` | `Predicate<Object> match, ref Object obj, String message, String[] args` | `` |
| `SelectOneObjectAtScreen` | `Object` | `Predicate<Object> match, String message` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `SerializableDictionary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.SerializableDictionary` |
| **Base Type** | `System.Collections.Generic.Dictionary`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgSerializable, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IDictionary`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgSerializable, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[System.Collections.Generic.KeyValuePair`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgSerializable, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgSerializable, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgSerializable, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgSerializable, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.Dictionary`2[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Stg.IStgSerializable, Topomatic.Stg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.View.SerializableDictionary`

#### Constructors (1)

- `.ctor()` - **Default constructor**

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

### `SpecSymbol` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.SpecSymbol` |
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
      - `Topomatic.Cad.View.SpecSymbol`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BigDiamond` | `SpecSymbol` | Yes | `BigDiamond` | `` |
| `Circle` | `SpecSymbol` | Yes | `Circle` | `` |
| `Diamond` | `SpecSymbol` | Yes | `Diamond` | `` |
| `GripBox` | `SpecSymbol` | Yes | `GripBox` | `` |
| `Spot` | `SpecSymbol` | Yes | `Spot` | `` |
| `Square` | `SpecSymbol` | Yes | `Square` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Diamond` | `0` |
| `Spot` | `1` |
| `BigDiamond` | `2` |
| `Circle` | `3` |
| `Square` | `4` |
| `GripBox` | `5` |

**Underlying Type**: `System.Int32`

### `TransformationStyleCamera` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Panel3d+TransformationStyleCamera` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Panel3d panel)`

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnKeyDown` | `Void` | `KeyEventArgs e` | `` |
| `OnKeyPress` | `Void` | `KeyPressEventArgs e` | `` |
| `OnKeyUp` | `Void` | `KeyEventArgs e` | `` |
| `OnMouseDoubleClick` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseDown` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseMove` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseUp` | `Void` | `MouseEventArgs e` | `` |
| `OnMouseWheel` | `Void` | `MouseEventArgs e` | `` |
| `OnPaint` | `Void` | `DeviceContext dc` | `` |
| `OnUpdate` | `Void` | `Single time` | `` |

### `TrueTypeCadFont` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.TrueTypeCadFont` |
| **Base Type** | `Topomatic.Cad.Foundation.CadFont` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CadFont`
    - `Topomatic.Cad.View.TrueTypeCadFont`

#### Constructors (2)

- `.ctor(String name, String filepath)`
- `.ctor(FontFamily family, String name, String filepath)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |
| `FilePath` | `String` | `get` | No | `` |
| `Font` | `Font` | `get` | No | `` |
| `FontStyle` | `FontStyle` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.Cad.View.Controls`

### `BaseGridPanelManager` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.BaseGridPanelManager` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultProportion` | `Single` | `get` | No | `` |
| `OptimizeStationsOnDraw` | `Boolean` | `get/set` | No | `` |
| `Panel` | `SimpleGridPanel` | `get/set` | No | `` |
| `PanelProportion` | `Single` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get` | No | `` |
| `RootLayer` | `SimpleGridPanelMultiLayer` | `get` | No | `` |
| `ShowHelp` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddItem` | `Void` | `GridPanelItem item` | `` |
| `Contains` | `GridPanelItem` | `Guid id` | `` |
| `GenerateMouseEventArgs` | `GridPanelMouseEventArgs` | `GridPanelMouseEventArgs e` | `` |
| `GeneratePaintEventArgs` | `GridPanelPaintEventArgs` | `GridPanelPaintEventArgs e` | `` |
| `GeneratePopupMenuEventArgs` | `GridPanelPopupMenuEventArgs` | `GridPanelPopupMenuEventArgs e` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Paint` | `Void` | `PaintEventArgs e` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `UpdateLayers` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GridPanelItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.GridPanelItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(BaseGridPanelManager manger, String name, String description, Guid id, Int32 defaultOrder)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultOrder` | `Int32` | `get` | No | `` |
| `DefaultVisible` | `Boolean` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |

### `GridPanelLayerEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`

#### Constructors (1)

- `.ctor(CadView cadView, Rectangle clientBounds)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `Rectangle` | `get/set` | No | `` |
| `CadView` | `CadView` | `get/set` | No | `` |

### `GridPanelMouseEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.GridPanelMouseEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelMouseEventArgs`

#### Constructors (1)

- `.ctor(CadView cadView, Rectangle clientBounds, Int32 x, Int32 y, MouseButtons button, Boolean ctrlPressed)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Button` | `MouseButtons` | `get/set` | No | `` |
| `CtrlPressed` | `Boolean` | `get/set` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `` |
| `Location` | `Point` | `get` | No | `` |
| `ShowToolTip` | `Boolean` | `get/set` | No | `` |
| `ToolTipText` | `String` | `get/set` | No | `` |
| `X` | `Int32` | `get/set` | No | `` |
| `Y` | `Int32` | `get/set` | No | `` |

### `GridPanelPaintEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs`

#### Constructors (1)

- `.ctor(CadView cadView, Rectangle clientBounds, Graphics graphics, Font font, Boolean isWhiteBackColor)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Font` | `Font` | `get/set` | No | `` |
| `Graphics` | `Graphics` | `get/set` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `IsWhiteBackColor` | `Boolean` | `get/set` | No | `` |
| `LeftSmoothBorder` | `Int32` | `get` | No | `` |
| `RightSmoothBorder` | `Int32` | `get` | No | `` |
| `SmoothBorders` | `SmoothBorders` | `get` | No | `` |

### `GridPanelPopupMenuEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.GridPanelPopupMenuEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelPopupMenuEventArgs`

#### Constructors (1)

- `.ctor(CadView cadView, Rectangle clientBounds, Int32 x, Int32 y, MenuAction root)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Location` | `Point` | `get` | No | `` |
| `Root` | `MenuAction` | `get/set` | No | `` |
| `X` | `Int32` | `get/set` | No | `` |
| `Y` | `Int32` | `get/set` | No | `` |

### `IGridPanelLayer` (interface)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.IGridPanelLayer` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Height` | `Int32` | `get/set` | No | `` |
| `MinHeight` | `Int32` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMouseDown` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseMove` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseUp` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

### `ISimpleGridPanelManager` (interface)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.ISimpleGridPanelManager` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layers` | `IEnumerable<IGridPanelLayer>` | `get` | No | `` |
| `Panel` | `SimpleGridPanel` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanManage` | `Boolean` | `Object obj` | `` |
| `GenerateMouseEventArgs` | `GridPanelMouseEventArgs` | `GridPanelMouseEventArgs e` | `` |
| `GeneratePaintEventArgs` | `GridPanelPaintEventArgs` | `GridPanelPaintEventArgs e` | `` |
| `GeneratePopupMenuEventArgs` | `GridPanelPopupMenuEventArgs` | `GridPanelPopupMenuEventArgs e` | `` |

### `SimpleGridPanel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.SimpleGridPanel` |
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
            - `Topomatic.Cad.View.Controls.SimpleGridPanel`

#### Constructors (1)

- `.ctor(ICadViewForm cadViewForm)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackColor` | `Color` | `get/set` | No | `` |
| `CadView` | `CadView` | `get` | No | `` |
| `IsWhiteBackColor` | `Boolean` | `get` | No | `` |
| `Manager` | `BaseGridPanelManager` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultName` | `String` | Yes | `"GridPanel"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SimpleGridPanelLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelItem` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, String name, String description, Guid id, Int32 sortOrder)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultProportion` | `Single` | `get` | No | `` |
| `Height` | `Int32` | `get` | No | `` |
| `Proportion` | `Single` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMouseDown` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseMove` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseUp` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SimpleGridPanelMultiLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.SimpleGridPanelMultiLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelItem` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.Controls.GridPanelItem, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelMultiLayer`

#### Constructors (2)

- `.ctor(BaseGridPanelManager manager, String name, String description, Guid id, Int32 sortOrder)`
- `.ctor(BaseGridPanelManager manager, String name, String description, Guid id, Boolean defaultVisible, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddItem` | `Void` | `GridPanelItem item` | `` |
| `Contains` | `GridPanelItem` | `Guid id` | `` |
| `GetEnumerator` | `IEnumerator<GridPanelItem>` | `` | `` |
| `MoveItemDown` | `Void` | `Guid id` | `` |
| `MoveItemUp` | `Void` | `Guid id` | `` |
| `Sort` | `Void` | `Dictionary<Guid Int32> ordersDict` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SmoothBorders` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Controls.SmoothBorders` |
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
      - `Topomatic.Cad.View.Controls.SmoothBorders`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `SmoothBorders` | Yes | `All` | `` |
| `None` | `SmoothBorders` | Yes | `None` | `` |
| `Part` | `SmoothBorders` | Yes | `Part` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Part` | `1` |
| `All` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Cad.View.Design`

### `CadViewDesignUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.CadViewDesignUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnCadViewSelect` | `CadView` | `String alias` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossSectionCadViewAlias` | `String` | Yes | `"{706546A2-AAFB-4b3f-A8CD-54CEFC6D58F5}"` | `` |
| `DefaultCadViewAlias` | `String` | Yes | `"{18949D25-8843-468f-A309-B2D41C216F5E}"` | `` |
| `PlanCadViewAlias` | `String` | Yes | `"{2EFEDF5E-3A88-45e9-AC16-B39EBFA24B0F}"` | `` |
| `ProfileCadViewAlias` | `String` | Yes | `"{43493912-34DC-48e5-844C-4B58703526D6}"` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `CadViewSelect` | `CadViewSelectorEventHandler` | Yes | `` |

### `CadViewPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.CadViewPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.CadViewPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `` |

### `CadViewSelectorEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.CadViewSelectorEventHandler` |
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
      - `Topomatic.Cad.View.Design.CadViewSelectorEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `String alias, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `CadView` | `IAsyncResult result` | `` |
| `Invoke` | `CadView` | `String alias` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ColorsDropDownList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.ColorsDropDownList` |
| **Base Type** | `Topomatic.ComponentModel.Design.PropertyDropDownList` |
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
        - `Topomatic.ComponentModel.Design.PropertyDropDownList`
          - `Topomatic.Cad.View.Design.ColorsDropDownList`

#### Constructors (1)

- `.ctor(IPropertyWindowsFormsEditorService service, Object ownColor, CadColor layerColor, Boolean supportNoneColor, Boolean supportBackgoundColor, Boolean supportByBlockColor, Boolean supportByLayerColor)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DefaultDoubleConverter` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.DefaultDoubleConverter` |
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
        - `Topomatic.Cad.View.Design.DefaultDoubleConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GradeConverter` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.GradeConverter` |
| **Base Type** | `Topomatic.Cad.View.Design.DefaultDoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Cad.View.Design.DefaultDoubleConverter`
          - `Topomatic.Cad.View.Design.GradeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ModelFinderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.ModelFinderAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.View.Design.ModelFinderAttribute`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ModelTypes` | `String[]` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModelFinderProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.ModelFinderProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.ModelFinderProvider`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `ModelUidAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.ModelUidAttribute` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelFinderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.View.Design.ModelFinderAttribute`
        - `Topomatic.Cad.View.Design.ModelUidAttribute`

#### Constructors (3)

- `.ctor(String[] modelTypes)`
- `.ctor(String selfUidAliace, String[] modelTypes)`
- `.ctor(String selfUidAliace, Boolean hideSelf, String[] modelTypes)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HideSelf` | `Boolean` | `get` | No | `` |
| `SelfUidAliace` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModelUidLayerAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.ModelUidLayerAttribute` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelUidAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.View.Design.ModelFinderAttribute`
        - `Topomatic.Cad.View.Design.ModelUidAttribute`
          - `Topomatic.Cad.View.Design.ModelUidLayerAttribute`

#### Constructors (3)

- `.ctor(String[] modelTypes)`
- `.ctor(String selfUidAliace, String[] modelTypes)`
- `.ctor(String selfUidAliace, Boolean hideSelf, String[] modelTypes)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModelUidLayerProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.ModelUidLayerProvider` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelUidProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.ModelFinderProvider`
      - `Topomatic.Cad.View.Design.ModelUidProvider`
        - `Topomatic.Cad.View.Design.ModelUidLayerProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ModelUidProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.ModelUidProvider` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelFinderProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.ModelFinderProvider`
      - `Topomatic.Cad.View.Design.ModelUidProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RelativePathAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.RelativePathAttribute` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelFinderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.View.Design.ModelFinderAttribute`
        - `Topomatic.Cad.View.Design.RelativePathAttribute`

#### Constructors (2)

- `.ctor(String[] modelTypes)`
- `.ctor(Boolean hideSelf, String[] modelTypes)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HideSelf` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RelativePathLayerAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.RelativePathLayerAttribute` |
| **Base Type** | `Topomatic.Cad.View.Design.RelativePathAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.View.Design.ModelFinderAttribute`
        - `Topomatic.Cad.View.Design.RelativePathAttribute`
          - `Topomatic.Cad.View.Design.RelativePathLayerAttribute`

#### Constructors (2)

- `.ctor(String[] modelTypes)`
- `.ctor(Boolean hideSelf, String[] modelTypes)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RelativePathLayerProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.RelativePathLayerProvider` |
| **Base Type** | `Topomatic.Cad.View.Design.RelativePathProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.ModelFinderProvider`
      - `Topomatic.Cad.View.Design.RelativePathProvider`
        - `Topomatic.Cad.View.Design.RelativePathLayerProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RelativePathProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.RelativePathProvider` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelFinderProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.ModelFinderProvider`
      - `Topomatic.Cad.View.Design.RelativePathProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StationProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.StationProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.StationProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |
| `GetStationing` | `IStationing` | `Object instance` | `` |

### `StationProviderPkEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.StationProviderPkEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Cad.View.Design.StationProviderPkEditor`

#### Constructors (1)

- `.ctor(StationProviderPkProperty property)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `StationProviderPkProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.StationProviderPkProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.Cad.View.Design.StationProviderPkProperty`

#### Constructors (1)

- `.ctor(StationProvider provider, PropertyInfo property, Object instance, Object[] attributes)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `PropertyType` | `Type` | `get` | No | `` |
| `Provider` | `StationProvider` | `get` | No | `` |
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `SetValue` | `Void` | `Object value` | `` |

### `StationProviderPlusEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.StationProviderPlusEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Cad.View.Design.StationProviderPlusEditor`

#### Constructors (1)

- `.ctor(StationProviderPlusProperty property)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `StationProviderPlusProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Design.StationProviderPlusProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.Cad.View.Design.StationProviderPlusProperty`

#### Constructors (1)

- `.ctor(StationProvider provider, PropertyInfo property, Object instance, Object[] attributes)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Provider` | `StationProvider` | `get` | No | `` |
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `SetValue` | `Void` | `Object value` | `` |

---
## Namespace: `Topomatic.Cad.View.EditableItems`

### `EditableItemsController` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.EditableItems.EditableItemsController` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `EditableItem` | `get/set` | No | `` |
| `Keys` | `IEnumerable<EditableItemsKey>` | `get` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetColor` | `CadColor` | `ILayer layer` | `` |
| `GetColor` | `CadColor` | `ILayer layer, EditableItemsKey editableItemsKey` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<EditableItemsKey>` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLayer` | `ILayer` | `` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |
| `GetOrCreateItem` | `EditableItem` | `EditableItemsKey key` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrapper` | `EditableItemsWrapper` | `CadView cadView, EditableItemsKey key` | `` |
| `InvalidateCadView` | `Void` | `` | `` |
| `RemoveItem` | `Void` | `EditableItemsKey key` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IDisposable` | `Dispose` |

### `EditableItemsDrawer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `DrawLayer` | `Void` | `Boolean enabled, CadPen pen` | `` |
| `DrawLayer3D` | `Void` | `Boolean enabled, DeviceContext dc` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `EditableItemsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.EditableItems.EditableItemsLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.EditableItems.EditableItemsLayer`

#### Constructors (1)

- `.ctor(EditableItemsController controller, Guid guid)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Controller` | `EditableItemsController` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |

### `EditableItemsWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.EditableItems.EditableItemsWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(EditableItemsController controller, EditableItemsKey editableItemsKey)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Controller` | `EditableItemsController` | `get` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `SupportCopyProperties` | `Boolean` | `get` | No | `Browsable` |
| `SupportPasteProperties` | `Boolean` | `get` | No | `Browsable` |
| `WrappedKey` | `EditableItemsKey` | `get/set` | No | `Browsable` |
| `WrappedObject` | `EditableItem` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `OnErase` | `Void` | `` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ReadOnly` | `Boolean` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IWrapped`1` | `get_WrappedObject` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Cad.View.Hints`

### `AbsoluteCoordsLinearCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.AbsoluteCoordsLinearCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`
        - `Topomatic.Cad.View.Hints.AbsoluteCoordsLinearCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ValueX` | `DoubleHint` | `get` | No | `` |
| `ValueY` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

### `AngleHint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.AngleHint` |
| **Base Type** | `Topomatic.Cad.View.Hints.EditHint` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadHint`
      - `Topomatic.Cad.View.Hints.ReadOnlyHint`
        - `Topomatic.Cad.View.Hints.EditHint`
          - `Topomatic.Cad.View.Hints.AngleHint`

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CadCursor` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.CadCursor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadview)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `` |
| `DynamicPoint` | `Nullable<Vector3D>` | `get/set` | No | `` |
| `DynamicPoints` | `IEnumerable<Vector3D>` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `GetPointResult` | `CursorView cv` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

### `CadCursors` (static class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.CadCursors` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (37)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAngle` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double angle, String message, String[] args` | `` |
| `GetAngleWithDefault` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double angle, String message, String[] args` | `` |
| `GetBoolean` | `Boolean` | `CadView cadView, ref Boolean value, Nullable<Point> popPoint, String message` | `` |
| `GetCustomValue` | `GetPointResult` | `CadView cadview, ref String value, OnValidate validate, String message, String[] args` | `` |
| `GetCustomValueWithDefault` | `GetPointResult` | `CadView cadview, ref String value, OnValidate validate, String message, String[] args` | `` |
| `GetDouble` | `GetPointResult` | `CadView cadview, ref Double value, String message, String[] args` | `` |
| `GetDoubleWithDefault` | `GetPointResult` | `CadView cadview, ref Double value, String message, String[] args` | `` |
| `GetFixedAngleLegth` | `GetPointResult` | `CadView cadview, Vector3D basePoint, Double angle, ref Double length, String message, String[] args` | `` |
| `GetFrame` | `GetPointResult` | `CadView cadview, ref RectangleD rectangle, ref FrameSelectType SelectType, String message` | `` |
| `GetFrame` | `GetPointResult` | `CadView cadview, Vector3D startPoint, ref RectangleD rectangle, ref FrameSelectType selectType` | `` |
| `GetInteger` | `GetPointResult` | `CadView cadview, ref Int32 value, String message, String[] args` | `` |
| `GetIntegerWithDefault` | `GetPointResult` | `CadView cadview, ref Int32 value, String message, String[] args` | `` |
| `GetLength` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double length, String message, String[] args` | `` |
| `GetLengthWithDefault` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double length, String message, String[] args` | `` |
| `GetLine` | `GetPointResult` | `CadView cadview, Vector3D startPoint, ref Vector3D secondPoint, String message, String[] args` | `` |
| `GetLine` | `Boolean` | `CadView cadview, ref Vector3D startPoint, ref Vector3D endPoint, String message1, String message2` | `` |
| `GetObject` | `GetPointResult` | `CadView cadview, ref Vector3D point, String message, String[] args` | `` |
| `GetPlanOffset` | `GetPointResult` | `CadView cadview, Vector2D startPoint, ref Vector2D offset, String message, String[] args` | `` |
| `GetPoint` | `Boolean` | `CadView cadview, ref Vector3D pos, String message` | `` |
| `GetPoint` | `GetPointResult` | `CadView cadview, ref Vector3D point, String message, String[] args` | `` |
| `GetQuadrantAngle` | `GetPointResult` | `CadView cadview, Vector3D basePoint, Int32 quadrant, ref Double angle, String message, String[] args` | `` |
| `GetRegisteredLinearCursors` | `IEnumerable<Type>` | `` | `` |
| `GetRegisteredPointCursors` | `IEnumerable<Type>` | `` | `` |
| `GetRelativeAngle` | `GetPointResult` | `CadView cadview, Vector3D basePoint, Vector3D anglePoint, Boolean ccw, ref Double angle, String message, String[] args` | `` |
| `GetRelativeAngle` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double angle, String message, String[] args` | `` |
| `GetRelativeAngleWithDefault` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double angle, String message, String[] args` | `` |
| `GetScale` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double length, String message, String[] args` | `` |
| `GetScaleWithDefault` | `GetPointResult` | `CadView cadview, Nullable<Vector3D> basePoint, ref Double length, String message, String[] args` | `` |
| `GetSmoothPos` | `GetPointResult` | `CadView cadview, Vector3D sourcePos, ref Vector3D pos, String message, String[] args` | `` |
| `GetStation` | `GetPointResult` | `CadView cadview, Polyline3D polyline, ref Double station, String message, String[] args` | `` |
| `GetStationOffset` | `GetPointResult` | `CadView cadview, Polyline3D polyline, ref Double station, ref Double offset, String message, String[] args` | `` |
| `GetString` | `GetPointResult` | `CadView cadview, ref String value, String message, String[] args` | `` |
| `GetStringWithDefault` | `GetPointResult` | `CadView cadview, ref String value, String message, String[] args` | `` |
| `GetText` | `Boolean` | `CadView cadview, Vector3D location, ref String text, CadFont font, Double height, Double ratio, Double oblique, Boolean singleLine, TextJustify justify, Color color` | `` |
| `GetUserSelect` | `Boolean` | `CadView cadview, ref String select, Nullable<Point> popPoint, String message, String[] args` | `` |
| `RegisterLinearCursor` | `Void` | `Type type` | `` |
| `RegisterPointCursor` | `Void` | `Type type` | `` |

### `CadHint` (abstract class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.CadHint` |
| **Base Type** | `Topomatic.Cad.View.CadControl` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadHint`

#### Constructors (1)

- `.ctor(CadView cadview)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackColor` | `Color` | `get/set` | No | `` |
| `BorderColor` | `Color` | `get/set` | No | `` |
| `BorderThick` | `Int32` | `get/set` | No | `` |
| `Location` | `Point` | `get/set` | No | `` |
| `Menu` | `CadMenu` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `TextHeight` | `Int32` | `String s` | `` |
| `TextWidth` | `Int32` | `String s` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `CadMenu` (class)

**Attributes**: [DefaultMember, ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.CadMenu` |
| **Base Type** | `Topomatic.Cad.View.CadControl` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadMenu`

#### Constructors (2)

- `.ctor(CadHint owner)`
- `.ctor(CadHint owner, String[] args)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlwaysOnTop` | `Boolean` | `get/set` | No | `` |
| `CanModal` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `String` | `get` | No | `` |
| `Items` | `IList<String>` | `get` | No | `` |
| `Modal` | `Boolean` | `get/set` | No | `` |
| `Owner` | `CadHint` | `get` | No | `` |
| `Selected` | `Int32` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyFrom` | `Void` | `String[] args` | `` |
| `Dispose` | `Void` | `` | `` |
| `PopUp` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawBody` | `Void` | `IGraphics g, Rectangle rect, Image image` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Click` | `EventHandler<MenuActionEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `CustomLinearCursor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StartPoint` | `Vector3D` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLine` | `GetPointResult` | `Vector3D startPoint, ref Vector3D point` | `` |

### `CustomPointCursor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.CustomPointCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomPointCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPoint` | `GetPointResult` | `ref Vector3D point` | `` |

### `DeltaLinearCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.DeltaLinearCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`
        - `Topomatic.Cad.View.Hints.DeltaLinearCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DeltaXValue` | `DoubleHint` | `get` | No | `` |
| `DeltaYValue` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

### `DoubleHint` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.DoubleHint` |
| **Base Type** | `Topomatic.Cad.View.Hints.EditHint` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadHint`
      - `Topomatic.Cad.View.Hints.ReadOnlyHint`
        - `Topomatic.Cad.View.Hints.EditHint`
          - `Topomatic.Cad.View.Hints.DoubleHint`

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EditHint` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.EditHint` |
| **Base Type** | `Topomatic.Cad.View.Hints.ReadOnlyHint` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadHint`
      - `Topomatic.Cad.View.Hints.ReadOnlyHint`
        - `Topomatic.Cad.View.Hints.EditHint`

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadFocused` | `Boolean` | `get` | No | `` |
| `CanModal` | `Boolean` | `get` | No | `` |
| `ClearOnEdit` | `Boolean` | `get/set` | No | `` |
| `Focused` | `Boolean` | `get/set` | No | `` |
| `Location` | `Point` | `get/set` | No | `` |
| `Locked` | `Boolean` | `get/set` | No | `` |
| `Modal` | `Boolean` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Lock` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FrameCursor` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.FrameCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.FrameCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, Vector3D FirstPoint)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FirstPoint` | `Vector3D` | `get/set` | No | `` |
| `SecondPoint` | `Vector3D` | `get` | No | `` |
| `SelectType` | `FrameSelectType` | `get` | No | `` |
| `ValueX` | `DoubleHint` | `get` | No | `` |
| `ValueY` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFrame` | `GetPointResult` | `` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

### `FrameSelectType` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.FrameSelectType` |
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
      - `Topomatic.Cad.View.Hints.FrameSelectType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Contains` | `FrameSelectType` | Yes | `Contains` | `` |
| `Intersects` | `FrameSelectType` | Yes | `Intersects` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Contains` | `0` |
| `Intersects` | `1` |

**Underlying Type**: `System.Int32`

### `HintTextBox` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.HintTextBox` |
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
            - `Topomatic.Cad.View.Hints.HintTextBox`

#### Constructors (1)

- `.ctor(EditHint hint, Int32 selectionStart)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Editing` | `Boolean` | `get` | No | `` |
| `EditResult` | `HintTextBoxResult` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HintTextBoxResult` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.HintTextBoxResult` |
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
      - `Topomatic.Cad.View.Hints.HintTextBoxResult`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Disposed` | `HintTextBoxResult` | Yes | `Disposed` | `` |
| `Escape` | `HintTextBoxResult` | Yes | `Escape` | `` |
| `Return` | `HintTextBoxResult` | Yes | `Return` | `` |
| `TabBack` | `HintTextBoxResult` | Yes | `TabBack` | `` |
| `TabForward` | `HintTextBoxResult` | Yes | `TabForward` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Disposed` | `0` |
| `Return` | `1` |
| `Escape` | `2` |
| `TabForward` | `3` |
| `TabBack` | `4` |

**Underlying Type**: `System.Int32`

### `LineAngularCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.LineAngularCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`
        - `Topomatic.Cad.View.Hints.LineAngularCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleHint` | `AngleHint` | `get` | No | `` |
| `LengthHint` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

### `MessageCursor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CadCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Args` | `String[]` | `get` | No | `` |
| `Keywords` | `IList<KeyValuePair<String String>>` | `get` | No | `` |
| `Message` | `String` | `get` | No | `` |
| `MessageHint` | `ReadOnlyHint` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExtractShortestForm` | `String` | `String command` | `` |
| `GetValue` | `GetPointResult` | `CursorView cv` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

### `OnValidate` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.OnValidate` |
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
      - `Topomatic.Cad.View.Hints.OnValidate`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `String value, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Boolean` | `IAsyncResult result` | `` |
| `Invoke` | `Boolean` | `String value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanStationCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.PlanStationCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.PlanStationCursor`

#### Constructors (4)

- `.ctor(IStationingCurve curve, CadView cadView, String message, String[] args)`
- `.ctor(IStationingCurve curve, CadView cadView, String message, String[] args, Boolean showOffset)`
- `.ctor(IStationingCurve curve, CadView cadView, String message, String[] args, Boolean showOffset, Boolean linkToEnds)`
- `.ctor(ICurve curve, IStationing stationing, CadView cadView, String message, String[] args, Boolean showOffset, Boolean linkToEnds)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowOffset` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStationAndOffset` | `Boolean` | `ref Double station, ref Double offset` | `` |
| `GetValue` | `GetPointResult` | `ref Double station, ref Double offset` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D pos` | `` |
| `ToString` | `String` | `` | `` |

### `PointCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.PointCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomPointCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomPointCursor`
        - `Topomatic.Cad.View.Hints.PointCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ValueX` | `DoubleHint` | `get` | No | `` |
| `ValueY` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

### `ReadOnlyHint` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.ReadOnlyHint` |
| **Base Type** | `Topomatic.Cad.View.Hints.CadHint` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadHint`
      - `Topomatic.Cad.View.Hints.ReadOnlyHint`

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadFocused` | `Boolean` | `get` | No | `` |
| `FontColor` | `Color` | `get/set` | No | `` |
| `Icon` | `Image` | `get/set` | No | `` |
| `PostfixText` | `String` | `get/set` | No | `` |
| `PreffixText` | `String` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PreviewKeyDown` | `Void` | `CadPreviewKeyDownEventArgs e` | `` |
| `SetCanFocused` | `Void` | `Boolean value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RelativeAngularCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.RelativeAngularCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`
        - `Topomatic.Cad.View.Hints.RelativeAngularCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

### `SmoothPointCursor` (class)

**Attributes**: [Browsable, ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.SmoothPointCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`
        - `Topomatic.Cad.View.Hints.SmoothPointCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleHint` | `DoubleHint` | `get` | No | `` |
| `LengthHint` | `DoubleHint` | `get` | No | `` |
| `SecondPoint` | `Vector3D` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSecondPoint` | `Void` | `Vector3D pos` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `ToString` | `String` | `` | `` |

### `StationHint` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.StationHint` |
| **Base Type** | `Topomatic.Cad.View.Hints.EditHint` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadControl`
    - `Topomatic.Cad.View.Hints.CadHint`
      - `Topomatic.Cad.View.Hints.ReadOnlyHint`
        - `Topomatic.Cad.View.Hints.EditHint`
          - `Topomatic.Cad.View.Hints.StationHint`

#### Constructors (1)

- `.ctor(CadView cadView, IStationing stationing)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Station` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UserSelectCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.UserSelectCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.UserSelectCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetUserSelect` | `GetPointResult` | `ref String select, Point popPoint` | `` |

### `VerticalShiftCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Hints.VerticalShiftCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.CustomLinearCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.CustomLinearCursor`
        - `Topomatic.Cad.View.Hints.VerticalShiftCursor`

#### Constructors (1)

- `.ctor(CadView cadView, String message, String[] args)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Dynamic_Draw` | `DrawCursorEvent` | `get/set` | No | `` |
| `ShiftHint` | `DoubleHint` | `get` | No | `` |
| `ShiftValue` | `Double` | `get/set` | No | `` |
| `ValueX` | `DoubleHint` | `get` | No | `` |
| `ValueY` | `DoubleHint` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLine` | `GetPointResult` | `Nullable<Vector3D> startPoint, ref Double shiftValue, ref Vector3D point` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

---
## Namespace: `Topomatic.Cad.View.Tools`

### `Polyline2DCurveTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.View.Tools.Polyline2DCurveTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `IList<BugleVector2D> vectors, Boolean closed, CadView cadView` | `` |
| `PaintPolyline` | `Void` | `DeviceContext dc, Color color, IList<BugleVector2D> vectors, Boolean closed` | `` |
| `WrapGrip` | `IGrip` | `IList<BugleVector2D> e, Int32 gripCount, CadView cadview` | `` |

---
## Namespace: `Topomatic.Visualization`

### `ImAggregateExtentions` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImAggregateExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateLinearObjectPolyline` | `List<Vector3D>` | `ICurve curve, ILinearObject obj, Double u1, Double u2, Double offs` | `` |
| `CreatePolylineFromSmdxPolyline` | `IList<Vector2D>` | `ImAggregates value` | `` |
| `CreateProfilePolyline` | `List<Vector3D>` | `List<Vector3D> polyline, IElevationProvider surface` | `` |
| `CreateReliefPolyline` | `List<Vector3D>` | `List<Vector3D> polyline, IElevationProvider surface` | `` |
| `CreateSmdxManualPolyline` | `Object` | `IPolyline3D polyline, Matrix pivot` | `` |
| `CreateSmdxPolyline` | `Object` | `List<Vector3D> polyline, Matrix pivot` | `` |
| `CreateStationOffsetedPolyline` | `List<Vector3D>` | `ICurve curve, IList<KeyValuePair<Double Double>> so` | `` |
| `LinearObjectDescription` | `String` | `Object obj, String name, Vector2D a, Vector2D b` | `` |
| `PointObjectDescription` | `String` | `Object obj, String name, Vector2D position` | `` |
| `PositionPkDescription` | `String` | `Object obj, Vector2D position` | `` |
| `PositionPkDescription` | `String` | `Object obj, String name, Vector2D position` | `` |
| `PositionPkLengthDescription` | `String` | `Object obj, Vector2D a, Vector2D b` | `` |
| `PositionPkLengthDescription` | `String` | `Object obj, String name, Vector2D a, Vector2D b` | `` |
| `PositionPkLengthValue` | `ImAggregates` | `Object obj, Vector2D a, Vector2D b` | `` |
| `PositionPkLengthValue` | `ImAggregates` | `Object obj, Double station, Double length` | `` |
| `PositionPkPointDescription` | `String` | `Object obj, String name, Vector2D position` | `` |
| `PositionPkPointValue` | `ImAggregates` | `Object obj, Vector2D position, Nullable<Double> z` | `` |
| `PositionPkValue` | `ImAggregates` | `Object obj, Double station` | `` |
| `PositionPkValue` | `ImAggregates` | `Object obj, Vector2D position` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 126 |
| **Classes** | 80 |
| **Interfaces** | 5 |
| **Enums** | 15 |
| **Structs** | 0 |
| **Abstract Classes** | 19 |
| **Static Classes** | 7 |
| **Total Methods** | 638 |
| **Total Properties** | 469 |
| **Total Fields** | 91 |
| **Total Events** | 32 |
| **Total Constructors** | 110 |
| **Nested Types** | 4 |
| **Extension Methods** | 0 |


