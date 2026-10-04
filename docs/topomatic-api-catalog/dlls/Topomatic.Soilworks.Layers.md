# Topomatic.Soilworks.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Soilworks.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Soilworks.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Soilworks.Layers.dll` |

---
## Namespace: `Topomatic.Soilworks`

### `IApplicabilitiyStateWrapperContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicabilityStateWrappers` | `ApplicabilityStateWrapper[]` | `get/set` | No | `` |

---
## Namespace: `Topomatic.Soilworks.Layers`

### `BaseSoilworksLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Soilworks` | `Soilworks` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearWrappers` | `Void` | `` | `` |

#### Nested Types (1)

- `BaseSoliworksSelectionSet` (abstract class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BaseSoliworksSelectionSet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet`

#### Constructors (1)

- `.ctor(BaseSoilworksLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Soilworks` | `Soilworks` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConnectionLinkLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.ConnectionLinkLayer` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer`
      - `Topomatic.Soilworks.Layers.ConnectionLinkLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionLinkDrawWrappers` | `ConnectionLinkDrawWrapper[]` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearWrappers` | `Void` | `` | `` |

#### Nested Types (1)

- `ConnectionLinkSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `ConnectionLinkSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.ConnectionLinkLayer+ConnectionLinkSelectionSet` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet`
      - `Topomatic.Soilworks.Layers.ConnectionLinkLayer+ConnectionLinkSelectionSet`

#### Constructors (1)

- `.ctor(ConnectionLinkLayer layer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionLinkLayer` | `ConnectionLinkLayer` | `get` | No | `` |
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

### `ContainerSoilworksObjectLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.ContainerSoilworksObjectLayer` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer`
      - `Topomatic.Soilworks.Layers.ContainerSoilworksObjectLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ContainerSoilworksObjectDrawWrappers` | `ContainerSoilworksObjectDrawWrapper[]` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearWrappers` | `Void` | `` | `` |

#### Nested Types (1)

- `ContainerSoilworksObjectSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `ContainerSoilworksObjectSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.ContainerSoilworksObjectLayer+ContainerSoilworksObjectSelectionSet` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet`
      - `Topomatic.Soilworks.Layers.ContainerSoilworksObjectLayer+ContainerSoilworksObjectSelectionSet`

#### Constructors (1)

- `.ctor(ContainerSoilworksObjectLayer layer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ContainerSoilworksObjectLayer` | `ContainerSoilworksObjectLayer` | `get` | No | `` |
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

### `HaulageLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.HaulageLayer` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer`
      - `Topomatic.Soilworks.Layers.HaulageLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HaulageDrawWrappers` | `HaulageDrawWrapper[]` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearWrappers` | `Void` | `` | `` |

#### Nested Types (1)

- `HaulageSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `HaulageSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.HaulageLayer+HaulageSelectionSet` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet`
      - `Topomatic.Soilworks.Layers.HaulageLayer+HaulageSelectionSet`

#### Constructors (1)

- `.ctor(HaulageLayer layer)`

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

### `MassContainerLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.MassContainerLayer` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer`
      - `Topomatic.Soilworks.Layers.MassContainerLayer`

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsApplicability` | `Predicate<IMassContainer>` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointSoilworksObjectLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.PointSoilworksObjectLayer` |
| **Base Type** | `Topomatic.Soilworks.Layers.MassContainerLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer`
      - `Topomatic.Soilworks.Layers.MassContainerLayer`
        - `Topomatic.Soilworks.Layers.PointSoilworksObjectLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PointSoilworksObjectDrawWrappers` | `PointSoilworksObjectDrawWrapper[]` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearWrappers` | `Void` | `` | `` |

#### Nested Types (1)

- `PointSoilworksObjectSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `PointSoilworksObjectSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.PointSoilworksObjectLayer+PointSoilworksObjectSelectionSet` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet`
      - `Topomatic.Soilworks.Layers.PointSoilworksObjectLayer+PointSoilworksObjectSelectionSet`

#### Constructors (1)

- `.ctor(PointSoilworksObjectLayer layer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `PointSoilworksObjectLayer` | `PointSoilworksObjectLayer` | `get` | No | `` |

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

### `SectorLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.SectorLayer` |
| **Base Type** | `Topomatic.Soilworks.Layers.MassContainerLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer`
      - `Topomatic.Soilworks.Layers.MassContainerLayer`
        - `Topomatic.Soilworks.Layers.SectorLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SectorDrawWrappers` | `SectorDrawWrapper[]` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearWrappers` | `Void` | `` | `` |
| `ResetWrappers` | `Void` | `` | `` |

#### Nested Types (1)

- `SectorSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `SectorSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.SectorLayer+SectorSelectionSet` |
| **Base Type** | `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Soilworks.Layers.BaseSoilworksLayer+BaseSoliworksSelectionSet`
      - `Topomatic.Soilworks.Layers.SectorLayer+SectorSelectionSet`

#### Constructors (1)

- `.ctor(SectorLayer layer)`

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

### `SoilworksCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.SoilworksCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Soilworks.ISoilworksContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Soilworks.Layers.SoilworksCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Soilworks` | `Soilworks` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ModelChanged` | `Void` | `Object sender, EventArgs e` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISoilworksContainer` | `get_Soilworks` |

### `SoilworksLayersConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.SoilworksLayersConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (20)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CONNECTION_LINK_ARROW_HEIGHT` | `Double` | Yes | `5` | `` |
| `CONNECTION_LINK_ARROW_WIDTH` | `Double` | Yes | `5` | `` |
| `CONNECTION_LINK_DEFAULT_ARC_RADIUS` | `Double` | Yes | `25` | `` |
| `CONNECTION_LINK_DISTANCE_TEXT_HEIGHT` | `UInt32` | Yes | `3` | `` |
| `CONNECTION_LINK_DISTANCE_Y_OFFSET` | `UInt32` | Yes | `5` | `` |
| `HAULAGE_ARROW_HEIGHT` | `Double` | Yes | `5` | `` |
| `HAULAGE_ARROW_WIDTH` | `Double` | Yes | `5` | `` |
| `HAULAGE_DEFAULT_ARC_RADIUS` | `Double` | Yes | `15` | `` |
| `HAULAGE_VALUE_TEXT_HEIGHT` | `UInt32` | Yes | `3` | `` |
| `HAULAGE_VALUE_TEXT_Y_OFFSET` | `UInt32` | Yes | `5` | `` |
| `LINEAR_SECTOR_DEFAULT_ARC_RADIUS` | `Double` | Yes | `5` | `` |
| `LINEAR_SOILWORKS_OBJECT_PK_SCALE_WIDTH` | `Double` | Yes | `5` | `` |
| `LINEAR_SOILWORKS_OBJECT_PK_TEXT_HEIGHT` | `UInt32` | Yes | `4` | `` |
| `LINEAR_SOILWORKS_OBJECT_WIDTH` | `UInt32` | Yes | `4` | `` |
| `POINT_SOILWORKS_OBJECT_DEFAULT_ARC_RADIUS` | `Double` | Yes | `25` | `` |
| `POINT_SOILWORKS_OBJECT_MIN_SIZE` | `Double` | Yes | `10` | `` |
| `SECTOR_MATERIAL_POLYGON_OFFSET` | `Double` | Yes | `0.0500000007450581` | `` |
| `SECTOR_TEXT_HEIGHT` | `UInt32` | Yes | `4` | `` |
| `VOLUME_FILL_INDICATOR_COLOR_COEFF` | `Double` | Yes | `0.75` | `` |
| `VOLUME_MAX_WIDTH` | `UInt32` | Yes | `20` | `` |

---
## Namespace: `Topomatic.Soilworks.Layers.Design`

### `ApplicabilityListEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Design.ApplicabilityListEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Soilworks.Layers.Design.ApplicabilityListEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `ApplicabilityStateWrappersListConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Design.ApplicabilityStateWrappersListConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Soilworks.Layers.Design.ApplicabilityStateWrappersListConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `MaterialDatasConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Design.MaterialDatasConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Soilworks.Layers.Design.MaterialDatasConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `MaterialDataWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Design.MaterialDataWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Soilworks.Layers.Design.MaterialDataWrapper`

#### Constructors (1)

- `.ctor(List<MaterialData> materialDatas, Soilworks soilworks, Boolean readOnly)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `MaterialEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Design.MaterialEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Soilworks.Layers.Design.MaterialEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `MaterialsValuesEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Design.MaterialsValuesEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Soilworks.Layers.Design.MaterialsValuesEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `SoilworksObjectValueConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Design.SoilworksObjectValueConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Soilworks.Layers.Design.SoilworksObjectValueConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

---
## Namespace: `Topomatic.Soilworks.Layers.Dialogs`

### `SelectApplicabilitiesDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Dialogs.SelectApplicabilitiesDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Soilworks.Layers.Dialogs.SelectApplicabilitiesDlg`

#### Constructors (1)

- `.ctor(ApplicabilityStateWrapper[] applicabilityStateWrappers)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicabilityStateWrappers` | `ApplicabilityStateWrapper[]` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectSoilworksObjectDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Dialogs.SelectSoilworksObjectDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Soilworks.Layers.Dialogs.SelectSoilworksObjectDlg`

#### Constructors (1)

- `.ctor(SoilworksObject[] soilworksObjects)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectedSoilworksObject` | `SoilworksObject` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Soilworks.Layers.DrawWrappers`

### `BaseLinearSectorDrawWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.BaseLinearSectorDrawWrapper` |
| **Base Type** | `Topomatic.Soilworks.Layers.DrawWrappers.SectorDrawWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.Soilworks.IMassContainerWrapper, Topomatic.Soilworks.ISoilworksContainer, Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Soilworks.Layers.DrawWrappers.SectorDrawWrapper`
    - `Topomatic.Soilworks.Layers.DrawWrappers.BaseLinearSectorDrawWrapper`

#### Constructors (1)

- `.ctor(BaseLinearSector sector)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `End` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get` | No | `Browsable` |
| `Length` | `Double` | `get` | No | `` |
| `LinearSoilworksObject` | `LinearSoilworksObject` | `get` | No | `Browsable` |
| `Start` | `String` | `get/set` | No | `` |
| `YOffset` | `Double` | `get/set` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConnectionLinkDrawWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.ConnectionLinkDrawWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ConnectionLink connectionLink)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionLink` | `ConnectionLink` | `get` | No | `Browsable` |
| `Distance` | `Double` | `get/set` | No | `DefaultDouble` |
| `Layer` | `String` | `get` | No | `` |
| `LineColor` | `CadColor` | `get/set` | No | `` |
| `Object1ConnectionPoint` | `String` | `get/set` | No | `ConditionalBrowsable` |
| `Object2ConnectionPoint` | `String` | `get/set` | No | `ConditionalBrowsable` |
| `ObjectConnected1` | `SoilworksObject` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor, PropertyTypeConverter` |
| `ObjectConnected2` | `SoilworksObject` | `get/set` | No | `PropertyEditor, PropertyTypeConverter, PropertyUpdateSequence` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |
| `YPosition` | `Double` | `get/set` | No | `DefaultDouble` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |

### `ContainerSoilworksObjectDrawWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.ContainerSoilworksObjectDrawWrapper` |
| **Base Type** | `Topomatic.Soilworks.Layers.DrawWrappers.SoilworksObjectDrawWrapper` |
| **Implements** | `Topomatic.Soilworks.ISoilworksObjectWrapper, Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Soilworks.Layers.DrawWrappers.SoilworksObjectDrawWrapper`
    - `Topomatic.Soilworks.Layers.DrawWrappers.ContainerSoilworksObjectDrawWrapper`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ContainerSoilworksObject` | `ContainerSoilworksObject` | `get` | No | `Browsable` |
| `Layer` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `ContainerSoilworksObjectDrawWrapper` | `ContainerSoilworksObject containerSoilworksObject` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HaulageDrawWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.HaulageDrawWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Haulage haulage)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CutQuantity` | `Double` | `get` | No | `` |
| `Distance` | `Double` | `get/set` | No | `` |
| `FillQuantityCompacted` | `Double` | `get/set` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `PropertyEditor` |
| `Haulage` | `Haulage` | `get` | No | `Browsable` |
| `Layer` | `String` | `get` | No | `` |
| `LineColor` | `CadColor` | `get` | No | `` |
| `LossCoeff` | `Double` | `get` | No | `` |
| `Material` | `Material` | `get` | No | `` |
| `RecipientName` | `String` | `get` | No | `ReadOnly` |
| `SupplierName` | `String` | `get` | No | `ReadOnly` |
| `TotalCompaction` | `Double` | `get` | No | `` |
| `Type` | `HaulageType` | `get/set` | No | `PropertyEditor` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |

### `LinearSectorDrawWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.LinearSectorDrawWrapper` |
| **Base Type** | `Topomatic.Soilworks.Layers.DrawWrappers.BaseLinearSectorDrawWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.Soilworks.IMassContainerWrapper, Topomatic.Soilworks.ISoilworksContainer, Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Soilworks.Layers.DrawWrappers.SectorDrawWrapper`
    - `Topomatic.Soilworks.Layers.DrawWrappers.BaseLinearSectorDrawWrapper`
      - `Topomatic.Soilworks.Layers.DrawWrappers.LinearSectorDrawWrapper`

#### Constructors (1)

- `.ctor(LinearSector sector)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Position` | `Vector2D` | `get` | No | `Browsable` |
| `Type` | `SectorType` | `get` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LinearSoilworksObjectDrawWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.LinearSoilworksObjectDrawWrapper` |
| **Base Type** | `Topomatic.Soilworks.Layers.DrawWrappers.ContainerSoilworksObjectDrawWrapper` |
| **Implements** | `Topomatic.Soilworks.ISoilworksObjectWrapper, Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Soilworks.Layers.DrawWrappers.SoilworksObjectDrawWrapper`
    - `Topomatic.Soilworks.Layers.DrawWrappers.ContainerSoilworksObjectDrawWrapper`
      - `Topomatic.Soilworks.Layers.DrawWrappers.LinearSoilworksObjectDrawWrapper`

#### Constructors (1)

- `.ctor(LinearSoilworksObject linearSoilworksObject)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `End` | `String` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `DefaultDouble` |
| `Start` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MassContainerDrawCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.MassContainerDrawCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double arcRadius, Vector2D[] points, Vector2D[] volumeBorderPoints, CadColor color, Color volumeBorderColor)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArcRadius` | `Double` | `get` | No | `` |
| `BorderColor` | `Color` | `get` | No | `` |
| `Color` | `CadColor` | `get` | No | `` |
| `Points` | `Vector2D[]` | `get` | No | `` |
| `VolumeBorderPoints` | `Vector2D[]` | `get` | No | `` |
| `VolumeDrawCaches` | `VolumeDrawCache[]` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddVolumeDrawCache` | `Void` | `VolumeDrawCache volumeDrawCache` | `` |

#### Nested Types (1)

- `VolumeDrawCache` (struct)

### `ParallelSectorDrawWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.ParallelSectorDrawWrapper` |
| **Base Type** | `Topomatic.Soilworks.Layers.DrawWrappers.BaseLinearSectorDrawWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.Soilworks.IMassContainerWrapper, Topomatic.Soilworks.ISoilworksContainer, Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Soilworks.Layers.DrawWrappers.SectorDrawWrapper`
    - `Topomatic.Soilworks.Layers.DrawWrappers.BaseLinearSectorDrawWrapper`
      - `Topomatic.Soilworks.Layers.DrawWrappers.ParallelSectorDrawWrapper`

#### Constructors (1)

- `.ctor(ParallelSector sector)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Distance` | `Double` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointSoilworksObjectDrawWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.PointSoilworksObjectDrawWrapper` |
| **Base Type** | `Topomatic.Soilworks.Layers.DrawWrappers.SoilworksObjectDrawWrapper` |
| **Implements** | `Topomatic.Soilworks.ISoilworksObjectWrapper, Topomatic.FoundationClasses.IWrapped, Topomatic.Soilworks.IMassContainerWrapper, Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer, Topomatic.Soilworks.ISoilworksContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Soilworks.Layers.DrawWrappers.SoilworksObjectDrawWrapper`
    - `Topomatic.Soilworks.Layers.DrawWrappers.PointSoilworksObjectDrawWrapper`

#### Constructors (1)

- `.ctor(PointSoilworksObject pointSoilworksObject)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicabilityStateWrappers` | `ApplicabilityStateWrapper[]` | `get/set` | No | `PropertyEditor, ConditionalReadOnly, PropertyTypeConverter` |
| `HauledVolume` | `Double` | `get` | No | `DefaultDouble` |
| `Height` | `Double` | `get/set` | No | `` |
| `IsRecipient` | `Boolean` | `get/set` | No | `` |
| `IsSupplier` | `Boolean` | `get/set` | No | `` |
| `Layer` | `String` | `get` | No | `` |
| `MassContainer` | `IMassContainer` | `get` | No | `Browsable` |
| `Materials` | `MaterialData[]` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Points` | `Vector2D[]` | `get` | No | `Browsable` |
| `PointSoilworksObject` | `PointSoilworksObject` | `get` | No | `Browsable` |
| `RemainingHaulQuantity` | `Double` | `get` | No | `DefaultDouble` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |
| `Volume` | `Double` | `get/set` | No | `ConditionalReadOnly, DefaultDouble` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IMassContainerWrapper` | `get_MassContainer` |
| `IApplicabilitiyStateWrapperContainer` | `get_ApplicabilityStateWrappers` |
| `IApplicabilitiyStateWrapperContainer` | `set_ApplicabilityStateWrappers` |
| `ISoilworksContainer` | `get_Soilworks` |

### `SectorDrawWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.SectorDrawWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.Soilworks.IMassContainerWrapper, Topomatic.Soilworks.ISoilworksContainer, Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicabilityStateWrappers` | `ApplicabilityStateWrapper[]` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter, PropertyEditor` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `ConditionalBrowsable` |
| `HauledVolume` | `Double` | `get` | No | `DefaultDouble` |
| `IsRecipient` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `IsSupplier` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `Layer` | `String` | `get` | No | `` |
| `MassContainer` | `IMassContainer` | `get` | No | `Browsable` |
| `Materials` | `MaterialData[]` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Name` | `String` | `get/set` | No | `` |
| `Points` | `Vector2D[]` | `get` | No | `Browsable` |
| `RemainingHaulVolume` | `Double` | `get` | No | `DefaultDouble` |
| `Sector` | `Sector` | `get` | No | `Browsable` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |
| `Volume` | `Double` | `get/set` | No | `DefaultDouble, ConditionalReadOnly` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `DeviceContext deviceContext, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `BoundingBox2D` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `SectorDrawWrapper` | `Sector sector` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |
| `IMassContainerWrapper` | `get_MassContainer` |
| `ISoilworksContainer` | `get_Soilworks` |
| `IApplicabilitiyStateWrapperContainer` | `get_ApplicabilityStateWrappers` |
| `IApplicabilitiyStateWrapperContainer` | `set_ApplicabilityStateWrappers` |

### `SoilworksObjectDrawWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.SoilworksObjectDrawWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Soilworks.ISoilworksObjectWrapper, Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SoilworksObject soilworksObject)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `DefaultWidth` |
| `Name` | `String` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `SoilworksObject` | `SoilworksObject` | `get` | No | `Browsable` |
| `Transit` | `Boolean` | `get/set` | No | `PropertyEditor` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISoilworksObjectWrapper` | `get_SoilworksObject` |
| `IWrapped` | `get_WrappedObject` |

### `VolumeDrawCache` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.DrawWrappers.MassContainerDrawCache+VolumeDrawCache` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Soilworks.Layers.DrawWrappers.MassContainerDrawCache+VolumeDrawCache`

#### Constructors (1)

- `.ctor(Color color, Vector2D[] points)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Color` | `get` | No | `` |
| `Points` | `Vector2D[]` | `get` | No | `` |

---
## Namespace: `Topomatic.Soilworks.Layers.Wrappers`

### `ApplicabilityStateWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Layers.Wrappers.ApplicabilityStateWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IEquatable`1[[Topomatic.Soilworks.Layers.Wrappers.ApplicabilityStateWrapper, Topomatic.Soilworks.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Applicability applicability, CheckState state)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicability` | `Applicability` | `get/set` | No | `` |
| `State` | `CheckState` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ApplicabilityStateWrapper other` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 38 |
| **Classes** | 29 |
| **Interfaces** | 1 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 6 |
| **Static Classes** | 1 |
| **Total Methods** | 124 |
| **Total Properties** | 122 |
| **Total Fields** | 22 |
| **Total Events** | 0 |
| **Total Constructors** | 32 |
| **Nested Types** | 7 |
| **Extension Methods** | 0 |


