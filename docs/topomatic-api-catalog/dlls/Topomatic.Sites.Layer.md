# Topomatic.Sites.Layer

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Sites.Layer` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Sites.Layer, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Sites.Layer.dll` |

---
## Namespace: `Topomatic.Sites.Layer`

### `SiteObjectController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Layer.SitePlanLayer+SiteObjectController` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CastRay` | `Nullable<Vector3D>` | `SiteObject entity, Ray3D ray` | `` |
| `GetGrips` | `IEnumerable` | `SiteObject entity, Object cadView` | `` |
| `PaintEntity` | `Void` | `SiteObject entity, CadPen pen` | `` |
| `PaintEntity3d` | `Void` | `SiteObject entity, CadPen pen` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetController` | `SiteObjectController` | `SiteObject siteObj` | `` |
| `RegisterController` | `Void` | `String typeName, SiteObjectController controller` | `` |

### `SitePlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Layer.SitePlanLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Sites.Layer.SitePlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Site` | `Site` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SelectLinePoint` | `Boolean` | `String msg, ref SiteLine line, ref Int32 index` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `SitePlanLayer` | `CadView cadView` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `SiteObjectController` (abstract class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 2 |
| **Classes** | 1 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 0 |
| **Total Methods** | 8 |
| **Total Properties** | 4 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 1 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


