# Topomatic.Visualization.Libx

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Visualization.Libx` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v4.0.30319` |
| **Full Name** | `Topomatic.Visualization.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Visualization.Libx.dll` |

---
## Namespace: `Topomatic.Visualization.Libx`

### `Model3DLibraryItemReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.Model3DLibraryItemReference` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.Libx.Model3DLibraryItemReference`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Guid guid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetNode` | `VisualizationModelNode` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VisualizationModelCustomControl` (class)

**Attributes**: [Obfuscation]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.VisualizationModelCustomControl` |
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
              - `Topomatic.Visualization.Libx.VisualizationModelCustomControl`

#### Constructors (2)

- `.ctor(VisualizationModelNode node, MethodInvoker onRefresh, Boolean readOnly)`
- `.ctor(VisualizationModelNode node, CustomVisualisationNodeProperties props, MethodInvoker onRefresh, Boolean readOnly)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VisualizationModelNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.VisualizationModelNode` |
| **Base Type** | `Topomatic.Libx.xLibraryNode` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.Visualization.Libx.VisualizationModelNode`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Content` | `String` | `get` | No | `` |
| `Documents` | `IEnumerable<String>` | `get` | No | `` |
| `Measure` | `VisualizationModelNodeMeasure` | `get/set` | No | `` |
| `ModelFileName` | `String` | `get` | No | `` |
| `Ox` | `Vector3D` | `get/set` | No | `` |
| `Oy` | `Vector3D` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Properties` | `IList<ModelPropertyItem>` | `get` | No | `` |
| `Type` | `ImTypeDescriptor` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDocument` | `Void` | `String documentName, Stream ms` | `` |
| `AddDocument` | `Void` | `String documentName, String fileName` | `` |
| `Assign` | `Void` | `VisualizationModelNode node` | `` |
| `ExtractToFolder` | `Void` | `String folder, Func<String String> parseName` | `` |
| `GetDocuments` | `IEnumerable<ImDocument>` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetOriginalModel` | `GeometryModel3D` | `` | `` |
| `GetTemporaryDocumentFileName` | `String` | `String documentName` | `` |
| `InnerSetModel` | `Void` | `GeometryModel3D model` | `` |
| `Optimize` | `Void` | `` | `` |
| `RemoveDocument` | `Boolean` | `String fileName` | `` |
| `SetModel` | `Void` | `String filename` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VisualizationModelNodeMeasure` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.VisualizationModelNodeMeasure` |
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
      - `Topomatic.Visualization.Libx.VisualizationModelNodeMeasure`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Centimeters` | `VisualizationModelNodeMeasure` | Yes | `Centimeters` | `` |
| `Metres` | `VisualizationModelNodeMeasure` | Yes | `Metres` | `` |
| `Millimeters` | `VisualizationModelNodeMeasure` | Yes | `Millimeters` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Metres` | `0` |
| `Centimeters` | `1` |
| `Millimeters` | `2` |

**Underlying Type**: `System.Int32`

### `VisualizationModelsLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.VisualizationModelsLibrary` |
| **Base Type** | `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Visualization.Libx.VisualizationModelNode, Topomatic.Visualization.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibrary, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Visualization.ITypedObjectCollection` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryCollection`
    - `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Visualization.Libx.VisualizationModelNode, Topomatic.Visualization.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Visualization.Libx.VisualizationModelsLibrary`

#### Constructors (1)

- `.ctor(String environment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `VisualizationModelsLibrary` | `get` | Yes | `` |
| `LibraryName` | `String` | `get` | No | `` |
| `LibraryUid` | `String` | `get` | No | `` |
| `RenderMode` | `RenderMode` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindObject` | `TypedObject` | `String uid` | `` |
| `FindPath` | `String` | `String uid` | `` |
| `FindUids` | `IEnumerable<String>` | `String parentType, Predicate<TypedObject> match` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITypedObjectCollection` | `FindUids` |
| `ITypedObjectCollection` | `FindObject` |
| `ITypedObjectCollection` | `FindPath` |
| `ITypedObjectCollection` | `get_LibraryUid` |

---
## Namespace: `Topomatic.Visualization.Libx.Design`

### `VisualizationModelNodeMeasureEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.Design.VisualizationModelNodeMeasureEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Visualization.Libx.Design.VisualizationModelNodeMeasureEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Visualization.Libx.Tools`

### `CSVImportExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.Tools.CSVImportExportProvider` |
| **Base Type** | `Topomatic.Visualization.Libx.Tools.ImportExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Libx.Tools.ImportExportProvider`
    - `Topomatic.Visualization.Libx.Tools.CSVImportExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Export` | `Void` | `IEnumerable<xLibraryNode> nodes, String fileName` | `` |
| `ImportFromFile` | `Void` | `VisualizationModelNode node, String fileName` | `` |
| `ImportFromFolder` | `Void` | `xLibraryNode folderNode, String fileName` | `` |

### `IfcImportExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.Tools.IfcImportExportProvider` |
| **Base Type** | `Topomatic.Visualization.Libx.Tools.ImportExportProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Libx.Tools.ImportExportProvider`
    - `Topomatic.Visualization.Libx.Tools.IfcImportExportProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Export` | `Void` | `IEnumerable<xLibraryNode> nodes, String folder` | `` |
| `ImportFromFile` | `Void` | `VisualizationModelNode node, String file` | `` |
| `ImportFromFolder` | `Void` | `xLibraryNode folderNode, String folder` | `` |

### `ImportExportProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Libx.Tools.ImportExportProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 9 |
| **Classes** | 8 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 30 |
| **Total Properties** | 14 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 9 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


