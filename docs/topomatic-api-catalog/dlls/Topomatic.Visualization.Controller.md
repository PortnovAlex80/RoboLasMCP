# Topomatic.Visualization.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Visualization.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v4.0.30319` |
| **Full Name** | `Topomatic.Visualization.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Visualization.Controller.dll` |

---
## Namespace: `Topomatic.Visualization.Controller`

### `SmdxIncludeHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.SmdxIncludeHandler` |
| **Base Type** | `Topomatic.Visualization.Geometry.IncludeHandler` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Geometry.IncludeHandler`
    - `Topomatic.Visualization.Controller.SmdxIncludeHandler`

#### Constructors (1)

- `.ctor(VisualizationMap map)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Open` | `Stream` | `IncludeHandlerType includeType, String filename` | `` |

### `VizualizationControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.VizualizationControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Visualization.Controller.VizualizationControllerPluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Visualization.Controller.Design`

### `ImElementDataStyleProvider` (class)

**Attributes**: [Obfuscation, SRDisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.Design.ImElementDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Visualization.Controller.Design.ImElementDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `LinearVisualizationSemanticDataStyleProvider` (class)

**Attributes**: [Obfuscation, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.Design.LinearVisualizationSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Visualization.Controller.Design.LinearVisualizationSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `PointVisualizationSemanticDataStyleProvider` (class)

**Attributes**: [Obfuscation, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.Design.PointVisualizationSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Visualization.Controller.Design.PointVisualizationSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `SmdxSemanticDataStyleProvider` (class)

**Attributes**: [DisplayName, Obfuscation]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.Design.SmdxSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Visualization.Controller.Design.SmdxSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

---
## Namespace: `Topomatic.Visualization.Controller.ImpExp3D`

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.ImpExp3D.Wrapper` |
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

### `XmlNodeExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.ImpExp3D.XmlNodeExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAttribute` | `Void` | `XmlNode node, String name, String value` | `Extension` |
| `AddAttribute` | `Void` | `XmlNode node, String name, Double value` | `Extension` |
| `AddAttribute` | `Void` | `XmlNode node, String name, Int32 value` | `Extension` |

---
## Namespace: `Topomatic.Visualization.Controller.ImpExp3D.Fbx`

### `FBXSaver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.ImpExp3D.Fbx.FBXSaver` |
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
| `DestinationFolder` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Save` | `Void` | `Stream stream, GeometryModel3D[] geometryModel3DList` | `` |
| `Save` | `Void` | `Stream stream, VisualizationMap visualizationMap` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BasePoint` | `Vector3D` | No | `` | `` |
| `Scale` | `Double` | No | `` | `` |
| `SwitchYZAxises` | `Boolean` | No | `` | `` |

#### Nested Types (1)

- `Mode` (enum)

### `Mode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Controller.ImpExp3D.Fbx.FBXSaver+Mode` |
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
      - `Topomatic.Visualization.Controller.ImpExp3D.Fbx.FBXSaver+Mode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Binary` | `Mode` | Yes | `Binary` | `` |
| `Text` | `Mode` | Yes | `Text` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Text` | `0` |
| `Binary` | `1` |

**Underlying Type**: `System.Int32`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 10 |
| **Classes** | 8 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 10 |
| **Total Properties** | 7 |
| **Total Fields** | 6 |
| **Total Events** | 0 |
| **Total Constructors** | 8 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


