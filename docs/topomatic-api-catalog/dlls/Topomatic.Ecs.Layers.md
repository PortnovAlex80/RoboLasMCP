# Topomatic.Ecs.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Ecs.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Ecs.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Ecs.Layers.dll` |

---
## Namespace: `Topomatic.Ecs.Layers`

### `AlignmentExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.AlignmentExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEcs` | `Ecs` | `Alignment alignment` | `Extension` |

### `EcsDrawer` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `EcsMastWrapper mw, CadPen pen, CadView cadView, InfoForCache info, DwgEntity[] list, Vector2D newPos` | `Extension` |
| `Draw` | `Void` | `EcsMastWrapper mw, CadPen pen, CadView cadView, InfoForCache info, DwgEntity[] list, Vector2D newPos, Boolean enabled, Boolean drawWipeout` | `Extension` |
| `Draw` | `Void` | `EcsMastWrapper mw, CadPen pen, CadView cadView, InfoForCache info, DwgEntity[] list, Boolean enabled` | `Extension` |
| `Draw` | `Void` | `EcsMastWrapper mw, CadPen pen, CadView cadView` | `Extension` |
| `Draw` | `Void` | `EcsMastWrapper mw, CadPen pen, CadView cadView, InfoForCache info, DwgEntity[] list` | `Extension` |
| `DrawSpan` | `Void` | `EcsMastWrapper mast, CadPen pen, Double annotationScale, Boolean enabled, TextStandard standard, CadFont font` | `Extension` |
| `DrawSpan` | `Void` | `EcsMastWrapper mast, CadPen pen, Vector2D userPoint, Boolean insertUserPoint, Double annotationScale, Boolean enabled` | `Extension` |
| `DrawSpan` | `Void` | `EcsMastWrapper mast, CadPen pen, Vector2D userPoint, Boolean insertUserPoint, Double annotationScale, Boolean enabled, TextStandard standard, CadFont font` | `Extension` |
| `DrawText` | `Void` | `CadPen pen, String content, Vector3D position, Double angle, TextStandard standard, CadFont font, Boolean background, Double scale` | `` |
| `DrawText` | `Void` | `CadPen pen, String content, Vector3D position, Double angle, String styleText, Boolean background, Double scale` | `` |

### `EcsPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer` |
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
      - `Topomatic.Ecs.Layers.EcsPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cache` | `List<DwgEntity>` | `get` | No | `` |
| `Ecs` | `EcsWrapper` | `get` | No | `` |
| `InfoCache` | `List<InfoForCache>` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `RefreshCache` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (12)

- `GripArrow` (class)
- `GripClearence` (class)
- `GripMast` (class)
- `GripMove` (abstract class)
- `GripNumber` (class)
- `GripOffset` (class)
- `GripSpan` (class)
- `GripText` (abstract class)
- `InfoForCache` (class)
- `MastsSelectionSet` (class)
- `SpanTextClickGrip` (class)
- `TextInvertClickGrip` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |

### `EcsStyleExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsStyleExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColor` | `CadColor` | `EcsLayerStyleItem style` | `Extension` |
| `GetEnable` | `Boolean` | `EcsLayerStyleItem style` | `Extension` |
| `GetLayer` | `DwgLayer` | `EcsLayerStyleItem style` | `Extension` |
| `GetMastSign` | `DwgBlock` | `EcsStyle style, EcsMast mast` | `Extension` |
| `GetVisible` | `Boolean` | `EcsLayerStyleItem style` | `Extension` |
| `GetZigzagSign` | `DwgBlock` | `EcsStyle style` | `Extension` |
| `SetEnable` | `Void` | `EcsLayerStyleItem style, Boolean value` | `Extension` |
| `SetVisible` | `Void` | `EcsLayerStyleItem style, Boolean value` | `Extension` |

### `GripArrow` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripArrow` |
| **Base Type** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripMove` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripMove`
      - `Topomatic.Ecs.Layers.EcsPlanLayer+GripArrow`

#### Constructors (1)

- `.ctor(CadView cadview, EcsMastWrapper mast, Double rotation, EcsPlanLayer layer)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GripClearence` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripClearence` |
| **Base Type** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripText` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripText`
      - `Topomatic.Ecs.Layers.EcsPlanLayer+GripClearence`

#### Constructors (1)

- `.ctor(CadView cadview, EcsMastWrapper mast, String content, Double rotationText)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GripMast` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripMast` |
| **Base Type** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripMove` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripMove`
      - `Topomatic.Ecs.Layers.EcsPlanLayer+GripMast`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnCreateMenu` |

### `GripMove` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripMove` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripMove`

#### Constructors (1)

- `.ctor(CadView cadview, EcsMastWrapper mast, EcsPlanLayer layer)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GripNumber` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripNumber` |
| **Base Type** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripText` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripText`
      - `Topomatic.Ecs.Layers.EcsPlanLayer+GripNumber`

#### Constructors (1)

- `.ctor(CadView cadview, EcsMastWrapper mast, String content, Double rotationText)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GripOffset` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripOffset` |
| **Base Type** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripText` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripText`
      - `Topomatic.Ecs.Layers.EcsPlanLayer+GripOffset`

#### Constructors (1)

- `.ctor(CadView cadview, EcsMastWrapper mast, String content, Double rotationText)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GripSpan` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripSpan` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripSpan`

#### Constructors (1)

- `.ctor(CadView cadview, EcsMastWrapper mast, String content, Double rotationText)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GripText` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+GripText` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+GripText`

#### Constructors (1)

- `.ctor(CadView cadview, EcsMastWrapper mast, String content, Double rotationText)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InfoForCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+InfoForCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Vector2D number, Vector2D clearence, Vector2D offset, Double angleText, Double angleSpanText)`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AngleText` | `Double` | No | `` | `` |
| `ClearencePos` | `Vector2D` | No | `` | `` |
| `NumberPos` | `Vector2D` | No | `` | `` |
| `OffsetPos` | `Vector2D` | No | `` | `` |

### `MastsSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+MastsSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+MastsSelectionSet`

#### Constructors (1)

- `.ctor(EcsPlanLayer layer)`

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

### `SpanTextClickGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+SpanTextClickGrip` |
| **Base Type** | `Topomatic.Cad.View.ClickGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.ClickGrip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+SpanTextClickGrip`

#### Constructors (1)

- `.ctor(EcsMastWrapper mast, Vector2D pos, Vector2D posText, Vector2D n, Double angle)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |

### `TextInvertClickGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.EcsPlanLayer+TextInvertClickGrip` |
| **Base Type** | `Topomatic.Cad.View.ClickGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.ClickGrip`
    - `Topomatic.Ecs.Layers.EcsPlanLayer+TextInvertClickGrip`

#### Constructors (1)

- `.ctor(EcsMastWrapper mast, Vector2D pos, Double angle)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnClick` | `Boolean` | `EventArgs e` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnPaint` |
| `IGrip` | `OnClick` |

---
## Namespace: `Topomatic.Ecs.Layers.Design`

### `EcsMastDesignStatusPropertyTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.Design.EcsMastDesignStatusPropertyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Ecs.Layers.Design.EcsMastDesignStatusPropertyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `EcsMastMaterialPropertyTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.Design.EcsMastMaterialPropertyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Ecs.Layers.Design.EcsMastMaterialPropertyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `EcsMastTypePropertyTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.Design.EcsMastTypePropertyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Ecs.Layers.Design.EcsMastTypePropertyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `EcsZigzagDirectionPropertyTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.Design.EcsZigzagDirectionPropertyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Ecs.Layers.Design.EcsZigzagDirectionPropertyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Ecs.Layers.UIWrappers`

### `EcsItemCollectionWrapper`2<ItemWrapperT where EcsItemWrapper`1, INamedTransactable, ITransactable, IUpdatable, IWrapped, IDisposable, class, EcsItemWrapper`1, ItemT where EcsItem, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, IEquatable`1, IEcsContainer, class, EcsItem>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.UIWrappers.EcsItemCollectionWrapper`2` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, , System.Collections.IEnumerable, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Ecs.Layers.UIWrappers.EcsItemCollectionWrapper`2`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ItemWrapperT` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `ItemWrapperT item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IEnumerable`1` | `System.Collections.Generic.IEnumerable<ItemWrapperT>.GetEnumerator` |
| `IEnumerable` | `GetEnumerator` |
| `IDisposable` | `Dispose` |

### `EcsItemWithIdWrapper`1<ItemT where EcsItemWithId, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, IEquatable`1, IEcsContainer, IHandledObject, class, EcsItemWithId>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.UIWrappers.EcsItemWithIdWrapper`1` |
| **Base Type** | `` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped, System.IDisposable, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - ``
      - `Topomatic.Ecs.Layers.UIWrappers.EcsItemWithIdWrapper`1`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |

### `EcsItemWrapper`1<ItemT where EcsItem, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, IEquatable`1, IEcsContainer, class, EcsItem>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.UIWrappers.EcsItemWrapper`1` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Ecs.Layers.UIWrappers.EcsItemWrapper`1`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IWrapped` | `get_WrappedObject` |
| `IDisposable` | `Dispose` |

### `EcsMastsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.UIWrappers.EcsMastsWrapper` |
| **Base Type** | `Topomatic.Ecs.Layers.UIWrappers.EcsItemCollectionWrapper`2[[Topomatic.Ecs.Layers.UIWrappers.EcsMastWrapper, Topomatic.Ecs.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Ecs.Layers.UIWrappers.EcsMastWrapper, Topomatic.Ecs.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Ecs.Layers.UIWrappers.EcsItemCollectionWrapper`2[[Topomatic.Ecs.Layers.UIWrappers.EcsMastWrapper, Topomatic.Ecs.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Ecs.Layers.UIWrappers.EcsMastsWrapper`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Masts` | `EcsMasts` | `get` | No | `` |
| `Style` | `EcsMastsStyle` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EcsMastWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.UIWrappers.EcsMastWrapper` |
| **Base Type** | `Topomatic.Ecs.Layers.UIWrappers.EcsItemWithIdWrapper`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped, System.IDisposable, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Ecs.Layers.UIWrappers.EcsItemWrapper`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Ecs.Layers.UIWrappers.EcsItemWithIdWrapper`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Ecs.Layers.UIWrappers.EcsMastWrapper`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasementCutoffElev` | `Double` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `Clearance` | `Double` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `Coords` | `Vector3D` | `get/set` | No | `PropertyUpdateSequence` |
| `DesignStatus` | `EcsMastDesignStatus` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `FixedSta` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `Index` | `Int32` | `get` | No | `Browsable` |
| `InvertSpanText` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `InvertText` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `Mast` | `EcsMast` | `get` | No | `Browsable` |
| `Masts` | `EcsMastsWrapper` | `get` | No | `Browsable` |
| `MastType` | `EcsMastType` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `Material` | `EcsMastMaterial` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `NextMast` | `EcsMastWrapper` | `get` | No | `Browsable` |
| `Number` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `Offset` | `Double` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `PrevMast` | `EcsMastWrapper` | `get` | No | `Browsable` |
| `SpanLength` | `Nullable<Double>` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `Station` | `Double` | `get/set` | No | `Browsable` |
| `StationStr` | `String` | `get/set` | No | `PropertyUpdateSequence` |
| `Width` | `Double` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `ZigzagDirection` | `EcsZigzagDirection` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `ZigzagOffset` | `Double` | `get/set` | No | `PropertyUpdateSequence` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSpanPosition` | `Vector2D` | `` | `` |
| `SetSpanPosition` | `Void` | `Vector2D pos` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EcsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Layers.UIWrappers.EcsWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Ecs Ecs)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ecs` | `Ecs` | `get` | No | `` |
| `Masts` | `EcsMastsWrapper` | `get` | No | `` |
| `Style` | `EcsStyle` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 26 |
| **Classes** | 20 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 3 |
| **Static Classes** | 3 |
| **Total Methods** | 59 |
| **Total Properties** | 41 |
| **Total Fields** | 5 |
| **Total Events** | 0 |
| **Total Constructors** | 18 |
| **Nested Types** | 12 |
| **Extension Methods** | 0 |


