# Topomatic.Glg.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Glg.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Glg.Layers.dll` |

---
## Namespace: `Topomatic.Glg.Layers`

### `AlignmentGeologyExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.AlignmentGeologyExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindDynamicGeology` | `AlignmentGeology` | `Alignment alignment` | `Extension` |
| `FindGeologyCrossSection` | `GeologySection` | `AlignmentGeology geology, Section section` | `Extension` |
| `FindOtherSection` | `Section` | `Alignment current, AlignmentGeology other, Section section` | `Extension` |
| `FindOtherSection` | `Section` | `Alignment current, AlignmentGeology other, Double station` | `Extension` |
| `FindOtherSection` | `Section` | `Alignment current, Alignment other, Section section` | `Extension` |
| `FindOtherSection` | `Section` | `Alignment current, Alignment other, Double station` | `Extension` |
| `FindTest` | `ConePenetrationTest[]` | `BoreholeReference reference` | `Extension` |
| `GetDynamicGeology` | `DynamicGeology` | `Alignment alignment` | `Extension` |
| `GetGeology` | `AlignmentGeology` | `Alignment alignment` | `Extension` |

### `GeologyStyleExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GeologyStyleExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColor` | `CadColor` | `GeologyLayerStyleItem style` | `Extension` |
| `GetEnable` | `Boolean` | `GeologyLayerStyleItem style` | `Extension` |
| `GetLayer` | `DwgLayer` | `GeologyLayerStyleItem style` | `Extension` |
| `GetStandardStyleColor` | `CadColor` | `GeologyLayerStyleItem style` | `Extension` |
| `GetStandardStyleLineWeight` | `Lineweight` | `GeologyLayerStyleItem style` | `Extension` |
| `GetVisible` | `Boolean` | `GeologyLayerStyleItem style` | `Extension` |
| `SetEnable` | `Void` | `GeologyLayerStyleItem style, Boolean value` | `Extension` |
| `SetVisible` | `Void` | `GeologyLayerStyleItem style, Boolean value` | `Extension` |

### `GlgAlignmentEditableItemsController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController` |
| **Base Type** | `Topomatic.Alg.Layers.AlgEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |
| `References` | `IGeologyReferences` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `ILayer` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrsDynamicGeologyBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyBoreholeLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyBoreholeLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyBoreholeLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyBoreholeLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrsDynamicGeologyCptLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyCptLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyCptLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyCptLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyCptLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrsDynamicGeologyImpellerTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyImpellerTestLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyImpellerTestLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyImpellerTestLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyImpellerTestLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrsDynamicGeologyItemsLayer`1<T where IOwned, class, IOwned>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrsDynamicGeologyLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `InvalidateDrawCache` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `LayerSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrsDynamicGeologyLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLinesLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyLinesLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgCrsDynamicGeologyLinesLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLinesLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgGlobalEditableItemsController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgGlobalEditableItemsController` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Glg.Layers.GlgGlobalEditableItemsController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AfterModelChange` | `Void` | `GeologyModel model` | `` |
| `BeforeModelChange` | `Void` | `` | `` |
| `GetLayer` | `ILayer` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgProfileDynamicGeologyBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyBoreholeLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyBoreholeLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyBoreholeLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyBoreholeLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgProfileDynamicGeologyCptLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (2)

- `ProfileConePenetrationTestDrawer` (class)
- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgProfileDynamicGeologyImpellerTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (2)

- `ProfileImpellerTestDrawer` (class)
- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgProfileDynamicGeologyItemsLayer`1<T where IOwned, class, IOwned>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `GlgProfileDynamicGeologyLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `InvalidateDrawCache` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `LayerSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `GlgProfileDynamicGeologyLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLinesLayer` |
| **Base Type** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyLinesLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyItemsLayer`1[[Topomatic.Glg.Layers.GlgProfileDynamicGeologyLinesLayer+Wrapper, Topomatic.Glg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLinesLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `Wrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GroundWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLayer+LayerSelectionSet+GroundWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Contours.GeologyContour, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyLayer layer, GeologyContour contour)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `String` | `get` | No | `` |
| `AreaSignEx` | `String` | `get` | No | `` |
| `AreaSignExScale` | `Double` | `get` | No | `` |
| `AreaSignScale` | `Double` | `get` | No | `` |
| `GroundColor` | `CadColor` | `get` | No | `` |
| `Layer` | `GlgProfileDynamicGeologyLayer` | `get` | No | `Browsable` |
| `WrappedObject` | `GeologyContour` | `get` | No | `Browsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `ReadOnly, WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |

### `GroundWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLayer+LayerSelectionSet+GroundWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Contours.GeologyContour, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GlgCrsDynamicGeologyLayer layer, GeologyContour contour)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `String` | `get` | No | `` |
| `AreaSignEx` | `String` | `get` | No | `` |
| `AreaSignExScale` | `Double` | `get` | No | `` |
| `AreaSignScale` | `Double` | `get` | No | `` |
| `GroundColor` | `CadColor` | `get` | No | `` |
| `Layer` | `GlgCrsDynamicGeologyLayer` | `get` | No | `Browsable` |
| `WrappedObject` | `GeologyContour` | `get` | No | `Browsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `ReadOnly, WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |

### `LayerSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLayer+LayerSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLayer+LayerSelectionSet`

#### Constructors (1)

- `.ctor(GlgCrsDynamicGeologyLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Nested Types (1)

- `GroundWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `LayerSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLayer+LayerSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLayer+LayerSelectionSet`

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Nested Types (1)

- `GroundWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `ProfileConePenetrationTestDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer+ProfileConePenetrationTestDrawer` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.AlignmentConePenetrationTestDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.AlignmentConePenetrationTestDrawer`
    - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer+ProfileConePenetrationTestDrawer`

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyCptLayer layer)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, ConePenetrationTest conePenetrationTest, Vector2D position` | `` |
| `GetLimits` | `Boolean` | `ConePenetrationTest algCptTest, ref BoundingBox2D limits` | `` |

### `ProfileImpellerTestDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer+ProfileImpellerTestDrawer` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.AlignmentImpellerTestDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.AlignmentImpellerTestDrawer`
    - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer+ProfileImpellerTestDrawer`

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyImpellerTestLayer layer)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, ImpellerTest impellerTest, Vector2D position, Double elevation` | `` |
| `GetLimits` | `Boolean` | `ImpellerTest impellerTest, Vector2D position, ref BoundingBox2D limits` | `` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyLinesLayer+Wrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Permafrost.GeologyLine, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyLinesLayer owner, GeologyLine line)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `ByLayer, ByBlock` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `TypedObjectWrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `ReadOnly, TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |
| `WrappedObject` | `GeologyLine` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyLinesLayer+Wrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Permafrost.GeologyLine, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GlgCrsDynamicGeologyLinesLayer owner, GeologyLine line)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `ByLayer, ByBlock` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `TypedObjectWrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `ReadOnly, TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |
| `WrappedObject` | `GeologyLine` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer+Wrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.ImpellerTestWrapper` |
| **Implements** | `Topomatic.Glg.IImpellerConstTableContainer, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.ImpellerTestWrapper`
    - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyImpellerTestLayer+Wrapper`

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyImpellerTestLayer owner, ImpellerTest test, Double station, Double offset, Double elevation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `Offset` | `Double` | `get` | No | `Length` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `StationStr` | `String` | `get` | No | `` |
| `WrappedObject` | `ImpellerTest` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyImpellerTestLayer+Wrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.ImpellerTestWrapper` |
| **Implements** | `Topomatic.Glg.IImpellerConstTableContainer, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.ImpellerTestWrapper`
    - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyImpellerTestLayer+Wrapper`

#### Constructors (1)

- `.ctor(GlgCrsDynamicGeologyImpellerTestLayer owner, ImpellerTest test, Double station, Double offset, Double elevation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `Offset` | `Double` | `get` | No | `Length` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `StationStr` | `String` | `get` | No | `` |
| `WrappedObject` | `ImpellerTest` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyBoreholeLayer+Wrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper`
    - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyBoreholeLayer+Wrapper`

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyBoreholeLayer owner, Borehole borehole, Double station, Double offset, Double elevation, Boolean isDummy)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `IsDummy` | `Boolean` | `get` | No | `Browsable` |
| `Offset` | `Double` | `get` | No | `Length` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `StationStr` | `String` | `get` | No | `` |
| `WrappedObject` | `Borehole` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyBoreholeLayer+Wrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper`
    - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyBoreholeLayer+Wrapper`

#### Constructors (1)

- `.ctor(GlgCrsDynamicGeologyBoreholeLayer owner, Borehole borehole, Double station, Double offset, Double elevation, Boolean isDummy)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `IsDummy` | `Boolean` | `get` | No | `Browsable` |
| `Offset` | `Double` | `get` | No | `Length` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `StationStr` | `String` | `get` | No | `` |
| `WrappedObject` | `Borehole` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer+Wrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.ConePenetrationTestWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.ConePenetrationTestWrapper`
    - `Topomatic.Glg.Layers.GlgProfileDynamicGeologyCptLayer+Wrapper`

#### Constructors (1)

- `.ctor(GlgProfileDynamicGeologyCptLayer owner, ConePenetrationTest test, Vector2D pos, Double station, Double offset, Double elevation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `Offset` | `Double` | `get` | No | `Length` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `StationStr` | `String` | `get` | No | `` |
| `WrappedObject` | `ConePenetrationTest` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Wrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.GlgCrsDynamicGeologyCptLayer+Wrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.ConePenetrationTestWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.ConePenetrationTestWrapper`
    - `Topomatic.Glg.Layers.GlgCrsDynamicGeologyCptLayer+Wrapper`

#### Constructors (1)

- `.ctor(GlgCrsDynamicGeologyCptLayer owner, ConePenetrationTest test, Vector2D pos, Double station, Double offset, Double elevation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `Offset` | `Double` | `get` | No | `Length` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `StationStr` | `String` | `get` | No | `` |
| `WrappedObject` | `ConePenetrationTest` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Glg.Layers.Design`

### `ElevationGlobalEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Design.ElevationGlobalEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Glg.Layers.Design.ElevationGlobalEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `ElevationGlobalEditorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Design.ElevationGlobalEditorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditorAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyEditorAttribute`
      - `Topomatic.Glg.Layers.Design.ElevationGlobalEditorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IElevationCalcer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Design.IElevationCalcer` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Offset` | `Double` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

### `SondeTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Design.SondeTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Layers.Design.SondeTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Glg.Layers.Drawers`

### `AlignmentConePenetrationTestDrawer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.AlignmentConePenetrationTestDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, ConePenetrationTest cpt, Vector2D position` | `` |
| `DrawConePenetrationTest` | `Void` | `CadPen pen, Boolean enable, ConePenetrationTest cpt, GeologyProfileStyle style, Double screenRatio` | `` |
| `DrawConePenetrationTest` | `Void` | `CadPen pen, Boolean enable, ConePenetrationTest cpt, GeologyCrossSectionStyle style, Double screenRatio` | `` |
| `GetLimits` | `Boolean` | `ConePenetrationTest cpt, ref BoundingBox2D limits` | `` |

### `AlignmentImpellerTestDrawer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.AlignmentImpellerTestDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, ImpellerTest impellerTest, Vector2D position, Double elevation` | `` |
| `DrawImpellerTest` | `Void` | `CadPen pen, Boolean enable, ImpellerTest impellerTest, ImpellerTestSectionStyle style, Double elevation, Double textSize, Boolean showAbsElev, Double screenRatio, ApplImpellerTestLayer applyTo` | `` |
| `GetLimits` | `Boolean` | `ImpellerTest impellerTest, Vector2D position, ref BoundingBox2D limits` | `` |

### `ApplImpellerTestLayer` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.ApplImpellerTestLayer` |
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
      - `Topomatic.Glg.Layers.Drawers.ApplImpellerTestLayer`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossSection` | `ApplImpellerTestLayer` | Yes | `CrossSection` | `` |
| `Profile` | `ApplImpellerTestLayer` | Yes | `Profile` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Profile` | `0` |
| `CrossSection` | `1` |

**Underlying Type**: `System.Int32`

### `BaseBoreholeDrawer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.BaseBoreholeDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, Borehole borehole, Vector2D position, Double boreholeElevation, Boolean isDummy` | `` |
| `GetLimits` | `Boolean` | `Borehole borehole, Vector2D position, ref BoundingBox2D limits` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBoreholeTypeWidthExtended` | `Double` | `BoreholeType boreholeType, Double screenRatio` | `` |

### `GeologyLineDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.GeologyLineDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object parent, Double scale)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawLine` | `Void` | `GeologyLine line, CadPen pen, Boolean enable` | `` |

### `PlanBoreholeDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.PlanBoreholeDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Vector2D position, GeologyPlanStyleBoreholes style, Double annotationScale, Borehole borehole` | `` |
| `DrawLine` | `Void` | `DeviceContext dc, BoreholeTable table, GeologyStructureLine line` | `` |
| `GetBounds` | `BoundingBox2D` | `Vector2D position, GeologyPlanStyleBoreholes style, Double angle, Double annotationScale, Borehole borehole` | `` |
| `GetGeneralBounds` | `BoundingBox2D` | `Vector2D position, GeologyPlanStyleBoreholes style, Double annotationScale, Borehole borehole` | `` |
| `GetWaterPlaneTextBounds` | `BoundingBox2D` | `Vector2D position, GeologyPlanStyleBoreholes style, Double annotationScale, BoreholeWaterPlaneLevel boreholeWaterPlaneLevel` | `` |
| `Layout` | `Void` | `DwgBlock block, Double angle, Vector2D position, Single bigRadius, Double annotationScale, Borehole borehole` | `` |

### `PlanConePenetrationTestDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.PlanConePenetrationTestDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, Vector2D position, Single signSize, Double annotationScale` | `` |
| `FindTest` | `ConePenetrationTest` | `IGeologyReferences references, ConePenetrationReferenceEditableItemKey key` | `` |
| `GetBoreholeCptPos` | `Vector3D` | `GlobalGeologyStyle style, Borehole borehole, Double annotationScale, Int32 indexInBorehole` | `` |
| `GetBounds` | `BoundingBox2D` | `Vector2D position, Double angle, Single signSize, Double annotationScale, String number, Double elevation` | `` |
| `GetLimits` | `BoundingBox2D` | `Vector2D position, Single signSize, Double annotationScale` | `` |
| `Layout` | `Void` | `DwgBlock block, Double angle, Vector2D position, Single signSize, Double annotationScale, String number, Double elevation` | `` |
| `TryGetBoreholeCptPos` | `Boolean` | `Alignment alignment, AlignmentGeologyStyle style, BoreholeReference reference, Double annotationScale, Int32 indexInBorehole, ref Vector3D pos` | `` |
| `TryGetCptPos` | `Boolean` | `Alignment alignment, ConePenetrationTestReference reference, ref Vector3D pos` | `` |
| `TryGetPos` | `Boolean` | `BoreholeTable boreholeTable, ConePenetrationTestTable cptTable, GlobalGeologyStyle style, ConePenetrationEditableItemKey key, Double annotationScale, ref Vector3D pos` | `` |
| `TryGetPos` | `Boolean` | `IGeologyReferences references, ConePenetrationReferenceEditableItemKey key, Double annotationScale, ref Vector3D pos` | `` |

### `PlanImpellerTestDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.PlanImpellerTestDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Vector2D position, Single bigRadius, Double annotationScale` | `` |
| `GetBounds` | `BoundingBox2D` | `Vector2D position, Double angle, Single bigRadius, Double annotationScale, String number, Double elevation` | `` |
| `Layout` | `Void` | `DwgBlock block, Double angle, Vector2D position, Single bigRadius, Double annotationScale, String number, Double elevation` | `` |

---
## Namespace: `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer`

### `AlignmentBoreholeCommonWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.AlignmentBoreholeCommonWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper`
    - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.AlignmentBoreholeCommonWrapper`

#### Constructors (1)

- `.ctor(Object parent, BoreholeReference borehole)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArchiveNumber` | `String` | `get` | No | `` |
| `Borehole` | `BoreholeReference` | `get` | No | `Browsable` |
| `BoreholeType` | `BoreholeType` | `get` | No | `` |
| `BoringDate` | `String` | `get` | No | `` |
| `ConstructionType` | `String` | `get` | No | `` |
| `Depth` | `Double` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DrillingEquipmentType` | `String` | `get` | No | `` |
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `Number` | `String` | `get` | No | `` |
| `Offset` | `Double` | `get` | No | `Length` |
| `WaterPlane` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlignmentImpellerTestCommonWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.AlignmentImpellerTestCommonWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper`
    - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.AlignmentImpellerTestCommonWrapper`

#### Constructors (1)

- `.ctor(Object parent, ImpellerTestReference impellerTest)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Elevation` | `Double` | `get` | No | `Elevation` |
| `ImpellerTest` | `ImpellerTestReference` | `get` | No | `Browsable` |
| `Key` | `ImpellerConstKeyRec` | `get` | No | `` |
| `Number` | `String` | `get` | No | `` |
| `Offset` | `Double` | `get` | No | `Length` |
| `TestingDate` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CommonGeologyDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.CommonGeologyDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AlignmentGeology geology, GeologyCompoundStyle style)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get` | No | `` |
| `Section` | `GeologySection` | `get` | No | `` |
| `Style` | `GeologyCompoundStyle` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDrawItems` | `List<CommonGeologyDrawerItem>` | `CadView cadView` | `` |
| `Invalidate` | `Void` | `` | `` |

### `CommonGeologyDrawerItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.CommonGeologyDrawerItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CommonGeologyDrawer drawer)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Drawer` | `CommonGeologyDrawer` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Wrapper` | `Object` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `CommonSectionGeologyDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.CommonSectionGeologyDrawer` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.CommonGeologyDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.CommonGeologyDrawer`
    - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.CommonSectionGeologyDrawer`

#### Constructors (1)

- `.ctor(Alignment alignment, AlignmentGeology geology, Double sectionStation, GeologyCompoundStyle style)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Section` | `GeologySection` | `get` | No | `` |

### `GeologyCommonWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `GeologyCompoundStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCompoundStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Style.GeologyStyleItem, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyle`
    - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCompoundStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeDrawStyle` | `BoreholeDrawStyle` | `get/set` | No | `` |
| `CommonStyle` | `GeologyCommonStyle` | `get/set` | No | `` |
| `LayerStyles` | `IEnumerable<GeologyLayerStyleItem>` | `get` | No | `` |
| `ProfileStyle` | `GeologyProfileStyle` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyContourCommonWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyContourCommonWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper`
    - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyContourCommonWrapper`

#### Constructors (1)

- `.ctor(Object parent, GeologyContour contour, Boolean isRoot)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `String` | `get` | No | `` |
| `AreaSignEx` | `String` | `get` | No | `` |
| `AreaSignExScale` | `Double` | `get` | No | `` |
| `AreaSignScale` | `Double` | `get` | No | `` |
| `Contour` | `GeologyContour` | `get` | No | `Browsable` |
| `GroundAggregates` | `UpdatableTypedObjectWrapper` | `get` | No | `ReadOnly, WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |
| `GroundColor` | `CadColor` | `get` | No | `` |
| `Scale` | `Double` | `get` | No | `` |
| `VertexCount` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeologyGeneralDisplayStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyGeneralDisplayStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawBoreholes` | `Boolean` | `get/set` | No | `` |
| `DrawContours` | `Boolean` | `get/set` | No | `` |
| `DrawGeologyLines` | `Boolean` | `get/set` | No | `` |
| `DrawImpellerTests` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyLineCommonWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyLineCommonWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyCommonWrapper`
    - `Topomatic.Glg.Layers.Drawers.CommonGeologyDrawer.GeologyLineCommonWrapper`

#### Constructors (1)

- `.ctor(Object parent, GeologyLine line)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `ByLayer, ByBlock` |
| `Line` | `GeologyLine` | `get` | No | `Browsable` |
| `VertexCount` | `Int32` | `get` | No | `` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `ReadOnly, TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Layers.EditableLayers`

### `BoreholeEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.BoreholeEiDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `CadPen pen, Vector2D boreholePosition, Vector2D textOffset, Boolean drawJoinLine, GeologyPlanStyleBoreholes style, Double annotationScale, Double currentScale, Borehole borehole, Double elevation` | `` |
| `GetTextPosition` | `Vector2D` | `Vector2D boreholePosition, Double annotationScale, GeologyPlanStyleBoreholes style, Borehole borehole, Boolean checkWaterPlane` | `` |
| `LayoutItem` | `Void` | `DwgBlock block, Double angle, Vector2D boreholePosition, Vector2D textOffset, Boolean drawJoinLine, GeologyPlanStyleBoreholes style, Double annotationScale, Borehole borehole, Double elevation` | `` |
| `TryGetTextBounds` | `Boolean` | `Vector2D boreholePosition, Vector2D textOffset, GeologyPlanStyleBoreholes style, Double annotationScale, Borehole borehole, Double elevation, ref BoundingBox2D bounds` | `` |

### `ConePenetrationTestEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.ConePenetrationTestEiDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `CadPen pen, Vector2D conePenetrationTestPosition, Vector2D textOffset, Boolean drawJoinLine, TextStandard textStandard, Double annotationScale, Double currentScale, Single signSize, String number, Nullable<Double> elevation` | `` |
| `GetTextPosition` | `Vector2D` | `Vector2D conePenetrationTestPosition, Double annotationScale, Double signSize` | `` |
| `LayoutItem` | `Void` | `DwgBlock block, Double angle, Vector2D conePenetrationTestPosition, Vector2D textOffset, Boolean drawJoinLine, TextStandard textStandard, Double annotationScale, Single signSize, String number, Nullable<Double> elevation` | `` |
| `TryGetTextBounds` | `Boolean` | `Vector2D conePenetrationTestPosition, Vector2D textOffset, Double signSize, TextStandard textStandard, Double annotationScale, String number, Double elevation, ref BoundingBox2D bounds` | `` |

### `GlgEditableItemsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.GlgEditableItemsLayer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.EditableItems.EditableItemsLayer`
      - `Topomatic.Glg.Layers.EditableLayers.GlgEditableItemsLayer`

#### Constructors (1)

- `.ctor(EditableItemsController controller, Guid guid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |

### `ImpellerTestEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.ImpellerTestEiDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `CadPen pen, Vector2D impellerTestPosition, Vector2D textOffset, Boolean drawJoinLine, TextStandard textStandard, Double annotationScale, Double currentScale, Single bigRadius, String number, Double elevation` | `` |
| `GetTextPosition` | `Vector2D` | `Vector2D impellerTestPosition, Double annotationScale, Double bigRadius` | `` |
| `LayoutItem` | `Void` | `DwgBlock block, Double angle, Vector2D impellerTestPosition, Vector2D textOffset, Boolean drawJoinLine, TextStandard textStandard, Double annotationScale, Single bigRadius, String number, Double elevation` | `` |
| `TryGetTextBounds` | `Boolean` | `Vector2D impellerTestPosition, Vector2D textOffset, Double bigRadius, TextStandard textStandard, Double annotationScale, String number, Double elevation, ref BoundingBox2D bounds` | `` |

### `PlanAlignmentBoreholeEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentBoreholeEiController` |
| **Base Type** | `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController`
        - `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentBoreholeEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindBorehole` | `BoreholeReference` | `ReferenceEditableItemKey key, IGeologyReferences references` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `PlanAlignmentBoreholeEiDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanAlignmentBoreholeEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalImpellerTestEiController+PlanAlignmentBoreholeEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalImpellerTestEiController+PlanAlignmentBoreholeEiDrawer`

#### Constructors (1)

- `.ctor(ImpellerTestTable table, GeologyPlanStyleImpeller style, CadView cadView)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `PlanAlignmentBoreholeEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController+PlanAlignmentBoreholeEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController+PlanAlignmentBoreholeEiDrawer`

#### Constructors (1)

- `.ctor(BoreholeTable boreholeTable, GeologyPlanStyleBoreholes style, CadView cadView)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `PlanAlignmentBoreholeEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentBoreholeEiController+PlanAlignmentBoreholeEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentBoreholeEiController+PlanAlignmentBoreholeEiDrawer`

#### Constructors (1)

- `.ctor(Alignment alignment, IGeologyReferences references, GeologyPlanStyleBoreholes style, CadView cadView)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `PlanAlignmentBoreholeEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentImpellerTestEiController+PlanAlignmentBoreholeEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentImpellerTestEiController+PlanAlignmentBoreholeEiDrawer`

#### Constructors (1)

- `.ctor(Alignment alignment, IGeologyReferences references, GeologyPlanStyleImpeller style, CadView cadView)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `PlanAlignmentConePenetrationTestEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentConePenetrationTestEiController` |
| **Base Type** | `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController`
        - `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentConePenetrationTestEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `PlanAlignmentConePenetrationTestEiDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanAlignmentConePenetrationTestEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentConePenetrationTestEiController+PlanAlignmentConePenetrationTestEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentConePenetrationTestEiController+PlanAlignmentConePenetrationTestEiDrawer`

#### Constructors (1)

- `.ctor(Alignment alignment, IGeologyReferences refernces, GeologyPlanStyleConePenetration style, CadView cadView)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `PlanAlignmentImpellerTestEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentImpellerTestEiController` |
| **Base Type** | `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Glg.Layers.GlgAlignmentEditableItemsController`
        - `Topomatic.Glg.Layers.EditableLayers.PlanAlignmentImpellerTestEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `PlanAlignmentBoreholeEiDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanGlobalBoreholeEiController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController` |
| **Base Type** | `Topomatic.Glg.Layers.GlgGlobalEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Glg.Layers.GlgGlobalEditableItemsController`
      - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeTable` | `BoreholeTable` | `get` | No | `` |
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AfterModelChange` | `Void` | `GeologyModel model` | `` |
| `BeforeModelChange` | `Void` | `` | `` |
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Nested Types (1)

- `PlanAlignmentBoreholeEiDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanGlobalConePenetrationTestEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalConePenetrationTestEiController` |
| **Base Type** | `Topomatic.Glg.Layers.GlgGlobalEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Glg.Layers.GlgGlobalEditableItemsController`
      - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalConePenetrationTestEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AfterModelChange` | `Void` | `GeologyModel model` | `` |
| `BeforeModelChange` | `Void` | `` | `` |
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `PlanGlobalConePenetrationTestEiDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanGlobalConePenetrationTestEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalConePenetrationTestEiController+PlanGlobalConePenetrationTestEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalConePenetrationTestEiController+PlanGlobalConePenetrationTestEiDrawer`

#### Constructors (1)

- `.ctor(ConePenetrationTestTable table, BoreholeTable boreholeTable, GlobalGeologyStyle style, CadView cadView)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `PlanGlobalFictiveBoreholeEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalFictiveBoreholeEiController` |
| **Base Type** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Glg.Layers.GlgGlobalEditableItemsController`
      - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController`
        - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalFictiveBoreholeEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanGlobalGeneralBoreholeEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalGeneralBoreholeEiController` |
| **Base Type** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Glg.Layers.GlgGlobalEditableItemsController`
      - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalBoreholeEiController`
        - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalGeneralBoreholeEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanGlobalImpellerTestEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.EditableLayers.PlanGlobalImpellerTestEiController` |
| **Base Type** | `Topomatic.Glg.Layers.GlgGlobalEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Glg.Layers.GlgGlobalEditableItemsController`
      - `Topomatic.Glg.Layers.EditableLayers.PlanGlobalImpellerTestEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologyStyle` | `GeologyLayerStyleItem` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AfterModelChange` | `Void` | `GeologyModel model` | `` |
| `BeforeModelChange` | `Void` | `` | `` |
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `PlanAlignmentBoreholeEiDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Layers.Layers`

### `BoreholeWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgSectionBoreholeLayer+BoreholeWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.GlobalBoreholeWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper`
    - `Topomatic.Glg.Layers.Wrappers.GlobalBoreholeWrapper`
      - `Topomatic.Glg.Layers.Layers.GlgSectionBoreholeLayer+BoreholeWrapper`

#### Constructors (1)

- `.ctor(GlgSectionBoreholeLayer layer, Borehole borehole, Int32 index, Double station)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `Browsable` |
| `Layer` | `GlgSectionBoreholeLayer` | `get` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeologyCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GeologyCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Glg.IBoreholeTableContainer, Topomatic.Glg.IGroundTableContainer, Topomatic.Glg.IGlobalGeologyContainer, Topomatic.Glg.ILabTableContainer, Topomatic.Glg.IImpellerConstTableContainer, Topomatic.Glg.IConePenetrationTableContainer, Topomatic.Glg.IImpellerTestTableContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Glg.Layers.Layers.GeologyCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `BoreholeTable` | `BoreholeTable` | `get` | No | `` |
| `ConePenetrationTestTable` | `ConePenetrationTestTable` | `get` | No | `` |
| `GroundTable` | `GroundTable` | `get` | No | `` |
| `ImpellerConstTable` | `ImpellerConstTable` | `get` | No | `` |
| `ImpellerTestTable` | `ImpellerTestTable` | `get` | No | `` |
| `LabTable` | `LabTable` | `get` | No | `` |
| `Model` | `GeologyModel` | `get/set` | No | `` |
| `Style` | `GlobalGeologyStyle` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `GetSubLayers` |
| `IBoreholeTableContainer` | `get_BoreholeTable` |
| `IGroundTableContainer` | `get_GroundTable` |
| `IGlobalGeologyContainer` | `get_Style` |
| `IGlobalGeologyContainer` | `get_BoreholeEditableItems` |
| `ILabTableContainer` | `get_LabTable` |
| `IImpellerConstTableContainer` | `get_ImpellerConstTable` |
| `IConePenetrationTableContainer` | `get_ConePenetrationTestTable` |
| `IImpellerTestTableContainer` | `get_ImpellerTestTable` |

### `GeologyPlanCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GeologyPlanCompoundLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GeologyCompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Glg.IBoreholeTableContainer, Topomatic.Glg.IGroundTableContainer, Topomatic.Glg.IGlobalGeologyContainer, Topomatic.Glg.ILabTableContainer, Topomatic.Glg.IImpellerConstTableContainer, Topomatic.Glg.IConePenetrationTableContainer, Topomatic.Glg.IImpellerTestTableContainer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Glg.Layers.Layers.GeologyCompoundLayer`
        - `Topomatic.Glg.Layers.Layers.GeologyPlanCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

### `GlgCrossSectionBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgCrossSectionBoreholeLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.Layers.GlgCrossSectionBoreholeLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrossSectionConePenetrationTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgCrossSectionConePenetrationTestLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.Layers.GlgCrossSectionConePenetrationTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrossSectionContours` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgCrossSectionContours` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.Layers.GlgCrossSectionContours`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoundContour` | `GeologyContour` | `get` | No | `` |
| `DenyInvalidateDrawCache` | `Boolean` | `get/set` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `GeologySection` | `GeologySection` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Selectable` | `IEnumerable` | `get` | No | `` |
| `Selected` | `List<GeologyContour>` | `get` | No | `` |
| `SelectionCount` | `Int32` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSelected` | `GeologyContour` | `Int32 index` | `` |
| `InvalidateDrawCache` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `GlgCrossSectionSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `GlgCrossSectionImpellerTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgCrossSectionImpellerTestLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.Layers.GlgCrossSectionImpellerTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgCrossSectionLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgCrossSectionLinesLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Glg.Layers.Layers.GlgCrossSectionLinesLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `GeologySection` | `GeologySection` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Selectable` | `IEnumerable` | `get` | No | `` |
| `Selected` | `List<GeologyLine>` | `get` | No | `` |
| `SelectionCount` | `Int32` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSelected` | `GeologyLine` | `Int32 index` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `GlgLinesCrossSectionSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `GlgCrossSectionSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgCrossSectionContours+GlgCrossSectionSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Glg.Layers.Layers.GlgCrossSectionContours+GlgCrossSectionSelectionSet`

#### Constructors (1)

- `.ctor(GlgCrossSectionContours layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `GlgLinesCrossSectionSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgCrossSectionLinesLayer+GlgLinesCrossSectionSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Glg.Layers.Layers.GlgCrossSectionLinesLayer+GlgLinesCrossSectionSelectionSet`

#### Constructors (1)

- `.ctor(GlgCrossSectionLinesLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `GlgLinesProfileSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileLinesLayer+GlgLinesProfileSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Glg.Layers.Layers.GlgProfileLinesLayer+GlgLinesProfileSelectionSet`

#### Constructors (1)

- `.ctor(GlgProfileLinesLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `GlgProfileBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileBoreholeLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.GlgProfileBoreholeLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawer` | `BaseBoreholeDrawer` | `get` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `ProfileBoreholeDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `GlgProfileConePenetrationTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileConePenetrationTestLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.GlgProfileConePenetrationTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawer` | `ProfileConePenetrationTestDrawer` | `get` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `ProfileConePenetrationTestDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `GlgProfileImpellerTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileImpellerTestLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.GlgProfileImpellerTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawer` | `AlignmentImpellerTestDrawer` | `get` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `ProfileImpellerTestDrawer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `GlgProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.GlgProfileLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoundContour` | `GeologyContour` | `get` | No | `` |
| `CommonBoundContour` | `GeologyContour` | `get` | No | `` |
| `CommonGeologySection` | `GeologySection` | `get` | No | `` |
| `DenyInvalidateDrawCache` | `Boolean` | `get/set` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `GeologySection` | `GeologySection` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Selectable` | `IEnumerable` | `get` | No | `` |
| `SelectionCount` | `Int32` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSelected` | `GeologyContour` | `Int32 index` | `` |
| `InvalidateDrawCache` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `GlgProfileSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |

### `GlgProfileLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileLinesLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.GlgProfileLinesLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonGeologySection` | `GeologySection` | `get` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `GeologySection` | `GeologySection` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Selectable` | `IEnumerable` | `get` | No | `` |
| `Selected` | `List<GeologyLine>` | `get` | No | `` |
| `SelectionCount` | `Int32` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSelected` | `GeologyLine` | `Int32 index` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `GlgLinesProfileSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |

### `GlgProfileSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileLayer+GlgProfileSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Glg.Layers.Layers.GlgProfileLayer+GlgProfileSelectionSet`

#### Constructors (1)

- `.ctor(GlgProfileLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `GlgSectionBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgSectionBoreholeLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.GlgSectionBoreholeLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Invalidate` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `BoreholeWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `GlgSectionContourLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgSectionContourLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.GlgSectionContourLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DenyInvalidateDrawCache` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Model` | `GeologyModel` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Selectable` | `IEnumerable` | `get` | No | `` |
| `SelectionCount` | `Int32` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSelected` | `GeologyContour` | `Int32 index` | `` |
| `InvalidateDrawCache` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `SectionGlobalSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |

### `GlobalGlgLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanAlignmentBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanAlignmentBoreholeLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanAlignmentBoreholeLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `PlanAlignmentConePenetrationTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanAlignmentConePenetrationTestLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanAlignmentConePenetrationTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `PlanAlignmentDummyDirectionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanAlignmentDummyDirectionLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanAlignmentDummyDirectionLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `PlanAlignmentImpellerTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanAlignmentImpellerTestLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanAlignmentImpellerTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `PlanGlobalBoreholeLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeEditableItemsTable` | `SimpleEditedItemsTable` | `get` | No | `` |
| `BoreholeTable` | `BoreholeTable` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Style` | `GeologyPlanStyleBoreholes` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `PlanGlobalBoreholeLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLinesLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLinesLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeTable` | `BoreholeTable` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Style` | `GeologyPlanStyleLines` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `PlanGlobalBulkLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanGlobalBulkLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanGlobalBulkLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Model` | `GeologyModel` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Invalidate` | `Void` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBulkLayer` | `PlanGlobalBulkLayer` | `CadView cadview, Boolean readOnly` | `` |
| `GetBulkLayer` | `PlanGlobalBulkLayer` | `CadView cadview` | `` |
| `GetLayers` | `IEnumerable<PlanGlobalBulkLayer>` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `PlanGlobalConePenetrationTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanGlobalConePenetrationTestLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanGlobalConePenetrationTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EditableItemsTable` | `SimpleEditedItemsTable` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Style` | `GeologyPlanStyleConePenetration` | `get` | No | `` |
| `Table` | `ConePenetrationTestTable` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `PlanGlobalFictiveBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanGlobalFictiveBoreholeLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLayer`
        - `Topomatic.Glg.Layers.Layers.PlanGlobalFictiveBoreholeLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanGlobalGeneralBoreholeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanGlobalGeneralBoreholeLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanGlobalBoreholeLayer`
        - `Topomatic.Glg.Layers.Layers.PlanGlobalGeneralBoreholeLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanGlobalImpellerTestLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.PlanGlobalImpellerTestLayer` |
| **Base Type** | `Topomatic.Glg.Layers.Layers.GlobalGlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Glg.Layers.Layers.GlobalGlgLayer`
      - `Topomatic.Glg.Layers.Layers.PlanGlobalImpellerTestLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EditableItemsTable` | `SimpleEditedItemsTable` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Style` | `GeologyPlanStyleImpeller` | `get` | No | `` |
| `Table` | `ImpellerTestTable` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Name` |

### `ProfileBoreholeDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileBoreholeLayer+ProfileBoreholeDrawer` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.BaseBoreholeDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.BaseBoreholeDrawer`
    - `Topomatic.Glg.Layers.Layers.GlgProfileBoreholeLayer+ProfileBoreholeDrawer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `CadView` | `CadView` | `get/set` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, Borehole borehole, Vector2D position, Double elevation, Boolean isDummy` | `` |
| `GetLimits` | `Boolean` | `Borehole borehole, Vector2D position, ref BoundingBox2D limits` | `` |

### `ProfileConePenetrationTestDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileConePenetrationTestLayer+ProfileConePenetrationTestDrawer` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.AlignmentConePenetrationTestDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.AlignmentConePenetrationTestDrawer`
    - `Topomatic.Glg.Layers.Layers.GlgProfileConePenetrationTestLayer+ProfileConePenetrationTestDrawer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `CadView` | `CadView` | `get/set` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, ConePenetrationTest conePenetrationTest, Vector2D position` | `` |
| `GetLimits` | `Boolean` | `ConePenetrationTest algCptTest, ref BoundingBox2D limits` | `` |

### `ProfileImpellerTestDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgProfileImpellerTestLayer+ProfileImpellerTestDrawer` |
| **Base Type** | `Topomatic.Glg.Layers.Drawers.AlignmentImpellerTestDrawer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Drawers.AlignmentImpellerTestDrawer`
    - `Topomatic.Glg.Layers.Layers.GlgProfileImpellerTestLayer+ProfileImpellerTestDrawer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `CadView` | `CadView` | `get/set` | No | `` |
| `Geology` | `AlignmentGeology` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable, ImpellerTest impellerTest, Vector2D position, Double elevation` | `` |
| `GetLimits` | `Boolean` | `ImpellerTest impellerTest, Vector2D position, ref BoundingBox2D limits` | `` |

### `SectionGlobalSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Layers.GlgSectionContourLayer+SectionGlobalSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Glg.Layers.Layers.GlgSectionContourLayer+SectionGlobalSelectionSet`

#### Constructors (1)

- `.ctor(GlgSectionContourLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

---
## Namespace: `Topomatic.Glg.Layers.Settings`

### `BoreholePrefixesEnvironmentSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Settings.BoreholePrefixesEnvironmentSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PrefixForType_Borehole` | `String` | `get/set` | No | `` |
| `PrefixForType_BorePit` | `String` | `get/set` | No | `` |
| `PrefixForType_ClearingHole` | `String` | `get/set` | No | `` |
| `PrefixForType_DigHole` | `String` | `get/set` | No | `` |
| `PrefixForType_Pipe` | `String` | `get/set` | No | `` |
| `PrefixForType_Pit` | `String` | `get/set` | No | `` |
| `PrefixForType_SoundingHole` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Instance` | `BoreholePrefixesEnvironmentSettings` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GlgLayersEnvironmentSettings` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Settings.GlgLayersEnvironmentSettings` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DoNotDynamicVerifyGripMove` | `Boolean` | `get/set` | Yes | `` |

### `PlanGeologyEnvironmentSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Settings.PlanGeologyEnvironmentSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholesDiameter` | `Double` | `get/set` | No | `` |
| `ShowForActiveModelOnly` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Instance` | `PlanGeologyEnvironmentSettings` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TestPrefixesEnvironmentSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Settings.TestPrefixesEnvironmentSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PrefixForType_ImpellerTest` | `String` | `get/set` | No | `` |
| `PrefixForType_StaticSoundingPoint` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Instance` | `TestPrefixesEnvironmentSettings` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Glg.Layers.Tools`

### `AlignmentBoreholeElevationCalcer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Tools.AlignmentBoreholeElevationCalcer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryCalculateProfileElevation` | `Boolean` | `Alignment alignment, Double station, ref Double elevation` | `` |
| `TryCalculateSectionElevation` | `Boolean` | `Alignment alignment, Double station, Double offset, ref Double elevation` | `` |
| `TryCalculateSectionElevation` | `Boolean` | `Alignment alignment, Int32 index, Double offset, ref Double elevation` | `` |

### `AlignmentObliqueOffsetCalcer` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Tools.AlignmentObliqueOffsetCalcer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetObliqueOffset` | `Boolean` | `StationedReference reference, Alignment alg, Section section, ref Double obliqueOffset` | `Extension` |
| `ObliqueOffsetToStaOffs` | `Boolean` | `Alignment alg, Section section, Double obliqueOffset, ref Double station, ref Double offset` | `` |
| `PosToStaOffset` | `Boolean` | `CrsLine line, Vector2D pos, ref Double sta, ref Double offset` | `Extension` |
| `StaOffsToObliqueOffset` | `Boolean` | `Alignment alg, Section section, Double station, Double offset, Double trustInterval, ref Double dist, ref Double obliqueOffset` | `` |
| `StaOffsToObliqueOffset` | `Boolean` | `Alignment alg, Section section, Double station, Double offset, ref Double obliqueOffset` | `` |

### `BoreholeUtils` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Tools.BoreholeUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBoreholeTypeWidthScale` | `Double` | `BoreholeType boreholeType` | `` |

### `TextAlignmentConverter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Tools.TextAlignmentConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAttachmentPoint` | `AttachmentPoint` | `TextAlignment ta` | `` |

---
## Namespace: `Topomatic.Glg.Layers.Visualization`

### `AlignmentBoreholesVisualizationBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.AlignmentBoreholesVisualizationBuilder` |
| **Base Type** | `Topomatic.Glg.Layers.Visualization.BoreholesVisualizationBuilder`1[[Topomatic.Glg.References.BoreholeReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Visualization.BoreholesVisualizationBuilder`1[[Topomatic.Glg.References.BoreholeReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Glg.Layers.Visualization.AlignmentBoreholesVisualizationBuilder`

#### Constructors (1)

- `.ctor(Alignment alignment)`

### `BoreholesVisualizationBuilder`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.BoreholesVisualizationBuilder`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `IEnumerable<Reference<T>>` | `IEnumerable<T> values, Predicate<T> match, ref Vector3D pivot` | `` |

#### Nested Types (1)

- `Reference` (struct)

### `BulkVisualizationBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.BulkVisualizationBuilder` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Glg.Layers.Visualization.BulkVisualizationBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildGround` | `StaticSolidElement[]` | `Surface surface, Ground ground, UInt32 cuttingIndex` | `` |
| `BuildGrounds` | `IList<Reference>` | `Surface surface, GeologyModel model, ref Vector3D pivot` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildGrounds` | `IList<Reference>` | `GeologyModel model, ref Vector3D pivot` | `` |
| `RebuildLayers` | `Void` | `GroundTable table, BulkLevel<BulkGround>[] items, Double boreholeElevation, Double egElevation` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `GetLayersFromColumns` | `Func<BulkLevel<BulkGround>[][] BulkLevel<BulkGround>[] GeologyModel IList<BulkLayers<BulkGround>>>` | Yes | `` | `` |

#### Nested Types (1)

- `Reference` (struct)

### `BulkVisualizationSectionBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.BulkVisualizationSectionBuilder` |
| **Base Type** | `Topomatic.Cad.Foundation.Bulk.BulkSectionTriangulation`1[[Topomatic.Glg.Model.Bulk.GeologyBulkSurface+BulkGround, Topomatic.Glg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Bulk.BulkSectionTriangulation`1[[Topomatic.Glg.Model.Bulk.GeologyBulkSurface+BulkGround, Topomatic.Glg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Glg.Layers.Visualization.BulkVisualizationSectionBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildSection` | `List<ContourLink>` | `GeologyModel model, IList<Vector2D> plan, Profile profile, Double delta` | `` |
| `BuildSection` | `Boolean` | `GeologyModel model, IList<Vector2D> plan, Profile profile, GeologyContour boundContour, Func<Ground GroundReference> findReference, Double delta, Double depth` | `` |
| `BuildSection` | `Boolean` | `GroundTable grounds, IList<KeyValuePair<Vector2D Borehole>> boreholes, GeologyContour boundContour, Func<Ground GroundReference> findReference, Double depth` | `` |
| `BuildTriangles` | `Boolean` | `IList<KeyValuePair<Vector2D Borehole>> boreholes` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GeneratePlanAndProfile` | `BoundingBox2D` | `Alignment alignment, Int32 sectionIndex, IList<Vector2D> plan, StaticProfile profile, ref Double delta` | `` |
| `GeneratePlanAndProfile` | `BoundingBox2D` | `Alignment alignment, IList<Vector2D> plan, StaticProfile profile` | `` |

#### Nested Types (1)

- `ContourLink` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ContourLink` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.BulkVisualizationSectionBuilder+ContourLink` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Layers.Visualization.BulkVisualizationSectionBuilder+ContourLink`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Area` | `Double` | No | `` | `` |
| `ControlPos` | `Vector2D` | No | `` | `` |
| `Points` | `List<Vector2D>` | No | `` | `` |
| `Uid` | `Guid` | No | `` | `` |

### `GlgSectionBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.GlgSectionBuilder` |
| **Base Type** | `Topomatic.Visualization.LinearSolidBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.LinearSolidBuilder`
    - `Topomatic.Glg.Layers.Visualization.GlgSectionBuilder`

#### Constructors (1)

- `.ctor(Alignment alignment, AlignmentGeology geology, Ground ground)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ground` | `Ground` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSolid` | `GeometryModel3D` | `Double from, Double to, ref Vector3D pivot, ref Vector3D ox, ref ImProperties properties` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateBoreholeGroundModel` | `GeometryModel3D` | `Ground ground, String prefix, Double depthFrom, Double depthTo` | `` |
| `CreateBoreholeGroundModel` | `GeometryModel3D` | `Borehole borehole, Int32 index` | `` |
| `Cylinder` | `Void` | `Vector3dCollection vertices, TrianglesCollection indices, MaterialGroup group, Double elevation1, Double elevation2, Double radius` | `` |
| `Rotate` | `Matrix` | `Vector3D ox, Vector3D oy` | `` |

### `GlobalBoreholesVisualizationBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.GlobalBoreholesVisualizationBuilder` |
| **Base Type** | `Topomatic.Glg.Layers.Visualization.BoreholesVisualizationBuilder`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Visualization.BoreholesVisualizationBuilder`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Glg.Layers.Visualization.GlobalBoreholesVisualizationBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `Reference<T where class>` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.BoreholesVisualizationBuilder`1+Reference` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Layers.Visualization.BoreholesVisualizationBuilder`1+Reference`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BoreholeId` | `Guid` | No | `` | `` |
| `Element` | `ImElement` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Placement` | `ImElementPlacement` | No | `` | `` |

### `Reference` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Visualization.BulkVisualizationBuilder+Reference` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Layers.Visualization.BulkVisualizationBuilder+Reference`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Element` | `ImElement` | No | `` | `` |
| `Placement` | `ImElementPlacement` | No | `` | `` |
| `Uid` | `BulkGround` | No | `` | `` |

---
## Namespace: `Topomatic.Glg.Layers.Wrappers`

### `BoreholeWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Borehole borehole)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get` | No | `` |
| `HasDocuments` | `Boolean` | `get` | No | `Browsable` |
| `Marked` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `SeasonFrostDepth` | `Nullable<Double>` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, PropertyEditor` |
| `SeasonThawingDepth` | `Nullable<Double>` | `get/set` | No | `PropertyEditor, ConditionalReadOnly, PropertyTypeConverter` |
| `WaterPlaneLevelsTable` | `BoreholeWaterPlaneLevelsTable` | `get/set` | No | `PropertyEditor, ConditionalReadOnly` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude, ConditionalReadOnly` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `ToString` | `String` | `` | `` |

### `BulkWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.BulkWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get` | No | `Browsable` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |

### `ConePenetrationTestWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.ConePenetrationTestWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ConePenetrationTest test, Vector2D pos)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConePenetrationTest` | `ConePenetrationTest` | `get` | No | `Browsable` |
| `Depth` | `Double` | `get` | No | `ConditionalReadOnly` |
| `Description` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `Number` | `String` | `get` | No | `ConditionalReadOnly` |
| `PenetrometerType` | `SondeType` | `get` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `Position` | `Vector2D` | `get` | No | `Browsable` |
| `ProbingUnitType` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `TestingDate` | `String` | `get/set` | No | `ConditionalReadOnly` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `ToString` | `String` | `` | `` |

### `GlobalBoreholeWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.GlobalBoreholeWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.BoreholeWrapper`
    - `Topomatic.Glg.Layers.Wrappers.GlobalBoreholeWrapper`

#### Constructors (2)

- `.ctor(Borehole borehole)`
- `.ctor(Borehole borehole, Boolean readOnly)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `BulkCalculate` | `Boolean` | `get/set` | No | `` |
| `Elevation` | `Double` | `get/set` | No | `Elevation, ConditionalReadOnly, ElevationGlobalEditor` |
| `IsFictive` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `WrappedObject` | `Borehole` | `get` | No | `Browsable` |
| `X` | `Double` | `get/set` | No | `DefaultDouble` |
| `Y` | `Double` | `get/set` | No | `DefaultDouble` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IPointObject` | `get_BasePoint` |

### `GlobalConePenetrationTestWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.GlobalConePenetrationTestWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.ConePenetrationTestWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.ConePenetrationTestWrapper`
    - `Topomatic.Glg.Layers.Wrappers.GlobalConePenetrationTestWrapper`

#### Constructors (1)

- `.ctor(ConePenetrationTest cpt, Vector2D pos)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `Elevation` | `Double` | `get/set` | No | `ElevationGlobalEditor, Elevation` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `WrappedObject` | `ConePenetrationTest` | `get` | No | `Browsable` |
| `X` | `Double` | `get/set` | No | `DefaultDouble` |
| `Y` | `Double` | `get/set` | No | `DefaultDouble` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IWrapped`1` | `get_WrappedObject` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |
| `IPointObject` | `get_BasePoint` |

### `GlobalImpellerTestWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.GlobalImpellerTestWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.ImpellerTestWrapper` |
| **Implements** | `Topomatic.Glg.IImpellerConstTableContainer, Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.ImpellerTestWrapper`
    - `Topomatic.Glg.Layers.Wrappers.GlobalImpellerTestWrapper`

#### Constructors (1)

- `.ctor(ImpellerTest cpt)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `Elevation` | `Double` | `get/set` | No | `ElevationGlobalEditor, Elevation` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `WrappedObject` | `ImpellerTest` | `get` | No | `Browsable` |
| `X` | `Double` | `get/set` | No | `DefaultDouble` |
| `Y` | `Double` | `get/set` | No | `DefaultDouble` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IWrapped`1` | `get_WrappedObject` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |
| `IPointObject` | `get_BasePoint` |

### `GroundWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.GroundWrapper` |
| **Base Type** | `Topomatic.Glg.Layers.Wrappers.BulkWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Layers.Wrappers.BulkWrapper`
    - `Topomatic.Glg.Layers.Wrappers.GroundWrapper`

#### Constructors (1)

- `.ctor(Ground ground, Int32 cuttingNumber)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Aggregates` | `UpdatableTypedObjectWrapper` | `get` | No | `TypedObjectPropertiesExclude, ReadOnly, WrappedTypedObjectProvider` |
| `AreaSign` | `String` | `get` | No | `` |
| `AreaSignEx` | `String` | `get` | No | `` |
| `AreaSignExScale` | `Double` | `get` | No | `` |
| `AreaSignScale` | `Double` | `get` | No | `` |
| `CuttingNumber` | `Int32` | `get` | No | `Browsable` |
| `GroundColor` | `CadColor` | `get` | No | `` |
| `Id` | `Guid` | `get` | No | `Browsable` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |

### `ImpellerTestWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Layers.Wrappers.ImpellerTestWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Glg.IImpellerConstTableContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ImpellerTest test)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get` | No | `ConditionalReadOnly` |
| `Description` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `ImpellerConstTable` | `ImpellerConstTable` | `get` | No | `Browsable` |
| `Key` | `ImpellerConstKeyRec` | `get/set` | No | `PropertyEditor, ConditionalReadOnly` |
| `Number` | `String` | `get` | No | `ConditionalReadOnly` |
| `TestingDate` | `String` | `get/set` | No | `ConditionalReadOnly` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IImpellerConstTableContainer` | `get_ImpellerConstTable` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 130 |
| **Classes** | 99 |
| **Interfaces** | 1 |
| **Enums** | 1 |
| **Structs** | 3 |
| **Abstract Classes** | 17 |
| **Static Classes** | 9 |
| **Total Methods** | 290 |
| **Total Properties** | 357 |
| **Total Fields** | 58 |
| **Total Events** | 0 |
| **Total Constructors** | 113 |
| **Nested Types** | 32 |
| **Extension Methods** | 0 |


