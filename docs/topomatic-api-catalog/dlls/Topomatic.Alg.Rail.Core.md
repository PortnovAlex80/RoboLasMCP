# Topomatic.Alg.Rail.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Rail.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Rail.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Rail.Core.dll` |

---
## Namespace: `Topomatic.Alg.Rail.Core`

### `RailCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.RailCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.Rail.Core.RailCorePluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `Void` | `PluginFactory factory` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |

### `RailModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.RailModel` |
| **Base Type** | `Topomatic.Alg.Model.AlignmentModel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Sfc.ISurfaceContainer, Topomatic.Alg.IAlignmentContainer, Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer, System.IDisposable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Dwg.IDrawingContainer, Topomatic.Visualization.ImElementCollectionContainer, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer, Topomatic.Cad.Foundation.IStateElevationProviderFactory, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Alg.Model.AlignmentModel`
          - `Topomatic.Alg.Rail.Core.RailModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildSurface` | `Void` | `Surface surface, Boolean forced` | `` |
| `RefreshRelativePaths` | `Void` | `URI folderUri` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Rail.Core.GridPanel`

### `RailProjectProfileGridGradeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.GridPanel.RailProjectProfileGridGradeLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Rail.Core.GridPanel.RailProjectProfileGridGradeLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMouseDown` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseMove` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseUp` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Rail.Core.Plt`

### `StampData` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.Plt.StampData` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `String` | `get/set` | No | `` |
| `ProjectCipher` | `String` | `get/set` | No | `` |
| `ProjectDescription` | `String` | `get/set` | No | `` |
| `ProjectWorkDescription` | `String` | `get/set` | No | `` |
| `SheetCount` | `Int32` | `get/set` | No | `` |
| `SheetDescription` | `String` | `get/set` | No | `` |
| `SheetNum` | `Int32` | `get/set` | No | `` |
| `Stage` | `String` | `get/set` | No | `` |
| `Workers` | `WorkItem[]` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Applay` | `Void` | `DwgTemplateSheet sheet` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Attributes` | `Dictionary<String String>` | No | `` | `` |
| `LogoPath` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `WorkItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.Plt.WorkItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Rail.Core.Plt.WorkItem`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Date` | `String` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Person` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Rail.Core.Plt.Fields.Prf`

### `Side` (enum)

**Attributes**: [PropertyTypeConverter, Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.Plt.Fields.Prf.Side` |
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
      - `Topomatic.Alg.Rail.Core.Plt.Fields.Prf.Side`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `Side` | Yes | `Left` | `` |
| `Right` | `Side` | Yes | `Right` | `` |
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

### `SideConverter` (class)

**Attributes**: [Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.Plt.Fields.Prf.SideConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Rail.Core.Plt.Fields.Prf.SideConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Alg.Rail.Core.VerticalLayout`

### `RailVLayEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.VerticalLayout.RailVLayEditableItem` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Alg.Rail.Core.VerticalLayout.RailVLayEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BckDistTextOffset` | `Vector2D` | `get/set` | No | `` |
| `BckGradeTextOffset` | `Vector2D` | `get/set` | No | `` |
| `FlipSign` | `Boolean` | `get/set` | No | `` |
| `FwdDistTextOffset` | `Vector2D` | `get/set` | No | `` |
| `FwdGradeTextOffset` | `Vector2D` | `get/set` | No | `` |
| `PoleTextOffset` | `Vector2D` | `get/set` | No | `` |
| `StandOffset` | `Vector2D` | `get/set` | No | `` |
| `TopTextOffset` | `Vector2D` | `get/set` | No | `` |

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

### `RailVLayEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.VerticalLayout.RailVLayEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Alg.Rail.Core.VerticalLayout.RailVLayEiDrawer`

#### Constructors (1)

- `.ctor(Alignment alignment, RailVLayEiStyle style, CadView cadView)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `CadPen pen, RailVLayGradeSign sign, RailVLayEditableItem item` | `` |
| `DrawItem` | `Void` | `CadPen pen, RailVLayGradeSign sign, Boolean flipSign, Vector2D standOffset, Vector2D poleTextOffset, Vector2D bckGradeTextOffset, Vector2D bckDistTextOffset, Vector2D fwdGradeTextOffset, Vector2D fwdDistTextOffset, Vector2D topTextOffset` | `` |
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateGradeSignBlock` | `DwgBlock` | `Drawing drawing, RailVLayEiStyle style, String path, Double scale, RailVLayGradeSign sign, Boolean flipSign, Vector2D standOffset, Vector2D poleTextOffset, Vector2D bckGradeTextOffset, Vector2D bckDistTextOffset, Vector2D fwdGradeTextOffset, Vector2D fwdDistTextOffset, Vector2D topTextOffset` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_SignPositionThresholdX` | `Double` | Yes | `0.2` | `` |
| `c_SignPositionThresholdY` | `Double` | Yes | `0.5` | `` |

### `RailVLayEiStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.VerticalLayout.RailVLayEiStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Rail.Core.VerticalLayout.RailVLayEiStyle`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FixSignHeight` | `Boolean` | `get/set` | No | `` |
| `ShowElevByCurve` | `Boolean` | `get/set` | No | `` |
| `ShowRadius` | `Boolean` | `get/set` | No | `` |
| `SignMinHeight` | `Double` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

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

### `RailVLayGradeSign` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Core.VerticalLayout.RailVLayGradeSign` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Alignment alignment, Int32 nodeIndex)`
- `.ctor(Alignment alignment, Nullable<ProjectNode> nodeBck, ProjectNode nodeThis, Nullable<ProjectNode> nodeFwd)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `BckDistTextPosition` | `Vector2D` | `get/set` | No | `` |
| `BckGradeTextPosition` | `Vector2D` | `get/set` | No | `` |
| `BckHandAngle` | `Double` | `get/set` | No | `` |
| `DistBck` | `Double` | `get` | No | `` |
| `DistFwd` | `Double` | `get` | No | `` |
| `Elevation` | `Double` | `get/set` | No | `` |
| `ElevationWOCurve` | `Double` | `get` | No | `` |
| `FwdDistTextPosition` | `Vector2D` | `get/set` | No | `` |
| `FwdGradeTextPosition` | `Vector2D` | `get/set` | No | `` |
| `FwdHandAngle` | `Double` | `get/set` | No | `` |
| `GradeBck` | `Double` | `get` | No | `` |
| `GradeFwd` | `Double` | `get` | No | `` |
| `HasCurve` | `Boolean` | `get` | No | `` |
| `NextNode` | `Nullable<ProjectNode>` | `get` | No | `` |
| `NodeIndex` | `Int32` | `get` | No | `` |
| `PoleTextPosition` | `Vector2D` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get` | No | `` |
| `PrevNode` | `Nullable<ProjectNode>` | `get` | No | `` |
| `Radius` | `Double` | `get` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `TopTextPosition` | `Vector2D` | `get/set` | No | `` |
| `UpDirectionAngle` | `Double` | `get` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 11 |
| **Classes** | 9 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 1 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 22 |
| **Total Properties** | 47 |
| **Total Fields** | 10 |
| **Total Events** | 0 |
| **Total Constructors** | 10 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


