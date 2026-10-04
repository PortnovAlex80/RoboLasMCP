# Topomatic.Visualization.Tools

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Visualization.Tools` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v4.0.30319` |
| **Full Name** | `Topomatic.Visualization.Tools, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Visualization.Tools.dll` |

---
## Namespace: `Topomatic.Visualization.Tools`

### `IfcExportContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.IfcExportContext` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DatabaseIfc db)`

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateColourRgb` | `IfcColourRgb` | `Color clr` | `` |
| `CreateComplexValue` | `IfcComplexProperty` | `String name, String usage, IEnumerable<IfcProperty> properties, String description` | `` |
| `CreateDirection` | `IfcDirection` | `Vector3D dir` | `` |
| `CreateEnumeratedValue` | `IfcPropertyEnumeratedValue` | `String name, IfcValue value, String description, IfcPropertyEnumeration enumeration` | `` |
| `CreateEnumerator` | `IfcPropertyEnumeration` | `EnumerationPropertyInfo info` | `` |
| `CreateLabel` | `IfcLabel` | `String value` | `` |
| `CreatePropertySet` | `IfcPropertySet` | `String name, IEnumerable<IfcProperty> properties` | `` |
| `CreateSingleValue` | `IfcPropertySingleValue` | `String name, IfcValue value, String description` | `` |
| `CreateSurfaceStyle` | `IfcSurfaceStyle` | `Color diffuse, Color specular, Single transparency` | `` |
| `GetGroupId` | `Guid` | `VisualizationGroup group` | `` |
| `GetStringId` | `Guid` | `String id` | `` |
| `GetTypeId` | `Guid` | `ImTypeDescriptor type` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProjectId` | `Guid` | `String id` | `` |

### `IfcSurfaceTextureHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.IfcTools+IfcSurfaceTextureHolder` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `accent` | `Vector4D` | No | `` | `` |
| `texture` | `IfcSurfaceTexture` | No | `` | `` |

### `IfcTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.IfcTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateGeometryRepresentation` | `IfcShapeRepresentation` | `DatabaseIfc db, Dictionary<String IfcSurfaceTextureHolder> textures, GeometryModel3D mesh, Matrix transform, IfcGeometricRepresentationContext ctx, IfcExportContext ic` | `` |
| `CreateIfcProperties` | `Void` | `IfcObjectDefinition definition, ImProperties properties` | `` |
| `CreateIfcType` | `ImTypeDescriptor` | `Type type, Dictionary<String ImTypeDescriptor> types` | `` |
| `CreateIfcType` | `ImTypeDescriptor` | `IfcObjectDefinition definition, Dictionary<String ImTypeDescriptor> types` | `` |
| `CreateManifoldSolidBrepRepresentation` | `IfcShapeRepresentation` | `DatabaseIfc db, Dictionary<String IfcSurfaceTextureHolder> textures, GeometryModel3D mesh, Matrix transform, IfcGeometricRepresentationContext ctx, IfcExportContext ic` | `` |
| `CreatePropertySet` | `List<IfcPropertySet>` | `DatabaseIfc db, IEnumerable<ModelPropertyItem> properties` | `` |
| `CreatePropertySet` | `List<IfcPropertySet>` | `DatabaseIfc db, ImProperties properties, Boolean exportGroups, IfcExportContext ic` | `` |
| `LoadIfcProductRepresentation` | `Void` | `IEnumerable<IfcRepresentation<T>> representations, Matrix transform, List<Static3DElement> models, List<Matrix> transforms, Dictionary<Int32 Static3DElement> map` | `` |
| `LoadIfcProductRepresentation` | `Void` | `IEnumerable<IfcRepresentation<T>> representations, Matrix transform, IfcStyledItem styledItem, List<Static3DElement> elements, List<Matrix> transforms, Dictionary<Int32 Static3DElement> map` | `` |
| `LoadProductPlacement` | `Matrix` | `IfcObjectPlacement placement` | `` |

#### Nested Types (1)

- `IfcSurfaceTextureHolder` (class)

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 3 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 23 |
| **Total Properties** | 0 |
| **Total Fields** | 2 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


