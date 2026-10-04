# Topomatic.Landscaping.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Landscaping.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Landscaping.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Landscaping.Runtime.dll` |

---
## Namespace: `Topomatic.Landscaping.Runtime`

### `BaseLibrary` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.BaseLibrary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsChanged` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddName` | `Boolean` | `String name` | `` |
| `ChangeNames` | `Boolean` | `String oldName, String newName` | `` |
| `ContainsNames` | `Boolean` | `String name` | `` |
| `GetNames` | `HashSet<String>` | `` | `` |
| `RemoveByName` | `Boolean` | `String name` | `` |

### `BaseLibraryList`1<T where IStgSerializable, INamedObject, class, IStgSerializable, INamedObject>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.BaseLibraryList`1` |
| **Base Type** | `Topomatic.Landscaping.Runtime.BaseLibrary` |
| **Implements** | `, , System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Landscaping.Runtime.BaseLibrary`
    - `Topomatic.Landscaping.Runtime.BaseLibraryList`1`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean read_only)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsChanged` | `Boolean` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Instance Methods (23)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `AddName` | `Boolean` | `String name` | `` |
| `AddRange` | `Void` | `IEnumerable<T> collection` | `` |
| `ChangeNames` | `Boolean` | `String oldName, String newName` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `ContainsNames` | `Boolean` | `String name` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `Find` | `IList<T>` | `Predicate<T> match` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `GetNames` | `HashSet<String>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `InsertRange` | `Void` | `Int32 index, IEnumerable<T> collection` | `` |
| `LoadFromFile` | `Void` | `String fileName` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 idx` | `` |
| `RemoveByName` | `Boolean` | `String name` | `` |
| `RemoveRange` | `Void` | `Predicate<T> match` | `` |
| `RemoveRange` | `Void` | `Int32 index, Int32 count` | `` |
| `SaveInFile` | `Void` | `String fileName` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |

### `DefaultSizes` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.DefaultSizes` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Landscaping.Runtime.DefaultSizes`

#### Constructors (1)

- `.ctor(Double size, Double depth)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Instance` | `DefaultSizes` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Depth` | `Double` | No | `` | `` |
| `Size` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GostList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.GostList` |
| **Base Type** | `Topomatic.Landscaping.Runtime.BaseLibraryList`1[[Topomatic.Landscaping.Runtime.PlantParams, Topomatic.Landscaping.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Landscaping.Runtime.PlantParams, Topomatic.Landscaping.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Landscaping.Runtime.PlantParams, Topomatic.Landscaping.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Landscaping.Runtime.PlantParams, Topomatic.Landscaping.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Landscaping.Runtime.BaseLibrary`
    - `Topomatic.Landscaping.Runtime.BaseLibraryList`1[[Topomatic.Landscaping.Runtime.PlantParams, Topomatic.Landscaping.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Landscaping.Runtime.GostList`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean read_only)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `GostList` | `get` | Yes | `` |
| `SetUp` | `GostList` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindAll` | `List<IList<PlantParams>>` | `Predicate<PlantParams> match` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LIBX` | `String` | Yes | `"plant_param"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandscapeLibTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.LandscapeLibTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateVolumes` | `Void` | `RootForm form, RootSystem type, Double pit_size, Double pit_depth, Double clod_size, Double clod_depth, ref Double pit_v, ref Double clod_v, ref Double ground100, ref Double ground50` | `` |
| `FindPlant` | `TypedObject` | `TreeType type, String gost, String name` | `` |
| `FindUnderground` | `UndergroundParams` | `Predicate<UndergroundParams> match` | `` |
| `GetDefault` | `PlantParams` | `DwgSmdxLandscaping entity, Predicate<PlantParams> match` | `` |
| `GetFilter` | `Predicate<PlantParams>` | `String tag, IList<ModelPropertyItem> items` | `` |
| `GetGost` | `String[]` | `TreeType type` | `` |
| `GetGroups` | `String[]` | `TreeType type, String gost` | `` |
| `GetLibraryFileName` | `String` | `String libraryPrefix` | `` |
| `GetPlant` | `PlantParams` | `Predicate<PlantParams> match` | `` |
| `GetPlants` | `String[]` | `TreeType type` | `` |
| `GetPlants` | `String[]` | `TreeType type, String gost` | `` |
| `GetSorts` | `String[]` | `TreeType type, String gost, String group` | `` |
| `GetSorts` | `String[]` | `PlantParams current` | `` |
| `GetSystemLibraryFileName` | `String` | `String libraryPrefix` | `` |
| `GetTypes` | `String[]` | `PlantingEnum planting` | `` |
| `GetUnderground` | `UndergroundParams` | `PlantParams gost, String region, Int32 ditch` | `` |
| `GetUserLibraryFileName` | `String` | `String libraryPrefix` | `` |
| `GetValues` | `Void` | `IList<ModelPropertyItem> items, ref String type, ref String gost, ref String group, ref String def` | `` |
| `SetDefaultSize` | `UndergroundParams` | `UndergroundParams obj` | `` |
| `UpdatePlant` | `Void` | `DwgSmdxLandscaping entity` | `` |
| `UpdateUnderground` | `Void` | `DwgSmdxLandscaping entity, PlantParams param` | `` |

### `PlantParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.PlantParams` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (6)

- `.ctor()` - **Default constructor**
- `.ctor(TreeType treeType)`
- `.ctor(TreeType treeType, String gost)`
- `.ctor(TreeType treeType, String gost, String group)`
- `.ctor(TreeType treeType, String gost, String group, String sort)`
- `.ctor(TreeType treeType, String gost, String group, String sort, String defName)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BranchCount` | `Int32` | `get/set` | No | `` |
| `ClodHeight` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `ClodSize` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `CrownDiameter` | `String` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Form` | `RootForm` | `get/set` | No | `PropertyTypeConverter` |
| `Group` | `String` | `get/set` | No | `ReadOnly` |
| `Name` | `String` | `get/set` | No | `ReadOnly` |
| `PlantHeight` | `String` | `get/set` | No | `` |
| `PlantType` | `TreeType` | `get/set` | No | `PropertyTypeConverter, ReadOnly` |
| `RootDiameter` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `RootLength` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `RootType` | `RootSystem` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `ShtambDiameter` | `String` | `get/set` | No | `` |
| `ShtambHeight` | `String` | `get/set` | No | `` |
| `Sort` | `String` | `get/set` | No | `ReadOnly` |
| `Subgroups` | `String` | `get/set` | No | `ReadOnly` |
| `Weight` | `Double` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Object` | `` | `` |
| `ConvertFromSmdx` | `Void` | `TypedObject tobj` | `` |
| `ConvertToImProperties` | `ImProperties` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `ICloneable` | `Clone` |

### `UndergoundList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.UndergoundList` |
| **Base Type** | `Topomatic.Landscaping.Runtime.BaseLibraryList`1[[Topomatic.Landscaping.UndergroundParams, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Landscaping.UndergroundParams, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Landscaping.UndergroundParams, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Landscaping.UndergroundParams, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Landscaping.Runtime.BaseLibrary`
    - `Topomatic.Landscaping.Runtime.BaseLibraryList`1[[Topomatic.Landscaping.UndergroundParams, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Landscaping.Runtime.UndergoundList`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean read_only)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `UndergoundList` | `get` | Yes | `` |
| `DefSizes` | `Dictionary<String List<DefaultSizes>>` | `get` | No | `` |
| `SetUp` | `UndergoundList` | `get` | Yes | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddName` | `Boolean` | `String name` | `` |
| `ChangeNames` | `Boolean` | `String oldName, String newName` | `` |
| `CopyLibrary` | `Void` | `UndergoundList list` | `` |
| `Find` | `IList<UndergroundParams>` | `String region` | `` |
| `FindAll` | `List<IList<UndergroundParams>>` | `Predicate<UndergroundParams> match` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveByName` | `Boolean` | `String name` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDefaultSizes` | `List<DefaultSizes>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LIBX` | `String` | Yes | `"hole_param"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Landscaping.Runtime.Providers`

### `GostEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.GostEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Landscaping.Runtime.Providers.GostEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GostPropsAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.GostPropsAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Landscaping.Runtime.Providers.GostPropsAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GostProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.GostProvider` |
| **Base Type** | `Topomatic.Landscaping.Runtime.Providers.LandscapeProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Landscaping.Runtime.Providers.LandscapeProvider`
      - `Topomatic.Landscaping.Runtime.Providers.GostProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `ImLandscapeObjectPropEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.ImLandscapeObjectPropEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Landscaping.Runtime.Providers.ImLandscapeObjectPropEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `ImObjectLandscapeProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.ImObjectLandscapeProvider` |
| **Base Type** | `Topomatic.Landscaping.Runtime.Providers.LandscapeProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Landscaping.Runtime.Providers.LandscapeProvider`
      - `Topomatic.Landscaping.Runtime.Providers.ImObjectLandscapeProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `LandscapeProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.LandscapeProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Landscaping.Runtime.Providers.LandscapeProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InstanceDependence` | `Boolean` | `get` | No | `` |

### `UndergroundPropsAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.UndergroundPropsAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Landscaping.Runtime.Providers.UndergroundPropsAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UndergroundPropsProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Runtime.Providers.UndergroundPropsProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Landscaping.Runtime.Providers.UndergroundPropsProvider`

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 15 |
| **Classes** | 11 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 2 |
| **Static Classes** | 1 |
| **Total Methods** | 73 |
| **Total Properties** | 31 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 21 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


