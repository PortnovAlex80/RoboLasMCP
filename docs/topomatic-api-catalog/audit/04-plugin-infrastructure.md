# Audit 04: Plugin Infrastructure and Object Lifecycle

**Date**: 2026-05-31
**Scope**: LasTerrainPluginHost, Module, CommandRegistry, Settings, surface interactions
**API Sources**: Topomatic.ApplicationPlatform, Topomatic.FoundationClasses, Topomatic.Stg, Topomatic.ComponentModel

---

## Executive Summary

LAS_TERRAIN uses a correct but minimal subset of the Topomatic plugin API. The plugin host and module initialization follow the documented pattern. However, several significant capabilities are unused: the Undo/Transaction system, PluginFactory registration APIs (RegisterProjectSettings, RegisterType, RegisterModelEditor), IStgSerializable for module-level persistence, DynamicDictionary for modern settings storage, Logger framework for diagnostics, PluginCoreOps for model navigation, and the Property grid framework for auto-generated UI. This audit identifies 10 findings with specific file/line references and actionable recommendations.

---

## Finding 1: PluginHostInitializator Usage

**File**: `LasTerrainPluginHost.cs:1-24`

**Current approach**: Correctly extends `PluginHostInitializator` and overrides `GetTypes()` to return `[typeof(Module)]`. Calls `base.Initialize(factory)` and then `Settings.Instance.PushToRuntimeConfig()`.

**Assessment**: **CORRECT -- but underutilized.** The `PluginFactory` parameter in `Initialize()` is captured by the base class but never used by our code. The `PluginFactory` exposes:
- `RegisterFunction(name, function)` -- register callable plugin functions
- `RegisterType(id, type)` -- register custom model types
- `RegisterProjectSettings(id, func)` -- register settings panels in project settings
- `RegisterModelEditor(modelType, info)` -- register editors for custom model types
- `RegisterTask(id, value)` -- register named tasks

**Current code**:
```csharp
public override void Initialize(PluginFactory factory)
{
    base.Initialize(factory);
    Settings.Instance.PushToRuntimeConfig();
}
```

**Impact**: LOW. Plugin loads and runs correctly. Missing registration APIs would matter if we wanted our settings in the Topomatic project settings dialog, or if we created custom model types.

---

## Finding 2: Module Extends PluginInitializator Without Using IStgSerializable

**File**: `Module.cs:1-186`

**Current approach**: `Module` extends `PluginInitializator` which itself implements `IStgSerializable`. The base class provides `SaveToStg(StgNode)` / `LoadFromStg(StgNode)` virtual methods and a `SerializationKey` property. Our Module does NOT override any of these.

**Topomatic alternative**: `PluginInitializator` has built-in serialization via `IStgSerializable`. It also provides:
- `CadView` property -- direct access to the CAD view
- `ActivateWindow(Func<CadView, bool> filter)` -- window management
- `SerializationKey` -- key under which module state is persisted

**Gap**: Module-level state (e.g., last-used step value, polygon collections, user preferences per document) is not persisted. When a project is saved/reopened, all plugin visual state (drawn polygons, CRS overlay data) is lost.

### IStgSerializable Implementation Guide for Module Persistence

**.NET 3.5 Compatible Implementation**:

```csharp
// Module.cs -- Add these overrides for persistence
public override string SerializationKey
{
    get { return "LAS_TERRAIN_MODULE_V1"; }
}

public override void SaveToStg(StgNode node)
{
    // Save polygon collections
    if (CrsPolygonCollection != null && CrsPolygonCollection.Count > 0)
    {
        var crsArray = node.AddArray("CrsPolygons", StgType.Node);
        foreach (var polygon in CrsPolygonCollection)
        {
            var polyNode = crsArray.AddNode();
            SavePolygonToStg(polyNode, polygon);
        }
    }
    
    if (PlanPolygonCollection != null && PlanPolygonCollection.Count > 0)
    {
        var planArray = node.AddArray("PlanPolygons", StgType.Node);
        foreach (var polygon in PlanPolygonCollection)
        {
            var polyNode = planArray.AddNode();
            SavePolygonToStg(polyNode, polygon);
        }
    }
    
    // Save last-used parameters
    node.AddInt("LastStep", RuntimeConfig.Step);
    node.AddDouble("LastBorderThickness", RuntimeConfig.BorderThickness);
    
    // Save layer visibility
    node.AddBoolean("CrsLayerVisible", crsOverlayLayer != null && crsOverlayLayer.Visible);
    node.AddBoolean("PlanLayerVisible", planOverlayLayer != null && planOverlayLayer.Visible);
}

public override void LoadFromStg(StgNode node)
{
    // Clear existing collections
    if (CrsPolygonCollection != null)
        CrsPolygonCollection.Clear();
    if (PlanPolygonCollection != null)
        PlanPolygonCollection.Clear();
    
    // Load CRS polygons
    var crsArray = node.GetArray("CrsPolygons", StgType.Node);
    if (crsArray != null && crsArray.Count > 0)
    {
        for (int i = 0; i < crsArray.Count; i++)
        {
            var polyNode = crsArray.GetNode(i);
            var polygon = LoadPolygonFromStg(polyNode);
            if (polygon != null && CrsPolygonCollection != null)
                CrsPolygonCollection.Add(polygon);
        }
    }
    
    // Load Plan polygons
    var planArray = node.GetArray("PlanPolygons", StgType.Node);
    if (planArray != null && planArray.Count > 0)
    {
        for (int i = 0; i < planArray.Count; i++)
        {
            var polyNode = planArray.GetNode(i);
            var polygon = LoadPolygonFromStg(polyNode);
            if (polygon != null && PlanPolygonCollection != null)
                PlanPolygonCollection.Add(polygon);
        }
    }
    
    // Restore parameters
    if (node.IsExists("LastStep"))
        RuntimeConfig.Step = node.GetInt("LastStep");
    if (node.IsExists("LastBorderThickness"))
        RuntimeConfig.BorderThickness = node.GetDouble("LastBorderThickness");
    
    // Restore layer visibility (requires layers to be initialized first)
    // This should be called after layers are created
    bool crsVisible = node.GetBoolean("CrsLayerVisible", true);
    bool planVisible = node.GetBoolean("PlanLayerVisible", true);
    
    // Store for later application to layers
    pendingCrsLayerVisibility = crsVisible;
    pendingPlanLayerVisibility = planVisible;
}

private void SavePolygonToStg(StgNode node, List<DVertex> polygon)
{
    var pointArray = node.AddArray("Points", StgType.Double);
    foreach (var vertex in polygon)
    {
        pointArray.AddDouble(vertex.X);
        pointArray.AddDouble(vertex.Y);
        pointArray.AddDouble(vertex.Z);
    }
}

private List<DVertex> LoadPolygonFromStg(StgNode node)
{
    var pointArray = node.GetArray("Points", StgType.Double);
    if (pointArray == null || pointArray.Count % 3 != 0)
        return null;
    
    var polygon = new List<DVertex>();
    for (int i = 0; i < pointArray.Count; i += 3)
    {
        double x = pointArray.GetDouble(i);
        double y = pointArray.GetDouble(i + 1);
        double z = pointArray.GetDouble(i + 2);
        polygon.Add(new DVertex(x, y, z));
    }
    return polygon;
}
```

**Impact**: MEDIUM. Users lose all drawn polygons and working state on project reload. This is a UX gap.

---

## Finding 3: Command Registration -- cmdAttribute Boilerplate

**File**: `Module.cs:27-181` (26 command methods)

**Current approach**: Every command is a one-liner method decorated with `[cmd("name")]` that calls `SectionCommandRunner.Run("name", CadView)`. This is the canonical Topomatic pattern, but there are 26 identical wrapper methods.

**Topomatic pattern**: The `[cmd]` attribute on `PluginInitializator` methods is the standard way to register commands. The `.plugin` manifest maps action IDs to command names, which Topomatic routes to these methods.

**Assessment**: **CORRECT pattern, high boilerplate.** The 26 methods are a maintenance burden but follow the Topomatic convention exactly. No action required unless we want to reduce code size.

### Command Registration Best Practices

**1. Use consistent naming conventions**:
- Command name: `"calculate_section"` (lowercase, underscores)
- Method name: `"CalculateSectionCommand"` (PascalCase, Command suffix)
- Action ID in `.plugin`: `"LAS_TERRAIN_CALCULATE_SECTION"` (uppercase)

**2. Group related commands**:
```csharp
// Section calculation commands
#region Section Commands
[cmd("calculate_section")]
public void CalculateSectionCommand() { /* ... */ }

[cmd("calculate_section_custom")]
public void CalculateSectionCustomCommand() { /* ... */ }
#endregion

// LAS file operations
#region LAS Operations
[cmd("clip_las_under")]
public void ClipLasUnderCommand() { /* ... */ }

[cmd("clip_las_below")]
public void ClipLasBelowCommand() { /* ... */ }
#endregion
```

**3. Document commands with XML comments** (shows in Topomatic IntelliSense if referenced):
```csharp
/// <summary>Calculates terrain section points along active alignment</summary>
/// <param name="alignment">Railway alignment for section positioning</param>
/// <param name="step">Distance between sections in meters</param>
[cmd("calculate_section")]
public void CalculateSectionCommand() { /* ... */ }
```

**Impact**: LOW. Functional but verbose.

---

## Finding 4: Custom SectionRegistry Bypasses Topomatic Discovery

**Files**:
- `CommandRegistry/SectionRegistry.cs:7-36` -- reflection-based use case discovery
- `CommandRegistry/SectionCmdAttribute .cs:1-12` -- custom attribute
- `CommandRegistry/ISectionUseCase.cs:1-14` -- custom interface
- `CommandRegistry/SectionCommandRunner.cs:1-26` -- dispatcher
- `CommandRegistry/SectionEnv.cs:1-12` -- environment wrapper

**Current approach**: A parallel command system inside the plugin. `SectionRegistry` scans the assembly for types implementing `ISectionUseCase` decorated with `[SectionCmd]`, instantiates them via `Activator.CreateInstance`, and caches them in a static dictionary. `SectionCommandRunner.Run()` resolves by name.

**Issue -- Singleton Use Cases**: Line 24 of `SectionRegistry.cs`:
```csharp
var instance = (ISectionUseCase)Activator.CreateInstance(type);
```
All use cases are created once at static init time and reused across invocations. This means mutable state in use cases persists between commands, which can cause stale data bugs.

**Issue -- No dependency injection**: `SectionEnv` only wraps `CadView`. Use cases that need `Alignment`, `Surface`, `CadView`, settings, or polygon collections must fetch these themselves internally.

**Assessment**: **Internal registry is reasonable abstraction, but singleton pattern is risky.**

**Impact**: MEDIUM. Singleton use cases with mutable state can cause bugs when the same command is run twice with different data.

---

## Finding 5: No Undo/Transaction System Usage

**File**: `Services/SectionBaseUseCase.cs:221-297` (InsertPointsToSurface)

**Current approach**: Surface modifications use `surface.BeginUpdate()` / `surface.EndUpdate()` for batch operations. These calls control TIN rebuild batching but do NOT participate in the Undo system.

**Topomatic alternative**: The platform provides a full Undo/Redo system:
- `UpdateLoop.BeginTransaction(ITransactable)` -- opens a transaction
- `UpdateLoop.BeginTransaction(INamedTransactable, string caption)` -- named transaction for undo stack
- `UpdateLoop.Commit(ITransactable)` -- commits with undo support
- `UpdateLoop.Rollback(ITransactable)` -- rolls back on error
- `UpdateLoop.InsertCommand(ITransactionManager, ICommand)` -- inserts a custom undo command
- `ICommand` interface with `Undo()` method and `Dispose()`
- `IStateCommand` extends `ICommand` with `CanUndo` property

The `Surface` object itself implements `ITransactable` (it has a `TransactionManager` property). Operations on it could be wrapped in transactions so users can Ctrl+Z to undo point insertions.

### UpdateLoop.BeginTransaction() Code Examples for Undo Support

**Current code** (`SectionBaseUseCase.cs:232-243`):
```csharp
surface.BeginUpdate();
try
{
    var editor = new PointEditor(surface);
    foreach (var p in points)
        editor.Add(new SurfacePoint(p));
}
finally
{
    surface.EndUpdate();
}
```

**Correct pattern with undo support**:

```csharp
// .NET 3.5 compatible transaction wrapper
public void InsertPointsToSurface(Surface surface, List<SurfacePoint> points, string operationName)
{
    if (surface == null || points == null || points.Count == 0)
        return;
    
    // Begin named transaction for undo stack
    UpdateLoop.BeginTransaction(surface, operationName);
    bool committed = false;
    
    try
    {
        surface.BeginUpdate();
        try
        {
            var editor = new PointEditor(surface);
            foreach (var p in points)
            {
                editor.Add(p);
            }
            
            // Mark as successful
            committed = true;
        }
        finally
        {
            surface.EndUpdate();
        }
        
        // Commit the transaction (adds to undo stack)
        if (committed)
        {
            UpdateLoop.Commit(surface);
        }
    }
    catch
    {
        // Rollback on any error
        UpdateLoop.Rollback(surface);
        throw;
    }
}
```

**With batch processing and progress**:

```csharp
public void InsertPointsBatched(Surface surface, List<SurfacePoint> points, 
                                 string operationName, int batchSize = 25000)
{
    if (surface == null || points == null || points.Count == 0)
        return;
    
    // Single transaction for entire operation
    UpdateLoop.BeginTransaction(surface, operationName);
    bool committed = false;
    
    try
    {
        int totalPoints = points.Count;
        for (int i = 0; i < totalPoints; i += batchSize)
        {
            int count = Math.Min(batchSize, totalPoints - i);
            var batch = points.GetRange(i, count);
            
            surface.BeginUpdate();
            try
            {
                var editor = new PointEditor(surface);
                foreach (var p in batch)
                {
                    editor.Add(p);
                }
            }
            finally
            {
                surface.EndUpdate();
            }
            
            // Optional: report progress
            if (Progress != null)
                Progress.Report((i + count) * 100.0 / totalPoints);
        }
        
        committed = true;
    }
    finally
    {
        if (committed)
        {
            UpdateLoop.Commit(surface);
        }
        else
        {
            UpdateLoop.Rollback(surface);
        }
    }
}
```

**Custom undo command approach** (for complex operations):

```csharp
// Custom command that stores point data for undo
private class InsertPointsCommand : ICommand
{
    private Surface m_surface;
    private List<SurfacePoint> m_insertedPoints;
    
    public InsertPointsCommand(Surface surface, List<SurfacePoint> points)
    {
        m_surface = surface;
        m_insertedPoints = new List<SurfacePoint>(points);
    }
    
    public void Undo()
    {
        // Remove inserted points
        m_surface.BeginUpdate();
        try
        {
            var editor = new PointEditor(m_surface);
            foreach (var p in m_insertedPoints)
            {
                // Find and remove the point
                var found = m_surface.Points.FirstOrDefault(
                    sp => Math.Abs(sp.X - p.X) < 0.001 &&
                           Math.Abs(sp.Y - p.Y) < 0.001 &&
                           Math.Abs(sp.Z - p.Z) < 0.001);
                if (found != null)
                    editor.Remove(found);
            }
        }
        finally
        {
            m_surface.EndUpdate();
        }
    }
    
    public void Dispose()
    {
        m_surface = null;
        if (m_insertedPoints != null)
        {
            m_insertedPoints.Clear();
            m_insertedPoints = null;
        }
    }
}

// Usage in InsertPointsToSurface:
public void InsertPointsWithUndoCommand(Surface surface, List<SurfacePoint> points)
{
    var command = new InsertPointsCommand(surface, points);
    
    // Perform the actual insertion
    surface.BeginUpdate();
    try
    {
        var editor = new PointEditor(surface);
        foreach (var p in points)
            editor.Add(p);
    }
    finally
    {
        surface.EndUpdate();
    }
    
    // Insert undo command into transaction manager
    UpdateLoop.InsertCommand(surface.TransactionManager, command);
}
```

**Impact**: HIGH. Users cannot undo surface modifications made by our plugin. For a terrain modeling tool, this is a significant usability gap. A bad LiDAR import can only be undone by manually deleting points or closing without saving.

---

## Finding 6: Settings Persistence -- Using DynamicDictionary for Modern Settings

**File**: `LaunchSettings/Settings.cs:1-243`

**Current approach**: `Settings` implements `IStgSerializable` with `SaveToStg`/`LoadFromStg`. Persistence is achieved by storing the `Settings` singleton in `ApplicationHost.Current.Settings["las_plugin_settings"]`. This is a `Topomatic.ApplicationPlatform.Settings` dictionary that implements `IStgSerializable` itself and persists via `LoadFromFileAsBinary`/`SaveToFileAsBinary`.

**Assessment**: **Working approach, but outdated pattern.** The `ApplicationHost.Current.Settings` dictionary is the older settings storage mechanism. Modern Topomatic plugins should use `DynamicDictionary` from `Topomatic.FoundationClasses` for settings storage, which provides better JSON serialization and type-safe accessors.

### DynamicDictionary for Modern Settings Storage

**.NET 3.5 Compatible Implementation**:

```csharp
// Settings.cs -- Modern implementation using DynamicDictionary
using Topomatic.FoundationClasses;
using Topomatic.Stg;

public class Settings
{
    private static Settings instance;
    private static readonly object lockObj = new object();
    
    // Use DynamicDictionary for storage
    private DynamicDictionary storage;
    
    private Settings()
    {
        storage = new DynamicDictionary();
        SetDefaults();
    }
    
    public static Settings Instance
    {
        get
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    // Load from ApplicationHost settings
                    var host = ApplicationHost.Current;
                    if (host != null && host.Settings != null)
                    {
                        object stored;
                        if (host.Settings.TryGetValue("las_plugin_settings_v2", out stored))
                        {
                            var dict = stored as DynamicDictionary;
                            if (dict != null)
                            {
                                instance = new Settings();
                                instance.storage = dict;
                                return instance;
                            }
                        }
                    }
                    
                    // Create new instance with defaults
                    instance = new Settings();
                }
                return instance;
            }
        }
    }
    
    // Type-safe property accessors using DynamicDictionary methods
    public double GridSizeMeters
    {
        get { return storage.GetDouble("GridSizeMeters", 2.0); }
        set { storage.SetDouble("GridSizeMeters", value); }
    }
    
    public int SmoothIterations
    {
        get { return storage.GetInt("SmoothIterations", 3); }
        set { storage.SetInt("SmoothIterations", value); }
    }
    
    public double Tolerance
    {
        get { return storage.GetDouble("Tolerance", 0.1); }
        set { storage.SetDouble("Tolerance", value); }
    }
    
    public bool UseGpuAcceleration
    {
        get { return storage.GetBoolean("UseGpuAcceleration", false); }
        set { storage.SetBoolean("UseGpuAcceleration", value); }
    }
    
    public string LastLasPath
    {
        get { return storage.GetString("LastLasPath", string.Empty); }
        set { storage.SetString("LastLasPath", value); }
    }
    
    // Complex types as nested dictionaries
    public DynamicDictionary FilterProfile
    {
        get
        {
            if (!storage.HasName("FilterProfile"))
            {
                var profile = storage.AddDictionary("FilterProfile");
                SetFilterProfileDefaults(profile);
                return profile;
            }
            return storage.GetDictionary("FilterProfile");
        }
    }
    
    // Collections as DynamicList
    public DynamicList RecentFiles
    {
        get
        {
            if (!storage.HasName("RecentFiles"))
            {
                return storage.AddList("RecentFiles");
            }
            return storage.GetList("RecentFiles");
        }
    }
    
    public void AddRecentFile(string path)
    {
        var recent = RecentFiles;
        
        // Remove if already exists (move to top)
        for (int i = 0; i < recent.Count; i++)
        {
            if (recent.GetString(i) == path)
            {
                recent.RemoveAt(i);
                break;
            }
        }
        
        // Add to front
        recent.AddString(path);
        
        // Limit to 10 items
        while (recent.Count > 10)
            recent.RemoveAt(recent.Count - 1);
    }
    
    // Serialization using DynamicDictionary's built-in IStgSerializable
    public void SaveToStg(StgNode node)
    {
        storage.SaveToStg(node);
    }
    
    public void LoadFromStg(StgNode node)
    {
        if (node == null)
        {
            SetDefaults();
            return;
        }
        
        storage.Clear();
        storage.LoadFromStg(node);
    }
    
    // Convert to/from JSON (DynamicDictionary supports JSON serialization)
    public string ToJson()
    {
        var sb = new StringBuilder();
        using (var writer = new StringWriter(sb))
        {
            var jsonWriter = new JsonWriter(writer);
            DynamicDictionary.Jsonify(jsonWriter, storage);
        }
        return sb.ToString();
    }
    
    public void FromJson(string json)
    {
        if (string.IsNullOrEmpty(json))
        {
            SetDefaults();
            return;
        }
        
        using (var reader = new StringReader(json))
        {
            var jsonReader = new JsonReader(reader);
            storage.Clear();
            DynamicDictionary.Parse(jsonReader, storage);
        }
    }
    
    private void SetDefaults()
    {
        storage.Clear();
        GridSizeMeters = 2.0;
        SmoothIterations = 3;
        Tolerance = 0.1;
        UseGpuAcceleration = false;
        LastLasPath = string.Empty;
        
        // Set default filter profile
        var profile = storage.AddDictionary("FilterProfile");
        SetFilterProfileDefaults(profile);
    }
    
    private void SetFilterProfileDefaults(DynamicDictionary profile)
    {
        profile.SetDouble("Tolerance", 0.1);
        profile.SetInt("SmoothIterations", 3);
        profile.SetDouble("GridSize", 2.0);
        profile.SetBoolean("UseMorphology", true);
        profile.SetBoolean("UseSpline", true);
    }
    
    // Persist to ApplicationHost
    public void Save()
    {
        var host = ApplicationHost.Current;
        if (host != null && host.Settings != null)
        {
            host.Settings["las_plugin_settings_v2"] = storage;
        }
    }
    
    public void PushToRuntimeConfig()
    {
        RuntimeConfig.Step = GridSizeMeters;
        RuntimeConfig.SmoothIterations = SmoothIterations;
        RuntimeConfig.Tolerance = Tolerance;
        RuntimeConfig.UseGpu = UseGpuAcceleration;
    }
}
```

**Benefits of DynamicDictionary**:
- Type-safe accessors for all primitive types
- Built-in JSON serialization support
- Nested dictionary and list structures
- Thread-safe with proper locking pattern
- Direct IStgSerializable implementation
- Clear API for collections management

**Impact**: LOW for app-level settings. MEDIUM if per-project settings are needed (currently all settings are global across all projects).

---

## Finding 7: Logger Framework Integration

**File**: `Infrastructure/Performance/PerformanceLogger.cs` (custom logging)

**Current approach**: Custom logging implementation writes directly to files. No integration with Topomatic's diagnostics framework.

**Topomatic alternative**: The `Topomatic.FoundationClasses.Diagnostics` namespace provides:
- `Logger` -- central logging singleton
- `LogWriter` -- scoped writer with task identity
- `TaskIdentity` -- operation context for log entries
- `TaskLevel` -- log levels (Error, Warning, Information)
- `TaskRecord` -- individual log records
- `IHelpProvider` -- contextual help integration

### Logger Framework Integration Guide

**.NET 3.5 Compatible Implementation**:

```csharp
// Services/Diagnostics/RoboLasLogger.cs
using Topomatic.FoundationClasses.Diagnostics;

public static class RoboLasLogger
{
    private static readonly TaskIdentity SectionCalcIdentity = 
        new TaskIdentity("SectionCalculation", new object[] { });
    
    private static readonly TaskIdentity LasFilterIdentity = 
        new TaskIdentity("LasFiltering", new object[] { });
    
    private static readonly TaskIdentity SurfaceBuildIdentity = 
        new TaskIdentity("SurfaceBuilding", new object[] { });
    
    // Create logger writers for different contexts
    public static LogWriter CreateSectionLogger()
    {
        return Logger.Current.CreateWriter(SectionCalcIdentity);
    }
    
    public static LogWriter CreateFilterLogger()
    {
        return Logger.Current.CreateWriter(LasFilterIdentity);
    }
    
    public static LogWriter CreateSurfaceLogger()
    {
        return Logger.Current.CreateWriter(SurfaceBuildIdentity);
    }
    
    // Convenience methods for common logging scenarios
    public static void LogSectionStart(int sectionCount, double length)
    {
        var writer = CreateSectionLogger();
        writer.Write(
            string.Format("Starting calculation: {0} sections over {1:N2}m", 
                         sectionCount, length),
            TaskLevel.Information
        );
    }
    
    public static void LogSectionProgress(int current, int total)
    {
        var writer = CreateSectionLogger();
        writer.Write(
            string.Format("Progress: {0}/{1} ({2:P0})", 
                         current, total, (double)current / total),
            TaskLevel.Information
        );
    }
    
    public static void LogFilterError(string message, Exception ex)
    {
        var writer = CreateFilterLogger();
        var helpProvider = new DelegateHelpProvider(() => 
        {
            // Provide contextual help for filter errors
            Console.WriteLine("Filter Error Help: Check LiDAR file format and point density.");
        });
        
        writer.Write(
            string.Format("Filter error: {0}", message),
            TaskLevel.Error,
            helpProvider
        );
        
        // Log exception details
        writer.Write(
            string.Format("Exception: {0}", ex.Message),
            TaskLevel.Error
        );
    }
    
    public static void LogSurfaceTiming(int pointCount, double elapsedSeconds)
    {
        var writer = CreateSurfaceLogger();
        writer.Write(
            string.Format("Inserted {0:N0} points in {1:N2}s ({2:N0} pts/sec)", 
                         pointCount, elapsedSeconds, pointCount / elapsedSeconds),
            TaskLevel.Information
        );
    }
    
    // Custom help provider for diagnostics
    private class DelegateHelpProvider : IHelpProvider
    {
        private readonly Action m_handler;
        
        public DelegateHelpProvider(Action handler)
        {
            m_handler = handler;
        }
        
        public void ProvideHelp(TaskRecord record)
        {
            if (m_handler != null)
                m_handler();
        }
    }
}
```

**Usage in Use Cases**:

```csharp
// In CalculateSectionUseCase
public void Execute(SectionEnv env)
{
    var logger = RoboLasLogger.CreateSectionLogger();
    
    logger.Write("Section calculation started", TaskLevel.Information);
    
    try
    {
        var sections = env.Alignment.CreateSections(step);
        logger.Write(string.Format("Created {0} sections", sections.Count), TaskLevel.Information);
        
        foreach (var section in sections)
        {
            // Collect points
            var points = collector.Collect(section);
            logger.Write(string.Format("Collected {0} points for section {1}", 
                                     points.Count, section.Station), TaskLevel.Information);
            
            // Filter
            var filtered = filter.Apply(points);
            logger.Write(string.Format("Filtered to {0} points", 
                                     filtered.Count), TaskLevel.Information);
        }
        
        logger.Write("Section calculation completed", TaskLevel.Information);
    }
    catch (Exception ex)
    {
        logger.Write(string.Format("Section calculation failed: {0}", ex.Message), 
                    TaskLevel.Error);
        throw;
    }
}
```

**Registering custom log listeners**:

```csharp
// In LasTerrainPluginHost.Initialize()
public override void Initialize(PluginFactory factory)
{
    base.Initialize(factory);
    
    // Register custom log listener for file output
    var fileListener = new RoboLasFileListener(
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "RoboLas", "RoboLas.log")
    );
    Logger.Current.Register(fileListener);
    
    Settings.Instance.PushToRuntimeConfig();
}

// Custom file listener implementation
public class RoboLasFileListener : ILoggerListener
{
    private readonly string m_filePath;
    private readonly object m_lock = new object();
    
    public RoboLasFileListener(string filePath)
    {
        m_filePath = filePath;
        
        // Ensure directory exists
        var dir = Path.GetDirectoryName(m_filePath);
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
    }
    
    public void Clear(TaskIdentity identity)
    {
        // Clear logs for specific task identity
    }
    
    public void Write(TaskRecord[] records)
    {
        lock (m_lock)
        {
            try
            {
                using (var writer = new StreamWriter(m_filePath, true))
                {
                    foreach (var record in records)
                    {
                        var line = string.Format("[{0:yyyy-MM-dd HH:mm:ss}] [{1}] {2}: {3}",
                                               DateTime.Now,
                                               record.Level,
                                               record.Identity != null ? record.Identity.DisplayName : "?",
                                               record.Message);
                        writer.WriteLine(line);
                    }
                }
            }
            catch
            {
                // Silently fail on log write errors
            }
        }
    }
}
```

**Benefits of Logger framework**:
- Centralized logging with automatic routing to multiple listeners
- Task-based organization with identity tracking
- Built-in help provider integration
- Consistent log format across Topomatic
- Easy to add new listeners (file, debug output, network)

**Impact**: LOW. Custom logging works, but Topomatic framework provides better integration and organization.

---

## Finding 8: PluginCoreOps Usage for Model Navigation

**File**: `UseCases/*` (various use cases)

**Current approach**: Each use case fetches its own dependencies (Alignment, Surface, CadView) directly from the CadView or global state. No centralized model navigation utilities.

**Topomatic alternative**: `PluginCoreOps` static class provides 39 extension methods for common operations:
- `FindModel` -- locate models by pathid, URI, or relative path
- `FindFolderModel` -- find folder/container models
- `FindAuxiliaryModel` -- find helper models
- `CreateFolder`, `CreateModel` -- create new model instances
- `GetFileName`, `FindModelPathId` -- path utilities
- `AddPermission`, `HasPermission`, `RemovePermission` -- permission management
- `AddRelatedDocument`, `GetRelatedDocuments` -- document linking
- `LockReadContainer` -- safe read-locking with `using` pattern

### PluginCoreOps Usage Patterns for Model Navigation

**.NET 3.5 Compatible Implementation**:

```csharp
// Services/Model/RoboLasModelOps.cs
using Topomatic.ApplicationPlatform.Core;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.FoundationClasses;

public static class RoboLasModelOps
{
    // Find active alignment with validation
    public static Alignment FindActiveAlignment(CadView cadView)
    {
        if (cadView == null || cadView.Document == null)
            return null;
        
        // Use PluginCoreOps to find the alignment model
        var alignmentModel = PluginCoreOps.FindModel(
            "Alignment",  // Model type
            cadView.Document.Project
        );
        
        return alignmentModel as Alignment;
    }
    
    // Find active surface with fallback
    public static Surface FindActiveSurface(CadView cadView, string surfaceName = null)
    {
        if (cadView == null || cadView.Document == null)
            return null;
        
        // Try specific surface first
        if (!string.IsNullOrEmpty(surfaceName))
        {
            var surfaceModel = PluginCoreOps.FindModel(
                "Surface", 
                cadView.Document.Project
            );
            
            var surface = surfaceModel as Surface;
            if (surface != null && surface.Name == surfaceName)
                return surface;
        }
        
        // Fallback to first available surface
        var surfaces = PluginCoreOps.FindModels("Surface", cadView.Document.Project);
        return surfaces.FirstOrDefault() as Surface;
    }
    
    // Create folder for LAS data storage
    public static IProjectModel EnsureLasFolder(ModelProject project)
    {
        var folder = PluginCoreOps.FindFolderModel(project);
        
        if (folder == null)
        {
            // Create LAS data folder
            folder = PluginCoreOps.CreateFolder(
                new[] { "LAS_DATA" }  // Folder path
            );
        }
        
        return folder;
    }
    
    // Safe read-locking for model access
    public static T ReadLockedModel<T>(IProjectModel model, Func<IProjectModel, T> action)
    {
        return PluginCoreOps.LockReadContainer(model, action);
    }
    
    // Example: read surface points safely
    public static List<SurfacePoint> GetSurfacePointsSafe(Surface surface)
    {
        return ReadLockedModel(surface, m =>
        {
            var points = new List<SurfacePoint>();
            var ptEnum = surface.Points.GetEnumerator();
            
            while (ptEnum.MoveNext())
            {
                points.Add(ptEnum.Current);
            }
            
            return points;
        });
    }
    
    // Permission management
    public static bool CanEditModel(IProjectModel model)
    {
        return PluginCoreOps.HasPermission(model, "editor");
    }
    
    public static void GrantEditPermission(IProjectModel model)
    {
        PluginCoreOps.AddPermission(model, "editor");
    }
    
    // Related documents (link LAS files to project)
    public static void LinkLasFile(IProjectModel model, string lasFilePath)
    {
        PluginCoreOps.AddRelatedDocument(model, lasFilePath);
    }
    
    public static string[] GetLinkedLasFiles(IProjectModel model)
    {
        return PluginCoreOps.GetRelatedDocuments(model)
            .Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    }
    
    // Model path utilities
    public static string GetModelRelativePath(IProjectModel model)
    {
        return PluginCoreOps.FindModelRelativePath(model);
    }
    
    public static IProjectModel FindModelByPath(ModelProject project, string relativePath)
    {
        return PluginCoreOps.FindModel(project, relativePath);
    }
    
    // Batch model operations
    public static IProjectModel[] FindAllSurfaces(ModelProject project)
    {
        return PluginCoreOps.FindModels("Surface", project);
    }
    
    public static IProjectModel[] FindAllAlignments(ModelProject project)
    {
        return PluginCoreOps.FindModels("Alignment", project);
    }
    
    // Auxiliary model finding
    public static IProjectModel FindAuxiliaryByType<T>(ModelProject project) where T : class
    {
        return PluginCoreOps.FindAuxiliaryModel(m => m is T);
    }
}
```

**Usage in Use Cases**:

```csharp
// In CalculateSectionUseCase
public void Execute(SectionEnv env)
{
    // Use helper to find alignment
    var alignment = RoboLasModelOps.FindActiveAlignment(env.CadView);
    if (alignment == null)
    {
        RoboLasLogger.CreateFilterLogger().Write(
            "No active alignment found",
            TaskLevel.Error
        );
        return;
    }
    
    // Use helper to find surface
    var surface = RoboLasModelOps.FindActiveSurface(env.CadView, "Terrain");
    if (surface == null)
    {
        RoboLasLogger.CreateSurfaceLogger().Write(
            "No target surface found",
            TaskLevel.Warning
        );
        return;
    }
    
    // Check permission
    if (!RoboLasModelOps.CanEditModel(surface))
    {
        RoboLasLogger.CreateSurfaceLogger().Write(
            "No edit permission for surface",
            TaskLevel.Error
        );
        return;
    }
    
    // Use safe read for surface points
    var existingPoints = RoboLasModelOps.GetSurfacePointsSafe(surface);
    
    // ... rest of use case logic ...
}
```

**Benefits of PluginCoreOps**:
- Centralized model navigation logic
- Consistent error handling
- Safe read-locking patterns
- Permission management
- Document linking capabilities
- Relative path handling

**Impact**: LOW. Current approach works but duplicates platform functionality. Using PluginCoreOps reduces code and improves consistency.

---

## Finding 9: Property Grid Framework for Auto-Generated UI

**File**: `Infrastructure/UserControl/LasSettingsPanel.cs` (custom WinForms panel)

**Current approach**: A custom `LasSettingsPanel` is created via `[cmd("create_las_settings_panel")]` in Module and registered in the `.plugin` manifest as a dockable panel. Settings are edited in this custom panel with manual property change handling.

**Topomatic alternative**: `Topomatic.ComponentModel` provides a complete property grid framework:
- `CustomProperty` -- base property descriptor
- `SimpleProperty` -- simple bound property
- `MultiProperty` -- multi-selection property
- `PropertyEditor` -- custom editors (dropdown, modal, color, date)
- `PropertyTypeConverter` -- type conversion for display/edit
- `PropertyProvider` -- dynamic property expansion
- `PropertyExplorer` -- property enumeration
- Attributes for metadata: `[Description]`, `[Category]`, `[ReadOnly]`, `[Browsable]`

### Property Grid Framework for Auto-Generated UI

**.NET 3.5 Compatible Implementation**:

```csharp
// Infrastructure/Settings/RoboLasSettingsProvider.cs
using System.ComponentModel;
using Topomatic.ComponentModel;
using Topomatic.ApplicationPlatform;

public class RoboLasSettingsProvider
{
    public static IEnumerable<CustomProperty> GetSettingsProperties()
    {
        var properties = new List<CustomProperty>();
        
        // Get property info from Settings type
        var settingsType = typeof(Settings);
        var properties = settingsType.GetProperties(
            BindingFlags.Public | BindingFlags.Instance
        );
        
        foreach (var propInfo in properties)
        {
            // Skip non-editable properties
            var attrs = propInfo.GetCustomAttributes(false);
            if (attrs.OfType<ReadOnlyAttribute>().Any())
                continue;
            
            if (attrs.OfType<BrowsableAttribute>().Any(a => !a.Browsable))
                continue;
            
            // Create property descriptor
            var property = CreateProperty(propInfo, Settings.Instance, attrs);
            if (property != null)
                properties.Add(property);
        }
        
        return properties;
    }
    
    private static CustomProperty CreateProperty(
        PropertyInfo propInfo, 
        object instance,
        object[] attributes)
    {
        // Get display name from attribute or property name
        var displayName = GetDisplayName(propInfo, attributes);
        
        // Get category
        var category = GetCategory(propInfo, attributes);
        
        // Get description
        var description = GetDescription(propInfo, attributes);
        
        // Get converter type
        var converterType = SimpleProperty.GetConverterType(propInfo, attributes);
        
        // Get editor type
        var editorType = SimpleProperty.GetEditorType(propInfo, attributes);
        
        // Create the property
        var property = new SimpleProperty(
            propInfo, 
            instance, 
            attributes
        );
        
        // Set metadata
        property.DisplayName = displayName;
        property.Category = category;
        property.Description = description;
        
        // Set converter if custom
        if (converterType != null)
        {
            property.Converter = PropertyTypeConverterFactory.CreateConverter(converterType);
        }
        
        // Set editor if custom
        if (editorType != null)
        {
            property.Editor = PropertyEditorFactory.CreateEditor(editorType);
        }
        
        return property;
    }
    
    private static string GetDisplayName(PropertyInfo propInfo, object[] attributes)
    {
        var displayNameAttr = attributes.OfType<DisplayNameAttribute>().FirstOrDefault();
        if (displayNameAttr != null)
            return displayNameAttr.DisplayName;
        
        // Convert PascalCase to space-separated words
        var name = propInfo.Name;
        var result = new StringBuilder();
        for (int i = 0; i < name.Length; i++)
        {
            if (i > 0 && char.IsUpper(name[i]))
                result.Append(' ');
            result.Append(name[i]);
        }
        return result.ToString();
    }
    
    private static string GetCategory(PropertyInfo propInfo, object[] attributes)
    {
        var categoryAttr = attributes.OfType<CategoryAttribute>().FirstOrDefault();
        if (categoryAttr != null)
            return categoryAttr.Category;
        
        // Infer category from property name prefix
        var name = propInfo.Name;
        if (name.StartsWith("Grid"))
            return "Grid Settings";
        if (name.StartsWith("Smooth") || name.StartsWith("Filter"))
            return "Filtering";
        if (name.StartsWith("Gpu") || name.StartsWith("Use"))
            return "Performance";
        if (name.StartsWith("Last") || name.StartsWith("Recent"))
            return "History";
        
        return "General";
    }
    
    private static string GetDescription(PropertyInfo propInfo, object[] attributes)
    {
        var descAttr = attributes.OfType<DescriptionAttribute>().FirstOrDefault();
        if (descAttr != null)
            return descAttr.Description;
        
        // Generate default description
        var name = GetDisplayName(propInfo, attributes);
        return string.Format("Gets or sets the {0}.", name.ToLower());
    }
}

// Custom editors for specific property types
public class DoubleStepEditor : PropertyEditor
{
    public override PropertyTypeEditorEditStyle GetEditStyle(IPropertyTypeDescriptorContext context)
    {
        return PropertyTypeEditorEditStyle.DropDown;
    }
    
    public override object EditValue(
        IPropertyTypeDescriptorContext context, 
        IPropertyWindowsFormsEditorService editorService,
        int button)
    {
        // Custom UI for numeric step editing
        var currentValue = (double)context.Value;
        
        // Show simple dialog with step buttons
        using (var form = new Form())
        {
            form.Text = "Edit Value";
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Size = new Size(200, 150);
            
            var label = new Label();
            label.Text = context.Property.DisplayName + ":";
            label.Location = new Point(10, 10);
            label.Size = new Size(180, 20);
            form.Controls.Add(label);
            
            var valueLabel = new Label();
            valueLabel.Text = currentValue.ToString("F3");
            valueLabel.Location = new Point(10, 35);
            valueLabel.Size = new Size(180, 20);
            form.Controls.Add(valueLabel);
            
            var upButton = new Button();
            upButton.Text = "+";
            upButton.Location = new Point(10, 60);
            upButton.Size = new Size(80, 30);
            upButton.Click += (s, e) => 
            {
                currentValue += 0.1;
                valueLabel.Text = currentValue.ToString("F3");
            };
            form.Controls.Add(upButton);
            
            var downButton = new Button();
            downButton.Text = "-";
            downButton.Location = new Point(100, 60);
            downButton.Size = new Size(80, 30);
            downButton.Click += (s, e) => 
            {
                currentValue = Math.Max(0, currentValue - 0.1);
                valueLabel.Text = currentValue.ToString("F3");
            };
            form.Controls.Add(downButton);
            
            if (editorService.ShowDialog(form) == DialogResult.OK)
                return currentValue;
        }
        
        return context.Value;
    }
}

// Custom converter for enum display
public class FilterAlgorithmConverter : PropertyTypeConverter
{
    private static readonly string[] Names = new string[]
    {
        "Morphological Open",
        "Graph Ground",
        "Progressive Morphological",
        "Adaptive TIN"
    };
    
    public override bool CanConvertFromString(Type sourceType)
    {
        return sourceType == typeof(string);
    }
    
    public override bool CanConvertToString(Type sourceType)
    {
        return sourceType == typeof(FilterAlgorithm);
    }
    
    public override object ConvertFromString(string value)
    {
        int index = Array.IndexOf(Names, value);
        if (index >= 0)
            return (FilterAlgorithm)index;
        return FilterAlgorithm.MorphologicalOpen;
    }
    
    public override string ConvertToString(object value)
    {
        if (value is FilterAlgorithm)
        {
            int index = (int)value;
            if (index >= 0 && index < Names.Length)
                return Names[index];
        }
        return "Unknown";
    }
}
```

**Settings class with attributes**:

```csharp
// Settings.cs -- Add attributes for property grid
public class Settings
{
    [Category("Grid Settings")]
    [Description("Distance between grid points in meters")]
    [DisplayName("Grid Size")]
    [ReadOnly(false)]
    public double GridSizeMeters
    {
        get { /* ... */ }
        set { /* ... */ }
    }
    
    [Category("Filtering")]
    [Description("Number of smoothing iterations")]
    [DisplayName("Smooth Iterations")]
    public int SmoothIterations
    {
        get { /* ... */ }
        set { /* ... */ }
    }
    
    [Category("Filtering")]
    [Description("Ground point tolerance in meters")]
    [DisplayName("Tolerance")]
    public double Tolerance
    {
        get { /* ... */ }
        set { /* ... */ }
    }
    
    [Category("Performance")]
    [Description("Enable GPU acceleration for filtering")]
    [DisplayName("Use GPU")]
    public bool UseGpuAcceleration
    {
        get { /* ... */ }
        set { /* ... */ }
    }
    
    [Category("Filtering")]
    [Description("Primary filtering algorithm")]
    [DisplayName("Filter Algorithm")]
    [PropertyConverter(typeof(FilterAlgorithmConverter))]
    public FilterAlgorithm Algorithm
    {
        get { /* ... */ }
        set { /* ... */ }
    }
    
    [Category("Performance")]
    [Description("Number of parallel threads for processing")]
    [DisplayName("Thread Count")]
    [PropertyEditor(typeof(ThreadCountEditor))]
    public int ThreadCount
    {
        get { /* ... */ }
        set { /* ... */ }
    }
}
```

**Integration in settings panel**:

```csharp
// LasSettingsPanel.cs -- Auto-generate from properties
public partial class LasSettingsPanel : UserControl
{
    private PropertyGrid propertyGrid;
    
    public LasSettingsPanel()
    {
        InitializeComponent();
        CreatePropertyGrid();
    }
    
    private void CreatePropertyGrid()
    {
        // Create property grid
        propertyGrid = new PropertyGrid();
        propertyGrid.Dock = DockStyle.Fill;
        propertyGrid.ToolbarVisible = true;
        propertyGrid.HelpVisible = true;
        propertyGrid.PropertySort = PropertySort.Categorized;
        
        // Generate properties from Settings
        var properties = RoboLasSettingsProvider.GetSettingsProperties();
        propertyGrid.SelectedObject = new PropertyBag(properties);
        
        this.Controls.Add(propertyGrid);
    }
    
    // Property bag wrapper for settings
    private class PropertyBag
    {
        private List<CustomProperty> properties;
        
        public PropertyBag(IEnumerable<CustomProperty> props)
        {
            properties = new List<CustomProperty>(props);
        }
        
        public IEnumerable<CustomProperty> Properties
        {
            get { return properties; }
        }
    }
}
```

**Benefits of Property Grid Framework**:
- Auto-generated UI from property definitions
- Consistent look and feel with Topomatic
- Built-in category organization
- Custom editors for specific types
- Type converters for display formatting
- Validation and read-only support
- Undo/redo integration

**Impact**: LOW. Custom panel works but property grid reduces code and improves consistency.

---

## Finding 10: Plugin Lifecycle Management Improvements

**File**: `LasTerrainPluginHost.cs` (plugin initialization)

**Current approach**: Basic plugin initialization with `Settings.Instance.PushToRuntimeConfig()`. No lifecycle hooks for project open/save, document events, or cleanup.

**Topomatic alternative**: The plugin system supports lifecycle management through:
- `PluginInitializator` virtual methods for project events
- `IProjectImp` interface for document events
- `IDocumentWindow` events for window lifecycle
- `IApplicationHost` events for application-level hooks

### Plugin Lifecycle Management Improvements

**.NET 3.5 Compatible Implementation**:

```csharp
// LasTerrainPluginHost.cs -- Enhanced lifecycle management
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Core;

public class LasTerrainPluginHost : PluginHostInitializator
{
    private static LasTerrainPluginHost instance;
    private IApplicationHost appHost;
    private PluginFactory factory;
    
    public override void Initialize(PluginFactory factory)
    {
        this.factory = factory;
        this.appHost = ApplicationHost.Current;
        instance = this;
        
        base.Initialize(factory);
        
        // Register event handlers
        RegisterLifecycleHooks();
        
        // Initialize settings
        Settings.Instance.PushToRuntimeConfig();
        
        // Register plugin services
        RegisterPluginServices();
    }
    
    private void RegisterLifecycleHooks()
    {
        // Application-level events
        if (appHost != null)
        {
            // Project opened event
            appHost.ActiveProjectChanged += (sender, e) =>
            {
                OnProjectChanged(appHost.ActiveProject);
            };
        }
        
        // Document events for each opened window
        if (appHost != null && appHost.ActiveProject != null)
        {
            var imp = appHost.ActiveProject.Imp;
            if (imp != null)
            {
                imp.AddDocumentWindow += (sender, e) =>
                {
                    OnDocumentWindowAdded(e.Window);
                };
            }
        }
    }
    
    private void RegisterPluginServices()
    {
        // Register custom model editors
        factory.RegisterModelEditor("LAS_POINT_CLOUD", new ModelEditorInfo(
            "LAS Point Cloud",
            ".las",
            "LiDAR Point Cloud Files",
            "Stores LAS file references and filter parameters",
            "RoboLas.LasPointCloudActivator"
        ));
        
        // Register project settings page
        factory.RegisterProjectSettings("LAS_TERRAIN_SETTINGS", "ShowLasSettingsPanel");
        
        // Register custom types
        factory.RegisterType("LAS_FILTER_PROFILE", typeof(FilterProfile));
        factory.RegisterType("LAS_POLYGON_COLLECTION", typeof(PolygonCollection));
        
        // Register custom functions
        factory.RegisterFunction("calculate_section_async", new CalculateSectionAsyncFunction());
        factory.RegisterFunction("import_las_batch", new ImportLasBatchFunction());
    }
    
    private void OnProjectChanged(Project newProject)
    {
        // Clear module state when project changes
        if (Module.Instance != null)
        {
            Module.Instance.OnProjectChanged(newProject);
        }
        
        // Log project change
        var logger = Logger.Current.CreateWriter(
            new TaskIdentity("PluginLifecycle", new object[] { })
        );
        
        if (newProject != null)
        {
            logger.Write(
                string.Format("Project changed: {0}", newProject.Alias),
                TaskLevel.Information
            );
        }
        else
        {
            logger.Write("Project closed", TaskLevel.Information);
        }
    }
    
    private void OnDocumentWindowAdded(IDocumentWindow window)
    {
        // Attach to document window events
        window.Load += (sender, e) =>
        {
            OnDocumentWindowLoad(window);
        };
        
        window.FormClosing += (sender, e) =>
        {
            OnDocumentWindowClosing(window, e);
        };
    }
    
    private void OnDocumentWindowLoad(IDocumentWindow window)
    {
        // Initialize plugin state for this window
        var logger = Logger.Current.CreateWriter(
            new TaskIdentity("PluginLifecycle", new object[] { })
        );
        logger.Write(
            string.Format("Document window loaded: {0}", window.UID),
            TaskLevel.Information
        );
        
        // Restore visual state if applicable
        RestoreWindowVisualState(window);
    }
    
    private void OnDocumentWindowClosing(IDocumentWindow window, FormClosingEventArgs e)
    {
        // Save visual state before closing
        SaveWindowVisualState(window);
        
        // Prompt to save unsaved changes
        if (Module.Instance != null && Module.Instance.HasUnsavedChanges)
        {
            var result = MessageBox.Show(
                "Save changes before closing?",
                "RoboLas",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );
            
            if (result == DialogResult.Yes)
            {
                Module.Instance.Save();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
    
    private void RestoreWindowVisualState(IDocumentWindow window)
    {
        // Restore layer visibility from module
        if (Module.Instance != null)
        {
            Module.Instance.RestoreVisualState(window);
        }
    }
    
    private void SaveWindowVisualState(IDocumentWindow window)
    {
        // Save current layer visibility to module
        if (Module.Instance != null)
        {
            Module.Instance.SaveVisualState(window);
        }
    }
    
    public override void Shutdown()
    {
        // Cleanup on plugin shutdown
        if (factory != null)
        {
            // Unregister functions, types, etc. if needed
            factory = null;
        }
        
        // Save settings
        Settings.Instance.Save();
        
        // Clear static references
        if (Module.Instance != null)
        {
            Module.Instance.Dispose();
        }
        
        instance = null;
        
        base.Shutdown();
    }
    
    public static LasTerrainPluginHost Instance
    {
        get { return instance; }
    }
}

// Enhanced Module with lifecycle support
public class Module : PluginInitializator
{
    private bool hasUnsavedChanges;
    private Dictionary<string, bool> windowLayerStates;
    
    public bool HasUnsavedChanges
    {
        get { return hasUnsavedChanges; }
    }
    
    public void OnProjectChanged(Project newProject)
    {
        // Clear state when project changes
        if (CrsPolygonCollection != null)
            CrsPolygonCollection.Clear();
        if (PlanPolygonCollection != null)
            PlanPolygonCollection.Clear();
        
        hasUnsavedChanges = false;
        
        // Load project-specific settings if available
        if (newProject != null)
        {
            LoadProjectSettings(newProject);
        }
    }
    
    public void SaveVisualState(IDocumentWindow window)
    {
        if (window == null || windowLayerStates == null)
            return;
        
        // Save layer visibility
        windowLayerStates[window.UID] = GetCurrentLayerVisibility(window);
    }
    
    public void RestoreVisualState(IDocumentWindow window)
    {
        if (window == null || windowLayerStates == null)
            return;
        
        bool visibility;
        if (windowLayerStates.TryGetValue(window.UID, out visibility))
        {
            SetLayerVisibility(window, visibility);
        }
    }
    
    public void Save()
    {
        // Persist all module state
        var project = ApplicationHost.Current.ActiveProject;
        if (project != null)
        {
            SaveProjectSettings(project);
        }
        
        hasUnsavedChanges = false;
    }
    
    private void SaveProjectSettings(Project project)
    {
        // Save to project's settings
        var settingsNode = project.Settings.AddNode("LAS_TERRAIN_MODULE");
        SaveToStg(settingsNode);
    }
    
    private void LoadProjectSettings(Project project)
    {
        // Load from project's settings
        var settingsNode = project.Settings.GetNode("LAS_TERRAIN_MODULE");
        if (settingsNode != null)
        {
            LoadFromStg(settingsNode);
        }
    }
}
```

**Benefits of lifecycle management**:
- Automatic state persistence on project save/load
- Proper cleanup on shutdown
- Event-driven architecture
- Integration with Topomatic document model
- Unsaved changes tracking

**Impact**: MEDIUM. Plugin works without lifecycle hooks, but state management is manual.

---

## Summary Table

| # | Finding | File | Severity | Topomatic API Available | Current State |
|---|---------|------|----------|------------------------|---------------|
| 1 | PluginHostInitializator underutilized | LasTerrainPluginHost.cs | LOW | PluginFactory registration | Correct but minimal |
| 2 | Module ignores IStgSerializable | Module.cs | MEDIUM | PluginInitializator.SaveToStg/LoadFromStg | No persistence |
| 3 | cmdAttribute boilerplate | Module.cs | LOW | Standard pattern | 26 wrapper methods |
| 4 | Singleton use cases, no DI | CommandRegistry/ | MEDIUM | N/A (internal) | Singleton with stale state risk |
| 5 | No Undo/Transaction for surface edits | SectionBaseUseCase.cs | HIGH | UpdateLoop, ITransactable, ICommand | surface.BeginUpdate only |
| 6 | Settings using outdated pattern | Settings.cs | LOW | DynamicDictionary | Working but not modern |
| 7 | Custom logging vs Logger framework | PerformanceLogger.cs | LOW | Logger, LogWriter, TaskIdentity | Custom implementation |
| 8 | Manual model navigation | UseCases/* | LOW | PluginCoreOps | Duplicated functionality |
| 9 | Custom settings panel vs Property Grid | LasSettingsPanel.cs | LOW | CustomProperty, PropertyEditor | Custom panel |
| 10 | Minimal lifecycle management | LasTerrainPluginHost.cs | MEDIUM | IProjectImp, IDocumentWindow events | Basic initialization |

---

## Priority Recommendations

### P0 -- HIGH (Implement First)
1. **Wrap surface point insertion in ITransaction** (Finding 5). This enables Ctrl+Z for LiDAR imports and allows rollback on cancellation. Changes needed in `SectionBaseUseCase.InsertPointsToSurface()`.

### P1 -- MEDIUM (Next Sprint)
2. **Override SaveToStg/LoadFromStg on Module** (Finding 2). Persist polygon collections and working state so users do not lose work on project reload.
3. **Migrate Settings to DynamicDictionary** (Finding 6). Modern settings storage with better type safety and JSON support.
4. **Implement plugin lifecycle hooks** (Finding 10). Proper cleanup and state persistence on project change.

### P2 -- LOW (Backlog)
5. **Integrate Logger framework** (Finding 7). Use Topomatic diagnostics for centralized logging.
6. **Use PluginCoreOps for model navigation** (Finding 8). Reduce code duplication with platform utilities.
7. **Consider Property Grid for settings UI** (Finding 9). Auto-generated UI from property attributes.
8. **Fix singleton use cases** (Finding 4). Either make all use cases stateless or create fresh instances per invocation.

---

## Migration Guide

### Step 1: Add Undo Support (P0)

1. Update `SectionBaseUseCase.InsertPointsToSurface()`:
   - Replace `surface.BeginUpdate()`/`EndUpdate()` with `UpdateLoop.BeginTransaction()`/`Commit()`
   - Add transaction name for undo stack
   - Implement rollback on exception

### Step 2: Implement Module Persistence (P1)

1. Override `SaveToStg()`/`LoadFromStg()` in `Module.cs`
2. Save polygon collections to StgNode arrays
3. Save last-used parameters
4. Restore state in `LoadFromStg()`
5. Call persistence from project save/load hooks

### Step 3: Migrate Settings to DynamicDictionary (P1)

1. Replace `Settings` storage with `DynamicDictionary`
2. Update property accessors to use type-safe methods
3. Implement `SaveToStg()`/`LoadFromStg()` using built-in methods
4. Update `ApplicationHost.Current.Settings` storage

### Step 4: Add Plugin Lifecycle Hooks (P1)

1. Register event handlers in `LasTerrainPluginHost.Initialize()`
2. Implement `OnProjectChanged()` for state management
3. Add document window event handlers
4. Implement cleanup in `Shutdown()`

### Step 5: Integrate Logger Framework (P2)

1. Replace `PerformanceLogger` with `Logger.Current`
2. Create `TaskIdentity` for operations
3. Use `LogWriter` for scoped logging
4. Register custom `ILoggerListener` for file output

### Step 6: Use PluginCoreOps (P2)

1. Create `RoboLasModelOps` helper class
2. Replace manual model finding with `PluginCoreOps.FindModel()`
3. Use `LockReadContainer` for safe model access
4. Implement permission management

### Step 7: Consider Property Grid (P2)

1. Add attributes to `Settings` properties
2. Create `RoboLasSettingsProvider`
3. Implement custom editors and converters
4. Update `LasSettingsPanel` to use `PropertyGrid`

### Step 8: Fix Singleton Use Cases (P2)

1. Modify `SectionRegistry.Resolve()` to create instances per call
2. Ensure all use cases are stateless
3. Pass dependencies through `SectionEnv`
4. Add lifecycle management for use case instances

---

## Conclusion

The LAS_TERRAIN plugin uses a correct subset of the Topomatic API but has significant opportunities for improvement. The highest priority is implementing Undo/Transaction support for surface modifications, which would dramatically improve user experience. Module-level persistence and settings modernization would follow. The Logger framework, PluginCoreOps, and Property Grid provide incremental improvements in code quality and maintainability.
