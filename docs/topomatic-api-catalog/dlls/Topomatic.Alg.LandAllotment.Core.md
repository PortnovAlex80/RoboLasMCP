# Topomatic.Alg.LandAllotment.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.LandAllotment.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.LandAllotment.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.LandAllotment.Core.dll` |

---
## Namespace: `Topomatic.Alg.LandAllotment.Core`

### `AlgLandAllotmentCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.AlgLandAllotmentCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.LandAllotment.Core.AlgLandAllotmentCorePluginHost`

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
## Namespace: `Topomatic.Alg.LandAllotment.Core.GridPanel`

### `LandAllotmentGridCrossSectionsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridCrossSectionsLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridCrossSectionsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentGridDesignOffsetsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridDesignOffsetsLayer` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer`
        - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridDesignOffsetsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Boolean absoluteOffsets, Int32 sortOrder)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentGridExistentOffsetsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridExistentOffsetsLayer` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer`
        - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridExistentOffsetsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Boolean absoluteOffs, Int32 sortOrder)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentGridOffsetsLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, String name, String description, Guid id, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentGridPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridPlanLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridPlanLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMouseMove` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentGridStationingLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridStationingLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridStationingLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentGridTempOffsetsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridTempOffsetsLayer` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridOffsetsLayer`
        - `Topomatic.Alg.LandAllotment.Core.GridPanel.LandAllotmentGridTempOffsetsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Boolean absoluteOffset, Int32 sortOrder)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.LandAllotment.Core.Plt.Crs`

### `PltCrsFieldLandAllotmentLines` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Core.Plt.Crs.PltCrsFieldLandAllotmentLines` |
| **Base Type** | `Topomatic.Plt.Templates.Crs.CrsField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Crs.CrsField`
      - `Topomatic.Alg.LandAllotment.Core.Plt.Crs.PltCrsFieldLandAllotmentLines`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 9 |
| **Classes** | 7 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 0 |
| **Total Methods** | 8 |
| **Total Properties** | 0 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 8 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


