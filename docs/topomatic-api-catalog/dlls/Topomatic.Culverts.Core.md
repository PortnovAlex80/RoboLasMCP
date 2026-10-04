# Topomatic.Culverts.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Culverts.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Culverts.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Culverts.Core.dll` |

---
## Namespace: `Topomatic.Culverts.Core`

### `CulvertModelReceiver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.CulvertModelReceiver` |
| **Base Type** | `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver`
    - `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver`
      - `Topomatic.Culverts.Core.CulvertModelReceiver`

#### Constructors (1)

- `.ctor(Boolean readOnly)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `` |
| `CulvertProjectModel` | `IProjectModel` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetActiveCulvert` | `Culvert` | `Boolean readOnly` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CulvertsCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.CulvertsCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Culverts.Core.CulvertsCorePluginHost`

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

### `PlanchetUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.PlanchetUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GeneratePlanchet` | `Void` | `GeneratePlanchetEventArgs e` | `` |

---
## Namespace: `Topomatic.Culverts.Core.ClvCommunications`

### `CulvertCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.ClvCommunications.CulvertCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment, Culvert culvert, Double station, Double elevation)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Album` | `String` | `get` | No | `` |
| `Angle` | `Double` | `get` | No | `PropertyTypeConverter` |
| `Diameter` | `Double` | `get` | No | `Length, ConditionalBrowsable` |
| `Elevation` | `Double` | `get` | No | `Browsable` |
| `ElevationString` | `String` | `get` | No | `` |
| `Hole` | `ValuePerValue` | `get` | No | `ConditionalBrowsable` |
| `HoleCount` | `Int32` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `Browsable` |
| `Model` | `String` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `StationStr` | `String` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawCommunication` | `Void` | `CadPen pen, CommunicationStyle style` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |

### `CuttingSurfaceCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.ClvCommunications.CuttingSurfaceCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Alg.Prf.IProfile` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String description, Int32 code)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get` | No | `` |
| `Codes` | `IList<Int32>` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Elevation` | `Double` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Items` | `IList<Vector2D>` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetStations` | `IEnumerable<Double>` | `Boolean onlyMarked` | `` |
| `GetY` | `Boolean` | `Double station, ref Double value` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Layout` | `Void` | `Drawing drawing, CommunicationStyle style, Boolean createLayer` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IProfile` | `GetY` |
| `IProfile` | `GetStations` |

---
## Namespace: `Topomatic.Culverts.Core.Design`

### `SourceVolumePropertyEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Design.SourceVolumePropertyEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Culverts.Core.Design.SourceVolumePropertyEditor`

#### Constructors (1)

- `.ctor(String[] standardValues)`

---
## Namespace: `Topomatic.Culverts.Core.GridPanel`

### `GridPanelCulvertPaintEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.GridPanel.GridPanelCulvertPaintEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs`
        - `Topomatic.Culverts.Core.GridPanel.GridPanelCulvertPaintEventArgs`

#### Constructors (1)

- `.ctor(Culvert culvert, CadView cadView, Rectangle clientBounds, Graphics graphics, Font font, Boolean isWhiteBackColor)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `` |

---
## Namespace: `Topomatic.Culverts.Core.Plt`

### `CrsSurfaceTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Plt.CrsSurfaceTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SurfaceBetweenStations` | `CrsLineNode[]` | `Culvert culvert, CrsLineNode[] surface` | `` |

---
## Namespace: `Topomatic.Culverts.Core.Plt.Constants`

### `CulvertMockupConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Plt.Constants.CulvertMockupConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ARRANGEMENT_DATA` | `String` | Yes | `"arrangement_data"` | `` |
| `CULVERT` | `String` | Yes | `"Culvert"` | `` |
| `DWL_MODEL_TYPE` | `String` | Yes | `"application/culvert-dwl"` | `` |
| `SHEET_HEIGHT` | `String` | Yes | `"SheetHeight"` | `` |
| `SHEET_WIDTH` | `String` | Yes | `"SheetWidth"` | `` |
| `TEMPLATE` | `String` | Yes | `"LT1"` | `` |

---
## Namespace: `Topomatic.Culverts.Core.Plt.Enumerations`

### `HeaderType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Plt.Enumerations.HeaderType` |
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
      - `Topomatic.Culverts.Core.Plt.Enumerations.HeaderType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `HeaderType` | Yes | `Empty` | `` |
| `Input` | `HeaderType` | Yes | `Input` | `` |
| `Output` | `HeaderType` | Yes | `Output` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Input` | `1` |
| `Output` | `2` |

**Underlying Type**: `System.Int32`

### `HorAlignment` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Plt.Enumerations.HorAlignment` |
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
      - `Topomatic.Culverts.Core.Plt.Enumerations.HorAlignment`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `HorAlignment` | Yes | `Center` | `` |
| `Empty` | `HorAlignment` | Yes | `Empty` | `` |
| `Left` | `HorAlignment` | Yes | `Left` | `` |
| `Right` | `HorAlignment` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Center` | `1` |
| `Left` | `2` |
| `Right` | `3` |

**Underlying Type**: `System.Int32`

### `LayoutGridCellMode` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Plt.Enumerations.LayoutGridCellMode` |
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
      - `Topomatic.Culverts.Core.Plt.Enumerations.LayoutGridCellMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `LayoutGridCellMode` | Yes | `Empty` | `` |
| `Overlay` | `LayoutGridCellMode` | Yes | `Overlay` | `` |
| `Stack` | `LayoutGridCellMode` | Yes | `Stack` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Overlay` | `1` |
| `Stack` | `2` |

**Underlying Type**: `System.Int32`

### `VertAlignment` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Plt.Enumerations.VertAlignment` |
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
      - `Topomatic.Culverts.Core.Plt.Enumerations.VertAlignment`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `VertAlignment` | Yes | `Bottom` | `` |
| `Center` | `VertAlignment` | Yes | `Center` | `` |
| `Empty` | `VertAlignment` | Yes | `Empty` | `` |
| `Top` | `VertAlignment` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Center` | `1` |
| `Top` | `2` |
| `Bottom` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Culverts.Core.Settings`

### `CulvertPrecisionSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Core.Settings.CulvertPrecisionSettings` |
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
                - `Topomatic.Culverts.Core.Settings.CulvertPrecisionSettings`

#### Constructors (1)

- `.ctor(Culvert culvert)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 14 |
| **Classes** | 7 |
| **Interfaces** | 0 |
| **Enums** | 4 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 3 |
| **Total Methods** | 24 |
| **Total Properties** | 21 |
| **Total Fields** | 24 |
| **Total Events** | 0 |
| **Total Constructors** | 7 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


