# Topomatic.RoadSigns.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.RoadSigns.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.RoadSigns.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.RoadSigns.Runtime.dll` |

---
## Namespace: `Topomatic.RoadSigns.Runtime.RoadSignsLibrary`

### `RoadSignElementLibraryReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignElementLibraryReference` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignElementLibraryReference`

#### Constructors (1)

- `.ctor(Guid guid)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Guid` | `Guid` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetLimits` | `Boolean` | `Model3DView view, Matrix transform, ref BoundingBox2D limits, Double mapscale` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `RoadSignxLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxLibrary` |
| **Base Type** | `Topomatic.Libx.xLibraryCollection`1[[Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxLibraryNode, Topomatic.RoadSigns.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibrary, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Visualization.ITypedObjectCollection` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryCollection`
    - `Topomatic.Libx.xLibraryCollection`1[[Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxLibraryNode, Topomatic.RoadSigns.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxLibrary`

#### Constructors (1)

- `.ctor(String environment)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `RoadSignxLibrary` | `get` | Yes | `` |
| `LibraryName` | `String` | `get` | No | `` |
| `LibraryUid` | `String` | `get` | No | `` |

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

### `RoadSignxLibraryNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxLibraryNode` |
| **Base Type** | `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxNode` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxNode`
      - `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxLibraryNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateMissingSign` | `Drawing` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MissingSignGuidBlockName` | `String` | Yes | `"MissingSign"` | `` |
| `RoadSignDefaultTag` | `String` | Yes | `"RoadSign"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadSignxNode` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxNode` |
| **Base Type** | `Topomatic.Libx.xLibraryNode` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.RoadSigns.Runtime.RoadSignsLibrary.RoadSignxNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawingHash` | `Guid` | `get` | No | `` |
| `GostName` | `String` | `get/set` | No | `` |
| `GostNumber` | `String` | `get/set` | No | `` |
| `IsTemp` | `Boolean` | `get/set` | No | `` |
| `Type` | `ImTypeDescriptor` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDefaultData` | `Drawing` | `` | `` |
| `SetDefaultData` | `Void` | `Drawing value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 4 |
| **Classes** | 3 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 0 |
| **Total Methods** | 18 |
| **Total Properties** | 11 |
| **Total Fields** | 2 |
| **Total Events** | 0 |
| **Total Constructors** | 4 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


