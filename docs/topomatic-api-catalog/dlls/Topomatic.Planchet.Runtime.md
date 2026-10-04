# Topomatic.Planchet.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Planchet.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Planchet.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Planchet.Runtime.dll` |

---
## Namespace: `Topomatic.Planchet.Runtime`

### `GeneratePlanchetEventArgs` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Runtime.GeneratePlanchetEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.Dwg.DwgLayout, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Planchet.IDwgSheet, Topomatic.Planchet, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Planchet.Runtime.GeneratePlanchetEventArgs`

#### Constructors (1)

- `.ctor(CadViewLayer layer, String path, GeneratePlanchetParams sheets)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `` |
| `Item` | `KeyValuePair<DwgLayout IDwgSheet>` | `get` | No | `` |
| `Layer` | `CadViewLayer` | `get` | No | `` |
| `Model` | `DwgBlock` | `get` | No | `` |
| `Params` | `IDictionary<String Object>` | `get` | No | `` |
| `Path` | `String` | `get` | No | `` |
| `RotateSigns` | `Boolean` | `get/set` | No | `` |
| `SaveFullPath` | `Boolean` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginObject` | `Void` | `String id` | `` |
| `Contains` | `ContainmentType` | `BoundingBox2D box` | `` |
| `Contains` | `ContainmentType` | `Vector2D v` | `` |
| `EndObject` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<DwgLayout IDwgSheet>>` | `` | `` |
| `GetSheetAtPoint` | `IDwgSheet` | `Vector2D v` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `GeneratePlanchetParams` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Runtime.GeneratePlanchetParams` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.Dwg.DwgLayout, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Planchet.IDwgSheet, Topomatic.Planchet, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(KeyValuePair<DwgLayout IDwgSheet>[] sheets, Drawing existing)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `KeyValuePair<DwgLayout IDwgSheet>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplayObjectsMockups` | `Void` | `` | `` |
| `BeginObject` | `Void` | `String id` | `` |
| `EndObject` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<DwgLayout IDwgSheet>>` | `` | `` |
| `RestoreEditedObjects` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `ProjectConfigurationExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Planchet.Runtime.ProjectConfigurationExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadProjectConfiguration` | `ProjectStateConfiguration` | `DwgObject obj` | `Extension` |
| `SaveProjectConfiguration` | `Void` | `DwgObject obj, ProjectStateConfiguration configuration` | `Extension` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 3 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 13 |
| **Total Properties** | 11 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


