# Topomatic.Culverts.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Culverts.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Culverts.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Culverts.Layers.dll` |

---
## Namespace: `Topomatic.Culverts.Layers`

### `BaseCulvertLineLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.BaseCulvertLineLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.BaseCulvertLineLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Wrapper` | `LineWrapperBase` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CulverSurfaceLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.CulverSurfaceLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.CulverSurfaceLayer`

#### Constructors (1)

- `.ctor(Boolean isEg)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `CulvertCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.CulvertCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Dwg.IDrawingContainer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Culverts.Layers.CulvertCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `Culvert` | `Culvert` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCulvertCompoundLayer` | `CulvertCompoundLayer` | `CadView cadView, Boolean readOnly` | `` |
| `GetCulvertCompoundLayer` | `CulvertCompoundLayer` | `CadView cadView` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |
| `IDrawingContainer` | `get_Drawing` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

### `CulvertLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CulvertLineLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.CulvertLineLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.BaseCulvertLineLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.BaseCulvertLineLayer`
        - `Topomatic.Culverts.Layers.CulvertLineLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `LayerSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.LayerSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Culverts.Layers.LayerSelectionSet`

#### Constructors (1)

- `.ctor(BaseCulvertLineLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (11)

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
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `LineWrapperBase` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.LineWrapperBase` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Culvert culvert)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, CadColor color, Boolean enable` | `` |
| `GetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `ToString` | `String` | `` | `` |

---
## Namespace: `Topomatic.Culverts.Layers.ClvConstruction`

### `CenterLineLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.ClvConstruction.CenterLineLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.ClvConstruction.CenterLineLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

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

### `CulvertConstructionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.ClvConstruction.CulvertConstructionLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.ClvConstruction.CulvertConstructionLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

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

---
## Namespace: `Topomatic.Culverts.Layers.Design`

### `ClvElementsPropsProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Design.ClvElementsPropsProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Culverts.Layers.Design.ClvElementsPropsProvider`

#### Constructors (1)

- `.ctor(HashSet<String> exclude)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InstanceDependence` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `ClvElementsPropsProviderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Design.ClvElementsPropsProviderAttribute` |
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
      - `Topomatic.Culverts.Layers.Design.ClvElementsPropsProviderAttribute`

#### Constructors (1)

- `.ctor(String[] exclude)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Culverts.Layers.Plan`

### `CaptionGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.CaptionGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Culverts.Layers.Plan.CaptionGrip`

#### Constructors (1)

- `.ctor(CadView cadview, CaptionLayer layer, CaptionWrapper wrapper)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CaptionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.CaptionLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.Plan.CaptionLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColor` | `CadColor` | `` | `` |
| `GetDwgEnable` | `Boolean` | `` | `` |
| `GetDwgLayer` | `DwgLayer` | `` | `` |
| `GetDwgVisible` | `Boolean` | `` | `` |
| `GetWrapper` | `CaptionWrapper` | `` | `` |
| `SetDwgEnable` | `Void` | `Boolean value` | `` |
| `SetDwgVisible` | `Void` | `Boolean value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |

### `CaptionSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.CaptionSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Culverts.Layers.Plan.CaptionSelectionSet`

#### Constructors (1)

- `.ctor(CaptionLayer layer)`

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

### `CaptionWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.CaptionWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView, Culvert culvert, CaptionLayer layer)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CaptionSide` | `PlanCaptionSide` | `get/set` | No | `PropertyTypeConverter` |
| `CaptionSta` | `Double` | `get/set` | No | `Browsable` |
| `Culvert` | `Culvert` | `get` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `Rotated` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, CadColor cadColor, Boolean resolveEnable, Double stationDelta` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

### `CulvertPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.CulvertPlanLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.BaseCulvertLineLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.BaseCulvertLineLayer`
        - `Topomatic.Culverts.Layers.Plan.CulvertPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Pivot` | `Vector3D` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDwgEnable` | `Boolean` | `` | `` |
| `GetDwgLayer` | `DwgLayer` | `` | `` |
| `GetDwgVisible` | `Boolean` | `` | `` |
| `Invalidate` | `Void` | `` | `` |
| `SetDwgEnable` | `Void` | `Boolean value` | `` |
| `SetDwgVisible` | `Void` | `Boolean value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |

### `ElevationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.ElevationLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.Plan.ElevationLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColor` | `CadColor` | `` | `` |
| `GetDwgEnable` | `Boolean` | `` | `` |
| `GetDwgLayer` | `DwgLayer` | `` | `` |
| `GetDwgVisible` | `Boolean` | `` | `` |
| `GetWrappers` | `List<ElevationWrapper>` | `` | `` |
| `SetDwgEnable` | `Void` | `Boolean value` | `` |
| `SetDwgVisible` | `Void` | `Boolean value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |

### `ElevationPositionGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.ElevationPositionGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Culverts.Layers.Plan.ElevationPositionGrip`

#### Constructors (1)

- `.ctor(CadView cadview, ElevationLayer layer, ElevationWrapper wrapper)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElevationRotationGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.ElevationRotationGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Culverts.Layers.Plan.ElevationRotationGrip`

#### Constructors (1)

- `.ctor(CadView cadview, ElevationLayer layer, ElevationWrapper wrapper)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElevationSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.ElevationSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Culverts.Layers.Plan.ElevationSelectionSet`

#### Constructors (1)

- `.ctor(ElevationLayer layer)`

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

### `ElevationSide` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.ElevationSide` |
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
      - `Topomatic.Culverts.Layers.Plan.ElevationSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `ElevationSide` | Yes | `Left` | `` |
| `Right` | `ElevationSide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

### `ElevationWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.ElevationWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView, Culvert culvert, ElevationLayer layer, Boolean isStartElevation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `Browsable` |
| `IsStartElevation` | `Boolean` | `get` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `Offset` | `Vector2D` | `get/set` | No | `Browsable` |
| `Rotation` | `Double` | `get/set` | No | `Browsable` |
| `Side` | `ElevationSide` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, CadColor cadColor, Boolean resolveEnable, Vector2D offset, Double rotation` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

### `PlanClvAxisLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.PlanClvAxisLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.Plan.PlanClvAxisLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetDwgEnable` | `Boolean` | `` | `` |
| `GetDwgLayer` | `DwgLayer` | `` | `` |
| `GetDwgVisible` | `Boolean` | `` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `SetDwgEnable` | `Void` | `Boolean value` | `` |
| `SetDwgVisible` | `Void` | `Boolean value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `SimplifiedRepresentationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.SimplifiedRepresentationLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.Plan.SimplifiedRepresentationLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDwgEnable` | `Boolean` | `` | `` |
| `GetDwgLayer` | `DwgLayer` | `` | `` |
| `GetDwgVisible` | `Boolean` | `` | `` |
| `GetWrapper` | `SimplifiedRepresentationWrapper` | `` | `` |
| `SetDwgEnable` | `Void` | `Boolean value` | `` |
| `SetDwgVisible` | `Void` | `Boolean value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |

### `SimplifiedRepresentationSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.SimplifiedRepresentationSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Culverts.Layers.Plan.SimplifiedRepresentationSelectionSet`

#### Constructors (1)

- `.ctor(SimplifiedRepresentationLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (11)

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
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `SimplifiedRepresentationWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Plan.SimplifiedRepresentationWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView, Culvert culvert, SimplifiedRepresentationLayer layer)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlbumName` | `String` | `get` | No | `` |
| `Culvert` | `Culvert` | `get` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `ModelName` | `String` | `get` | No | `` |
| `PipeAlignmentAngle` | `Double` | `get` | No | `Angle, ConditionalReadOnly, PropertyUpdateSequence` |
| `PipeElevation` | `Double` | `get` | No | `Elevation, PropertyUpdateSequence` |
| `PipeGrade` | `Double` | `get` | No | `PropertyUpdateSequence, Grade` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, CadColor cadColor, Boolean resolveEnable` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `ToString` | `String` | `` | `` |

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
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

---
## Namespace: `Topomatic.Culverts.Layers.Prism`

### `BaseCulvertPrismLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Prism.BaseCulvertPrismLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.CulvertLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.Prism.BaseCulvertPrismLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CulvertPrismLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Prism.CulvertPrismLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.Prism.BaseCulvertPrismLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.Prism.BaseCulvertPrismLayer`
        - `Topomatic.Culverts.Layers.Prism.CulvertPrismLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `CulvertUrbLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Prism.CulvertUrbLayer` |
| **Base Type** | `Topomatic.Culverts.Layers.Prism.BaseCulvertPrismLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Culverts.Layers.CulvertLayer`
      - `Topomatic.Culverts.Layers.Prism.BaseCulvertPrismLayer`
        - `Topomatic.Culverts.Layers.Prism.CulvertUrbLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `Position` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Prism.Position` |
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
      - `Topomatic.Culverts.Layers.Prism.Position`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `Position` | Yes | `Center` | `` |
| `Left` | `Position` | Yes | `Left` | `` |
| `Right` | `Position` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Center` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `PrismWrapperBase` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Layers.Prism.PrismWrapperBase` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Culvert culvert)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Boolean enable` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawAuxiliaryLine3d` | `Void` | `DeviceContext dc, Color color, Vector3D position, Vector3D direction` | `` |
| `DrawCenter` | `Void` | `DeviceContext dc, Vector2D center` | `` |
| `DrawPrism` | `Void` | `DeviceContext dc, Vector2D leftTop, Vector2D rightTop, Vector2D leftBottom, Vector2D rightBottom` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 31 |
| **Classes** | 24 |
| **Interfaces** | 0 |
| **Enums** | 2 |
| **Structs** | 0 |
| **Abstract Classes** | 5 |
| **Static Classes** | 0 |
| **Total Methods** | 118 |
| **Total Properties** | 73 |
| **Total Fields** | 18 |
| **Total Events** | 0 |
| **Total Constructors** | 28 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


