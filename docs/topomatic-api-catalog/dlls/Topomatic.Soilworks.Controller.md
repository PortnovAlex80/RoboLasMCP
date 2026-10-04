# Topomatic.Soilworks.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Soilworks.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Soilworks.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Soilworks.Controller.dll` |

---
## Namespace: `Simplex`

### `Constraint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Simplex.Constraint` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double[] coefficients, Double restriction)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Coefficients` | `Double[]` | `get` | No | `` |
| `Restriction` | `Double` | `get` | No | `` |

### `Dictionary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Simplex.Dictionary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(LPP lpp)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EntersBasis` | `Int32` | `` | `` |
| `Improve` | `Void` | `Int32 preferToLeave` | `` |
| `IsFeasible` | `Boolean` | `` | `` |
| `Recalculate` | `Void` | `Int32 enterIdx, Int32 leaveIdx` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `a` | `Double[]` | No | `` | `` |
| `basic` | `Int32[]` | No | `` | `` |
| `c` | `Double[]` | No | `` | `` |
| `slack` | `Int32[]` | No | `` | `` |
| `z0` | `Double` | No | `` | `` |

### `LPP` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Simplex.LPP` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ObjectiveFunction objFunc, Constraint[] constraints)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SolutionFound` | `Boolean` | `Dictionary d` | `` |
| `Solve` | `Boolean` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Caption` | `String` | No | `` | `` |
| `Constraints` | `Constraint[]` | No | `` | `` |
| `ObjFunc` | `ObjectiveFunction` | No | `` | `` |
| `Variables` | `Double[]` | No | `` | `` |

### `ObjectiveFunction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Simplex.ObjectiveFunction` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double[] coefficients)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Coefficients` | `Double[]` | `get` | No | `` |
| `VariablesNumber` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Value` | `Double` | `Double[] variables` | `` |

---
## Namespace: `Topomatic.Soilworks.Controller`

### `AutoDistributionMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.AutoDistributionMode` |
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
      - `Topomatic.Soilworks.Controller.AutoDistributionMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SimplexMethod` | `AutoDistributionMode` | Yes | `SimplexMethod` | `` |
| `value__` | `Int32` | No | `` | `` |
| `VogelMethod` | `AutoDistributionMode` | Yes | `VogelMethod` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `VogelMethod` | `0` |
| `SimplexMethod` | `1` |

**Underlying Type**: `System.Int32`

### `GroundMaterialLink` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.GroundMaterialLink` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Soilworks.ISoilworksContainer, Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Soilworks soilworks, String groundId, String groundName, Material material)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicabilityStateWrappers` | `ApplicabilityStateWrapper[]` | `get/set` | No | `PropertyEditor, DefaultWidth, PropertyTypeConverter` |
| `Cipher` | `String` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `ByLayer, ByBlock, DefaultWidth` |
| `CompactionCoeff` | `Double` | `get/set` | No | `PropertyEditor, DefaultDouble` |
| `GroundId` | `String` | `get` | No | `Browsable` |
| `GroundName` | `String` | `get/set` | No | `ReadOnly` |
| `Material` | `Material` | `get/set` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |
| `Priority` | `Int32` | `get/set` | No | `PropertyEditor` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISoilworksContainer` | `get_Soilworks` |
| `IApplicabilitiyStateWrapperContainer` | `get_ApplicabilityStateWrappers` |
| `IApplicabilitiyStateWrapperContainer` | `set_ApplicabilityStateWrappers` |

### `HaulagesGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.HaulagesGenerator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(ContainerSoilworksObject[] containerSoilworksObjects)`
- `.ctor(IMassContainer[] massConatiners)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoDistributionMode` | `AutoDistributionMode` | `get/set` | No | `` |
| `MaxHauledVolume` | `Double` | `get/set` | No | `` |
| `PreferredHaulageType` | `HaulageType` | `get/set` | No | `` |
| `SelectedMaterials` | `Material[]` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Generate` | `Void` | `` | `` |

### `LinearSectorGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.LinearSectorGenerator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSectors` | `Boolean` | `Alignment alignment, LinearSoilworksObjectSourceSettings sourceSettings, Soilworks soilworks, ref LinearSector[] resultSectors` | `` |

### `LinearSoilworksObjectCreator` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.LinearSoilworksObjectCreator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `LinearSoilworksObject` | `Soilworks soilworks` | `` |
| `Update` | `LinearSoilworksObject` | `LinearSoilworksObject linearSoilwroksObject, Alignment alignment` | `` |

### `LinearSoilworksObjectSourceSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.LinearSoilworksObjectSourceSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Soilworks.ITemplateItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Soilworks soilworks)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `Applicabilities` | `Applicability[]` | `get` | No | `` |
| `FromStation` | `Double` | `get/set` | No | `` |
| `GroundMaterialLinks` | `GroundMaterialLink[]` | `get` | No | `` |
| `OnlySelectedSections` | `Boolean` | `get/set` | No | `` |
| `PathId` | `String` | `get/set` | No | `` |
| `RecalcVolumesCache` | `Boolean` | `get/set` | No | `` |
| `Soilworks` | `Soilworks` | `get` | No | `` |
| `Stations` | `Double[]` | `get/set` | No | `` |
| `StationsFromTable` | `Boolean` | `get/set` | No | `` |
| `TemplateItems` | `TemplateItem[]` | `get` | No | `` |
| `TemplateItemsContainer` | `ITemplateItemsContainer` | `get/set` | No | `` |
| `ToStation` | `Double` | `get/set` | No | `` |
| `UpdatingMode` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddGroundMaterialLink` | `Void` | `GroundMaterialLink groundMaterialLink` | `` |
| `AddTemplateItem` | `Void` | `TemplateItem templateItem` | `` |
| `AddVolumesToCache` | `Void` | `Int32 sectionIndex, Volume[] volume` | `` |
| `ContainsVolumesForSection` | `Boolean` | `Int32 sectionIndex` | `` |
| `GetTemplateItems` | `TemplateItem[]` | `Int32[] codes` | `` |
| `GetVolumesForSection` | `Volume[]` | `Int32 sectionIndex` | `` |
| `RemoveGroundMaterialLink` | `Void` | `GroundMaterialLink groundMaterialLink` | `` |
| `RemoveTemplateItem` | `Void` | `TemplateItem templateItem` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITemplateItemsContainer` | `get_TemplateItems` |
| `ITemplateItemsContainer` | `RemoveTemplateItem` |
| `ITemplateItemsContainer` | `AddTemplateItem` |
| `ITemplateItemsContainer` | `get_Applicabilities` |

### `ParallelSectorTemplate` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.ParallelSectorTemplate` |
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
      - `Topomatic.Soilworks.Controller.ParallelSectorTemplate`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dump` | `ParallelSectorTemplate` | Yes | `Dump` | `` |
| `Junkyard` | `ParallelSectorTemplate` | Yes | `Junkyard` | `` |
| `Pit` | `ParallelSectorTemplate` | Yes | `Pit` | `` |
| `SpoilBank` | `ParallelSectorTemplate` | Yes | `SpoilBank` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Pit` | `0` |
| `Dump` | `1` |
| `SpoilBank` | `2` |
| `Junkyard` | `3` |

**Underlying Type**: `System.Int32`

### `SoilworksControllerModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.SoilworksControllerModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Soilworks.Controller.SoilworksControllerModule`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTransfer` | `Void` | `` | `cmd` |
| `AddTransferIn` | `Void` | `` | `cmd` |
| `AddTransferOut` | `Void` | `` | `cmd` |
| `BreakOnSectors` | `Void` | `` | `cmd` |
| `ConnectionLinkEdit` | `Void` | `` | `cmd` |
| `HaulageEdit` | `Void` | `` | `cmd` |
| `MergeSectors` | `Void` | `` | `cmd` |
| `SectorCanTransferIn` | `Boolean` | `` | `cmd` |
| `SectorCanTransferOut` | `Boolean` | `` | `cmd` |
| `SoilworkEditorAddDump` | `Void` | `` | `cmd` |
| `SoilworkEditorAddJunkyard` | `Void` | `` | `cmd` |
| `SoilworkEditorAddPit` | `Void` | `` | `cmd` |
| `SoilworkEditorAddSpoilBank` | `Void` | `` | `cmd` |
| `SoilworksEditorAddEmptyLinearObject` | `Void` | `` | `cmd` |
| `SoilworksEditorAddLinearObject` | `Void` | `` | `cmd` |
| `SoilworksObjectsAddLinks` | `Void` | `` | `cmd` |
| `UpdateLinearObjects` | `Void` | `` | `cmd` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SoilworksControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.SoilworksControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Soilworks.Controller.SoilworksControllerPluginHost`

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

### `TransportationProblem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.TransportationProblem` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double[] a, Double[] b, Double[] c, Double[] d)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SolveTransportation` | `Double[]` | `Boolean usePerturbations` | `` |
| `SolveTransportationSimplex` | `Boolean` | `String progressCaption, ref Double[] result` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Log` | `List<String>` | No | `` | `` |
| `MinCompactionCoefficient` | `Double` | Yes | `1` | `` |
| `Z` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Soilworks.Controller.Controls`

### `BreakOnSectorsControl` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Controls.BreakOnSectorsControl` |
| **Base Type** | `System.Windows.Forms.UserControl` |
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
              - `Topomatic.Soilworks.Controller.Controls.BreakOnSectorsControl`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStation` | `Double` | `set` | No | `Browsable` |
| `SectorsLengths` | `Double[]` | `get` | No | `Browsable` |
| `SectorsStations` | `Double[]` | `get/set` | No | `Browsable` |
| `StartStation` | `Double` | `set` | No | `Browsable` |
| `Stationing` | `StaticStationing` | `get` | No | `Browsable` |
| `TableMode` | `Boolean` | `get/set` | No | `Browsable` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `MakeWholeStations` | `Boolean` | `StaticStationing stationing, Double startStation, Double endStation, Double step, List<Double> stations, Boolean canTerminate, Boolean wholePickets` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConnectionPointEditControl` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControl` |
| **Base Type** | `System.Windows.Forms.UserControl` |
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
              - `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControl`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ConnectionPoint connectionPoint)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionPoint` | `ConnectionPoint` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyChanges` | `Boolean` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConnectionPointEditControlArea` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControlArea` |
| **Base Type** | `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControl` |
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
              - `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControl`
                - `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControlArea`

#### Constructors (1)

- `.ctor(PointConnectionPoint areaConnectionPoint)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConnectionPointEditControlLinear` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControlLinear` |
| **Base Type** | `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControl` |
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
              - `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControl`
                - `Topomatic.Soilworks.Controller.Controls.ConnectionPointEditControlLinear`

#### Constructors (1)

- `.ctor(LinearConnectionPoint linearConnectionPoint)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyChanges` | `Boolean` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Soilworks.Controller.CreationWizard`

### `GroundToMaterialLinkWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.CreationWizard.GroundToMaterialLinkWizardFrame` |
| **Base Type** | `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame` |
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
              - `Topomatic.Controls.Dialogs.WizardFrame`
                - `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame`
                  - `Topomatic.Soilworks.Controller.CreationWizard.GroundToMaterialLinkWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `State` | `WizardState` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LinearObjectWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame` |
| **Base Type** | `Topomatic.Controls.Dialogs.WizardFrame` |
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
              - `Topomatic.Controls.Dialogs.WizardFrame`
                - `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `State` | `WizardState` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectModelWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.CreationWizard.SelectModelWizardFrame` |
| **Base Type** | `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame` |
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
              - `Topomatic.Controls.Dialogs.WizardFrame`
                - `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame`
                  - `Topomatic.Soilworks.Controller.CreationWizard.SelectModelWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ModelName` | `String` | `get` | No | `` |
| `State` | `WizardState` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StationingWizardFarme` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.CreationWizard.StationingWizardFarme` |
| **Base Type** | `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame` |
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
              - `Topomatic.Controls.Dialogs.WizardFrame`
                - `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame`
                  - `Topomatic.Soilworks.Controller.CreationWizard.StationingWizardFarme`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `State` | `WizardState` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AnalyzeCrossSections` | `Boolean` | `` | `` |
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TemplateItemWizardFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.CreationWizard.TemplateItemWizardFrame` |
| **Base Type** | `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame` |
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
              - `Topomatic.Controls.Dialogs.WizardFrame`
                - `Topomatic.Soilworks.Controller.CreationWizard.LinearObjectWizardFrame`
                  - `Topomatic.Soilworks.Controller.CreationWizard.TemplateItemWizardFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `State` | `WizardState` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Void` | `Object arg` | `` |
| `OnInitialize` | `Boolean` | `Object arg` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Soilworks.Controller.Design`

### `AutoDistributionModeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Design.AutoDistributionModeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Soilworks.Controller.Design.AutoDistributionModeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GroundCompactionTypesEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Design.GroundCompactionTypesEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Soilworks.Controller.Design.GroundCompactionTypesEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `HaulageGenerateModeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Design.HaulageGenerateModeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Soilworks.Controller.Design.HaulageGenerateModeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `MaterialCompactionCoefficientEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Design.MaterialCompactionCoefficientEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Soilworks.Controller.Design.MaterialCompactionCoefficientEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `MaterialPriorityEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Design.MaterialPriorityEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Soilworks.Controller.Design.MaterialPriorityEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ParallelSectorTemplateEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Design.ParallelSectorTemplateEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Soilworks.Controller.Design.ParallelSectorTemplateEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Soilworks.Controller.Dialogs`

### `BreakOnSectorsDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.BreakOnSectorsDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.BreakOnSectorsDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sectors` | `Double[]` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `StaticStationing stationing, Double startStation, Double endStation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConnectionEditDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.ConnectionEditDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.ConnectionEditDlg`

#### Constructors (2)

- `.ctor(ConnectionLink connectionLink)`
- `.ctor(SoilworksObject soilworksObject1, SoilworksObject soilworksObject2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SoilworksConnectionPoint1` | `ConnectionPoint` | `get` | No | `` |
| `SoilworksConnectionPoint2` | `ConnectionPoint` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LinearSectorDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.LinearSectorDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.LinearSectorDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LinearSector` | `LinearSector` | `get/set` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `Soilworks soilworks` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ParallelSectorDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.ParallelSectorDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.ParallelSectorDlg`

#### Constructors (1)

- `.ctor(LinearSoilworksObject linearSoilworksObject)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParallelSector` | `ParallelSector` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ParticipantsEditTableDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.ParticipantsEditTableDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.ParticipantsEditTableDlg`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `ITemplateItemsContainer templateItemsContainer` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectApplicabilitiesDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.SelectApplicabilitiesDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.SelectApplicabilitiesDlg`

#### Constructors (1)

- `.ctor(Applicability[] applicabilities, Applicability[] selectedApplicabilities)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectedApplicabilities` | `Applicability[]` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectCompactionCoefficientDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.SelectCompactionCoefficientDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.SelectCompactionCoefficientDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SoilworksPropertiesDialog` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.SoilworksPropertiesDialog` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.SoilworksPropertiesDialog`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlignmentName` | `String` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `ref String name` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TransferEditDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Dialogs.TransferEditDlg` |
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
                - `Topomatic.Soilworks.Controller.Dialogs.TransferEditDlg`

#### Constructors (2)

- `.ctor(Haulage haulage)`
- `.ctor(IMassContainer[] suppliers, IMassContainer[] recipients)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Distance` | `Double` | `get` | No | `` |
| `SelectedHaulageGenerateMode` | `HaulagesGenerateMode` | `get` | No | `` |
| `SelectedHaulageType` | `HaulageType` | `get` | No | `` |
| `SelectedMaterial` | `Material` | `get` | No | `` |
| `Volume` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateHaulages` | `Void` | `` | `` |
| `GetTotalCompaction` | `Double` | `IMassContainer supplier, IMassContainer recipient` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Soilworks.Controller.Settings`

### `CompactionCoefficients` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Settings.CompactionCoefficients` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RequiredCoeff` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Double` | `GroundCompactionType groundCompactionType` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetValue` | `Void` | `GroundCompactionType groundCompactionType, Double value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GroundCompactionType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Settings.GroundCompactionType` |
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
      - `Topomatic.Soilworks.Controller.Settings.GroundCompactionType`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Clays` | `GroundCompactionType` | Yes | `Clays` | `` |
| `Loesses` | `GroundCompactionType` | Yes | `Loesses` | `` |
| `RockSoils0` | `GroundCompactionType` | Yes | `RockSoils0` | `` |
| `RockSoils1` | `GroundCompactionType` | Yes | `RockSoils1` | `` |
| `RockSoils2` | `GroundCompactionType` | Yes | `RockSoils2` | `` |
| `Sands` | `GroundCompactionType` | Yes | `Sands` | `` |
| `Slags` | `GroundCompactionType` | Yes | `Slags` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Sands` | `0` |
| `Clays` | `1` |
| `Loesses` | `2` |
| `RockSoils0` | `3` |
| `RockSoils1` | `4` |
| `RockSoils2` | `5` |
| `Slags` | `6` |

**Underlying Type**: `System.Int32`

### `SoilworksCompactionCoefficientsSettingsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Settings.SoilworksCompactionCoefficientsSettingsFrame` |
| **Base Type** | `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel` |
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
              - `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel`
                - `Topomatic.Soilworks.Controller.Settings.SoilworksCompactionCoefficientsSettingsFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SoilworksGlobalSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Settings.SoilworksGlobalSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CompactionsCoefficients` | `CompactionCoefficients[]` | `get` | No | `` |
| `Instance` | `SoilworksGlobalSettings` | `get` | Yes | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDefaultCompactionsCoefficients` | `Void` | `` | `` |
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

---
## Namespace: `Topomatic.Soilworks.Controller.Sheets`

### `SelectObjectsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Sheets.SelectObjectsFrame` |
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
                - `Topomatic.Soilworks.Controller.Sheets.SelectObjectsFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Boolean` | `UserSheet sheet` | `` |
| `OnInitialize` | `Void` | `UserSheet sheet` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Soilworks.Controller.Utils`

### `LinearSectorsBreaker` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Utils.LinearSectorsBreaker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Break` | `Void` | `LinearSector linearSector, Double[] stations, Boolean refresh, Dictionary<Int32 List<LinearSector>> ranges` | `` |

### `LinearSectorsMerger` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Utils.LinearSectorsMerger` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Merge` | `Void` | `LinearSector[] linearSectors, Boolean equalName, Boolean equalDescription, Boolean equalMaterial` | `` |

### `LinearSectorsRebuilder` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Utils.LinearSectorsRebuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Rebuild` | `Boolean` | `LinearSoilworksObject linearSoilworksObject, Double[] stations, Boolean equalName, Boolean equalDescription, Boolean equalMaterials` | `` |

### `LinearSectorsUpdater` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Utils.LinearSectorsUpdater` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Update` | `Void` | `LinearSoilworksObject linearSoilworksObject, LinearSector[] linearSectors` | `` |

### `Range` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Utils.Range` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(LinearSoilworksObject linearSoilworksObject, Double startStation, Double endStation)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStation` | `Double` | `get` | No | `` |
| `Km` | `Int32` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddCutVolume` | `Void` | `String name, String cipher, Double value` | `` |
| `AddEmbankmentVolume` | `Void` | `String name, Double value` | `` |
| `AddHaulageTypeVolume` | `Void` | `HaulageType haulageType, String cipher, Double value` | `` |
| `AddHauledInVolume` | `Void` | `String name, String cipher, Double value` | `` |
| `TryGetCutsSumm` | `Boolean` | `ref Double value` | `` |
| `TryGetCutVolume` | `Boolean` | `String cutName, String cipher, ref Double value` | `` |
| `TryGetEmbankmentsSumm` | `Boolean` | `ref Double value` | `` |
| `TryGetEmbankmentVolume` | `Boolean` | `String name, ref Double value` | `` |
| `TryGetHaulageTypeVolume` | `Boolean` | `HaulageType haulageType, String cipher, ref Double value` | `` |
| `TryGetHauledInVolume` | `Boolean` | `String cutName, String cipher, ref Double value` | `` |
| `TryGetHauledSumm` | `Boolean` | `ref Double value` | `` |

### `RangeBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Utils.RangeBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(LinearSoilworksObject linearSoilworksObject)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Generate` | `Range[]` | `` | `` |
| `GetHaulageTypes` | `HaulageType[]` | `` | `` |
| `GetMaterialsListForHaulageType` | `String[]` | `HaulageType haulageType` | `` |
| `GetMaterialsListForSupplier` | `String[]` | `String supplierName` | `` |
| `GetRecipientsList` | `String[]` | `` | `` |
| `GetSuppliersList` | `String[]` | `` | `` |

---
## Namespace: `Topomatic.Soilworks.Controller.Wrappers`

### `IMaterialsContainerContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Wrappers.IMaterialsContainerContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MaterialsContainer` | `IMaterialsContainer` | `get` | No | `` |

### `ItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Wrappers.MaterialsWrapper+ItemWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Soilworks.ISoilworksContainer, Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Material material)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicabilityStateWrappers` | `ApplicabilityStateWrapper[]` | `get/set` | No | `PropertyEditor, DefaultWidth, PropertyTypeConverter` |
| `CompactionCoeff` | `Double` | `get/set` | No | `PropertyEditor, DefaultDouble` |
| `LineColor` | `CadColor` | `get/set` | No | `DefaultWidth, ByLayer, ByBlock` |
| `Material` | `Material` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |
| `Priority` | `Int32` | `get/set` | No | `PropertyEditor` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISoilworksContainer` | `get_Soilworks` |
| `IApplicabilitiyStateWrapperContainer` | `get_ApplicabilityStateWrappers` |
| `IApplicabilitiyStateWrapperContainer` | `set_ApplicabilityStateWrappers` |

### `MaterialsValuesWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Wrappers.MaterialsValuesWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Soilworks.Controller.Wrappers.MaterialsValuesWrapper`

#### Constructors (1)

- `.ctor(List<KeyValuePair<Material Double>> materialsValues, Soilworks soilworks)`

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

### `MaterialsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Wrappers.MaterialsWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Soilworks.Controller.Wrappers.MaterialsWrapper`

#### Constructors (1)

- `.ctor(Soilworks soilworks)`

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

#### Nested Types (1)

- `ItemWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `StationingSectorWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Wrappers.StationingSectorWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Soilworks.Controller.Wrappers.StationingSectorWrapper`

#### Constructors (1)

- `.ctor(StaticStationing stationing, IKilometers kilometers, List<Double> sectorsStarts)`

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 54 |
| **Classes** | 45 |
| **Interfaces** | 1 |
| **Enums** | 3 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 5 |
| **Total Methods** | 99 |
| **Total Properties** | 78 |
| **Total Fields** | 28 |
| **Total Events** | 0 |
| **Total Constructors** | 48 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


