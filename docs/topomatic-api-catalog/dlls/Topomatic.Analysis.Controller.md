# Topomatic.Analysis.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Analysis.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Analysis.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Analysis.Controller.dll` |

---
## Namespace: `Topomatic.Analysis.Controller`

### `AnalysisPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.AnalysisPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Analysis.Controller.AnalysisPluginHost`

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

---
## Namespace: `Topomatic.Analysis.Controller.Alg`

### `Visibility3DFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Alg.Visibility3DFrame` |
| **Base Type** | `Topomatic.Tables.Export.UserSheetWizardFrame` |
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
            - `System.Windows.Forms.UserControl`
              - `Topomatic.Tables.Export.UserSheetWizardFrame`
                - `Topomatic.Analysis.Controller.Alg.Visibility3DFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Boolean` | `UserSheet sheet` | `` |
| `OnInitialize` | `Void` | `UserSheet sheet` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Analysis.Controller.Common.Styles`

### `CommonProfileLayerStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Common.Styles.CommonProfileLayerStyle` |
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
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

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

### `PrecisionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Common.Styles.PrecisionStyle` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Analysis.Controller.Common.Styles.PrecisionStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleDigits` | `Int32` | `get/set` | No | `` |
| `AngleUnit` | `AngleUnits` | `get/set` | No | `` |
| `CoordinateDigits` | `Int32` | `get/set` | No | `` |
| `ElevationDigits` | `Int32` | `get/set` | No | `` |
| `FloatDigits` | `Int32` | `get/set` | No | `` |
| `GradeDigits` | `Int32` | `get/set` | No | `` |
| `LengthDigits` | `Int32` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RadiusDigits` | `Int32` | `get/set` | No | `` |
| `RoundGrades` | `Boolean` | `get/set` | No | `` |
| `ShowAngleEndZeroFeet` | `Boolean` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AngleToStr` | `String` | `Double value` | `` |
| `CoordinateToStr` | `String` | `Double value` | `` |
| `CopyProperties` | `Void` | `PrecisionStyle style` | `` |
| `ElevationToStr` | `String` | `Double value` | `` |
| `FloatToStr` | `String` | `Double value` | `` |
| `GradeToStr` | `String` | `Double value` | `` |
| `LengthToStr` | `String` | `Double value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RadiusToStr` | `String` | `Double value` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |

---
## Namespace: `Topomatic.Analysis.Controller.Plc`

### `PowerLineMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Plc.PowerLineMockupLayer` |
| **Base Type** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`
        - `Topomatic.Analysis.Controller.Plc.PowerLineMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PowerLine` | `PowerLine` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Analysis.Controller.Plc.Communications`

### `PowerLineCommunications` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Plc.Communications.PowerLineCommunications` |
| **Base Type** | `Topomatic.Alg.Runtime.Communications.Communications` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Runtime.Communications.Communications`
      - `Topomatic.Analysis.Controller.Plc.Communications.PowerLineCommunications`

#### Constructors (1)

- `.ctor(PowerLine powerLine)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `PowerLine` | `PowerLine` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Double` | `Double station` | `` |
| `GetIntersections` | `Void` | `Vector2D center, Double radius, Double sangle, Double eangle, IList<Double> stations` | `` |
| `GetIntersections` | `Void` | `Vector2D a, Vector2D b, IList<Double> stations` | `` |
| `StationToPos` | `Vector2D` | `Double station` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Analysis.Controller.Plc.PowerLineClasses`

### `PowerLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Plc.PowerLineClasses.PowerLine` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Analysis.Controller.Plc.PowerLineClasses.PowerLine`

#### Constructors (1)

- `.ctor(Object parent, List<PowerLineNode> line)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommunicationsStyle` | `CommonProfileLayerStyle` | `get` | No | `` |
| `EgProfile` | `Section` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Double` | `Double station` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `StgTag` | `String` | Yes | `"<StgNode>"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `PowerLineNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Plc.PowerLineClasses.PowerLineNode` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `PowerLineNode` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SurfaceIndex` | `Int32` | No | `` | `` |
| `Vertex` | `Vector3D` | No | `` | `` |

---
## Namespace: `Topomatic.Analysis.Controller.PlcMockup`

### `PowerLineMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.PlcMockup.PowerLineMockupLayer` |
| **Base Type** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`
        - `Topomatic.Analysis.Controller.PlcMockup.PowerLineMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PowerLine` | `PowerLine` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Analysis.Controller.Sfc`

### `ISfcSection` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.ISfcSection` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsStatic` | `Boolean` | `get/set` | No | `` |
| `LinearObject` | `ILinearObject` | `get/set` | No | `` |
| `StaticSections` | `IList<SfcSectionProfile>` | `get` | No | `` |

### `SfcSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.SfcSection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Analysis.Controller.Sfc.ISfcSection` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Analysis.Controller.Sfc.SfcSection`

#### Constructors (1)

- `.ctor(Object parent, ProjectStateConfiguration сonfiguration)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Configuration` | `ProjectStateConfiguration` | `get` | No | `` |
| `Guid` | `Guid` | `get` | No | `` |
| `IsStatic` | `Boolean` | `get/set` | No | `` |
| `LinearObject` | `ILinearObject` | `get/set` | No | `` |
| `Mockups` | `MockupCollection` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PrecisionStyle` | `PrecisionStyle` | `get` | No | `` |
| `StaticSections` | `IList<SfcSectionProfile>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AllSource` | `String` | Yes | `` | `` |
| `ExistingPath` | `String` | No | `` | `` |
| `ProjectPath` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ISfcSection` | `get_LinearObject` |
| `ISfcSection` | `set_LinearObject` |
| `ISfcSection` | `get_StaticSections` |
| `ISfcSection` | `get_IsStatic` |
| `ISfcSection` | `set_IsStatic` |

### `SfcSectionConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.SfcSectionConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DWL_MODEL_TYPE` | `String` | Yes | `"application/sfc-section-dwl"` | `` |
| `GetSfcSectionData` | `String` | Yes | `"get_sfc_section_data"` | `` |
| `GetStructureLineSfcSectionProfile` | `String` | Yes | `"get_structure_line_sfc_section_profile"` | `` |
| `MODEL_TYPE` | `String` | Yes | `"sfcsectionmodel"` | `` |
| `RemoveSection` | `String` | Yes | `"remove_sfc_section"` | `` |
| `WindowID` | `String` | Yes | `"id_sfc_section_window"` | `` |

### `SfcSectionModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.SfcSectionModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Analysis.Controller.Sfc.SfcSectionModel`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ProjectStateConfiguration сonfiguration)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Section` | `SfcSection` | `get` | No | `` |

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

### `SfcSectionProfile` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.SfcSectionProfile` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Analysis.Controller.Sfc.SfcSectionProfile`

#### Constructors (1)

- `.ctor(Section section, String nameSurface, String relativePath)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `NameSurface` | `String` | `get` | No | `` |
| `RelativePath` | `String` | `get` | No | `` |
| `Section` | `Section` | `get` | No | `` |

---
## Namespace: `Topomatic.Analysis.Controller.Sfc.Layers`

### `LayerTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.Layers.LayerTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDashPattern` | `LinetypePattern` | `Double penScale` | `` |

---
## Namespace: `Topomatic.Analysis.Controller.Sfc.Plt`

### `SfcSectionFieldProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.Plt.SfcSectionFieldProvider` |
| **Base Type** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.TemplateFieldProvider`
    - `Topomatic.Analysis.Controller.Sfc.Plt.SfcSectionFieldProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

### `SfcSectionPltCommonVariablesProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.Plt.SfcSectionPltCommonVariablesProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Analysis.Controller.Sfc.Plt.SfcSectionPltCommonVariablesProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

---
## Namespace: `Topomatic.Analysis.Controller.Sfc.Plt.Fields`

### `BaseSectionField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.Plt.Fields.BaseSectionField` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Analysis.Controller.Sfc.Plt.Fields.BaseSectionField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScaleHField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.Plt.Fields.ScaleHField` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Analysis.Controller.Sfc.Plt.Fields.ScaleHField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScaleVField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.Sfc.Plt.Fields.ScaleVField` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Analysis.Controller.Sfc.Plt.Fields.ScaleVField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Analysis.Controller.SfcMockup`

### `SectionMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Analysis.Controller.SfcMockup.SectionMockupLayer` |
| **Base Type** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`
        - `Topomatic.Analysis.Controller.SfcMockup.SectionMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Section` | `SfcSection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 21 |
| **Classes** | 17 |
| **Interfaces** | 1 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 0 |
| **Static Classes** | 2 |
| **Total Methods** | 34 |
| **Total Properties** | 39 |
| **Total Fields** | 12 |
| **Total Events** | 0 |
| **Total Constructors** | 19 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


