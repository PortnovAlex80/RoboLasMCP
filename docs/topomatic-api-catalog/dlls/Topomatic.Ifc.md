# Topomatic.Ifc

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Ifc` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v4.0.30319` |
| **Full Name** | `Topomatic.Ifc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Ifc.dll` |

---
## Namespace: `Topomatic.Ifc`

### `IfcItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.IfcItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ICustomDocumentsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IfcProject project)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `Browsable` |
| `AlignmentBuffer` | `ManagedBuffer<Vector3F>` | `get` | No | `Browsable` |
| `AllProperties` | `ImProperties` | `get` | No | `SRCategory` |
| `Bounds` | `Nullable<BoundingBox3D>` | `get` | No | `Browsable` |
| `Cache` | `GeometryModelsCache` | `get/set` | No | `Browsable` |
| `Documents` | `ImDocuments` | `get/set` | No | `Browsable` |
| `Guid` | `String` | `get/set` | No | `ReadOnly, SRDisplayName` |
| `Name` | `String` | `get/set` | No | `SRDisplayName, ReadOnly` |
| `Parent` | `IfcItem` | `get/set` | No | `Browsable` |
| `Project` | `IfcProject` | `get` | No | `Browsable` |
| `Properties` | `ImProperties` | `get/set` | No | `Browsable` |
| `ReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Selected` | `Boolean` | `get/set` | No | `Browsable` |
| `SubItems` | `IfcSubItems` | `get/set` | No | `Browsable` |
| `Tag` | `Object` | `get/set` | No | `Browsable` |
| `Type` | `IfcType` | `get/set` | No | `ReadOnly, SRDisplayName` |
| `Visible` | `Boolean` | `get/set` | No | `SRDisplayName` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `` | `` |
| `Execute` | `Void` | `IDocumentContainer doc` | `` |
| `Remove` | `Void` | `IDocumentContainer doc` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICustomDocumentsContainer` | `Topomatic.FoundationClasses.ICustomDocumentsContainer.get_Documents` |
| `ICustomDocumentsContainer` | `get_ReadOnly` |
| `ICustomDocumentsContainer` | `Add` |
| `ICustomDocumentsContainer` | `Remove` |
| `ICustomDocumentsContainer` | `Execute` |

### `IfcProject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.IfcProject` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Ifc.IfcProject`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Modified` | `Boolean` | `get/set` | No | `` |
| `Path` | `String` | `get/set` | No | `` |
| `Pivot` | `Vector3D` | `get` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `Root` | `IfcItem` | `get` | No | `` |
| `Types` | `IDictionary<Guid IfcType>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Invalidate` | `Void` | `` | `` |
| `Load` | `Void` | `DatabaseIfc db` | `` |
| `Load` | `Void` | `VisualizationMap map, Action<Int32> progress` | `` |
| `TryGetItem` | `Boolean` | `String guid, ref IfcItem item` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetTypeStructureId` | `String` | `IfcItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStateController` | `get_Modified` |
| `IStateController` | `set_Modified` |
| `IStateController` | `get_ReadOnly` |
| `IStateController` | `set_ReadOnly` |
| `IDisposable` | `Dispose` |

### `IfcSubItems` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.IfcSubItems` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `IfcItem` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `IfcItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

### `IfcType` (class)

**Attributes**: [PropertyProvider]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.IfcType` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ImTypeDescriptor dsc)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Childs` | `IList<IfcType>` | `get` | No | `` |
| `Descriptor` | `ImTypeDescriptor` | `get` | No | `` |
| `Guid` | `Guid` | `get/set` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Parent` | `IfcType` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 4 |
| **Classes** | 4 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 13 |
| **Total Properties** | 31 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 4 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


