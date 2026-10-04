# Topomatic.Dtm.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Dtm.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Dtm.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Dtm.Core.dll` |

---
## Namespace: `Topomatic.Dtm.Core`

### `DtmCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.DtmCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Dtm.Core.DtmCorePluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Surface3dView` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.Surface3dView` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Dtm.Core.Surface3dView`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VolumeRenderModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.VolumeRenderModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Dtm.Core.VolumeRenderModule`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Dtm.Core.Design`

### `ClassificatorSemanticConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.Design.ClassificatorSemanticConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Dtm.Core.Design.ClassificatorSemanticConverter`

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
| `SPLITTER` | `Char` | Yes | `|` | `` |

### `ClassificatorSemanticDataStyleProvider` (class)

**Attributes**: [DisplayName]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.Design.ClassificatorSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Dtm.Core.Design.ClassificatorSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `ClassificatorSemanticEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.Design.ClassificatorSemanticEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Dtm.Core.Design.ClassificatorSemanticEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `RelatedDocumentsConverter` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.Design.RelatedDocumentsConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Dtm.Core.Design.RelatedDocumentsConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `RelatedDocumentsEditor` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.Design.RelatedDocumentsEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Dtm.Core.Design.RelatedDocumentsEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `RelatedDocumentsSemanticDataStyleProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Core.Design.RelatedDocumentsSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Dtm.Core.Design.RelatedDocumentsSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 9 |
| **Classes** | 9 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 14 |
| **Total Properties** | 0 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 9 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


