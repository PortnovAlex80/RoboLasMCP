# Topomatic.Glg.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Glg.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Glg.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Glg.Core.dll` |

---
## Namespace: `Topomatic.Glg.Core`

### `ExpImpExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.ExpImpExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAttribute` | `Void` | `XmlNode node, String name, Double value` | `Extension` |
| `AddAttribute` | `Void` | `XmlNode node, String name, String value` | `Extension` |
| `AddAttribute` | `Void` | `XmlNode node, String name, Boolean value` | `Extension` |
| `AddAttribute` | `Void` | `XmlNode node, String name, Int32 value` | `Extension` |
| `FindSta` | `Boolean` | `Alignment alg, UInt32 p, ref Int32 index` | `` |
| `GenerateValidNumber` | `String` | `String number, HashSet<String> existingNumbers` | `` |
| `GetAttribute` | `UInt32` | `XmlNode node, String name, UInt32 defaultValue` | `Extension` |
| `GetAttribute` | `String` | `XmlNode node, String name, String defaultValue` | `Extension` |
| `GetAttribute` | `Boolean` | `XmlNode node, String name, Boolean defaultValue` | `Extension` |
| `GetAttribute` | `Int32` | `XmlNode node, String name, Int32 defaultValue` | `Extension` |
| `GetAttribute` | `Double` | `XmlNode node, String name, Double defaultValue` | `Extension` |
| `LoadFromXml` | `Void` | `TypedObject typedObject, XmlNode node` | `Extension` |
| `SaveToXml` | `Void` | `TypedObject typedObject, XmlNode node` | `Extension` |

### `GlgBoreholeAlgDwlEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.GlgBoreholeAlgDwlEditor` |
| **Base Type** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`
        - `Topomatic.Glg.Core.GlgBoreholeAlgDwlEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GlgBoreholeGlobalDwlEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.GlgBoreholeGlobalDwlEditor` |
| **Base Type** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`
        - `Topomatic.Glg.Core.GlgBoreholeGlobalDwlEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GlgConePenetrationTestAlgDwlEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.GlgConePenetrationTestAlgDwlEditor` |
| **Base Type** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`
        - `Topomatic.Glg.Core.GlgConePenetrationTestAlgDwlEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GlgCoreModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.GlgCoreModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Glg.Core.GlgCoreModule`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SerializationKey` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GlgCreateCptDwlEditor` | `GlgConePenetrationTestAlgDwlEditor` | `` | `cmd` |
| `GlgCreateDwlEditor` | `GlgBoreholeAlgDwlEditor` | `` | `cmd` |
| `GlgCreateGlobalBoreholeDwlEditor` | `GlgBoreholeGlobalDwlEditor` | `` | `cmd` |
| `Initialize` | `Void` | `PluginFactory factory` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateLabItems` | `String` | `String pathid` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |

### `GlgCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.GlgCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Glg.Core.GlgCorePluginHost`

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
## Namespace: `Topomatic.Glg.Core.Design`

### `DigitsAfterPointEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Design.DigitsAfterPointEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Glg.Core.Design.DigitsAfterPointEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Glg.Core.Dialogs`

### `QuestionBoxResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Dialogs.QuestionBoxResult` |
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
      - `Topomatic.Glg.Core.Dialogs.QuestionBoxResult`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `No` | `QuestionBoxResult` | Yes | `No` | `` |
| `NoToAll` | `QuestionBoxResult` | Yes | `NoToAll` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `QuestionBoxResult` | Yes | `Yes` | `` |
| `YesToAll` | `QuestionBoxResult` | Yes | `YesToAll` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Yes` | `0` |
| `YesToAll` | `1` |
| `No` | `2` |
| `NoToAll` | `3` |

**Underlying Type**: `System.Int32`

### `SelectOrCreateRelativeReferenceDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Dialogs.SelectOrCreateRelativeReferenceDlg` |
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
                - `Topomatic.Glg.Core.Dialogs.SelectOrCreateRelativeReferenceDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SelectReference` | `Boolean` | `GeologyRelativeReferences references, ref GeologyRelativeReference selected` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.Core.ExpImp.CredoImpExp`

### `DocumentExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.ExpImp.CredoImpExp.DocumentExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToXDocument` | `XDocument` | `XmlDocument xmlDocument` | `Extension` |
| `ToXmlDocument` | `XmlDocument` | `XDocument xDocument` | `Extension` |

---
## Namespace: `Topomatic.Glg.Core.Plt`

### `AbsElevsLocation` (enum)

**Attributes**: [DefaultValue, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.AbsElevsLocation` |
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
      - `Topomatic.Glg.Core.Plt.AbsElevsLocation`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `AbsElevsLocation` | Yes | `Left` | `` |
| `None` | `AbsElevsLocation` | Yes | `None` | `` |
| `Right` | `AbsElevsLocation` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Left` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `AssaysLocation` (enum)

**Attributes**: [DefaultValue, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.AssaysLocation` |
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
      - `Topomatic.Glg.Core.Plt.AssaysLocation`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `AssaysLocation` | Yes | `Left` | `` |
| `Right` | `AssaysLocation` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `BoreholeGroundDepthsAlign` (enum)

**Attributes**: [PropertyTypeConverter, DefaultValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.BoreholeGroundDepthsAlign` |
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
      - `Topomatic.Glg.Core.Plt.BoreholeGroundDepthsAlign`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `BoreholeGroundDepthsAlign` | Yes | `Bottom` | `` |
| `Middle` | `BoreholeGroundDepthsAlign` | Yes | `Middle` | `` |
| `Top` | `BoreholeGroundDepthsAlign` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Middle` | `0` |
| `Top` | `1` |
| `Bottom` | `-1` |

**Underlying Type**: `System.Int32`

### `BoreholesNumbersLocation` (enum)

**Attributes**: [PropertyTypeConverter, DefaultValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.BoreholesNumbersLocation` |
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
      - `Topomatic.Glg.Core.Plt.BoreholesNumbersLocation`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AboveHeader` | `BoreholesNumbersLocation` | Yes | `AboveHeader` | `` |
| `BottomVertical` | `BoreholesNumbersLocation` | Yes | `BottomVertical` | `` |
| `None` | `BoreholesNumbersLocation` | Yes | `None` | `` |
| `TopHorizontal` | `BoreholesNumbersLocation` | Yes | `TopHorizontal` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TopHorizontal` | `0` |
| `BottomVertical` | `1` |
| `AboveHeader` | `2` |
| `None` | `3` |

**Underlying Type**: `System.Int32`

### `CipherEdgingType` (enum)

**Attributes**: [DefaultValue, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.CipherEdgingType` |
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
      - `Topomatic.Glg.Core.Plt.CipherEdgingType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Circles` | `CipherEdgingType` | Yes | `Circles` | `` |
| `Ellipses` | `CipherEdgingType` | Yes | `Ellipses` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Ellipses` | `0` |
| `Circles` | `1` |

**Underlying Type**: `System.Int32`

### `CrsGroundNoteLocation` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.CrsGroundNoteLocation` |
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
      - `Topomatic.Glg.Core.Plt.CrsGroundNoteLocation`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Adapting` | `CrsGroundNoteLocation` | Yes | `Adapting` | `` |
| `Centroid` | `CrsGroundNoteLocation` | Yes | `Centroid` | `` |
| `LeftPartCentroid` | `CrsGroundNoteLocation` | Yes | `LeftPartCentroid` | `` |
| `RightPartCentroid` | `CrsGroundNoteLocation` | Yes | `RightPartCentroid` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Adapting` | `0` |
| `Centroid` | `1` |
| `LeftPartCentroid` | `2` |
| `RightPartCentroid` | `3` |

**Underlying Type**: `System.Int32`

### `GroundHatchColor` (enum)

**Attributes**: [DefaultValue, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.GroundHatchColor` |
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
      - `Topomatic.Glg.Core.Plt.GroundHatchColor`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByLayer` | `GroundHatchColor` | Yes | `ByLayer` | `` |
| `Color` | `GroundHatchColor` | Yes | `Color` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Color` | `0` |
| `ByLayer` | `1` |

**Underlying Type**: `System.Int32`

### `GroundNotes` (enum)

**Attributes**: [PropertyTypeConverter, DefaultValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.GroundNotes` |
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
      - `Topomatic.Glg.Core.Plt.GroundNotes`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cipher` | `GroundNotes` | Yes | `Cipher` | `` |
| `Cipher_Category` | `GroundNotes` | Yes | `Cipher_Category` | `` |
| `Description_Category` | `GroundNotes` | Yes | `Description_Category` | `` |
| `Genesis_Cipher_Category` | `GroundNotes` | Yes | `Genesis_Cipher_Category` | `` |
| `IndexNumberCircle` | `GroundNotes` | Yes | `IndexNumberCircle` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Cipher` | `0` |
| `Cipher_Category` | `1` |
| `Genesis_Cipher_Category` | `2` |
| `Description_Category` | `3` |
| `IndexNumberCircle` | `4` |

**Underlying Type**: `System.Int32`

### `GroundNumberType` (enum)

**Attributes**: [PropertyTypeConverter, DefaultValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.GroundNumberType` |
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
      - `Topomatic.Glg.Core.Plt.GroundNumberType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FromTable` | `GroundNumberType` | Yes | `FromTable` | `` |
| `Increment` | `GroundNumberType` | Yes | `Increment` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Increment` | `0` |
| `FromTable` | `1` |

**Underlying Type**: `System.Int32`

### `LegendGroundNameType` (enum)

**Attributes**: [DefaultValue, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.LegendGroundNameType` |
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
      - `Topomatic.Glg.Core.Plt.LegendGroundNameType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `LegendGroundNameType` | Yes | `Description` | `` |
| `Name` | `LegendGroundNameType` | Yes | `Name` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Description` | `0` |
| `Name` | `1` |

**Underlying Type**: `System.Int32`

### `LegendType` (enum)

**Attributes**: [PropertyTypeConverter, DefaultValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.LegendType` |
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
      - `Topomatic.Glg.Core.Plt.LegendType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AltTable` | `LegendType` | Yes | `AltTable` | `` |
| `Circles` | `LegendType` | Yes | `Circles` | `` |
| `Table` | `LegendType` | Yes | `Table` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Table` | `0` |
| `AltTable` | `1` |
| `Circles` | `2` |

**Underlying Type**: `System.Int32`

### `PrfLegendType` (enum)

**Attributes**: [PropertyTypeConverter, DefaultValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.PrfLegendType` |
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
      - `Topomatic.Glg.Core.Plt.PrfLegendType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Alternative` | `PrfLegendType` | Yes | `Alternative` | `` |
| `Full` | `PrfLegendType` | Yes | `Full` | `` |
| `Simple` | `PrfLegendType` | Yes | `Simple` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Full` | `0` |
| `Simple` | `1` |
| `Alternative` | `2` |

**Underlying Type**: `System.Int32`

### `WaterPlaneSignAlign` (enum)

**Attributes**: [PropertyTypeConverter, DefaultValue]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Plt.WaterPlaneSignAlign` |
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
      - `Topomatic.Glg.Core.Plt.WaterPlaneSignAlign`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `InHole` | `WaterPlaneSignAlign` | Yes | `InHole` | `` |
| `Left` | `WaterPlaneSignAlign` | Yes | `Left` | `` |
| `Right` | `WaterPlaneSignAlign` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |
| `InHole` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Glg.Core.Settings`

### `GeologyRelativeReferencesSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Settings.GeologyRelativeReferencesSettings` |
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
                - `Topomatic.Glg.Core.Settings.GeologyRelativeReferencesSettings`

#### Constructors (1)

- `.ctor(Alignment alignment, URI folderUri)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGeologySettingsBoreholeAssays` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Settings.SectionGeologySettingsBoreholeAssays` |
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
                - `Topomatic.Glg.Core.Settings.SectionGeologySettingsBoreholeAssays`

#### Constructors (1)

- `.ctor(BoreholeAssayStyle assayStyle)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGeologySettinsImpellerTests` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Core.Settings.SectionGeologySettinsImpellerTests` |
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
                - `Topomatic.Glg.Core.Settings.SectionGeologySettinsImpellerTests`

#### Constructors (1)

- `.ctor(ImpellerTestSectionStyle impellerTestSectionStyle)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 26 |
| **Classes** | 10 |
| **Interfaces** | 0 |
| **Enums** | 14 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 2 |
| **Total Methods** | 22 |
| **Total Properties** | 1 |
| **Total Fields** | 56 |
| **Total Events** | 0 |
| **Total Constructors** | 10 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


