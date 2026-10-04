# Topomatic.Alg.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Layers.dll` |

---
## Namespace: `Topomatic.Alg.Layers`

### `AgObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.BaseSectionLayer+AgObject` |
| **Base Type** | `Topomatic.Alg.Layers.BaseSectionLayer+LayerObject` |
| **Implements** | `Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Layers.BaseSectionLayer+LayerObject`
    - `Topomatic.Alg.Layers.BaseSectionLayer+AgObject`

#### Constructors (1)

- `.ctor(BaseSectionLayer layer)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `Paint` | `Void` | `DeviceContext dc` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AgProfileDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AgProfileDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AgProfile profile)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DoubleDraw` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext dc` | `` |
| `GetBounds` | `Boolean` | `ref BoundingBox2D limits` | `` |

### `AlgAuxiliaryDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgAuxiliaryDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawProfileSpline` | `Void` | `DeviceContext dc, Color color, Double x, Double y, Double dx, Double dy, Double g1, Double g2` | `` |
| `DrawSimpleSpline` | `Void` | `DeviceContext dc, Color color, Double x1, Double x2, Double a, Double b, Double c, Double d` | `` |

### `AlgBaseCrossSectionLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `Section` | `Section` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `AlgBasePlanLayerSelectionSet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgBasePlanLayerSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Alg.Layers.AlgBasePlanLayerSelectionSet`

#### Constructors (1)

- `.ctor(CadViewLayer layer)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgBaseProfileLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgBaseProfileLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseProfileLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveTransition` | `Transition` | `get` | No | `` |
| `ActiveTransitionIndex` | `Int32` | `get` | No | `` |
| `CurrentSection` | `Int32` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `AlgBridgesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgBridgesLayer` |
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
      - `Topomatic.Alg.Layers.AlgBridgesLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `AlgCompoundLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Alg.Layers.AlgCompoundLayer`

#### Constructors (1)

- `.ctor(String name, Guid guid, IAlignmentContainer container)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `AlignmentModel` | `AlignmentModel` | `get/set` | No | `` |
| `Container` | `IAlignmentContainer` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IAlignmentContainer` | `get_Alignment` |

### `AlgCorridorWorkElevationsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgCorridorWorkElevationsLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(BaseSectionLayer owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Owner` | `CadViewLayer` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `Paint` | `Void` | `CadPen pen, Alignment alignment, CrsDesignContext designContext, CrsContour eg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |

### `AlgCrossSectionCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgCrossSectionCompoundLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgCompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Alg.Layers.AlgCompoundLayer`
        - `Topomatic.Alg.Layers.AlgCrossSectionCompoundLayer`

#### Constructors (1)

- `.ctor(String name, IAlignmentContainer container)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Corridor` | `Corridor` | `get` | No | `` |
| `CurrentSection` | `Int32` | `get/set` | No | `` |
| `EndSection` | `Int32` | `get/set` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |

### `AlgEditableItemsController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgEditableItemsController` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `AlgKilometresLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgKilometresLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgPlanSubLayer` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Layers.AlgPlanSubLayer`
    - `Topomatic.Alg.Layers.AlgKilometresLayer`

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `CadPen pen` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `AlgMiddleCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgMiddleCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Alg.Layers.AlgMiddleCompoundLayer`

#### Constructors (1)

- `.ctor(String name, Guid guid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `AlgPipesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgPipesLayer` |
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
      - `Topomatic.Alg.Layers.AlgPipesLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `AlgPlanCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgPlanCompoundLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgCompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer, Topomatic.Sfc.ISurfaceContainer, Topomatic.Dwg.IDrawingContainer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Alg.Layers.AlgCompoundLayer`
        - `Topomatic.Alg.Layers.AlgPlanCompoundLayer`

#### Constructors (1)

- `.ctor(String name, AlignmentModel model)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |
| `ISurfaceContainer` | `get_Surface` |
| `IDrawingContainer` | `get_Drawing` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

### `AlgPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgPlanLayer` |
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
      - `Topomatic.Alg.Layers.AlgPlanLayer`

#### Constructors (1)

- `.ctor(String name, Boolean alwaysEditMode)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `KilometresLayer` | `AlgKilometresLayer` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PlanLineLayer` | `AlgPlanLineLayer` | `get` | No | `` |
| `PlanSectionsLayer` | `AlgPlanSectionsLayer` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanLayer` | `AlgPlanLayer` | `CadView cadView, Boolean readOnly` | `` |
| `GetPlanLayer` | `AlgPlanLayer` | `CadView cadView` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |

### `AlgPlanLineLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgPlanLineLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgPlanSubLayer` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Layers.AlgPlanSubLayer`
    - `Topomatic.Alg.Layers.AlgPlanLineLayer`

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `Paint` | `Void` | `CadPen pen` | `` |
| `Paint3d` | `Void` | `DeviceContext dc` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgPlanSectionsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgPlanSectionsLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgPlanSubLayer` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Layers.AlgPlanSubLayer`
    - `Topomatic.Alg.Layers.AlgPlanSectionsLayer`

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `CadPen pen` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgPlanSubLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgPlanSubLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Owner` | `CadViewLayer` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |

### `AlgProfileCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgProfileCompoundLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgCompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Alg.Layers.AlgCompoundLayer`
        - `Topomatic.Alg.Layers.AlgProfileCompoundLayer`

#### Constructors (1)

- `.ctor(String name, IAlignmentContainer container)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveTransitionIndex` | `Int32` | `get/set` | No | `` |
| `Transitions` | `ITransitions` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgProjectProfileElevationsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgProjectProfileElevationsLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AlgBaseProfileLayer owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `Paint` | `Void` | `CadPen pen` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |

### `AlgStyledEditableItemsController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.AlgStyledEditableItemsController` |
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
      - `Topomatic.Alg.Layers.AlgStyledEditableItemsController`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `ILayer` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BaseSectionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.BaseSectionLayer` |
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
        - `Topomatic.Alg.Layers.BaseSectionLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Codes` | `SelectedCodes` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBaseSectionLayer` | `BaseSectionLayer` | `CadView cadview, Boolean readOnly` | `` |
| `GetBaseSectionLayer` | `BaseSectionLayer` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (5)

- `AgObject` (class)
- `LayerObject` (abstract class)
- `SectionSelectionSet` (class)
- `SelectedCodes` (class)
- `TransitionObject` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BaseZoneDrawer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.BaseZoneDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProjectProfile profile)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext dc` | `` |

### `CompoundLineDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CompoundLineDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CompoundLine line)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `CompoundLine` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext dc, Double start, Double end, Color straight, Color arc, Color cloth` | `` |
| `Draw` | `Void` | `DeviceContext dc, Color straight, Color arc, Color cloth` | `` |
| `GetBounds` | `Boolean` | `ref BoundingBox2D limits` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawLine` | `Void` | `DeviceContext dc, CompoundLine line, Color color` | `` |

### `CrsDesignLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CrsDesignLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Crs.Design.ICrsDesignHost, Topomatic.Crs.Ast.IAstProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Alg.Layers.CrsDesignLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AstProvider` | `IAstProvider` | `get` | No | `` |
| `CLY` | `Double` | `get` | No | `` |
| `CurrentSection` | `Int32` | `get` | No | `` |
| `DesignContext` | `CrsDesignContext` | `get` | No | `` |
| `Drawer` | `CrsDrawer` | `get/set` | No | `` |
| `EndSection` | `Int32` | `get` | No | `` |
| `Items` | `IList<ActBaseComponent>` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PythonPackage` | `Object` | `get` | No | `` |
| `ReverseCursorPosition` | `Int32` | `get/set` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `SerializationManager` | `DesignerSerializationManager` | `get` | No | `` |

#### Instance Methods (22)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ComponentExist` | `Boolean` | `String typeName` | `` |
| `CreateComplexContour` | `Void` | `List<ActNode> nodes, List<AstExpression> contourNodes` | `` |
| `CreateComponent` | `Void` | `ActBaseComponent component` | `` |
| `CreateComponent` | `Boolean` | `DesignInitializer initializator, CrsComponent component` | `` |
| `CreateContourWithVolume` | `Boolean` | `` | `` |
| `CreatePythonComponent` | `Void` | `String fullName, String displayName` | `` |
| `Deserialize` | `CrsComponent` | `AstExpression expression` | `` |
| `GenerateExpression` | `Void` | `AstObject ast, TextWriter writer` | `` |
| `GetComponentFullTypeName` | `String` | `CrsComponent component` | `` |
| `GetComponentIndex` | `Int32` | `String name, Int32 index` | `` |
| `GetComponentIndex` | `Int32` | `String name` | `` |
| `GetWrapper` | `Object` | `ActBaseComponent component` | `` |
| `HandleEvent` | `Void` | `Object sender, EventArgs e` | `` |
| `Invalidate` | `Void` | `` | `` |
| `ParseExpression` | `AstExpression` | `TextReader reader` | `` |
| `RenameComponent` | `Void` | `ActBaseComponent component, String name` | `` |
| `SelectComponent` | `GetPointResult` | `String message, SelectionType type, ref CrsComponent component, ref AstExpression expression, CrsComponent owner` | `` |
| `SelectComponent` | `GetPointResult` | `String message, SelectionType type, ref CrsComponent component, ref AstExpression expression, CrsComponent owner, CrsComponent except` | `` |
| `SelectComponent` | `GetPointResult` | `String message, SelectionType type, ref CrsComponent component, ref AstExpression expression, CrsComponent owner, CrsComponent except, String[] args` | `` |
| `SelectComponent2` | `Boolean` | `String message, SelectionType type, ref CrsComponent component, ref AstExpression expression, CrsComponent owner` | `` |
| `Serialize` | `AstExpression` | `CrsComponent component` | `` |
| `Translate` | `Boolean` | `String category, ref String value` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCrsDesignLayer` | `CrsDesignLayer` | `CadView cadView, Boolean readOnly` | `` |
| `GetCrsDesignLayer` | `CrsDesignLayer` | `CadView cadView` | `` |
| `IsValidIdentifier` | `Boolean` | `String identifier` | `` |
| `MakeValidIdentifier` | `String` | `String identifier` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (3)

- `CrsDesignLayerSelectionSet` (class)
- `CrsDrawer` (class)
- `HatchCache` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `ICrsDesignHost` | `get_SerializationManager` |
| `ICrsDesignHost` | `get_AstProvider` |
| `ICrsDesignHost` | `get_PythonPackage` |
| `ICrsDesignHost` | `get_CLY` |
| `ICrsDesignHost` | `Invalidate` |
| `ICrsDesignHost` | `RenameComponent` |
| `ICrsDesignHost` | `GetComponentFullTypeName` |
| `ICrsDesignHost` | `SelectComponent` |
| `ICrsDesignHost` | `SelectComponent` |
| `ICrsDesignHost` | `SelectComponent` |
| `ICrsDesignHost` | `ComponentExist` |
| `ICrsDesignHost` | `Serialize` |
| `ICrsDesignHost` | `Deserialize` |
| `ICrsDesignHost` | `Translate` |
| `ICrsDesignHost` | `HandleEvent` |
| `ICrsDesignHost` | `get_DesignContext` |
| `IAstProvider` | `ParseExpression` |
| `IAstProvider` | `GenerateExpression` |

### `CrsDesignLayerSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CrsDesignLayer+CrsDesignLayerSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Alg.Layers.CrsDesignLayer+CrsDesignLayerSelectionSet`

#### Constructors (1)

- `.ctor(CrsDesignLayer layer)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanSelectConstructionContours` | `Boolean` | `get/set` | No | `` |
| `CanSelectConstructionNodes` | `Boolean` | `get/set` | No | `` |
| `CanSelectGeology` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `DesignLayer` | `CrsDesignLayer` | `get` | No | `` |
| `SupportClipboard` | `Boolean` | `get` | No | `` |
| `SupportDragAndDrop` | `Boolean` | `get` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Copy` | `Void` | `` | `` |
| `Cut` | `Void` | `` | `` |
| `DragDrop` | `Boolean` | `String path` | `` |
| `DragOver` | `Boolean` | `String path` | `` |
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
| `Paste` | `Void` | `` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `CrsDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CrsDesignLayer+CrsDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginDraw` | `Void` | `CrsDesignContext dc, AlignmentStyle style` | `` |
| `DrawConstruction` | `Void` | `CadPen pen, CrsConstruction construction, Boolean enable` | `` |
| `DrawContour` | `Void` | `CadPen pen, CrsContour contour, Boolean enable` | `` |
| `DrawHatch` | `Void` | `CadPen pen, CrsVolume volume, Boolean enable, Double scale, Double rotation, IDictionary<Object HatchCache> cache` | `` |
| `DrawNode` | `Void` | `Double screenRatio, CadPen pen, CrsNode node, Boolean enable` | `` |
| `DrawRay` | `Void` | `CadPen pen, CrsRay ray, Boolean enable` | `` |
| `DrawVolume` | `Void` | `CadPen pen, CrsVolume volume, Boolean enable` | `` |
| `EndDraw` | `Void` | `` | `` |

### `CrsNodeCaptionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CrsNodeCaptionLayer` |
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
        - `Topomatic.Alg.Layers.CrsNodeCaptionLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
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

### `CrsPerspectiveLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CrsPerspectiveLayer` |
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
        - `Topomatic.Alg.Layers.CrsPerspectiveLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
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

### `CrsUnderlayLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CrsUnderlayLayer` |
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
        - `Topomatic.Alg.Layers.CrsUnderlayLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
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

### `DummyConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.DummyConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Alg.Layers.DummyConstruction`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HatchCache` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.CrsDesignLayer+HatchCache` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Layers.CrsDesignLayer+HatchCache`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AreaSignCache` | `AreaSignCache` | No | `` | `` |
| `Color` | `CadColor` | No | `` | `` |
| `Guid` | `Guid` | No | `` | `` |

### `LayerObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.BaseSectionLayer+LayerObject` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(BaseSectionLayer layer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layer` | `BaseSectionLayer` | `get` | No | `Browsable` |
| `Position` | `Vector2D` | `get` | No | `Browsable` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetXFormula` | `AstExpression` | `` | `` |
| `GetYFormula` | `AstExpression` | `` | `` |
| `Paint` | `Void` | `DeviceContext dc` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `LayerUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.LayerUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `T` | `CadView cadView, Guid layerId` | `` |
| `GetLayer` | `T` | `CadView cadView, Guid layerId, Boolean readOnly` | `` |
| `GetLayerOnPlanCadView` | `T` | `Guid layerId, Boolean readOnly` | `` |
| `GetLayerOnPlanCadView` | `T` | `Guid layerId` | `` |
| `GetLayerOnProfileCadView` | `T` | `Guid layerId, Boolean readOnly` | `` |
| `GetLayerOnProfileCadView` | `T` | `Guid layerId` | `` |
| `GetLayerOnSectionCadView` | `T` | `Guid layerId, Boolean readOnly` | `` |
| `GetLayerOnSectionCadView` | `T` | `Guid layerId` | `` |
| `GetLayers` | `IEnumerable<T>` | `CadView cadview, Guid layerId` | `` |

#### Nested Types (1)

- `LayerVisibilityManager` (class)

### `LayerVisibilityManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.LayerUtils+LayerVisibilityManager` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView, IEnumerable<Guid> layerId, Predicate<CadViewLayer> isVisible)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `PipeDrawer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.PipeDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawPipe` | `Void` | `Pipe pipe, PipesStyle style, Boolean enable` | `` |

### `PlanLineDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.PlanLineDrawer` |
| **Base Type** | `Topomatic.Alg.Layers.CompoundLineDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Layers.CompoundLineDrawer`
    - `Topomatic.Alg.Layers.PlanLineDrawer`

#### Constructors (1)

- `.ctor(PlanLine line)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawArcBorderSign` | `Void` | `CadPen pen, Double station` | `` |
| `DrawClothoidBorderSign` | `Void` | `CadPen pen, Double station` | `` |
| `DrawItemBorderSigns` | `Void` | `CadPen pen, Color color` | `` |
| `GetBounds` | `Boolean` | `ref BoundingBox2D limits` | `` |

### `ProfileDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.ProfileDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Profile profile)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DisplayStyle` | `ProfileDisplayStyle` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext dc, Boolean useDisplayStyle` | `` |
| `GetBounds` | `Boolean` | `ref BoundingBox2D limits` | `` |

### `ProjectProfileDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.ProjectProfileDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProjectProfile profile, Profile egProfile, GapsCollection gaps)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DoubleThick` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext dc` | `` |
| `GetBounds` | `Boolean` | `ref BoundingBox2D limits` | `` |

### `ProjectTransitionsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.ProjectTransitionsLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseProfileLayer`
        - `Topomatic.Alg.Layers.ProjectTransitionsLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
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
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `SectionSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.BaseSectionLayer+SectionSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Alg.Layers.BaseSectionLayer+SectionSelectionSet`

#### Constructors (1)

- `.ctor(BaseSectionLayer layer)`

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
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `SelectedCodes` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.BaseSectionLayer+SelectedCodes` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<Int32>` | `` | `` |
| `IsSelected` | `Boolean` | `Int32 code` | `` |
| `Remove` | `Void` | `Int32 code` | `` |
| `Select` | `Void` | `IEnumerable<Int32> codes` | `` |
| `Select` | `Void` | `Int32 code` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `TransitionObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.BaseSectionLayer+TransitionObject` |
| **Base Type** | `Topomatic.Alg.Layers.BaseSectionLayer+LayerObject` |
| **Implements** | `Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Layers.BaseSectionLayer+LayerObject`
    - `Topomatic.Alg.Layers.BaseSectionLayer+TransitionObject`

#### Constructors (1)

- `.ctor(BaseSectionLayer layer, String name, Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Position` | `Vector2D` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetXFormula` | `AstExpression` | `` | `` |
| `GetYFormula` | `AstExpression` | `` | `` |
| `Paint` | `Void` | `DeviceContext dc` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PaintTransition` | `Void` | `DeviceContext dc, CadView cadView, Double offset, Double elevation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |

---
## Namespace: `Topomatic.Alg.Layers.Design`

### `BridgeBaseConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.BridgeBaseConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Layers.Design.BridgeBaseConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `BridgeMaterialConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.BridgeMaterialConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Layers.Design.BridgeMaterialConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `BridgeTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.BridgeTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Layers.Design.BridgeTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `IOrientation` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.IOrientation` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get` | No | `` |

### `OrientationAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.OrientationAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Alg.Layers.Design.OrientationAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeMaterialConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.PipeMaterialConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Layers.Design.PipeMaterialConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeModeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.PipeModeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Layers.Design.PipeModeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeSectionConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.PipeSectionConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Layers.Design.PipeSectionConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.PipeTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Layers.Design.PipeTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PlanStationEditor` (class)

**Attributes**: [Obsolete(Message: `U`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Design.PlanStationEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Alg.Layers.Design.PlanStationEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

---
## Namespace: `Topomatic.Alg.Layers.EditableLayers.LineSegments`

### `LineSegmentsEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.EditableLayers.LineSegments.LineSegmentsEiController` |
| **Base Type** | `Topomatic.Alg.Layers.AlgStyledEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.Layers.AlgStyledEditableItemsController`
        - `Topomatic.Alg.Layers.EditableLayers.LineSegments.LineSegmentsEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LineSegmentsEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.EditableLayers.LineSegments.LineSegmentsEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Alg.Layers.EditableLayers.LineSegments.LineSegmentsEiDrawer`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `DrawItem` | `Void` | `CadPen pen, Vertex firstVertex, Vertex secondVertex, Vector2D textOffset, Double additionalRotation` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePlanchetDwgEntities` | `List<DwgEntity>` | `Alignment alignment, Double scale, Drawing drawing, CadColor color, Vertex firstVertex, Vertex secondVertex, Vector2D textOffset, Double additionalRotation` | `` |
| `GetTextPosition` | `Boolean` | `Alignment alignment, Double scale, Vertex firstVertex, Vertex secondVertex, ref Vector2D position, ref Double rotation` | `` |

---
## Namespace: `Topomatic.Alg.Layers.EditableLayers.PlanVertex`

### `PlanVertexEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.EditableLayers.PlanVertex.PlanVertexEiController` |
| **Base Type** | `Topomatic.Alg.Layers.AlgStyledEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.Layers.AlgStyledEditableItemsController`
        - `Topomatic.Alg.Layers.EditableLayers.PlanVertex.PlanVertexEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Layers.EditableLayers.PlanVertexElements`

### `PlanVertexElementsEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.EditableLayers.PlanVertexElements.PlanVertexElementsEiController` |
| **Base Type** | `Topomatic.Alg.Layers.AlgStyledEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.Layers.AlgStyledEditableItemsController`
        - `Topomatic.Alg.Layers.EditableLayers.PlanVertexElements.PlanVertexElementsEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanVertexElementsEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.EditableLayers.PlanVertexElements.PlanVertexElementsEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Alg.Layers.EditableLayers.PlanVertexElements.PlanVertexElementsEiDrawer`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enable, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `DrawItem` | `Void` | `CadPen pen, Vertex vertex, Int32 dataType, Int32 dataIndex, Vector2D textOffset, Double additionalRotation` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |
| `TextBounds` | `Boolean` | `Vertex vertex, Int32 dataType, Int32 dataIndex, Vector2D textOffset, ref BoundingBox2D bounds` | `` |
| `TextPosition` | `Vector2D` | `Vertex vertex, Int32 dataType, Int32 dataIndex` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePlanchetDwgEntities` | `List<DwgEntity>` | `Alignment alignment, TextStandard textStd, Double scale, Drawing drawing, CadColor color, Vertex vertex, Int32 dataType, Int32 dataIndex, Vector2D textOffset, Double additionalRotation` | `` |
| `PrepareElementsString` | `String` | `Alignment alignment, Double angle, Double radius, Double k, Double kk, Double l1, Double l2, Double t1, Double t2` | `` |

---
## Namespace: `Topomatic.Alg.Layers.EditableLayers.Stationing`

### `StationingEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.EditableLayers.Stationing.StationingEiController` |
| **Base Type** | `Topomatic.Alg.Layers.AlgStyledEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.Layers.AlgStyledEditableItemsController`
        - `Topomatic.Alg.Layers.EditableLayers.Stationing.StationingEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetInsertionPoint` |

---
## Namespace: `Topomatic.Alg.Layers.Extensions`

### `AlgBaseCrossEctionLayerExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Extensions.AlgBaseCrossEctionLayerExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SelectedSections` | `IEnumerable<Section>` | `AlgBaseCrossSectionLayer layer` | `Extension` |

---
## Namespace: `Topomatic.Alg.Layers.Plugins`

### `IAlignmentPluginLayersInitializator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Plugins.IAlignmentPluginLayersInitializator` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePlanLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `CreateProfileLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `CreateSectionLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |

---
## Namespace: `Topomatic.Alg.Layers.Settings`

### `AlgLayersCommonSettings` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Settings.AlgLayersCommonSettings` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsVisible` | `Boolean` | `Guid id` | `` |
| `SetVisible` | `Void` | `Guid id, Boolean value` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossSectionGridBlackMultiLayerId` | `Guid` | Yes | `` | `` |
| `CrossSectionGridCuttingMuliLayerId` | `Guid` | Yes | `` | `` |
| `CrossSectionGridRedMultiLayerId` | `Guid` | Yes | `` | `` |

---
## Namespace: `Topomatic.Alg.Layers.Wrappers`

### `AlignmentWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Wrappers.AlignmentWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICompoundLinearObject, Topomatic.FoundationClasses.IWrapped, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `Browsable` |
| `AlignmentName` | `String` | `get` | No | `` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `MaxGrade` | `Double` | `get` | No | `Grade` |
| `MaxInRadius` | `Double` | `get` | No | `Radius` |
| `MaxLength` | `Double` | `get` | No | `Length` |
| `MaxLineLength` | `Double` | `get` | No | `Length` |
| `MaxOutRadius` | `Double` | `get` | No | `Radius` |
| `MaxRadius` | `Double` | `get` | No | `Radius` |
| `MinGrade` | `Double` | `get` | No | `Grade` |
| `MinInRadius` | `Double` | `get` | No | `Radius` |
| `MinLength` | `Double` | `get` | No | `Length` |
| `MinLineLength` | `Double` | `get` | No | `Length` |
| `MinOutRadius` | `Double` | `get` | No | `Radius` |
| `MinRadius` | `Double` | `get` | No | `Radius` |
| `MultiRadius` | `Boolean` | `get` | No | `` |
| `PlanLength` | `Double` | `get` | No | `Length` |
| `VertexesCount` | `Int32` | `get` | No | `` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |
| `ILinearObject` | `GetPolyline` |
| `ICompoundLinearObject` | `GetPathList` |
| `IWrapped` | `get_WrappedObject` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IAlignmentContainer` | `get_Alignment` |

### `CompoundLineWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Layers.Wrappers.CompoundLineWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.ICompoundLinearObject, Topomatic.Cad.Foundation.ILinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name, CompoundLine compoundLine)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CompoundLine` | `CompoundLine` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICompoundLinearObject` | `GetPathList` |
| `ILinearObject` | `GetPolyline` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 66 |
| **Classes** | 48 |
| **Interfaces** | 2 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 11 |
| **Static Classes** | 4 |
| **Total Methods** | 190 |
| **Total Properties** | 109 |
| **Total Fields** | 22 |
| **Total Events** | 0 |
| **Total Constructors** | 54 |
| **Nested Types** | 9 |
| **Extension Methods** | 0 |


