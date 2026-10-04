# LAS_TERRAIN Local Build Script
# Builds to D:\LAS_TERRAIN_BUILD and creates .tpm package
# Usage: .\build_local.ps1 [-Version "1.0.0"]

param(
    [string]$Version = "1.0.0",
    [string]$OutputPath = "D:\LAS_TERRAIN_BUILD",
    [string]$TopomaticPath = $env:TOPOMATIC_PATH
)

$ErrorActionPreference = "Stop"
$ProjectRoot = Split-Path $PSScriptRoot -Parent
if ([string]::IsNullOrWhiteSpace($TopomaticPath)) {
    throw 'Pass -TopomaticPath pointing to the intended Topomatic SDK copy.'
}
$sdkRoot = (Resolve-Path -LiteralPath $TopomaticPath).Path
$outputRoot = [System.IO.Path]::GetFullPath($OutputPath)
if ([string]::Equals($outputRoot, $sdkRoot, [StringComparison]::OrdinalIgnoreCase) -or
    $outputRoot.StartsWith($sdkRoot.TrimEnd('\') + '\', [StringComparison]::OrdinalIgnoreCase) -or
    $outputRoot -match '^[A-Za-z]:\\Program Files( \(x86\))?\\') {
    throw 'Build output must not be inside a Topomatic installation or Program Files.'
}

# ========================================
# Find MSBuild
# ========================================
function Find-MSBuild {
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"

    if (Test-Path $vswhere) {
        $msbuild = & $vswhere -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe 2>$null | Select-Object -First 1
        if ($msbuild) { return $msbuild }
    }

    $vs2022Paths = @(
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\MSBuild.exe",
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\amd64\MSBuild.exe",
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\amd64\MSBuild.exe"
    )
    foreach ($p in $vs2022Paths) {
        if (Test-Path $p) { return $p }
    }

    $frameworkPath = "$env:SystemRoot\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
    if (Test-Path $frameworkPath) { return $frameworkPath }

    return $null
}

$MSBuild = Find-MSBuild
if (-not $MSBuild) {
    Write-Host "ERROR: MSBuild not found!" -ForegroundColor Red
    exit 1
}

Write-Host "Found MSBuild: $MSBuild" -ForegroundColor Green

# ========================================
# Build
# ========================================
Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Building LAS_TERRAIN Plugin" -ForegroundColor Cyan
Write-Host "Output: $OutputPath" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Each trusted release build gets fresh output and intermediate directories.
# The caller-selected output is used only for the final package.
$runRoot = Join-Path $outputRoot ('build-' + [Guid]::NewGuid().ToString('N'))
$buildOut = Join-Path $runRoot 'out'
$buildObj = Join-Path $runRoot 'obj'
New-Item -ItemType Directory -Path $buildOut,$buildObj -Force | Out-Null
$msbuildOut = $buildOut.Replace('\', '/') + '/'
$msbuildObj = $buildObj.Replace('\', '/') + '/'

# Build
$csproj = Join-Path $ProjectRoot "LAS_TERRAIN.csproj"
& $MSBuild $csproj /p:Configuration=Release /p:Diagnostic=false "/p:TopomaticPath=$sdkRoot" "/p:ReferencePath=$sdkRoot" "/p:OutputPath=$msbuildOut" "/p:BaseIntermediateOutputPath=$msbuildObj" "/p:IntermediateOutputPath=$msbuildObj" /p:PreBuildEvent= /v:minimal

if ($LASTEXITCODE -ne 0) {
    Write-Host "Build FAILED!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "Build SUCCESS!" -ForegroundColor Green

# ========================================
# Copy plugin file
# ========================================
Write-Host ""
Write-Host "Copying additional files..." -ForegroundColor Yellow

# Copy .plugin
$pluginFile = Join-Path $ProjectRoot "LAS_TERRAIN.plugin"
Copy-Item -LiteralPath $pluginFile -Destination (Join-Path $buildOut 'LAS_TERRAIN.plugin') -Force
Write-Host "  LAS_TERRAIN.plugin" -ForegroundColor Green
$builtDll = Join-Path $buildOut 'LAS_TERRAIN.dll'
$expectedDllHash = (Get-FileHash -LiteralPath $builtDll -Algorithm SHA256).Hash
Write-Host "  DLL SHA-256: $expectedDllHash" -ForegroundColor Green


# ========================================
# Create package
# ========================================

Write-Host ""
Write-Host "Creating package..." -ForegroundColor Yellow
& powershell.exe -NoProfile -ExecutionPolicy Bypass -File (Join-Path $PSScriptRoot 'package.ps1') -Version $Version -BuildPath $buildOut -OutputPath $outputRoot -ExpectedDllHash $expectedDllHash
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }

Write-Host ""
Write-Host "========================================" -ForegroundColor Green
Write-Host "DONE!" -ForegroundColor Green
Write-Host "Output folder: $OutputPath" -ForegroundColor Green
Write-Host "Verified build: $buildOut" -ForegroundColor Green
Write-Host "Package: $OutputPath\LAS_TERRAIN-$Version.tpm" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Green

# No recursive deletion of caller-selected output.

