# Topomatic.Alg.Rail.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Rail.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Rail.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Rail.Runtime.dll` |

---
## Namespace: `Topomatic.Alg.Rail.Runtime`

### `RailOldBinarySerializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Runtime.RailOldBinarySerializer` |
| **Base Type** | `Topomatic.Alg.Runtime.AlgOldBinarySerializer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.AlgOldBinarySerializer`
    - `Topomatic.Alg.Rail.Runtime.RailOldBinarySerializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, Alignment alg` | `` |
| `SaveToStream` | `Void` | `Stream stream, Alignment alg, ProgramType type, Int32 version` | `` |

### `RailTemplateBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Runtime.RailTemplateBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.TemplateBuilder` |
| **Implements** | `Topomatic.Crs.ICrsBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsTemplateBuilder`
    - `Topomatic.Crs.Runtime.CrsTemplatePythonBuilder`
      - `Topomatic.Alg.Runtime.TemplateBuilder`
        - `Topomatic.Alg.Rail.Runtime.RailTemplateBuilder`

#### Constructors (1)

- `.ctor(RailAlignment alignment)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Rail.Runtime.Tools`

### `RailDynamicSurfaceBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Runtime.Tools.RailDynamicSurfaceBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.Tools.DynamicSurfaceBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Tools.DynamicSurfaceBuilder`
    - `Topomatic.Alg.Rail.Runtime.Tools.RailDynamicSurfaceBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildCrsSurface` | `Boolean` | `RailAlignment alignment, Surface surface` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 3 |
| **Classes** | 3 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 3 |
| **Total Properties** | 0 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 3 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


