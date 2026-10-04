# Topomatic.Alg.Survey

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Survey` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Survey, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Survey.dll` |

---
## Namespace: `Topomatic.Alg.Survey`

### `SurveyAlignment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.SurveyAlignment` |
| **Base Type** | `Topomatic.Alg.Alignment` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IStationingContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Alignment`
        - `Topomatic.Alg.Survey.SurveyAlignment`

#### Constructors (1)

- `.ctor(INamedTransactable owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetAlias` | `Void` | `String alias` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SurveyTransitions` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.SurveyTransitions` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, Topomatic.Alg.Prf.ITransitions, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Survey.SurveyTransitions`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Transition` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetNext` | `Int32` | `Int32 index` | `` |
| `GetPrevious` | `Int32` | `Int32 index` | `` |
| `IndexOf` | `Int32` | `Transition item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `trCl` | `Int32` | Yes | `0` | `` |
| `trLeftDitch` | `Int32` | Yes | `1` | `` |
| `trRightDitch` | `Int32` | Yes | `2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ITransitions` | `get_Item` |
| `ITransitions` | `Clear` |
| `ITransitions` | `IndexOf` |
| `ITransitions` | `GetPrevious` |
| `ITransitions` | `GetNext` |
| `ITransitions` | `get_Count` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.add_Changed` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.remove_Changed` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.add_Undo` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.remove_Undo` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentContainer` | `Topomatic.Alg.IAlignmentContainer.get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Alg.Survey.Vcs`

### `SurveyConflictResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.Vcs.SurveyConflictResolver` |
| **Base Type** | `Topomatic.Alg.Vcs.AlgConflictResolver` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Vcs.AlgConflictResolver`
    - `Topomatic.Alg.Survey.Vcs.SurveyConflictResolver`

#### Constructors (1)

- `.ctor()` - **Default constructor**

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
| **Total Methods** | 7 |
| **Total Properties** | 4 |
| **Total Fields** | 3 |
| **Total Events** | 0 |
| **Total Constructors** | 3 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


