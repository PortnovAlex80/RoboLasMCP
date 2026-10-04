# Topomatic.Alg.CogoController

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.CogoController` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.CogoController, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.CogoController.dll` |

---
## Namespace: `Topomatic.Alg.CogoController`

### `CogoControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.CogoControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.CogoController.CogoControllerPluginHost`

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

### `GripPurpose` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.GripPurpose` |
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
      - `Topomatic.Alg.CogoController.GripPurpose`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Selector` | `GripPurpose` | Yes | `Selector` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Variator` | `GripPurpose` | Yes | `Variator` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Variator` | `0` |
| `Selector` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.CogoController.Design`

### `ArcInputStruc` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.Design.ArcInputStruc` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PathItemType elem_To)`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DenySetLength` | `Boolean` | No | `` | `` |
| `DenySetRadius` | `Boolean` | No | `` | `` |
| `elemTo` | `PathItemType` | No | `` | `` |
| `FixedLength` | `Boolean` | No | `` | `` |
| `FixedRadius` | `Boolean` | No | `` | `` |
| `InputLength` | `Double` | No | `` | `` |
| `InputRadius` | `Double` | No | `` | `` |
| `Invert` | `Boolean` | No | `` | `` |
| `JoinPosHaveFiniteRadius` | `Boolean` | No | `` | `` |
| `JoinPosRadius` | `Double` | No | `` | `` |

### `ClothoidInputStruc` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.Design.ClothoidInputStruc` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PathItemType elem_To)`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DenySetLength` | `Boolean` | No | `` | `` |
| `DenySetRadius` | `Boolean` | No | `` | `` |
| `elemTo` | `PathItemType` | No | `` | `` |
| `FixedLength` | `Boolean` | No | `` | `` |
| `FixedRadius` | `Boolean` | No | `` | `` |
| `InputClothoidType` | `InputElemType` | No | `` | `` |
| `InputLength` | `Double` | No | `` | `` |
| `InputRadius` | `Double` | No | `` | `` |
| `JoinPosCenter` | `Vector2D` | No | `` | `` |
| `JoinPosHaveFiniteRadius` | `Boolean` | No | `` | `` |
| `JoinPosRadius` | `Double` | No | `` | `` |

### `InputElemType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.Design.InputElemType` |
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
      - `Topomatic.Alg.CogoController.Design.InputElemType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arc` | `InputElemType` | Yes | `Arc` | `` |
| `ClothoidBackward` | `InputElemType` | Yes | `ClothoidBackward` | `` |
| `ClothoidForward` | `InputElemType` | Yes | `ClothoidForward` | `` |
| `ClothoidTruncatedBackward` | `InputElemType` | Yes | `ClothoidTruncatedBackward` | `` |
| `ClothoidTruncatedForward` | `InputElemType` | Yes | `ClothoidTruncatedForward` | `` |
| `Segment` | `InputElemType` | Yes | `Segment` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Segment` | `0` |
| `Arc` | `1` |
| `ClothoidForward` | `2` |
| `ClothoidBackward` | `3` |
| `ClothoidTruncatedForward` | `4` |
| `ClothoidTruncatedBackward` | `5` |

**Underlying Type**: `System.Int32`

### `SegmentInputStruc` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.Design.SegmentInputStruc` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PathItemType elem_To, Double inputAngle)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearAllCmds` | `Void` | `` | `` |

#### Fields (14)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cmdAngleDirLen` | `Boolean` | No | `` | `` |
| `cmdAngleOXLen` | `Boolean` | No | `` | `` |
| `cmdAngleTurnLen` | `Boolean` | No | `` | `` |
| `cmdCoords` | `Boolean` | No | `` | `` |
| `cmdCoordsDiff` | `Boolean` | No | `` | `` |
| `DenySetLength` | `Boolean` | No | `` | `` |
| `DirectEndPos` | `Vector2D` | No | `` | `` |
| `DirectInput` | `Boolean` | No | `` | `` |
| `elemTo` | `PathItemType` | No | `` | `` |
| `FixedLength` | `Boolean` | No | `` | `` |
| `FromPos` | `Vector2D` | No | `` | `` |
| `InputAngle` | `Double` | No | `` | `` |
| `InputLength` | `Double` | No | `` | `` |
| `JoinPosHaveFiniteRadius` | `Boolean` | No | `` | `` |

---
## Namespace: `Topomatic.Alg.CogoController.Dialogs.Input`

### `GetFixValueDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.Dialogs.Input.GetFixValueDlg` |
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
                  - `Topomatic.Alg.CogoController.Dialogs.Input.GetFixValueDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `Void` | `ref Double value, ref Boolean fix` | `` |
| `SetCaption` | `Void` | `String capt` | `` |
| `SetData` | `Void` | `Double value, Boolean fix` | `` |
| `SetInvitation` | `Void` | `String txt` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExecGetFixValueDlg` | `Boolean` | `String capt, String txt, ref Double value, ref Boolean fix, Double minValue, Double maxValue` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GetValuesDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.CogoController.Dialogs.Input.GetValuesDlg` |
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
                  - `Topomatic.Alg.CogoController.Dialogs.Input.GetValuesDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExecGetValuesDlg` | `Boolean` | `String dlgCaption, String[] capts, Double[] values, Vector2D[] MinMaxValues` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 8 |
| **Classes** | 6 |
| **Interfaces** | 0 |
| **Enums** | 2 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 8 |
| **Total Properties** | 0 |
| **Total Fields** | 45 |
| **Total Events** | 0 |
| **Total Constructors** | 6 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


