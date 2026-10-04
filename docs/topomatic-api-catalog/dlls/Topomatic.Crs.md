# Topomatic.Crs

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Crs` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Crs.dll` |

---
## Namespace: `Topomatic.Crs`

### `ActConstructionManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.ActConstructionManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Instance` | `ActConstructionManager` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Load` | `ActConstruction` | `String name` | `` |

### `ActPythonManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.ActPythonManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Instance` | `ActPythonManager` | `get` | Yes | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CallMethod` | `Object` | `Object instance, String name, Object[] args` | `` |
| `CreateInstance` | `Object` | `Object ptype` | `` |
| `GetProperty` | `Object` | `Object instance, String name` | `` |
| `LoadModule` | `ScriptScope` | `String module` | `` |
| `SetProperty` | `Void` | `Object instance, String name, Object value` | `` |

### `BuildMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.BuildMode` |
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
      - `Topomatic.Crs.BuildMode`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Existing` | `BuildMode` | Yes | `Existing` | `` |
| `ModifyParameters` | `BuildMode` | Yes | `ModifyParameters` | `` |
| `Project` | `BuildMode` | Yes | `Project` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Volume` | `BuildMode` | Yes | `Volume` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Existing` | `1` |
| `Project` | `3` |
| `Volume` | `7` |
| `ModifyParameters` | `14` |

**Underlying Type**: `System.Int32`

### `CrsLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.CrsLine` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.CrsLineNode, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.CrsLineNode, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Crs.CrsLineNode, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.ICloneable, Topomatic.Cad.Foundation.IObjectDisjoiner, System.IEquatable`1[[Topomatic.Crs.CrsLine, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Crs.CrsLine`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<Vector2D> nodes)`
- `.ctor(IEnumerable<CrsLineNode> nodes)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `CrsLineNode` | `get/set` | No | `` |
| `MaxOffset` | `Double` | `get` | No | `` |
| `MinOffset` | `Double` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (26)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `CrsLineNode item` | `` |
| `Append` | `Void` | `IEnumerable<CrsLineNode> nodes` | `` |
| `Clear` | `Void` | `` | `` |
| `Clone` | `Object` | `` | `` |
| `Contains` | `Boolean` | `CrsLineNode item` | `` |
| `ConvertToVectorList` | `IList<Vector2D>` | `` | `` |
| `CopyTo` | `Void` | `CrsLineNode[] array, Int32 arrayIndex` | `` |
| `Equals` | `Boolean` | `CrsLine other` | `` |
| `FindNodes` | `IEnumerable<Int32>` | `Double offset` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<CrsLineNode>` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetY` | `Boolean` | `Double offset, List<Double> values` | `` |
| `GetY` | `Boolean` | `Double offset, ref Double value` | `` |
| `GetY` | `Boolean` | `Double offset, List<KeyValuePair<Int32 Double>> values` | `` |
| `IndexOf` | `Int32` | `CrsLineNode item` | `` |
| `Insert` | `Void` | `Int32 index, CrsLineNode item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `CrsLineNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `ICloneable` | `Clone` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IEquatable`1` | `Equals` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `CrsLineNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.CrsLineNode` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Crs.CrsLineNode, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.CrsLineNode`

#### Constructors (2)

- `.ctor(Double offset, Double elevation)`
- `.ctor(Double offset, Double elevation, Int32 code)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `CrsLineNode other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, CrsLineNode defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `CrsLineNode` | `StgNode stgNode, CrsLineNode defaultValue` | `` |
| `LoadFromStg` | `CrsLineNode` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `CrsLineNode prfNode, StgNode stgNode, CrsLineNode defaultValue` | `` |
| `SaveToStg` | `Void` | `CrsLineNode prfNode, StgNode stgNode` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code` | `Int32` | No | `` | `` |
| `Elevation` | `Double` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `CrsModifiedVolume` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.CrsModifiedVolume` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.CrsModifiedVolume`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `GeologyGroundId` | `String` | No | `` | `` |
| `Volume` | `CrsVolume` | No | `` | `` |

### `ICrsBuilder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.ICrsBuilder` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildTemplate` | `CrsDesignContext` | `Double station, CrsLine staticEg, CrsLine sectionLine, ActConstruction construction, BuildMode mode, Boolean clipContours, ICrsBuilderListener listener` | `` |

### `ICrsBuilderListener` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.ICrsBuilderListener` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Error` | `Void` | `String text` | `` |
| `Message` | `Void` | `String text` | `` |
| `Warning` | `Void` | `String text` | `` |

### `ICrsDesignContextBuilder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.ICrsDesignContextBuilder` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `CrsDesignContext context, Double station, CrsLine staticEg, CrsLine sectionLine` | `` |

---
## Namespace: `Topomatic.Crs.Ast`

### `ActBaseComponent` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Base Type** | `Topomatic.Crs.Ast.ActStatement` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `SDDisplayName` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `Browsable` |
| `Visible` | `Boolean` | `get/set` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ActBuildStatus` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActBuildStatus` |
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
      - `Topomatic.Crs.Ast.ActBuildStatus`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Error` | `ActBuildStatus` | Yes | `Error` | `` |
| `None` | `ActBuildStatus` | Yes | `None` | `` |
| `Success` | `ActBuildStatus` | Yes | `Success` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Success` | `0` |
| `Error` | `1` |
| `None` | `2` |

**Underlying Type**: `System.Int32`

### `ActComponent` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActComponent` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.ICollection`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActComponent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowedComponentTypes` | `String` | `get/set` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `Browsable` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `ActBaseComponent` | `get/set` | No | `` |
| `Properties` | `PropertyList` | `get` | No | `Browsable` |
| `Semantic` | `SemanticList` | `get` | No | `PropertyProvider` |
| `Type` | `ComponentType` | `get/set` | No | `Browsable` |
| `TypeName` | `String` | `get/set` | No | `Browsable` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ActBaseComponent item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ActBaseComponent item` | `` |
| `CopyTo` | `Void` | `ActBaseComponent[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ActBaseComponent>` | `` | `` |
| `IndexOf` | `Int32` | `ActBaseComponent item` | `` |
| `Insert` | `Void` | `Int32 index, ActBaseComponent item` | `` |
| `Remove` | `Boolean` | `ActBaseComponent item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `ToString` | `String` | `` | `` |
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Static Methods (27)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateConstruction` | `ActComponent` | `String name, String typeName, ComponentType type, String allowedComponentTypes` | `` |
| `CreateConstruction` | `ActComponent` | `String name, String typeName` | `` |
| `CreateConstruction` | `ActComponent` | `String name, String typeName, ComponentType type` | `` |
| `CreateContour` | `ActSimpleContour` | `String name, IEnumerable<AstExpression> nodes` | `` |
| `CreateContourSegment` | `ActSegmentContour` | `String name, AstExpression contour, AstExpression node1, AstExpression node2` | `` |
| `CreateContourUnion` | `ActUnionContour` | `String name, IEnumerable<AstExpression> contours` | `` |
| `CreateCopy` | `ActBaseComponent` | `ActBaseComponent component` | `` |
| `CreateNode` | `ActRelativeNode` | `String name, String node, Double x, Double y` | `` |
| `CreateNode` | `ActSimpleNode` | `String name, AstExpression x, AstExpression y` | `` |
| `CreateNode` | `ActSimpleNode` | `String name, Double x, Double y` | `` |
| `CreateNode` | `ActRelativeNode` | `String name, AstExpression node, AstExpression x, AstExpression y` | `` |
| `CreateNode` | `ActSimpleNode` | `String name, Double x, Double y, Int32 code` | `` |
| `CreateNodeConstruction` | `ActRayContainerNode` | `String name, AstExpression ray, AstExpression container, Int32 index` | `` |
| `CreateNodeConstruction` | `ActRayContainerNode` | `String name, AstExpression ray, AstExpression container` | `` |
| `CreateNodeContour` | `ActRayContourNode` | `String name, AstExpression ray, AstExpression contour, Int32 index` | `` |
| `CreateNodeContour` | `ActRayContourNode` | `String name, AstExpression ray, AstExpression contour` | `` |
| `CreateNodeContour` | `ActRayContourNode` | `String name, String ray, String contour` | `` |
| `CreateNodeRays` | `ActTwoRayNode` | `String name, String ray1, String ray2` | `` |
| `CreateNodeRays` | `ActTwoRayNode` | `String name, AstExpression ray1, AstExpression ray2` | `` |
| `CreatePythonConstruction` | `ActComponent` | `String name, String typeName` | `` |
| `CreateRay` | `ActSimpleRay` | `String name, String node, Double x, Double y` | `` |
| `CreateRay` | `ActSimpleRay` | `String name, AstExpression node, AstExpression x, AstExpression y` | `` |
| `CreateRayNodes` | `ActTwoNodeRay` | `String name, AstExpression node1, AstExpression node2` | `` |
| `CreateVolume` | `ActSimpleVolume` | `String name, AstExpression contour` | `` |
| `CreateVolume` | `ActSectVolume` | `String name, AstExpression contour1, AstExpression contour2, Boolean firstUp` | `` |
| `CreateVolume` | `ActSimpleVolume` | `String name, String contourName` | `` |
| `CreateVolume` | `ActSegmentVolume` | `String name, AstExpression contour, AstExpression node1, AstExpression node2` | `` |

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

### `ActCondition` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActCondition` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.ICollection`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActCondition`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `Expression` | `AstExpression` | `get/set` | No | `PropertyTypeConverter, SDDisplayName, AstExpression` |
| `False` | `ActSequence` | `get` | No | `Browsable` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `ActBaseComponent` | `get/set` | No | `` |
| `True` | `ActSequence` | `get` | No | `Browsable` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ActBaseComponent item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ActBaseComponent item` | `` |
| `CopyTo` | `Void` | `ActBaseComponent[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ActBaseComponent>` | `` | `` |
| `IndexOf` | `Int32` | `ActBaseComponent item` | `` |
| `Insert` | `Void` | `Int32 index, ActBaseComponent item` | `` |
| `Remove` | `Boolean` | `ActBaseComponent item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Walk` | `Void` | `AstWalker walker` | `` |

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

### `ActConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActConstruction` |
| **Base Type** | `Topomatic.Crs.Ast.ActSequence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.ICollection`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActSequence`
            - `Topomatic.Crs.Ast.ActConstruction`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Properties` | `ActConstructionProperties` | `get` | No | `Browsable` |
| `Semantics` | `ActConstructionSemantics` | `get` | No | `Browsable` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `ActConstruction` | `ActConstruction source` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `ActConstruction construction` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DefineComponentSemantic` | `Void` | `ActComponent component` | `` |
| `LoadConstruction` | `Void` | `XmlReader reader, ActConstruction construction` | `` |
| `LoadConstruction` | `Void` | `XmlReader reader, ActConstruction construction, CrsContour eg, ref AdditionalInfo info, List<CrsNode> crossing, IDictionary<String Object> variables` | `` |
| `SaveConstruction` | `Void` | `XmlWriter writer, ActConstruction construction` | `` |
| `SaveConstruction` | `Void` | `XmlWriter writer, ActConstruction construction, CrsContour eg, ref AdditionalInfo info, List<CrsNode> crossing, IDictionary<String Object> variables` | `` |

#### Events (5)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterInsert` | `IndexerEventHandler` | No | `` |
| `AfterRemove` | `IndexerEventHandler` | No | `` |
| `Changed` | `EventHandler` | No | `` |
| `NameChanged` | `EventHandler` | No | `` |
| `VisibleChanged` | `EventHandler` | No | `` |

#### Nested Types (1)

- `AdditionalInfo` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ActConstructionProperties` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActConstructionProperties` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActConstructionProperty, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ActConstructionProperty property` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<ActConstructionProperty>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `ActConstructionProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActConstructionProperty` |
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
| `Category` | `String` | `get/set` | No | `` |
| `DefaultValue` | `Object` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DisplayName` | `String` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `SmdxType` | `String` | `get/set` | No | `` |
| `Type` | `ActPropertyType` | `get/set` | No | `` |

### `ActConstructionSemantic` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActConstructionSemantic` |
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
| `Category` | `String` | `get/set` | No | `` |
| `Code` | `Int32` | `get/set` | No | `` |
| `Volumes` | `String` | `get/set` | No | `` |

### `ActConstructionSemantics` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActConstructionSemantics` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActConstructionSemantic, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ActConstructionSemantic property` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<ActConstructionSemantic>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `ActContour` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActContour` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActContour`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `SemanticAllowed, SemanticEditor, SDDisplayName` |
| `IsFilling` | `Boolean` | `get/set` | No | `SDDisplayName` |
| `IsRedLinePart` | `Boolean` | `get/set` | No | `SDDisplayName` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActNode` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActNode` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `SemanticAllowed, SemanticEditor, SDDisplayName` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActProperty` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `Value` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `LoadFromStg` | `Boolean` | `StgNode node, String typeName, Boolean semantic` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ActPropertyType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActPropertyType` |
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
      - `Topomatic.Crs.Ast.ActPropertyType`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Boolean` | `ActPropertyType` | Yes | `Boolean` | `` |
| `Container` | `ActPropertyType` | Yes | `Container` | `` |
| `Contour` | `ActPropertyType` | Yes | `Contour` | `` |
| `Double` | `ActPropertyType` | Yes | `Double` | `` |
| `Integer` | `ActPropertyType` | Yes | `Integer` | `` |
| `Node` | `ActPropertyType` | Yes | `Node` | `` |
| `Side` | `ActPropertyType` | Yes | `Side` | `` |
| `String` | `ActPropertyType` | Yes | `String` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Integer` | `0` |
| `Double` | `1` |
| `String` | `2` |
| `Boolean` | `3` |
| `Side` | `4` |
| `Node` | `5` |
| `Contour` | `6` |
| `Container` | `7` |

**Underlying Type**: `System.Int32`

### `ActRay` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActRay` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActRay`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bidirectional` | `Boolean` | `get/set` | No | `SDDisplayName` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActRayContainerNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActRayContainerNode` |
| **Base Type** | `Topomatic.Crs.Ast.ActNode` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActNode`
            - `Topomatic.Crs.Ast.ActRayContainerNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Container` | `AstExpression` | `get/set` | No | `SDCategory, PropertyTypeConverter, PropertyEditor, SDDisplayName` |
| `Index` | `Int32` | `get/set` | No | `PropertyEditor, SDDisplayName, SDCategory` |
| `Ray` | `AstExpression` | `get/set` | No | `PropertyTypeConverter, SDCategory, SDDisplayName, PropertyEditor` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActRayContourNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActRayContourNode` |
| **Base Type** | `Topomatic.Crs.Ast.ActNode` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActNode`
            - `Topomatic.Crs.Ast.ActRayContourNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour` | `AstExpression` | `get/set` | No | `PropertyEditor, SDCategory, PropertyTypeConverter, SDDisplayName` |
| `Index` | `Int32` | `get/set` | No | `PropertyEditor, SDCategory, SDDisplayName` |
| `Ray` | `AstExpression` | `get/set` | No | `SDCategory, PropertyTypeConverter, PropertyEditor, SDDisplayName` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActRelativeNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActRelativeNode` |
| **Base Type** | `Topomatic.Crs.Ast.ActNode` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActNode`
            - `Topomatic.Crs.Ast.ActRelativeNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Node` | `AstExpression` | `get/set` | No | `SDCategory, SDDisplayName, PropertyTypeConverter, PropertyEditor` |
| `X` | `AstExpression` | `get/set` | No | `PropertyTypeConverter, AstExpression, SDCategory, SDDisplayName` |
| `Y` | `AstExpression` | `get/set` | No | `SDCategory, AstExpression, SDDisplayName, PropertyTypeConverter` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActReport` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActReport` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActReport`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Message` | `String` | `get/set` | No | `SDDisplayName` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActSectVolume` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSectVolume` |
| **Base Type** | `Topomatic.Crs.Ast.ActVolume` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActVolume`
            - `Topomatic.Crs.Ast.ActSectVolume`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour1` | `AstExpression` | `get/set` | No | `SDDisplayName, SDCategory, PropertyEditor, PropertyTypeConverter` |
| `Contour2` | `AstExpression` | `get/set` | No | `PropertyTypeConverter, PropertyEditor, SDCategory, SDDisplayName` |
| `FirstUp` | `Boolean` | `get/set` | No | `SDCategory, SDDisplayName` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActSegmentContour` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSegmentContour` |
| **Base Type** | `Topomatic.Crs.Ast.ActContour` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActContour`
            - `Topomatic.Crs.Ast.ActSegmentContour`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour` | `AstExpression` | `get/set` | No | `PropertyEditor, PropertyTypeConverter, SDCategory, Browsable, SDDisplayName` |
| `Node1` | `AstExpression` | `get/set` | No | `SDCategory, PropertyTypeConverter, PropertyEditor, Browsable, SDDisplayName` |
| `Node2` | `AstExpression` | `get/set` | No | `PropertyEditor, Browsable, PropertyTypeConverter, SDDisplayName, SDCategory` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActSegmentVolume` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSegmentVolume` |
| **Base Type** | `Topomatic.Crs.Ast.ActVolume` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActVolume`
            - `Topomatic.Crs.Ast.ActSegmentVolume`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour` | `AstExpression` | `get/set` | No | `PropertyEditor, SDCategory, SDDisplayName, PropertyTypeConverter` |
| `Node1` | `AstExpression` | `get/set` | No | `SDDisplayName, PropertyTypeConverter, SDCategory, PropertyEditor` |
| `Node2` | `AstExpression` | `get/set` | No | `PropertyTypeConverter, SDDisplayName, SDCategory, PropertyEditor` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActSequence` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSequence` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.ICollection`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActSequence`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `ActBaseComponent` | `get/set` | No | `Browsable` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ActBaseComponent component` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ActBaseComponent item` | `` |
| `CopyTo` | `Void` | `ActBaseComponent[] array, Int32 arrayIndex` | `` |
| `FindByName` | `ActBaseComponent` | `String name` | `` |
| `GetEnumerator` | `IEnumerator<ActBaseComponent>` | `` | `` |
| `IndexOf` | `Int32` | `ActBaseComponent component` | `` |
| `Insert` | `Void` | `Int32 index, ActBaseComponent component` | `` |
| `Remove` | `Boolean` | `ActBaseComponent item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Walk` | `Void` | `AstWalker walker` | `` |

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

### `ActSide` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSide` |
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
      - `Topomatic.Crs.Ast.ActSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `ActSide` | Yes | `Left` | `` |
| `Right` | `ActSide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Right` | `1` |
| `Left` | `-1` |

**Underlying Type**: `System.Int32`

### `ActSimpleContour` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSimpleContour` |
| **Base Type** | `Topomatic.Crs.Ast.ActContour` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActContour`
            - `Topomatic.Crs.Ast.ActSimpleContour`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Nodes` | `IEnumerable<AstExpression>` | `get/set` | No | `SDDisplayName, SDCategory, PropertyEditor, PropertyTypeConverter` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActSimpleNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSimpleNode` |
| **Base Type** | `Topomatic.Crs.Ast.ActNode` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActNode`
            - `Topomatic.Crs.Ast.ActSimpleNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `X` | `AstExpression` | `get/set` | No | `AstExpression, PropertyTypeConverter, SDCategory, SDDisplayName` |
| `Y` | `AstExpression` | `get/set` | No | `AstExpression, PropertyTypeConverter, SDDisplayName, SDCategory` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActSimpleRay` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSimpleRay` |
| **Base Type** | `Topomatic.Crs.Ast.ActRay` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActRay`
            - `Topomatic.Crs.Ast.ActSimpleRay`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Node` | `AstExpression` | `get/set` | No | `SDDisplayName, SDCategory, PropertyTypeConverter, PropertyEditor` |
| `X` | `AstExpression` | `get/set` | No | `SDDisplayName, AstExpression, PropertyTypeConverter, SDCategory` |
| `Y` | `AstExpression` | `get/set` | No | `SDDisplayName, AstExpression, PropertyTypeConverter, SDCategory` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActSimpleVolume` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSimpleVolume` |
| **Base Type** | `Topomatic.Crs.Ast.ActVolume` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActVolume`
            - `Topomatic.Crs.Ast.ActSimpleVolume`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour` | `AstExpression` | `get/set` | No | `SDCategory, PropertyTypeConverter, PropertyEditor, SDDisplayName` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActStatement` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`

### `ActSwitch` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActSwitch` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.ICollection`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.Ast.ActBaseComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActSwitch`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `Expression` | `AstExpression` | `get/set` | No | `SDDisplayName, AstExpression, PropertyTypeConverter` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `ActBaseComponent` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ActBaseComponent item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ActBaseComponent item` | `` |
| `CopyTo` | `Void` | `ActBaseComponent[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ActBaseComponent>` | `` | `` |
| `IndexOf` | `Int32` | `ActBaseComponent item` | `` |
| `Insert` | `Void` | `Int32 index, ActBaseComponent item` | `` |
| `Remove` | `Boolean` | `ActBaseComponent item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Walk` | `Void` | `AstWalker walker` | `` |

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

### `ActTwoNodeRay` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActTwoNodeRay` |
| **Base Type** | `Topomatic.Crs.Ast.ActRay` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActRay`
            - `Topomatic.Crs.Ast.ActTwoNodeRay`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Node1` | `AstExpression` | `get/set` | No | `SDCategory, SDDisplayName, PropertyEditor, PropertyTypeConverter` |
| `Node2` | `AstExpression` | `get/set` | No | `SDCategory, PropertyTypeConverter, SDDisplayName, PropertyEditor` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActTwoRayNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActTwoRayNode` |
| **Base Type** | `Topomatic.Crs.Ast.ActNode` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActNode`
            - `Topomatic.Crs.Ast.ActTwoRayNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ray1` | `AstExpression` | `get/set` | No | `PropertyEditor, SDCategory, SDDisplayName, PropertyTypeConverter` |
| `Ray2` | `AstExpression` | `get/set` | No | `PropertyTypeConverter, SDDisplayName, SDCategory, PropertyEditor` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActUnionContour` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActUnionContour` |
| **Base Type** | `Topomatic.Crs.Ast.ActContour` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActContour`
            - `Topomatic.Crs.Ast.ActUnionContour`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contours` | `IEnumerable<AstExpression>` | `get/set` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ActVolume` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActVolume` |
| **Base Type** | `Topomatic.Crs.Ast.ActBaseComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.ActStatement`
        - `Topomatic.Crs.Ast.ActBaseComponent`
          - `Topomatic.Crs.Ast.ActVolume`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `SemanticAllowed, SDDisplayName, SemanticEditor, SDCategory` |
| `Factor` | `Double` | `get/set` | No | `Browsable` |
| `Holder` | `SemanticDataHolder` | `get` | No | `Browsable` |
| `Mode` | `CrsVolumeMode` | `get/set` | No | `SDDisplayName` |
| `Semantic` | `SemanticDataSet` | `get` | No | `SDDisplayName, SDCategory, PropertyUpdateSequence` |
| `SemanticEx` | `PropertyList` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AdditionalInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ActConstruction+AdditionalInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Ast.ActConstruction+AdditionalInfo`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AgElevation` | `Double` | No | `` | `` |
| `AgGrade` | `Double` | No | `` | `` |
| `AgLeftOffset` | `Double` | No | `` | `` |
| `AgRightOffset` | `Double` | No | `` | `` |
| `ClElevation` | `Double` | No | `` | `` |
| `EgElevation` | `Double` | No | `` | `` |
| `EgInclination` | `Double` | No | `` | `` |

### `AstAndExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstAndExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstAndExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression left, AstExpression right)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Left` | `AstExpression` | `get/set` | No | `` |
| `Right` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstArg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstArg` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstArg`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression expression)`
- `.ctor(String name, AstExpression expression)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `AstExpression` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstAssertStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstAssertStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstAssertStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression test, AstExpression message)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Message` | `AstExpression` | `get/set` | No | `` |
| `Test` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstAssignmentStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstAssignmentStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstAssignmentStatement`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression[] left, AstExpression right)`
- `.ctor(AstExpression left, AstExpression right)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Left` | `AstExpressionCollection` | `get` | No | `` |
| `Right` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstAugmentedAssignStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstAugmentedAssignStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstAugmentedAssignStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstOperator op, AstExpression left, AstExpression right)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Left` | `AstExpression` | `get/set` | No | `` |
| `Operator` | `AstOperator` | `get/set` | No | `` |
| `Right` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstBackQuoteExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstBackQuoteExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstBackQuoteExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression expression)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstBinaryExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstBinaryExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstBinaryExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstOperator op, AstExpression left, AstExpression right)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Left` | `AstExpression` | `get/set` | No | `` |
| `Operator` | `AstOperator` | `get/set` | No | `` |
| `Right` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstBreakStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstBreakStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstBreakStatement`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstCallExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstCallExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstCallExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression target, AstArg[] args)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Args` | `AstObjectCollection<AstArg>` | `get` | No | `` |
| `Target` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstClassDefinition` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstClassDefinition` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstClassDefinition`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bases` | `AstExpressionCollection` | `get` | No | `` |
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `Decorators` | `AstExpressionCollection` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstCommentStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstCommentStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstCommentStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String comment)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Comment` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstConditionalExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstConditionalExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstConditionalExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression testExpression, AstExpression trueExpression, AstExpression falseExpression)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FalseExpression` | `AstExpression` | `get/set` | No | `` |
| `Test` | `AstExpression` | `get/set` | No | `` |
| `TrueExpression` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstConstantExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstConstantExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstConstantExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Object value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Object` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstContinueStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstContinueStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstContinueStatement`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstDelStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstDelStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstDelStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression[] expressions)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expressions` | `AstExpressionCollection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstDictionaryExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstDictionaryExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstDictionaryExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstSliceExpression[] expressions)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expressions` | `AstObjectCollection<AstSliceExpression>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstDottedName` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstDottedName` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstDottedName`

#### Constructors (1)

- `.ctor(String[] names)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Names` | `List<String>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `MakeString` | `String` | `` | `` |
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstErrorExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstErrorExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstErrorExpression`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstExecStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstExecStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstExecStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression code, AstExpression locals, AstExpression globals)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `AstExpression` | `get/set` | No | `` |
| `Globals` | `AstExpression` | `get/set` | No | `` |
| `Locals` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstExpression` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`

### `AstExpressionCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstExpressionCollection` |
| **Base Type** | `Topomatic.Crs.Ast.AstObjectCollection`1[[Topomatic.Crs.Ast.AstExpression, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Crs.Ast.AstExpression, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.AstExpression, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.Ast.AstExpression, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstObjectCollection`1[[Topomatic.Crs.Ast.AstExpression, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Crs.Ast.AstExpressionCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AstExpressionStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstExpressionStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstExpressionStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression expression)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstForStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstForStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstForStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression left, AstExpression list, IEnumerable<AstStatement> body, IEnumerable<AstStatement> else_)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `Else` | `AstStatementCollection` | `get` | No | `` |
| `Left` | `AstExpression` | `get/set` | No | `` |
| `List` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstFromImportStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstFromImportStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstFromImportStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstDottedName root, String[] names, String[] asNames)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AsNames` | `List<String>` | `get` | No | `` |
| `Names` | `List<String>` | `get` | No | `` |
| `Root` | `AstDottedName` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstFunctionDefinition` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstFunctionDefinition` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstFunctionDefinition`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String name, AstParameter[] parameters)`
- `.ctor(String name, AstParameter[] parameters, AstStatement[] body)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `Decorators` | `AstExpressionCollection` | `get` | No | `` |
| `IsGenerator` | `Boolean` | `get/set` | No | `` |
| `IsLambda` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Parameters` | `AstObjectCollection<AstParameter>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstGenerator` |
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
| `Generate` | `Void` | `AstObject ast, TextWriter writer` | `` |

### `AstGeneratorExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstGeneratorExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstGeneratorExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstFunctionDefinition function, AstExpression iterable)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Function` | `AstFunctionDefinition` | `get/set` | No | `` |
| `Iterable` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstGlobalStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstGlobalStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstGlobalStatement`

#### Constructors (1)

- `.ctor(String[] names)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Names` | `List<String>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstIfStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstIfStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstIfStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstIfStatementTest[] tests, AstStatement[] else_)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElseStatement` | `AstStatementCollection` | `get` | No | `` |
| `Tests` | `AstObjectCollection<AstIfStatementTest>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstIfStatementTest` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstIfStatementTest` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstIfStatementTest`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `Test` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstImportStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstImportStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstImportStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstDottedName[] names, String[] asNames)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AsNames` | `List<String>` | `get` | No | `` |
| `Names` | `AstObjectCollection<AstDottedName>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstIndexExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstIndexExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstIndexExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression target, AstExpression index)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `AstExpression` | `get/set` | No | `` |
| `Target` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstLambdaExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstLambdaExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstLambdaExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstFunctionDefinition function)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Function` | `AstFunctionDefinition` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstListComprehension` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstListComprehension` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstListComprehension`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression item, AstListComprehensionIterator[] iterators)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `AstExpression` | `get/set` | No | `` |
| `Iterators` | `AstObjectCollection<AstListComprehensionIterator>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstListComprehensionFor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstListComprehensionFor` |
| **Base Type** | `Topomatic.Crs.Ast.AstListComprehensionIterator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstListComprehensionIterator`
      - `Topomatic.Crs.Ast.AstListComprehensionFor`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression left, AstExpression list)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Left` | `AstExpression` | `get/set` | No | `` |
| `List` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstListComprehensionIf` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstListComprehensionIf` |
| **Base Type** | `Topomatic.Crs.Ast.AstListComprehensionIterator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstListComprehensionIterator`
      - `Topomatic.Crs.Ast.AstListComprehensionIf`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression test)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Test` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstListComprehensionIterator` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstListComprehensionIterator` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstListComprehensionIterator`

### `AstListExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstListExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstListExpression`

#### Constructors (1)

- `.ctor(AstExpression[] items)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expressions` | `AstExpressionCollection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstMemberExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstMemberExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstMemberExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression target, String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |
| `Target` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstNameExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstNameExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstNameExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstObject` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `End` | `Location` | `get/set` | No | `Browsable` |
| `Span` | `LocationSpan` | `get` | No | `Browsable` |
| `Start` | `Location` | `get/set` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstObjectCollection`1<T where AstObject, class, AstObject>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstObjectCollection`1` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Implements** | `, , System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstObjectCollection`1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `AddRange` | `Void` | `IEnumerable<T> collection` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `RemoveRange` | `Void` | `Int32 index, Int32 count` | `` |
| `Walk` | `Void` | `AstWalker walker` | `` |

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

### `AstOperator` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstOperator` |
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
      - `Topomatic.Crs.Ast.AstOperator`

#### Fields (32)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Add` | `AstOperator` | Yes | `Add` | `` |
| `BitwiseAnd` | `AstOperator` | Yes | `BitwiseAnd` | `` |
| `BitwiseOr` | `AstOperator` | Yes | `BitwiseOr` | `` |
| `Divide` | `AstOperator` | Yes | `Divide` | `` |
| `Equal` | `AstOperator` | Yes | `Equals` | `` |
| `Equals` | `AstOperator` | Yes | `Equals` | `` |
| `ExclusiveOr` | `AstOperator` | Yes | `Xor` | `` |
| `FloorDivide` | `AstOperator` | Yes | `FloorDivide` | `` |
| `GreaterThan` | `AstOperator` | Yes | `GreaterThan` | `` |
| `GreaterThanOrEqual` | `AstOperator` | Yes | `GreaterThanOrEqual` | `` |
| `In` | `AstOperator` | Yes | `In` | `` |
| `Invert` | `AstOperator` | Yes | `Invert` | `` |
| `Is` | `AstOperator` | Yes | `Is` | `` |
| `IsNot` | `AstOperator` | Yes | `IsNot` | `` |
| `LeftShift` | `AstOperator` | Yes | `LeftShift` | `` |
| `LessThan` | `AstOperator` | Yes | `LessThan` | `` |
| `LessThanOrEqual` | `AstOperator` | Yes | `LessThanOrEqual` | `` |
| `Mod` | `AstOperator` | Yes | `Mod` | `` |
| `Multiply` | `AstOperator` | Yes | `Multiply` | `` |
| `Negate` | `AstOperator` | Yes | `Negate` | `` |
| `None` | `AstOperator` | Yes | `None` | `` |
| `Not` | `AstOperator` | Yes | `Not` | `` |
| `NotEqual` | `AstOperator` | Yes | `NotEqual` | `` |
| `NotEquals` | `AstOperator` | Yes | `NotEqual` | `` |
| `NotIn` | `AstOperator` | Yes | `NotIn` | `` |
| `Pos` | `AstOperator` | Yes | `Pos` | `` |
| `Power` | `AstOperator` | Yes | `Power` | `` |
| `RightShift` | `AstOperator` | Yes | `RightShift` | `` |
| `Subtract` | `AstOperator` | Yes | `Subtract` | `` |
| `TrueDivide` | `AstOperator` | Yes | `TrueDivide` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Xor` | `AstOperator` | Yes | `Xor` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Not` | `1` |
| `Pos` | `2` |
| `Invert` | `3` |
| `Negate` | `4` |
| `Add` | `5` |
| `Subtract` | `6` |
| `Multiply` | `7` |
| `Divide` | `8` |
| `TrueDivide` | `9` |
| `Mod` | `10` |
| `BitwiseAnd` | `11` |
| `BitwiseOr` | `12` |
| `Xor` | `13` |
| `ExclusiveOr` | `13` |
| `LeftShift` | `14` |
| `RightShift` | `15` |
| `Power` | `16` |
| `FloorDivide` | `17` |
| `LessThan` | `18` |
| `LessThanOrEqual` | `19` |
| `GreaterThan` | `20` |
| `GreaterThanOrEqual` | `21` |
| `Equals` | `22` |
| `Equal` | `22` |
| `NotEqual` | `23` |
| `NotEquals` | `23` |
| `In` | `24` |
| `NotIn` | `25` |
| `IsNot` | `26` |
| `Is` | `27` |

**Underlying Type**: `System.Int32`

### `AstOrExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstOrExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstOrExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression left, AstExpression right)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Left` | `AstExpression` | `get/set` | No | `` |
| `Right` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstParameter` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstParameter`

#### Constructors (2)

- `.ctor(String name)`
- `.ctor(String name, AstParameterKind kind)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultValue` | `AstExpression` | `get/set` | No | `` |
| `IsDictionary` | `Boolean` | `get/set` | No | `` |
| `IsList` | `Boolean` | `get/set` | No | `` |
| `Kind` | `AstParameterKind` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstParameterKind` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstParameterKind` |
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
      - `Topomatic.Crs.Ast.AstParameterKind`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dictionary` | `AstParameterKind` | Yes | `Dictionary` | `` |
| `List` | `AstParameterKind` | Yes | `List` | `` |
| `Normal` | `AstParameterKind` | Yes | `Normal` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Normal` | `0` |
| `List` | `1` |
| `Dictionary` | `2` |

**Underlying Type**: `System.Int32`

### `AstParenthesisExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstParenthesisExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstParenthesisExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression expression)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstParser` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstParser` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Parse` | `AstUnit` | `TextReader codeStream, LanguageContext language, ErrorSink errorSink` | `` |
| `Parse` | `AstUnit` | `TextReader codeStream, LanguageContext language` | `` |

### `AstPrintStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstPrintStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstPrintStatement`

#### Constructors (1)

- `.ctor(AstExpression destination, AstExpression[] expressions, Boolean trailingComma)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Destination` | `AstExpression` | `get/set` | No | `` |
| `Expressions` | `AstExpressionCollection` | `get` | No | `` |
| `TrailingComma` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstRaiseStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstRaiseStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstRaiseStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression type)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstReturnStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstReturnStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstReturnStatement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression expression)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstSliceExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstSliceExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstSliceExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression start, AstExpression stop, AstExpression step, Boolean stepProvided)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SliceStart` | `AstExpression` | `get/set` | No | `` |
| `SliceStep` | `AstExpression` | `get/set` | No | `` |
| `SliceStop` | `AstExpression` | `get/set` | No | `` |
| `StepProvided` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstStatement` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documentation` | `String` | `get/set` | No | `Browsable` |

### `AstStatementCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstStatementCollection` |
| **Base Type** | `Topomatic.Crs.Ast.AstObjectCollection`1[[Topomatic.Crs.Ast.AstStatement, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Crs.Ast.AstStatement, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.AstStatement, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Crs.Ast.AstStatement, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstObjectCollection`1[[Topomatic.Crs.Ast.AstStatement, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Crs.Ast.AstStatementCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AstSublistParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstSublistParameter` |
| **Base Type** | `Topomatic.Crs.Ast.AstParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstParameter`
      - `Topomatic.Crs.Ast.AstSublistParameter`

#### Constructors (2)

- `.ctor(String name, AstTupleExpression tuple)`
- `.ctor(Int32 position, AstTupleExpression tuple)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Tuple` | `AstTupleExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstTryStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstTryStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstTryStatement`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `Else` | `AstStatementCollection` | `get` | No | `` |
| `Finally` | `AstStatementCollection` | `get` | No | `` |
| `Handlers` | `AstObjectCollection<AstTryStatementHandler>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstTryStatementHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstTryStatementHandler` |
| **Base Type** | `Topomatic.Crs.Ast.AstObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstTryStatementHandler`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `Target` | `AstExpression` | `get/set` | No | `` |
| `Test` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstTupleExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstTupleExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstTupleExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean expandable, AstExpression[] items)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expressions` | `AstExpressionCollection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstUnaryExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstUnaryExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstUnaryExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstOperator op, AstExpression expression)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `AstExpression` | `get/set` | No | `` |
| `Operator` | `AstOperator` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstUnit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstUnit` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstUnit`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstWalker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstWalker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (140)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PostWalk` | `Void` | `AstRaiseStatement node` | `` |
| `PostWalk` | `Void` | `AstReturnStatement node` | `` |
| `PostWalk` | `Void` | `AstUnit node` | `` |
| `PostWalk` | `Void` | `AstImportStatement node` | `` |
| `PostWalk` | `Void` | `AstPrintStatement node` | `` |
| `PostWalk` | `Void` | `AstTryStatement node` | `` |
| `PostWalk` | `Void` | `AstDottedName node` | `` |
| `PostWalk` | `Void` | `AstIfStatementTest node` | `` |
| `PostWalk` | `Void` | `AstArg node` | `` |
| `PostWalk` | `Void` | `AstWhileStatement node` | `` |
| `PostWalk` | `Void` | `AstWithStatement node` | `` |
| `PostWalk` | `Void` | `ActSectVolume volume` | `` |
| `PostWalk` | `Void` | `AstContinueStatement node` | `` |
| `PostWalk` | `Void` | `AstDelStatement node` | `` |
| `PostWalk` | `Void` | `AstClassDefinition node` | `` |
| `PostWalk` | `Void` | `AstAugmentedAssignStatement node` | `` |
| `PostWalk` | `Void` | `AstBreakStatement node` | `` |
| `PostWalk` | `Void` | `AstExecStatement node` | `` |
| `PostWalk` | `Void` | `AstFunctionDefinition node` | `` |
| `PostWalk` | `Void` | `AstGlobalStatement node` | `` |
| `PostWalk` | `Void` | `AstFromImportStatement node` | `` |
| `PostWalk` | `Void` | `AstExpressionStatement node` | `` |
| `PostWalk` | `Void` | `AstForStatement node` | `` |
| `PostWalk` | `Void` | `ActRayContourNode node` | `` |
| `PostWalk` | `Void` | `ActSimpleRay ray` | `` |
| `PostWalk` | `Void` | `ActRayContainerNode node` | `` |
| `PostWalk` | `Void` | `ActRelativeNode node` | `` |
| `PostWalk` | `Void` | `ActTwoRayNode node` | `` |
| `PostWalk` | `Void` | `ActTwoNodeRay ray` | `` |
| `PostWalk` | `Void` | `ActSimpleVolume volume` | `` |
| `PostWalk` | `Void` | `ActSegmentVolume volume` | `` |
| `PostWalk` | `Void` | `ActUnionContour contour` | `` |
| `PostWalk` | `Void` | `ActSimpleContour contour` | `` |
| `PostWalk` | `Void` | `ActSegmentContour contour` | `` |
| `PostWalk` | `Void` | `ActSimpleNode node` | `` |
| `PostWalk` | `Void` | `AstSublistParameter node` | `` |
| `PostWalk` | `Void` | `AstTryStatementHandler node` | `` |
| `PostWalk` | `Void` | `AstParameter node` | `` |
| `PostWalk` | `Void` | `AstListComprehensionFor node` | `` |
| `PostWalk` | `Void` | `AstListComprehensionIf node` | `` |
| `PostWalk` | `Void` | `AstCommentStatement node` | `` |
| `PostWalk` | `Void` | `ActReport report` | `` |
| `PostWalk` | `Void` | `ActComponent component` | `` |
| `PostWalk` | `Void` | `ActSwitch aswitch` | `` |
| `PostWalk` | `Void` | `ActSequence sequence` | `` |
| `PostWalk` | `Void` | `ActCondition condition` | `` |
| `PostWalk` | `Void` | `AstSliceExpression node` | `` |
| `PostWalk` | `Void` | `AstCallExpression node` | `` |
| `PostWalk` | `Void` | `AstListExpression node` | `` |
| `PostWalk` | `Void` | `AstErrorExpression node` | `` |
| `PostWalk` | `Void` | `AstBinaryExpression node` | `` |
| `PostWalk` | `Void` | `AstTupleExpression node` | `` |
| `PostWalk` | `Void` | `AstListComprehension node` | `` |
| `PostWalk` | `Void` | `AstMemberExpression node` | `` |
| `PostWalk` | `Void` | `AstConstantExpression node` | `` |
| `PostWalk` | `Void` | `AstNameExpression node` | `` |
| `PostWalk` | `Void` | `AstDictionaryExpression node` | `` |
| `PostWalk` | `Void` | `AstParenthesisExpression node` | `` |
| `PostWalk` | `Void` | `AstConditionalExpression node` | `` |
| `PostWalk` | `Void` | `AstOrExpression node` | `` |
| `PostWalk` | `Void` | `AstAssertStatement node` | `` |
| `PostWalk` | `Void` | `AstAssignmentStatement node` | `` |
| `PostWalk` | `Void` | `AstYieldExpression node` | `` |
| `PostWalk` | `Void` | `AstAndExpression node` | `` |
| `PostWalk` | `Void` | `AstIfStatement node` | `` |
| `PostWalk` | `Void` | `AstIndexExpression node` | `` |
| `PostWalk` | `Void` | `AstLambdaExpression node` | `` |
| `PostWalk` | `Void` | `AstUnaryExpression node` | `` |
| `PostWalk` | `Void` | `AstBackQuoteExpression node` | `` |
| `PostWalk` | `Void` | `AstGeneratorExpression node` | `` |
| `Walk` | `Boolean` | `ActComponent component` | `` |
| `Walk` | `Boolean` | `ActReport report` | `` |
| `Walk` | `Boolean` | `AstAndExpression node` | `` |
| `Walk` | `Boolean` | `AstTryStatementHandler node` | `` |
| `Walk` | `Boolean` | `ActCondition condition` | `` |
| `Walk` | `Boolean` | `AstGeneratorExpression node` | `` |
| `Walk` | `Boolean` | `ActSequence sequence` | `` |
| `Walk` | `Boolean` | `AstCommentStatement node` | `` |
| `Walk` | `Boolean` | `AstErrorExpression node` | `` |
| `Walk` | `Boolean` | `AstIndexExpression node` | `` |
| `Walk` | `Boolean` | `ActSwitch aswitch` | `` |
| `Walk` | `Boolean` | `AstDictionaryExpression node` | `` |
| `Walk` | `Boolean` | `AstBinaryExpression node` | `` |
| `Walk` | `Boolean` | `ActSegmentContour contour` | `` |
| `Walk` | `Boolean` | `ActTwoNodeRay ray` | `` |
| `Walk` | `Boolean` | `ActSimpleContour contour` | `` |
| `Walk` | `Boolean` | `ActUnionContour contour` | `` |
| `Walk` | `Boolean` | `ActSegmentVolume volume` | `` |
| `Walk` | `Boolean` | `ActSectVolume volume` | `` |
| `Walk` | `Boolean` | `AstBackQuoteExpression node` | `` |
| `Walk` | `Boolean` | `ActSimpleVolume volume` | `` |
| `Walk` | `Boolean` | `AstConstantExpression node` | `` |
| `Walk` | `Boolean` | `ActTwoRayNode node` | `` |
| `Walk` | `Boolean` | `ActSimpleNode node` | `` |
| `Walk` | `Boolean` | `ActRelativeNode node` | `` |
| `Walk` | `Boolean` | `ActRayContainerNode node` | `` |
| `Walk` | `Boolean` | `ActSimpleRay ray` | `` |
| `Walk` | `Boolean` | `AstCallExpression node` | `` |
| `Walk` | `Boolean` | `AstConditionalExpression node` | `` |
| `Walk` | `Boolean` | `ActRayContourNode node` | `` |
| `Walk` | `Boolean` | `AstFunctionDefinition node` | `` |
| `Walk` | `Boolean` | `AstTupleExpression node` | `` |
| `Walk` | `Boolean` | `AstFromImportStatement node` | `` |
| `Walk` | `Boolean` | `AstForStatement node` | `` |
| `Walk` | `Boolean` | `AstUnaryExpression node` | `` |
| `Walk` | `Boolean` | `AstImportStatement node` | `` |
| `Walk` | `Boolean` | `AstPrintStatement node` | `` |
| `Walk` | `Boolean` | `AstSliceExpression node` | `` |
| `Walk` | `Boolean` | `AstGlobalStatement node` | `` |
| `Walk` | `Boolean` | `AstIfStatement node` | `` |
| `Walk` | `Boolean` | `AstClassDefinition node` | `` |
| `Walk` | `Boolean` | `AstContinueStatement node` | `` |
| `Walk` | `Boolean` | `AstAssignmentStatement node` | `` |
| `Walk` | `Boolean` | `AstAugmentedAssignStatement node` | `` |
| `Walk` | `Boolean` | `AstBreakStatement node` | `` |
| `Walk` | `Boolean` | `AstYieldExpression node` | `` |
| `Walk` | `Boolean` | `AstExpressionStatement node` | `` |
| `Walk` | `Boolean` | `AstExecStatement node` | `` |
| `Walk` | `Boolean` | `AstAssertStatement node` | `` |
| `Walk` | `Boolean` | `AstDelStatement node` | `` |
| `Walk` | `Boolean` | `AstIfStatementTest node` | `` |
| `Walk` | `Boolean` | `AstListComprehensionFor node` | `` |
| `Walk` | `Boolean` | `AstListExpression node` | `` |
| `Walk` | `Boolean` | `AstArg node` | `` |
| `Walk` | `Boolean` | `AstDottedName node` | `` |
| `Walk` | `Boolean` | `AstLambdaExpression node` | `` |
| `Walk` | `Boolean` | `AstSublistParameter node` | `` |
| `Walk` | `Boolean` | `AstParameter node` | `` |
| `Walk` | `Boolean` | `AstListComprehension node` | `` |
| `Walk` | `Boolean` | `AstListComprehensionIf node` | `` |
| `Walk` | `Boolean` | `AstOrExpression node` | `` |
| `Walk` | `Boolean` | `AstReturnStatement node` | `` |
| `Walk` | `Boolean` | `AstRaiseStatement node` | `` |
| `Walk` | `Boolean` | `AstParenthesisExpression node` | `` |
| `Walk` | `Boolean` | `AstUnit node` | `` |
| `Walk` | `Boolean` | `AstWithStatement node` | `` |
| `Walk` | `Boolean` | `AstMemberExpression node` | `` |
| `Walk` | `Boolean` | `AstWhileStatement node` | `` |
| `Walk` | `Boolean` | `AstTryStatement node` | `` |
| `Walk` | `Boolean` | `AstNameExpression node` | `` |

### `AstWhileStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstWhileStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstWhileStatement`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `ElseStatement` | `AstStatementCollection` | `get` | No | `` |
| `Test` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstWithStatement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstWithStatement` |
| **Base Type** | `Topomatic.Crs.Ast.AstStatement` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstStatement`
      - `Topomatic.Crs.Ast.AstWithStatement`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Body` | `AstStatementCollection` | `get` | No | `` |
| `ContextManager` | `AstExpression` | `get/set` | No | `` |
| `Variable` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `AstYieldExpression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.AstYieldExpression` |
| **Base Type** | `Topomatic.Crs.Ast.AstExpression` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstObject`
    - `Topomatic.Crs.Ast.AstExpression`
      - `Topomatic.Crs.Ast.AstYieldExpression`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(AstExpression expression)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `AstExpression` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Void` | `AstWalker walker` | `` |

### `ComponentType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.ComponentType` |
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
      - `Topomatic.Crs.Ast.ComponentType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Act` | `ComponentType` | Yes | `Act` | `` |
| `DotNet` | `ComponentType` | Yes | `DotNet` | `` |
| `None` | `ComponentType` | Yes | `None` | `` |
| `Python` | `ComponentType` | Yes | `Python` | `` |
| `Rbt` | `ComponentType` | Yes | `Rbt` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DotNet` | `0` |
| `Python` | `1` |
| `Rbt` | `2` |
| `Act` | `3` |
| `None` | `4` |

**Underlying Type**: `System.Int32`

### `IAstProvider` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.IAstProvider` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateExpression` | `Void` | `AstObject ast, TextWriter writer` | `` |
| `ParseExpression` | `AstExpression` | `TextReader reader` | `` |

### `Location` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.Location` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Ast.Location`

#### Constructors (1)

- `.ctor(Int32 line, Int32 column)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Column` | `Int32` | `get` | No | `` |
| `Line` | `Int32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Compare` | `Int32` | `Location left, Location right` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Invalid` | `Location` | Yes | `` | `` |
| `MinValue` | `Location` | Yes | `` | `` |
| `None` | `Location` | Yes | `` | `` |

### `LocationSpan` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.LocationSpan` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Ast.LocationSpan`

#### Constructors (1)

- `.ctor(Location start, Location end)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `End` | `Location` | `get` | No | `` |
| `Start` | `Location` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Invalid` | `LocationSpan` | Yes | `` | `` |
| `None` | `LocationSpan` | Yes | `` | `` |

### `PropertyList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.PropertyList` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Ast.ActProperty, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Crs.Ast.PropertyList`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ActProperty` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `String name, AstExpression value` | `` |
| `Clear` | `Void` | `` | `` |
| `FindIndex` | `Int32` | `String name` | `` |
| `GetEnumerator` | `IEnumerator<ActProperty>` | `` | `` |
| `Remove` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `PythonLanguage` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.PythonLanguage` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Generate` | `String` | `AstExpression exp` | `` |
| `Parse` | `AstExpression` | `String code` | `` |

### `SemanticList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Ast.SemanticList` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Crs.Ast.SemanticList`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `SemanticDataSet` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Int32 code, String name` | `` |
| `Add` | `Int32` | `` | `` |
| `Clear` | `Void` | `Int32 index` | `` |
| `Clear` | `Void` | `` | `` |
| `GetCode` | `Int32` | `Int32 index` | `` |
| `GetHolder` | `SemanticDataHolder` | `Int32 index` | `` |
| `GetName` | `String` | `Int32 index` | `` |
| `GetSemanticEx` | `PropertyList` | `Int32 index` | `` |
| `IndexOf` | `Int32` | `SemanticDataSet dataSet` | `` |
| `Remove` | `Void` | `Int32 index` | `` |
| `SetCode` | `Void` | `Int32 index, Int32 code` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Crs.Design`

### `ActSideTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.ActSideTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Crs.Design.ActSideTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `ActSideTypeConverter` | Yes | `` | `` |

### `AstExpressionConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.AstExpressionConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Crs.Design.AstExpressionConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `AstExpressionConverter` | Yes | `` | `` |

### `AstSelectEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.AstSelectEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Crs.Design.AstSelectEditor`

#### Constructors (1)

- `.ctor(SelectionType selectionType)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `CodeExpressionProperty` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.CodeExpressionProperty` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Crs.Design.CodeExpressionProperty`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean expression)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expression` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsAfterPropertyChangeEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.CrsAfterPropertyChangeEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Crs.Design.CrsAfterPropertyChangeEventArgs`

#### Constructors (1)

- `.ctor(CustomProperty property, ActBaseComponent component, String propertyName, Object value, Object old_value)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Component` | `ActBaseComponent` | `get` | No | `` |
| `OldValue` | `Object` | `get` | No | `` |
| `Property` | `CustomProperty` | `get` | No | `` |
| `PropertyName` | `String` | `get` | No | `` |
| `Value` | `Object` | `get` | No | `` |

### `CrsBeforePropertyChangeEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.CrsBeforePropertyChangeEventArgs` |
| **Base Type** | `System.ComponentModel.CancelEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `System.ComponentModel.CancelEventArgs`
      - `Topomatic.Crs.Design.CrsBeforePropertyChangeEventArgs`

#### Constructors (1)

- `.ctor(ActBaseComponent component, String propertyName, Object value, Object new_value)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Component` | `ActBaseComponent` | `get` | No | `` |
| `NewValue` | `Object` | `get` | No | `` |
| `PropertyName` | `String` | `get` | No | `` |
| `Value` | `Object` | `get` | No | `` |

### `CrsDesignEntityWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.CrsDesignEntityWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ICrsDesignHost host, ActBaseComponent actComponent, CrsComponent component)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActComponent` | `ActBaseComponent` | `get` | No | `PropertyProvider` |
| `Component` | `CrsComponent` | `get` | No | `Browsable` |
| `DesignHost` | `ICrsDesignHost` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `CrsDesignInitializatorAttribute` (class)

**Attributes**: [AttributeUsage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.CrsDesignInitializatorAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Crs.Design.CrsDesignInitializatorAttribute`

#### Constructors (2)

- `.ctor(Type initializatorType)`
- `.ctor(String initializatorType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InitializatorType` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsDesignPropertyProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.CrsDesignPropertyProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `CrsDesignEntityWrapper wrapper, MultiProperty property` | `` |

### `CrsDesignPropertyProviderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.CrsDesignPropertyProviderAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Crs.Design.CrsDesignPropertyProviderAttribute`

#### Constructors (2)

- `.ctor(Type providerType)`
- `.ctor(String providerType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ProviderType` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DesignInitializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.DesignInitializer` |
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
| `InitializeComponent` | `ActBaseComponent` | `ICrsDesignHost host, CrsComponent crsComponent, CrsComponent owner` | `` |

### `EditContourDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.EditContourDlg` |
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
                  - `Topomatic.Crs.Design.EditContourDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `CrsComponent contour, List<AstExpression> nodes, ICrsDesignHost host` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IActSerializable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.IActSerializable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsActSerializable` | `Boolean` | `` | `` |

### `ICrsDesignHost` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.ICrsDesignHost` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AstProvider` | `IAstProvider` | `get` | No | `` |
| `CLY` | `Double` | `get` | No | `` |
| `DesignContext` | `CrsDesignContext` | `get` | No | `` |
| `PythonPackage` | `Object` | `get` | No | `` |
| `SerializationManager` | `DesignerSerializationManager` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ComponentExist` | `Boolean` | `String typeName` | `` |
| `Deserialize` | `CrsComponent` | `AstExpression expression` | `` |
| `GetComponentFullTypeName` | `String` | `CrsComponent component` | `` |
| `HandleEvent` | `Void` | `Object sender, EventArgs e` | `` |
| `Invalidate` | `Void` | `` | `` |
| `RenameComponent` | `Void` | `ActBaseComponent component, String name` | `` |
| `SelectComponent` | `GetPointResult` | `String message, SelectionType type, ref CrsComponent compoennt, ref AstExpression expression, CrsComponent owner, CrsComponent except, String[] args` | `` |
| `SelectComponent` | `GetPointResult` | `String message, SelectionType type, ref CrsComponent compoennt, ref AstExpression expression, CrsComponent owner, CrsComponent except` | `` |
| `SelectComponent` | `GetPointResult` | `String message, SelectionType type, ref CrsComponent compoennt, ref AstExpression expression, CrsComponent owner` | `` |
| `Serialize` | `AstExpression` | `CrsComponent component` | `` |
| `Translate` | `Boolean` | `String category, ref String value` | `` |

### `RenewLayerTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.RenewLayerTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Crs.Design.RenewLayerTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SegmentModeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.SegmentModeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Crs.Design.SegmentModeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SelectionType` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.SelectionType` |
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
      - `Topomatic.Crs.Design.SelectionType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Construction` | `SelectionType` | Yes | `Construction` | `` |
| `ConstructionContour` | `SelectionType` | Yes | `ConstructionContour` | `` |
| `Contour` | `SelectionType` | Yes | `Contour` | `` |
| `Node` | `SelectionType` | Yes | `Node` | `` |
| `Ray` | `SelectionType` | Yes | `Ray` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Node` | `1` |
| `Ray` | `2` |
| `Contour` | `4` |
| `Construction` | `8` |
| `ConstructionContour` | `16` |

**Underlying Type**: `System.Int32`

### `SemanticAllowedAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Design.SemanticAllowedAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Crs.Design.SemanticAllowedAttribute`

#### Constructors (3)

- `.ctor(String[] allows)`
- `.ctor(Int32[] intervals)`
- `.ctor(Int32[] intervals, String[] allows)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Allows` | `String[]` | `get` | No | `` |
| `Intervals` | `Int32[]` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Crs.KP`

### `Constructions` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.KP.Constructions` |
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
      - `Topomatic.Crs.KP.Constructions`

#### Fields (20)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ballast` | `Constructions` | Yes | `Ballast` | `` |
| `Berm` | `Constructions` | Yes | `Berm` | `` |
| `BottomFill` | `Constructions` | Yes | `BottomFill` | `` |
| `CrsParamBufSize` | `Constructions` | Yes | `CrsParamBufSize` | `` |
| `CutSlope` | `Constructions` | Yes | `CutSlope` | `` |
| `Ditch` | `Constructions` | Yes | `Ditch` | `` |
| `Drain` | `Constructions` | Yes | `Drain` | `` |
| `Drainage` | `Constructions` | Yes | `Drainage` | `` |
| `FillSlope` | `Constructions` | Yes | `FillSlope` | `` |
| `Geotextile` | `Constructions` | Yes | `Geotextile` | `` |
| `Geotextile2` | `Constructions` | Yes | `Geotextile2` | `` |
| `ImmersedFill` | `Constructions` | Yes | `ImmersedFill` | `` |
| `InterceptingChannel` | `Constructions` | Yes | `InterceptingChannel` | `` |
| `LayerCutting` | `Constructions` | Yes | `LayerCutting` | `` |
| `Layout` | `Constructions` | Yes | `Layout` | `` |
| `Replacement` | `Constructions` | Yes | `Replacement` | `` |
| `Strengthening` | `Constructions` | Yes | `Strengthening` | `` |
| `TrackFormation` | `Constructions` | Yes | `TrackFormation` | `` |
| `Tray` | `Constructions` | Yes | `Tray` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TrackFormation` | `0` |
| `FillSlope` | `60` |
| `BottomFill` | `120` |
| `Berm` | `170` |
| `ImmersedFill` | `250` |
| `CutSlope` | `350` |
| `LayerCutting` | `410` |
| `Drain` | `460` |
| `Ditch` | `530` |
| `Tray` | `600` |
| `Drainage` | `670` |
| `Geotextile` | `990` |
| `Strengthening` | `1150` |
| `Layout` | `1330` |
| `Geotextile2` | `1380` |
| `Ballast` | `1630` |
| `Replacement` | `1730` |
| `InterceptingChannel` | `1780` |
| `CrsParamBufSize` | `2000` |

**Underlying Type**: `System.Int32`

### `KPReader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.KP.KPReader` |
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
| `Read` | `ActConstruction` | `Double* crsParamBuf` | `` |

---
## Namespace: `Topomatic.Crs.Rail`

### `Berm` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.Berm` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Berm`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BermLegdeInclination` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, DefaultValue, RTCCategory, RTCDwgTagName` |
| `BermLength` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, RTCDwgTagName, DefaultValue, RTCCategory` |
| `BermSlopeInclination` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDwgTagName, RTCDisplayName, RTCDescription` |
| `Side` | `Int32` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCDescription, RTCDisplayName, RTCCategory` |
| `Slope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BottomFill` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.BottomFill` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.BottomFill`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomFillGround` | `Int32` | `get/set` | No | `RTCCategory, RTCDescription, RTCDisplayName, DefaultValue, RTCDwgTagName` |
| `BottomFillLeftLedge` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDisplayName, RTCDwgTagName, DefaultValue` |
| `BottomFillLeftSlopeInclination` | `Double` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCDisplayName, RTCDescription, RTCCategory` |
| `BottomFillRightLedge` | `Double` | `get/set` | No | `RTCCategory, RTCDwgTagName, DefaultValue, RTCDisplayName, RTCDescription` |
| `BottomFillRightSlopeInclination` | `Double` | `get/set` | No | `DefaultValue, RTCDescription, RTCDisplayName, RTCCategory, RTCDwgTagName` |
| `BottomFillTopInclination` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, RTCDwgTagName, DefaultValue, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CutSlope` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.CutSlope` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.CutSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CutSlopeFirstStepHeight` | `Double` | `get/set` | No | `RTCCategory, DefaultValue, RTCDwgTagName, RTCDescription, RTCDisplayName` |
| `CutSlopeFirstStepInc` | `Double` | `get/set` | No | `DefaultValue, RTCDescription, RTCDisplayName, RTCCategory, RTCDwgTagName` |
| `CutSlopeFirstStepLedge` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDisplayName, RTCCategory, RTCDescription, DefaultValue` |
| `CutSlopeSecondStepHeight` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDisplayName, RTCDescription, RTCDwgTagName` |
| `CutSlopeSecondStepInc` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, DefaultValue, RTCDwgTagName, RTCDisplayName` |
| `CutSlopeSecondStepLedge` | `Double` | `get/set` | No | `RTCDescription, RTCDwgTagName, RTCCategory, RTCDisplayName, DefaultValue` |
| `CutSlopeThirdStepInc` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, RTCDescription, DefaultValue, RTCDwgTagName` |
| `Side` | `Int32` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Ditch` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.Ditch` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Ditch`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomWidth` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDisplayName, DefaultValue, RTCCategory, RTCDescription` |
| `InsideLedgeInc` | `Double` | `get/set` | No | `RTCDwgTagName, RTCCategory, RTCDescription, DefaultValue, RTCDisplayName` |
| `InsideLedgeLength` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDescription, RTCDwgTagName, RTCDisplayName` |
| `InsideSlopeInc` | `Double` | `get/set` | No | `RTCDescription, RTCDwgTagName, RTCCategory, DefaultValue, RTCDisplayName` |
| `LedgeLevelDifference` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDisplayName, DefaultValue, RTCDescription, RTCCategory` |
| `OutsideLedgeInc` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDisplayName, RTCDescription, DefaultValue, RTCCategory` |
| `OutsideLedgeLength` | `Double` | `get/set` | No | `RTCDescription, DefaultValue, RTCCategory, RTCDwgTagName, RTCDisplayName` |
| `OutsideSlopeInc` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDisplayName, RTCDescription, RTCDwgTagName` |
| `Side` | `Int32` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DitchByDepth` (class)

**Attributes**: [RTCImage, DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DitchByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.Ditch` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Ditch`
              - `Topomatic.Crs.Rail.DitchByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDwgTagName, DefaultValue, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DitchByElevation` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DitchByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.Ditch` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Ditch`
              - `Topomatic.Crs.Rail.DitchByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get/set` | No | `DefaultValue, RTCDwgTagName, RTCCategory, RTCDisplayName, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DitchWithDischarge` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DitchWithDischarge` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.DitchWithDischarge`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomInc` | `Double` | `get/set` | No | `RTCDescription, RTCCategory, RTCDisplayName, DefaultValue, RTCDwgTagName` |
| `LedgeInc` | `Double` | `get/set` | No | `RTCDescription, RTCDisplayName, RTCCategory, DefaultValue, RTCDwgTagName` |
| `LedgeLength` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, RTCDescription, DefaultValue, RTCDwgTagName` |
| `Side` | `Int32` | `get/set` | No | `` |
| `SlopeInc` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDisplayName, RTCDwgTagName, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DitchWithDischargeByDepth` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DitchWithDischargeByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.DitchWithDischarge` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.DitchWithDischarge`
              - `Topomatic.Crs.Rail.DitchWithDischargeByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `RTCCategory, RTCDwgTagName, DefaultValue, RTCDescription, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DitchWithDischargeByElevation` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DitchWithDischargeByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.DitchWithDischarge` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.DitchWithDischarge`
              - `Topomatic.Crs.Rail.DitchWithDischargeByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, DefaultValue, RTCCategory, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Drain` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.Drain` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomWidth` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDescription, RTCDisplayName, RTCDwgTagName` |
| `InsideSlopeInc` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, DefaultValue, RTCDwgTagName, RTCDescription` |
| `OutsideSlopeInc` | `Double` | `get/set` | No | `RTCDisplayName, RTCCategory, RTCDescription, DefaultValue, RTCDwgTagName` |
| `Side` | `Int32` | `get/set` | No | `RTCDescription, DefaultValue, RTCDisplayName, RTCCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainageBerm` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainageBerm` |
| **Base Type** | `Topomatic.Crs.Rail.Berm` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Berm`
              - `Topomatic.Crs.Rail.DrainageBerm`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BermOutEdgeElevation` | `Double` | `get/set` | No | `DefaultValue, RTCDescription, RTCDwgTagName, RTCCategory, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainageBottomFill` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainageBottomFill` |
| **Base Type** | `Topomatic.Crs.Rail.BottomFill` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.BottomFill`
              - `Topomatic.Crs.Rail.DrainageBottomFill`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomFillOutEdgeElevation` | `Double` | `get/set` | No | `RTCCategory, RTCDwgTagName, RTCDisplayName, RTCDescription, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainByElevation` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.Drain` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrainBottomElevation` | `Double` | `get/set` | No | `RTCDescription, RTCDwgTagName, RTCCategory, RTCDisplayName, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainFromSlope` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainFromSlope` |
| **Base Type** | `Topomatic.Crs.Rail.Drain` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainFromSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LedgeInc` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDwgTagName, DefaultValue, RTCDisplayName` |
| `Offset` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, DefaultValue, RTCDwgTagName, RTCCategory` |
| `OffsetType` | `Int32` | `get/set` | No | `RTCDisplayName, RTCCategory, RTCDescription, RTCDwgTagName, DefaultValue` |
| `Slope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainWithAddition` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainWithAddition` |
| **Base Type** | `Topomatic.Crs.Rail.DrainFromSlope` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainFromSlope`
                - `Topomatic.Crs.Rail.DrainWithAddition`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionGround` | `Int32` | `get/set` | No | `RTCDescription, DefaultValue, RTCCategory, RTCDisplayName, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainWithAdditionByDepth` (class)

**Attributes**: [CrsDesignInitializator, RTCImage, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainWithAdditionByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.DrainWithAddition` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainFromSlope`
                - `Topomatic.Crs.Rail.DrainWithAddition`
                  - `Topomatic.Crs.Rail.DrainWithAdditionByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDescription, RTCDisplayName, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainWithAdditionByElevation` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainWithAdditionByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.DrainWithAddition` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainFromSlope`
                - `Topomatic.Crs.Rail.DrainWithAddition`
                  - `Topomatic.Crs.Rail.DrainWithAdditionByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrainBottomElevation` | `Double` | `get/set` | No | `RTCDescription, RTCDwgTagName, RTCCategory, RTCDisplayName, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainWithCutting` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainWithCutting` |
| **Base Type** | `Topomatic.Crs.Rail.DrainFromSlope` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainFromSlope`
                - `Topomatic.Crs.Rail.DrainWithCutting`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainWithCuttingByDepth` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainWithCuttingByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.DrainWithCutting` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainFromSlope`
                - `Topomatic.Crs.Rail.DrainWithCutting`
                  - `Topomatic.Crs.Rail.DrainWithCuttingByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `DefaultValue, RTCDescription, RTCDisplayName, RTCCategory, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrainWithCuttingByElevation` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.DrainWithCuttingByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.DrainWithCutting` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.DrainFromSlope`
                - `Topomatic.Crs.Rail.DrainWithCutting`
                  - `Topomatic.Crs.Rail.DrainWithCuttingByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrainBottomElevation` | `Double` | `get/set` | No | `RTCDisplayName, DefaultValue, RTCDescription, RTCCategory, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FillSlope` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.FillSlope` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.FillSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FillSlopeFirstStepHeight` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDescription, DefaultValue, RTCCategory, RTCDisplayName` |
| `FillSlopeFirstStepInc` | `Double` | `get/set` | No | `DefaultValue, RTCDisplayName, RTCCategory, RTCDescription, RTCDwgTagName` |
| `FillSlopeLedge` | `Double` | `get/set` | No | `RTCDisplayName, RTCDwgTagName, DefaultValue, RTCDescription, RTCCategory` |
| `FillSlopeSecondStepHeight` | `Double` | `get/set` | No | `DefaultValue, RTCDisplayName, RTCDwgTagName, RTCDescription, RTCCategory` |
| `FillSlopeSecondStepInc` | `Double` | `get/set` | No | `DefaultValue, RTCDescription, RTCDisplayName, RTCDwgTagName, RTCCategory` |
| `FillSlopeThirdStepInc` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDisplayName, RTCDwgTagName, RTCDescription` |
| `Side` | `Int32` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Form1` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.Form1` |
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
              - `Topomatic.Crs.Rail.Form1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Geotextile` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.Geotextile` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CatchPoint` | `CrsNode` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileHalfLayer` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileHalfLayer` |
| **Base Type** | `Topomatic.Crs.Rail.Geotextile` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileHalfLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeotextileHalfLayerLength` | `Double` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCCategory, RTCDisplayName, RTCDescription` |
| `LayingHeight` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDwgTagName, RTCDisplayName, DefaultValue` |
| `Side` | `Int32` | `get/set` | No | `RTCDisplayName, RTCDescription, RTCCategory, RTCDwgTagName, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileHalfLayerByOffset` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileHalfLayerByOffset` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileHalfLayer` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileHalfLayer`
                - `Topomatic.Crs.Rail.GeotextileHalfLayerByOffset`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayingBorder` | `Double` | `get/set` | No | `RTCDescription, RTCCategory, DefaultValue, RTCDisplayName, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileHalfLayerToBorders` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileHalfLayerToBorders` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileHalfLayer` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileHalfLayer`
                - `Topomatic.Crs.Rail.GeotextileHalfLayerToBorders`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayingBorderOffset` | `Double` | `get/set` | No | `RTCDwgTagName, RTCCategory, DefaultValue, RTCDescription, RTCDisplayName` |
| `Slope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileHalfSleeve` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileHalfSleeve` |
| **Base Type** | `Topomatic.Crs.Rail.Geotextile` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileHalfSleeve`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bend` | `Double` | `get/set` | No | `DefaultValue, RTCDescription, RTCDisplayName, RTCCategory, RTCDwgTagName` |
| `GeotextileHalfSleeveLength` | `Double` | `get/set` | No | `DefaultValue, RTCDisplayName, RTCDwgTagName, RTCCategory, RTCDescription` |
| `LayingHeight` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, DefaultValue, RTCDwgTagName, RTCDescription` |
| `Side` | `Int32` | `get/set` | No | `RTCDisplayName, DefaultValue, RTCDescription, RTCCategory, RTCDwgTagName` |
| `SleeveSlopeInc` | `Double` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCCategory, RTCDescription, RTCDisplayName` |
| `SleeveWidth` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDwgTagName, RTCDisplayName, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileHalfSleeveByOffset` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileHalfSleeveByOffset` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileHalfSleeve` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileHalfSleeve`
                - `Topomatic.Crs.Rail.GeotextileHalfSleeveByOffset`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayingBorder` | `Double` | `get/set` | No | `RTCDescription, RTCDwgTagName, DefaultValue, RTCCategory, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileHalfSleeveToBorders` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileHalfSleeveToBorders` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileHalfSleeve` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileHalfSleeve`
                - `Topomatic.Crs.Rail.GeotextileHalfSleeveToBorders`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayingBorderOffset` | `Double` | `get/set` | No | `DefaultValue, RTCDwgTagName, RTCCategory, RTCDescription, RTCDisplayName` |
| `Slope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileInSlope` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileInSlope` |
| **Base Type** | `Topomatic.Crs.Rail.Geotextile` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileInSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawOffset` | `Double` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCDisplayName, RTCCategory, RTCDescription` |
| `LayingHeight` | `Double` | `get/set` | No | `DefaultValue, RTCDescription, RTCDisplayName, RTCCategory, RTCDwgTagName` |
| `Side` | `Int32` | `get/set` | No | `DefaultValue, RTCCategory, RTCDisplayName, RTCDwgTagName, RTCDescription` |
| `Slope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDirection` | `Int32` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileLayer` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileLayer` |
| **Base Type** | `Topomatic.Crs.Rail.Geotextile` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayingHeight` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, RTCDwgTagName, RTCCategory, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileLayerByOffsets` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileLayerByOffsets` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileLayer` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileLayer`
                - `Topomatic.Crs.Rail.GeotextileLayerByOffsets`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftLayingBorder` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDisplayName, RTCDwgTagName, DefaultValue` |
| `RightLayingBorder` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, DefaultValue, RTCDwgTagName, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileLayerToBorders` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileLayerToBorders` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileLayer` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileLayer`
                - `Topomatic.Crs.Rail.GeotextileLayerToBorders`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftLayingBorderOffset` | `Double` | `get/set` | No | `DefaultValue, RTCDisplayName, RTCDwgTagName, RTCCategory, RTCDescription` |
| `LeftSlope` | `CrsContour` | `get/set` | No | `Browsable` |
| `RightLayingBorderOffset` | `Double` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCDescription, RTCDisplayName, RTCCategory` |
| `RightSlope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileSleeve` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileSleeve` |
| **Base Type** | `Topomatic.Crs.Rail.Geotextile` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileSleeve`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bend` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDescription, DefaultValue, RTCDisplayName, RTCCategory` |
| `LayingHeight` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDescription, RTCCategory, RTCDisplayName, DefaultValue` |
| `SleeveSlopeInc` | `Double` | `get/set` | No | `RTCDescription, RTCDisplayName, DefaultValue, RTCCategory, RTCDwgTagName` |
| `SleeveWidth` | `Double` | `get/set` | No | `RTCCategory, DefaultValue, RTCDisplayName, RTCDwgTagName, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileSleeveByOffsets` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileSleeveByOffsets` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileSleeve` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileSleeve`
                - `Topomatic.Crs.Rail.GeotextileSleeveByOffsets`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftLayingBorder` | `Double` | `get/set` | No | `RTCDescription, RTCCategory, RTCDwgTagName, RTCDisplayName, DefaultValue` |
| `RightLayingBorder` | `Double` | `get/set` | No | `RTCDisplayName, RTCCategory, RTCDescription, RTCDwgTagName, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeotextileSleeveToBorders` (class)

**Attributes**: [RTCImage, CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.GeotextileSleeveToBorders` |
| **Base Type** | `Topomatic.Crs.Rail.GeotextileSleeve` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Geotextile`
              - `Topomatic.Crs.Rail.GeotextileSleeve`
                - `Topomatic.Crs.Rail.GeotextileSleeveToBorders`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftLayingBorderOffset` | `Double` | `get/set` | No | `RTCDescription, RTCDisplayName, DefaultValue, RTCCategory, RTCDwgTagName` |
| `LeftSlope` | `CrsContour` | `get/set` | No | `Browsable` |
| `RightLayingBorderOffset` | `Double` | `get/set` | No | `RTCDescription, RTCDisplayName, RTCCategory, RTCDwgTagName, DefaultValue` |
| `RightSlope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeatingBerm` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.HeatingBerm` |
| **Base Type** | `Topomatic.Crs.Rail.Berm` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Berm`
              - `Topomatic.Crs.Rail.HeatingBerm`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BermHeight` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDisplayName, DefaultValue, RTCCategory, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeatingBottomFill` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.HeatingBottomFill` |
| **Base Type** | `Topomatic.Crs.Rail.BottomFill` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.BottomFill`
              - `Topomatic.Crs.Rail.HeatingBottomFill`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomFillHeight` | `Double` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCDisplayName, RTCCategory, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ICrsConstructionSelectionCondition` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.ICrsConstructionSelectionCondition` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Condition` | `Boolean` | `RailCrsConstruction construction` | `` |

### `InterceptingChannel` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.InterceptingChannel` |
| **Base Type** | `Topomatic.Crs.Rail.Drain` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.InterceptingChannel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CatchPoint` | `CrsNode` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InterceptingChannelByDepth` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.InterceptingChannelByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.InterceptingChannel` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.InterceptingChannel`
                - `Topomatic.Crs.Rail.InterceptingChannelByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, RTCDescription, DefaultValue, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InterceptingChannelByDepthFromAxis` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.InterceptingChannelByDepthFromAxis` |
| **Base Type** | `Topomatic.Crs.Rail.InterceptingChannelByDepth` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.InterceptingChannel`
                - `Topomatic.Crs.Rail.InterceptingChannelByDepth`
                  - `Topomatic.Crs.Rail.InterceptingChannelByDepthFromAxis`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Offset` | `Double` | `get/set` | No | `RTCDescription, RTCCategory, RTCDwgTagName, DefaultValue, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InterceptingChannelByDepthFromCatchPoint` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.InterceptingChannelByDepthFromCatchPoint` |
| **Base Type** | `Topomatic.Crs.Rail.InterceptingChannelByDepth` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.InterceptingChannel`
                - `Topomatic.Crs.Rail.InterceptingChannelByDepth`
                  - `Topomatic.Crs.Rail.InterceptingChannelByDepthFromCatchPoint`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Offset` | `Double` | `get/set` | No | `RTCDescription, RTCDwgTagName, DefaultValue, RTCCategory, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InterceptingChannelByElevation` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.InterceptingChannelByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.InterceptingChannel` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.InterceptingChannel`
                - `Topomatic.Crs.Rail.InterceptingChannelByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrainBottomElevation` | `Double` | `get/set` | No | `DefaultValue, RTCDisplayName, RTCDwgTagName, RTCDescription, RTCCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InterceptingChannelByElevationFromAxis` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.InterceptingChannelByElevationFromAxis` |
| **Base Type** | `Topomatic.Crs.Rail.InterceptingChannelByElevation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.InterceptingChannel`
                - `Topomatic.Crs.Rail.InterceptingChannelByElevation`
                  - `Topomatic.Crs.Rail.InterceptingChannelByElevationFromAxis`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Offset` | `Double` | `get/set` | No | `RTCDisplayName, RTCCategory, RTCDwgTagName, DefaultValue, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `InterceptingChannelByElevationFromCatchPoint` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.InterceptingChannelByElevationFromCatchPoint` |
| **Base Type** | `Topomatic.Crs.Rail.InterceptingChannelByElevation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Drain`
              - `Topomatic.Crs.Rail.InterceptingChannel`
                - `Topomatic.Crs.Rail.InterceptingChannelByElevation`
                  - `Topomatic.Crs.Rail.InterceptingChannelByElevationFromCatchPoint`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Offset` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, RTCCategory, DefaultValue, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LayerCutting` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LayerCutting` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.LayerCutting`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerCuttingFillingGround` | `Int32` | `get/set` | No | `RTCDwgTagName, RTCDisplayName, DefaultValue, RTCCategory, RTCDescription` |
| `LeftSlope` | `CrsContour` | `get/set` | No | `Browsable` |
| `RightSlope` | `CrsContour` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LayerCuttingParallelToEG` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LayerCuttingParallelToEG` |
| **Base Type** | `Topomatic.Crs.Rail.LayerCutting` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.LayerCutting`
              - `Topomatic.Crs.Rail.LayerCuttingParallelToEG`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `RTCDisplayName, RTCDwgTagName, RTCDescription, DefaultValue, RTCCategory` |
| `LeftLedge` | `Double` | `get/set` | No | `RTCDisplayName, RTCCategory, RTCDwgTagName, DefaultValue, RTCDescription` |
| `RightLedge` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, RTCDescription, DefaultValue, RTCDwgTagName` |
| `SlopesInclination` | `Double` | `get/set` | No | `RTCDisplayName, RTCCategory, RTCDwgTagName, RTCDescription, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LayerCuttingToCutSlopes` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LayerCuttingToCutSlopes` |
| **Base Type** | `Topomatic.Crs.Rail.LayerCutting` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.LayerCutting`
              - `Topomatic.Crs.Rail.LayerCuttingToCutSlopes`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `RTCDescription, DefaultValue, RTCDwgTagName, RTCDisplayName, RTCCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LayerCuttingWithInclinationAndSlope` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LayerCuttingWithInclinationAndSlope` |
| **Base Type** | `Topomatic.Crs.Rail.LayerCutting` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.LayerCutting`
              - `Topomatic.Crs.Rail.LayerCuttingWithInclinationAndSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomInclination` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDwgTagName, RTCDisplayName, RTCDescription` |
| `Depth` | `Double` | `get/set` | No | `RTCDwgTagName, RTCCategory, RTCDescription, DefaultValue, RTCDisplayName` |
| `LeftLedge` | `Double` | `get/set` | No | `RTCDwgTagName, DefaultValue, RTCDisplayName, RTCCategory, RTCDescription` |
| `RightLedge` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDescription, RTCDisplayName, DefaultValue, RTCCategory` |
| `SlopesInclination` | `Double` | `get/set` | No | `DefaultValue, RTCDwgTagName, RTCDescription, RTCCategory, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftCutSlope` (class)

**Attributes**: [RTCImage, CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LeftCutSlope` |
| **Base Type** | `Topomatic.Crs.Rail.CutSlope` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.CutSlope`
              - `Topomatic.Crs.Rail.LeftCutSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftDitchByDepth` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LeftDitchByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.DitchByDepth` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Ditch`
              - `Topomatic.Crs.Rail.DitchByDepth`
                - `Topomatic.Crs.Rail.LeftDitchByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftDitchByElevation` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LeftDitchByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.DitchByElevation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Ditch`
              - `Topomatic.Crs.Rail.DitchByElevation`
                - `Topomatic.Crs.Rail.LeftDitchByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftDitchWithDischargeByDepth` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LeftDitchWithDischargeByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.DitchWithDischargeByDepth` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.DitchWithDischarge`
              - `Topomatic.Crs.Rail.DitchWithDischargeByDepth`
                - `Topomatic.Crs.Rail.LeftDitchWithDischargeByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftDitchWithDischargeByElevation` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LeftDitchWithDischargeByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.DitchWithDischargeByElevation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.DitchWithDischarge`
              - `Topomatic.Crs.Rail.DitchWithDischargeByElevation`
                - `Topomatic.Crs.Rail.LeftDitchWithDischargeByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftFillSlope` (class)

**Attributes**: [CrsDesignInitializator, RTCImage, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.LeftFillSlope` |
| **Base Type** | `Topomatic.Crs.Rail.FillSlope` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.FillSlope`
              - `Topomatic.Crs.Rail.LeftFillSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Pillow` (class)

**Attributes**: [CrsDesignInitializator, DisplayName, RTCImage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.Pillow` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Pillow`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PillowBottomInclination` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, DefaultValue, RTCDwgTagName, RTCCategory` |
| `PillowGround` | `Int32` | `get/set` | No | `RTCDisplayName, RTCDwgTagName, RTCCategory, DefaultValue, RTCDescription` |
| `PillowHeight` | `Double` | `get/set` | No | `RTCDisplayName, RTCDwgTagName, DefaultValue, RTCCategory, RTCDescription` |
| `PillowLeftSlopeInclination` | `Double` | `get/set` | No | `RTCDisplayName, DefaultValue, RTCCategory, RTCDescription, RTCDwgTagName` |
| `PillowRightSlopeInclination` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDisplayName, DefaultValue, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailConstructionDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RailConstructionDlg` |
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
                - `Topomatic.Crs.Rail.RailConstructionDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Construction` | `RailCrsConstruction` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailCrsConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsSemanticConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<VolumeData> data)`
- `.ctor(Int32 code)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElementType` | `Int32` | `get/set` | No | `Browsable` |
| `X0` | `Double` | `get` | No | `DesignerSerializationVisibility, Browsable` |
| `Y0` | `Double` | `get` | No | `Browsable, DesignerSerializationVisibility` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ChangeContourDirection` | `Void` | `CrsContour contour` | `` |
| `ClipLineWithConstruction` | `CrsNode` | `CrsContour line, CrsContainer container` | `` |
| `ClipLineWithConstruction` | `CrsNode` | `CrsContour line, CrsContainer container, Int32 direction` | `` |
| `ClipSegmentWithConstruction` | `CrsNode` | `CrsNode node1, CrsNode node2, CrsContainer container, Int32 index, Int32 code` | `` |
| `EGY` | `Double` | `Double offset` | `Browsable` |
| `EGY0` | `Double` | `` | `Browsable` |
| `GetContours` | `IEnumerable<CrsContour>` | `` | `` |
| `GetContoursIntersection` | `CrsNode` | `CrsContour contour1, CrsContour contour2, Int32 index` | `` |
| `GetEdge` | `CrsNode` | `CrsContour contour, Int32 side` | `` |
| `GetSegmentAndContourIntersection` | `CrsNode` | `CrsNode node1, CrsNode node2, CrsContour contour, Int32 index` | `` |
| `GetSegmentsIntersection` | `CrsNode` | `CrsNode node1_1, CrsNode node1_2, CrsNode node2_1, CrsNode node2_2` | `` |
| `LinkConstructionByElementType` | `RailCrsConstruction` | `Int32 elementType` | `` |
| `LinkConstructionByElementType` | `RailCrsConstruction` | `Int32 elementType, ICrsConstructionSelectionCondition selectionCondition` | `` |
| `LinkContourByCode` | `CrsContour` | `Int32 code, Int32 index` | `` |
| `LinkContourByCode` | `CrsContour` | `Int32 code` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `UnachievableCrsWidth` | `Double` | Yes | `` | `` |
| `UnachievableSlopeHeight` | `Double` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightCutSlope` (class)

**Attributes**: [CrsDesignInitializator, DisplayName, RTCImage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RightCutSlope` |
| **Base Type** | `Topomatic.Crs.Rail.CutSlope` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.CutSlope`
              - `Topomatic.Crs.Rail.RightCutSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightDitchByDepth` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RightDitchByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.DitchByDepth` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Ditch`
              - `Topomatic.Crs.Rail.DitchByDepth`
                - `Topomatic.Crs.Rail.RightDitchByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightDitchByElevation` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RightDitchByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.DitchByElevation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Ditch`
              - `Topomatic.Crs.Rail.DitchByElevation`
                - `Topomatic.Crs.Rail.RightDitchByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightDitchWithDischargeByDepth` (class)

**Attributes**: [DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RightDitchWithDischargeByDepth` |
| **Base Type** | `Topomatic.Crs.Rail.DitchWithDischargeByDepth` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.DitchWithDischarge`
              - `Topomatic.Crs.Rail.DitchWithDischargeByDepth`
                - `Topomatic.Crs.Rail.RightDitchWithDischargeByDepth`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightDitchWithDischargeByElevation` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RightDitchWithDischargeByElevation` |
| **Base Type** | `Topomatic.Crs.Rail.DitchWithDischargeByElevation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.DitchWithDischarge`
              - `Topomatic.Crs.Rail.DitchWithDischargeByElevation`
                - `Topomatic.Crs.Rail.RightDitchWithDischargeByElevation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightFillSlope` (class)

**Attributes**: [DisplayName, CrsDesignInitializator, RTCImage]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.RightFillSlope` |
| **Base Type** | `Topomatic.Crs.Rail.FillSlope` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.FillSlope`
              - `Topomatic.Crs.Rail.RightFillSlope`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StrengtheningBerm` (class)

**Attributes**: [DisplayName, RTCImage, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.StrengtheningBerm` |
| **Base Type** | `Topomatic.Crs.Rail.Berm` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.Berm`
              - `Topomatic.Crs.Rail.StrengtheningBerm`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TopFillHeight` | `Double` | `get/set` | No | `RTCDisplayName, RTCDwgTagName, RTCCategory, DefaultValue, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StrengtheningBottomFill` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.StrengtheningBottomFill` |
| **Base Type** | `Topomatic.Crs.Rail.BottomFill` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.BottomFill`
              - `Topomatic.Crs.Rail.StrengtheningBottomFill`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TopFillHeight` | `Double` | `get/set` | No | `RTCDescription, RTCCategory, DefaultValue, RTCDisplayName, RTCDwgTagName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TableBermRailCrsConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.TableBermRailCrsConstruction` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.TableBermRailCrsConstruction`

#### Constructors (1)

- `.ctor(IEnumerable<VolumeData> data, String aliace)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Aliace` | `String` | `get` | No | `Browsable` |
| `Prefix` | `String` | `get/set` | No | `CrsDesignPropertyProvider, SDCategory, SDDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrackFormation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.TrackFormation` |
| **Base Type** | `Topomatic.Crs.Rail.RailCrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.TrackFormation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLeftEgdeInclination` | `Double` | `` | `` |
| `GetRightEgdeInclination` | `Double` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrackFormationType1` (class)

**Attributes**: [RTCImage, DisplayName, CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.TrackFormationType1` |
| **Base Type** | `Topomatic.Crs.Rail.TrackFormation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.TrackFormation`
              - `Topomatic.Crs.Rail.TrackFormationType1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderHeight` | `Double` | `get/set` | No | `RTCDisplayName, RTCDwgTagName, DefaultValue, RTCCategory, RTCDescription` |
| `BorderInclination` | `Double` | `get/set` | No | `RTCDescription, RTCDisplayName, RTCCategory, RTCDwgTagName, DefaultValue` |
| `DischargePrismHeight` | `Double` | `get/set` | No | `RTCDescription, RTCDwgTagName, RTCCategory, DefaultValue, RTCDisplayName` |
| `LeftWidth` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, RTCDwgTagName, DefaultValue, RTCCategory` |
| `RightWidth` | `Double` | `get/set` | No | `RTCDisplayName, DefaultValue, RTCDwgTagName, RTCDescription, RTCCategory` |
| `WidthWithoutDischarge` | `Double` | `get/set` | No | `RTCDwgTagName, RTCDisplayName, RTCCategory, DefaultValue, RTCDescription` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrackFormationType2` (class)

**Attributes**: [CrsDesignInitializator, RTCImage, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.TrackFormationType2` |
| **Base Type** | `Topomatic.Crs.Rail.TrackFormation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.TrackFormation`
              - `Topomatic.Crs.Rail.TrackFormationType2`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderHeight` | `Double` | `get/set` | No | `RTCDisplayName, DefaultValue, RTCDescription, RTCDwgTagName, RTCCategory` |
| `BorderInclination` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDisplayName, RTCDescription, RTCDwgTagName` |
| `DRR` | `Double` | `get/set` | No | `RTCDisplayName, RTCCategory, DefaultValue, RTCDwgTagName, RTCDescription` |
| `IntertrackSpace` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, RTCDescription, DefaultValue, RTCDwgTagName` |
| `LeftWidth` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, DefaultValue, RTCDisplayName, RTCDwgTagName` |
| `RightWidth` | `Double` | `get/set` | No | `RTCCategory, RTCDwgTagName, RTCDisplayName, RTCDescription, DefaultValue` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrackFormationType3` (class)

**Attributes**: [CrsDesignInitializator, DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rail.TrackFormationType3` |
| **Base Type** | `Topomatic.Crs.Rail.TrackFormation` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Rail.RailCrsConstruction`
            - `Topomatic.Crs.Rail.TrackFormation`
              - `Topomatic.Crs.Rail.TrackFormationType3`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderHeight` | `Double` | `get/set` | No | `RTCCategory, DefaultValue, RTCDwgTagName, RTCDisplayName, RTCDescription` |
| `BorderInclination` | `Double` | `get/set` | No | `RTCDisplayName, RTCDescription, DefaultValue, RTCCategory, RTCDwgTagName` |
| `DischargePrismHeight` | `Double` | `get/set` | No | `DefaultValue, RTCCategory, RTCDescription, RTCDwgTagName, RTCDisplayName` |
| `IntertrackSpace` | `Double` | `get/set` | No | `RTCDisplayName, DefaultValue, RTCDwgTagName, RTCDescription, RTCCategory` |
| `LeftWidth` | `Double` | `get/set` | No | `RTCCategory, RTCDisplayName, RTCDwgTagName, RTCDescription, DefaultValue` |
| `RightWidth` | `Double` | `get/set` | No | `RTCCategory, RTCDescription, RTCDwgTagName, DefaultValue, RTCDisplayName` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Crs.Rbt`

### `IniNodeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.IniNodeType` |
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
      - `Topomatic.Crs.Rbt.IniNodeType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `KeyValuePair` | `IniNodeType` | Yes | `KeyValuePair` | `` |
| `Setion` | `IniNodeType` | Yes | `Setion` | `` |
| `Unknown` | `IniNodeType` | Yes | `Unknown` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Setion` | `0` |
| `KeyValuePair` | `1` |
| `Unknown` | `2` |

**Underlying Type**: `System.Int32`

### `IniReader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.IniReader` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Stream stream)`
- `.ctor(String fileName)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EOF` | `Boolean` | `get` | No | `` |
| `Line` | `Int32` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `NodeType` | `IniNodeType` | `get` | No | `` |
| `Value` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Read` | `Boolean` | `` | `` |
| `Skip` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `IniWriter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.IniWriter` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String fileName)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `WritePair` | `Void` | `String key, String value` | `` |
| `WriteSection` | `Void` | `String sectionName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `Rbt` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.Rbt` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromRbt` | `Void` | `Stream stream` | `` |
| `LoadFromRbt` | `Void` | `String fileName` | `` |
| `SaveToRbt` | `Void` | `String fileName` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `_LeftSlopeVisited` | `Boolean` | No | `` | `` |
| `_RightSlopeVisited` | `Boolean` | No | `` | `` |
| `General` | `RbtGeneral` | No | `` | `` |
| `LeftNodeCode` | `Int32` | Yes | `258` | `` |
| `LeftSlope` | `String` | Yes | `"leftSlope"` | `` |
| `Lines` | `RbtLine[]` | No | `` | `` |
| `Nodes` | `RbtNode[]` | No | `` | `` |
| `Rays` | `RbtRay[]` | No | `` | `` |
| `RightNodeCode` | `Int32` | Yes | `259` | `` |
| `RightSlope` | `String` | Yes | `"rightSlope"` | `` |
| `Settings` | `RbtProjectSettings` | No | `` | `` |
| `Variables` | `RbtVariable[]` | No | `` | `` |

### `RbtGeneral` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtGeneral` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Rbt.RbtGeneral`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Create` | `String` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `LineCount` | `Int32` | No | `` | `` |
| `NodeCount` | `Int32` | No | `` | `` |
| `RayCount` | `Int32` | No | `` | `` |
| `SectionName` | `String` | Yes | `"General"` | `` |
| `Version` | `Version` | No | `` | `` |

### `RbtGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtGenerator` |
| **Base Type** | `Topomatic.Crs.Ast.AstWalker` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstWalker`
    - `Topomatic.Crs.Rbt.RbtGenerator`

#### Constructors (1)

- `.ctor(TextWriter writer)`

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Boolean` | `AstParenthesisExpression node` | `` |
| `Walk` | `Boolean` | `AstConstantExpression node` | `` |
| `Walk` | `Boolean` | `AstArg node` | `` |
| `Walk` | `Boolean` | `AstCallExpression node` | `` |
| `Walk` | `Boolean` | `AstNameExpression node` | `` |
| `Walk` | `Boolean` | `AstAndExpression node` | `` |
| `Walk` | `Boolean` | `AstOrExpression node` | `` |
| `Walk` | `Boolean` | `AstUnaryExpression node` | `` |
| `Walk` | `Boolean` | `AstBinaryExpression node` | `` |

### `RbtInitializator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtInitializator` |
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
| `InitializeComponent` | `List<ActBaseComponent>` | `Rbt rbt` | `` |

### `RbtLine` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtLine` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Rbt.RbtLine`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code` | `Int32` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `FillCode` | `Int32` | No | `` | `` |
| `Items` | `Int32[]` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `SectionName` | `String` | Yes | `"Line"` | `` |
| `Tag` | `Int32` | No | `` | `` |

### `RbtLineTag` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtLineTag` |
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
      - `Topomatic.Crs.Rbt.RbtLineTag`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CalcVolume` | `RbtLineTag` | Yes | `CalcVolume` | `` |
| `LeftSlope` | `RbtLineTag` | Yes | `LeftSlope` | `` |
| `Reconstruction` | `RbtLineTag` | Yes | `Reconstruction` | `` |
| `RightSlope` | `RbtLineTag` | Yes | `RightSlope` | `` |
| `Unknown` | `RbtLineTag` | Yes | `Unknown` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftSlope` | `1` |
| `RightSlope` | `2` |
| `Reconstruction` | `4` |
| `CalcVolume` | `8` |
| `Unknown` | `16` |

**Underlying Type**: `System.Int32`

### `RbtNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtNode` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Rbt.RbtNode`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `_Visited` | `Boolean` | No | `` | `` |
| `CalcMode` | `RbtNodeCalcMode` | No | `` | `` |
| `Code` | `Int32` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `FirstRay` | `Int32` | No | `` | `` |
| `FormulaX` | `String` | No | `` | `` |
| `FormulaY` | `String` | No | `` | `` |
| `Link` | `Int32` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `SecondRay` | `Int32` | No | `` | `` |
| `SectionName` | `String` | Yes | `"Node"` | `` |

### `RbtNodeCalcMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtNodeCalcMode` |
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
      - `Topomatic.Crs.Rbt.RbtNodeCalcMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `_RayConstructionIntersection` | `RbtNodeCalcMode` | Yes | `_RayConstructionIntersection` | `` |
| `Absolute` | `RbtNodeCalcMode` | Yes | `Absolute` | `` |
| `RayIntersect` | `RbtNodeCalcMode` | Yes | `RayIntersect` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Absolute` | `0` |
| `RayIntersect` | `1` |
| `_RayConstructionIntersection` | `2` |

**Underlying Type**: `System.Int32`

### `RbtParser` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtParser` |
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
| `Parse` | `AstExpression` | `String expression` | `` |

### `RbtProjectSettings` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtProjectSettings` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Rbt.RbtProjectSettings`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BaseAxisColor` | `Color` | No | `` | `` |
| `EditorBackgroundColor` | `Color` | No | `` | `` |
| `LinesColor` | `Color` | No | `` | `` |
| `NodeColor` | `Color` | No | `` | `` |
| `NodeMarkersColor` | `Color` | No | `` | `` |
| `RaysColor` | `Color` | No | `` | `` |
| `SectionName` | `String` | Yes | `"ProjectSettings"` | `` |

### `RbtRay` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtRay` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Rbt.RbtRay`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `_Visited` | `Boolean` | No | `` | `` |
| `CalcMode` | `RbtRayCalcMode` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `FormulaDirect` | `String` | No | `` | `` |
| `Link` | `Int32` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `SectionName` | `String` | Yes | `"Ray"` | `` |

### `RbtRayCalcMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtRayCalcMode` |
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
      - `Topomatic.Crs.Rbt.RbtRayCalcMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TwoNodes` | `RbtRayCalcMode` | Yes | `TwoNodes` | `` |
| `value__` | `Int32` | No | `` | `` |
| `X` | `RbtRayCalcMode` | Yes | `X` | `` |
| `Y` | `RbtRayCalcMode` | Yes | `Y` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Y` | `0` |
| `X` | `1` |
| `TwoNodes` | `2` |

**Underlying Type**: `System.Int32`

### `RbtVariable` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtVariable` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Rbt.RbtVariable`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultsSectionName` | `String` | Yes | `"VariablesDefaults"` | `` |
| `Description` | `String` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `SectionName` | `String` | Yes | `"Variables"` | `` |
| `Value` | `Double` | No | `` | `` |

### `RbtVariableIndex` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtVariableIndex` |
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
      - `Topomatic.Crs.Rbt.RbtVariableIndex`

#### Fields (139)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `H1` | `RbtVariableIndex` | Yes | `H1` | `` |
| `H2` | `RbtVariableIndex` | Yes | `H2` | `` |
| `H3` | `RbtVariableIndex` | Yes | `H3` | `` |
| `H4` | `RbtVariableIndex` | Yes | `H4` | `` |
| `LOFFSX1` | `RbtVariableIndex` | Yes | `LOFFSX1` | `` |
| `LOFFSX2` | `RbtVariableIndex` | Yes | `LOFFSX2` | `` |
| `LOFFSX3` | `RbtVariableIndex` | Yes | `LOFFSX3` | `` |
| `LOFFSX4` | `RbtVariableIndex` | Yes | `LOFFSX4` | `` |
| `LOFFSX5` | `RbtVariableIndex` | Yes | `LOFFSX5` | `` |
| `LOFFSX6` | `RbtVariableIndex` | Yes | `LOFFSX6` | `` |
| `LOFFSX7` | `RbtVariableIndex` | Yes | `LOFFSX7` | `` |
| `LOFFSX8` | `RbtVariableIndex` | Yes | `LOFFSX8` | `` |
| `LOFFSY1` | `RbtVariableIndex` | Yes | `LOFFSY1` | `` |
| `LOFFSY2` | `RbtVariableIndex` | Yes | `LOFFSY2` | `` |
| `LOFFSY3` | `RbtVariableIndex` | Yes | `LOFFSY3` | `` |
| `LOFFSY4` | `RbtVariableIndex` | Yes | `LOFFSY4` | `` |
| `LOFFSY5` | `RbtVariableIndex` | Yes | `LOFFSY5` | `` |
| `LOFFSY6` | `RbtVariableIndex` | Yes | `LOFFSY6` | `` |
| `LOFFSY7` | `RbtVariableIndex` | Yes | `LOFFSY7` | `` |
| `LOFFSY8` | `RbtVariableIndex` | Yes | `LOFFSY8` | `` |
| `LS1` | `RbtVariableIndex` | Yes | `LS1` | `` |
| `LS2` | `RbtVariableIndex` | Yes | `LS2` | `` |
| `LS3` | `RbtVariableIndex` | Yes | `LS3` | `` |
| `LS4` | `RbtVariableIndex` | Yes | `LS4` | `` |
| `LX1` | `RbtVariableIndex` | Yes | `LX1` | `` |
| `LX2` | `RbtVariableIndex` | Yes | `LX2` | `` |
| `LX3` | `RbtVariableIndex` | Yes | `LX3` | `` |
| `LX4` | `RbtVariableIndex` | Yes | `LX4` | `` |
| `LX5` | `RbtVariableIndex` | Yes | `LX5` | `` |
| `LX6` | `RbtVariableIndex` | Yes | `LX6` | `` |
| `LX7` | `RbtVariableIndex` | Yes | `LX7` | `` |
| `LX8` | `RbtVariableIndex` | Yes | `LX8` | `` |
| `LY1` | `RbtVariableIndex` | Yes | `LY1` | `` |
| `LY2` | `RbtVariableIndex` | Yes | `LY2` | `` |
| `LY3` | `RbtVariableIndex` | Yes | `LY3` | `` |
| `LY4` | `RbtVariableIndex` | Yes | `LY4` | `` |
| `LY5` | `RbtVariableIndex` | Yes | `LY5` | `` |
| `LY6` | `RbtVariableIndex` | Yes | `LY6` | `` |
| `LY7` | `RbtVariableIndex` | Yes | `LY7` | `` |
| `LY8` | `RbtVariableIndex` | Yes | `LY8` | `` |
| `P1` | `RbtVariableIndex` | Yes | `P1` | `` |
| `P10` | `RbtVariableIndex` | Yes | `P10` | `` |
| `P2` | `RbtVariableIndex` | Yes | `P2` | `` |
| `P3` | `RbtVariableIndex` | Yes | `P3` | `` |
| `P4` | `RbtVariableIndex` | Yes | `P4` | `` |
| `P5` | `RbtVariableIndex` | Yes | `P5` | `` |
| `P6` | `RbtVariableIndex` | Yes | `P6` | `` |
| `P7` | `RbtVariableIndex` | Yes | `P7` | `` |
| `P8` | `RbtVariableIndex` | Yes | `P8` | `` |
| `P9` | `RbtVariableIndex` | Yes | `P9` | `` |
| `ROFFSX1` | `RbtVariableIndex` | Yes | `ROFFSX1` | `` |
| `ROFFSX2` | `RbtVariableIndex` | Yes | `ROFFSX2` | `` |
| `ROFFSX3` | `RbtVariableIndex` | Yes | `ROFFSX3` | `` |
| `ROFFSX4` | `RbtVariableIndex` | Yes | `ROFFSX4` | `` |
| `ROFFSX5` | `RbtVariableIndex` | Yes | `ROFFSX5` | `` |
| `ROFFSX6` | `RbtVariableIndex` | Yes | `ROFFSX6` | `` |
| `ROFFSX7` | `RbtVariableIndex` | Yes | `ROFFSX7` | `` |
| `ROFFSX8` | `RbtVariableIndex` | Yes | `ROFFSX8` | `` |
| `ROFFSY1` | `RbtVariableIndex` | Yes | `ROFFSY1` | `` |
| `ROFFSY2` | `RbtVariableIndex` | Yes | `ROFFSY2` | `` |
| `ROFFSY3` | `RbtVariableIndex` | Yes | `ROFFSY3` | `` |
| `ROFFSY4` | `RbtVariableIndex` | Yes | `ROFFSY4` | `` |
| `ROFFSY5` | `RbtVariableIndex` | Yes | `ROFFSY5` | `` |
| `ROFFSY6` | `RbtVariableIndex` | Yes | `ROFFSY6` | `` |
| `ROFFSY7` | `RbtVariableIndex` | Yes | `ROFFSY7` | `` |
| `ROFFSY8` | `RbtVariableIndex` | Yes | `ROFFSY8` | `` |
| `RS1` | `RbtVariableIndex` | Yes | `RS1` | `` |
| `RS2` | `RbtVariableIndex` | Yes | `RS2` | `` |
| `RS3` | `RbtVariableIndex` | Yes | `RS3` | `` |
| `RS4` | `RbtVariableIndex` | Yes | `RS4` | `` |
| `RX1` | `RbtVariableIndex` | Yes | `RX1` | `` |
| `RX2` | `RbtVariableIndex` | Yes | `RX2` | `` |
| `RX3` | `RbtVariableIndex` | Yes | `RX3` | `` |
| `RX4` | `RbtVariableIndex` | Yes | `RX4` | `` |
| `RX5` | `RbtVariableIndex` | Yes | `RX5` | `` |
| `RX6` | `RbtVariableIndex` | Yes | `RX6` | `` |
| `RX7` | `RbtVariableIndex` | Yes | `RX7` | `` |
| `RX8` | `RbtVariableIndex` | Yes | `RX8` | `` |
| `RY1` | `RbtVariableIndex` | Yes | `RY1` | `` |
| `RY2` | `RbtVariableIndex` | Yes | `RY2` | `` |
| `RY3` | `RbtVariableIndex` | Yes | `RY3` | `` |
| `RY4` | `RbtVariableIndex` | Yes | `RY4` | `` |
| `RY5` | `RbtVariableIndex` | Yes | `RY5` | `` |
| `RY6` | `RbtVariableIndex` | Yes | `RY6` | `` |
| `RY7` | `RbtVariableIndex` | Yes | `RY7` | `` |
| `RY8` | `RbtVariableIndex` | Yes | `RY8` | `` |
| `V1` | `RbtVariableIndex` | Yes | `V1` | `` |
| `V10` | `RbtVariableIndex` | Yes | `V10` | `` |
| `V11` | `RbtVariableIndex` | Yes | `V11` | `` |
| `V12` | `RbtVariableIndex` | Yes | `V12` | `` |
| `V13` | `RbtVariableIndex` | Yes | `V13` | `` |
| `V14` | `RbtVariableIndex` | Yes | `V14` | `` |
| `V15` | `RbtVariableIndex` | Yes | `V15` | `` |
| `V16` | `RbtVariableIndex` | Yes | `V16` | `` |
| `V17` | `RbtVariableIndex` | Yes | `V17` | `` |
| `V18` | `RbtVariableIndex` | Yes | `V18` | `` |
| `V19` | `RbtVariableIndex` | Yes | `V19` | `` |
| `V2` | `RbtVariableIndex` | Yes | `V2` | `` |
| `V20` | `RbtVariableIndex` | Yes | `V20` | `` |
| `V21` | `RbtVariableIndex` | Yes | `V21` | `` |
| `V22` | `RbtVariableIndex` | Yes | `V22` | `` |
| `V23` | `RbtVariableIndex` | Yes | `V23` | `` |
| `V24` | `RbtVariableIndex` | Yes | `V24` | `` |
| `V25` | `RbtVariableIndex` | Yes | `V25` | `` |
| `V26` | `RbtVariableIndex` | Yes | `V26` | `` |
| `V27` | `RbtVariableIndex` | Yes | `V27` | `` |
| `V28` | `RbtVariableIndex` | Yes | `V28` | `` |
| `V29` | `RbtVariableIndex` | Yes | `V29` | `` |
| `V3` | `RbtVariableIndex` | Yes | `V3` | `` |
| `V30` | `RbtVariableIndex` | Yes | `V30` | `` |
| `V31` | `RbtVariableIndex` | Yes | `V31` | `` |
| `V32` | `RbtVariableIndex` | Yes | `V32` | `` |
| `V33` | `RbtVariableIndex` | Yes | `V33` | `` |
| `V34` | `RbtVariableIndex` | Yes | `V34` | `` |
| `V35` | `RbtVariableIndex` | Yes | `V35` | `` |
| `V36` | `RbtVariableIndex` | Yes | `V36` | `` |
| `V37` | `RbtVariableIndex` | Yes | `V37` | `` |
| `V38` | `RbtVariableIndex` | Yes | `V38` | `` |
| `V39` | `RbtVariableIndex` | Yes | `V39` | `` |
| `V4` | `RbtVariableIndex` | Yes | `V4` | `` |
| `V40` | `RbtVariableIndex` | Yes | `V40` | `` |
| `V41` | `RbtVariableIndex` | Yes | `V41` | `` |
| `V42` | `RbtVariableIndex` | Yes | `V42` | `` |
| `V43` | `RbtVariableIndex` | Yes | `V43` | `` |
| `V44` | `RbtVariableIndex` | Yes | `V44` | `` |
| `V45` | `RbtVariableIndex` | Yes | `V45` | `` |
| `V46` | `RbtVariableIndex` | Yes | `V46` | `` |
| `V47` | `RbtVariableIndex` | Yes | `V47` | `` |
| `V48` | `RbtVariableIndex` | Yes | `V48` | `` |
| `V49` | `RbtVariableIndex` | Yes | `V49` | `` |
| `V5` | `RbtVariableIndex` | Yes | `V5` | `` |
| `V50` | `RbtVariableIndex` | Yes | `V50` | `` |
| `V6` | `RbtVariableIndex` | Yes | `V6` | `` |
| `V7` | `RbtVariableIndex` | Yes | `V7` | `` |
| `V8` | `RbtVariableIndex` | Yes | `V8` | `` |
| `V9` | `RbtVariableIndex` | Yes | `V9` | `` |
| `value__` | `Int32` | No | `` | `` |
| `X0` | `RbtVariableIndex` | Yes | `X0` | `` |
| `Y0` | `RbtVariableIndex` | Yes | `Y0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LX1` | `0` |
| `LX2` | `1` |
| `LX3` | `2` |
| `LX4` | `3` |
| `LX5` | `4` |
| `LX6` | `5` |
| `LX7` | `6` |
| `LX8` | `7` |
| `RX1` | `8` |
| `RX2` | `9` |
| `RX3` | `10` |
| `RX4` | `11` |
| `RX5` | `12` |
| `RX6` | `13` |
| `RX7` | `14` |
| `RX8` | `15` |
| `LOFFSX1` | `16` |
| `LOFFSX2` | `17` |
| `LOFFSX3` | `18` |
| `LOFFSX4` | `19` |
| `LOFFSX5` | `20` |
| `LOFFSX6` | `21` |
| `LOFFSX7` | `22` |
| `LOFFSX8` | `23` |
| `ROFFSX1` | `24` |
| `ROFFSX2` | `25` |
| `ROFFSX3` | `26` |
| `ROFFSX4` | `27` |
| `ROFFSX5` | `28` |
| `ROFFSX6` | `29` |
| `ROFFSX7` | `30` |
| `ROFFSX8` | `31` |
| `LY1` | `32` |
| `LY2` | `33` |
| `LY3` | `34` |
| `LY4` | `35` |
| `LY5` | `36` |
| `LY6` | `37` |
| `LY7` | `38` |
| `LY8` | `39` |
| `RY1` | `40` |
| `RY2` | `41` |
| `RY3` | `42` |
| `RY4` | `43` |
| `RY5` | `44` |
| `RY6` | `45` |
| `RY7` | `46` |
| `RY8` | `47` |
| `LOFFSY1` | `48` |
| `LOFFSY2` | `49` |
| `LOFFSY3` | `50` |
| `LOFFSY4` | `51` |
| `LOFFSY5` | `52` |
| `LOFFSY6` | `53` |
| `LOFFSY7` | `54` |
| `LOFFSY8` | `55` |
| `ROFFSY1` | `56` |
| `ROFFSY2` | `57` |
| `ROFFSY3` | `58` |
| `ROFFSY4` | `59` |
| `ROFFSY5` | `60` |
| `ROFFSY6` | `61` |
| `ROFFSY7` | `62` |
| `ROFFSY8` | `63` |
| `H1` | `64` |
| `H2` | `65` |
| `H3` | `66` |
| `H4` | `67` |
| `LS1` | `68` |
| `LS2` | `69` |
| `LS3` | `70` |
| `LS4` | `71` |
| `RS1` | `72` |
| `RS2` | `73` |
| `RS3` | `74` |
| `RS4` | `75` |
| `X0` | `76` |
| `Y0` | `77` |
| `V1` | `78` |
| `V2` | `79` |
| `V3` | `80` |
| `V4` | `81` |
| `V5` | `82` |
| `V6` | `83` |
| `V7` | `84` |
| `V8` | `85` |
| `V9` | `86` |
| `V10` | `87` |
| `V11` | `88` |
| `V12` | `89` |
| `V13` | `90` |
| `V14` | `91` |
| `V15` | `92` |
| `V16` | `93` |
| `V17` | `94` |
| `V18` | `95` |
| `V19` | `96` |
| `V20` | `97` |
| `V21` | `98` |
| `V22` | `99` |
| `V23` | `100` |
| `V24` | `101` |
| `V25` | `102` |
| `V26` | `103` |
| `V27` | `104` |
| `V28` | `105` |
| `V29` | `106` |
| `V30` | `107` |
| `V31` | `108` |
| `V32` | `109` |
| `V33` | `110` |
| `V34` | `111` |
| `V35` | `112` |
| `V36` | `113` |
| `V37` | `114` |
| `V38` | `115` |
| `V39` | `116` |
| `V40` | `117` |
| `V41` | `118` |
| `V42` | `119` |
| `V43` | `120` |
| `V44` | `121` |
| `V45` | `122` |
| `V46` | `123` |
| `V47` | `124` |
| `V48` | `125` |
| `V49` | `126` |
| `V50` | `127` |
| `P1` | `128` |
| `P2` | `129` |
| `P3` | `130` |
| `P4` | `131` |
| `P5` | `132` |
| `P6` | `133` |
| `P7` | `134` |
| `P8` | `135` |
| `P9` | `136` |
| `P10` | `137` |

**Underlying Type**: `System.Int32`

### `RbtVariableWalker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Rbt.RbtVariableWalker` |
| **Base Type** | `Topomatic.Crs.Ast.AstWalker` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Ast.AstWalker`
    - `Topomatic.Crs.Rbt.RbtVariableWalker`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Walk` | `Boolean` | `AstNameExpression node` | `` |

---
## Namespace: `Topomatic.Crs.Road`

### `Aliace` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.VolumesBuilder+Aliace` |
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
      - `Topomatic.Crs.Road.VolumesBuilder+Aliace`

#### Fields (54)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CUT` | `Aliace` | Yes | `CUT` | `` |
| `CUT_SLOPE` | `Aliace` | Yes | `CUT_SLOPE` | `` |
| `DITCH_BOTTOM` | `Aliace` | Yes | `DITCH_BOTTOM` | `` |
| `DITCH_CUT` | `Aliace` | Yes | `DITCH_CUT` | `` |
| `DITCH_SLOPE` | `Aliace` | Yes | `DITCH_SLOPE` | `` |
| `EXISITING_CONSTRUCTION_REPLACE` | `Aliace` | Yes | `EXISITING_CONSTRUCTION_REPLACE` | `` |
| `FILL` | `Aliace` | Yes | `FILL` | `` |
| `FILL_LAYER_1` | `Aliace` | Yes | `FILL_LAYER_1` | `` |
| `FILL_LAYER_10` | `Aliace` | Yes | `FILL_LAYER_10` | `` |
| `FILL_LAYER_11` | `Aliace` | Yes | `FILL_LAYER_11` | `` |
| `FILL_LAYER_12` | `Aliace` | Yes | `FILL_LAYER_12` | `` |
| `FILL_LAYER_13` | `Aliace` | Yes | `FILL_LAYER_13` | `` |
| `FILL_LAYER_14` | `Aliace` | Yes | `FILL_LAYER_14` | `` |
| `FILL_LAYER_15` | `Aliace` | Yes | `FILL_LAYER_15` | `` |
| `FILL_LAYER_16` | `Aliace` | Yes | `FILL_LAYER_16` | `` |
| `FILL_LAYER_17` | `Aliace` | Yes | `FILL_LAYER_17` | `` |
| `FILL_LAYER_18` | `Aliace` | Yes | `FILL_LAYER_18` | `` |
| `FILL_LAYER_19` | `Aliace` | Yes | `FILL_LAYER_19` | `` |
| `FILL_LAYER_2` | `Aliace` | Yes | `FILL_LAYER_2` | `` |
| `FILL_LAYER_20` | `Aliace` | Yes | `FILL_LAYER_20` | `` |
| `FILL_LAYER_21` | `Aliace` | Yes | `FILL_LAYER_21` | `` |
| `FILL_LAYER_22` | `Aliace` | Yes | `FILL_LAYER_22` | `` |
| `FILL_LAYER_23` | `Aliace` | Yes | `FILL_LAYER_23` | `` |
| `FILL_LAYER_24` | `Aliace` | Yes | `FILL_LAYER_24` | `` |
| `FILL_LAYER_25` | `Aliace` | Yes | `FILL_LAYER_25` | `` |
| `FILL_LAYER_26` | `Aliace` | Yes | `FILL_LAYER_26` | `` |
| `FILL_LAYER_27` | `Aliace` | Yes | `FILL_LAYER_27` | `` |
| `FILL_LAYER_28` | `Aliace` | Yes | `FILL_LAYER_28` | `` |
| `FILL_LAYER_29` | `Aliace` | Yes | `FILL_LAYER_29` | `` |
| `FILL_LAYER_3` | `Aliace` | Yes | `FILL_LAYER_3` | `` |
| `FILL_LAYER_30` | `Aliace` | Yes | `FILL_LAYER_30` | `` |
| `FILL_LAYER_31` | `Aliace` | Yes | `FILL_LAYER_31` | `` |
| `FILL_LAYER_32` | `Aliace` | Yes | `FILL_LAYER_32` | `` |
| `FILL_LAYER_33` | `Aliace` | Yes | `FILL_LAYER_33` | `` |
| `FILL_LAYER_34` | `Aliace` | Yes | `FILL_LAYER_34` | `` |
| `FILL_LAYER_35` | `Aliace` | Yes | `FILL_LAYER_35` | `` |
| `FILL_LAYER_36` | `Aliace` | Yes | `FILL_LAYER_36` | `` |
| `FILL_LAYER_37` | `Aliace` | Yes | `FILL_LAYER_37` | `` |
| `FILL_LAYER_38` | `Aliace` | Yes | `FILL_LAYER_38` | `` |
| `FILL_LAYER_39` | `Aliace` | Yes | `FILL_LAYER_39` | `` |
| `FILL_LAYER_4` | `Aliace` | Yes | `FILL_LAYER_4` | `` |
| `FILL_LAYER_40` | `Aliace` | Yes | `FILL_LAYER_40` | `` |
| `FILL_LAYER_5` | `Aliace` | Yes | `FILL_LAYER_5` | `` |
| `FILL_LAYER_6` | `Aliace` | Yes | `FILL_LAYER_6` | `` |
| `FILL_LAYER_7` | `Aliace` | Yes | `FILL_LAYER_7` | `` |
| `FILL_LAYER_8` | `Aliace` | Yes | `FILL_LAYER_8` | `` |
| `FILL_LAYER_9` | `Aliace` | Yes | `FILL_LAYER_9` | `` |
| `FILL_SLOPE` | `Aliace` | Yes | `FILL_SLOPE` | `` |
| `PLANNING_A` | `Aliace` | Yes | `PLANNING_A` | `` |
| `PLANNING_M1` | `Aliace` | Yes | `PLANNING_M1` | `` |
| `PLANNING_M2` | `Aliace` | Yes | `PLANNING_M2` | `` |
| `PLANNING_M3` | `Aliace` | Yes | `PLANNING_M3` | `` |
| `PLANNING_M4` | `Aliace` | Yes | `PLANNING_M4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FILL` | `0` |
| `CUT` | `1` |
| `DITCH_CUT` | `2` |
| `CUT_SLOPE` | `3` |
| `FILL_SLOPE` | `4` |
| `DITCH_SLOPE` | `5` |
| `DITCH_BOTTOM` | `6` |
| `EXISITING_CONSTRUCTION_REPLACE` | `7` |
| `PLANNING_M1` | `8` |
| `PLANNING_M2` | `9` |
| `PLANNING_M3` | `10` |
| `PLANNING_M4` | `11` |
| `PLANNING_A` | `12` |
| `FILL_LAYER_1` | `13` |
| `FILL_LAYER_2` | `14` |
| `FILL_LAYER_3` | `15` |
| `FILL_LAYER_4` | `16` |
| `FILL_LAYER_5` | `17` |
| `FILL_LAYER_6` | `18` |
| `FILL_LAYER_7` | `19` |
| `FILL_LAYER_8` | `20` |
| `FILL_LAYER_9` | `21` |
| `FILL_LAYER_10` | `22` |
| `FILL_LAYER_11` | `23` |
| `FILL_LAYER_12` | `24` |
| `FILL_LAYER_13` | `25` |
| `FILL_LAYER_14` | `26` |
| `FILL_LAYER_15` | `27` |
| `FILL_LAYER_16` | `28` |
| `FILL_LAYER_17` | `29` |
| `FILL_LAYER_18` | `30` |
| `FILL_LAYER_19` | `31` |
| `FILL_LAYER_20` | `32` |
| `FILL_LAYER_21` | `33` |
| `FILL_LAYER_22` | `34` |
| `FILL_LAYER_23` | `35` |
| `FILL_LAYER_24` | `36` |
| `FILL_LAYER_25` | `37` |
| `FILL_LAYER_26` | `38` |
| `FILL_LAYER_27` | `39` |
| `FILL_LAYER_28` | `40` |
| `FILL_LAYER_29` | `41` |
| `FILL_LAYER_30` | `42` |
| `FILL_LAYER_31` | `43` |
| `FILL_LAYER_32` | `44` |
| `FILL_LAYER_33` | `45` |
| `FILL_LAYER_34` | `46` |
| `FILL_LAYER_35` | `47` |
| `FILL_LAYER_36` | `48` |
| `FILL_LAYER_37` | `49` |
| `FILL_LAYER_38` | `50` |
| `FILL_LAYER_39` | `51` |
| `FILL_LAYER_40` | `52` |

**Underlying Type**: `System.Int32`

### `BorderItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadRenewConstruction+BorderItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlackElevation` | `Double` | `get` | No | `` |
| `Offset` | `Double` | `get` | No | `` |
| `RedElevation` | `Double` | `get` | No | `` |
| `WorkElevation` | `Double` | `get` | No | `` |

### `BorderLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadRenewConstruction+BorderLayer` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |
| `Thick` | `Double` | `get` | No | `` |

### `IRenewLayer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.IRenewLayer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerType` | `RenewLayerType` | `get` | No | `` |
| `MinThick` | `Double` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Thick` | `Double` | `get` | No | `` |

### `RenewBorder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadRenewConstruction+RenewBorder` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double start, Double end, RenewTypes renewType)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderLine` | `IList<BorderItem>` | `get` | No | `` |
| `End` | `Double` | `get/set` | No | `` |
| `Layers` | `IList<BorderLayer>` | `get` | No | `` |
| `RenewType` | `RenewTypes` | `get` | No | `` |
| `Start` | `Double` | `get` | No | `` |

### `RenewInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadRenewConstruction+RenewInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Road.RoadRenewConstruction+RenewInfo`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FreezingDepth` | `Double` | `get` | No | `` |
| `RenewDepth` | `Double` | `get` | No | `` |
| `ReplaceDepth` | `Double` | `get` | No | `` |
| `Type` | `RenewTypes` | `get` | No | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HasFrez` | `Boolean` | No | `` | `` |
| `HasReplace` | `Boolean` | No | `` | `` |
| `Heights` | `Double[]` | No | `` | `` |

### `RenewLayerType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RenewLayerType` |
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
      - `Topomatic.Crs.Road.RenewLayerType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Main` | `RenewLayerType` | Yes | `Main` | `` |
| `Renew` | `RenewLayerType` | Yes | `Renew` | `` |
| `RenewFill` | `RenewLayerType` | Yes | `RenewFill` | `` |
| `RenewFrez` | `RenewLayerType` | Yes | `RenewFrez` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Renew` | `0` |
| `Main` | `1` |
| `RenewFrez` | `2` |
| `RenewFill` | `3` |

**Underlying Type**: `System.Int32`

### `RenewTypes` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadRenewConstruction+RenewTypes` |
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
      - `Topomatic.Crs.Road.RoadRenewConstruction+RenewTypes`

#### Fields (22)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Broadening` | `RenewTypes` | Yes | `Broadening` | `` |
| `Frez1Layer` | `RenewTypes` | Yes | `Frez1Layer` | `` |
| `Frez2Layer` | `RenewTypes` | Yes | `Frez2Layer` | `` |
| `Frez3Layer` | `RenewTypes` | Yes | `Frez3Layer` | `` |
| `Frez4Layer` | `RenewTypes` | Yes | `Frez4Layer` | `` |
| `Frez5Layer` | `RenewTypes` | Yes | `Frez5Layer` | `` |
| `Frez6Layer` | `RenewTypes` | Yes | `Frez6Layer` | `` |
| `Frez7Layer` | `RenewTypes` | Yes | `Frez7Layer` | `` |
| `Frez8Layer` | `RenewTypes` | Yes | `Frez8Layer` | `` |
| `Frez9Layer` | `RenewTypes` | Yes | `Frez9Layer` | `` |
| `None` | `RenewTypes` | Yes | `None` | `` |
| `Renew1Layer` | `RenewTypes` | Yes | `Renew1Layer` | `` |
| `Renew2Layer` | `RenewTypes` | Yes | `Renew2Layer` | `` |
| `Renew3Layer` | `RenewTypes` | Yes | `Renew3Layer` | `` |
| `Renew4Layer` | `RenewTypes` | Yes | `Renew4Layer` | `` |
| `Renew5Layer` | `RenewTypes` | Yes | `Renew5Layer` | `` |
| `Renew6Layer` | `RenewTypes` | Yes | `Renew6Layer` | `` |
| `Renew7Layer` | `RenewTypes` | Yes | `Renew7Layer` | `` |
| `Renew8Layer` | `RenewTypes` | Yes | `Renew8Layer` | `` |
| `Renew9Layer` | `RenewTypes` | Yes | `Renew9Layer` | `` |
| `Replace` | `RenewTypes` | Yes | `Replace` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Renew1Layer` | `1` |
| `Renew2Layer` | `2` |
| `Renew3Layer` | `3` |
| `Renew4Layer` | `4` |
| `Renew5Layer` | `5` |
| `Renew6Layer` | `6` |
| `Renew7Layer` | `7` |
| `Renew8Layer` | `8` |
| `Renew9Layer` | `9` |
| `Broadening` | `10` |
| `Frez1Layer` | `11` |
| `Frez2Layer` | `12` |
| `Frez3Layer` | `13` |
| `Frez4Layer` | `14` |
| `Frez5Layer` | `15` |
| `Frez6Layer` | `16` |
| `Frez7Layer` | `17` |
| `Frez8Layer` | `18` |
| `Frez9Layer` | `19` |
| `Replace` | `20` |

**Underlying Type**: `System.Int32`

### `Result` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.TopFoundationBuilder+Result` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Road.TopFoundationBuilder+Result`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BottomEnd` | `Vector2D` | No | `` | `` |
| `BottomStart` | `Vector2D` | No | `` | `` |
| `MiddlePos` | `Vector2D` | No | `` | `` |
| `TopEnd` | `Vector2D` | No | `` | `` |
| `TopStart` | `Vector2D` | No | `` | `` |

### `ResultPoints` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.SlopeBuilder+ResultPoints` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Road.SlopeBuilder+ResultPoints`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Catch` | `Vector2D` | No | `` | `` |
| `DitchStart` | `Vector2D` | No | `` | `` |
| `End` | `Vector2D` | No | `` | `` |
| `HasCatch` | `Boolean` | No | `` | `` |
| `HasDitchStart` | `Boolean` | No | `` | `` |
| `HasEnd` | `Boolean` | No | `` | `` |
| `HasStart` | `Boolean` | No | `` | `` |
| `Nodes` | `CrsNode[]` | No | `` | `` |
| `Start` | `Vector2D` | No | `` | `` |

### `RoadExistingConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadExistingConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsGround` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGround`
          - `Topomatic.Crs.Road.RoadExistingConstruction`

#### Constructors (1)

- `.ctor(Int32 code)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadRenewConstruction` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadRenewConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsSemanticConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Road.RoadRenewConstruction`

#### Constructors (1)

- `.ctor(IEnumerable<VolumeData> data)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Borders` | `IList<RenewBorder>` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSemanticTypeDataToVolume` | `CrsVolume` | `RenewBorder border, IList<IRenewLayer> layers` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateBetweenStations` | `Boolean` | `IEnumerable<IRenewLayer> layers, Double maxFrez, Double sta1, Double height1, Double sta2, Double height2, Double eps, IList<Double> stations` | `` |
| `FindRenewInfo` | `RenewInfo` | `IEnumerable<IRenewLayer> layers, Double maxFrez, Double height` | `` |
| `RenewTypesToString` | `String` | `RenewTypes type` | `` |
| `RenewTypeToSemanticCode` | `Int32` | `RenewTypes type` | `` |

#### Nested Types (6)

- `BorderItem` (class)
- `BorderLayer` (class)
- `RenewBorder` (class)
- `RenewInfo` (struct)
- `RenewTypes` (enum)
- `Segment` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Segment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.RoadRenewConstruction+Segment` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double start, Double end)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `End` | `Double` | `get/set` | No | `` |
| `Start` | `Double` | `get/set` | No | `` |

### `SlopeBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.SlopeBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Int32 side, Int32 flags, Int32 sectionCount, Double m1, Double m2, Double m3, Double m4, Double h1, Double h2, Double h3, Double a1, Double a2, Double a3, Double gl, Double g, Double w, Double b, Double hk, Double gk, Double n1, Double n2, Boolean hasOffset, Double offset)`
- `.ctor(Int32 side, Int32 flags, Int32 sectionCount, Double m1, Double m2, Double m3, Double m4, Double m5, Double m6, Double m7, Double h1, Double h2, Double h3, Double h4, Double h5, Double h6, Double a1, Double a2, Double a3, Double a4, Double a5, Double a6, Double gl, Double g, Double w, Double b, Double hk, Double gk, Double n1, Double n2, Boolean hasOffset, Double offset)`

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareCutSlope` | `ResultPoints` | `Vector2D edge, CrsContour earth, Double elevation, CrsContour fillContour, CrsContour cutContour, CrsContour ditchFill, CrsContour ditchCut, CrsContour ditchBottom, CrsContour ledge` | `` |
| `PrepareDitchSlope` | `ResultPoints` | `Vector2D edge, CrsContour earth, CrsContour contour` | `` |
| `PrepareFillSlope` | `ResultPoints` | `Vector2D edge, CrsContour earth, Double elevation, CrsContour fillContour, CrsContour ditchFill, CrsContour ditchCut, CrsContour ditchBottom, CrsContour ledge` | `` |
| `PrepareOffset` | `Void` | `CrsContour contour, CrsContour offset, Double height, Boolean startVertical, Boolean endVertical` | `` |
| `PrepareSlopeBank` | `Void` | `Vector2D fromPos, CrsContour contour, CrsContour line1, CrsContour contour1, CrsContour line2, CrsContour contour2, Double depth, Double height1, Double height2, Boolean fromCatchPoint, Boolean startVertical, Boolean endVertical` | `` |
| `PrepareSlopeBank` | `Void` | `Vector2D fromPos, CrsContour contour, CrsContour line1, CrsContour contour1, CrsContour line2, CrsContour contour2, Double depth, Double height1, Double height2, Boolean fromCatchPoint` | `` |
| `UnionEqualsContours` | `IEnumerable<CrsContour>` | `IEnumerable<CrsContour> contous` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CUT_CODE` | `Int32` | Yes | `707` | `` |
| `DITCH_BOTTOM_CODE` | `Int32` | Yes | `720` | `` |
| `FILL_CODE` | `Int32` | Yes | `703` | `` |
| `LEFT_SIDE` | `Int32` | Yes | `-1` | `` |
| `RIGHT_SIDE` | `Int32` | Yes | `1` | `` |
| `SLOPE_FLAG_USE_DITCH_PROFILE` | `Int32` | Yes | `2` | `` |
| `SLOPE_FLAG_USE_LAST_POINT_STANDING` | `Int32` | Yes | `4` | `` |

#### Nested Types (1)

- `ResultPoints` (struct)

### `TopFoundationBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.TopFoundationBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Int32 side, Double elevation, Double height, Double bottomGrade, Double leftGrade, Double rightGrade, Double leftBroadeningGrade, Double leftBroadeningWidth, Double rightBroadeningGrade, Double rightBroadeningWidth, Boolean emptySlope, Boolean hasReconstruction, Double reconstructionOffset)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Result` | `Double slopeOffset, CrsContour topContour, CrsContour foundationContour, CrsContour middleContour` | `` |

#### Nested Types (1)

- `Result` (struct)

### `VolumesBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Road.VolumesBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddReconstructionInterval` | `Void` | `Double start, Double end` | `` |
| `AddRedLineComponent` | `Void` | `CrsComponent component` | `` |
| `AddSemanticAliase` | `Void` | `Aliace aliace, Int32 code, Int32 index` | `` |
| `AddSemanticAliase` | `Void` | `Aliace aliace, Int32 code` | `` |
| `CalculateFillLayers` | `IEnumerable<CrsComponent>` | `CrsSemanticConstruction construction, CrsContour earthLine, CrsContour agLine, Double step, Double leftGrade, Double rightGrade, Int32 leftSlopeFlags, Int32 rightSlopeFlags` | `` |
| `CalculateVolumes` | `IEnumerable<CrsVolume>` | `CrsSemanticConstruction construction, CrsContour earthLine, CrsContour agLine, Int32 leftSlopeFlags, Int32 rightSlopeFlags` | `` |
| `Clear` | `Void` | `` | `` |

#### Nested Types (1)

- `Aliace` (enum)

---
## Namespace: `Topomatic.Crs.Templates`

### `CrossSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrossSection` |
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
| `Context` | `CrsDesignContext` | `get/set` | No | `` |

### `CrsAgGround` (class)

**Attributes**: [Browsable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsAgGround` |
| **Base Type** | `Topomatic.Crs.Templates.CrsNodesGround` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGround`
          - `Topomatic.Crs.Templates.CrsNodesGround`
            - `Topomatic.Crs.Templates.CrsAgGround`

#### Constructors (1)

- `.ctor(IEnumerable<Node> nodes, Double cly, Int32 code)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AgName` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsAgregatorTemplateBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsAgregatorTemplateBuilder` |
| **Base Type** | `Topomatic.Crs.Templates.CrsTemplateBuilder` |
| **Implements** | `Topomatic.Crs.ICrsBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsTemplateBuilder`
    - `Topomatic.Crs.Templates.CrsAgregatorTemplateBuilder`

#### Constructors (1)

- `.ctor(CrsTemplateBuilder builder)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsCodeSemanticConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsCodeSemanticConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsSemanticConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Templates.CrsCodeSemanticConstruction`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `semanticCode0` | `Int32` | `get/set` | No | `SemanticEditor, SemanticAllowed, SDDisplayName, CrsDesignPropertyProvider, SDCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsComponent` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsComponent` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DesignContext` | `CrsDesignContext` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `Browsable` |
| `Owner` | `CrsContainer` | `get/set` | No | `Browsable` |

### `CrsConstruction` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsContainer` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowAutoCalculation` | `Boolean` | `get/set` | No | `Browsable` |
| `calcVolumes` | `Boolean` | `get/set` | No | `SDCategory, SDDisplayName` |
| `Clip` | `Boolean` | `get` | No | `Browsable` |
| `ConstructionMode` | `Boolean` | `get` | No | `Browsable` |
| `InsertionNode` | `CrsNode` | `get/set` | No | `Browsable, DisplayName, DesignerSerializationVisibility` |
| `Mirror` | `Boolean` | `get/set` | No | `Browsable` |
| `ProjectionMatrix` | `Matrix` | `get` | No | `Browsable` |
| `ProperMatrix` | `Matrix` | `get` | No | `Browsable` |
| `X` | `Double` | `get/set` | No | `Browsable, DefaultValue` |
| `Y` | `Double` | `get/set` | No | `Browsable, DefaultValue` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `CreateVolumes` | `Void` | `` | `` |
| `getClips` | `CrsContour[]` | `String name` | `` |
| `getExtended` | `CrsContour[]` | `String name` | `` |
| `GetGrips` | `IEnumerable<CrsGrip>` | `` | `` |
| `GetNodes` | `IEnumerable<CrsNode>` | `` | `` |
| `LinkByCode` | `CrsNode` | `Int32 code` | `` |
| `LinkByCode` | `CrsNode` | `Int32 code, Int32 index` | `` |
| `LinkByIndex` | `CrsNode` | `Int32 index` | `` |
| `LinkByName` | `CrsNode` | `String name` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateLinearObjectVariableKey` | `String` | `String uid, String key` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsContainer` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsContainer` |
| **Base Type** | `Topomatic.Crs.Templates.CrsComponent` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `Item` | `CrsComponent` | `get` | No | `` |
| `Item` | `CrsComponent` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `CrsComponent component` | `` |
| `AddRange` | `Void` | `IEnumerable collection` | `` |
| `Clear` | `Void` | `` | `` |
| `FindComponent` | `IEnumerable<CrsComponent>` | `String name` | `` |
| `FindContour` | `IEnumerable<CrsContour>` | `Int32 code` | `` |
| `GetEnumerator` | `IEnumerator<CrsComponent>` | `` | `` |
| `IndexOf` | `Int32` | `CrsComponent component` | `` |
| `Remove` | `Boolean` | `CrsComponent component` | `` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Deserialize` | `CrsComponent` | `CrsContainer container, String expression` | `` |
| `Deserialize` | `CrsComponent` | `CrsContainer container, AstExpression expression` | `` |
| `ForEachContour` | `Void` | `CrsContainer container, Predicate<CrsContour> match, Action<CrsContour> action` | `` |
| `ForEachNode` | `Void` | `CrsContainer container, Predicate<CrsNode> match, Action<CrsNode> action` | `` |
| `ForEachVolume` | `Void` | `CrsContainer container, Predicate<CrsVolume> match, Action<CrsVolume> action` | `` |
| `Serialize` | `AstExpression` | `CrsContainer container, CrsComponent component` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CrsContour` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsContour` |
| **Base Type** | `Topomatic.Crs.Templates.CrsComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContour`

#### Constructors (4)

- `.ctor()` - **Default constructor**
- `.ctor(CrsContour[] contours)`
- `.ctor(CrsContour contour, CrsNode beg, CrsNode end)`
- `.ctor(CrsContour contour, CrsNode beg, CrsNode end, Double eps)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `Obsolete` |
| `IsClosed` | `Boolean` | `get` | No | `` |
| `IsFilling` | `Boolean` | `get/set` | No | `` |
| `IsRedLinePart` | `Boolean` | `get/set` | No | `` |
| `Item` | `CrsNode` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `CrsNode node` | `` |
| `AddRange` | `Void` | `IEnumerable collection` | `` |
| `AddToVectorList` | `Void` | `List<Vector2D> list` | `` |
| `AsVectorList` | `List<Vector2D>` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Elevation` | `Double` | `Double offset` | `` |
| `Insert` | `Void` | `Int32 index, CrsNode node` | `` |
| `Left` | `Vector2D` | `` | `` |
| `Remove` | `Boolean` | `CrsNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Reverse` | `Void` | `` | `` |
| `Right` | `Vector2D` | `` | `` |
| `TryGetElevation` | `Boolean` | `Double offset, ref Double elevation` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `CrsContour` | `CrsContour contour, CrsNode beg, CrsNode end` | `` |
| `Create` | `CrsContour` | `CrsContour[] contours` | `` |
| `NotNull` | `Boolean` | `IEnumerable nodes` | `` |

### `CrsCuttingGround` (class)

**Attributes**: [Browsable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsCuttingGround` |
| **Base Type** | `Topomatic.Crs.Templates.CrsNodesGround` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGround`
          - `Topomatic.Crs.Templates.CrsNodesGround`
            - `Topomatic.Crs.Templates.CrsCuttingGround`

#### Constructors (1)

- `.ctor(IEnumerable<Node> nodes, Double cly, Int32 code)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsDesignContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsDesignContext` |
| **Base Type** | `Topomatic.Crs.Templates.CrsContainer` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsDesignContext`

#### Constructors (2)

- `.ctor(ICrsParams parameters, ICrsBuilderListener listener)`
- `.ctor(ICrsParams parameters, ICrsBuilderListener listener, Boolean clipContours)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BuildStatus` | `IDictionary<ActBaseComponent ActBuildStatus>` | `get` | No | `` |
| `ClipContours` | `Boolean` | `get` | No | `` |
| `Errors` | `IDictionary<ActBaseComponent String>` | `get` | No | `` |
| `InvMap` | `IDictionary<ActBaseComponent CrsComponent>` | `get` | No | `` |
| `Listener` | `ICrsBuilderListener` | `get` | No | `` |
| `Map` | `IDictionary<CrsComponent ActBaseComponent>` | `get` | No | `` |
| `Params` | `ICrsParams` | `get` | No | `` |
| `Properties` | `IDictionary<AstExpression Object>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Elevate` | `Void` | `Double elevation` | `` |
| `GetAgContour` | `CrsContour` | `` | `` |
| `GetEgContour` | `CrsContour` | `` | `` |
| `GetRedLineContour` | `CrsContour` | `` | `` |
| `LinkByCode` | `CrsNode` | `Int32 code` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsErrorException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsErrorException` |
| **Base Type** | `System.Exception` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.Crs.Templates.CrsErrorException`

#### Constructors (1)

- `.ctor(String message)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsExistentGround` (class)

**Attributes**: [Browsable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsExistentGround` |
| **Base Type** | `Topomatic.Crs.Templates.CrsNodesGround` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGround`
          - `Topomatic.Crs.Templates.CrsNodesGround`
            - `Topomatic.Crs.Templates.CrsExistentGround`

#### Constructors (1)

- `.ctor(IEnumerable<Node> nodes, Double cly, Int32 code)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EgContour` | `String` | Yes | `"EgContour"` | `` |
| `EgName` | `String` | Yes | `"Eg"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsGeologyGround` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsGeologyGround` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGeologyGround`

#### Constructors (1)

- `.ctor(IEnumerable[] contours)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsGrassOrTorfGround` (class)

**Attributes**: [Browsable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsGrassOrTorfGround` |
| **Base Type** | `Topomatic.Crs.Templates.CrsGround` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGround`
          - `Topomatic.Crs.Templates.CrsGrassOrTorfGround`

#### Constructors (1)

- `.ctor(Int32 code)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConstructionName` | `String` | Yes | `` | `` |
| `ContourName` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsGrip` |
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
| `Pos` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector2D position` | `` |
| `OnMove` | `Void` | `Vector2D pos` | `` |

### `CrsGround` (abstract class)

**Attributes**: [Browsable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsGround` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGround`

#### Constructors (1)

- `.ctor(Int32 code)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsLayer` |
| **Base Type** | `Topomatic.Crs.Templates.CrsSemanticConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Templates.CrsLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BuildBottom` | `Boolean` | `get/set` | No | `SDCategory, SDDisplayName` |
| `BuildMiddle` | `Boolean` | `get/set` | No | `SDDisplayName, SDCategory` |
| `BuildTop` | `Boolean` | `get/set` | No | `SDCategory, SDDisplayName` |
| `Depth` | `Object` | `get/set` | No | `AstExpressionOrSelectContour, SDCategory, SDDisplayName` |
| `Grade1` | `Double` | `get/set` | No | `SDDisplayName, AstExpression, SDCategory` |
| `Grade2` | `Double` | `get/set` | No | `SDCategory, AstExpression, SDDisplayName` |
| `semanticCode0` | `Int32` | `get/set` | No | `SemanticEditor, SemanticAllowed, CrsSemanticCodeIndex, SDDisplayName, SDCategory, CrsDesignPropertyProvider` |
| `semanticCode1` | `Int32` | `get/set` | No | `SemanticAllowed, CrsSemanticCodeIndex, CrsDesignPropertyProvider, SDDisplayName, SemanticEditor, SDCategory` |
| `semanticCode2` | `Int32` | `get/set` | No | `SDDisplayName, SemanticAllowed, SDCategory, SemanticEditor, CrsSemanticCodeIndex, CrsDesignPropertyProvider` |
| `semanticCode3` | `Int32` | `get/set` | No | `CrsSemanticCodeIndex, SemanticAllowed, SDCategory, CrsDesignPropertyProvider, SemanticEditor, SDDisplayName` |
| `Slope1` | `Double` | `get/set` | No | `AstExpression, SDDisplayName, SDCategory` |
| `Slope2` | `Double` | `get/set` | No | `AstExpression, SDDisplayName, SDCategory` |
| `Width1` | `Object` | `get/set` | No | `SDDisplayName, AstExpressionOrSelectContour, SDCategory` |
| `Width2` | `Object` | `get/set` | No | `SDCategory, SDDisplayName, AstExpressionOrSelectContour` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `getClips` | `CrsContour[]` | `String name` | `` |
| `getExtended` | `CrsContour[]` | `String name` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsLayerList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsLayerList` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsLayerList`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `CrsContour` | `get` | No | `Browsable` |
| `Contour` | `CrsContour` | `get/set` | No | `SDCategory, PropertyEditor, SDDisplayName` |
| `Node1` | `CrsNode` | `get/set` | No | `PropertyEditor, SDCategory, SDDisplayName` |
| `Node2` | `CrsNode` | `get/set` | No | `SDDisplayName, SDCategory, PropertyEditor` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsNode` |
| **Base Type** | `Topomatic.Crs.Templates.CrsComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsNode`

#### Constructors (9)

- `.ctor(CrsRay ray, CrsContour contour)`
- `.ctor(CrsRay ray, CrsContainer[] containers)`
- `.ctor(CrsRay ray, CrsContainer container)`
- `.ctor(Double x, Double y)`
- `.ctor(CrsRay ray1, CrsRay ray2)`
- `.ctor(CrsRay ray, CrsContainer container, Int32 index)`
- `.ctor(CrsNode node, Double x, Double y)`
- `.ctor(CrsRay ray, CrsContour contour, Int32 index)`
- `.ctor(CrsRay ray, CrsContainer container, Int32 index, Int32 code)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `Browsable` |
| `Vector` | `Vector2D` | `get` | No | `Browsable` |
| `X` | `Double` | `get/set` | No | `ReadOnly, Length` |
| `Y` | `Double` | `get/set` | No | `Elevation, ReadOnly` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `CrsNode` | `CrsRay ray, CrsContainer container, Int32 index` | `` |
| `Create` | `CrsNode` | `CrsRay ray, CrsContainer container, Int32 index, Int32 code` | `` |
| `Create` | `CrsNode` | `CrsRay ray, CrsContainer container` | `` |
| `Create` | `CrsNode` | `CrsContour contour1, CrsContour contour2, Int32 num` | `` |
| `Create` | `CrsNode` | `CrsRay ray, CrsContainer[] containers` | `` |
| `Create` | `CrsNode` | `CrsNode node, Double x, Double y` | `` |
| `Create` | `CrsNode` | `Double x, Double y` | `` |
| `Create` | `CrsNode` | `CrsRay ray1, CrsRay ray2` | `` |
| `Create` | `CrsNode` | `CrsRay ray, CrsContour contour, Int32 index` | `` |
| `Create` | `CrsNode` | `CrsRay ray, CrsContour contour` | `` |

### `CrsNodesGround` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsNodesGround` |
| **Base Type** | `Topomatic.Crs.Templates.CrsGround` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsGround`
          - `Topomatic.Crs.Templates.CrsNodesGround`

#### Constructors (1)

- `.ctor(IEnumerable<Node> nodes, Double cly, Int32 code)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ground` | `Nodes` | `get` | No | `Browsable` |

#### Nested Types (2)

- `Node` (struct)
- `Nodes` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsRay` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsRay` |
| **Base Type** | `Topomatic.Crs.Templates.CrsComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsRay`

#### Constructors (3)

- `.ctor(CrsNode node, Double inclination)`
- `.ctor(CrsNode node1, CrsNode node2)`
- `.ctor(CrsNode node, Double x, Double y)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bidirectional` | `Boolean` | `get/set` | No | `` |
| `Inclination` | `Double` | `get/set` | No | `` |
| `Line` | `Line2D` | `get` | No | `` |
| `Node` | `CrsNode` | `get` | No | `` |
| `Ray` | `Ray2D` | `get` | No | `` |
| `X` | `Double` | `get/set` | No | `` |
| `Y` | `Double` | `get/set` | No | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `CrsRay` | `CrsNode node, Double x, Double y` | `` |
| `Create` | `CrsRay` | `CrsNode node, Double inclination` | `` |
| `Create` | `CrsRay` | `CrsNode node1, CrsNode node2` | `` |

### `CrsRedLine` (class)

**Attributes**: [Browsable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsRedLine` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsRedLine`

#### Constructors (1)

- `.ctor(IEnumerable<Point> points, Double elevation)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get/set` | No | `` |
| `PointsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPoint` | `Point` | `Int32 index` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RedLineCode` | `Int32` | Yes | `514` | `` |
| `RedLineContour` | `String` | Yes | `"RedLineContour"` | `` |
| `RedLineName` | `String` | Yes | `"RedLine"` | `` |

#### Nested Types (1)

- `Point` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsSegment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsSegment` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSegment`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `SemanticEditor, SemanticAllowed, SDDisplayName` |
| `Contour` | `CrsContour` | `get/set` | No | `SDCategory, SDDisplayName, PropertyEditor` |
| `Mode` | `SegmentMode` | `get/set` | No | `SDDisplayName, SDCategory` |
| `Node` | `CrsNode` | `get/set` | No | `SDDisplayName, SDCategory, PropertyEditor` |
| `NodeCode` | `Int32` | `get/set` | No | `SDDisplayName, SemanticAllowed, SemanticEditor` |
| `Value1` | `Double` | `get/set` | No | `AstExpression, SDDisplayName, SDCategory` |
| `Value2` | `Double` | `get/set` | No | `SDDisplayName, AstExpression, SDCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsSegmentList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsSegmentList` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSegmentList`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour` | `CrsContour` | `get/set` | No | `Browsable` |
| `IsRedLinePart` | `Boolean` | `get/set` | No | `SDDisplayName` |
| `Node` | `CrsNode` | `get/set` | No | `SDDisplayName, PropertyEditor, SDCategory` |
| `Prev` | `CrsNode` | `get/set` | No | `Browsable` |
| `Side` | `ActSide` | `get/set` | No | `SDDisplayName, SDCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsSemanticConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsSemanticConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`

#### Constructors (1)

- `.ctor(IEnumerable<VolumeData> data)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Semantics` | `VolumeDataList` | `get/set` | No | `Browsable` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignVolumeData` | `Void` | `CrsVolume volume, Int32 index` | `` |
| `BrepDifference` | `List<List<Vector2D>>` | `List<Vector2D> poly1, List<Vector2D> poly2` | `` |
| `ClipLine` | `List<List<Vector2D>>` | `CrsContour line, CrsContour polygon, Boolean inside` | `` |
| `ClipLine` | `List<List<Vector2D>>` | `List<Vector2D> polyline, List<Vector2D> polygon, Boolean inside` | `` |
| `Difference` | `List<List<Vector2D>>` | `CrsContour contour1, CrsContour contour2, Boolean firstUp` | `` |
| `Difference` | `List<List<Vector2D>>` | `List<Vector2D> points1, List<Vector2D> points2` | `` |
| `Intersect` | `List<List<Vector2D>>` | `List<Vector2D> points1, List<Vector2D> points2` | `` |
| `Intersect` | `List<List<Vector2D>>` | `CrsContour contour1, CrsContour contour2, Boolean firstUp` | `` |
| `Union` | `List<List<Vector2D>>` | `CrsContour contour1, CrsContour contour2, Boolean firstUp` | `` |
| `Union` | `List<List<Vector2D>>` | `List<Vector2D> points1, List<Vector2D> points2` | `` |
| `VerticalContourCut` | `List<List<CrsNode>>` | `CrsContour contour, Double offset, Boolean leaveLeft` | `` |

#### Nested Types (2)

- `VolumeData` (class)
- `VolumeDataList` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsTemplateBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsTemplateBuilder` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Crs.ICrsBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildTemplate` | `CrsDesignContext` | `Double station, CrsLine staticEg, CrsLine sectionLine, ActConstruction construction, BuildMode mode, Boolean clipContours, ICrsBuilderListener listener` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICrsBuilder` | `BuildTemplate` |

### `CrsTwoCodeSemanticConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsTwoCodeSemanticConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsSemanticConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsSemanticConstruction`
          - `Topomatic.Crs.Templates.CrsTwoCodeSemanticConstruction`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `semanticCode0` | `Int32` | `get/set` | No | `CrsDesignPropertyProvider, CrsSemanticCodeIndex, SemanticEditor, SemanticAllowed, SDCategory, SDDisplayName` |
| `semanticCode1` | `Int32` | `get/set` | No | `CrsSemanticCodeIndex, SemanticEditor, SemanticAllowed, SDDisplayName, SDCategory, CrsDesignPropertyProvider` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsUserConstruction` (abstract class)

**Attributes**: [CrsDesignInitializator]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsUserConstruction` |
| **Base Type** | `Topomatic.Crs.Templates.CrsConstruction` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsComponent, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsContainer`
      - `Topomatic.Crs.Templates.CrsConstruction`
        - `Topomatic.Crs.Templates.CrsUserConstruction`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrsVolume` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsVolume` |
| **Base Type** | `Topomatic.Crs.Templates.CrsComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsComponent`
    - `Topomatic.Crs.Templates.CrsVolume`

#### Constructors (5)

- `.ctor()` - **Default constructor**
- `.ctor(CrsContour contour)`
- `.ctor(CrsContour contour, CrsNode beg, CrsNode end)`
- `.ctor(CrsContour contour1, CrsContour contour2, Boolean firstUp)`
- `.ctor(IEnumerable<Vector2D> vectors, CrsVolumeMode mode, Int32 code)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Begin` | `CrsNode` | `get` | No | `` |
| `Code` | `Int32` | `get/set` | No | `` |
| `Contour1` | `CrsContour` | `get` | No | `` |
| `Contour2` | `CrsContour` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `End` | `CrsNode` | `get` | No | `` |
| `Factor` | `Double` | `get/set` | No | `` |
| `Holder` | `SemanticDataHolder` | `get/set` | No | `` |
| `Item` | `IList<Vector2D>` | `get` | No | `` |
| `Mode` | `CrsVolumeMode` | `get/set` | No | `` |
| `Semantic` | `SemanticDataSet` | `get` | No | `` |
| `Volume` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddContour` | `Void` | `CrsContour contour` | `` |
| `Clear` | `Void` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `CrsVolume` | `CrsContour contour1, CrsContour contour2, Boolean firstUp` | `` |
| `Create` | `CrsVolume` | `CrsContour contour, CrsNode beg, CrsNode end` | `` |
| `Create` | `CrsVolume` | `CrsContour contour` | `` |

### `CrsVolumeMode` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsVolumeMode` |
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
      - `Topomatic.Crs.Templates.CrsVolumeMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Area` | `CrsVolumeMode` | Yes | `Area` | `` |
| `Count` | `CrsVolumeMode` | Yes | `Count` | `` |
| `Length` | `CrsVolumeMode` | Yes | `Length` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Area` | `0` |
| `Length` | `1` |
| `Count` | `2` |

**Underlying Type**: `System.Int32`

### `ICrsParams` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.ICrsParams` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.Generic.ICollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.Generic.IDictionary`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `RoundValues` | `Boolean` | `get` | No | `` |

### `Node` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsNodesGround+Node` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Templates.CrsNodesGround+Node`

#### Constructors (1)

- `.ctor(Double offset, Double elevation, Int32 code)`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code` | `Int32` | No | `` | `` |
| `Elevation` | `Double` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |

### `Nodes` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsNodesGround+Nodes` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Templates.CrsNodesGround+Node, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Node` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<Node>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `Point` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsRedLine+Point` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Templates.CrsRedLine+Point`

#### Constructors (1)

- `.ctor(Vector2D position, Int32 code, Int32 segmentCode)`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code` | `Int32` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |
| `SegmentCode` | `Int32` | No | `` | `` |

### `SegmentMode` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.SegmentMode` |
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
      - `Topomatic.Crs.Templates.SegmentMode`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `dXdY` | `SegmentMode` | Yes | `dXdY` | `` |
| `SlopeElevation` | `SegmentMode` | Yes | `SlopeElevation` | `` |
| `SlopeHeight` | `SegmentMode` | Yes | `SlopeHeight` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WidthGrade` | `SegmentMode` | Yes | `WidthGrade` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `dXdY` | `0` |
| `WidthGrade` | `1` |
| `SlopeHeight` | `2` |
| `SlopeElevation` | `3` |

**Underlying Type**: `System.Int32`

### `VolumeData` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsSemanticConstruction+VolumeData` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Int32 code, String name)`
- `.ctor(Int32 code, String name, Boolean canChangeSemanticCode)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `` |
| `Holder` | `SemanticDataHolder` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<KeyValuePair<String Object>>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `VolumeDataList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Templates.CrsSemanticConstruction+VolumeDataList` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IEnumerable<VolumeData> data)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `VolumeData` | `get` | No | `` |

---
## Namespace: `Topomatic.Crs.Utility`

### `DesignContextUtility` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Utility.DesignContextUtility` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindVolume` | `CrsVolume` | `CrsDesignContext context, CrsContour contour` | `` |
| `IsAllowedVolumeSemantic` | `Boolean` | `SemanticRootNode node, Int32[] intervals, String[] applicability, Boolean hasChipher` | `` |

### `InvertedRedLineBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Utility.InvertedRedLineBuilder` |
| **Base Type** | `Topomatic.Crs.Utility.RedLineSegmentBuilder` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Crs.Utility.RedLineSegmentBuilder+RedLineSegment, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Utility.RedLineSegmentBuilder+RedLineSegment, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Utility.RedLineSegmentBuilder`
    - `Topomatic.Crs.Utility.InvertedRedLineBuilder`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(RedLineSegmentBuilder builder)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PolygonLibrary` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Utility.PolygonLibrary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Intersect` | `List<IList<Vector2D>>` | `List<Vector2D> poly1, List<Vector2D> poly2` | `` |
| `PosInBorder` | `Int32` | `Vector2D pos, List<Vector2D> poly, Double eps` | `` |
| `SectSegments` | `Int32` | `Vector2D b1, Vector2D e1, Vector2D b2, Vector2D e2, ref Vector2D point1, ref Vector2D point2` | `` |

### `RedLineSegment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Utility.RedLineSegmentBuilder+RedLineSegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Crs.Utility.RedLineSegmentBuilder+RedLineSegment`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetY` | `Double` | `Double x` | `` |
| `TryGetY` | `Boolean` | `Double x, ref Double y` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndCode` | `Int32` | No | `` | `` |
| `EndPosition` | `Vector2D` | No | `` | `` |
| `Project` | `Boolean` | No | `` | `` |
| `SegmentCode` | `Int32` | No | `` | `` |
| `StartCode` | `Int32` | No | `` | `` |
| `StartPosition` | `Vector2D` | No | `` | `` |

### `RedLineSegmentBuilder` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Crs.Utility.RedLineSegmentBuilder` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Crs.Utility.RedLineSegmentBuilder+RedLineSegment, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Crs.Utility.RedLineSegmentBuilder+RedLineSegment, Topomatic.Crs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(RedLineSegmentBuilder builder)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `RedLineSegment` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `RedLineSegment segment` | `` |
| `AddRange` | `Void` | `RedLineSegmentBuilder builder` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `RedLineSegment item` | `` |
| `CopyTo` | `Void` | `RedLineSegment[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<RedLineSegment>` | `` | `` |
| `Refresh` | `Void` | `` | `` |
| `Remove` | `Boolean` | `RedLineSegment item` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSegment` | `RedLineSegment` | `Vector2D start, Vector2D end, Int32 code, Int32 startCode, Int32 endCode` | `` |
| `CreateSegment` | `RedLineSegment` | `Vector2D start, Vector2D end, Int32 code` | `` |

#### Nested Types (1)

- `RedLineSegment` (struct)

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 282 |
| **Classes** | 214 |
| **Interfaces** | 9 |
| **Enums** | 19 |
| **Structs** | 17 |
| **Abstract Classes** | 20 |
| **Static Classes** | 3 |
| **Total Methods** | 585 |
| **Total Properties** | 530 |
| **Total Fields** | 457 |
| **Total Events** | 5 |
| **Total Constructors** | 295 |
| **Nested Types** | 16 |
| **Extension Methods** | 0 |


