# Topomatic.Crs.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Crs.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Crs.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Crs.Runtime.dll` |

---
## Namespace: `Topomatic.Crs.Runtime`

### `AlignmentType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.AlignmentType` |
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
      - `Topomatic.Crs.Runtime.AlignmentType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `AlignmentType` | Yes | `None` | `` |
| `Rail` | `AlignmentType` | Yes | `Rail` | `` |
| `Road` | `AlignmentType` | Yes | `Road` | `` |
| `Survey` | `AlignmentType` | Yes | `Survey` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Rail` | `0` |
| `Road` | `1` |
| `Survey` | `2` |
| `None` | `3` |

**Underlying Type**: `System.Int32`

### `ConstructionItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.ConstructionItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AlignmentType algType, String group, ComponentType compType, String module, String className, String name, String displayName, String description, String icon)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlgType` | `AlignmentType` | `get` | No | `` |
| `Class` | `String` | `get` | No | `` |
| `CompType` | `ComponentType` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DislpayName` | `String` | `get` | No | `` |
| `Group` | `String` | `get` | No | `` |
| `Icon` | `String` | `get` | No | `` |
| `Module` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadConstructionItems` | `Void` | `String fileName, List<ConstructionItem> items` | `` |
| `SaveConstructionItmes` | `Void` | `String fileName, List<ConstructionItem> items` | `` |

### `CrsComponentPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.CrsComponentPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Crs.Runtime.CrsComponentPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InstanceDependence` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `CrsTemplatePythonBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.CrsTemplatePythonBuilder` |
| **Base Type** | `Topomatic.Crs.Templates.CrsTemplateBuilder` |
| **Implements** | `Topomatic.Crs.ICrsBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsTemplateBuilder`
    - `Topomatic.Crs.Runtime.CrsTemplatePythonBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SemanticExpressionProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.SemanticExpressionProperty` |
| **Base Type** | `Topomatic.ComponentModel.CustomProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.Crs.Runtime.SemanticExpressionProperty`

#### Constructors (1)

- `.ctor(SemanticProperty semanticProperty, PropertyList semanticEx)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Category` | `String` | `get/set` | No | `` |
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `DataSet` | `SemanticDataSet` | `get/set` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsBrowsable` | `Boolean` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `PropertyType` | `Type` | `get` | No | `` |
| `SemanticEx` | `PropertyList` | `get/set` | No | `` |
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |
| `VisualStyle` | `VisualStyle` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `SetValue` | `Void` | `Object value` | `` |

### `Volume` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.VolumeCalcer+Volume` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Runtime.VolumeCalcer+Volume`

#### Constructors (1)

- `.ctor(String cipher, String groundId, String description, Double left, Double right, Nullable<Double> loffs, Nullable<Double> roffs, Int32 code, CrsVolumeMode mode)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Double` | `get` | No | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cipher` | `String` | No | `` | `` |
| `Code` | `Int32` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `GroundId` | `String` | No | `` | `` |
| `Left` | `Double` | No | `` | `` |
| `LeftOffset` | `Nullable<Double>` | No | `` | `` |
| `Mode` | `CrsVolumeMode` | No | `` | `` |
| `Right` | `Double` | No | `` | `` |
| `RightOffset` | `Nullable<Double>` | No | `` | `` |

### `VolumeCalcer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.VolumeCalcer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcVolumes` | `Void` | `List<Volume> result, CrsContainer container, Action<List<CrsModifiedVolume>> modify, Boolean hasOffsets` | `` |

#### Nested Types (1)

- `Volume` (struct)

---
## Namespace: `Topomatic.Crs.Runtime.Initializer`

### `ActConstructionInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.ActConstructionInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.ActConstructionInitializer`

#### Constructors (1)

- `.ctor(String file)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `ContourInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.ContourInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.ContourInitializer`

#### Constructors (1)

- `.ctor(CadView cadView)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent component, CrsComponent owner` | `` |

### `ContourSegmentInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.ContourSegmentInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.ContourSegmentInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `ContourUnionInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.ContourUnionInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.ContourUnionInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `CrossNodeInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.CrossNodeInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.CrossNodeInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent component, CrsComponent owner` | `` |

### `CrsDesignHostDecorator` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.PythonInitializer+CrsDesignHostDecorator` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ICrsDesignHost host, CrsComponent owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `AstExpression` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ComponentExist` | `Boolean` | `String typeName` | `` |
| `Contains` | `Boolean` | `CrsComponent key` | `` |
| `SelectComponent` | `CrsComponent` | `String message, SelectionType type` | `` |

### `LayerListInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.LayerListInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.LayerListInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `NodeAlongRayInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.NodeAlongRayInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.NodeAlongRayInitializer`

#### Constructors (1)

- `.ctor(Boolean useStation, Boolean useOffset)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `NodeExpression` | `AstExpression` | `get` | No | `` |
| `NodePosition` | `Vector2D` | `get` | No | `` |
| `Ray` | `CrsRay` | `get` | No | `` |
| `RayExpression` | `AstExpression` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `ParallelRayInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.ParallelRayInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.ParallelRayInitializer`

#### Constructors (1)

- `.ctor(AstExpression baseRay, AstExpression baseNode)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `PythonInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.PythonInitializer` |
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
| `InitializeComponent` | `ActComponent` | `ICrsDesignHost host, CrsComponent instance, String fullTypeName, CrsComponent owner` | `` |

#### Nested Types (1)

- `CrsDesignHostDecorator` (class)

### `RelativeNodeInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.RelativeNodeInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.RelativeNodeInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent component, CrsComponent owner` | `` |

### `RelativeRayIntializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.RelativeRayIntializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.RelativeRayIntializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent component, CrsComponent owner` | `` |

### `SegmentListInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.SegmentListInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.SegmentListInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `SimpleNodeInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.SimpleNodeInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.SimpleNodeInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent component, CrsComponent owner` | `` |

### `SimpleRayInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.SimpleRayInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.SimpleRayInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent component, CrsComponent owner` | `` |

### `TwoNodesRayInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.TwoNodesRayInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.TwoNodesRayInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent component, CrsComponent owner` | `` |

### `VolumeInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.VolumeInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.VolumeInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `VolumeIntersectionInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.VolumeIntersectionInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.VolumeIntersectionInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `VolumeSegmentInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Initializer.VolumeSegmentInitializer` |
| **Base Type** | `Topomatic.Crs.Design.DesignInitializer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Design.DesignInitializer`
    - `Topomatic.Crs.Runtime.Initializer.VolumeSegmentInitializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

---
## Namespace: `Topomatic.Crs.Runtime.Interpreter`

### `ActBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Interpreter.ActBuilder` |
| **Base Type** | `Topomatic.Crs.Ast.AstWalker` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstWalker`
    - `Topomatic.Crs.Runtime.Interpreter.ActBuilder`

#### Constructors (1)

- `.ctor(CrsDesignContext dc, IDictionary<String Object> variables, List<CrsConstruction> volumeConstructions, ICrsBuilderListener listener)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurrentContext` | `Context` | `get` | No | `` |
| `Result` | `Object` | `get` | No | `` |

#### Instance Methods (32)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Boolean` | `AstNameExpression node` | `` |
| `Walk` | `Boolean` | `AstIndexExpression node` | `` |
| `Walk` | `Boolean` | `AstMemberExpression node` | `` |
| `Walk` | `Boolean` | `AstConstantExpression node` | `` |
| `Walk` | `Boolean` | `ActSimpleVolume volume` | `` |
| `Walk` | `Boolean` | `ActSegmentVolume volume` | `` |
| `Walk` | `Boolean` | `ActSectVolume volume` | `` |
| `Walk` | `Boolean` | `AstConditionalExpression node` | `` |
| `Walk` | `Boolean` | `AstCallExpression node` | `` |
| `Walk` | `Boolean` | `AstArg node` | `` |
| `Walk` | `Boolean` | `AstOrExpression node` | `` |
| `Walk` | `Boolean` | `AstUnaryExpression node` | `` |
| `Walk` | `Boolean` | `AstBinaryExpression node` | `` |
| `Walk` | `Boolean` | `AstAndExpression node` | `` |
| `Walk` | `Boolean` | `ActUnionContour contour` | `` |
| `Walk` | `Boolean` | `ActSimpleNode node` | `` |
| `Walk` | `Boolean` | `ActComponent component` | `` |
| `Walk` | `Boolean` | `ActTwoRayNode node` | `` |
| `Walk` | `Boolean` | `ActRelativeNode node` | `` |
| `Walk` | `Boolean` | `ActCondition condition` | `` |
| `Walk` | `Boolean` | `ActSequence sequence` | `` |
| `Walk` | `Boolean` | `ActReport report` | `` |
| `Walk` | `Boolean` | `ActSwitch aswitch` | `` |
| `Walk` | `Boolean` | `ActRayContourNode node` | `` |
| `Walk` | `Boolean` | `ActSegmentContour contour` | `` |
| `Walk` | `Boolean` | `ActTwoNodeRay ray` | `` |
| `Walk` | `Boolean` | `ActSimpleContour contour` | `` |
| `Walk` | `Boolean` | `ActRayContainerNode node` | `` |
| `Walk` | `Boolean` | `ActSimpleRay ray` | `` |
| `WalkAct` | `Boolean` | `ActComponent component` | `` |
| `WalkDotNet` | `Boolean` | `ActComponent component` | `` |
| `WalkPython` | `Boolean` | `ActComponent component` | `` |

#### Nested Types (1)

- `Context` (class)

### `ActBuiltinFunctions` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Interpreter.ActBuiltinFunctions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Functions` | `IDictionary<String ActFunction>` | `get` | Yes | `` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBuildinFunctions` | `Void` | `IDictionary<String ActFunction> functions` | `` |
| `AddBuildinVariables` | `Void` | `IDictionary<String Object> variables` | `` |
| `DrainX` | `Object` | `CrsDesignContext context, Int32 transition, Object value` | `` |
| `DrainY` | `Object` | `CrsDesignContext context, Int32 transition, Object value` | `` |
| `Iff` | `Object` | `Object cond, Object trueValue, Object falseValue` | `` |
| `Max` | `Object` | `Object value1, Object value2, Object[] values` | `` |
| `Min` | `Object` | `Object value1, Object value2, Object[] values` | `` |

### `ActFunction` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Interpreter.ActFunction` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invoke` | `Object` | `AstObjectCollection<AstArg> expression, ActBuilder evaluator` | `` |

### `ActStaticFunction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Interpreter.ActStaticFunction` |
| **Base Type** | `Topomatic.Crs.Runtime.Interpreter.ActFunction` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Runtime.Interpreter.ActFunction`
    - `Topomatic.Crs.Runtime.Interpreter.ActStaticFunction`

#### Constructors (1)

- `.ctor(MethodInfo info)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddOverload` | `Void` | `MethodInfo info` | `` |
| `Invoke` | `Object` | `AstObjectCollection<AstArg> expression, ActBuilder evaluator` | `` |

### `Context` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Runtime.Interpreter.ActBuilder+Context` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(IDictionary<String Object> names)`
- `.ctor(CrsContainer container, Context parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Container` | `CrsContainer` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `Parent` | `Context` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `CrsComponent component` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String Object>>` | `` | `` |
| `TryGetValue` | `Boolean` | `String key, ref Object value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 31 |
| **Classes** | 25 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 1 |
| **Abstract Classes** | 2 |
| **Static Classes** | 2 |
| **Total Methods** | 72 |
| **Total Properties** | 35 |
| **Total Fields** | 14 |
| **Total Events** | 0 |
| **Total Constructors** | 28 |
| **Nested Types** | 3 |
| **Extension Methods** | 0 |


