# Topomatic.Alg.Road.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.Runtime.dll` |

---
## Namespace: `Topomatic.Alg.Road.Runtime`

### `AliasTemplateBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.AliasTemplateBuilder` |
| **Base Type** | `Topomatic.Alg.Road.Runtime.RoadTemplateBuilder` |
| **Implements** | `Topomatic.Crs.ICrsBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsTemplateBuilder`
    - `Topomatic.Crs.Runtime.CrsTemplatePythonBuilder`
      - `Topomatic.Alg.Runtime.TemplateBuilder`
        - `Topomatic.Alg.Road.Runtime.RoadTemplateBuilder`
          - `Topomatic.Alg.Road.Runtime.AliasTemplateBuilder`

#### Constructors (1)

- `.ctor(RoadAlignment alignment, List<KeyValuePair<String Object>> aliaces)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ApplyTo` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.ApplyTo` |
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
      - `Topomatic.Alg.Road.Runtime.ApplyTo`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cut` | `ApplyTo` | Yes | `Cut` | `` |
| `Ditch` | `ApplyTo` | Yes | `Ditch` | `` |
| `Fill` | `ApplyTo` | Yes | `Fill` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Fill` | `0` |
| `Cut` | `1` |
| `Ditch` | `2` |

**Underlying Type**: `System.Int32`

### `RoadCrsSectionsOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.RoadCrsSectionsOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, Alignment alignment` | `` |
| `SaveToStream` | `Void` | `Stream stream, Alignment alignment` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `OLD_REC_SIZE` | `Int32` | Yes | `248` | `` |
| `REC_SIZE` | `Int32` | Yes | `408` | `` |

### `RoadOldBinarySerializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.RoadOldBinarySerializer` |
| **Base Type** | `Topomatic.Alg.Runtime.AlgOldBinarySerializer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.AlgOldBinarySerializer`
    - `Topomatic.Alg.Road.Runtime.RoadOldBinarySerializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, Alignment alg` | `` |
| `SaveToStream` | `Void` | `Stream stream, Alignment alg, ProgramType type, Int32 version` | `` |

### `RoadProjectProfileOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.RoadProjectProfileOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, ProjectProfile profile` | `` |
| `SaveToStream` | `Void` | `Stream stream, ProjectProfile profile` | `` |
| `SaveToStreamOld` | `Void` | `Stream stream, ProjectProfile profile` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `OLD_RECORD_SIZE` | `Int32` | Yes | `24` | `` |
| `RECORD_SIZE` | `Int32` | Yes | `36` | `` |

### `RoadTemplateBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.RoadTemplateBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.TemplateBuilder` |
| **Implements** | `Topomatic.Crs.ICrsBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsTemplateBuilder`
    - `Topomatic.Crs.Runtime.CrsTemplatePythonBuilder`
      - `Topomatic.Alg.Runtime.TemplateBuilder`
        - `Topomatic.Alg.Road.Runtime.RoadTemplateBuilder`

#### Constructors (1)

- `.ctor(RoadAlignment alignment)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadUrbParamsSerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.RoadUrbParamsSerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, RoadAlignment alignment` | `` |
| `SaveToStream` | `Void` | `Stream stream, RoadAlignment alignment, List<KeyValuePair<Double String>> templates` | `` |

#### Fields (15)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `POSARRAY_SIGNATURE` | `Int32` | Yes | `16` | `` |
| `URB_GROUPS` | `Int32` | Yes | `68` | `` |
| `URB_MASTER_DATA_CONSTRUCTION` | `Int32` | Yes | `96` | `` |
| `URB_MASTER_DATA_TYPES` | `Int32` | Yes | `208` | `` |
| `URB_MASTER_DATA_UKLON_MAIN` | `Int32` | Yes | `88` | `` |
| `URB_MASTER_DATA_UKLON_RAZD` | `Int32` | Yes | `24` | `` |
| `URB_MASTER_DATA_UKLON_SIDES` | `Int32` | Yes | `24` | `` |
| `URB_MASTER_DATA_VARIABLES` | `Int32` | Yes | `20` | `` |
| `URB_MASTER_DATA_WIDTH_ADD` | `Int32` | Yes | `44` | `` |
| `URB_MASTER_DATA_WIDTH_MAIN` | `Int32` | Yes | `88` | `` |
| `URB_MASTER_DATA_WIDTH_RAZD` | `Int32` | Yes | `40` | `` |
| `URB_MASTER_DATA_WIDTH_SIDES` | `Int32` | Yes | `56` | `` |
| `URB_SIGNATURE` | `Int32` | Yes | `1431454291` | `` |
| `URB_VERSION` | `Int32` | Yes | `1` | `` |
| `VIRAGE_OTGON` | `Int32` | Yes | `64` | `` |

### `RoadUrbTemplateSerializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.RoadUrbTemplateSerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, RoadAlignment alignment` | `` |
| `PrepareDefaultConstructionAliaces` | `Void` | `Dictionary<String String> aliases` | `` |
| `SaveToStream` | `Void` | `Stream stream, RoadAlignment alignment, List<KeyValuePair<Double String>> templates` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TPL` | `Int32` | Yes | `146` | `` |

### `SlopeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.SlopeType` |
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
      - `Topomatic.Alg.Road.Runtime.SlopeType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Auto` | `SlopeType` | Yes | `Auto` | `` |
| `Cut` | `SlopeType` | Yes | `Cut` | `` |
| `Ditch` | `SlopeType` | Yes | `Ditch` | `` |
| `Fill` | `SlopeType` | Yes | `Fill` | `` |
| `None` | `SlopeType` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Auto` | `0` |
| `Fill` | `1` |
| `Cut` | `2` |
| `Ditch` | `3` |
| `None` | `4` |

**Underlying Type**: `System.Int32`

### `StandardRule` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.StandardRule` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Runtime.StandardRule`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ApplyTo` | `ApplyTo` | No | `` | `` |
| `MaxValue` | `Double` | No | `` | `` |
| `MinValue` | `Double` | No | `` | `` |
| `StandardId` | `Int32` | No | `` | `` |

### `StandardRulesList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.StandardRulesList` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Alg.Road.Runtime.StandardRule, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Runtime.StandardRule, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Runtime.StandardRule, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Runtime.StandardRule, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Road.Runtime.StandardRule, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Road.Runtime.StandardRule, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Road.Runtime.StandardRule, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Road.Runtime.StandardRulesList`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

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

---
## Namespace: `Topomatic.Alg.Road.Runtime.Design`

### `RoadCategoryEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Design.RoadCategoryEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Runtime.Design.RoadCategoryEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SlopeTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Design.SlopeTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Runtime.Design.SlopeTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Alg.Road.Runtime.Dialogs`

### `AddRuleDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Dialogs.AddRuleDlg` |
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
                - `Topomatic.Alg.Road.Runtime.Dialogs.AddRuleDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `StandardSlopesLibrary library, ref String name, ref String description, List<StandardRule> rules` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectStandardSlopeDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Dialogs.SelectStandardSlopeDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
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
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Road.Runtime.Dialogs.SelectStandardSlopeDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `StandardSlopesLibrary library, ref StandardSlope slope` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Road.Runtime.Settings`

### `RulesSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Settings.RulesSettings` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Alg.Road.Runtime.StandardRulesList, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Runtime.StandardRulesList, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Runtime.StandardRulesList, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Runtime.StandardRulesList, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Road.Runtime.StandardRulesList, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Road.Runtime.StandardRulesList, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Road.Runtime.StandardRulesList, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Road.Runtime.Settings.RulesSettings`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `UID` | `String` | Yes | `"RoadRulesSettings"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Road.Runtime.Standards`

### `StandardBusStop` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Standards.StandardBusStop` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Runtime.Standards.StandardBusStop`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `StandardBusStop` | `StgNode stgNode` | `` |

#### Fields (28)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DividerBackwardLength` | `Double` | No | `` | `` |
| `DividerBackwardOtgon` | `Double` | No | `` | `` |
| `DividerForwardLength` | `Double` | No | `` | `` |
| `DividerForwardOtgon` | `Double` | No | `` | `` |
| `DividerWidth` | `Double` | No | `` | `` |
| `GrassBackwardWidth` | `Double` | No | `` | `` |
| `GrassForwardWidth` | `Double` | No | `` | `` |
| `LandingPlaceBackwardLength` | `Double` | No | `` | `` |
| `LandingPlaceForwardLength` | `Double` | No | `` | `` |
| `LandingPlaceWidth` | `Double` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `PocketBackwardLength` | `Double` | No | `` | `` |
| `PocketForwardLength` | `Double` | No | `` | `` |
| `PocketWidth` | `Double` | No | `` | `` |
| `PspBackwardLength` | `Double` | No | `` | `` |
| `PspBackwardOtgon` | `Double` | No | `` | `` |
| `PspForwardLength` | `Double` | No | `` | `` |
| `PspForwardOtgon` | `Double` | No | `` | `` |
| `PspWidth` | `Double` | No | `` | `` |
| `SideBackwardWidth` | `Double` | No | `` | `` |
| `SideForwardWidth` | `Double` | No | `` | `` |
| `SideWalkBackwardLength` | `Double` | No | `` | `` |
| `SideWalkBackwardWidth` | `Double` | No | `` | `` |
| `SideWalkForwardLength` | `Double` | No | `` | `` |
| `SideWalkForwardWidth` | `Double` | No | `` | `` |
| `WaitingAreaBackwardLength` | `Double` | No | `` | `` |
| `WaitingAreaForwardLength` | `Double` | No | `` | `` |
| `WaitingAreaWidth` | `Double` | No | `` | `` |

### `StandardBusStopsLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Standards.StandardBusStopsLibrary` |
| **Base Type** | `Topomatic.Alg.Runtime.Standards.StandardLibrary`1[[Topomatic.Alg.Road.Runtime.Standards.StandardBusStop, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Runtime.Standards.StandardBusStop, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Runtime.Standards.StandardBusStop, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Runtime.Standards.StandardBusStop, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Standards.StandardLibrary`
    - `Topomatic.Alg.Runtime.Standards.StandardLibrary`1[[Topomatic.Alg.Road.Runtime.Standards.StandardBusStop, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Alg.Road.Runtime.Standards.StandardBusStopsLibrary`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BusStopsLibraryId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StandardReversalArea` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Standards.StandardReversalArea` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Runtime.Standards.StandardReversalArea`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `StandardReversalArea` | `StgNode node` | `` |

#### Fields (26)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AxisOffset` | `Double` | No | `` | `` |
| `LeftAfterPspLength` | `Double` | No | `` | `` |
| `LeftAfterPspOtgon` | `Double` | No | `` | `` |
| `LeftAfterRadius` | `Double` | No | `` | `` |
| `LeftBeforePspLength` | `Double` | No | `` | `` |
| `LeftBeforePspOtgon` | `Double` | No | `` | `` |
| `LeftBeforeRadius` | `Double` | No | `` | `` |
| `LeftCenterRadius` | `Double` | No | `` | `` |
| `LeftPspDividerLength` | `Double` | No | `` | `` |
| `LeftPspDividerOtgon` | `Double` | No | `` | `` |
| `MiddleWidth` | `Double` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `PspDividerWidth` | `Double` | No | `` | `` |
| `PspWidth` | `Double` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |
| `RadiusWidth` | `Double` | No | `` | `` |
| `ReversalAreaType` | `ReversalAreaType` | No | `` | `` |
| `RightAfterPspLength` | `Double` | No | `` | `` |
| `RightAfterPspOtgon` | `Double` | No | `` | `` |
| `RightAfterRadius` | `Double` | No | `` | `` |
| `RightBeforePspLength` | `Double` | No | `` | `` |
| `RightBeforePspOtgon` | `Double` | No | `` | `` |
| `RightBeforeRadius` | `Double` | No | `` | `` |
| `RightCenterRadius` | `Double` | No | `` | `` |
| `RightPspDividerLength` | `Double` | No | `` | `` |
| `RightPspDividerOtgon` | `Double` | No | `` | `` |

### `StandardReversalAreaLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Standards.StandardReversalAreaLibrary` |
| **Base Type** | `Topomatic.Alg.Runtime.Standards.StandardLibrary`1[[Topomatic.Alg.Road.Runtime.Standards.StandardReversalArea, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Runtime.Standards.StandardReversalArea, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Runtime.Standards.StandardReversalArea, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Runtime.Standards.StandardReversalArea, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Standards.StandardLibrary`
    - `Topomatic.Alg.Runtime.Standards.StandardLibrary`1[[Topomatic.Alg.Road.Runtime.Standards.StandardReversalArea, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Alg.Road.Runtime.Standards.StandardReversalAreaLibrary`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ReversalAreaLibraryId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StandardSlope` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Standards.StandardSlope` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Runtime.Standards.StandardSlope`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode stgNode, StandardSlope defaultValue` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `StandardSlope` | `StgNode stgNode, StandardSlope defaultValue` | `` |
| `LoadFromStg` | `StandardSlope` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StandardSlope slope, StgNode stgNode, StandardSlope defaultValue` | `` |
| `SaveToStg` | `Void` | `StandardSlope slope, StgNode stgNode` | `` |

#### Fields (21)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A1` | `Double` | No | `` | `` |
| `A2` | `Double` | No | `` | `` |
| `A3` | `Double` | No | `` | `` |
| `B` | `Double` | No | `` | `` |
| `Category` | `StandardSlopeCategory` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `Ga` | `Double` | No | `` | `` |
| `Gk` | `Double` | No | `` | `` |
| `Gw` | `Double` | No | `` | `` |
| `H1` | `Double` | No | `` | `` |
| `H2` | `Double` | No | `` | `` |
| `H3` | `Double` | No | `` | `` |
| `Hk` | `Double` | No | `` | `` |
| `M1` | `Double` | No | `` | `` |
| `M2` | `Double` | No | `` | `` |
| `M3` | `Double` | No | `` | `` |
| `M4` | `Double` | No | `` | `` |
| `N1` | `Double` | No | `` | `` |
| `N2` | `Double` | No | `` | `` |
| `TypeIndex` | `Int32` | No | `` | `` |
| `W` | `Double` | No | `` | `` |

### `StandardSlopeCategory` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Standards.StandardSlopeCategory` |
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
      - `Topomatic.Alg.Road.Runtime.Standards.StandardSlopeCategory`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BigCut` | `StandardSlopeCategory` | Yes | `BigCut` | `` |
| `BigFill` | `StandardSlopeCategory` | Yes | `BigFill` | `` |
| `Ditch` | `StandardSlopeCategory` | Yes | `Ditch` | `` |
| `SmallCut` | `StandardSlopeCategory` | Yes | `SmallCut` | `` |
| `SmallFill` | `StandardSlopeCategory` | Yes | `SmallFill` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SmallFill` | `0` |
| `BigFill` | `1` |
| `SmallCut` | `2` |
| `BigCut` | `3` |
| `Ditch` | `4` |

**Underlying Type**: `System.Int32`

### `StandardSlopesLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Standards.StandardSlopesLibrary` |
| **Base Type** | `Topomatic.Alg.Runtime.Standards.StandardLibrary`1[[Topomatic.Alg.Road.Runtime.Standards.StandardSlope, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Runtime.Standards.StandardSlope, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Runtime.Standards.StandardSlope, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Runtime.Standards.StandardSlope, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Standards.StandardLibrary`
    - `Topomatic.Alg.Runtime.Standards.StandardLibrary`1[[Topomatic.Alg.Road.Runtime.Standards.StandardSlope, Topomatic.Alg.Road.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Alg.Road.Runtime.Standards.StandardSlopesLibrary`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SlopesLibraryId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Road.Runtime.Tools`

### `CrsGradeSolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.CrsGradeSolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `RoadAlignment` | `get/set` | No | `` |
| `MaxGrade` | `Double` | `get/set` | No | `` |
| `MaxOffset` | `Double` | `get/set` | No | `` |
| `UseKosogornost` | `Boolean` | `get/set` | No | `` |
| `UseReconstruct` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `CrsDesignContext dc, Double station, ref CrsGradeSolverResult rslt` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcCrsGrade` | `Boolean` | `RoadAlignment alignment, Double maxOffset, Double maxGrade, Boolean useReconstruct, Boolean useKosogornost, CrsDesignContext dc, Double station, ref CrsGradeSolverResult rslt` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cLeftSide` | `Int32` | No | `` | `` |
| `cRightSide` | `Int32` | No | `` | `` |
| `CRS_GRADE_SOLVER_FLAGS_EMPTY` | `Int32` | Yes | `0` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_H_DITCH` | `Int32` | Yes | `4` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_H_EDGE` | `Int32` | Yes | `1` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_H_FOOT` | `Int32` | Yes | `2` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_H_M_NGREATER` | `Int32` | Yes | `10` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_H_M_NLESS` | `Int32` | Yes | `8` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_HN` | `Int32` | Yes | `40` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_M` | `Int32` | Yes | `20` | `` |
| `CRS_GRADE_SOLVER_FLAGS_HAS_N` | `Int32` | Yes | `80` | `` |
| `CRS_GRADE_SOLVER_FLAGS_IS_VERTICAL_WALL` | `Int32` | Yes | `100` | `` |

### `CrsGradeSolverResult` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.CrsGradeSolverResult` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftSide` | `CrsGradeSolverResultRec` | `get/set` | No | `` |
| `RightSide` | `CrsGradeSolverResultRec` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

### `CrsGradeSolverResultRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.CrsGradeSolverResultRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Runtime.Tools.CrsGradeSolverResultRec`

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Flags` | `Int32` | No | `` | `` |
| `Hbr` | `Double` | No | `` | `` |
| `Hditch` | `Double` | No | `` | `` |
| `Hm` | `Double` | No | `` | `` |
| `Hn` | `Double` | No | `` | `` |
| `Hpod` | `Double` | No | `` | `` |
| `M` | `Double` | No | `` | `` |
| `N` | `Double` | No | `` | `` |
| `Xbr` | `Double` | No | `` | `` |
| `Xditch` | `Double` | No | `` | `` |
| `Xm` | `Double` | No | `` | `` |
| `Xpod` | `Double` | No | `` | `` |

### `DescentControlPointSelector` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+DescentControlPointSelector` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+DescentControlPointSelector`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AlwaysFirst` | `DescentControlPointSelector` | Yes | `AlwaysFirst` | `` |
| `AlwaysLast` | `DescentControlPointSelector` | Yes | `AlwaysLast` | `` |
| `Auto` | `DescentControlPointSelector` | Yes | `Auto` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Auto` | `0` |
| `AlwaysFirst` | `1` |
| `AlwaysLast` | `2` |

**Underlying Type**: `System.Int32`

### `DescentMatingAssistant` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.DescentMatingAssistant` |
| **Base Type** | `Topomatic.Alg.Road.Runtime.Tools.MatingAssistant` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Road.Runtime.Tools.MatingAssistant`
    - `Topomatic.Alg.Road.Runtime.Tools.DescentMatingAssistant`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `PlanLine descent, CompoundLine mainLine, CompoundLine secondLine, Vector2D crossPosition, Vector2D mainPosition, Vector2D secondPosition, Double radius, Double l1, Double l2, Boolean useTruncatedCloth` | `` |

### `DisplayRenewElevation` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadDynamicSurfaceBuilder+DisplayRenewElevation` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Runtime.Tools.RoadDynamicSurfaceBuilder+DisplayRenewElevation`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `InCentimetres` | `DisplayRenewElevation` | Yes | `InCentimetres` | `` |
| `InMetres` | `DisplayRenewElevation` | Yes | `InMetres` | `` |
| `InTruncatedCentimetres` | `DisplayRenewElevation` | Yes | `InTruncatedCentimetres` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `InMetres` | `0` |
| `InCentimetres` | `1` |
| `InTruncatedCentimetres` | `2` |

**Underlying Type**: `System.Int32`

### `DropShapedIslandMating` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.DropShapedIslandMating` |
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
| `ExecuteMajor` | `Boolean` | `Alignment alignment, ILinearObject secondLine, Vector2D secondPosition, Vector2D islandPosition, Double radius, Double width, ref IslandDirection direction, ref Double station` | `` |
| `ExecuteMinor` | `Boolean` | `Alignment alignment, ILinearObject mainLine, ILinearObject secondLine, Vector2D mainPosition, Vector2D secondPosition, Vector2D islandPosition, Double mainRadius, Double secondRadius, Double width, ref IslandDirection direction, ref DropShapedIslandRadiusPosition radiusPosition, ref Double lineLength, ref Double station` | `` |
| `PrepareCompoundLineAndContolPos` | `Boolean` | `ILinearObject line, Vector2D prefferedPos, ref CompoundLine compoundLine, ref Vector2D controlPos` | `` |
| `PrepareOffset` | `CompoundLine` | `Alignment alignment, Double offset` | `` |

#### Nested Types (1)

- `DropShapedIslandMatingAssistant` (class)

### `DropShapedIslandMatingAssistant` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.DropShapedIslandMating+DropShapedIslandMatingAssistant` |
| **Base Type** | `Topomatic.Alg.Road.Runtime.Tools.MatingAssistant` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Road.Runtime.Tools.MatingAssistant`
    - `Topomatic.Alg.Road.Runtime.Tools.DropShapedIslandMating+DropShapedIslandMatingAssistant`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `CompoundLine mainLine, CompoundLine secondLine, Vector2D mainPosition, Vector2D secondPosition, Double radius, ref Vector2D pos` | `` |

### `LightweightCompoundLineMaker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.LightweightCompoundLineMaker` |
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
| `MakeCompoundLineFromPathItems` | `Boolean` | `IList<IPathItem> pathList, CompoundLine line` | `` |

### `MakeDitchType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.MakeDitchType` |
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
      - `Topomatic.Alg.Road.Runtime.Tools.MakeDitchType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BottomElevation` | `MakeDitchType` | Yes | `BottomElevation` | `` |
| `FromAnchorPoint` | `MakeDitchType` | Yes | `FromAnchorPoint` | `` |
| `FromEdge` | `MakeDitchType` | Yes | `FromEdge` | `` |
| `FromProfile` | `MakeDitchType` | Yes | `FromProfile` | `` |
| `FromSand` | `MakeDitchType` | Yes | `FromSand` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FromEdge` | `0` |
| `FromSand` | `1` |
| `BottomElevation` | `2` |
| `FromAnchorPoint` | `3` |
| `FromProfile` | `4` |

**Underlying Type**: `System.Int32`

### `MatingAssistant` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.MatingAssistant` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossPosition` | `Vector2D` | `get/set` | No | `` |
| `MainLine` | `CompoundLine` | `get/set` | No | `` |
| `MainLinePosition` | `Vector2D` | `get/set` | No | `` |
| `SecondLine` | `CompoundLine` | `get/set` | No | `` |
| `SecondLinePosition` | `Vector2D` | `get/set` | No | `` |

### `MergeSolverTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.MergeSolverTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyTemplates` | `Void` | `ConstructionTemplates source, ConstructionTemplates destination, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `CopyUrb` | `Void` | `UrbParams source, UrbParams desitnation, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `EqualsTemplates` | `Boolean` | `ConstructionTemplates source, ConstructionTemplates destination, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `EqualsUrb` | `Boolean` | `UrbParams source, UrbParams desitnation, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |

### `RenewProfileMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+RenewProfileMode` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+RenewProfileMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Max` | `RenewProfileMode` | Yes | `Max` | `` |
| `Min` | `RenewProfileMode` | Yes | `Min` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Min` | `0` |
| `Max` | `1` |

**Underlying Type**: `System.Int32`

### `RenewSurfaceBuildMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadDynamicSurfaceBuilder+RenewSurfaceBuildMode` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Runtime.Tools.RoadDynamicSurfaceBuilder+RenewSurfaceBuildMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dynamic` | `RenewSurfaceBuildMode` | Yes | `Dynamic` | `` |
| `OnlyMarked` | `RenewSurfaceBuildMode` | Yes | `OnlyMarked` | `` |
| `Standard` | `RenewSurfaceBuildMode` | Yes | `Standard` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Standard` | `0` |
| `OnlyMarked` | `1` |
| `Dynamic` | `2` |

**Underlying Type**: `System.Int32`

### `RoadDynamicSurfaceBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadDynamicSurfaceBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.Tools.DynamicSurfaceBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Tools.DynamicSurfaceBuilder`
    - `Topomatic.Alg.Road.Runtime.Tools.RoadDynamicSurfaceBuilder`

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildCrsSurface` | `Boolean` | `RoadAlignment alignment, Surface surface` | `` |
| `BuildRenewSurface` | `Boolean` | `RoadAlignment alignment, Surface surface, Drawing drawing, RenewSurfaceBuildMode mode, Double lstep, Double cstep, Boolean buildByStationing, Boolean useMiddleElevation, DisplayRenewElevation elevationInCm, Boolean onlyMarked` | `` |
| `BuildUrbSurface` | `Boolean` | `RoadAlignment alignment, Surface surface, Boolean dynamic, Double factor` | `` |

#### Nested Types (2)

- `DisplayRenewElevation` (enum)
- `RenewSurfaceBuildMode` (enum)

### `RoadLibrary` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (23)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyRules` | `Void` | `RoadAlignment alignment, Side side, Double startStation, Double endStation, Boolean reconstruct, Boolean useInterpolateGround, Boolean ditchProfileElevation, List<Rule> fillRules, List<Rule> cutRules` | `` |
| `BuildFgCrossSurface` | `Boolean` | `RoadAlignment alignment, Surface surface, Int32 code` | `` |
| `BuildFgTopSurface` | `Boolean` | `RoadAlignment alignment, Surface surface, Double lineStep, Double curveStep` | `` |
| `CalcDescentControlPoints` | `Int32` | `RoadAlignment generalAlignment, RoadAlignment descentAlignment, Double dividerWidth, DescentControlPointSelector selector, ref Vector3D cl, ref Vector3D inEdge, ref Vector3D outEdge` | `` |
| `FindSectPostion` | `Boolean` | `CompoundLine edgeLine, Vector2D pos1, Vector2D pos2, Double station, ref Vector2D pos` | `` |
| `FindSectPostion` | `Boolean` | `RoadAlignment descent, CompoundLine edgeLine, Double station, ref Vector2D pos` | `` |
| `GetLeftSlope` | `SlopePrms` | `Alignment alignment, Double station` | `` |
| `GetRightSlope` | `SlopePrms` | `Alignment alignment, Double station` | `` |
| `InitializeConstructionParameters` | `Void` | `AlignmentParameters parameters, IEnumerable<ActConstructionProperty> propertys, Action<ActConstructionProperty IParameterTable Int32> fillProperty` | `` |
| `InterpolateDitchOnDescent` | `Void` | `Alignment descent, Alignment majorRoad, Alignment minorRoad, Vector2D cross, Boolean majorFirst` | `` |
| `InterpolateSlopesOnDescent` | `Void` | `Alignment descent, Alignment majorRoad, Alignment minorRoad, Vector2D cross` | `` |
| `MakeDitch` | `Boolean` | `Corridor corridor, IParameter<Int32> slope_flags, IParameter<Double> hk, MakeDitchType ditchType, Int32 edgeCode, Int32 catchCode, Int32 sandCode, Int32 ditchStartCode, Int32 index, Double fromEdge, Double fromSand, Double fromAnchor, Double bottomElevation` | `` |
| `MakeProjectProfileByReferenceGrade` | `Void` | `IList<Double> stations, Double startStation, Double endStation, Transition currentTransition, Transition referenceTransition, Alignment currentAlignment, Alignment referenceAlignment, Double startGrade, Double endGrade` | `` |
| `MakeRenewProfile` | `Boolean` | `RoadAlignment alignment, Double startStation, Double endStation, RenewProfileMode mode, Double thickForce` | `` |
| `PrepareCompoundLine` | `CompoundLine` | `RoadAlignment alignment, Int32 category, Double startStation, Double endStation, Double offset` | `` |
| `PrepareCompoundLine` | `CompoundLine` | `CompoundLine mainLine, List<Vector2D> staOffsList` | `` |
| `PrepareTriangleIslandOffset` | `Boolean` | `RoadAlignment descent, CompoundLine edgeLine, Side side, Double station, Boolean use_last, ref Double island_width` | `` |
| `SegmentInsideLimitedChange` | `Boolean` | `Alignment alignment, ref Double from, ref Double to` | `` |
| `SetLeftSlope` | `Void` | `Alignment alignment, SlopePrms prms, Double station` | `` |
| `SetRightSlope` | `Void` | `Alignment alignment, SlopePrms prms, Double station` | `` |
| `TryGetDitchElevation` | `Boolean` | `CrsDesignContext dc, String slopeName, Int32 endCode, ref Double offset, ref Double bottom, ref Double red, ref Double eg` | `` |
| `TryGetDitchHeight` | `Boolean` | `CrsDesignContext dc, String slopeName, Int32 ditchCode, ref Double offset, ref Double height` | `` |
| `TrySectCompoundLine` | `Boolean` | `CompoundLine mainLine, CompoundLine sectLine, Vector2D intersectionPosition, Double distance, ref Vector2D sectPosition` | `` |

#### Nested Types (5)

- `DescentControlPointSelector` (enum)
- `RenewProfileMode` (enum)
- `Rule` (struct)
- `Side` (enum)
- `SlopePrms` (struct)

### `Rule` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+Rule` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+Rule`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ditch` | `Boolean` | No | `` | `` |
| `MaxValue` | `Double` | No | `` | `` |
| `MinValue` | `Double` | No | `` | `` |
| `StandardSlope` | `StandardSlope` | No | `` | `` |

### `Side` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+Side` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+Side`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `Side` | Yes | `Empty` | `` |
| `Left` | `Side` | Yes | `Left` | `` |
| `Right` | `Side` | Yes | `Right` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Left` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Byte`

### `SlopePrms` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+SlopePrms` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Runtime.Tools.RoadLibrary+SlopePrms`

#### Fields (22)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A1` | `Double` | No | `` | `` |
| `A2` | `Double` | No | `` | `` |
| `A3` | `Double` | No | `` | `` |
| `B` | `Double` | No | `` | `` |
| `Flags` | `Int32` | No | `` | `` |
| `Ga` | `Double` | No | `` | `` |
| `Gk` | `Double` | No | `` | `` |
| `Gw` | `Double` | No | `` | `` |
| `H1` | `Double` | No | `` | `` |
| `H2` | `Double` | No | `` | `` |
| `H3` | `Double` | No | `` | `` |
| `Hk` | `Double` | No | `` | `` |
| `IntersectionsCount` | `Int32` | No | `` | `` |
| `M1` | `Double` | No | `` | `` |
| `M2` | `Double` | No | `` | `` |
| `M3` | `Double` | No | `` | `` |
| `M4` | `Double` | No | `` | `` |
| `N1` | `Double` | No | `` | `` |
| `N2` | `Double` | No | `` | `` |
| `SlopeNumber` | `Int32` | No | `` | `` |
| `SlopeType` | `Int32` | No | `` | `` |
| `W` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Alg.Runtime.GeologyVolume`

### `GeologyVolumeCell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GeologyVolume.GeologyVolumeCell` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CutArea` | `Nullable<Double>` | `get/set` | No | `` |
| `LeftDitchArea` | `Nullable<Double>` | `get/set` | No | `` |
| `RightDitchArea` | `Nullable<Double>` | `get/set` | No | `` |

### `GeologyVolumeColumns` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GeologyVolume.GeologyVolumeColumns` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(IEnumerable<GroundReference> grounds)`
- `.ctor(Int32 colCount)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Ground` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindIndex` | `Int32` | `Ground ground` | `` |

### `GeologyVolumeData` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GeologyVolume.GeologyVolumeData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Columns` | `GeologyVolumeColumns` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `GeologyVolumeRow` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Generate` | `Boolean` | `Alignment alg, Double startSta, Double endSta` | `` |
| `Generate` | `Boolean` | `Alignment alg` | `` |

### `GeologyVolumeRow` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GeologyVolume.GeologyVolumeRow` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double sta, Int32 colCount, Boolean selected)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `GeologyVolumeCell` | `get/set` | No | `` |
| `Selected` | `Boolean` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 46 |
| **Classes** | 24 |
| **Interfaces** | 0 |
| **Enums** | 9 |
| **Structs** | 7 |
| **Abstract Classes** | 1 |
| **Static Classes** | 5 |
| **Total Methods** | 76 |
| **Total Properties** | 28 |
| **Total Fields** | 194 |
| **Total Events** | 0 |
| **Total Constructors** | 24 |
| **Nested Types** | 8 |
| **Extension Methods** | 0 |


