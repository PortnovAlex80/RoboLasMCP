# Topomatic.Scripting.IronPython

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Scripting.IronPython` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Scripting.IronPython, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Scripting.IronPython.dll` |

---
## Namespace: `Topomatic.Scripting.IronPython`

### `PythonPackage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Scripting.IronPython.PythonPackage` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CodeContext` | `CodeContext` | `get` | No | `` |
| `Engine` | `ScriptEngine` | `get` | No | `` |
| `IO` | `ScriptIO` | `get` | No | `` |
| `Language` | `LanguageContext` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Object` | `String code` | `` |
| `GetCodeProperties` | `ScriptCodeParseResult` | `String code` | `` |
| `GetService` | `TService` | `Object[] args` | `` |

---
## Namespace: `Topomatic.Scripting.IronPython.Dlr`

### `DlrModule` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Scripting.IronPython.Dlr.DlrModule` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `convertAs` | `Object` | `CodeContext context, Object obj, Type type` | `` |
| `params` | `Object` | `Object[] types` | `` |
| `result` | `Object` | `Object type` | `` |

### `ParamsChecker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Scripting.IronPython.Dlr.ParamsChecker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object[] prms)`

### `ResultChecker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Scripting.IronPython.Dlr.ResultChecker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object returnType)`

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `retType` | `Object` | No | `` | `` |

### `RuntimeParamsChecker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Scripting.IronPython.Dlr.RuntimeParamsChecker` |
| **Base Type** | `IronPython.Runtime.PythonProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `IronPython.Runtime.Types.PythonTypeSlot`
    - `IronPython.Runtime.Types.PythonTypeDataSlot`
      - `IronPython.Runtime.PythonProperty`
        - `Topomatic.Scripting.IronPython.Dlr.RuntimeParamsChecker`

#### Constructors (2)

- `.ctor(Object function, Object[] expectedArgs)`
- `.ctor(Object instance, Object function, Object[] expectedArgs)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expected` | `Object[]` | `get` | No | `` |
| `Function` | `Object` | `get` | No | `` |
| `Instance` | `Object` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `__get__` | `Object` | `CodeContext context, Object instance, Object typeContext` | `` |

### `RuntimeResultChecker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Scripting.IronPython.Dlr.RuntimeResultChecker` |
| **Base Type** | `IronPython.Runtime.PythonProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `IronPython.Runtime.Types.PythonTypeSlot`
    - `IronPython.Runtime.Types.PythonTypeDataSlot`
      - `IronPython.Runtime.PythonProperty`
        - `Topomatic.Scripting.IronPython.Dlr.RuntimeResultChecker`

#### Constructors (2)

- `.ctor(Object function, Object expectedReturn)`
- `.ctor(Object instance, Object function, Object expectedReturn)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Function` | `Object` | `get` | No | `` |
| `Instance` | `Object` | `get` | No | `` |
| `ReturnType` | `Object` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `__get__` | `Object` | `CodeContext context, Object instance, Object owner` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 5 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 8 |
| **Total Properties** | 10 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 7 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


