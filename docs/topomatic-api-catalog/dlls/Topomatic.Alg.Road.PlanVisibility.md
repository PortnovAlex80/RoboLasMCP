# Topomatic.Alg.Road.PlanVisibility

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road.PlanVisibility` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.PlanVisibility.dll` |

---
## Namespace: `Topomatic.Alg.Road.PlanVisibility`

### `AlignmentPlanVisibility` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.AlignmentPlanVisibility` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Road.PlanVisibility.IAlignmentPlanVisibilityContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.PlanVisibility.AlignmentPlanVisibility`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Apply` | `Boolean` | `get/set` | No | `` |
| `ObserverHeight` | `Double` | `get/set` | No | `` |
| `ObserverOffset` | `Double` | `get/set` | No | `` |
| `ObserverStep` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Style` | `AlignmentPlanVisibilityStyle` | `get` | No | `` |
| `VisibilityDistance` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildArrows` | `Void` | `Alignment alignment, Double visibilityDistance, Double observerStep, Double startStation, Double endStation, Double offset, Int32 plnIndex, List<Vector2D> points, List<Vector2D> line, List<VisibilityArrow> arrows, Boolean solveValues` | `` |
| `BuildPoints` | `Void` | `Alignment alignment, Double observerHeight, Double startStation, Double endStation, Double offset, Int32 side, List<Vector2D> points` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentPlanVisibilityContainer` | `Topomatic.Alg.Road.PlanVisibility.IAlignmentPlanVisibilityContainer.get_PlanVisibility` |

### `IAlignmentPlanVisibilityContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.IAlignmentPlanVisibilityContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PlanVisibility` | `AlignmentPlanVisibility` | `get` | No | `` |

### `PlanVisibilityConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.PlanVisibilityConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PluginUID` | `String` | Yes | `"Pvb"` | `` |

### `VisibilityArrow` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.VisibilityArrow` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.PlanVisibility.VisibilityArrow`

#### Constructors (1)

- `.ctor(VisibilityArrow other)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `VisibilityArrow other` | `` |
| `Reset` | `Void` | `` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndPosition` | `Vector2D` | No | `` | `` |
| `EndStation` | `Double` | No | `` | `` |
| `PlnItemIndex` | `Int32` | No | `` | `` |
| `StartPosition` | `Vector2D` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |
| `Visibility` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Alg.Road.PlanVisibility.Style`

### `AlignmentPlanVisibilityStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Style.AlignmentPlanVisibilityStyle` |
| **Base Type** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityStyle`
    - `Topomatic.Alg.Road.PlanVisibility.Style.AlignmentPlanVisibilityStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArrowsPlanStyle` | `PlanVisibilityArrowsPlanStyle` | `get` | No | `` |
| `CommonVisPlanStyle` | `PlanVisibilityCommonPlanStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `LinesPlanStyle` | `PlanVisibilityLinesPlanStyle` | `get` | No | `` |
| `PointsPlanStyle` | `PlanVisibilityPointsPlanStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `AlignmentPlanVisibilityStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PlanVisibilityArrowsPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityArrowsPlanStyle` |
| **Base Type** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle`
        - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityArrowsPlanStyle`

#### Constructors (1)

- `.ctor(PlanVisibilityStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanVisibilityCommonPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityCommonPlanStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityCommonPlanStyle`

#### Constructors (1)

- `.ctor(PlanVisibilityStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Apply` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `PlanVisibilityCommonPlanStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PlanVisibilityLinesPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityLinesPlanStyle` |
| **Base Type** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle`
        - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityLinesPlanStyle`

#### Constructors (1)

- `.ctor(PlanVisibilityStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanVisibilityPlanStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle`

#### Constructors (1)

- `.ctor(PlanVisibilityStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `PlanVisibilityPlanStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PlanVisibilityPointsPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPointsPlanStyle` |
| **Base Type** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPlanStyle`
        - `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityPointsPlanStyle`

#### Constructors (1)

- `.ctor(PlanVisibilityStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanVisibilityStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Style.PlanVisibilityStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<AlignmentStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 11 |
| **Classes** | 6 |
| **Interfaces** | 1 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 2 |
| **Static Classes** | 1 |
| **Total Methods** | 18 |
| **Total Properties** | 24 |
| **Total Fields** | 7 |
| **Total Events** | 0 |
| **Total Constructors** | 9 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


