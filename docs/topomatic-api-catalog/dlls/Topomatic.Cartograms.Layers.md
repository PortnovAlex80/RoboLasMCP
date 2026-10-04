# Topomatic.Cartograms.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Cartograms.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Cartograms.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Cartograms.Layers.dll` |

---
## Namespace: `Topomatic.Cartograms.Layers`

### `CartogramCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.CartogramCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Dwg.IDrawingContainer, Topomatic.Cartograms.ICartogramContainer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Cartograms.Layers.CartogramCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `Cartogram` | `Cartogram` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |
| `IDrawingContainer` | `get_Drawing` |
| `ICartogramContainer` | `get_Cartogram` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

### `CartogramLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.CartogramLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Cartograms.ICartogramContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cartograms.Layers.CartogramLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cartogram` | `Cartogram` | `get/set` | No | `` |
| `CellsLayer` | `CartogramSubLayer` | `get` | No | `` |
| `ContoursLayer` | `CartogramSubLayer` | `get` | No | `` |
| `CutHatchLayer` | `CartogramSubLayer` | `get` | No | `` |
| `FillHatchLayer` | `CartogramSubLayer` | `get` | No | `` |
| `InfoLayer` | `CartogramSubLayer` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `NullLinesLayer` | `CartogramSubLayer` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `ICartogramContainer` | `get_Cartogram` |

### `CartogramSubLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.CartogramSubLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cartograms.ICartogramContainer, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cartogram` | `Cartogram` | `get` | No | `` |
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
| `ICartogramContainer` | `get_Cartogram` |
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

---
## Namespace: `Topomatic.Cartograms.Layers.EditableItems`

### `CartogramEiBaseController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cartogram` | `Cartogram` | `get/set` | No | `` |
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetDwgEntities` | `IEnumerable<DwgEntity>` | `Drawing drawing, Double scale, BoundingBox2D sheetBounds, CartogramEditableItemsKey key` | `` |
| `GetLayer` | `ILayer` | `` | `` |
| `GetNodeItemOffset` | `Vector2D` | `CartogramEditableItemsKey key` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramEiBaseDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseDrawer`

#### Constructors (1)

- `.ctor(CartogramEiBaseController controller, CadView cadView)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `CadPen pen, CartogramEditableItemsKey key, Vector2D textOffset, Double additionalRotation, Boolean drawLeader` | `` |
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `DrawLayer` | `Void` | `Boolean enabled, CadPen pen` | `` |
| `GetItemLimits` | `Boolean` | `CartogramEditableItemsKey key, Vector2D textOffset, ref BoundingBox2D bounds` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateMText` | `DwgMText` | `Drawing drawing, TextStandard textStd, Vector2D position, Double rotation, Double textSize, AttachmentPoint attPoint, String text, BackgroundFillType backFillType, CadColor backColor` | `` |
| `GetEntities` | `IEnumerable<DwgEntity>` | `Drawing drawing, Cartogram cartogram, Double scale, CartogramEditableItemsKey key, Vector2D textOffset, Double additionalRotation, Boolean drawLeader` | `` |
| `GetTextByKey` | `String` | `Cartogram cartogram, CartogramEditableItemsKey key` | `` |
| `GetTextPosition` | `Vector2D` | `Cartogram cartogram, Double scale, CartogramEditableItemsKey key` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Cartogram` | `Cartogram` | No | `` | `` |

### `CartogramEiCutController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiCutController` |
| **Base Type** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`
      - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiCutController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramEiEarthElevationsController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiEarthElevationsController` |
| **Base Type** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`
      - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiEarthElevationsController`

#### Constructors (1)

- `.ctor(CartogramEiNodeController nodeController)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetNodeItemOffset` | `Vector2D` | `CartogramEditableItemsKey key` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramEiFillController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiFillController` |
| **Base Type** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`
      - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiFillController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramEiGridController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiGridController` |
| **Base Type** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`
      - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiGridController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDwgEntities` | `IEnumerable<DwgEntity>` | `Drawing drawing, Double scale, BoundingBox2D sheetBounds, CartogramEditableItemsKey key` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramEiNodeController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiNodeController` |
| **Base Type** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`
      - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiNodeController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramEiProjectElevationController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiProjectElevationController` |
| **Base Type** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`
      - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiProjectElevationController`

#### Constructors (1)

- `.ctor(CartogramEiNodeController nodeController)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetNodeItemOffset` | `Vector2D` | `CartogramEditableItemsKey key` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramEiWorkElevationController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiWorkElevationController` |
| **Base Type** | `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiBaseController`
      - `Topomatic.Cartograms.Layers.EditableItems.CartogramEiWorkElevationController`

#### Constructors (1)

- `.ctor(CartogramEiNodeController nodeController)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `CartogramLayerStyleItem` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetNodeItemOffset` | `Vector2D` | `CartogramEditableItemsKey key` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 12 |
| **Classes** | 10 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 0 |
| **Total Methods** | 22 |
| **Total Properties** | 27 |
| **Total Fields** | 10 |
| **Total Events** | 0 |
| **Total Constructors** | 12 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


