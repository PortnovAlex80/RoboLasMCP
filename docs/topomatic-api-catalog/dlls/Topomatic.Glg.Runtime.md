# Topomatic.Glg.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Glg.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Glg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Glg.Runtime.dll` |

---
## Namespace: `Topomatic.Glg.Runtime`

### `ActiveGeologyReceiver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.ActiveGeologyReceiver` |
| **Base Type** | `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver`
    - `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver`
      - `Topomatic.Glg.Runtime.ActiveGeologyReceiver`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `GeologyModel` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateReciver` | `ActiveGeologyReceiver` | `Boolean readOnly, Boolean mustExists` | `` |
| `CreateReciver` | `ActiveGeologyReceiver` | `Boolean readOnly` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `AlignmentGeologyReceiver` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.AlignmentGeologyReceiver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateReceiver` | `ActiveAlignmentReciver<Alignment>` | `ref Boolean readOnly` | `` |
| `CreateReceiver` | `ActiveAlignmentReciver<Alignment>` | `Boolean readOnly` | `` |
| `Current_Section` | `Section` | `ActiveAlignmentReciver<Alignment> receiver` | `Extension` |
| `CurrentCrsLine` | `CrsContour` | `ActiveAlignmentReciver<Alignment> receiver` | `Extension` |
| `CurrentProfile` | `Profile` | `ActiveAlignmentReciver<Alignment> receiver` | `Extension` |
| `CurrentSection` | `GeologyCrossSection` | `ActiveAlignmentReciver<Alignment> receiver` | `Extension` |
| `End_Section` | `Section` | `ActiveAlignmentReciver<Alignment> receiver` | `Extension` |
| `GetGeology` | `AlignmentGeology` | `ActiveAlignmentReciver<Alignment> receiver` | `Extension` |

### `CorridorExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.CorridorExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAgContour` | `CrsContour` | `Corridor corridor, Int32 index` | `Extension` |
| `GetEgContour` | `CrsContour` | `Corridor corridor, Int32 index` | `Extension` |
| `GetSectionIndexFromAlignmentLink` | `Int32` | `Alignment alignment, Double station, UInt32 id` | `` |

### `GeologyModelReceiver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.GeologyModelReceiver` |
| **Base Type** | `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver`
    - `Topomatic.Glg.Runtime.GeologyModelReceiver`

#### Constructors (1)

- `.ctor(String pathId, Boolean locked)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `GeologyModel` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateReciver` | `GeologyModelReceiver` | `String pathId, Boolean readOnly` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `GeologyOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.GeologyOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EncodeBadXmlString` | `String` | `String xml` | `` |
| `LoadBoreholeReferencesFromXmlDocument` | `Void` | `XmlDocument doc, ImpGroundTable groundTable, BoreholeTable table, BoreholeCollection collection` | `` |
| `LoadFromStream` | `Void` | `Stream stream, Alignment alignment, AlignmentGeology geology, IGeologyReference reference` | `` |
| `LoadFromXmlDocument` | `Void` | `XmlDocument doc, Alignment alignment, AlignmentGeology geology, IGeologyReference reference` | `` |
| `LoadGlobalBoreholesFromXmlDocument` | `Void` | `XmlDocument doc, ImpGroundTable groundTable, BoreholeTable boreholeTable` | `` |
| `LoadGroundsFromXmlDocument` | `Void` | `XmlDocument doc, ImpGroundTable groundTable` | `` |
| `SaveBoreholeReferencesAndGroundsToXmlDocument` | `Void` | `XmlDocument doc, AlignmentGeology geology, Alignment alignment` | `` |
| `SaveGroundsToXmlDocument` | `Void` | `XmlDocument doc, GroundTable groundTable` | `` |
| `SaveToStream` | `Void` | `Stream stream, AlignmentGeology geology, Alignment alignment` | `` |
| `SaveToXmlDocument` | `Void` | `XmlDocument doc, AlignmentGeology geology, Alignment alignment` | `` |

### `ImpGroundTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.ImpGroundTable` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GroundTable table, GroundRemoveValidator validator)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GroundTable` | `GroundTable` | `get` | No | `` |
| `Item` | `Ground` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Ground` | `Ground ground` | `` |
| `Clear` | `Void` | `Predicate<Guid> match` | `` |
| `Clear` | `Void` | `` | `` |
| `GetAddedGrounds` | `IEnumerable<Ground>` | `` | `` |

### `PltGlgConsts` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.PltGlgConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (21)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AbsElevations` | `String` | Yes | `` | `` |
| `Assays` | `String` | Yes | `` | `` |
| `BoreholeGroundDepthsAlign` | `String` | Yes | `` | `` |
| `BoreholeGroundNotes` | `String` | Yes | `` | `` |
| `BoreholesNumbers` | `String` | Yes | `` | `` |
| `FatLineBetweenDifferentGenesises` | `String` | Yes | `` | `` |
| `Geology` | `String` | Yes | `` | `` |
| `GeologyDashLinetypeName` | `String` | Yes | `` | `` |
| `GeologyScaleDistortion` | `String` | Yes | `` | `` |
| `GeologyStyles` | `String` | Yes | `` | `` |
| `GroundCipherEdging` | `String` | Yes | `` | `` |
| `GroundCodeWithAssaySign` | `String` | Yes | `` | `` |
| `GroundHatchColor` | `String` | Yes | `` | `` |
| `GroundNotes` | `String` | Yes | `` | `` |
| `GroundsBottomBorderHiding` | `String` | Yes | `` | `` |
| `GroundsLegendType` | `String` | Yes | `` | `` |
| `LegendGroundNameType` | `String` | Yes | `` | `` |
| `LegendGroundNotes` | `String` | Yes | `` | `` |
| `LinkedTestsOffsetFromBorehole` | `String` | Yes | `` | `` |
| `ProfileLine` | `String` | Yes | `` | `` |
| `SG` | `String` | Yes | `` | `` |

### `ReferenceUpdateLoop` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.ReferenceUpdateLoop` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `BeginUpdate` | `Void` | `String caption` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `ReferenceUpdateLoop` | `ReferenceValue reference` | `` |
| `Create` | `ReferenceUpdateLoop` | `IGeologyReference reference` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamedTransactable` | `BeginUpdate` |
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.Glg.Runtime.Controls`

### `DialogValues`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Controls.DialogValues`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActivateReference` | `IProjectModel` | `get/set` | No | `` |
| `HighlightedValues` | `T[]` | `get/set` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `SelectedValue` | `T` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `DialogValues<T> values` | `` |
| `Commit` | `Void` | `PropertyGrid grid, Func<Int32 T> getValue` | `` |
| `ConvertFrom` | `Void` | `IEnumerable<U> highlighted, U selected` | `` |
| `ConvertTo` | `DialogValues<U>` | `` | `` |
| `GetValues` | `IEnumerable<T>` | `` | `` |
| `Init` | `Boolean` | `PropertyGrid grid, Func<T Int32> indexOf` | `` |

### `LabQuestionBox` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Controls.LabQuestionBox` |
| **Base Type** | `System.Windows.Forms.Form` |
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
              - `Topomatic.Glg.Runtime.Controls.LabQuestionBox`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LabelText` | `String` | `get/set` | No | `` |
| `Result` | `LabQuestionBoxResult` | `get/set` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ShowQuestionDialog` | `LabQuestionBoxResult` | `String label, String title, String bhNum, String depth, AssayType assayType, Int32 fromInd, Int32 toInd` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LabQuestionBoxResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Controls.LabQuestionBoxResult` |
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
      - `Topomatic.Glg.Runtime.Controls.LabQuestionBoxResult`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Copy` | `LabQuestionBoxResult` | Yes | `Copy` | `` |
| `CopyToAll` | `LabQuestionBoxResult` | Yes | `CopyToAll` | `` |
| `Replace` | `LabQuestionBoxResult` | Yes | `Replace` | `` |
| `ReplaceToAll` | `LabQuestionBoxResult` | Yes | `ReplaceToAll` | `` |
| `Skip` | `LabQuestionBoxResult` | Yes | `Skip` | `` |
| `SkipToAll` | `LabQuestionBoxResult` | Yes | `SkipToAll` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Replace` | `0` |
| `ReplaceToAll` | `1` |
| `Skip` | `2` |
| `SkipToAll` | `3` |
| `Copy` | `4` |
| `CopyToAll` | `5` |

**Underlying Type**: `System.Int32`

### `ReferenceViewCollectionFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Controls.ReferenceViewCollectionFrame` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleFrame` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl, Topomatic.Controls.Dialogs.IManagedControl` |
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
              - `Topomatic.Controls.Dialogs.SimpleFrame`
                - `Topomatic.Glg.Runtime.Controls.ReferenceViewCollectionFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `AllowActivateReference` | `Boolean` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `Reference` | `IGeologyReference` | `get/set` | No | `` |
| `Values` | `DialogValues<ReferenceValue>` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ReferenceViewDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Controls.ReferenceViewDlg` |
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
                - `Topomatic.Glg.Runtime.Controls.ReferenceViewDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `AllowActivateReference` | `Boolean` | `get/set` | No | `` |
| `HideOldReference` | `Boolean` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `References` | `GeologyRelativeReferences` | `get/set` | No | `` |
| `SelectedNeeded` | `Boolean` | `get/set` | No | `` |
| `Values` | `DialogValues<ReferenceValue>` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Runtime.Cursors`

### `GeologyReferenceCorridorBoreholeCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorBoreholeCursor` |
| **Base Type** | `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor`
        - `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorBoreholeCursor`

#### Constructors (1)

- `.ctor(IGeologyReference geologyRelativeReference, CadView cadView, String message, String[] args)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBoreholes` | `GetPointResult` | `ref Borehole[] boreholes` | `` |
| `GetOffset` | `GetPointResult` | `ref Double offset` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

### `GeologyReferenceCorridorCptCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCptCursor` |
| **Base Type** | `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor`
        - `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCptCursor`

#### Constructors (1)

- `.ctor(IGeologyReference geologyRelativeReference, CadView cadView, String message, String[] args)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetConePenetrationTests` | `GetPointResult` | `ref ConePenetrationTest[] cpts` | `` |
| `GetOffset` | `GetPointResult` | `ref Double offset` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

### `GeologyReferenceCorridorCursor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor`

#### Constructors (1)

- `.ctor(IGeologyReference geologyRelativeReference, CadView cadView, String message, String[] args)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

### `GeologyReferenceCorridorImpellerTestCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorImpellerTestCursor` |
| **Base Type** | `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorCursor`
        - `Topomatic.Glg.Runtime.Cursors.GeologyReferenceCorridorImpellerTestCursor`

#### Constructors (1)

- `.ctor(IGeologyReference geologyRelativeReference, CadView cadView, String message, String[] args)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetImpellerTests` | `GetPointResult` | `ref ImpellerTest[] impellerTests` | `` |
| `GetOffset` | `GetPointResult` | `ref Double offset` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D position` | `` |

---
## Namespace: `Topomatic.Glg.Runtime.Design`

### `DigitsAfterPointPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Design.DigitsAfterPointPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Glg.Runtime.Design.DigitsAfterPointPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `DigitsAfterPointPropertyProviderShort` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Design.DigitsAfterPointPropertyProviderShort` |
| **Base Type** | `Topomatic.Glg.Runtime.Design.DigitsAfterPointPropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Glg.Runtime.Design.DigitsAfterPointPropertyProvider`
      - `Topomatic.Glg.Runtime.Design.DigitsAfterPointPropertyProviderShort`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Glg.Runtime.Plt.BoreholePlt`

### `BoreholeAlgWizardController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeAlgWizardController` |
| **Base Type** | `Topomatic.Plt.PltSimpleWizardController` |
| **Implements** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Dialogs.SimpleWizardController`
    - `Topomatic.Plt.PltSimpleWizardController`
      - `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeAlgWizardController`

#### Constructors (1)

- `.ctor(BoreholeTemplateDwgGenerator g, WizardFrame[] frames)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BoreholeFieldProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeFieldProvider` |
| **Base Type** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.TemplateFieldProvider`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeFieldProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

### `BoreholeGlobalWizardController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeGlobalWizardController` |
| **Base Type** | `Topomatic.Plt.PltSimpleWizardController` |
| **Implements** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Dialogs.SimpleWizardController`
    - `Topomatic.Plt.PltSimpleWizardController`
      - `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeGlobalWizardController`

#### Constructors (1)

- `.ctor(BoreholeTemplateDwgGenerator g, WizardFrame[] frames)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BoreholePltConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholePltConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (26)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ALIGNMENT` | `String` | Yes | `` | `` |
| `ASSAAYS` | `String` | Yes | `` | `` |
| `BOREHOLE` | `String` | Yes | `` | `` |
| `BOREHOLE_ON_SHEET` | `String` | Yes | `` | `` |
| `BOREHOLE_STATIONING_VALUE` | `String` | Yes | `` | `` |
| `BOREHOLE_TITLE_NAME` | `String` | Yes | `` | `` |
| `BOREHOLE_WRAPPERS` | `String` | Yes | `` | `` |
| `COLUMN_SCALE` | `String` | Yes | `` | `` |
| `CONE_PENETRATION_TEST` | `String` | Yes | `` | `` |
| `CONE_PENETRATION_TEST_STATIONING_VALUE` | `String` | Yes | `` | `` |
| `CONE_PENETRATION_TEST_TITLE_NAME` | `String` | Yes | `` | `` |
| `CONE_PENETRATION_WRAPPERS` | `String` | Yes | `` | `` |
| `DESCRIPTION_HEIGHT` | `String` | Yes | `` | `` |
| `LAYERS_HEIGHT` | `String` | Yes | `` | `` |
| `PaddingBottom` | `String` | Yes | `` | `` |
| `PaddingLeft` | `String` | Yes | `` | `` |
| `PaddingRight` | `String` | Yes | `` | `` |
| `PaddingTop` | `String` | Yes | `` | `` |
| `SheetHeightFirst` | `String` | Yes | `` | `` |
| `SheetHeightSecond` | `String` | Yes | `` | `` |
| `SheetWidthFirst` | `String` | Yes | `` | `` |
| `SheetWidthSecond` | `String` | Yes | `` | `` |
| `STYLE_OPTIONS` | `String` | Yes | `` | `` |
| `TemplateFirst` | `String` | Yes | `` | `` |
| `TemplateSecond` | `String` | Yes | `` | `` |
| `TEXT_HEIGHT_SCALE` | `String` | Yes | `` | `` |

### `BoreholeTemplateDwgGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeTemplateDwgGenerator` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeTemplateDwgGenerator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `BoreholeWrappers` | `BoreholeWrapper[]` | `get/set` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `StyleOptions` | `StyleOptions` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ID_BOREHOLE` | `UInt32` | Yes | `4194305` | `` |

#### Nested Types (1)

- `BoreholeWrapper` (struct)

### `BoreholeVariablesProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeVariablesProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeVariablesProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `BoreholeWrapper` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeTemplateDwgGenerator+BoreholeWrapper` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.BoreholeTemplateDwgGenerator+BoreholeWrapper`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Borehole` | `Borehole` | No | `` | `` |
| `Id` | `String` | No | `` | `` |
| `IsValid` | `Boolean` | No | `` | `` |
| `StationValue` | `Nullable<Vector3D>` | No | `` | `` |

### `ConePenetrationTestAlgWizardController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestAlgWizardController` |
| **Base Type** | `Topomatic.Plt.PltSimpleWizardController` |
| **Implements** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Dialogs.SimpleWizardController`
    - `Topomatic.Plt.PltSimpleWizardController`
      - `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestAlgWizardController`

#### Constructors (1)

- `.ctor(ConePenetrationTestTemplateDwgGenerator g, WizardFrame[] frames)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConePenetrationTestFieldProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestFieldProvider` |
| **Base Type** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.TemplateFieldProvider`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestFieldProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

### `ConePenetrationTestTemplateDwgGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestTemplateDwgGenerator` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestTemplateDwgGenerator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `ConePenetrationTests` | `Wrapper[]` | `get/set` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `StyleOptions` | `StyleOptions` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ID_CONE_PENETRATION_TEST` | `UInt32` | Yes | `4194306` | `` |

#### Nested Types (1)

- `Wrapper` (struct)

### `ConePenetrationTestVariablesProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestVariablesProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestVariablesProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `Wrapper` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestTemplateDwgGenerator+Wrapper` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.ConePenetrationTestTemplateDwgGenerator+Wrapper`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Borehole` | `Borehole` | No | `` | `` |
| `Data` | `ConePenetrationTest` | No | `` | `` |
| `Id` | `String` | No | `` | `` |
| `IsValid` | `Boolean` | No | `` | `` |
| `StationValue` | `Nullable<Vector3D>` | No | `` | `` |

---
## Namespace: `Topomatic.Glg.Runtime.Plt.BoreholePlt.Mockup`

### `BoreholeAlgMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Mockup.BoreholeAlgMockupLayer` |
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
        - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Mockup.BoreholeAlgMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertFromUidString` | `BoreholeReference` | `IGeologyReferences references, String key` | `` |
| `ConvertToUidKey` | `String` | `GuidReference value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BoreholeGlobalMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Mockup.BoreholeGlobalMockupLayer` |
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
        - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Mockup.BoreholeGlobalMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConePenetrationTestAlgMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Mockup.ConePenetrationTestAlgMockupLayer` |
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
        - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Mockup.ConePenetrationTestAlgMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertFromUidString` | `StationedReference` | `IGeologyReferences references, String key, ref Int32 indexInBorehole` | `` |
| `ConvertToUidKey` | `String` | `StationedReference reference, Int32 indexInBorehole` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash`

### `BoreholeColumnsOptions` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.BoreholeColumnsOptions` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.BoreholeColumnsOptions`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Format` | `Format` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetUserSettings` | `BoreholeColumnsOptions` | `` | `` |

#### Fields (15)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Alone` | `Boolean` | No | `` | `` |
| `AssayAlign` | `Int32` | No | `` | `` |
| `AssaySize` | `Double` | No | `` | `` |
| `ColumnType` | `ColumnType` | No | `` | `` |
| `DrawStamp` | `Boolean` | No | `` | `` |
| `ExternalFrame` | `Boolean` | No | `` | `` |
| `FontFileName` | `String` | No | `` | `` |
| `FontHeight` | `Double` | No | `` | `` |
| `FontOblique` | `Double` | No | `` | `` |
| `FontRatio` | `Double` | No | `` | `` |
| `InternalFrame` | `Boolean` | No | `` | `` |
| `Order` | `Int32` | No | `` | `` |
| `PaperFormat` | `PaperFormat` | No | `` | `` |
| `Scale` | `Double` | No | `` | `` |
| `UseCommonHeader` | `Boolean` | No | `` | `` |

### `ColumnType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.ColumnType` |
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
      - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.ColumnType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Type1` | `ColumnType` | Yes | `Type1` | `` |
| `Type2` | `ColumnType` | Yes | `Type2` | `` |
| `Type3` | `ColumnType` | Yes | `Type3` | `` |
| `Type3_1` | `ColumnType` | Yes | `Type3_1` | `` |
| `Type4` | `ColumnType` | Yes | `Type4` | `` |
| `Type4_1` | `ColumnType` | Yes | `Type4_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Type1` | `0` |
| `Type2` | `1` |
| `Type3` | `2` |
| `Type3_1` | `3` |
| `Type4` | `4` |
| `Type4_1` | `5` |

**Underlying Type**: `System.Int32`

### `ConePenetrationColumnsOptions` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.ConePenetrationColumnsOptions` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.ConePenetrationColumnsOptions`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetUserSettings` | `ConePenetrationColumnsOptions` | `` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DrawCpt` | `Boolean` | No | `` | `` |
| `DrawRf` | `Boolean` | No | `` | `` |
| `FsScale` | `Double` | No | `` | `` |
| `QcScale` | `Double` | No | `` | `` |
| `QsScale` | `Double` | No | `` | `` |
| `RfScale` | `Double` | No | `` | `` |

### `PageOrientation` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.PageOrientation` |
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
      - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.PageOrientation`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Album` | `PageOrientation` | Yes | `Album` | `` |
| `Book` | `PageOrientation` | Yes | `Book` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Book` | `0` |
| `Album` | `1` |

**Underlying Type**: `System.Int32`

### `PaperFormat` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.PaperFormat` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.PaperFormat`

#### Constructors (1)

- `.ctor(Format format)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Format` | `Format` | No | `` | `` |

### `StyleOptions` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.StyleOptions` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Plt.BoreholePlt.Trash.StyleOptions`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DepthDigits` | `Int32` | No | `` | `` |
| `ElevDigits` | `Int32` | No | `` | `` |
| `PowerDigits` | `Int32` | No | `` | `` |
| `ShowEndZeroFeet` | `Boolean` | No | `` | `` |
| `WaterDigits` | `Int32` | No | `` | `` |

---
## Namespace: `Topomatic.Glg.Runtime.Settings`

### `GeologyRelativeReferencesSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Settings.GeologyRelativeReferencesSettings` |
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
                - `Topomatic.Glg.Runtime.Settings.GeologyRelativeReferencesSettings`

#### Constructors (1)

- `.ctor(GeologyRelativeReferences references, URI folderUri)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileGeologySettingsContours` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Settings.ProfileGeologySettingsContours` |
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
                - `Topomatic.Glg.Runtime.Settings.ProfileGeologySettingsContours`

#### Constructors (1)

- `.ctor(GeologyProfileStyle style)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Runtime.Tools`

### `BgParamType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GroundParamsEqualityChecker+BgParamType` |
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
      - `Topomatic.Glg.Runtime.Tools.GroundParamsEqualityChecker+BgParamType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `BgParamType` | Yes | `Description` | `` |
| `ExcavationCategory` | `BgParamType` | Yes | `ExcavationCategory` | `` |
| `Genesis` | `BgParamType` | Yes | `Genesis` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ExcavationCategory` | `0` |
| `Genesis` | `1` |
| `Description` | `2` |

**Underlying Type**: `System.Int32`

### `BoreholeConverter`2<T where Borehole, INamedTransactable, ITransactable, IUpdatable, ICollection`1, IEnumerable`1, IEnumerable, IList`1, IOwned, IGroundTableContainer, class, Borehole, U where Borehole, INamedTransactable, ITransactable, IUpdatable, ICollection`1, IEnumerable`1, IEnumerable, IList`1, IOwned, IGroundTableContainer, class, Borehole>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.BoreholeConverter`2` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor(GroundTable groundTable)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Convert` | `Boolean` | `T from, U to` | `` |

### `BoreholeNumberValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.BoreholeNumberValidator` |
| **Base Type** | `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Glg.Runtime.Tools.BoreholeNumberValidator`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<Borehole> boreholes)`

### `BoreholesGroundRemoveValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.BoreholesGroundRemoveValidator` |
| **Base Type** | `Topomatic.Glg.Runtime.Tools.GroundRemoveValidator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Runtime.Tools.GroundRemoveValidator`
    - `Topomatic.Glg.Runtime.Tools.BoreholesGroundRemoveValidator`

#### Constructors (1)

- `.ctor(BoreholeTable table)`

### `ConePenetrationTestNumberValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.ConePenetrationTestNumberValidator` |
| **Base Type** | `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Glg.Runtime.Tools.ConePenetrationTestNumberValidator`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<ConePenetrationTest> boreholes)`

### `ContourEmbedding` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.ContourEmbedding` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EmbedContour` | `Void` | `GeologyContour parent, IList<Vector2D> r, GroundReference g` | `` |
| `EmbedContoursInCrsGlg` | `Void` | `AlignmentGeology geology, SectionList sections, Int32 index, List<List<Vector2D>> contours, GroundReference ground` | `` |

### `GeologyVcsTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GeologyVcsTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LabTableTemplatesPath` | `String` | `get` | Yes | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetOrCreateGround` | `Ground` | `Dictionary<Guid Guid> aliaces, GroundTable table, Ground ground` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BOREHOLES_ALIACES` | `String` | Yes | `"BOREHOLES_ALIACES"` | `` |
| `GROUND_ALIACES` | `String` | Yes | `"GROUND_ALIACES"` | `` |

### `GeologyVolumeModifier` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GeologyVolumeModifier` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CutGeologyVolumes` | `Void` | `List<CrsModifiedVolume> volumes, CrsVolume cutVolume, Int32 index, GeologyContour glgContour` | `` |
| `Modify` | `Void` | `List<CrsModifiedVolume> volumes, GeologyContour boundContour` | `` |

### `GlgCrsSectionMaker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GlgCrsSectionMaker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `GeologySection aCrsSection, Double crsSectionStation, CrsContour eg, GeologySection aPrfSection, Alignment aAlignment, Boolean allowInterp, Nullable<GrassAndSpecialGround> grass, Double depth` | `` |
| `SectContour` | `Boolean` | `GeologyContour contour, Double sta, IList<GlgCrsSectionMakerElement> list` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BreakLine` | `List<CrsContour>` | `CrsContour line, Double h` | `` |
| `MakeInterpLine` | `Boolean` | `CrsContour eg, CrsContour ag, List<Vector2D> line` | `` |
| `SectionMakerElementToSortedSegmentsList` | `Void` | `GlgCrsSectionMakerElement element, List<GlgSectionElement> list` | `` |

#### Nested Types (2)

- `GlgSectionElement` (class)
- `GrassAndSpecialGround` (struct)

### `GlgCrsSectionMakerElement` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GlgCrsSectionMakerElement` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Ground` | `GroundReference` | `get/set` | No | `` |
| `Item` | `GlgCrsSectionMakerElement` | `get` | No | `` |
| `Items` | `List<GlgCrsSectionMakerElement>` | `get` | No | `` |
| `MaxElev` | `Double` | `get/set` | No | `` |
| `MinElev` | `Double` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `GlgCrsSectionMakerElement element` | `` |

### `GlgCrsSectionManager` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GlgCrsSectionManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearGlgCrsSection` | `Boolean` | `AlignmentGeology geology, Corridor corridor, Int32 index` | `` |
| `CreateGlgCrsSection` | `Boolean` | `AlignmentGeology geology, Corridor corridor, Double station` | `` |
| `CreateGlgCrsSection` | `Boolean` | `AlignmentGeology geology, Corridor corridor, Int32 index` | `` |
| `DeleteGlgCrsSection` | `Boolean` | `AlignmentGeology geology, Corridor corridor, Int32 index` | `` |

### `GlgSectionElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GlgCrsSectionMaker+GlgSectionElement` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double min, Double max, Ground ground)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ground` | `Ground` | `get/set` | No | `` |
| `MaxElev` | `Double` | `get/set` | No | `` |
| `MinElev` | `Double` | `get/set` | No | `` |

### `GrassAndSpecialGround` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GlgCrsSectionMaker+GrassAndSpecialGround` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Tools.GlgCrsSectionMaker+GrassAndSpecialGround`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AgGround` | `GroundReference` | No | `` | `` |
| `GrassCode` | `Int32` | No | `` | `` |
| `GrassGround` | `GroundReference` | No | `` | `` |
| `GrassValue` | `Double` | No | `` | `` |

### `GroundMd5Validator` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GroundUtils+GroundMd5Validator` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(IEnumerable<GroundReference> groundRefernces)`
- `.ctor(IEnumerable<Ground> table)`
- `.ctor(IEnumerable<Ground> table, Predicate<String> match)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Ground` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateGroundMd5` | `Guid` | `Ground ground` | `` |
| `Invalidate` | `Void` | `` | `` |
| `IsExist` | `Boolean` | `Guid md5` | `` |
| `IsExist` | `Boolean` | `Ground ground` | `` |
| `TryGetGround` | `Boolean` | `Guid md5, ref Ground ground` | `` |
| `Update` | `Void` | `Guid md5, Ground ground` | `` |

### `GroundParamsEqualityChecker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GroundParamsEqualityChecker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(BoreholeTable boreholes)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `PossibleReplace` | `Boolean` | `Ground ground, String oldValue, BgParamType param` | `` |
| `ReplaceParam` | `Int32` | `Ground ground, String oldValue, BgParamType param, String newValue` | `` |

#### Nested Types (1)

- `BgParamType` (enum)

### `GroundReferenceRemoveValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GroundReferenceRemoveValidator` |
| **Base Type** | `Topomatic.Glg.Runtime.Tools.GroundRemoveValidator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Runtime.Tools.GroundRemoveValidator`
    - `Topomatic.Glg.Runtime.Tools.GroundReferenceRemoveValidator`

#### Constructors (1)

- `.ctor(AlignmentGeology geology)`

### `GroundRemoveValidator` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GroundRemoveValidator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanRemove` | `Boolean` | `Ground ground` | `` |
| `CanRemove` | `Boolean` | `Guid id` | `` |
| `FindInformaton` | `Nullable<UsedInformation>` | `Guid id` | `` |
| `Invalidate` | `Void` | `` | `` |

#### Nested Types (1)

- `UsedInformation` (struct)

### `GroundUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GroundUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Match` | `Predicate<String>` | `get` | Yes | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExcludeImProperty` | `Boolean` | `String tag` | `` |
| `GenerateGroundMd5` | `Guid` | `Ground ground, Predicate<String> fieldMatch` | `` |
| `GenerateGroundMd5` | `Guid` | `Ground ground` | `` |

#### Nested Types (1)

- `GroundMd5Validator` (class)

### `ImpellerConstKeyNumberValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.ImpellerConstKeyNumberValidator` |
| **Base Type** | `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.ImpellerTests.ImpellerConstKeyRec, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.ImpellerTests.ImpellerConstKeyRec, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Glg.Runtime.Tools.ImpellerConstKeyNumberValidator`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<ImpellerConstKeyRec> tests)`

### `ImpellerConstRemoveValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.ImpellerConstRemoveValidator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ImpellerTestTable table)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanRemove` | `Boolean` | `Ground ground` | `` |
| `CanRemove` | `Boolean` | `Guid id` | `` |
| `FindInformaton` | `Nullable<UsedInformation>` | `Guid id` | `` |
| `Invalidate` | `Void` | `` | `` |

#### Nested Types (1)

- `UsedInformation` (struct)

### `ImpellerTestNumberValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.ImpellerTestNumberValidator` |
| **Base Type** | `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Runtime.Tools.NumberValidator`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Glg.Runtime.Tools.ImpellerTestNumberValidator`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<ImpellerTest> tests)`

### `NumberValidator`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.NumberValidator`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (2)

- `.ctor(Func<T String> getNumber)`
- `.ctor(IEnumerable<T> boreholes, Func<T String> getNumber)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateValidNumber` | `String` | `String number` | `` |
| `Invalidate` | `Void` | `` | `` |
| `IsExist` | `Boolean` | `String number` | `` |
| `TryGetValue` | `Boolean` | `String number, ref T borehole` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateValidDummyNumber` | `String` | `NumberValidator<T> validator, String number` | `` |

### `TransactableUpdateLoop` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.TransactableUpdateLoop` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Commit` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateOwnerLoop` | `TransactableUpdateLoop` | `Object value` | `` |
| `CreateProjectLoop` | `TransactableUpdateLoop` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `TransactionRenamer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.TransactionRenamer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(ITransactable transactable, String caption)`
- `.ctor(ITransactionManager tm, String caption)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `TransactionRenamer` | `ITransactionManager transactionManager, String caption` | `` |
| `Create` | `TransactionRenamer` | `ITransactable transactable, String caption` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `UsedInformation` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.GroundRemoveValidator+UsedInformation` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Tools.GroundRemoveValidator+UsedInformation`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BoreholesCount` | `Int32` | No | `` | `` |
| `GroundsCount` | `Int32` | No | `` | `` |
| `UsedBoreholes` | `String` | No | `` | `` |
| `UsedSections` | `String` | No | `` | `` |

### `UsedInformation` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Runtime.Tools.ImpellerConstRemoveValidator+UsedInformation` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.Runtime.Tools.ImpellerConstRemoveValidator+UsedInformation`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ImpellerTestsCount` | `Int32` | No | `` | `` |
| `UsedImpellerTests` | `String` | No | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 68 |
| **Classes** | 44 |
| **Interfaces** | 0 |
| **Enums** | 4 |
| **Structs** | 9 |
| **Abstract Classes** | 3 |
| **Static Classes** | 8 |
| **Total Methods** | 115 |
| **Total Properties** | 48 |
| **Total Fields** | 118 |
| **Total Events** | 0 |
| **Total Constructors** | 52 |
| **Nested Types** | 8 |
| **Extension Methods** | 0 |


