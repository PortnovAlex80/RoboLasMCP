# Topomatic.Extentions.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Extentions.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v4.0.30319` |
| **Full Name** | `Topomatic.Extentions.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Extentions.Controller.dll` |

---
## Namespace: `Topomatic.Extentions.Controller`

### `ExtentionsPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.ExtentionsPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Extentions.Controller.ExtentionsPluginHost`

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

### `LineSurfaceBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.LineSurfaceBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.Tools.SurfaceBuilder` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Tools.SurfaceBuilder`
    - `Topomatic.Extentions.Controller.LineSurfaceBuilder`

#### Constructors (1)

- `.ctor(Alignment alignment, Int32 stationsCount, Int32 index)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `OpenEnabledEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.ProjectOpen+OpenEnabledEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Extentions.Controller.ProjectOpen+OpenEnabledEventArgs`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `OpenEnabled` | `Boolean` | `get/set` | No | `` |

### `PointSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.PointSide` |
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
      - `Topomatic.Extentions.Controller.PointSide`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `PointSide` | Yes | `Left` | `` |
| `Middle` | `PointSide` | Yes | `Middle` | `` |
| `NotDefined` | `PointSide` | Yes | `NotDefined` | `` |
| `Right` | `PointSide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Right` | `0` |
| `Left` | `1` |
| `Middle` | `2` |
| `NotDefined` | `3` |

**Underlying Type**: `System.Int32`

### `PointType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.PointType` |
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
      - `Topomatic.Extentions.Controller.PointType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `End` | `PointType` | Yes | `End` | `` |
| `NotDefined` | `PointType` | Yes | `NotDefined` | `` |
| `Start` | `PointType` | Yes | `Start` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NotDefined` | `0` |
| `Start` | `1` |
| `End` | `2` |

**Underlying Type**: `System.Int32`

### `ProjectInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.ProjectOpen+ProjectInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Item` | `ListViewItem` | No | `` | `` |
| `Modifed` | `DateTime` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Uri` | `URI` | No | `` | `` |

### `ProjectOpen` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.ProjectOpen` |
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
              - `Topomatic.Extentions.Controller.ProjectOpen`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectedProject` | `ProjectInfo` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RefreshList` | `Void` | `` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `ListViewProjectsDoubleClicked` | `EventHandler` | No | `` |
| `OpenEnabledChanged` | `EventHandler` | No | `` |

#### Nested Types (2)

- `OpenEnabledEventArgs` (class)
- `ProjectInfo` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectByCountour` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.SectByCountour` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(List<Vector2D> polygon, SectTypes sectType)`

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ArcIntersection` | `List<ArcSegment>` | `ArcSegment arcSegment, SectTypes sectType, List<ArcSegment> sectedArcSegments` | `` |
| `ArcIntersection` | `List<ArcSegment>` | `ArcSegment arcSegment, SectTypes sectType` | `` |
| `ArcIntersection` | `List<ArcSegment>` | `ArcSegment arcSegment` | `` |
| `BoundingBoxIntersection` | `Boolean` | `BoundingBox2D boundingBox` | `` |
| `BoundingBoxIntersection` | `Boolean` | `BoundingBox2D boundingBox, SectTypes sectType` | `` |
| `CircleIntersection` | `Boolean` | `Vector2D center, Double radius, List<ArcSegment> resultArcSegments` | `` |
| `CircleIntersection` | `Boolean` | `Vector2D center, Double radius, List<ArcSegment> resultArcSegments, List<ArcSegment> sectedArcSegments` | `` |
| `PolylineIntersection` | `List<Polyline3D>` | `Polyline3D polyline, List<Polyline3D> sectedPolylines, SectTypes sectType` | `` |
| `PolylineIntersection` | `List<Polyline3D>` | `Polyline3D polyline` | `` |
| `PolylineIntersection` | `List<Polyline3D>` | `Polyline3D polyline, SectTypes sectType` | `` |
| `SegmentIntersection` | `List<LineSegment>` | `Vector2D startPoint, Vector2D endPoint` | `` |
| `SegmentIntersection` | `List<LineSegment>` | `Vector2D startPoint, Vector2D endPoint, SectTypes sectType` | `` |
| `SegmentIntersection` | `List<LineSegment>` | `Vector2D startPoint, Vector2D endPoint, SectTypes sectType, List<LineSegment> sectedSegments` | `` |

### `SectTypes` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.SectTypes` |
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
      - `Topomatic.Extentions.Controller.SectTypes`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Inner` | `SectTypes` | Yes | `Inner` | `` |
| `NotDefined` | `SectTypes` | Yes | `NotDefined` | `` |
| `Outer` | `SectTypes` | Yes | `Outer` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NotDefined` | `0` |
| `Inner` | `1` |
| `Outer` | `2` |

**Underlying Type**: `System.Int32`

### `StructureLineSectType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.StructureLineSectType` |
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
      - `Topomatic.Extentions.Controller.StructureLineSectType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `StructureLineSectType` | Yes | `Default` | `` |
| `DelIntersectedSegmens` | `StructureLineSectType` | Yes | `DelIntersectedSegmens` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `DelIntersectedSegmens` | `1` |

**Underlying Type**: `System.Int32`

### `SurfaceSectByContour` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.SurfaceSectByContour` |
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
| `CloseStructureLines` | `Boolean` | `set` | No | `` |
| `StructureLine` | `StructureLine` | `set` | No | `` |
| `StructureLineSectType` | `StructureLineSectType` | `set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SurfaceCut` | `Void` | `Surface surface, StructureLine structureLineContour, List<Vector2D> p` | `` |
| `SurfaceFill` | `Void` | `Surface resultSurface` | `` |
| `SurfaceInsert` | `Void` | `Surface resultSurface` | `` |
| `SurfaceSect` | `Void` | `Surface surface, List<Vector2D> polygon, SectTypes sectType` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindEqualStructureLine` | `StructureLine` | `Surface surface, StructureLine structureLineSource` | `` |

---
## Namespace: `Topomatic.Extentions.Controller.Dialogs`

### `GetSurfaceForVadSurfaceBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Dialogs.GetSurfaceForVadSurfaceBuilder` |
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
                - `Topomatic.Extentions.Controller.Dialogs.GetSurfaceForVadSurfaceBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `URI folderUri, ref String path, ref Boolean modelCreated` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProjectOpenDialog` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Dialogs.ProjectOpenDialog` |
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
                  - `Topomatic.Extentions.Controller.Dialogs.ProjectOpenDialog`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ProjectInfo` | `ProjectInfo` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectSimilarSettingsDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Dialogs.SelectSimilarSettingsDlg` |
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
                - `Topomatic.Extentions.Controller.Dialogs.SelectSimilarSettingsDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SearchInSameModelOnly` | `Boolean` | `get` | No | `` |
| `SelectedProperties` | `String[]` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `Object selectedObject, String[] selectedProperties, Boolean searchInSameModelOnly` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Extentions.Controller.GML`

### `GML` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.GML.GML` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |
| `Code` | `Int32` | `get/set` | No | `` |
| `ObjectName` | `String` | `get/set` | No | `` |
| `Properties` | `List<GMLProperty>` | `get/set` | No | `` |
| `Tag` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetXElement` | `XElement` | `Int32 handle` | `` |

### `GmlObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.GML.GmlObject` |
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
| `Code` | `Int32` | `get/set` | No | `` |
| `DotOnly` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Properties` | `Dictionary<String String>` | `get/set` | No | `` |

### `GMLProperty` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.GML.GMLProperty` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Extentions.Controller.GML.GMLProperty`

#### Constructors (1)

- `.ctor(String caption, String propertyName, String type)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetXElement` | `XElement` | `ref Int32 handle` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Caption` | `String` | No | `` | `` |
| `PropertyName` | `String` | No | `` | `` |
| `Tag` | `String` | No | `` | `` |
| `Type` | `String` | No | `` | `` |

### `GMLUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.GML.GMLUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Dictionaries` | `Dictionary<String Dictionary<String String>>` | `get` | Yes | `` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertToSemantic` | `Void` | `List<GML> list` | `` |
| `GetAvaragePoint` | `Vector3D` | `Vector3D[] vectors` | `` |
| `GetTriangleVector3Ds` | `Vector3D[]` | `String coordinaes, Int32 dim` | `` |
| `GetTriangleVector3Ds` | `Vector3D[]` | `String coordinaes` | `` |
| `GetVector3Ds` | `Vector3D[]` | `String coordinaes` | `` |
| `GetVector3Ds` | `Vector3D[]` | `String coordinaes, Char split, Char splitXYZ` | `` |
| `LoadGmlKeyPairs` | `List<GmlObject>` | `` | `` |
| `SaveSemanticLibrary` | `Void` | `List<GML> list` | `` |
| `SetSemantic` | `Void` | `SemanticDataSet set, XmlNodeList nodes, Dictionary<String String> keypair` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `stgTypes` | `String[]` | Yes | `` | `` |

### `ImportGml` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.GML.ImportGml` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Surface surface)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GmlKeyPairs` | `List<GmlObject>` | `get` | Yes | `` |
| `HasKeyPairs` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ImportGmlFile` | `Void` | `` | `` |

---
## Namespace: `Topomatic.Extentions.Controller.LibraryExplorer`

### `LibraryExplorer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.LibraryExplorer.LibraryExplorer` |
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
              - `Topomatic.Extentions.Controller.LibraryExplorer.LibraryExplorer`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `LibraryExplorer` | `get` | Yes | `` |
| `SelectedFolder` | `xLibraryNode` | `get` | No | `` |
| `SelectedItem` | `xLibraryNode` | `get` | No | `` |
| `SelectedLibrary` | `xLibrary` | `get` | No | `` |
| `SelectedLibraryCollection` | `xLibraryCollection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RefreshData` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Extentions.Controller.MIF`

### `MifDataSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.MifDataSet` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(FileStream fileStream)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Encoding` | `Encoding` | `set` | No | `` |
| `Entities` | `MifEntity[]` | `get` | No | `` |
| `EntityType` | `Type` | `get` | No | `` |
| `Header` | `MifHeader` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntity` | `Void` | `MifEntity entity` | `` |
| `Dispose` | `Void` | `` | `` |
| `LoadDataTable` | `Void` | `` | `` |
| `LoadEntities` | `MifEntity[]` | `` | `` |
| `LoadHeader` | `MifHeader` | `` | `` |
| `Save` | `Void` | `` | `` |
| `SaveDataTable` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `MifHeader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.MifHeader` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CharSet` | `String` | `get/set` | No | `` |
| `Columns` | `MifColumn[]` | `get` | No | `` |
| `CRS` | `HorizontalCoordinateSystem` | `get/set` | No | `` |
| `Default` | `MifHeader` | `get` | Yes | `` |
| `Delimiter` | `Char` | `get/set` | No | `` |
| `Transform` | `Transform` | `get` | No | `` |
| `Version` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddColumn` | `Void` | `MifColumn column` | `` |
| `Save` | `Void` | `StreamWriter streamWriter` | `` |

### `Transform` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.Transform` |
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
| `MultX` | `Int32` | `get` | No | `` |
| `MultY` | `Int32` | `get` | No | `` |
| `OffsetX` | `Int32` | `get` | No | `` |
| `OffsetY` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TransformPoint` | `Void` | `ref Vector2D point` | `` |

---
## Namespace: `Topomatic.Extentions.Controller.MIF.Entities`

### `MifEntity` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.Entities.MifEntity` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DataRow` | `MifRow` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToDwgEntities` | `DwgEntity[]` | `MifHeader mifHeader` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFromDwgEntity` | `MifEntity` | `DwgEntity dwgEntity` | `` |

---
## Namespace: `Topomatic.Extentions.Controller.MIF.Import.Controls`

### `Importer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.Import.Controls.Importer` |
| **Base Type** | `System.Windows.Forms.UserControl` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.Stg.IStgSerializable` |
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
              - `Topomatic.Extentions.Controller.MIF.Import.Controls.Importer`

#### Constructors (1)

- `.ctor(MifDataSet mifDataSet)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |
| `SelectedCRS` | `HorizontalCoordinateSystem` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DoCommit` | `Void` | `` | `` |
| `DoImport` | `Void` | `Surface surface, ProgressChangedEventHandler onProgress` | `` |
| `DoInit` | `Void` | `Surface surface` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Extentions.Controller.MIF.Table`

### `MifColumn` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.Table.MifColumn` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `Type` | `MifColumnType` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateColumn` | `MifColumn` | `MifColumnType type, String name` | `` |

### `MifColumnType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.Table.MifColumnType` |
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
      - `Topomatic.Extentions.Controller.MIF.Table.MifColumnType`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Char` | `MifColumnType` | Yes | `Char` | `` |
| `Date` | `MifColumnType` | Yes | `Date` | `` |
| `Decimal` | `MifColumnType` | Yes | `Decimal` | `` |
| `Float` | `MifColumnType` | Yes | `Float` | `` |
| `Integer` | `MifColumnType` | Yes | `Integer` | `` |
| `Logical` | `MifColumnType` | Yes | `Logical` | `` |
| `Smallint` | `MifColumnType` | Yes | `Smallint` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Char` | `0` |
| `Integer` | `1` |
| `Smallint` | `2` |
| `Decimal` | `3` |
| `Float` | `4` |
| `Date` | `5` |
| `Logical` | `6` |

**Underlying Type**: `System.Int32`

### `MifRow` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.MIF.Table.MifRow` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(MifHeader mifHeader, String[] fields)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `String` | `get` | No | `` |
| `Values` | `String[]` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddValue` | `Void` | `String value` | `` |
| `TryGetValue` | `Boolean` | `Int32 i, ref Double value` | `` |
| `TryGetValue` | `Boolean` | `Int32 i, ref Int32 value` | `` |

---
## Namespace: `Topomatic.Extentions.Controller.Models3DLoaders`

### `OBJSaver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.OBJSaver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Save` | `Void` | `Stream stream, GeometryModel3D model` | `` |

### `STLLoader` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.STLLoader` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadModel` | `Boolean` | `Stream stream, GeometryModel3D model` | `` |

### `STLLoaderBinary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.STLLoaderBinary` |
| **Base Type** | `Topomatic.Extentions.Controller.Models3DLoaders.STLLoader` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Extentions.Controller.Models3DLoaders.STLLoader`
    - `Topomatic.Extentions.Controller.Models3DLoaders.STLLoaderBinary`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `STLLoaderText` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.STLLoaderText` |
| **Base Type** | `Topomatic.Extentions.Controller.Models3DLoaders.STLLoader` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Extentions.Controller.Models3DLoaders.STLLoader`
    - `Topomatic.Extentions.Controller.Models3DLoaders.STLLoaderText`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `STLSaver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.STLSaver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Save` | `Void` | `Stream stream, GeometryModel3D model` | `` |

### `STLSaverBinary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.STLSaverBinary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Save` | `Void` | `Stream fileStream, GeometryModel3D model` | `` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.Wrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GeometryModel3D model, String name, Vector3D translation, Vector3D oX, Vector3D oY, Vector3D scale)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Model` | `GeometryModel3D` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `OX` | `Vector3D` | `get` | No | `` |
| `OY` | `Vector3D` | `get` | No | `` |
| `Scale` | `Vector3D` | `get` | No | `` |
| `Translation` | `Vector3D` | `get` | No | `` |

---
## Namespace: `Topomatic.Extentions.Controller.Models3DLoaders.VRML`

### `VRMLProcessor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.Models3DLoaders.VRML.VRMLProcessor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Load` | `ImElement` | `Stream stream` | `` |
| `Save` | `Void` | `ImElement model3DElement, Stream stream` | `` |

---
## Namespace: `Topomatic.Extentions.Controller.TopographicSignsLibrary`

### `TopographicSignsNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Extentions.Controller.TopographicSignsLibrary.TopographicSignsNode` |
| **Base Type** | `Topomatic.Libx.xLibraryNode` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.Extentions.Controller.TopographicSignsLibrary.TopographicSignsNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MissingSignGuidBlockName` | `String` | Yes | `"MissingSign"` | `` |
| `TopographicSignDefaultTag` | `String` | Yes | `"TopographicSign"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 37 |
| **Classes** | 27 |
| **Interfaces** | 0 |
| **Enums** | 5 |
| **Structs** | 1 |
| **Abstract Classes** | 3 |
| **Static Classes** | 1 |
| **Total Methods** | 63 |
| **Total Properties** | 54 |
| **Total Fields** | 36 |
| **Total Events** | 2 |
| **Total Constructors** | 26 |
| **Nested Types** | 2 |
| **Extension Methods** | 0 |


