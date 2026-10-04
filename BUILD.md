# Multi-Version Build System for Topomatic

## Overview

The project now supports automatic building for different Topomatic versions without manual configuration changes.
Normal Debug and Release builds write to `bin\Debug` and `bin\Release` in this repository.
`TopomaticPath` selects SDK references; building does not install the plugin or clear the host cache.

## Quick Start

### Windows Batch Scripts

```cmd
# Auto-detect and build (Release)
build\build.bat

# Build for specific version
build\build.bat "C:\Program Files\Topomatic Robur Rail 17.0"

# Debug build
build\build_debug.bat

# Debug build for specific version
build\build_debug.bat "C:\Program Files\Topomatic Robur Road 16.0"
```

### PowerShell Script

```powershell
# Auto-detect and build
.\build\build.ps1

# Build for specific version
.\build\build.ps1 -Path "C:\Program Files\Topomatic Robur Rail 17.0"

# Debug build
.\build\build.ps1 -Configuration Debug

# Full control
.\build\build.ps1 -Path "..." -Configuration Release
```

### Direct MSBuild

```cmd
msbuild LAS_TERRAIN.csproj /p:Configuration=Release /p:TopomaticPath="C:\Program Files\Topomatic Robur Rail 17.0"
```

### Environment Variable

```cmd
set TOPOMATIC_PATH=C:\Program Files\Topomatic Robur Rail 17.0
msbuild LAS_TERRAIN.csproj /p:Configuration=Release
```

## Auto-Detection Order

The build system automatically searches for Topomatic in this order:

1. Topomatic Robur Rail 17.0
2. Topomatic Robur Road 17.0
3. Topomatic Robur Rail 16.0
4. Topomatic Robur Road 16.0
5. Topomatic Robur Rail 15.0
6. Topomatic Robur Road 15.0

## Supported Topomatic Versions

- **Topomatic Robur Rail 15.0** - Railway version
- **Topomatic Robur Road 15.0** - Road version
- **Topomatic Robur Rail 16.0** - Railway version (current default)
- **Topomatic Robur Road 16.0** - Road version
- **Topomatic Robur Rail 17.0** - Railway version
- **Topomatic Robur Road 17.0** - Road version

## Project File Changes

The `.csproj` file now uses:

- **Variable `TopomaticPath`** - dynamic path resolution
- **Auto-detection logic** - finds installed Topomatic versions
- **Environment variable support** - `TOPOMATIC_PATH`
- **Command-line override** - MSBuild property `TopomaticPath`

All DLL references now use `$(TopomaticPath)` instead of hardcoded paths.

## Building for Multiple Versions

### Batch Script for All Versions

Create `build_all.bat`:

```cmd
@echo off
call build.bat "C:\Program Files\Topomatic Robur Rail 15.0"
call build.bat "C:\Program Files\Topomatic Robur Road 15.0"
call build.bat "C:\Program Files\Topomatic Robur Rail 16.0"
call build.bat "C:\Program Files\Topomatic Robur Road 16.0"
call build.bat "C:\Program Files\Topomatic Robur Rail 17.0"
call build.bat "C:\Program Files\Topomatic Robur Road 17.0"
```

### PowerShell Script for All Versions

Create `build_all.ps1`:

```powershell
$versions = @(
    "C:\Program Files\Topomatic Robur Rail 15.0",
    "C:\Program Files\Topomatic Robur Road 15.0",
    "C:\Program Files\Topomatic Robur Rail 16.0",
    "C:\Program Files\Topomatic Robur Road 16.0",
    "C:\Program Files\Topomatic Robur Rail 17.0",
    "C:\Program Files\Topomatic Robur Road 17.0"
)

foreach ($version in $versions) {
    if (Test-Path $version) {
        Write-Host "Building for: $version" -ForegroundColor Cyan
        .\build.ps1 -Path $version
    }
}
```

## Troubleshooting

### Build Fails with "Cannot find Topomatic DLLs"

**Solution**: Specify the Topomatic path explicitly:
```cmd
build.bat "C:\Program Files\Topomatic Robur Rail 16.0"
```

### Multiple Topomatic Versions Installed

**Solution**: Always specify the path explicitly or set `TOPOMATIC_PATH` environment variable.

### Wrong Version Detected

**Solution**: The auto-detection prioritizes newer versions. Specify your version explicitly.

## Integration with CI/CD

### GitHub Actions Example

```yaml
name: Build for Topomatic

on: [push, pull_request]

jobs:
  build:
    runs-on: windows-latest
    strategy:
      matrix:
        topomatic:
          - "C:\Program Files\Topomatic Robur Rail 16.0"
          - "C:\Program Files\Topomatic Robur Road 16.0"

    steps:
    - uses: actions/checkout@v2
    - name: Build LAS_TERRAIN
      run: |
        .\build.ps1 -Path "${{ matrix.topomatic }}" -Configuration Release
```

## .NET Framework 3.5 Requirement

**CRITICAL**: This project strictly targets .NET Framework 3.5.
- NO modern C# features allowed
- Ensure .NET Framework 3.5 is enabled in Windows
- Use appropriate MSBuild tools version

## Output Locations

Built assemblies are automatically copied to:
- **Debug/Release**: `<TopomaticPath>\LAS_TERRAIN.dll`
- **Plugin files**: `<TopomaticPath>\LAS_TERRAIN.plugin`

## Pre-Build Event

The project includes a pre-build event that cleans old assemblies:
```cmd
del /q "C:\Users\%username%\AppData\Local\Topomatic\Robur rail\16.0\assemblies\*"
```

**Note**: You may need to adjust this for different Topomatic versions or product lines (Rail vs Road).
