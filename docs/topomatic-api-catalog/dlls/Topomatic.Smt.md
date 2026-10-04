# Topomatic.Smt

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Smt` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Smt.dll` |

---
## Namespace: `Topomatic.Smt`

### `DataSetModifyEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.DataSetModifyEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Smt.DataSetModifyEventArgs`

#### Constructors (1)

- `.ctor(SemanticNode node, Object oldValue, Object newValue)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `NewValue` | `Object` | `get` | No | `` |
| `Node` | `SemanticNode` | `get` | No | `` |
| `OldValue` | `Object` | `get` | No | `` |

### `SemanticConflictResolver` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticConflictResolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResolveLibraryConflict` | `SemanticLibrary` | `SemanticLibrary origin, SemanticLibrary local, SemanticLibrary remote, LogWriter writer` | `` |
| `ResolveLibrarySetConflict` | `SemanticLibrarySet` | `String origin, String local, String remote, LogWriter writer` | `` |

### `SemanticDataHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticDataHolder` |
| **Base Type** | `System.Object` |
| **Implements** | `System.ICloneable, System.IEquatable`1[[Topomatic.Smt.SemanticDataHolder, Topomatic.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SemanticDataHolder other` | `` |
| `Clear` | `Void` | `` | `` |
| `Clone` | `Object` | `` | `` |
| `Equals` | `Boolean` | `SemanticDataHolder other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `IStgArray stgArray` | `` |
| `LoadFromStream` | `Void` | `BinaryReader reader` | `` |
| `LoadFromXml` | `Void` | `XmlElement element` | `` |
| `SaveToStg` | `Void` | `IStgArray stgArray` | `` |
| `SaveToStream` | `Void` | `BinaryWriter writer` | `` |
| `SaveToXml` | `Void` | `XmlElement element` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `Clone` |
| `IEquatable`1` | `Equals` |

### `SemanticDataSet` (class)

**Attributes**: [DefaultMember, PropertyProvider]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticDataSet` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `Keys` | `ICollection<Int32>` | `get` | No | `` |
| `Root` | `SemanticRootNode` | `get` | No | `` |
| `TaggedValues` | `ICollection<TagedValue>` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `Values` | `ICollection<Object>` | `get` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `ContainsKey` | `Boolean` | `Int32 key` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetAllValues` | `IEnumerable<Object>` | `String tag` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<Int32 Object>>` | `` | `` |
| `GetStringTags` | `Void` | `IDictionary<String String> dictionary` | `` |
| `GetTags` | `Void` | `IDictionary<String Object> dictionary` | `` |
| `GetVisibleProperties` | `IEnumerable<KeyValuePair<String String>>` | `` | `` |
| `GetVisiblePropertiesWithTags` | `IEnumerable<TagedValue>` | `` | `` |
| `TryGetGuid` | `Boolean` | `String tag, ref Guid guid` | `` |
| `TryGetHandle` | `Boolean` | `String tag, ref Int32 handle` | `` |
| `TryGetNode` | `Boolean` | `String tag, ref SemanticNode node` | `` |
| `TryGetNode` | `Boolean` | `Int32 key, ref SemanticNode node` | `` |
| `TryGetValue` | `Boolean` | `String tag, ref Object value, ref PropertyTypeConverter converter` | `` |
| `TryGetValue` | `Boolean` | `String tag, ref Object value` | `` |
| `TryGetValue` | `Boolean` | `Int32 key, ref Object value` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Modify` | `EventHandler<DataSetModifyEventArgs>` | No | `` |

#### Nested Types (1)

- `TagedValue` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ITransactable` | `get_TransactionManager` |

### `SemanticDataStyleProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `SemanticDependencyProperty` (class)

**Attributes**: [PropertyProvider]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticDependencyProperty` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Smt.SemanticDependencyProperty`

#### Constructors (2)

- `.ctor(Double value)`
- `.ctor(Object owner, Double value)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Constant` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `Multiplier` | `SemanticDependencyProperty` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Randomize` | `Double` | `get/set` | No | `PropertyTypeConverter` |
| `Summand` | `SemanticDependencyProperty` | `get` | No | `` |
| `Tag` | `String` | `get/set` | No | `PropertyEditor` |
| `Value` | `Double` | `get/set` | No | `PropertyTypeConverter` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SemanticDependencyProperty source` | `` |
| `Clone` | `Object` | `` | `` |
| `GetValue` | `Double` | `SemanticDataSet semantic, IDictionary<String Object> parameters` | `` |
| `GetValue` | `Double` | `IDictionary<String Object> parameters` | `` |
| `GetValue` | `Double` | `IDictionary<String String> parameters` | `` |
| `GetValue` | `Double` | `SemanticDataSet semantic` | `` |
| `LoadFromStg` | `Void` | `StgNode node, Double defaultValue` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node, Double defaultValue` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetPositiveValue` | `Boolean` | `IDictionary<String Object> parameters, ref Double value` | `` |
| `TryGetPositiveValue` | `Boolean` | `SemanticDataSet semantic, ref Double value` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ICloneable` | `Clone` |

### `SemanticDoubleNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticDoubleNode` |
| **Base Type** | `Topomatic.Smt.SemanticPropertyNode` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticNode`
    - `Topomatic.Smt.SemanticPropertyNode`
      - `Topomatic.Smt.SemanticDoubleNode`

#### Constructors (1)

- `.ctor(Int32 handle)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SemanticIntegerNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticIntegerNode` |
| **Base Type** | `Topomatic.Smt.SemanticPropertyNode` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticNode`
    - `Topomatic.Smt.SemanticPropertyNode`
      - `Topomatic.Smt.SemanticIntegerNode`

#### Constructors (1)

- `.ctor(Int32 handle)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Int32` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SemanticJumper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticJumper` |
| **Base Type** | `Topomatic.Smt.SemanticPropertyNode` |
| **Implements** | `System.ICloneable, System.Collections.Generic.IEnumerable`1[[Topomatic.Smt.SemanticRootNode, Topomatic.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticNode`
    - `Topomatic.Smt.SemanticPropertyNode`
      - `Topomatic.Smt.SemanticJumper`

#### Constructors (1)

- `.ctor(Int32 handle)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Last` | `SemanticRootNode` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddRootNode` | `SemanticRootNode` | `Int32 handle, String caption` | `` |
| `GetEnumerator` | `IEnumerator<SemanticRootNode>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `MoveDown` | `Boolean` | `SemanticRootNode node` | `` |
| `MoveUp` | `Boolean` | `SemanticRootNode node` | `` |
| `Remove` | `Boolean` | `Int32 key` | `` |
| `ResetHandles` | `Void` | `SemanticRootNode root, ref Int32 handle` | `` |
| `ResetHandles` | `Void` | `SemanticRootNode root` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SemanticLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticLibrary` |
| **Base Type** | `Topomatic.Smt.SemanticJumper` |
| **Implements** | `System.ICloneable, System.Collections.Generic.IEnumerable`1[[Topomatic.Smt.SemanticRootNode, Topomatic.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticNode`
    - `Topomatic.Smt.SemanticPropertyNode`
      - `Topomatic.Smt.SemanticJumper`
        - `Topomatic.Smt.SemanticLibrary`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RelativePath` | `String` | `get/set` | No | `` |
| `Version` | `Int32` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SemanticLibrary other` | `` |
| `GenerateHandle` | `Void` | `ref Int32 handle` | `` |
| `HasRootHandleHandle` | `Boolean` | `Int32 handle` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetHandle` | `Void` | `SemanticRootNode node, Int32 handle` | `` |
| `TryGetValue` | `Boolean` | `Int32 key, ref SemanticRootNode value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SemanticLibrarySet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticLibrarySet` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Smt.SemanticLibrary, Topomatic.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `SemanticLibrarySet` | `get/set` | Yes | `` |
| `Default` | `SemanticLibrarySet` | `get` | Yes | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddLibrary` | `SemanticLibrary` | `String caption` | `` |
| `AddLibrary` | `SemanticLibrary` | `SemanticLibrary lib` | `` |
| `Clone` | `SemanticLibrarySet` | `` | `` |
| `FindRootSemanticNode` | `SemanticRootNode` | `Predicate<SemanticNode> match` | `` |
| `FindRootSemanticNode` | `SemanticRootNode` | `Predicate<SemanticNode> match, List<KeyValuePair<Int32 Int32>> jumpers` | `` |
| `FindSemanticCode` | `Int32` | `String tag, Guid guid, List<KeyValuePair<Int32 Int32>> jumpers` | `` |
| `GenerateHandle` | `Void` | `ref Int32 handle` | `` |
| `GetEnumerator` | `IEnumerator<SemanticLibrary>` | `` | `` |
| `IsValidHandle` | `Boolean` | `Int32 handle` | `` |
| `Remove` | `Void` | `SemanticLibrary lib` | `` |
| `SaveAs` | `Void` | `String filename` | `` |
| `SetHandle` | `Void` | `SemanticRootNode node, Int32 handle` | `` |
| `TryGetValue` | `Boolean` | `Int32 key, ref SemanticRootNode value` | `` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckSemanticNode` | `Boolean` | `Predicate<SemanticNode> match, SemanticJumper jumper` | `` |
| `CheckSemanticNode` | `Boolean` | `Predicate<SemanticNode> match, SemanticRootNode root` | `` |
| `FindSemanticPath` | `Boolean` | `Predicate<SemanticNode> match, SemanticRootNode root, List<KeyValuePair<Int32 Int32>> jumpers` | `` |
| `FindSemanticPath` | `Boolean` | `Predicate<SemanticNode> match, SemanticJumper jumper, List<KeyValuePair<Int32 Int32>> jumpers` | `` |
| `LoadFromFile` | `SemanticLibrarySet` | `String filename` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SemanticNode` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticNode` |
| **Base Type** | `System.Object` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Int32 handle)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |
| `Handle` | `Int32` | `get/set` | No | `` |
| `Tag` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Object` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `ResetHandle` | `Void` | `Int32 value` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `Clone` |

### `SemanticPropertyNode` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticPropertyNode` |
| **Base Type** | `Topomatic.Smt.SemanticNode` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticNode`
    - `Topomatic.Smt.SemanticPropertyNode`

#### Constructors (1)

- `.ctor(Int32 handle)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConverterType` | `String` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `EditorType` | `String` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetConverter` | `PropertyTypeConverter` | `` | `` |
| `GetEditor` | `PropertyEditor` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SemanticRootNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticRootNode` |
| **Base Type** | `Topomatic.Smt.SemanticNode` |
| **Implements** | `System.ICloneable, System.Collections.Generic.IEnumerable`1[[Topomatic.Smt.SemanticNode, Topomatic.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticNode`
    - `Topomatic.Smt.SemanticRootNode`

#### Constructors (1)

- `.ctor(Int32 handle)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Int32` | `get/set` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDouble` | `SemanticDoubleNode` | `Int32 handle, String caption, Double value` | `` |
| `AddInteger` | `SemanticIntegerNode` | `Int32 handle, String caption, Int32 value` | `` |
| `AddJumper` | `SemanticJumper` | `Int32 handle, String caption` | `` |
| `AddString` | `SemanticStringNode` | `Int32 handle, String caption, String value` | `` |
| `GenerateHandle` | `Void` | `ref Int32 handle` | `` |
| `GetData` | `SemanticDataSet` | `SemanticDataHolder dataHolder, ITransactable owner` | `` |
| `GetEnumerator` | `IEnumerator<SemanticNode>` | `` | `` |
| `IsValidHandle` | `Boolean` | `Int32 handle` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `MoveDown` | `Boolean` | `SemanticNode node` | `` |
| `MoveUp` | `Boolean` | `SemanticNode node` | `` |
| `Remove` | `Void` | `Int32 key` | `` |
| `ResetHandles` | `Void` | `SemanticRootNode root` | `` |
| `ResetHandles` | `Void` | `SemanticRootNode root, ref Int32 handle` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `TagReplayCount` | `Int32` | `String tag` | `` |
| `TryGetNode` | `Boolean` | `Int32 handle, ref SemanticNode node` | `` |
| `TryGetNode` | `Boolean` | `Int32 handle, ref SemanticPropertyNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SemanticStringNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticStringNode` |
| **Base Type** | `Topomatic.Smt.SemanticPropertyNode` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticNode`
    - `Topomatic.Smt.SemanticPropertyNode`
      - `Topomatic.Smt.SemanticStringNode`

#### Constructors (1)

- `.ctor(Int32 handle)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, List<String> classes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TagedValue` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.SemanticDataSet+TagedValue` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Smt.SemanticDataSet+TagedValue`

#### Constructors (1)

- `.ctor(String _tag, String _name, Object _value, String _svalue, Int32 _handle)`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `handle` | `Int32` | No | `` | `` |
| `name` | `String` | No | `` | `` |
| `svalue` | `String` | No | `` | `` |
| `tag` | `String` | No | `` | `` |
| `value` | `Object` | No | `` | `` |

---
## Namespace: `Topomatic.Smt.Design`

### `ISemanticLibrarySetDlg` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.ISemanticLibrarySetDlg` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectedNode` | `TreeNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Modify` | `Void` | `SemanticLibrary library` | `` |

### `ProvideRandomizeAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.ProvideRandomizeAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Smt.Design.ProvideRandomizeAttribute`

#### Constructors (1)

- `.ctor(Boolean provider)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Provide` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SemanticBooleanConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticBooleanConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Smt.Design.SemanticBooleanConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `SemanticBooleanEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticBooleanEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Smt.Design.SemanticBooleanEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |

### `SemanticCaseWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticCaseWrapper` |
| **Base Type** | `Topomatic.Smt.Design.SemanticNodeWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.Design.SemanticNodeWrapper`
    - `Topomatic.Smt.Design.SemanticCaseWrapper`

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticRootNode node, SemanticLibrary library)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Tag` | `String` | `get/set` | No | `` |

### `SemanticDependencyPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticDependencyPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Smt.Design.SemanticDependencyPropertyProvider`

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

### `SemanticDoubleNodeWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticDoubleNodeWrapper` |
| **Base Type** | `Topomatic.Smt.Design.SemanticPropertyWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.Design.SemanticNodeWrapper`
    - `Topomatic.Smt.Design.SemanticPropertyWrapper`
      - `Topomatic.Smt.Design.SemanticDoubleNodeWrapper`

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticDoubleNode node, SemanticLibrary library)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultValue` | `Double` | `get/set` | No | `PropertyProvider` |

### `SemanticIntegerNodeWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticIntegerNodeWrapper` |
| **Base Type** | `Topomatic.Smt.Design.SemanticPropertyWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.Design.SemanticNodeWrapper`
    - `Topomatic.Smt.Design.SemanticPropertyWrapper`
      - `Topomatic.Smt.Design.SemanticIntegerNodeWrapper`

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticIntegerNode node, SemanticLibrary library)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultValue` | `Int32` | `get/set` | No | `PropertyProvider` |

### `SemanticLibraryWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticLibraryWrapper` |
| **Base Type** | `Topomatic.Smt.Design.SemanticNodeWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.Design.SemanticNodeWrapper`
    - `Topomatic.Smt.Design.SemanticLibraryWrapper`

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticLibrary node, SemanticLibrary library)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |

### `SemanticNodeWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticNodeWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticNode node, SemanticLibrary library)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get/set` | No | `` |
| `Dlg` | `ISemanticLibrarySetDlg` | `get` | No | `Browsable` |
| `Node` | `SemanticNode` | `get` | No | `Browsable` |
| `TreeNode` | `TreeNode` | `get` | No | `Browsable` |

### `SemanticProperty` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticProperty` |
| **Base Type** | `Topomatic.ComponentModel.CustomProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.Smt.Design.SemanticProperty`

#### Constructors (1)

- `.ctor(PropertyInfo property, Object[] attributes, SemanticDataSet dataSet, Int32 key, SemanticNode node)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Category` | `String` | `get/set` | No | `` |
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `DataSet` | `SemanticDataSet` | `get/set` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsBrowsable` | `Boolean` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Key` | `Int32` | `get` | No | `` |
| `Node` | `SemanticNode` | `get` | No | `` |
| `UpdateSequence` | `PropertyUpdateSequence` | `get` | No | `` |
| `VisualStyle` | `VisualStyle` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `SetValue` | `Void` | `Object value` | `` |

### `SemanticPropertyWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticPropertyWrapper` |
| **Base Type** | `Topomatic.Smt.Design.SemanticNodeWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.Design.SemanticNodeWrapper`
    - `Topomatic.Smt.Design.SemanticPropertyWrapper`

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticPropertyNode node, SemanticLibrary library)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `Tag` | `String` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

### `SemanticRootNodeWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticRootNodeWrapper` |
| **Base Type** | `Topomatic.Smt.Design.SemanticNodeWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.Design.SemanticNodeWrapper`
    - `Topomatic.Smt.Design.SemanticRootNodeWrapper`

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticRootNode node, SemanticLibrary library)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `PropertyEditor` |

### `SemanticStringNodeWrapper` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Design.SemanticStringNodeWrapper` |
| **Base Type** | `Topomatic.Smt.Design.SemanticPropertyWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.Design.SemanticNodeWrapper`
    - `Topomatic.Smt.Design.SemanticPropertyWrapper`
      - `Topomatic.Smt.Design.SemanticStringNodeWrapper`

#### Constructors (1)

- `.ctor(ISemanticLibrarySetDlg dlg, SemanticStringNode node, SemanticLibrary library)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultValue` | `String` | `get/set` | No | `PropertyProvider` |

---
## Namespace: `Topomatic.Smt.Extentions`

### `SemanticDataSetExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Extentions.SemanticDataSetExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualsDataHolder` | `Boolean` | `SemanticDataSet dataSet, SemanticDataSet other` | `Extension` |

---
## Namespace: `Topomatic.Smt.Gui`

### `SelectSemanticCodeDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Gui.SelectSemanticCodeDlg` |
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
                - `Topomatic.Smt.Gui.SelectSemanticCodeDlg`

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `ref Int32 code` | `` |
| `Execute` | `Boolean` | `ref Int32 code, SemanticLibrarySet library` | `` |
| `Execute` | `Boolean` | `ref Int32 code, Predicate<SemanticRootNode> match, SemanticLibrarySet library` | `` |
| `ExecuteMulti` | `IEnumerable<Int32>` | `SemanticLibrarySet library, IEnumerable<Int32> codes` | `` |
| `ExecuteMulti` | `IEnumerable<Int32>` | `` | `` |
| `ExecuteMulti` | `IEnumerable<Int32>` | `SemanticLibrarySet library, Predicate<SemanticRootNode> match, IEnumerable<Int32> codes` | `` |
| `ExecuteMulti` | `IEnumerable<Int32>` | `SemanticLibrarySet library` | `` |
| `ExecuteMulti` | `IEnumerable<Int32>` | `SemanticLibrarySet library, Predicate<SemanticRootNode> match` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Smt.Old`

### `SmtEntry` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Old.SmtEntry` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SmtStorage storage)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `BinaryReader reader` | `` |

### `SmtNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Old.SmtNode` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(SmtStorage storage)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `BinaryReader reader` | `` |

### `SmtStorage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Old.SmtStorage` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RootNode` | `SmtNode` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |

### `SmtStorageObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Old.SmtStorageObject` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SmtStorage storage)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Int64` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `BinaryReader reader` | `` |

### `TfcStreamUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Smt.Old.TfcStreamUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ReadDataItem` | `Object` | `BinaryReader reader` | `` |
| `ReadString` | `String` | `BinaryReader reader` | `` |
| `ReadWideString` | `String` | `BinaryReader reader` | `` |
| `WriteDataItem` | `Void` | `BinaryWriter writer, Object value` | `` |
| `WriteString` | `Void` | `BinaryWriter writer, String s` | `` |
| `WriteWideString` | `Void` | `BinaryWriter writer, String s` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 37 |
| **Classes** | 28 |
| **Interfaces** | 1 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 4 |
| **Static Classes** | 3 |
| **Total Methods** | 145 |
| **Total Properties** | 71 |
| **Total Fields** | 5 |
| **Total Events** | 2 |
| **Total Constructors** | 31 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


