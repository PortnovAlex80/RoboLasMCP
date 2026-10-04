# Topomatic.FoundationClasses

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.FoundationClasses` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.FoundationClasses.dll` |

---
## Namespace: ``

### `UpdateLoop` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `UpdateLoop` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginTransaction` | `Void` | `ITransactable obj` | `Extension` |
| `BeginTransaction` | `Void` | `INamedTransactable obj, String caption` | `Extension` |
| `BeginUpdateLoop` | `IDisposable` | `IUpdatable obj` | `Extension` |
| `BeginUpdateLoop` | `IDisposable` | `INamedTransactable obj, String caption` | `Extension` |
| `Commit` | `Void` | `ITransactable obj` | `Extension` |
| `InsertCommand` | `Void` | `ITransactionManager obj, ICommand command` | `Extension` |
| `Rollback` | `Void` | `ITransactable obj` | `Extension` |

---
## Namespace: `Topomatic.ComponentModel`

### `ISupportClipboard` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ComponentModel.ISupportClipboard` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `CanCopy` | `Boolean` | `get` | No | `` |
| `CanPaste` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Load` | `Void` | `Object obj, StgNode node` | `` |
| `Save` | `Void` | `Object obj, StgNode node` | `` |

---
## Namespace: `Topomatic.FoundationClasses`

### `DynamicDictionary` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.DynamicDictionary` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String json)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Object` | `get/set` | No | `` |
| `Items` | `IDictionary<String Object>` | `get` | No | `` |

#### Instance Methods (40)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDictionary` | `DynamicDictionary` | `String name` | `` |
| `AddList` | `DynamicList` | `String name` | `` |
| `Assign` | `Void` | `DynamicDictionary source` | `` |
| `Clear` | `Void` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetBoolean` | `Boolean` | `String name` | `` |
| `GetByte` | `Byte` | `String name` | `` |
| `GetChar` | `Char` | `String name` | `` |
| `GetDictionary` | `DynamicDictionary` | `String name` | `` |
| `GetDouble` | `Double` | `String name` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String Object>>` | `` | `` |
| `GetFloat` | `Single` | `String name` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetInt` | `Int32` | `String name` | `` |
| `GetList` | `DynamicList` | `String name` | `` |
| `GetLong` | `Int64` | `String name` | `` |
| `GetShort` | `Int16` | `String name` | `` |
| `GetString` | `String` | `String name` | `` |
| `HasName` | `Boolean` | `String name` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `String name` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetBoolean` | `DynamicDictionary` | `String name, Boolean value` | `` |
| `SetByte` | `DynamicDictionary` | `String name, Byte value` | `` |
| `SetChar` | `DynamicDictionary` | `String name, Char value` | `` |
| `SetDictionary` | `Void` | `String name, DynamicDictionary value` | `` |
| `SetDouble` | `DynamicDictionary` | `String name, Double value` | `` |
| `SetFloat` | `DynamicDictionary` | `String name, Single value` | `` |
| `SetInt` | `DynamicDictionary` | `String name, Int32 value` | `` |
| `SetList` | `Void` | `String name, DynamicList value` | `` |
| `SetLong` | `DynamicDictionary` | `String name, Int64 value` | `` |
| `SetShort` | `DynamicDictionary` | `String name, Int16 value` | `` |
| `SetString` | `DynamicDictionary` | `String name, String value` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetBoolen` | `Boolean` | `String name, ref Boolean value` | `` |
| `TryGetDouble` | `Boolean` | `String name, ref Double value` | `` |
| `TryGetFloat` | `Boolean` | `String name, ref Single value` | `` |
| `TryGetInt` | `Boolean` | `String name, ref Int32 value` | `` |
| `TryGetObject` | `Boolean` | `String name, ref Object value` | `` |
| `TryGetString` | `Boolean` | `String name, ref String value` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Jsonify` | `Void` | `JsonWriter writer, DynamicDictionary dictionary` | `` |
| `Parse` | `Void` | `JsonReader reader, DynamicDictionary dictionary` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DynamicList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.DynamicList` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String json)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `ElementType` | `StgType` | `get` | No | `` |
| `Item` | `Object` | `get` | No | `` |

#### Instance Methods (32)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBoolean` | `DynamicList` | `Boolean value` | `` |
| `AddByte` | `DynamicList` | `Byte value` | `` |
| `AddChar` | `DynamicList` | `Char value` | `` |
| `AddDictinary` | `DynamicDictionary` | `` | `` |
| `AddDouble` | `DynamicList` | `Double value` | `` |
| `AddFloat` | `DynamicList` | `Single value` | `` |
| `AddInt` | `DynamicList` | `Int32 value` | `` |
| `AddList` | `DynamicList` | `` | `` |
| `AddLong` | `DynamicList` | `Int32 value` | `` |
| `AddShort` | `DynamicList` | `Int16 value` | `` |
| `AddString` | `DynamicList` | `String value` | `` |
| `Assign` | `Void` | `DynamicList source` | `` |
| `Clear` | `Void` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `FindDictionary` | `DynamicDictionary` | `Predicate<DynamicDictionary> match` | `` |
| `GetBoolean` | `Boolean` | `Int32 index` | `` |
| `GetByte` | `Byte` | `Int32 index` | `` |
| `GetChar` | `Char` | `Int32 index` | `` |
| `GetDictionary` | `DynamicDictionary` | `Int32 index` | `` |
| `GetDouble` | `Double` | `Int32 index` | `` |
| `GetEnumerator` | `IEnumerator<Object>` | `` | `` |
| `GetFloat` | `Single` | `Int32 index` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetInt` | `Int32` | `Int32 index` | `` |
| `GetList` | `DynamicList` | `Int32 index` | `` |
| `GetLong` | `Int64` | `Int32 index` | `` |
| `GetShort` | `Int16` | `Int32 index` | `` |
| `GetString` | `String` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `IStgArray array` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `IStgArray array` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Jsonify` | `Void` | `JsonWriter writer, DynamicList list` | `` |
| `Parse` | `Void` | `JsonReader reader, DynamicList list` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `ICheckable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.ICheckable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Checked` | `Nullable<Boolean>` | `get/set` | No | `` |

### `ICustomDocumentsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.ICustomDocumentsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documents` | `IDocumentContainer[]` | `get` | No | `` |
| `ReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `` | `` |
| `Execute` | `Void` | `IDocumentContainer doc` | `` |
| `Remove` | `Void` | `IDocumentContainer doc` | `` |

### `IDocumentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IDocumentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

### `IExplodable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IExplodable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsExplodable` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Explode` | `Boolean` | `Boolean erase` | `` |

### `IHandledObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IHandledObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get/set` | No | `` |

### `IIconHolder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IIconHolder` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Icon` | `Bitmap` | `get` | No | `` |

### `ILayer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.ILayer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

### `ILayerActivityController` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.ILayerActivityController` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.ILayer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

### `ILayeredObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.ILayeredObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layer` | `ILayer` | `get/set` | No | `` |

### `IModelFinder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IModelFinder` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindHardReferences` | `IEnumerable<Object>` | `Object model` | `` |
| `FindModelFromPath` | `Object` | `String relativePath` | `` |
| `FindModelFromUid` | `Object` | `String modelUid` | `` |
| `FindModelType` | `String` | `Object model` | `` |
| `FindModelUid` | `String` | `Object model` | `` |
| `FindRelativePath` | `String` | `Object model` | `` |
| `ReadModelFromPath` | `T` | `String relativePath` | `` |
| `ReadModelFromUid` | `T` | `String modelUid` | `` |

### `INamedObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.INamedObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |

### `IndexesCollection`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IndexesCollection`1` |
| **Base Type** | `System.Object` |
| **Implements** | `, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddIndex` | `Void` | `T index` | `` |
| `ContainsIndex` | `Boolean` | `T index` | `` |
| `GetCount` | `T` | `` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `GetIntervals` | `T[]` | `` | `` |
| `GetLast` | `Boolean` | `ref T from, ref T to` | `` |
| `RemoveIndex` | `Boolean` | `T index` | `` |
| `RemoveRange` | `Void` | `T index, Int32 count` | `` |
| `SetIntervals` | `Void` | `T[] intervals` | `` |
| `ToString` | `String` | `` | `` |
| `TrimExcess` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `INode` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.INode` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `INode`2<TParentItem where class, TChildItem where IOwned, class, IOwned>` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.INode`2` |
| **Base Type** | `none` |
| **Implements** | `, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.INode, System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

### `IntegerIndexesCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IntegerIndexesCollection` |
| **Base Type** | `Topomatic.FoundationClasses.IndexesCollection`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.IndexesCollection`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.FoundationClasses.IntegerIndexesCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IntervalsToString` | `String` | `` | `` |
| `StringToIntervals` | `Boolean` | `String s` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IOwned` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IOwned` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

### `IOwned`1<TOwner where class>` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IOwned`1` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `TOwner` | `get/set` | No | `` |

### `IReferenceHolder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IReferenceHolder` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetReferences` | `IEnumerable<String>` | `` | `` |

### `ISimpleDocumentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.ISimpleDocumentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documents` | `String` | `get/set` | No | `` |
| `HasDocuments` | `Boolean` | `get` | No | `` |

### `IStateController` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IStateController` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Modified` | `Boolean` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |

### `IUpdatable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IUpdatable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |

### `IWrapped` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IWrapped` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WrappedObject` | `Object` | `get` | No | `` |

### `IWrapped`1<TItem where class>` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.IWrapped`1` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WrappedObject` | `TItem` | `get` | No | `` |

### `ObjectId` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.ObjectId` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `sEMPTY_MONIKER` | `String` | Yes | `` | `` |
| `sMONIKER_FORMAT` | `String` | Yes | `` | `` |
| `sMONIKER_GUID_DELIMETER` | `Char` | Yes | `#` | `` |
| `sMONIKER_PATH_DELIMETER` | `Char` | Yes | `;` | `` |

### `OwnedExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.OwnedExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindOwner` | `T` | `Object obj` | `Extension` |

### `StateControllerObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ModelFinder` | `IModelFinder` | `get/set` | No | `` |
| `Modified` | `Boolean` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetTransactionManager` | `Void` | `ITransactionManager value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IStateController` | `get_Modified` |
| `IStateController` | `set_Modified` |
| `IStateController` | `get_ReadOnly` |
| `IStateController` | `set_ReadOnly` |

### `UndoObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.UndoObject` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `BeginUpdate` | `Void` | `String caption` | `` |
| `EndUpdate` | `Void` | `` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |
| `Undo` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamedTransactable` | `BeginUpdate` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `UpdatableObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `Browsable` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `BeginUpdate` | `Void` | `String caption` | `` |
| `EndUpdate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamedTransactable` | `BeginUpdate` |
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `URI` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.URI` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(String uri)`
- `.ctor(URI baseUri, String relative)`
- `.ctor(String baseUri, String relative)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AsAbsoluteUri` | `String` | `get` | No | `` |
| `AsFilePath` | `String` | `get` | No | `` |
| `DirectoryUri` | `URI` | `get` | No | `` |
| `Extension` | `String` | `get` | No | `` |
| `IsAbsoluteUri` | `Boolean` | `get` | No | `` |
| `LastPathComponent` | `String` | `get` | No | `` |
| `Scheme` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetRelativeUri` | `URI` | `URI baseUri` | `` |
| `ToString` | `String` | `` | `` |

---
## Namespace: `Topomatic.FoundationClasses.Csv`

### `CsvReader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Csv.CsvReader` |
| **Base Type** | `System.IO.StreamReader` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.IO.TextReader`
      - `System.IO.StreamReader`
        - `Topomatic.FoundationClasses.Csv.CsvReader`

#### Constructors (10)

- `.ctor(Stream stream)`
- `.ctor(String path)`
- `.ctor(Stream stream, Encoding encoding)`
- `.ctor(Stream stream, Boolean detectEncodingFromByteOrderMarks)`
- `.ctor(String path, Boolean detectEncodingFromByteOrderMarks)`
- `.ctor(String path, Encoding encoding)`
- `.ctor(Stream stream, Encoding encoding, Boolean detectEncodingFromByteOrderMarks)`
- `.ctor(String path, Encoding encoding, Boolean detectEncodingFromByteOrderMarks)`
- `.ctor(Stream stream, Encoding encoding, Boolean detectEncodingFromByteOrderMarks, Int32 bufferSize)`
- `.ctor(String path, Encoding encoding, Boolean detectEncodingFromByteOrderMarks, Int32 bufferSize)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Comment` | `Char` | `get/set` | No | `` |
| `Delimiter` | `Char` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ReadFields` | `IList<String>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CsvWriter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Csv.CsvWriter` |
| **Base Type** | `System.IO.StreamWriter` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.IO.TextWriter`
      - `System.IO.StreamWriter`
        - `Topomatic.FoundationClasses.Csv.CsvWriter`

#### Constructors (7)

- `.ctor(Stream stream)`
- `.ctor(String path)`
- `.ctor(Stream stream, Encoding encoding)`
- `.ctor(String path, Boolean append)`
- `.ctor(Stream stream, Encoding encoding, Int32 bufferSize)`
- `.ctor(String path, Boolean append, Encoding encoding)`
- `.ctor(String path, Boolean append, Encoding encoding, Int32 bufferSize)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Comment` | `Char` | `get/set` | No | `` |
| `Delimiter` | `Char` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `WriteComment` | `Void` | `String comment` | `` |
| `WriteField` | `Void` | `String field, Boolean lastField` | `` |
| `WriteFields` | `Void` | `String[] fields` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.FoundationClasses.Diagnostics`

### `DelegateHelpProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.DelegateHelpProvider` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Diagnostics.IHelpProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Action handler)`
- `.ctor(Delegate handler, Object[] args)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ProvideHelp` | `Void` | `TaskRecord record` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHelpProvider` | `ProvideHelp` |

### `IHelpProvider` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.IHelpProvider` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ProvideHelp` | `Void` | `TaskRecord record` | `` |

### `ILoggerListener` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.ILoggerListener` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `TaskIdentity identity` | `` |
| `Write` | `Void` | `TaskRecord[] records` | `` |

### `Logger` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.Logger` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Diagnostics.ILoggerListener, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.Diagnostics.ILoggerListener, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `Logger` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `TaskIdentity identity` | `` |
| `CreateWriter` | `LogWriter` | `TaskIdentity identity` | `` |
| `GetEnumerator` | `IEnumerator<ILoggerListener>` | `` | `` |
| `Register` | `Void` | `ILoggerListener listner` | `` |
| `Unregister` | `Boolean` | `ILoggerListener listner` | `` |
| `Write` | `Void` | `TaskRecord[] records` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILoggerListener` | `Clear` |
| `ILoggerListener` | `Write` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `LogWriter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.LogWriter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(TaskIdentity identity, ILoggerListener listner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Identity` | `TaskIdentity` | `get` | No | `` |
| `Listner` | `ILoggerListener` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Write` | `Void` | `TaskRecord[] records` | `` |
| `Write` | `Void` | `String message` | `` |
| `Write` | `Void` | `String message, TaskLevel level, Action help` | `` |
| `Write` | `Void` | `String message, TaskLevel level` | `` |
| `Write` | `Void` | `String message, TaskLevel level, IHelpProvider help` | `` |

### `TaskIdentity` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.TaskIdentity` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String displayName, Object[] args)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DisplayName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

### `TaskLevel` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.TaskLevel` |
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
      - `Topomatic.FoundationClasses.Diagnostics.TaskLevel`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Error` | `TaskLevel` | Yes | `Error` | `` |
| `Information` | `TaskLevel` | Yes | `Information` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Warning` | `TaskLevel` | Yes | `Warning` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Error` | `0` |
| `Warning` | `1` |
| `Information` | `2` |

**Underlying Type**: `System.Int32`

### `TaskRecord` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diagnostics.TaskRecord` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(TaskIdentity identity, String message, TaskLevel level)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HelpProvider` | `IHelpProvider` | `get/set` | No | `` |
| `Identity` | `TaskIdentity` | `get` | No | `` |
| `Level` | `TaskLevel` | `get` | No | `` |
| `Message` | `String` | `get` | No | `` |

---
## Namespace: `Topomatic.FoundationClasses.Diesel`

### `DieselConstant` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselConstant` |
| **Base Type** | `Topomatic.FoundationClasses.Diesel.DieselFunction` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Diesel.DieselFunction`
    - `Topomatic.FoundationClasses.Diesel.DieselConstant`

#### Constructors (1)

- `.ctor(String value)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Evaluate` | `DieselResult` | `DieselEngine engine, String s, ref Int32 position` | `` |

### `DieselEngine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselEngine` |
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
| `Scope` | `DieselScope` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Apply` | `DieselResult` | `String s, ref Int32 position, Boolean inside` | `` |
| `Evaluate` | `DieselResult` | `DieselScope scope, ref String macros, String[] registers` | `` |
| `Read` | `DieselResult` | `String s, ref Int32 position, ref String arg` | `` |
| `Skeep` | `DieselResult` | `String s, ref Int32 position` | `` |
| `Write` | `Void` | `String s, Int32 length` | `` |
| `Write` | `Void` | `Char chr` | `` |
| `Write` | `Void` | `String s` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultScope` | `DieselScope` | Yes | `` | `` |
| `RecursionLimmit` | `Int32` | Yes | `` | `` |

### `DieselFunction` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselFunction` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Evaluate` | `DieselResult` | `DieselEngine engine, String s, ref Int32 position` | `` |

### `DieselMacros` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselMacros` |
| **Base Type** | `Topomatic.FoundationClasses.Diesel.DieselFunction` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Diesel.DieselFunction`
    - `Topomatic.FoundationClasses.Diesel.DieselMacros`

#### Constructors (1)

- `.ctor(String macros)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Evaluate` | `DieselResult` | `DieselEngine engine, String s, ref Int32 position` | `` |

### `DieselResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselResult` |
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
      - `Topomatic.FoundationClasses.Diesel.DieselResult`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ArgumentError` | `DieselResult` | Yes | `ArgumentError` | `` |
| `Ok` | `DieselResult` | Yes | `Ok` | `` |
| `Overflow` | `DieselResult` | Yes | `Overflow` | `` |
| `SyntaxError` | `DieselResult` | Yes | `SyntaxError` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Ok` | `0` |
| `SyntaxError` | `1` |
| `ArgumentError` | `2` |
| `Overflow` | `3` |

**Underlying Type**: `System.Int32`

### `DieselScope` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselScope` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DieselScope parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFunction` | `DieselFunction` | `String name` | `` |

### `DieselSimpleFunction` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselSimpleFunction` |
| **Base Type** | `Topomatic.FoundationClasses.Diesel.DieselFunction` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Diesel.DieselFunction`
    - `Topomatic.FoundationClasses.Diesel.DieselSimpleFunction`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Evaluate` | `DieselResult` | `DieselEngine engine, String s, ref Int32 position` | `` |

### `DieselUserScope` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Diesel.DieselUserScope` |
| **Base Type** | `Topomatic.FoundationClasses.Diesel.DieselScope` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Diesel.DieselScope`
    - `Topomatic.FoundationClasses.Diesel.DieselUserScope`

#### Constructors (1)

- `.ctor(DieselScope parent)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFunction` | `DieselFunction` | `String name` | `` |
| `IsRegistered` | `Boolean` | `String name` | `` |
| `RegisterFunction` | `Void` | `String name, DieselFunction function` | `` |

---
## Namespace: `Topomatic.FoundationClasses.EditableItems`

### `BasicEditedItemsTable` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable`

#### Constructors (1)

- `.ctor(ITransactable transactableOwner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultItem` | `EditableItem` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `ClearUnused` | `Void` | `Predicate<EditableItemsKey> keyUsed` | `` |
| `CreateItem` | `EditableItem` | `` | `` |
| `CreateKey` | `EditableItemsKey` | `` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<EditableItemsKey EditableItem>>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `EditableItemsKey key` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetValue` | `Void` | `EditableItemsKey key, EditableItem item` | `` |
| `TryGetValue` | `Boolean` | `EditableItemsKey key, ref EditableItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `BlankEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.EditableItems.BlankEditableItem` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.FoundationClasses.EditableItems.BlankEditableItem`

#### Constructors (1)

- `.ctor(Object itemsTable)`

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

### `BlankEditableItemsKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.EditableItems.BlankEditableItemsKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.FoundationClasses.EditableItems.BlankEditableItemsKey`

#### Constructors (1)

- `.ctor()` - **Default constructor**

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

### `BlankEditedItemsTable` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.EditableItems.BlankEditedItemsTable` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable`
        - `Topomatic.FoundationClasses.EditableItems.BlankEditedItemsTable`

#### Constructors (1)

- `.ctor(ITransactable transactableParent)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateItem` | `EditableItem` | `` | `` |
| `CreateKey` | `EditableItemsKey` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EditableItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`

#### Constructors (1)

- `.ctor(Object itemsTable)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `EditableItemsKey` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SimpleEditedItemsTable` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.EditableItems.SimpleEditedItemsTable` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable`
        - `Topomatic.FoundationClasses.EditableItems.SimpleEditedItemsTable`

#### Constructors (1)

- `.ctor(ITransactable transactableParent, Func<EditableItemsKey> createKey, Func<EditableItem> createItem)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateItem` | `EditableItem` | `` | `` |
| `CreateKey` | `EditableItemsKey` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.FoundationClasses.Json`

### `JsonReader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Json.JsonReader` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Stream stream)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `Int32` | `get` | No | `` |
| `Row` | `Int32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ReadName` | `Boolean` | `ref String name` | `` |
| `ReadValue` | `JsonToken` | `ref Object value` | `` |
| `SkeepValue` | `JsonToken` | `` | `` |

### `JsonToken` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Json.JsonToken` |
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
      - `Topomatic.FoundationClasses.Json.JsonToken`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ArrayBegin` | `JsonToken` | Yes | `ArrayBegin` | `` |
| `ArrayEnd` | `JsonToken` | Yes | `ArrayEnd` | `` |
| `Boolean` | `JsonToken` | Yes | `Boolean` | `` |
| `Double` | `JsonToken` | Yes | `Double` | `` |
| `Error` | `JsonToken` | Yes | `Error` | `` |
| `Integer` | `JsonToken` | Yes | `Integer` | `` |
| `Null` | `JsonToken` | Yes | `Null` | `` |
| `ObjectBegin` | `JsonToken` | Yes | `ObjectBegin` | `` |
| `ObjectEnd` | `JsonToken` | Yes | `ObjectEnd` | `` |
| `String` | `JsonToken` | Yes | `String` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Error` | `0` |
| `String` | `1` |
| `Integer` | `2` |
| `Double` | `3` |
| `Boolean` | `4` |
| `Null` | `5` |
| `ObjectBegin` | `6` |
| `ObjectEnd` | `7` |
| `ArrayBegin` | `8` |
| `ArrayEnd` | `9` |

**Underlying Type**: `System.Int32`

### `JsonWriter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Json.JsonWriter` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(TextWriter writer)`
- `.ctor(String fullname)`

#### Instance Methods (37)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBoolean` | `Void` | `String name, Boolean value` | `` |
| `AddBoolean` | `Void` | `Boolean value` | `` |
| `AddBoolean` | `Void` | `Boolean value, Boolean newLine` | `` |
| `AddBoolean` | `Void` | `String name, Boolean value, Boolean newLine` | `` |
| `AddDouble` | `Void` | `String name, Double value, Boolean newLine` | `` |
| `AddDouble` | `Void` | `Double value` | `` |
| `AddDouble` | `Void` | `Double value, Boolean newLine` | `` |
| `AddDouble` | `Void` | `String name, Double value` | `` |
| `AddFloat` | `Void` | `String name, Single value, Boolean newLine` | `` |
| `AddFloat` | `Void` | `Single value, Boolean newLine` | `` |
| `AddFloat` | `Void` | `String name, Single value` | `` |
| `AddFloat` | `Void` | `Single value` | `` |
| `AddInteger` | `Void` | `Int32 value` | `` |
| `AddInteger` | `Void` | `Int32 value, Boolean newLine` | `` |
| `AddInteger` | `Void` | `String name, Int32 value, Boolean newLine` | `` |
| `AddInteger` | `Void` | `String name, Int32 value` | `` |
| `AddNull` | `Void` | `Boolean newLine` | `` |
| `AddNull` | `Void` | `String name` | `` |
| `AddNull` | `Void` | `String name, Boolean newLine` | `` |
| `AddNull` | `Void` | `` | `` |
| `AddString` | `Void` | `String name, String value` | `` |
| `AddString` | `Void` | `String name, String value, Boolean newLine` | `` |
| `AddString` | `Void` | `String value` | `` |
| `AddString` | `Void` | `String value, Boolean newLine` | `` |
| `BeginArray` | `Void` | `Boolean newLine` | `` |
| `BeginArray` | `Void` | `String name` | `` |
| `BeginArray` | `Void` | `String name, Boolean newLine` | `` |
| `BeginArray` | `Void` | `` | `` |
| `BeginObject` | `Void` | `Boolean newLine` | `` |
| `BeginObject` | `Void` | `` | `` |
| `BeginObject` | `Void` | `String name, Boolean newLine` | `` |
| `BeginObject` | `Void` | `String name` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndArray` | `Void` | `Boolean newLine` | `` |
| `EndArray` | `Void` | `` | `` |
| `EndObject` | `Void` | `Boolean newLine` | `` |
| `EndObject` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.FoundationClasses.Lisp`

### `BuiltInFuncBase` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.BuiltInFuncBase` |
| **Base Type** | `Topomatic.FoundationClasses.Lisp.LispFunc` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Lisp.LispFunc`
    - `Topomatic.FoundationClasses.Lisp.BuiltInFuncBase`

#### Constructors (1)

- `.ctor(String name, Int32 carity)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EvalWith` | `Object` | `Engine engine, Cell arg, Cell interpEnv` | `` |
| `EvalWithEngine` | `Object` | `Engine engine, Object[] args` | `` |
| `ToString` | `String` | `` | `` |

### `BuiltInFuncBody` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.BuiltInFuncBody` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.FoundationClasses.Lisp.BuiltInFuncBody`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object[] frame, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Object` | `IAsyncResult result` | `` |
| `Invoke` | `Object` | `Object[] frame` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BuiltInFuncBodyEngine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.BuiltInFuncBodyEngine` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.FoundationClasses.Lisp.BuiltInFuncBodyEngine`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Engine engine, Object[] frame, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Object` | `IAsyncResult result` | `` |
| `Invoke` | `Object` | `Engine engine, Object[] frame` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BuiltInFuncEngine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.BuiltInFuncEngine` |
| **Base Type** | `Topomatic.FoundationClasses.Lisp.BuiltInFuncBase` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Lisp.LispFunc`
    - `Topomatic.FoundationClasses.Lisp.BuiltInFuncBase`
      - `Topomatic.FoundationClasses.Lisp.BuiltInFuncEngine`

#### Constructors (1)

- `.ctor(String name, Int32 carity, BuiltInFuncBodyEngine body)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `BuiltInFuncBodyEngine` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EvalWithEngine` | `Object` | `Engine engine, Object[] args` | `` |

### `BuiltInFuncS` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.BuiltInFuncS` |
| **Base Type** | `Topomatic.FoundationClasses.Lisp.BuiltInFuncBase` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Lisp.LispFunc`
    - `Topomatic.FoundationClasses.Lisp.BuiltInFuncBase`
      - `Topomatic.FoundationClasses.Lisp.BuiltInFuncS`

#### Constructors (1)

- `.ctor(String name, Int32 carity, BuiltInFuncBody body)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `BuiltInFuncBody` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EvalWithEngine` | `Object` | `Engine engine, Object[] args` | `` |

### `Cell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.Cell` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object car, Object cdr)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Car` | `Object` | No | `` | `` |
| `Cdr` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `Engine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.Engine` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Scope scope)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Eval` | `Object` | `Object x, Cell env` | `` |
| `EvalFunc` | `Object` | `LispFunc func, Object[] args` | `` |
| `Run` | `Object` | `TextReader script` | `` |
| `WrapFunction` | `Func<Object[] Object>` | `LispFunc func` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `QqExpand` | `Object` | `Object x` | `` |
| `QqQuote` | `Object` | `Object x` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Scope` | `Scope` | No | `` | `` |

### `EvalException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.EvalException` |
| **Base Type** | `Topomatic.FoundationClasses.Lisp.LispException` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.FoundationClasses.Lisp.LispException`
      - `Topomatic.FoundationClasses.Lisp.EvalException`

#### Constructors (2)

- `.ctor(String msg, Object x)`
- `.ctor(String msg, Object x, Boolean quoteString)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `_Exception` | `ToString` |

### `LispException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.LispException` |
| **Base Type** | `System.Exception` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.FoundationClasses.Lisp.LispException`

#### Constructors (2)

- `.ctor(String message)`
- `.ctor(String message, Exception innerException)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Trace` | `List<String>` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Trace` | `List<String>` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LispFunc` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.LispFunc` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Carity` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EvalFrame` | `Void` | `Object[] frame, Engine interp, Cell env` | `` |
| `MakeFrame` | `Object[]` | `Cell arg` | `` |

### `LMath` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.LMath` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Object` | `Object x, Object y` | `` |
| `Compare` | `Int32` | `Object x, Object y` | `` |
| `GetDouble` | `Double` | `Object x` | `` |
| `IsNumber` | `Boolean` | `Object x` | `` |
| `Multiply` | `Object` | `Object x, Object y` | `` |
| `Quotient` | `Object` | `Object x, Object y` | `` |
| `Remainder` | `Object` | `Object x, Object y` | `` |
| `RoundedQuotient` | `Object` | `Object x, Object y` | `` |
| `Subtract` | `Object` | `Object x, Object y` | `` |
| `TryParse` | `Boolean` | `String s, ref Object result` | `` |

#### Nested Types (2)

- `Number` (struct)
- `NumberType` (enum)

### `LUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.LUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CdrCell` | `Cell` | `Cell x` | `` |
| `LFold` | `T` | `T x, Cell j, Func<T Object T> fn` | `` |
| `MapCar` | `Cell` | `Cell list, Func<Object Object> fn` | `` |
| `Str` | `String` | `Object x, Boolean quoteString` | `` |
| `Str` | `String` | `Object x` | `` |

#### Fields (22)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AppendSym` | `Symbol` | Yes | `` | `` |
| `BackQuoteSym` | `Symbol` | Yes | `` | `` |
| `CommaAtSym` | `Symbol` | Yes | `` | `` |
| `CommaSym` | `Symbol` | Yes | `` | `` |
| `CondSym` | `Symbol` | Yes | `` | `` |
| `ConsSym` | `Symbol` | Yes | `` | `` |
| `DotSym` | `Symbol` | Yes | `` | `` |
| `FSym` | `Symbol` | Yes | `` | `` |
| `LambdaSym` | `Symbol` | Yes | `` | `` |
| `LeftParenSym` | `Symbol` | Yes | `` | `` |
| `ListSym` | `Symbol` | Yes | `` | `` |
| `MacroSym` | `Symbol` | Yes | `` | `` |
| `PrognSym` | `Symbol` | Yes | `` | `` |
| `QuasiquoteSym` | `Symbol` | Yes | `` | `` |
| `QuoteSym` | `Symbol` | Yes | `` | `` |
| `RestSym` | `Symbol` | Yes | `` | `` |
| `RightParenSym` | `Symbol` | Yes | `` | `` |
| `SetqSym` | `Symbol` | Yes | `` | `` |
| `SingleQuoteSym` | `Symbol` | Yes | `` | `` |
| `TSym` | `Symbol` | Yes | `` | `` |
| `UnquoteSplicingSym` | `Symbol` | Yes | `` | `` |
| `UnquoteSym` | `Symbol` | Yes | `` | `` |

### `Number` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.LMath+Number` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.FoundationClasses.Lisp.LMath+Number`

#### Constructors (1)

- `.ctor(Object value)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AsDouble` | `Double` | `get` | No | `` |
| `AsInteger` | `Int32` | `get` | No | `` |
| `AsLong` | `Int64` | `get` | No | `` |
| `Type` | `NumberType` | `get` | No | `` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Object` | `Number x, Number y` | `` |
| `Compare` | `Int32` | `Number x, Number y` | `` |
| `Multiply` | `Object` | `Number x, Number y` | `` |
| `Normalize` | `Object` | `Int64 value` | `` |
| `Quotient` | `Object` | `Number x, Number y` | `` |
| `Remainder` | `Object` | `Number x, Number y` | `` |
| `RoundedQuotient` | `Object` | `Number x, Number y` | `` |
| `Subtract` | `Object` | `Number x, Number y` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Value` | `Object` | No | `` | `` |

### `NumberType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.LMath+NumberType` |
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
      - `Topomatic.FoundationClasses.Lisp.LMath+NumberType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Double` | `NumberType` | Yes | `Double` | `` |
| `Int32` | `NumberType` | Yes | `Int32` | `` |
| `Int64` | `NumberType` | Yes | `Int64` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Int32` | `0` |
| `Int64` | `1` |
| `Double` | `2` |

**Underlying Type**: `System.Int32`

### `Reader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.Reader` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(TextReader tr)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Read` | `Object` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EOF` | `Object` | Yes | `` | `` |

### `Scope` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.Scope` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Scope scope)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Object` | `get` | No | `` |
| `Keys` | `IEnumerable<Symbol>` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Contains` | `Boolean` | `Symbol key` | `` |
| `Def` | `Void` | `String name, Int32 carity, BuiltInFuncBody body` | `` |
| `Def` | `Object` | `Symbol key, Object value` | `` |
| `DefEngine` | `Void` | `String name, Int32 carity, BuiltInFuncBodyEngine body` | `` |
| `Remove` | `Boolean` | `Symbol key` | `` |
| `TryGetValue` | `Boolean` | `Symbol key, ref Object value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Global` | `Scope` | Yes | `` | `` |

### `Symbol` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Lisp.Symbol` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsInterned` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `New` | `Symbol` | `String name` | `` |

---
## Namespace: `Topomatic.FoundationClasses.Parallel`

### `Core` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Parallel.Core` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Factory factory)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Invoke` | `Void` | `Action action` | `` |

#### Nested Types (1)

- `Factory` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `Factory` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Parallel.Core+Factory` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 cores)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCore` | `Core` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `WaitAll` | `Void` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Cores` | `Stack<Core>` | No | `` | `` |
| `m_Event` | `ManualResetEvent` | No | `` | `` |
| `m_FreeCores` | `Int32` | No | `` | `` |
| `m_MaxCores` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `Parallel` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Parallel.Parallel` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ForEach` | `Void` | `IEnumerable<T> items, Action<T> action` | `` |

---
## Namespace: `Topomatic.FoundationClasses.Undo`

### `BaseTransactableField`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.BaseTransactableField`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (2)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, T initialize)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InnerValue` | `T` | `get/set` | No | `` |
| `Value` | `T` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `BaseTransactableList`1<T where class>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.BaseTransactableList`1` |
| **Base Type** | `System.Object` |
| **Implements** | `, System.Collections.IEnumerable, , , System.Collections.ICollection, System.Collections.IList` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (3)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, Int32 capacity)`
- `.ctor(ITransactable owner, IEnumerable<T> collection)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `InnerList` | `List<T>` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object value` | `` |
| `Add` | `Void` | `T item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Sort` | `Void` | `` | `` |
| `Sort` | `Void` | `Comparison<T> comparison` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IList` | `System.Collections.IList.get_Item` |
| `IList` | `System.Collections.IList.set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |

### `CreateTransactionEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.CreateTransactionEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.FoundationClasses.Undo.CreateTransactionEventArgs`

#### Constructors (1)

- `.ctor(Transaction transaction)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Transaction` | `Transaction` | `get` | No | `` |

### `CreateTransactionEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.CreateTransactionEventHandler` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.FoundationClasses.Undo.CreateTransactionEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, CreateTransactionEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, CreateTransactionEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FieldChangedEventArgs`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.FieldChangedEventArgs`1` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.FoundationClasses.Undo.FieldChangedEventArgs`1`

#### Constructors (1)

- `.ctor(T oldValue)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `OldValue` | `T` | `get` | No | `` |

### `ICommand` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.ICommand` |
| **Base Type** | `none` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Undo` | `ICommand` | `` | `` |

### `INamedTransactable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.INamedTransactable` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `String caption` | `` |

### `IndexerEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.IndexerEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.FoundationClasses.Undo.IndexerEventArgs`

#### Constructors (1)

- `.ctor(Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |

### `IndexerEventHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.IndexerEventHandler` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.FoundationClasses.Undo.IndexerEventHandler`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Object sender, IndexerEventArgs e, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Void` | `IAsyncResult result` | `` |
| `Invoke` | `Void` | `Object sender, IndexerEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IOwnedCommand` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.IOwnedCommand` |
| **Base Type** | `none` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.Undo.ICommand, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `IrreversibleCommand` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.IrreversibleCommand` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Undo.IStateCommand, Topomatic.FoundationClasses.Undo.ICommand, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanUndo` | `Boolean` | `get` | No | `` |
| `Empty` | `IrreversibleCommand` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Undo` | `ICommand` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStateCommand` | `get_CanUndo` |
| `ICommand` | `Undo` |
| `IDisposable` | `Dispose` |

### `IStateCommand` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.IStateCommand` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ICommand, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanUndo` | `Boolean` | `get` | No | `` |

### `ITransactable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.ITransactable` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

### `ITransaction` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.ITransaction` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.Undo.ICommand, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.FoundationClasses.Undo.ICommand, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IDisposable, Topomatic.FoundationClasses.Undo.ICommand, Topomatic.FoundationClasses.Undo.IStateCommand` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `Item` | `ICommand` | `get` | No | `` |
| `Parent` | `ITransaction` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAllCommands` | `IEnumerable<ICommand>` | `` | `` |
| `Insert` | `Void` | `ICommand item` | `` |

### `ITransactionManager` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.ITransactionManager` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActionIsExecuting` | `Boolean` | `get` | No | `` |
| `CanRedo` | `Boolean` | `get` | No | `` |
| `CanUndo` | `Boolean` | `get` | No | `` |
| `CurrentTransaction` | `ITransaction` | `get` | No | `` |
| `UpdateCount` | `Int32` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetRedoHistory` | `IEnumerable<ITransaction>` | `` | `` |
| `GetUndoHistory` | `IEnumerable<ITransaction>` | `` | `` |
| `PushCommand` | `Void` | `ICommand command` | `` |
| `Redo` | `Void` | `` | `` |
| `Undo` | `Void` | `` | `` |

### `TransactableDictionary`2<TKey where class, TValue where class>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.TransactableDictionary`2` |
| **Base Type** | `System.Object` |
| **Implements** | `, , System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (6)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, Int32 capacity)`
- `.ctor(ITransactable owner, IEqualityComparer<TKey> comparer)`
- `.ctor(ITransactable owner, IDictionary<TKey TValue> dictionary)`
- `.ctor(ITransactable owner, Int32 capacity, IEqualityComparer<TKey> comparer)`
- `.ctor(ITransactable owner, IDictionary<TKey TValue> dictionary, IEqualityComparer<TKey> comparer)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `InnerDictionary` | `Dictionary<TKey TValue>` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `TValue` | `get/set` | No | `` |
| `Keys` | `ICollection<TKey>` | `get` | No | `` |
| `Values` | `ICollection<TValue>` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `KeyValuePair<TKey TValue> item` | `` |
| `Add` | `Void` | `TKey key, TValue value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `KeyValuePair<TKey TValue> item` | `` |
| `ContainsKey` | `Boolean` | `TKey key` | `` |
| `CopyTo` | `Void` | `KeyValuePair<TKey TValue>[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<TKey TValue>>` | `` | `` |
| `Remove` | `Boolean` | `KeyValuePair<TKey TValue> item` | `` |
| `Remove` | `Boolean` | `TKey key` | `` |
| `TryGetValue` | `Boolean` | `TKey key, ref TValue value` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Modify` | `EventHandler` | No | `` |

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
| `IDictionary`2` | `get_Item` |
| `IDictionary`2` | `set_Item` |
| `IDictionary`2` | `get_Keys` |
| `IDictionary`2` | `get_Values` |
| `IDictionary`2` | `ContainsKey` |
| `IDictionary`2` | `Add` |
| `IDictionary`2` | `Remove` |
| `IDictionary`2` | `TryGetValue` |

### `TransactableField`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.TransactableField`1` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.FoundationClasses.Undo.TransactableField`1`

#### Constructors (3)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, T initialize)`
- `.ctor(ITransactable owner, T initialize, EventHandler<FieldChangedEventArgs<T>> change)`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateField` | `TransactableField<T>` | `ITransactable owner, T initialize, Action<FieldChangedEventArgs<T>> change` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler<FieldChangedEventArgs<T>>` | No | `` |

### `TransactableList`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.TransactableList`1` |
| **Base Type** | `` |
| **Implements** | `, System.Collections.IEnumerable, , , System.Collections.ICollection, System.Collections.IList` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.FoundationClasses.Undo.TransactableList`1`

#### Constructors (3)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, Int32 capacity)`
- `.ctor(ITransactable owner, IEnumerable<T> collection)`

#### Events (7)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterInsert` | `IndexerEventHandler` | No | `` |
| `AfterModify` | `IndexerEventHandler` | No | `` |
| `AfterRemove` | `IndexerEventHandler` | No | `` |
| `BeforeInsert` | `IndexerEventHandler` | No | `` |
| `BeforeModify` | `IndexerEventHandler` | No | `` |
| `BeforeRemove` | `IndexerEventHandler` | No | `` |
| `Modify` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Transaction` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.Transaction` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.Undo.ICommand, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.FoundationClasses.Undo.ICommand, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.Undo.ITransaction, System.IDisposable, Topomatic.FoundationClasses.Undo.ICommand, Topomatic.FoundationClasses.Undo.IStateCommand` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String caption)`
- `.ctor(String caption, ITransaction parent)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanUndo` | `Boolean` | `get` | No | `` |
| `Caption` | `String` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ICommand` | `get` | No | `` |
| `Parent` | `ITransaction` | `get` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ICommand item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ICommand item` | `` |
| `CopyTo` | `Void` | `ICommand[] array, Int32 arrayIndex` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetAllCommands` | `IEnumerable<ICommand>` | `` | `` |
| `GetEnumerator` | `IEnumerator<ICommand>` | `` | `` |
| `Insert` | `Void` | `ICommand item` | `` |
| `Remove` | `Boolean` | `ICommand item` | `` |
| `ToString` | `String` | `` | `` |
| `Undo` | `ICommand` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `ITransaction` | `get_Parent` |
| `ITransaction` | `get_Item` |
| `ITransaction` | `get_Caption` |
| `ITransaction` | `Insert` |
| `ITransaction` | `GetAllCommands` |
| `IDisposable` | `Dispose` |
| `ICommand` | `Undo` |
| `IStateCommand` | `get_CanUndo` |

### `TransactionManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Undo.TransactionManager` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactionManager, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 history)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActionIsExecuting` | `Boolean` | `get` | No | `` |
| `CanRedo` | `Boolean` | `get` | No | `` |
| `CanUndo` | `Boolean` | `get` | No | `` |
| `CurrentAction` | `ICommand` | `get/set` | No | `` |
| `CurrentTransaction` | `ITransaction` | `get` | No | `` |
| `HistoryLimit` | `Int32` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `UpdateCount` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `String caption` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `ClearRedo` | `Void` | `` | `` |
| `ClearUndo` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetRedoHistory` | `IEnumerable<ITransaction>` | `` | `` |
| `GetUndoHistory` | `IEnumerable<ITransaction>` | `` | `` |
| `PushCommand` | `Void` | `ICommand command` | `` |
| `Redo` | `Void` | `` | `` |
| `Undo` | `Void` | `` | `` |

#### Events (3)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `CreateTransaction` | `CreateTransactionEventHandler` | No | `` |
| `HistoryChanged` | `EventHandler` | No | `` |
| `RefreshState` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamedTransactable` | `BeginUpdate` |
| `ITransactable` | `Topomatic.FoundationClasses.Undo.ITransactable.get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ITransactionManager` | `get_CanRedo` |
| `ITransactionManager` | `get_CanUndo` |
| `ITransactionManager` | `Clear` |
| `ITransactionManager` | `Redo` |
| `ITransactionManager` | `Undo` |
| `ITransactionManager` | `get_CurrentTransaction` |
| `ITransactionManager` | `PushCommand` |
| `ITransactionManager` | `get_ActionIsExecuting` |
| `ITransactionManager` | `GetUndoHistory` |
| `ITransactionManager` | `GetRedoHistory` |
| `ITransactionManager` | `get_UpdateCount` |
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.FoundationClasses.Utils`

### `FileUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Utils.FileUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanMakeRelativePath` | `Boolean` | `String baseName, String destName` | `` |
| `ExtractFilePathNoDrive` | `String` | `String fileName` | `` |
| `ExtractRelativeFilePath` | `String` | `String baseName, String destName` | `` |
| `ExtractRelativeUriPath` | `String` | `String baseName, String destName` | `` |
| `FindFileExtensionByObjectId` | `String` | `String moniker` | `` |
| `FindFullPath` | `String` | `String baseDirectory, String relativePath` | `` |
| `GetPathRoot` | `String` | `String filename` | `` |
| `IsValidFileName` | `Boolean` | `String fileName` | `` |
| `IsValidPath` | `Boolean` | `String location` | `` |
| `ObjectIdToRelativePath` | `String` | `String basePath, String moniker` | `` |

### `NumberUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Utils.NumberUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CombineHash` | `Int32` | `Int32 a, Int32 b` | `` |

### `StringUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Utils.StringUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompareStringsLogical` | `Int32` | `String x, String y` | `` |
| `ReplaceParameters` | `String` | `String s, IDictionary<String String> parameters` | `` |
| `SafeStringToString` | `String` | `String s` | `` |
| `StringToSafeString` | `String` | `String s` | `` |

---
## Namespace: `Topomatic.FoundationClasses.Vcs`

### `CollectionWrapper`1<T where class>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContext+CollectionWrapper`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |

### `ConflictState` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.ConflictState` |
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
      - `Topomatic.FoundationClasses.Vcs.ConflictState`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Both` | `ConflictState` | Yes | `Both` | `` |
| `Conflict` | `ConflictState` | Yes | `Conflict` | `` |
| `Our` | `ConflictState` | Yes | `Our` | `` |
| `Their` | `ConflictState` | Yes | `Their` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Our` | `0` |
| `Their` | `1` |
| `Both` | `2` |
| `Conflict` | `3` |

**Underlying Type**: `System.Int32`

### `ConflictValue` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.ConflictValue` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.FoundationClasses.Vcs.ConflictValue`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Conflicts` | `List<KeyValuePair<Int32 Int32>>` | No | `` | `` |
| `State` | `ConflictState` | No | `` | `` |

### `DictionaryWrapper`2<T where class, U where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContext+DictionaryWrapper`2` |
| **Base Type** | `System.Object` |
| **Implements** | `, System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Contains` | `Boolean` | `T key` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<T U>>` | `` | `` |
| `TryGetValue` | `Boolean` | `T key, ref U value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `EqualityValue`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.EqualityValue`1` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.FoundationClasses.Vcs.EqualityValue`1`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `T a, T b, Boolean isRemote, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Boolean` | `IAsyncResult result` | `` |
| `Invoke` | `Boolean` | `T a, T b, Boolean isRemote` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MergedDictionary`2<T where class, U where class>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContext+MergedDictionary`2` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `U` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `MergeResult merge, T key, U value` | `` |
| `TryGetValue` | `Boolean` | `MergeResult merge, T key, ref U value` | `` |

### `MergeResult` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.MergeResult` |
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
      - `Topomatic.FoundationClasses.Vcs.MergeResult`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Conflict` | `MergeResult` | Yes | `Conflict` | `` |
| `HasLocal` | `MergeResult` | Yes | `HasLocal` | `` |
| `HasOrigin` | `MergeResult` | Yes | `HasOrigin` | `` |
| `HasRemote` | `MergeResult` | Yes | `HasRemote` | `` |
| `None` | `MergeResult` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `HasOrigin` | `16` |
| `HasLocal` | `32` |
| `HasRemote` | `64` |
| `Conflict` | `128` |

**Underlying Type**: `System.Int32`

### `MergeValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.MergeValue` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Index` | `Int32` | No | `` | `` |
| `OurOps` | `List<OperationValue>` | No | `` | `` |
| `TheirOps` | `List<OperationValue>` | No | `` | `` |

### `NeedlemanWunschAlgorithm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.NeedlemanWunschAlgorithm` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertOperations` | `List<OperationValue>` | `IList<T> a, IList<T> b, Func<T T Boolean> equality` | `` |
| `ConvertOperations` | `List<OperationValue>` | `IList<T> a, IList<T> b` | `` |
| `PrepareOperations` | `List<OperationValue>` | `Int32 mstart, Int32 nstart, Int32 mlength, Int32 nlength, Func<Int32 Int32 Boolean> equals` | `` |
| `ThreeWayCompare` | `List<MergeValue>` | `IList<T> baseValue, IList<T> ourValue, IList<T> theirValue` | `` |
| `ThreeWayCompare` | `List<MergeValue>` | `IList<T> baseValue, IList<T> ourValue, IList<T> theirValue, EqualityValue<T> equality` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompareOperations` | `ConflictValue` | `List<OperationValue> ourOperations, List<OperationValue> theirOperations` | `` |
| `PrepareThreeWayCompare` | `List<MergeValue>` | `List<OperationValue> ourOperations, List<OperationValue> theirOperations` | `` |

### `Operation` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.Operation` |
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
      - `Topomatic.FoundationClasses.Vcs.Operation`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EqualsAB` | `Operation` | Yes | `EqualsAB` | `` |
| `InsertFromB` | `Operation` | Yes | `InsertFromB` | `` |
| `RemoveFromA` | `Operation` | Yes | `RemoveFromA` | `` |
| `ReplaceAB` | `Operation` | Yes | `ReplaceAB` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `InsertFromB` | `0` |
| `RemoveFromA` | `1` |
| `ReplaceAB` | `2` |
| `EqualsAB` | `3` |

**Underlying Type**: `System.Int32`

### `OperationValue` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.OperationValue` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.FoundationClasses.Vcs.OperationValue`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IndexA` | `Int32` | No | `` | `` |
| `IndexB` | `Int32` | No | `` | `` |
| `Operation` | `Operation` | No | `` | `` |

### `Value` (struct)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.Value` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.FoundationClasses.Vcs.Value`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Int32` | `get/set` | No | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Base` | `Int32` | No | `` | `` |
| `Our` | `Int32` | No | `` | `` |
| `State` | `MergeResult` | No | `` | `` |
| `Their` | `Int32` | No | `` | `` |

### `Value`1<T where class>` (struct)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContext+Value`1` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.FoundationClasses.Vcs.VcsContext+Value`1`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HasConflict` | `Boolean` | `get` | No | `` |
| `HasLocal` | `Boolean` | `get` | No | `` |
| `HasOrigin` | `Boolean` | `get` | No | `` |
| `HasRemote` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Local` | `T` | No | `` | `` |
| `Origin` | `T` | No | `` | `` |
| `Remote` | `T` | No | `` | `` |
| `State` | `MergeResult` | No | `` | `` |

### `VcsContext` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContext` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(LogWriter writer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Writer` | `LogWriter` | `get` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AppendParameter` | `Void` | `String key, Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Equals` | `Boolean` | `IStgSerializable a, IStgSerializable b` | `` |
| `LogChange` | `Void` | `MergeResult state, String message, Object prms` | `` |
| `LogRemove` | `Void` | `MergeResult state, String message, Object prms` | `` |
| `MergeValue` | `Value<T>` | `T origin, T local, T remote, VcsEqualityValue<T> equals` | `` |
| `MergeValue` | `Boolean` | `T origin, T local, T remote, VcsContextResolver<T> resolver` | `` |
| `MergeValues` | `Void` | `IList<T> origin, IList<T> local, IList<T> remote, VcsEqualityValue<T> equality, Action<Value<Int32>> append, Action<MergeResult Int32> remove` | `` |
| `MergeValues` | `Void` | `IDictionary<T U> origin, IDictionary<T U> local, IDictionary<T U> remote, VcsEqualityValue<U> equals, Action<T Value<U>> append, Action<MergeResult T> remove` | `` |
| `MergeValues` | `Void` | `DictionaryWrapper<T U> origin, DictionaryWrapper<T U> local, DictionaryWrapper<T U> remote, VcsEqualityValue<U> equals, Action<T Value<U>> append, Action<MergeResult T> remove` | `` |
| `MergeValues` | `Void` | `IList<T> local, IList<T> remote, Func<T T Boolean> equality, Action<Value<Int32>> resolve` | `` |
| `MergeValues` | `Void` | `CollectionWrapper<T> origin, CollectionWrapper<T> local, CollectionWrapper<T> remote, VcsEqualityValue<T> equality, Action<Value<Int32>> append, Action<MergeResult Int32> remove` | `` |
| `MergeValues` | `Boolean` | `CollectionWrapper<T> origin, CollectionWrapper<T> local, CollectionWrapper<T> remote, VcsContextResolver<T> resolver` | `` |
| `MergeValues` | `Boolean` | `IStgSerializable origin, IStgSerializable local, IStgSerializable remote, IStgSerializable result, String caption` | `` |
| `MergeValues` | `Boolean` | `BasicEditedItemsTable origin, BasicEditedItemsTable local, BasicEditedItemsTable remote, BasicEditedItemsTable result, Func<Value<T> T> createKey, String caption` | `` |
| `MergeValues` | `Boolean` | `IList<T> origin, IList<T> local, IList<T> remote, VcsContextResolver<T> resolver` | `` |
| `TryGetParameter` | `Boolean` | `String key, ref Object value` | `` |
| `TryGetParameter` | `Boolean` | `String key, ref T value` | `` |

#### Nested Types (4)

- `CollectionWrapper`1` (abstract class)
- `DictionaryWrapper`2` (abstract class)
- `MergedDictionary`2` (class)
- `Value`1` (struct)

### `VcsContextCollecitonItemResolver`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContextCollecitonItemResolver`1` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.FoundationClasses.Vcs.VcsContextCollecitonItemResolver`1`

#### Constructors (4)

- `.ctor(Action<T> apply, Func<T String> message)`
- `.ctor(Action<T> apply, VcsEqualityValue<T> equals, Func<T String> message)`
- `.ctor(Action<T> apply, Action<T> remove, VcsEqualityValue<T> equals, Func<T String> message)`
- `.ctor(Action<T> apply, Action<T> remove, VcsEqualityValue<T> equals, Func<T String> message, Func<T Object> prms)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Message` | `String` | `get` | No | `` |
| `ProviderPrms` | `Object` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Append` | `Void` | `T value` | `` |
| `Equals` | `Boolean` | `T a, T b, MergeResult state` | `` |
| `Refresh` | `Void` | `T value` | `` |
| `Remove` | `Void` | `T value` | `` |

### `VcsContextResolver`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContextResolver`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Message` | `String` | `get` | No | `` |
| `ProviderPrms` | `Object` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Append` | `Void` | `T value` | `` |
| `Equals` | `Boolean` | `T a, T b, MergeResult state` | `` |
| `Remove` | `Void` | `T value` | `` |

### `VcsContextValueResolver`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsContextValueResolver`1` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.FoundationClasses.Vcs.VcsContextValueResolver`1`

#### Constructors (3)

- `.ctor(String message, Action<T> apply)`
- `.ctor(String message, Action<T> apply, VcsEqualityValue<T> equals)`
- `.ctor(String message, Action<T> apply, VcsEqualityValue<T> equals, Object prms)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Message` | `String` | `get` | No | `` |
| `ProviderPrms` | `Object` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Append` | `Void` | `T value` | `` |
| `Equals` | `Boolean` | `T a, T b, MergeResult state` | `` |
| `Remove` | `Void` | `T value` | `` |

### `VcsEqualityValue`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.FoundationClasses.Vcs.VcsEqualityValue`1` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.FoundationClasses.Vcs.VcsEqualityValue`1`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `T a, T b, MergeResult state, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Boolean` | `IAsyncResult result` | `` |
| `Invoke` | `Boolean` | `T a, T b, MergeResult state` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.UTI`

### `DialogResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.DialogResult` |
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
      - `Topomatic.UTI.DialogResult`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Abort` | `DialogResult` | Yes | `Abort` | `` |
| `Cancel` | `DialogResult` | Yes | `Cancel` | `` |
| `Ignore` | `DialogResult` | Yes | `Ignore` | `` |
| `No` | `DialogResult` | Yes | `No` | `` |
| `None` | `DialogResult` | Yes | `None` | `` |
| `OK` | `DialogResult` | Yes | `OK` | `` |
| `Retry` | `DialogResult` | Yes | `Retry` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `DialogResult` | Yes | `Yes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `OK` | `1` |
| `Cancel` | `2` |
| `Abort` | `3` |
| `Retry` | `4` |
| `Ignore` | `5` |
| `Yes` | `6` |
| `No` | `7` |

**Underlying Type**: `System.Int32`

### `DialogStyle` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.DialogStyle` |
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
      - `Topomatic.UTI.DialogStyle`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AutoCommit` | `DialogStyle` | Yes | `AutoCommit` | `` |
| `AutoRallback` | `DialogStyle` | Yes | `AutoRallback` | `` |
| `CloseButton` | `DialogStyle` | Yes | `CloseButton` | `` |
| `MaximizeButton` | `DialogStyle` | Yes | `MaximizeButton` | `` |
| `MinimizeButton` | `DialogStyle` | Yes | `MinimizeButton` | `` |
| `Resizable` | `DialogStyle` | Yes | `Resizable` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `MinimizeButton` | `1` |
| `MaximizeButton` | `2` |
| `CloseButton` | `4` |
| `Resizable` | `8` |
| `AutoCommit` | `16` |
| `AutoRallback` | `32` |

**Underlying Type**: `System.Int32`

### `EditBoxStyle` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.EditBoxStyle` |
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
      - `Topomatic.UTI.EditBoxStyle`

#### Fields (15)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AllDecimal` | `EditBoxStyle` | Yes | `AllDecimal` | `` |
| `AllInteger` | `EditBoxStyle` | Yes | `AllInteger` | `` |
| `Borderless` | `EditBoxStyle` | Yes | `Borderless` | `` |
| `Decimal` | `EditBoxStyle` | Yes | `Decimal` | `` |
| `Integer` | `EditBoxStyle` | Yes | `Integer` | `` |
| `Lower` | `EditBoxStyle` | Yes | `Lower` | `` |
| `Multiline` | `EditBoxStyle` | Yes | `Multiline` | `` |
| `Negative` | `EditBoxStyle` | Yes | `Negative` | `` |
| `Password` | `EditBoxStyle` | Yes | `Password` | `` |
| `Positive` | `EditBoxStyle` | Yes | `Positive` | `` |
| `Readonly` | `EditBoxStyle` | Yes | `Readonly` | `` |
| `Searchbox` | `EditBoxStyle` | Yes | `Searchbox` | `` |
| `Upper` | `EditBoxStyle` | Yes | `Upper` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Zero` | `EditBoxStyle` | Yes | `Zero` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Multiline` | `1` |
| `Borderless` | `2` |
| `Readonly` | `4` |
| `Password` | `8` |
| `Upper` | `16` |
| `Lower` | `32` |
| `Searchbox` | `64` |
| `Positive` | `1024` |
| `Negative` | `2048` |
| `Zero` | `4096` |
| `Integer` | `8192` |
| `AllInteger` | `15360` |
| `Decimal` | `16384` |
| `AllDecimal` | `23552` |

**Underlying Type**: `System.Int32`

### `ITextHolder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.ITextHolder` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Text` | `String` | `get` | No | `` |

### `IUTIFont` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.IUTIFont` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Size` | `Single` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Measure` | `Single` | `String s, UTIFontStyle style, Single viewScaling` | `` |

### `IUTIGraphics2dRenderable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.IUTIGraphics2dRenderable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Render` | `Void` | `UTIGraphics2d g` | `` |

### `IUTIIcon` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.IUTIIcon` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `IUTILayout` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.IUTILayout` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.UTI.IUTIView` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Factory` | `UTIViewFactory` | `get` | No | `` |
| `Item` | `IUTIView` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `IUTIView view` | `` |
| `Clear` | `Void` | `` | `` |
| `IndexOf` | `Int32` | `IUTIView view` | `` |
| `Remove` | `Boolean` | `IUTIView view` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

### `IUTILayoutEngine` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.IUTILayoutEngine` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Applay` | `Void` | `IUTIView view, Single x, Single y, Single width, Single height, Boolean visible, Boolean enable` | `` |

### `IUTIResources` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIViewFactory+IUTIResources` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Icon` | `IUTIIcon` | `String id` | `` |
| `Open` | `Stream` | `String uri` | `` |

### `IUTITheme` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.IUTITheme` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AccentColor` | `Color` | `get` | No | `` |
| `BackgroundColor` | `Color` | `get` | No | `` |
| `BorderColor` | `Color` | `get` | No | `` |
| `ContentColor` | `Color` | `get` | No | `` |
| `Font` | `IUTIFont` | `get` | No | `` |
| `ForegroundColor` | `Color` | `get` | No | `` |
| `GridSize` | `Single` | `get` | No | `` |
| `ScreenScaling` | `Single` | `get` | No | `` |

### `IUTIView` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.IUTIView` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Controller` | `UTIViewController` | `get` | No | `` |
| `Enable` | `Boolean` | `get` | No | `` |
| `Height` | `Single` | `get` | No | `` |
| `Parent` | `IUTILayout` | `get` | No | `` |
| `Theme` | `IUTITheme` | `get` | No | `` |
| `Visible` | `Boolean` | `get` | No | `` |
| `Width` | `Single` | `get` | No | `` |
| `X` | `Single` | `get` | No | `` |
| `Y` | `Single` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `NotifyChanged` | `Void` | `String id, EventArgs e` | `` |

### `LayoutInformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIAbstractLayoutController+LayoutInformation` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `LayoutInformation` | Yes | `` | `` |

### `LayoutInformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIToolbar+LayoutInformation` |
| **Base Type** | `Topomatic.UTI.UTIAbstractLayoutController+LayoutInformation` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIAbstractLayoutController+LayoutInformation`
    - `Topomatic.UTI.UTIToolbar+LayoutInformation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Align` | `Boolean` | `get/set` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Max` | `UTIDimension` | `get/set` | No | `` |
| `Min` | `UTIDimension` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |
| `Width` | `UTIDimension` | `get/set` | No | `` |

### `LayoutInformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIStack+LayoutInformation` |
| **Base Type** | `Topomatic.UTI.UTIAbstractLayoutController+LayoutInformation` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIAbstractLayoutController+LayoutInformation`
    - `Topomatic.UTI.UTIStack+LayoutInformation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dock` | `UTIStackDocking` | No | `` | `` |
| `Enable` | `Boolean` | No | `` | `` |
| `Height` | `UTIDimension` | No | `` | `` |
| `Max` | `UTISize` | No | `` | `` |
| `Min` | `UTISize` | No | `` | `` |
| `Padding` | `UTIPadding` | No | `` | `` |
| `Visible` | `Boolean` | No | `` | `` |
| `Width` | `UTIDimension` | No | `` | `` |

### `TextChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.TextChangedEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.UTI.TextChangedEventArgs`

#### Constructors (1)

- `.ctor(ITextHolder holder)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Accept` | `Boolean` | `get/set` | No | `` |
| `Holder` | `ITextHolder` | `get` | No | `` |

### `UTIAbstractButtonController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIAbstractButtonController` |
| **Base Type** | `Topomatic.UTI.UTIViewController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractButtonController`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetButtonType` | `UTIButtonType` | `` | `` |
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |
| `GetTitle` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ButtonTypeEvent` | `String` | Yes | `"ButtonType"` | `` |
| `TitleEvent` | `String` | Yes | `"Title"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIAbstractEditBoxController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIAbstractEditBoxController` |
| **Base Type** | `Topomatic.UTI.UTIViewController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractEditBoxController`

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEditBoxStyle` | `EditBoxStyle` | `` | `` |
| `GetEditSize` | `UTIDimension` | `` | `` |
| `GetLabel` | `String` | `` | `` |
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |
| `GetTabOrder` | `Int32` | `` | `` |
| `GetText` | `String` | `` | `` |
| `OnTextChanged` | `Void` | `TextChangedEventArgs e` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EditBoxStyleEvent` | `String` | Yes | `"EditBoxStyle"` | `` |
| `EditSizeEvent` | `String` | Yes | `"EditSize"` | `` |
| `LabelEvent` | `String` | Yes | `"Label"` | `` |
| `PreferredEditWidth` | `UTIDimension` | Yes | `` | `` |
| `TabOrderEvent` | `String` | Yes | `"TabOrder"` | `` |
| `TextEvent` | `String` | Yes | `"Text"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIAbstractLayoutController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIAbstractLayoutController` |
| **Base Type** | `Topomatic.UTI.UTIViewController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractLayoutController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Margin` | `UTIPadding` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Object obj` | `` |
| `CreateLayoutInformation` | `LayoutInformation` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `LayoutContent` | `Void` | `IUTILayoutEngine engine` | `` |
| `OnAddView` | `Void` | `EventArgs e` | `` |
| `OnRemoveView` | `Void` | `EventArgs e` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MarginEvent` | `String` | Yes | `"Margin"` | `` |

#### Nested Types (1)

- `LayoutInformation` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `UTIAbstractToolButtonController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIAbstractToolButtonController` |
| **Base Type** | `Topomatic.UTI.UTIViewController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractToolButtonController`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetIcon` | `IUTIIcon` | `` | `` |
| `GetNeighbors` | `Void` | `ref UTIViewController left, ref UTIViewController right` | `` |
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIButtonController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIButtonController` |
| **Base Type** | `Topomatic.UTI.UTIAbstractButtonController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractButtonController`
      - `Topomatic.UTI.UTIButtonController`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String title)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ButtonType` | `UTIButtonType` | `get/set` | No | `` |
| `Title` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetButtonType` | `UTIButtonType` | `` | `` |
| `GetTitle` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIButtonType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIButtonType` |
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
      - `Topomatic.UTI.UTIButtonType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Destructive` | `UTIButtonType` | Yes | `Destructive` | `` |
| `Primary` | `UTIButtonType` | Yes | `Primary` | `` |
| `Secondary` | `UTIButtonType` | Yes | `Secondary` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Primary` | `0` |
| `Secondary` | `1` |
| `Destructive` | `2` |

**Underlying Type**: `System.Int32`

### `UTIDialog` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIDialog` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `UTIStack` | `get` | No | `` |
| `Cancel` | `UTIButtonController` | `get` | No | `` |
| `Dialog` | `UTIDialogController` | `get` | No | `` |
| `Ok` | `UTIButtonController` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `ShowDialog` | `DialogResult` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `UTIDialogController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIDialogController` |
| **Base Type** | `Topomatic.UTI.UTIStack` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractLayoutController`
      - `Topomatic.UTI.UTIStack`
        - `Topomatic.UTI.UTIDialogController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DialogStyle` | `DialogStyle` | `get/set` | No | `` |
| `Max` | `UTISize` | `get/set` | No | `` |
| `Min` | `UTISize` | `get/set` | No | `` |
| `Title` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `Boolean` | `` | `` |
| `Rallback` | `Boolean` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DialogStyleEvent` | `String` | Yes | `"DialogStyle"` | `` |
| `TitleEvent` | `String` | Yes | `"Title"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIDimension` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIDimension` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.UTI.UTIDimension`

#### Constructors (2)

- `.ctor(Single value)`
- `.ctor(Single value, UTIDimensionUnit units)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Empty` | `Boolean` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Pixel` | `Single` | `IUTIView view, Single size` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Units` | `UTIDimensionUnit` | No | `` | `` |
| `Value` | `Single` | No | `` | `` |

### `UTIDimensionUnit` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIDimensionUnit` |
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
      - `Topomatic.UTI.UTIDimensionUnit`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Em` | `UTIDimensionUnit` | Yes | `Em` | `` |
| `Grid` | `UTIDimensionUnit` | Yes | `Grid` | `` |
| `Percent` | `UTIDimensionUnit` | Yes | `Percent` | `` |
| `Pixel` | `UTIDimensionUnit` | Yes | `Pixel` | `` |
| `Point` | `UTIDimensionUnit` | Yes | `Point` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Point` | `0` |
| `Pixel` | `1` |
| `Percent` | `2` |
| `Em` | `3` |
| `Grid` | `4` |

**Underlying Type**: `System.Int32`

### `UTIExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CoreEnable` | `Boolean` | `IUTIView view` | `Extension` |
| `CoreVisible` | `Boolean` | `IUTIView view` | `Extension` |
| `Darker` | `Color` | `Color color, Single percent` | `Extension` |
| `Find` | `UTIViewController` | `IUTIView view, String id` | `Extension` |
| `HSLtoRGB` | `Color` | `Double hue, Double saturation, Double luminance` | `` |
| `Inflate` | `UTIViewController` | `UTIViewFactory factory, String uri` | `Extension` |
| `IsDarkTheme` | `Boolean` | `IUTITheme theme` | `Extension` |
| `Lighter` | `Color` | `Color color, Single percent` | `Extension` |

### `UTIFontStyle` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIFontStyle` |
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
      - `Topomatic.UTI.UTIFontStyle`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bold` | `UTIFontStyle` | Yes | `Bold` | `` |
| `Italic` | `UTIFontStyle` | Yes | `Italic` | `` |
| `Regular` | `UTIFontStyle` | Yes | `Regular` | `` |
| `Strikeout` | `UTIFontStyle` | Yes | `Strikeout` | `` |
| `Underline` | `UTIFontStyle` | Yes | `Underline` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Regular` | `0` |
| `Bold` | `1` |
| `Italic` | `2` |
| `Underline` | `4` |
| `Strikeout` | `8` |

**Underlying Type**: `System.Int32`

### `UTIGraphics2d` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIGraphics2d` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `Color color` | `` |
| `DrawIcon` | `Void` | `IUTIIcon icon, Int32 size, RectangleF rectangle` | `` |
| `DrawRectangle` | `Void` | `Color color, Single width, RectangleF rectangle` | `` |
| `DrawRectangle` | `Void` | `Color color, Single width, Rectangle rectangle` | `` |
| `DrawRectangleRound` | `Void` | `Color color, Single width, Rectangle rectangle, Int32 tl, Int32 tr, Int32 bl, Int32 br` | `` |
| `DrawRectangleRound` | `Void` | `Color color, Single width, RectangleF rectangle, Single tl, Single tr, Single bl, Single br` | `` |
| `FillRectangle` | `Void` | `Color color, Rectangle rectangle` | `` |
| `FillRectangle` | `Void` | `Color color, RectangleF rectangle` | `` |
| `FillRectangleRound` | `Void` | `Color color, RectangleF rectangle, Single tl, Single tr, Single bl, Single br` | `` |
| `FillRectangleRound` | `Void` | `Color color, Rectangle rectangle, Int32 tl, Int32 tr, Int32 bl, Int32 br` | `` |

### `UTIPadding` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIPadding` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.UTI.UTIPadding`

#### Constructors (2)

- `.ctor(UTIDimension all)`
- `.ctor(UTIDimension left, UTIDimension top, UTIDimension right, UTIDimension bottom)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `UTIDimension` | No | `` | `` |
| `Left` | `UTIDimension` | No | `` | `` |
| `Right` | `UTIDimension` | No | `` | `` |
| `Top` | `UTIDimension` | No | `` | `` |

### `UTIPointerEvent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIPointerEvent` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.UTI.UTIPointerEvent`

#### Constructors (1)

- `.ctor(UTIPointerType type, Single x, Single y)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PointerType` | `UTIPointerType` | `get` | No | `` |
| `Prevented` | `Boolean` | `get` | No | `` |
| `X` | `Single` | `get` | No | `` |
| `Y` | `Single` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PreventDefault` | `Void` | `` | `` |

### `UTIPointerType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIPointerType` |
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
      - `Topomatic.UTI.UTIPointerType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MouseLeft` | `UTIPointerType` | Yes | `MouseLeft` | `` |
| `MouseMiddle` | `UTIPointerType` | Yes | `MouseMiddle` | `` |
| `MouseRight` | `UTIPointerType` | Yes | `MouseRight` | `` |
| `None` | `UTIPointerType` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `MouseLeft` | `1` |
| `MouseRight` | `2` |
| `MouseMiddle` | `3` |

**Underlying Type**: `System.Int32`

### `UTISize` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTISize` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.UTI.UTISize`

#### Constructors (2)

- `.ctor(UTIDimension all)`
- `.ctor(UTIDimension width, UTIDimension height)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Height` | `UTIDimension` | No | `` | `` |
| `Width` | `UTIDimension` | No | `` | `` |

### `UTIStack` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIStack` |
| **Base Type** | `Topomatic.UTI.UTIAbstractLayoutController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractLayoutController`
      - `Topomatic.UTI.UTIStack`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateLayoutInformation` | `LayoutInformation` | `` | `` |
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |
| `LayoutContent` | `Void` | `IUTILayoutEngine engine` | `` |

#### Nested Types (2)

- `LayoutInformation` (class)
- `UTIStackDocking` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIStackDocking` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIStack+UTIStackDocking` |
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
      - `Topomatic.UTI.UTIStack+UTIStackDocking`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `UTIStackDocking` | Yes | `Bottom` | `` |
| `Fill` | `UTIStackDocking` | Yes | `Fill` | `` |
| `Left` | `UTIStackDocking` | Yes | `Left` | `` |
| `Right` | `UTIStackDocking` | Yes | `Right` | `` |
| `Top` | `UTIStackDocking` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Top` | `0` |
| `Left` | `1` |
| `Right` | `2` |
| `Bottom` | `3` |
| `Fill` | `4` |

**Underlying Type**: `System.Int32`

### `UTIToolbar` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIToolbar` |
| **Base Type** | `Topomatic.UTI.UTIAbstractLayoutController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractLayoutController`
      - `Topomatic.UTI.UTIToolbar`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateLayoutInformation` | `LayoutInformation` | `` | `` |
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |
| `LayoutContent` | `Void` | `IUTILayoutEngine engine` | `` |

#### Nested Types (1)

- `LayoutInformation` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIToolButton` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIToolButton` |
| **Base Type** | `Topomatic.UTI.UTIAbstractToolButtonController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIAbstractToolButtonController`
      - `Topomatic.UTI.UTIToolButton`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String icon)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Icon` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetIcon` | `IUTIIcon` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIToolSeparator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIToolSeparator` |
| **Base Type** | `Topomatic.UTI.UTIViewController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTIToolSeparator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTITreeViewController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTITreeViewController` |
| **Base Type** | `Topomatic.UTI.UTIViewController` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.UTI.UTIViewController`
    - `Topomatic.UTI.UTITreeViewController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UTIViewController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIViewController` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get/set` | No | `` |
| `Layout` | `LayoutInformation` | `get/set` | No | `` |
| `OverallScale` | `Single` | `get` | No | `` |
| `View` | `IUTIView` | `get/set` | No | `` |
| `ViewScaling` | `Single` | `get` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Object obj` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetPrefferedHeight` | `Single` | `Single available` | `` |
| `GetPrefferedWidth` | `Single` | `Single available` | `` |
| `OnAttachView` | `Void` | `EventArgs e` | `` |
| `OnEnableChanged` | `Void` | `EventArgs e` | `` |
| `OnPointerClick` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerDoubleClick` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerDown` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerEnter` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerHover` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerLeave` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerLongClick` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerMove` | `Void` | `UTIPointerEvent e` | `` |
| `OnPointerUp` | `Void` | `UTIPointerEvent e` | `` |
| `OnPositionChanged` | `Void` | `EventArgs e` | `` |
| `OnSizeChanged` | `Void` | `EventArgs e` | `` |
| `OnVisibleChanged` | `Void` | `EventArgs e` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LayoutEvent` | `String` | Yes | `"Layout"` | `` |
| `ViewScalingEvent` | `String` | Yes | `"ViewScaling"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `UTIViewFactory` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.UTI.UTIViewFactory` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Resources` | `IUTIResources` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloseModal` | `Void` | `UTIDialogController controller, DialogResult result` | `` |
| `Create` | `IUTIView` | `UTIViewController controller` | `` |
| `DisplayModal` | `DialogResult` | `UTIDialogController controller` | `` |
| `InvokeDelayed` | `Int64` | `Int32 milliseconds, Action callback, Boolean regular, Boolean ui` | `` |
| `RevokeDelayed` | `Boolean` | `Int64 id` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `System` | `UTIViewFactory` | Yes | `` | `` |

#### Nested Types (1)

- `IUTIResources` (interface)

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 163 |
| **Classes** | 67 |
| **Interfaces** | 40 |
| **Enums** | 15 |
| **Structs** | 8 |
| **Abstract Classes** | 23 |
| **Static Classes** | 10 |
| **Total Methods** | 526 |
| **Total Properties** | 191 |
| **Total Fields** | 184 |
| **Total Events** | 14 |
| **Total Constructors** | 127 |
| **Nested Types** | 12 |
| **Extension Methods** | 0 |


