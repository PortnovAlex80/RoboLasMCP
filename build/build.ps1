# LAS_TERRAIN Build Script for Topomatic
# Usage: .\build.ps1 [-Path] "C:\Program Files\Topomatic Robur Rail 17.0" [-Configuration] Debug|Release

param(
    [string]$Path = "",
    [string]$Configuration = "Release",
    [switch]$Help
)

if ($Help) {
    Write-Host "LAS_TERRAIN Build Script for Topomatic" -ForegroundColor Cyan
    Write-Host ""
    Write-Host "Usage: .\build.ps1 [-Path] `"TopomaticPath`" [-Configuration] Debug|Release"
    Write-Host ""
    Write-Host "Examples:"
    Write-Host "  .\build.ps1                                    # Auto-detect Topomatic"
    Write-Host "  .\build.ps1 -Path `"C:\Program Files\Topomatic Robur Rail 17.0`""
    Write-Host "  .\build.ps1 -Configuration Debug              # Debug build"
    Write-Host "  .\build.ps1 -Path `"...`" -Configuration Release"
    Write-Host ""
    exit 0
}

# Project root (one level up from build folder)
$ProjectRoot = Split-Path $PSScriptRoot -Parent

# ========================================
# Find MSBuild
# ========================================
function Find-MSBuild {
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"

    # Try vswhere first (VS 2017+)
    if (Test-Path $vswhere) {
        $msbuild = & $vswhere -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe 2>$null | Select-Object -First 1
        if ($msbuild) { return $msbuild }
    }

    # Fallback: Try common VS 2022 paths
    $vs2022Paths = @(
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\MSBuild.exe",
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\amd64\MSBuild.exe",
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\amd64\MSBuild.exe"
    )
    foreach ($p in $vs2022Paths) {
        if (Test-Path $p) { return $p }
    }

    # Fallback: VS 2019
    $vs2019Paths = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\amd64\MSBuild.exe",
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\amd64\MSBuild.exe"
    )
    foreach ($p in $vs2019Paths) {
        if (Test-Path $p) { return $p }
    }

    # Fallback: .NET Framework
    $frameworkPath = "$env:SystemRoot\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
    if (Test-Path $frameworkPath) { return $frameworkPath }

    return $null
}

$MSBuild = Find-MSBuild
if (-not $MSBuild) {
    Write-Host "ERROR: MSBuild not found!" -ForegroundColor Red
    Write-Host "Please install Visual Studio 2019/2022 or .NET Framework 4.0+" -ForegroundColor Red
    exit 1
}

Write-Host "Found MSBuild: $MSBuild" -ForegroundColor Green

# ========================================
# Find Topomatic
# ========================================
if ([string]::IsNullOrWhiteSpace($Path)) {
    Write-Host "Auto-detecting Topomatic installations..." -ForegroundColor Yellow

    $possiblePaths = @(
        "C:\Program Files\Topomatic Robur Rail 17.0",
        "C:\Program Files\Topomatic Robur Road 17.0",
        "C:\Program Files\Topomatic Robur Rail 16.0",
        "C:\Program Files\Topomatic Robur Road 16.0",
        "C:\Program Files\Topomatic Robur Rail 15.0",
        "C:\Program Files\Topomatic Robur Road 15.0"
    )

    foreach ($p in $possiblePaths) {
        if (Test-Path $p) {
            $Path = $p
            Write-Host "Found: $p" -ForegroundColor Green
            break
        }
    }

    if ([string]::IsNullOrWhiteSpace($Path)) {
        Write-Host "ERROR: No Topomatic installation found!" -ForegroundColor Red
        Write-Host "Please specify path: .\build.ps1 -Path `"C:\Program Files\Topomatic Robur Rail 16.0`""
        exit 1
    }
}

# Verify Topomatic path
if (-not (Test-Path $Path)) {
    Write-Host "ERROR: Topomatic path does not exist: $Path" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Building LAS_TERRAIN Plugin" -ForegroundColor Cyan
Write-Host "SDK: $Path" -ForegroundColor Cyan
Write-Host "Configuration: $Configuration" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Build using MSBuild
$csproj = Join-Path $ProjectRoot "LAS_TERRAIN.csproj"
& $MSBuild $csproj /p:Configuration=$Configuration "/p:TopomaticPath=$Path" "/p:ReferencePath=$Path" /v:minimal

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Green
    Write-Host "Build SUCCESS!" -ForegroundColor Green
    Write-Host "Output: $(Join-Path $ProjectRoot "bin\$Configuration\LAS_TERRAIN.dll")" -ForegroundColor Green
    Write-Host "========================================" -ForegroundColor Green
} else {
    Write-Host ""
    Write-Host "========================================" -ForegroundColor Red
    Write-Host "Build FAILED!" -ForegroundColor Red
    Write-Host "========================================" -ForegroundColor Red
    exit 1
}
