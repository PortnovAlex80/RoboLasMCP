# Topomatic.RoadSigns

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.RoadSigns` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.RoadSigns.dll` |

---
## Namespace: `Topomatic.RoadSigns`

### `DwgRoadSignStand` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.DwgRoadSignStand` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPointObject, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadSigns.DwgRoadSignStand`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (41)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllSignsScale` | `Double` | `get/set` | No | `SRCategory, PropertyEditor, StepValue, SRDisplayName` |
| `AngleTower` | `Double` | `get/set` | No | `SRCategory, SRDisplayName, Angle` |
| `BaseInsPos` | `Vector2D` | `get/set` | No | `Browsable` |
| `Block` | `DwgBlock` | `get/set` | No | `PropertyProvider` |
| `Cache` | `GeometryModelsCache` | `get` | No | `Browsable` |
| `ConstFootLength` | `Double` | `get/set` | No | `Browsable` |
| `ConstHeightTower` | `Double` | `get/set` | No | `Browsable` |
| `ConstSpaceSize` | `Double` | `get/set` | No | `Browsable` |
| `Element` | `ImElement` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `FoundationModel` | `Guid` | `get/set` | No | `SRCategory, Model3DLibraryItemGuid, SRDisplayName` |
| `FoundationPos` | `Vector2D` | `get/set` | No | `Browsable` |
| `FundamentType` | `RsFundamentType` | `get/set` | No | `SRDisplayName, SRCategory` |
| `HasCache3d` | `Boolean` | `get` | No | `Browsable` |
| `HeightTower` | `Double` | `get/set` | No | `SRCategory, SRDisplayName` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `JoinLine` | `DwgLine` | `get/set` | No | `Browsable` |
| `LinesSet` | `List<DwgEntity>` | `get` | No | `Browsable` |
| `NumsTextSet` | `List<DwgEntity>` | `get` | No | `Browsable` |
| `PktdX` | `Double` | `get/set` | No | `Browsable` |
| `PktdY` | `Double` | `get/set` | No | `Browsable` |
| `Position` | `Vector3D` | `get/set` | No | `SRDisplayName, SRCategory` |
| `RealPoint` | `Vector3D` | `get/set` | No | `SRCategory, SRDisplayName` |
| `SecondTower` | `DwgPolyline` | `get/set` | No | `Browsable` |
| `SecondTowerFoot` | `DwgPolyline` | `get/set` | No | `Browsable` |
| `ShowNums` | `Boolean` | `get/set` | No | `SRCategory, SRDisplayName` |
| `ShowOffs` | `Boolean` | `get/set` | No | `SRCategory, SRDisplayName` |
| `ShowPkt` | `Boolean` | `get/set` | No | `SRDisplayName, SRCategory` |
| `StakeText` | `DwgText` | `get/set` | No | `Browsable` |
| `ThirdTower` | `DwgPolyline` | `get/set` | No | `Browsable` |
| `ThirdTowerFoot` | `DwgPolyline` | `get/set` | No | `Browsable` |
| `Tower` | `DwgPolyline` | `get/set` | No | `Browsable` |
| `TowerCount` | `Int32` | `get/set` | No | `Browsable` |
| `TowerCountType` | `RsTowerCount` | `get/set` | No | `SRCategory, SRDisplayName` |
| `TowerFoot` | `DwgPolyline` | `get/set` | No | `Browsable` |
| `TowerMark` | `String` | `get/set` | No | `PropertyEditor, SRCategory, SRDisplayName, PropertyTypeConverter` |
| `TowerModel` | `Guid` | `get/set` | No | `SRDisplayName, Model3DLibraryItemGuid, SRCategory` |
| `TypeSize` | `RsTypeSize` | `get/set` | No | `SRCategory, SRDisplayName` |
| `TypeSizeScale` | `Double` | `get/set` | No | `Browsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AdaptSigns` | `Void` | `` | `` |
| `AddRoadSign` | `Void` | `RoadSignData rsData` | `` |
| `AddRoadSignOld` | `Void` | `RoadSignData rsData` | `` |
| `AlignSigns` | `Void` | `` | `` |
| `ChangeSign` | `Void` | `Int32 index, RoadSignDescriptor dr` | `` |
| `DeleteSign` | `Void` | `Int32 index` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetAnnotativeBounds` | `BoundingBox2D` | `Double scale` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSignTypedObject` | `TypedObject` | `DwgInsert insert` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `MoveSignDown` | `Void` | `Int32 index` | `` |
| `MoveSignUp` | `Void` | `Int32 index` | `` |
| `NotifyChange` | `Void` | `DwgObject sender, EventArgs e` | `` |
| `ToString` | `String` | `` | `` |
| `UseReference` | `Boolean` | `DwgObject obj` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BlockNameFromGUID` | `String` | `Guid guid, String gostNum` | `` |
| `SignUid` | `String` | `DwgInsert insert` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Const_FootLength` | `Double` | Yes | `` | `` |
| `Const_HeightTower` | `Double` | Yes | `` | `` |
| `Const_SpaceSize` | `Double` | Yes | `` | `` |
| `DefaultAngleTower` | `Double` | Yes | `` | `` |
| `DefaultDiameterTower` | `Double` | Yes | `` | `` |
| `DefaultHeightTower` | `Double` | Yes | `` | `` |
| `SignThickness` | `Double` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IPointObject` | `Topomatic.Cad.Foundation.IPointObject.get_BasePoint` |
| `ImElementHolder` | `get_Element` |
| `ImElementHolder` | `get_Cache` |

### `MarkAsbestosCementRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkAsbestosCementRec` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.RoadSigns.MarkAsbestosCementRec`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `D` | `Double` | No | `` | `` |
| `Document` | `String` | No | `` | `` |
| `Fundament` | `String` | No | `` | `` |
| `L` | `Double` | No | `` | `` |
| `M` | `Double` | No | `` | `` |
| `Mark` | `String` | No | `` | `` |
| `S` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkAsbestosCementTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkAsbestosCementTable` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.RoadSigns.MarkAsbestosCementRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.RoadSigns.MarkAsbestosCementRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.RoadSigns.MarkAsbestosCementRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<MarkAsbestosCementRec> records)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `MarkAsbestosCementRec` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `MarkAsbestosCementRec item` | `` |
| `Assign` | `Void` | `MarkAsbestosCementTable source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `MarkAsbestosCementRec item` | `` |
| `CopyTo` | `Void` | `MarkAsbestosCementRec[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<MarkAsbestosCementRec>` | `` | `` |
| `IndexOf` | `Int32` | `MarkAsbestosCementRec item` | `` |
| `Insert` | `Void` | `Int32 index, MarkAsbestosCementRec item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromXmlFile` | `Void` | `String path` | `` |
| `Remove` | `Boolean` | `MarkAsbestosCementRec item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToXmlFile` | `Void` | `String path` | `` |
| `Search` | `Int32` | `String mark` | `` |

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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkConcreteSteelRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkConcreteSteelRec` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.RoadSigns.MarkConcreteSteelRec`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Armature` | `String` | No | `` | `` |
| `B` | `Double` | No | `` | `` |
| `ConcreteExpense` | `Double` | No | `` | `` |
| `Document` | `String` | No | `` | `` |
| `Fundament` | `String` | No | `` | `` |
| `L` | `Double` | No | `` | `` |
| `L1` | `Double` | No | `` | `` |
| `M` | `Double` | No | `` | `` |
| `Mark` | `String` | No | `` | `` |
| `SteelExpense` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkConcreteSteelTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkConcreteSteelTable` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.RoadSigns.MarkConcreteSteelRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.RoadSigns.MarkConcreteSteelRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.RoadSigns.MarkConcreteSteelRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<MarkConcreteSteelRec> records)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `MarkConcreteSteelRec` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `MarkConcreteSteelRec item` | `` |
| `Assign` | `Void` | `MarkConcreteSteelTable source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `MarkConcreteSteelRec item` | `` |
| `CopyTo` | `Void` | `MarkConcreteSteelRec[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<MarkConcreteSteelRec>` | `` | `` |
| `IndexOf` | `Int32` | `MarkConcreteSteelRec item` | `` |
| `Insert` | `Void` | `Int32 index, MarkConcreteSteelRec item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromXmlFile` | `Void` | `String path` | `` |
| `Remove` | `Boolean` | `MarkConcreteSteelRec item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToXmlFile` | `Void` | `String path` | `` |
| `Search` | `Int32` | `String mark` | `` |

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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkMetallRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkMetallRec` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.RoadSigns.MarkMetallRec`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `D` | `Double` | No | `` | `` |
| `Document` | `String` | No | `` | `` |
| `Fundament` | `String` | No | `` | `` |
| `L` | `Double` | No | `` | `` |
| `M` | `Double` | No | `` | `` |
| `Mark` | `String` | No | `` | `` |
| `S` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkMetallTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkMetallTable` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.RoadSigns.MarkMetallRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.RoadSigns.MarkMetallRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.RoadSigns.MarkMetallRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<MarkMetallRec> records)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `MarkMetallRec` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `MarkMetallRec item` | `` |
| `Assign` | `Void` | `MarkMetallTable source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `MarkMetallRec item` | `` |
| `CopyTo` | `Void` | `MarkMetallRec[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<MarkMetallRec>` | `` | `` |
| `IndexOf` | `Int32` | `MarkMetallRec item` | `` |
| `Insert` | `Void` | `Int32 index, MarkMetallRec item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromXmlFile` | `Void` | `String path` | `` |
| `Remove` | `Boolean` | `MarkMetallRec item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToXmlFile` | `Void` | `String path` | `` |
| `Search` | `Int32` | `String mark` | `` |

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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkRoundWoodRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkRoundWoodRec` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.RoadSigns.MarkRoundWoodRec`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `D` | `Double` | No | `` | `` |
| `Document` | `String` | No | `` | `` |
| `Fundament` | `String` | No | `` | `` |
| `H` | `Double` | No | `` | `` |
| `L` | `Double` | No | `` | `` |
| `M` | `Double` | No | `` | `` |
| `Mark` | `String` | No | `` | `` |
| `WoodExpense` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkRoundWoodTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkRoundWoodTable` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.RoadSigns.MarkRoundWoodRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.RoadSigns.MarkRoundWoodRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.RoadSigns.MarkRoundWoodRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<MarkRoundWoodRec> records)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `MarkRoundWoodRec` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `MarkRoundWoodRec item` | `` |
| `Assign` | `Void` | `MarkRoundWoodTable source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `MarkRoundWoodRec item` | `` |
| `CopyTo` | `Void` | `MarkRoundWoodRec[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<MarkRoundWoodRec>` | `` | `` |
| `IndexOf` | `Int32` | `MarkRoundWoodRec item` | `` |
| `Insert` | `Void` | `Int32 index, MarkRoundWoodRec item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromXmlFile` | `Void` | `String path` | `` |
| `Remove` | `Boolean` | `MarkRoundWoodRec item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToXmlFile` | `Void` | `String path` | `` |
| `Search` | `Int32` | `String mark` | `` |

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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkSquareWoodRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkSquareWoodRec` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.RoadSigns.MarkSquareWoodRec`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A` | `Double` | No | `` | `` |
| `B` | `Double` | No | `` | `` |
| `Document` | `String` | No | `` | `` |
| `Fundament` | `String` | No | `` | `` |
| `L` | `Double` | No | `` | `` |
| `M` | `Double` | No | `` | `` |
| `Mark` | `String` | No | `` | `` |
| `WoodExpense` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MarkSquareWoodTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.MarkSquareWoodTable` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.RoadSigns.MarkSquareWoodRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.RoadSigns.MarkSquareWoodRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.RoadSigns.MarkSquareWoodRec, Topomatic.RoadSigns, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<MarkSquareWoodRec> records)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `MarkSquareWoodRec` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `MarkSquareWoodRec item` | `` |
| `Assign` | `Void` | `MarkSquareWoodTable source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `MarkSquareWoodRec item` | `` |
| `CopyTo` | `Void` | `MarkSquareWoodRec[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<MarkSquareWoodRec>` | `` | `` |
| `IndexOf` | `Int32` | `MarkSquareWoodRec item` | `` |
| `Insert` | `Void` | `Int32 index, MarkSquareWoodRec item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromXmlFile` | `Void` | `String path` | `` |
| `Remove` | `Boolean` | `MarkSquareWoodRec item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToXmlFile` | `Void` | `String path` | `` |
| `Search` | `Int32` | `String mark` | `` |

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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ModelCreator` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.ModelCreator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `ImElement` | `DwgRoadSignStand roadSign, Boolean geometrySigns` | `` |

### `RoadSignData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RoadSignData` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `` |
| `Guid` | `Guid` | `get/set` | No | `` |
| `InsPos` | `Vector2D` | `get/set` | No | `` |
| `IsTemp` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RoadSignData source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RoadSignDescriptor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RoadSignDescriptor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Drawing dwg, Guid guid, String gostNumber, String gostName, Boolean isTemp)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `Drawing` | `get/set` | No | `` |
| `GostName` | `String` | `get/set` | No | `` |
| `GostNumber` | `String` | `get/set` | No | `` |
| `Guid` | `Guid` | `get/set` | No | `` |
| `IsTemp` | `Boolean` | `get/set` | No | `` |

### `RsConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RsConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RoadSignsLayerName` | `String` | Yes | `` | `` |

### `RsFundamentType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RsFundamentType` |
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
      - `Topomatic.RoadSigns.RsFundamentType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FundamentType1` | `RsFundamentType` | Yes | `FundamentType1` | `` |
| `FundamentType2` | `RsFundamentType` | Yes | `FundamentType2` | `` |
| `FundamentType3` | `RsFundamentType` | Yes | `FundamentType3` | `` |
| `FundamentTypeNone` | `RsFundamentType` | Yes | `FundamentTypeNone` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FundamentTypeNone` | `0` |
| `FundamentType1` | `1` |
| `FundamentType2` | `2` |
| `FundamentType3` | `3` |

**Underlying Type**: `System.Int32`

### `RsFundamentTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RsFundamentTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadSigns.RsFundamentTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsTowerCount` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RsTowerCount` |
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
      - `Topomatic.RoadSigns.RsTowerCount`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `One_Tower` | `RsTowerCount` | Yes | `One_Tower` | `` |
| `Three_Tower` | `RsTowerCount` | Yes | `Three_Tower` | `` |
| `Two_Tower` | `RsTowerCount` | Yes | `Two_Tower` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Without_Tower` | `RsTowerCount` | Yes | `Without_Tower` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Without_Tower` | `0` |
| `One_Tower` | `1` |
| `Two_Tower` | `2` |
| `Three_Tower` | `3` |

**Underlying Type**: `System.Int32`

### `RsTowerCountConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RsTowerCountConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadSigns.RsTowerCountConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsTypeSize` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RsTypeSize` |
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
      - `Topomatic.RoadSigns.RsTypeSize`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TypeSize1` | `RsTypeSize` | Yes | `TypeSize1` | `` |
| `TypeSize2` | `RsTypeSize` | Yes | `TypeSize2` | `` |
| `TypeSize3` | `RsTypeSize` | Yes | `TypeSize3` | `` |
| `TypeSize4` | `RsTypeSize` | Yes | `TypeSize4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TypeSize1` | `0` |
| `TypeSize2` | `1` |
| `TypeSize3` | `2` |
| `TypeSize4` | `3` |

**Underlying Type**: `System.Int32`

### `RsTypeSizeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.RsTypeSizeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadSigns.RsTypeSizeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.RoadSigns.Design`

### `PWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.Design.SignsPropertyProvider+PWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IPointObject, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DwgInsert ins, DwgRoadSignStand stand)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `PropertyTypeConverter, SRDisplayName, PropertyEditor` |
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `GostName` | `String` | `get/set` | No | `SRDisplayName` |
| `GostNumber` | `String` | `get/set` | No | `SRDisplayName` |
| `IsTemp` | `Boolean` | `get/set` | No | `SRDisplayName` |
| `IsUpdating` | `Boolean` | `get` | No | `Browsable` |
| `PositionX` | `Double` | `get/set` | No | `SRDisplayName` |
| `PositionY` | `Double` | `get/set` | No | `SRDisplayName` |
| `Scale` | `Double` | `get/set` | No | `SRDisplayName, PropertyEditor, StepValue` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `Browsable` |
| `TypedObject` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPointObject` | `get_BasePoint` |
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `RsBlockAttributeProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.Design.RsBlockAttributeProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.RoadSigns.Design.RsBlockAttributeProperty`

#### Constructors (1)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes, IAttrib attrib, DwgInsert insert, DwgRoadSignStand stand)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `IsCompatablePropertysDesctiptor` | `Boolean` | `CustomProperty other` | `` |
| `SetValue` | `Void` | `Object value` | `` |

### `SignsPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadSigns.Design.SignsPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.RoadSigns.Design.SignsPropertyProvider`

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

#### Nested Types (1)

- `PWrapper` (class)

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 24 |
| **Classes** | 14 |
| **Interfaces** | 0 |
| **Enums** | 3 |
| **Structs** | 5 |
| **Abstract Classes** | 0 |
| **Static Classes** | 2 |
| **Total Methods** | 113 |
| **Total Properties** | 85 |
| **Total Fields** | 63 |
| **Total Events** | 0 |
| **Total Constructors** | 19 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


