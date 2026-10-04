# Topomatic.ComponentModel

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.ComponentModel` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.ComponentModel, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.ComponentModel.dll` |

---
## Namespace: ``

### `DoNotObfuscateAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `DoNotObfuscateAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `DoNotObfuscateAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.ComponentModel`

### `BaseEnumConverter` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStrings` | `IEnumerable<String>` | `Type type, Predicate<Enum> match` | `` |
| `ToEnum` | `Enum` | `String s, Type type` | `` |

### `BaseNumberConverter` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.BaseNumberConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `BooleanConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.BooleanConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BooleanConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `BooleanConverter` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `ByteConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ByteConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseNumberConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.ByteConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `CollectionExpandPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.CollectionExpandPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.ComponentModel.CollectionExpandPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InstanceDependence` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `ColorEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ColorEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.ColorEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |
| `GetPaintValueSupported` | `Boolean` | `IPropertyTypeDescriptorContext context` | `` |
| `GetPreferedPaintWidth` | `Int32` | `Int32 height` | `` |
| `PaintValue` | `Void` | `Rectangle bounds, Graphics g, IPropertyTypeDescriptorContext context` | `` |

### `ConditionalBrowsableAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ConditionalBrowsableAttribute` |
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
      - `Topomatic.ComponentModel.ConditionalBrowsableAttribute`

#### Constructors (1)

- `.ctor(String property)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PropertyName` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConditionalReadOnlyAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ConditionalReadOnlyAttribute` |
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
      - `Topomatic.ComponentModel.ConditionalReadOnlyAttribute`

#### Constructors (1)

- `.ctor(String property)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PropertyName` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CustomProperty` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.CustomProperty` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Attributes` | `Object[]` | `get` | No | `` |
| `Category` | `String` | `get/set` | No | `` |
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `Instance` | `Object` | `get/set` | No | `` |
| `IsBrowsable` | `Boolean` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `NullValue` | `Object` | `get` | Yes | `` |
| `PropertyInfo` | `PropertyInfo` | `get/set` | No | `` |
| `PropertyType` | `Type` | `get` | No | `` |
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |
| `VisualStyle` | `VisualStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `IsCompatablePropertysDesctiptor` | `Boolean` | `CustomProperty other` | `` |
| `SetValue` | `Void` | `Object value` | `` |

### `DateConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DateConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.DateConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `DateEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DateEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.DateEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsDropDownResizable` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `DefaultVisibleAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DefaultVisibleAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.DefaultVisibleAttribute`

#### Constructors (1)

- `.ctor(Boolean visible)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Visible` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DefaultWidthAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DefaultWidthAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.DefaultWidthAttribute`

#### Constructors (1)

- `.ctor(Single width)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Width` | `Single` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DesignAliasAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DesignAliasAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.DesignAliasAttribute`

#### Constructors (1)

- `.ctor(String alias)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAlias` | `String` | `Object obj` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAliases` | `String[]` | `IEnumerable collection` | `` |
| `GetObjectAliases` | `String[]` | `Object obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DoubleConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DoubleConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseNumberConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `DoubleConverter` | `get` | Yes | `` |

### `DoubleMaxMinAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DoubleMaxMinAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.DoubleMaxMinAttribute`

#### Constructors (1)

- `.ctor(Double max, Double min)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Max` | `Double` | `get` | No | `` |
| `Min` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DoubleStepAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DoubleStepAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.DoubleStepAttribute`

#### Constructors (1)

- `.ctor(Double step)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Step` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DoubleUpDownEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.DoubleUpDownEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.DoubleUpDownEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `DynamicTypeLoader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.TypeExplorer+DynamicTypeLoader` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.ComponentModel.TypeExplorer+DynamicTypeLoader`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `String asm, String name, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Type` | `IAsyncResult result` | `` |
| `Invoke` | `Type` | `String asm, String name` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EnumerableList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.EnumerableList` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(IEnumerable enumerable)`
- `.ctor(IEnumerable collection, Int32 capacity)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |

### `IActivator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.IActivator` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

### `IActivator`1<T where class>` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.IActivator`1` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `T` | `` | `` |

### `ILongSetterAsyncWorker` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ILongSetterAsyncWorker` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CancellationPending` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginProgress` | `Void` | `CustomProperty property, MethodInvoker method, Boolean canCancel` | `` |
| `ProgressChange` | `Void` | `Single progressPercentage` | `` |

### `InspectDescendantTypesAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.InspectDescendantTypesAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.InspectDescendantTypesAttribute`

#### Constructors (1)

- `.ctor(Boolean inspect)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Inspect` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IntegerConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.IntegerConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseNumberConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.IntegerConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `IntegerConverter` | `get` | Yes | `` |

### `IPropertyTypeDescriptorContext` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.IPropertyTypeDescriptorContext` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Instances` | `IList` | `get` | No | `` |
| `MultiProperty` | `MultiProperty` | `get` | No | `` |
| `Value` | `Object` | `get` | No | `` |
| `Values` | `Object[]` | `get` | No | `` |

### `IPropertyWindowsFormsEditorService` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.IPropertyWindowsFormsEditorService` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloseDropDownControl` | `Void` | `DialogResult result` | `` |
| `DropDownControl` | `DialogResult` | `Control control` | `` |
| `ShowDialog` | `DialogResult` | `Form dialog` | `` |

### `ISupportInterpolation` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ISupportInterpolation` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanInterpolate` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Interpolate` | `Boolean` | `Object first, Object second, Object result` | `` |

### `KeyFieldAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.KeyFieldAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.KeyFieldAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftAligned` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.LeftAligned` |
| **Base Type** | `Topomatic.ComponentModel.VisualStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.VisualStyle`
    - `Topomatic.ComponentModel.LeftAligned`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetTextAlign` | `VisualStyleAlign` | `IPropertyTypeDescriptorContext context, VisualStyleAlign defaultValue, Boolean selected` | `` |

### `MultiProperty` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.MultiProperty` |
| **Base Type** | `Topomatic.ComponentModel.CustomProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.MultiProperty`

#### Constructors (3)

- `.ctor(Dictionary<Type CustomProperty> dictionary, IList instances)`
- `.ctor(CustomProperty prop, IList instance)`
- `.ctor(IList<CustomProperty> list, IList instances)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Category` | `String` | `get/set` | No | `` |
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsBrowsable` | `Boolean` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `CustomProperty` | `get` | No | `` |
| `LongSetterAsyncWorker` | `ILongSetterAsyncWorker` | `get/set` | No | `` |
| `PropertyInfo` | `PropertyInfo` | `get/set` | No | `` |
| `PropertyType` | `Type` | `get` | No | `` |
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |
| `VisualStyle` | `VisualStyle` | `get` | No | `` |

#### Instance Methods (27)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertStringToValue` | `Object` | `String value, Int32 index` | `` |
| `ConvertValueToString` | `String` | `Int32 index` | `` |
| `GetCategory` | `String` | `Int32 index` | `` |
| `GetConverter` | `PropertyTypeConverter` | `Int32 index` | `` |
| `GetDescription` | `String` | `Int32 index` | `` |
| `GetDisplayName` | `String` | `Int32 index` | `` |
| `GetEditor` | `PropertyEditor` | `Int32 index` | `` |
| `GetInstance` | `IList` | `` | `` |
| `GetIsBrowsable` | `Boolean` | `Int32 index` | `` |
| `GetIsEditable` | `Boolean` | `Int32 index` | `` |
| `GetIsReadOnly` | `Boolean` | `Int32 index` | `` |
| `GetProperty` | `CustomProperty` | `Int32 index` | `` |
| `GetPropertyInfo` | `PropertyInfo` | `Int32 index` | `` |
| `GetPropertyType` | `Type` | `Int32 index` | `` |
| `GetStringValue` | `String` | `` | `` |
| `GetToolTipString` | `String` | `` | `` |
| `GetUpdateSequence` | `PropertyUpdateSequence` | `Int32 index` | `` |
| `GetValue` | `Object` | `Int32 index` | `` |
| `GetValue` | `Object` | `` | `` |
| `GetValues` | `Object[]` | `` | `` |
| `GetVisualStyle` | `VisualStyle` | `Int32 index` | `` |
| `SetStringValue` | `Void` | `String value` | `` |
| `SetStringValue` | `Void` | `String value, Predicate<Int32> isReadonly` | `` |
| `SetStringValue` | `Void` | `Int32 index, String value` | `` |
| `SetValue` | `Void` | `Object value, Int32 index` | `` |
| `SetValue` | `Void` | `Object value, Predicate<Int32> isReadonly` | `` |
| `SetValue` | `Void` | `Object value` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateEmptyProperty` | `MultiProperty` | `` | `` |

### `ParameterTypeAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ParameterTypeAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.ParameterTypeAttribute`

#### Constructors (2)

- `.ctor(String type)`
- `.ctor(Type type)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `Type` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PropertyEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyEditor` |
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
| `IsDropDownResizable` | `Boolean` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClickEdit` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService` | `` |
| `DoubleClickEdit` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService` | `` |
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |
| `GetPaintValueSupported` | `Boolean` | `IPropertyTypeDescriptorContext context` | `` |
| `GetPreferedPaintWidth` | `Int32` | `Int32 height` | `` |
| `PaintValue` | `Void` | `Rectangle bounds, Graphics g, IPropertyTypeDescriptorContext context` | `` |

### `PropertyEditorAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyEditorAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyEditorAttribute`

#### Constructors (2)

- `.ctor(String editorType)`
- `.ctor(Type editorType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EditorType` | `Type` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PropertyExplorer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyExplorer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `List<MultiProperty>` | `IEnumerable collection` | `` |
| `HaveCommonProperties` | `Boolean` | `IList instance` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CategoryDelimiter` | `Char` | Yes | `` | `` |

### `PropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyProvider` |
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
| `InstanceDependence` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProvider` | `PropertyProvider` | `PropertyInfo property, IEnumerable attributes` | `` |
| `RegisterProvider` | `Void` | `Type sourceType, Type providerType` | `` |

### `PropertyProviderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`

#### Constructors (2)

- `.ctor(String providerType)`
- `.ctor(Type providerType)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Order` | `Int32` | `get/set` | No | `` |
| `ProviderType` | `Type` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PropertyTypeConverter` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToObject` | `Object` | `String s, Type type` | `` |
| `ToString` | `String` | `Object value` | `` |

### `PropertyTypeConverterAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyTypeConverterAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyTypeConverterAttribute`

#### Constructors (2)

- `.ctor(String converterType)`
- `.ctor(Type converterType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConverterType` | `Type` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PropertyTypeEditorEditStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyTypeEditorEditStyle` |
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
      - `Topomatic.ComponentModel.PropertyTypeEditorEditStyle`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Custom` | `PropertyTypeEditorEditStyle` | Yes | `Custom` | `` |
| `DropDown` | `PropertyTypeEditorEditStyle` | Yes | `DropDown` | `` |
| `Modal` | `PropertyTypeEditorEditStyle` | Yes | `Modal` | `` |
| `None` | `PropertyTypeEditorEditStyle` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `1` |
| `Modal` | `2` |
| `DropDown` | `3` |
| `Custom` | `4` |

**Underlying Type**: `System.Int32`

### `PropertyUpdateSequence` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyUpdateSequence` |
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
      - `Topomatic.ComponentModel.PropertyUpdateSequence`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Category` | `PropertyUpdateSequence` | Yes | `Category` | `` |
| `Default` | `PropertyUpdateSequence` | Yes | `Default` | `` |
| `List` | `PropertyUpdateSequence` | Yes | `List` | `` |
| `Reload` | `PropertyUpdateSequence` | Yes | `Reload` | `` |
| `Repaint` | `PropertyUpdateSequence` | Yes | `Repaint` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `5` |
| `Category` | `10` |
| `Repaint` | `12` |
| `List` | `15` |
| `Reload` | `20` |

**Underlying Type**: `System.Int32`

### `PropertyUpdateSequenceAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.PropertyUpdateSequenceAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyUpdateSequenceAttribute`

#### Constructors (1)

- `.ctor(PropertyUpdateSequence value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RegexExtentions` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.RegexExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateRegex` | `Regex` | `String pattern` | `` |
| `IsMatchFilter` | `Boolean` | `String pattern, String value` | `` |
| `IsMatchFilter` | `Boolean` | `String pattern, Regex regex, String value` | `` |

### `RightAligned` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.RightAligned` |
| **Base Type** | `Topomatic.ComponentModel.VisualStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.VisualStyle`
    - `Topomatic.ComponentModel.RightAligned`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetTextAlign` | `VisualStyleAlign` | `IPropertyTypeDescriptorContext context, VisualStyleAlign defaultValue, Boolean selected` | `` |

### `SelectorModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.SelectorModel` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name, IEnumerable selectable)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `Selectable` | `IEnumerable` | `get` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `SharedPropertyAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.SharedPropertyAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.SharedPropertyAttribute`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean shared)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Shared` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SimpleProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.SimpleProperty` |
| **Base Type** | `Topomatic.ComponentModel.CustomProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`

#### Constructors (1)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Category` | `String` | `get/set` | No | `` |
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsBrowsable` | `Boolean` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `PropertyType` | `Type` | `get` | No | `` |
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |
| `VisualStyle` | `VisualStyle` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `SetValue` | `Void` | `Object value` | `` |

#### Static Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCategory` | `String` | `IEnumerable attibutes` | `` |
| `GetConverterFromType` | `Type` | `Type type` | `` |
| `GetConverterType` | `Type` | `PropertyInfo property, Object[] attibutes` | `` |
| `GetDescription` | `String` | `PropertyInfo property, Object[] attibutes` | `` |
| `GetDisplayName` | `String` | `PropertyInfo property, Object[] attibutes` | `` |
| `GetEditorFromType` | `Type` | `Type type` | `` |
| `GetEditorType` | `Type` | `PropertyInfo property, Object[] attibutes` | `` |
| `GetIsBrowsable` | `Boolean` | `PropertyInfo property, Object[] attibutes` | `` |
| `GetIsReadOnly` | `Boolean` | `PropertyInfo property, Object[] attibutes` | `` |
| `GetUpdateSequence` | `PropertyUpdateSequence` | `PropertyInfo property, Object[] attibutes` | `` |
| `GetVisualStyleType` | `Type` | `PropertyInfo property, Object[] attibutes` | `` |
| `IsCompatableProperty` | `Boolean` | `PropertyInfo property` | `` |

### `SingleConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.SingleConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseNumberConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.SingleConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SortedTypedList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.SortedTypedList` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IList parentList, String caption)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |

### `StringConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.StringConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.StringConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultConverter` | `StringConverter` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `SubtypeExpandPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.SubtypeExpandPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.ComponentModel.SubtypeExpandPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InstanceDependence` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `TypeExplorer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.TypeExplorer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDisplayName` | `String` | `Type type` | `` |
| `GetIsBrowsable` | `Boolean` | `Type type` | `` |
| `GetLoadedModules` | `IEnumerable<Assembly>` | `` | `` |
| `GetPropertyInfoCustomAttributes` | `Object[]` | `PropertyInfo propertyinfo, Boolean inherit` | `` |
| `GetSerializableString` | `String` | `Type type` | `` |
| `GetSerializableType` | `Type` | `String type` | `` |
| `GetSerializableType` | `Type` | `String type, StringComparison comparisonType` | `` |
| `GetTypeCustomAttributes` | `Object[]` | `Type type, Boolean inherit` | `` |
| `GetTypes` | `Type[]` | `Type baseType` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `DynamicLoader` | `DynamicTypeLoader` | Yes | `` |

#### Nested Types (1)

- `DynamicTypeLoader` (class)

### `VisualStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.VisualStyle` |
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
| `Default` | `VisualStyle` | `get` | Yes | `` |
| `LeftAligned` | `VisualStyle` | `get` | Yes | `` |
| `RightAligned` | `VisualStyle` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBackGroundColor` | `Color` | `IPropertyTypeDescriptorContext context, Color defaultValue, Boolean selected` | `` |
| `GetTextAlign` | `VisualStyleAlign` | `IPropertyTypeDescriptorContext context, VisualStyleAlign defaultValue, Boolean selected` | `` |
| `GetTextColor` | `Color` | `IPropertyTypeDescriptorContext context, Color defaultValue, Boolean selected` | `` |

### `VisualStyleAlign` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.VisualStyleAlign` |
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
      - `Topomatic.ComponentModel.VisualStyleAlign`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `VisualStyleAlign` | Yes | `Left` | `` |
| `Right` | `VisualStyleAlign` | Yes | `Right` | `` |
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

### `VisualStyleAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.VisualStyleAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.VisualStyleAttribute`

#### Constructors (1)

- `.ctor(Type visualStyleType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `VisualStyleType` | `Type` | `get` | No | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `VisualStyleAttribute` | Yes | `` | `` |
| `LeftAligned` | `VisualStyleAttribute` | Yes | `` | `` |
| `RightAligned` | `VisualStyleAttribute` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.ComponentModel.Design`

### `BooleanEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.BooleanEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.BooleanEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertValue` | `String` | `Boolean b` | `` |
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `BooleanProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.BooleanProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.ComponentModel.Design.BooleanProperty`

#### Constructors (1)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |

### `BooleanPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.BooleanPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.ComponentModel.Design.BooleanPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `EnumEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.EnumEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.EnumEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `EnumProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.EnumProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.ComponentModel.Design.EnumProperty`

#### Constructors (1)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |

### `EnumPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.EnumPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.ComponentModel.Design.EnumPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `IndentAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.IndentAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.Design.IndentAttribute`

#### Constructors (1)

- `.ctor(Int32 indent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Indent` | `Int32` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PropertyDropDownList` (class)

**Attributes**: [Browsable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.PropertyDropDownList` |
| **Base Type** | `System.Windows.Forms.Control` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.ComponentModel.Design.PropertyDropDownList`

#### Constructors (1)

- `.ctor(Int32 offset, IPropertyWindowsFormsEditorService service)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemHeight` | `Int32` | `get/set` | No | `` |
| `List` | `List<Object>` | `get` | No | `` |
| `MinItems` | `Int32` | `get/set` | No | `` |
| `Offset` | `Int32` | `get/set` | No | `` |
| `ScrollBar` | `ScrollBar` | `get` | No | `` |
| `SelectedIndex` | `Int32` | `get/set` | No | `` |
| `SelectedObject` | `Object` | `get` | No | `` |
| `Service` | `IPropertyWindowsFormsEditorService` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddItem` | `Void` | `Object value` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGuiScaling` | `Single` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MinOffset` | `Int32` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StandardValueEditor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `SummarizeAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.Design.SummarizeAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.Design.SummarizeAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Summarize` | `Object` | `Object a, Object b` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 66 |
| **Classes** | 49 |
| **Interfaces** | 6 |
| **Enums** | 3 |
| **Structs** | 0 |
| **Abstract Classes** | 5 |
| **Static Classes** | 3 |
| **Total Methods** | 165 |
| **Total Properties** | 105 |
| **Total Fields** | 19 |
| **Total Events** | 1 |
| **Total Constructors** | 58 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


