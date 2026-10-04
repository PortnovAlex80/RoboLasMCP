param(
    [string]$Version = '1.0.0',
    [string]$BuildPath = 'D:\LAS_TERRAIN_BUILD',
    [string]$OutputPath = '',
    [string]$ExpectedDllHash = '',
    [string]$McpBuildPath = '',
    [switch]$NoIcons,
    [switch]$Help
)

if ($Help) {
    Write-Host 'Usage: .\build\package.ps1 [-Version 1.0.0] [-BuildPath <normal build folder>] [-OutputPath <package folder>]'
    exit 0
}

$ErrorActionPreference = 'Stop'
$projectRoot = (Resolve-Path -LiteralPath (Join-Path $PSScriptRoot '..')).Path
if ($Version -notmatch '^[0-9A-Za-z][0-9A-Za-z._-]*$') { throw 'Version contains unsupported filename characters.' }
if ($NoIcons) { throw 'A release package requires the manifest icons; -NoIcons is unsupported.' }
$buildRoot = (Resolve-Path -LiteralPath $BuildPath).Path
if ($buildRoot.Length -gt [System.IO.Path]::GetPathRoot($buildRoot).Length) {
    $buildRoot = $buildRoot.TrimEnd('\', '/')
}
if ([string]::IsNullOrWhiteSpace($OutputPath)) { $OutputPath = $buildRoot }
$outputRoot = [System.IO.Path]::GetFullPath($OutputPath)
if (-not (Test-Path -LiteralPath $outputRoot)) {
    New-Item -ItemType Directory -Path $outputRoot -Force | Out-Null
}

# Preflight occurs before any package staging or replacement. The verifier
# rejects a diagnostic IPC DLL and checks source/manifest/icon wiring.
$verifyArgs = @('-NoProfile', '-ExecutionPolicy', 'Bypass', '-File',
    (Join-Path $PSScriptRoot 'verify_release.ps1'), '-BuildPath', $buildRoot)
if ($ExpectedDllHash) { $verifyArgs += @('-ExpectedDllHash', $ExpectedDllHash) }
if ($McpBuildPath) { $verifyArgs += @('-McpBuildPath', $McpBuildPath) }
& powershell.exe @verifyArgs
if ($LASTEXITCODE -ne 0) { throw 'Release verification failed; package was not changed.' }

$dll = Join-Path $buildRoot 'LAS_TERRAIN.dll'
$pdb = Join-Path $buildRoot 'LAS_TERRAIN.pdb'
$manifest = Join-Path $buildRoot 'LAS_TERRAIN.plugin'
$icons = @(Get-ChildItem -LiteralPath (Join-Path $projectRoot 'RobolasIcons') -File -Recurse -Filter '*.png')
$stageRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '.package-stage'))
if (Test-Path -LiteralPath $stageRoot) {
    $stageRootItem = Get-Item -LiteralPath $stageRoot -Force
    if ($stageRootItem.Attributes -band [IO.FileAttributes]::ReparsePoint) {
        throw 'Package stage root is a reparse point; staging refused.'
    }
}
$stage = [System.IO.Path]::GetFullPath((Join-Path $stageRoot ([Guid]::NewGuid().ToString('N'))))
$stagePrefix = $stageRoot.TrimEnd('\', '/') + [System.IO.Path]::DirectorySeparatorChar
if (-not $stage.StartsWith($stagePrefix, [StringComparison]::OrdinalIgnoreCase)) {
    throw 'Unsafe package stage path.'
}
$target = Join-Path $outputRoot ('LAS_TERRAIN-' + $Version + '.tpm')
$temporaryPackage = Join-Path $outputRoot ('.LAS_TERRAIN-' + $Version + '-' + [Guid]::NewGuid().ToString('N') + '.tmp')
$replacementBackup = Join-Path $outputRoot ('.LAS_TERRAIN-' + $Version + '-' + [Guid]::NewGuid().ToString('N') + '.bak')
$published = $false
$publishAttempted = $false

try {
    New-Item -ItemType Directory -Path (Join-Path $stage 'bin') -Force | Out-Null
    New-Item -ItemType Directory -Path (Join-Path $stage 'plugins') -Force | Out-Null
    New-Item -ItemType Directory -Path (Join-Path $stage 'icons') -Force | Out-Null
    Copy-Item -LiteralPath $dll -Destination (Join-Path $stage 'bin\LAS_TERRAIN.dll')
    if (Test-Path -LiteralPath $pdb -PathType Leaf) {
        Copy-Item -LiteralPath $pdb -Destination (Join-Path $stage 'bin\LAS_TERRAIN.pdb')
    }
    Copy-Item -LiteralPath $manifest -Destination (Join-Path $stage 'plugins\LAS_TERRAIN.plugin')
    if ($McpBuildPath) {
        Copy-Item -LiteralPath (Join-Path $McpBuildPath 'LAS_TERRAIN.MCP.dll') -Destination (Join-Path $stage 'bin\LAS_TERRAIN.MCP.dll')
        Copy-Item -LiteralPath (Join-Path $McpBuildPath 'LAS_TERRAIN.MCP.plugin') -Destination (Join-Path $stage 'plugins\LAS_TERRAIN.MCP.plugin')
        if (Test-Path -LiteralPath (Join-Path $McpBuildPath 'Topomatic.ToolBridge.dll')) {
            foreach ($name in @('Topomatic.ToolBridge.dll','robur-mcp-LICENSE.txt')) {
                Copy-Item -LiteralPath (Join-Path $McpBuildPath $name) -Destination (Join-Path (Join-Path $stage 'bin') $name)
            }
            Copy-Item -LiteralPath (Join-Path $McpBuildPath 'tool_bridge.plugin') -Destination (Join-Path $stage 'plugins\tool_bridge.plugin')
            Copy-Item -LiteralPath (Join-Path $McpBuildPath 'mcp_server') -Destination (Join-Path $stage 'bin\mcp_server') -Recurse
        }
    }
    foreach ($icon in $icons) {
        Copy-Item -LiteralPath $icon.FullName -Destination (Join-Path $stage ('icons\' + $icon.Name))
    }
    $packageJson = @{
        name = 'LAS_TERRAIN'
        version = $Version
        caption = 'RoboLaserSection - LIDAR Terrain Processing'
        description = 'Plugin for processing LIDAR data (LAS format) for railway terrain modeling'
        author = 'Robolas'
    } | ConvertTo-Json -Depth 10
    [System.IO.File]::WriteAllText((Join-Path $stage 'package.json'), $packageJson,
        (New-Object System.Text.UTF8Encoding($false)))

    Add-Type -AssemblyName System.IO.Compression
    Add-Type -AssemblyName System.IO.Compression.FileSystem
    $archive = [System.IO.Compression.ZipFile]::Open($temporaryPackage,
        [System.IO.Compression.ZipArchiveMode]::Create)
    try {
        foreach ($file in @(Get-ChildItem -LiteralPath $stage -File -Recurse)) {
            $entryName = $file.FullName.Substring($stage.Length + 1).Replace('\', '/')
            [System.IO.Compression.ZipFileExtensions]::CreateEntryFromFile(
                $archive, $file.FullName, $entryName) | Out-Null
        }
    }
    finally { $archive.Dispose() }
    $stagedVerifyArgs = $verifyArgs + @('-PackagePath', $temporaryPackage)
    & powershell.exe @stagedVerifyArgs
    if ($LASTEXITCODE -ne 0) { throw 'Staged package did not pass release verification.' }
    if ($ExpectedDllHash -and
        (Get-FileHash -LiteralPath $dll -Algorithm SHA256).Hash -ne $ExpectedDllHash) {
        throw 'Build DLL changed after staged package verification.'
    }
    $publishAttempted = $true
    if (Test-Path -LiteralPath $target -PathType Leaf) {
        [System.IO.File]::Replace($temporaryPackage, $target, $replacementBackup)
    } else {
        [System.IO.File]::Move($temporaryPackage, $target)
    }
    $published = $true
    Write-Host "Package created: $target ($($icons.Count) icons)"
}
finally {
    # If publication returned an error, preserve temporary/backup files for
    # inspection: File.Replace can fail with an uncertain target state.
    if ($published -or -not $publishAttempted) {
        try {
            if (Test-Path -LiteralPath $temporaryPackage -PathType Leaf) {
                Remove-Item -LiteralPath $temporaryPackage -Force
            }
            if ($published -and (Test-Path -LiteralPath $replacementBackup -PathType Leaf)) {
                Remove-Item -LiteralPath $replacementBackup -Force
            }
        }
        catch { Write-Warning ("Package cleanup needs attention: " + $_.Exception.Message) }
    }
    # This is the only recursive cleanup target. It is a generated child of the
    # checked stage root inside this workspace, never caller-provided output.
    try {
        if ($stage.StartsWith($stagePrefix, [StringComparison]::OrdinalIgnoreCase) -and
            (Test-Path -LiteralPath $stage)) {
            $stageRootItem = Get-Item -LiteralPath $stageRoot -Force
            $stageItem = Get-Item -LiteralPath $stage -Force
            if (($stageRootItem.Attributes -band [IO.FileAttributes]::ReparsePoint) -or
                ($stageItem.Attributes -band [IO.FileAttributes]::ReparsePoint)) {
                throw 'Package stage is a reparse point; recursive cleanup refused.'
            }
            Remove-Item -LiteralPath $stage -Recurse -Force
        }
    }
    catch { Write-Warning ("Package stage cleanup needs attention: " + $_.Exception.Message) }
}
