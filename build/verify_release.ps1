param(
    [Parameter(Mandatory = $true)][string]$BuildPath,
    [string]$PackagePath = '',
    [string]$ExpectedDllHash = '',
    [string]$InstallerPath = '',
    [string]$McpBuildPath = '',
    [switch]$Diagnostic
)

$ErrorActionPreference = 'Stop'
$projectRoot = (Resolve-Path -LiteralPath (Join-Path $PSScriptRoot '..')).Path

function Require([bool]$condition, [string]$message) {
    if (-not $condition) { throw $message }
}

function Sha256([byte[]]$bytes) {
    $hash = [System.Security.Cryptography.SHA256]::Create()
    try { return [Convert]::ToBase64String($hash.ComputeHash($bytes)) }
    finally { $hash.Dispose() }
}

function ZipBytes($archive, [string]$entryName) {
    $entry = $archive.GetEntry($entryName)
    Require ($null -ne $entry) "Package is missing $entryName"
    $stream = $entry.Open()
    $memory = New-Object System.IO.MemoryStream
    try { $stream.CopyTo($memory); return $memory.ToArray() }
    finally { $stream.Dispose(); $memory.Dispose() }
}

try {
    $managedProjects = @(Get-ChildItem -LiteralPath $projectRoot -Recurse -File -Filter '*.csproj' |
        Where-Object { $_.FullName -notmatch '[\\/]obj[\\/]' })
    Require ($managedProjects.Count -gt 0) 'No managed projects found'
    foreach ($managedProject in $managedProjects) {
        [xml]$managedXml = Get-Content -LiteralPath $managedProject.FullName -Raw
        $versions = @($managedXml.SelectNodes('//*[local-name()="TargetFrameworkVersion"]'))
        $modernTargets = @($managedXml.SelectNodes('//*[local-name()="TargetFramework" or local-name()="TargetFrameworks"]'))
        $mcpProject = Join-Path $projectRoot 'Mcp\LasTerrain.Mcp.csproj'
        $expectedFramework = if ($managedProject.FullName -eq $mcpProject) { 'v4.8' } else { 'v3.5' }
        Require ($versions.Count -eq 1 -and $versions[0].InnerText -eq $expectedFramework -and $modernTargets.Count -eq 0) `
            "Managed project must target $expectedFramework : $($managedProject.FullName)"
    }

    $buildRoot = (Resolve-Path -LiteralPath $BuildPath).Path
    $dll = Join-Path $buildRoot 'LAS_TERRAIN.dll'
    $manifest = Join-Path $buildRoot 'LAS_TERRAIN.plugin'
    Require (Test-Path -LiteralPath $dll -PathType Leaf) "Missing build DLL: $dll"
    Require (Test-Path -LiteralPath $manifest -PathType Leaf) "Missing build manifest: $manifest"
    $dllHash = (Get-FileHash -LiteralPath $dll -Algorithm SHA256).Hash
    if ($ExpectedDllHash) {
        Require ($ExpectedDllHash -match '^[0-9a-fA-F]{64}$') 'ExpectedDllHash must be a SHA-256 hex digest'
        Require ($dllHash -eq $ExpectedDllHash) 'Build DLL differs from the hash captured after MSBuild'
    }

    [xml]$project = Get-Content -LiteralPath (Join-Path $projectRoot 'LAS_TERRAIN.csproj') -Raw
    $frameworkTarget = $project.SelectSingleNode('//*[local-name()="TargetFrameworkVersion"]')
    Require ($null -ne $frameworkTarget -and $frameworkTarget.InnerText -eq 'v3.5') `
        'Plugin project must target .NET Framework 3.5'
    $compile = @($project.SelectNodes('//*[local-name()="Compile"]'))
    Require ($compile.Count -gt 0) 'No explicit Compile Include entries found'
    foreach ($item in $compile) {
        $source = Join-Path $projectRoot $item.Include
        Require (Test-Path -LiteralPath $source -PathType Leaf) "Missing Compile Include: $($item.Include)"
    }
    $ipc = @($compile | Where-Object { $_.Include -like 'Testing\Remoting\*' })
    $expectedIpc = @(
        'Testing\Remoting\LasTerrainTestService.cs',
        'Testing\Remoting\DiagnosticUiDispatcher.cs',
        'Testing\Remoting\IpcTestServer.cs'
    )
    Require ($ipc.Count -eq $expectedIpc.Count) "Expected $($expectedIpc.Count) diagnostic IPC Compile Include items; found $($ipc.Count)"
    foreach ($item in $ipc) {
        Require ($expectedIpc -contains $item.Include) "Unexpected diagnostic IPC item: $($item.Include)"
        Require ($item.Condition -eq "'`$(Diagnostic)' == 'true'") "IPC item is not diagnostic-only: $($item.Include)"
    }
    $conditional = @($compile | Where-Object { $_.Condition })
    Require ($conditional.Count -eq $ipc.Count) 'Unexpected conditional Compile Include item'
    $activeCompile = if ($Diagnostic) { $compile } else {
        @($compile | Where-Object { -not $_.Condition })
    }
    $dllWriteTime = (Get-Item -LiteralPath $dll).LastWriteTimeUtc
    $buildInputs = @((Join-Path $projectRoot 'LAS_TERRAIN.csproj')) +
        @($activeCompile | ForEach-Object { Join-Path $projectRoot $_.Include })
    foreach ($input in $buildInputs) {
        Require ((Get-Item -LiteralPath $input).LastWriteTimeUtc -le $dllWriteTime) "Build is older than input: $input"
    }
    Require ($project.SelectNodes('//*[local-name()="PreBuildEvent"]').Count -eq 0) 'PreBuildEvent is present'

    $manifestSource = Join-Path $projectRoot 'LAS_TERRAIN.plugin'
    Require ((Get-FileHash -LiteralPath $manifest -Algorithm SHA256).Hash -eq
        (Get-FileHash -LiteralPath $manifestSource -Algorithm SHA256).Hash) 'Build manifest differs from source manifest'
    $plugin = Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json
    Require ($plugin.assemblies.LAS_TERRAIN.assembly -eq 'LAS_TERRAIN.dll, LAS_TERRAIN.LasTerrainPluginHost') 'Plugin host entry changed'
    $moduleText = Get-Content -LiteralPath (Join-Path $projectRoot 'Module.cs') -Raw
    $iconFiles = @(Get-ChildItem -LiteralPath (Join-Path $projectRoot 'RobolasIcons') -File -Recurse -Filter '*.png')
    $iconNames = @($iconFiles | ForEach-Object Name)
    Require ($iconFiles.Count -gt 0) 'No source icons found'
    Require (($iconNames | Group-Object | Where-Object Count -gt 1).Count -eq 0) 'Flattened icon filenames collide'
    foreach ($action in $plugin.actions.PSObject.Properties) {
        $command = [string]$action.Value.cmd
        Require ($moduleText.Contains('[cmd("' + $command + '")]')) "Manifest command lacks Module entry: $command"
        if ($action.Value.icon) {
            $iconFile = [string]$action.Value.icon + '_16dp_1x.png'
            Require ($iconNames -contains $iconFile) "Manifest icon lacks source PNG: $($action.Value.icon)"
        }
    }

    $name = [System.Reflection.AssemblyName]::GetAssemblyName($dll)
    Require ($name.Name -eq 'LAS_TERRAIN') 'Unexpected assembly name'

    $assembly = [System.Reflection.Assembly]::ReflectionOnlyLoadFrom($dll)
    Require ($assembly.ImageRuntimeVersion -eq 'v2.0.50727') `
        "Plugin DLL targets an unexpected CLR: $($assembly.ImageRuntimeVersion)"
    foreach ($reference in $assembly.GetReferencedAssemblies()) {
        $frameworkReference = $reference.Name -eq 'mscorlib' -or
            $reference.Name -eq 'System' -or
            $reference.Name.StartsWith('System.', [StringComparison]::Ordinal)
        if ($frameworkReference) {
            Require ($reference.Version.Major -lt 3 -or
                ($reference.Version.Major -eq 3 -and $reference.Version.Minor -le 5)) `
                "Framework reference exceeds .NET 3.5: $($reference.FullName)"
        } else {
            Require ($reference.Name.StartsWith('Topomatic.', [StringComparison]::Ordinal)) `
                "Unreviewed plugin dependency: $($reference.FullName)"
        }
    }
    # Metadata names are ASCII in the CLR string heap. Avoid resolving live
    # Topomatic types just to inspect a candidate package outside the host.
    $metadata = [Text.Encoding]::ASCII.GetString([System.IO.File]::ReadAllBytes($dll))
    Require ($metadata.Contains('LasTerrainPluginHost')) 'Plugin host type name is missing'
    $hasIpcType = $metadata.Contains('IpcTestServer') -and $metadata.Contains('LasTerrainTestService')
    $remotingRef = @($assembly.GetReferencedAssemblies() | Where-Object Name -eq 'System.Runtime.Remoting')
    if ($Diagnostic) {
        Require ($hasIpcType -and $remotingRef.Count -gt 0) 'Diagnostic IPC was not compiled in'
    } else {
        Require (-not $hasIpcType -and $remotingRef.Count -eq 0) 'Diagnostic IPC is present in release DLL'
    }

    $mcpFiles = @{}
    if ($McpBuildPath) {
        $mcpRoot = (Resolve-Path -LiteralPath $McpBuildPath).Path
        $mcpDll = Join-Path $mcpRoot 'LAS_TERRAIN.MCP.dll'
        $mcpManifest = Join-Path $mcpRoot 'LAS_TERRAIN.MCP.plugin'
        Require (Test-Path -LiteralPath $mcpDll -PathType Leaf) 'Missing MCP extension DLL'
        Require (Test-Path -LiteralPath $mcpManifest -PathType Leaf) 'Missing MCP extension manifest'
        $mcpName = [Reflection.AssemblyName]::GetAssemblyName($mcpDll)
        Require ($mcpName.Name -eq 'LAS_TERRAIN.MCP') 'Unexpected MCP assembly identity'
        $mcpAssembly = [Reflection.Assembly]::ReflectionOnlyLoadFrom($mcpDll)
        Require ($mcpAssembly.ImageRuntimeVersion -eq 'v4.0.30319') 'MCP extension must target CLR4'
        $nativePath = Join-Path $mcpRoot 'Topomatic.ToolBridge.dll'
        $nativeReferences = @{}
        if (Test-Path -LiteralPath $nativePath) {
            $nativeName = [Reflection.AssemblyName]::GetAssemblyName($nativePath)
            Require ($nativeName.FullName -eq 'Topomatic.ToolBridge, Version=0.1.0.0, Culture=neutral, PublicKeyToken=0af0f61cef2ab3a8') 'Unexpected native bridge identity'
            foreach ($reference in ([Reflection.Assembly]::ReflectionOnlyLoadFrom($nativePath)).GetReferencedAssemblies()) {
                $nativeReferences[$reference.Name] = $reference.FullName
            }
            foreach ($fileName in @('Topomatic.ToolBridge.dll','tool_bridge.plugin','robur-mcp-LICENSE.txt')) {
                $filePath = Join-Path $mcpRoot $fileName
                Require (Test-Path -LiteralPath $filePath -PathType Leaf) "Missing native MCP payload: $fileName"
                $entry = if ($fileName -like '*.plugin') { 'plugins/' + $fileName } else { 'bin/' + $fileName }
                $mcpFiles[$entry] = $filePath
            }
            $serverRoot = Join-Path $mcpRoot 'mcp_server'
            Require (Test-Path -LiteralPath (Join-Path $serverRoot 'robur_mcp_server.exe')) 'Missing native HTTP server executable'
            foreach ($file in Get-ChildItem -LiteralPath $serverRoot -Recurse -File) {
                $relative = $file.FullName.Substring($serverRoot.Length).TrimStart('\').Replace('\','/')
                $mcpFiles['bin/mcp_server/' + $relative] = $file.FullName
            }
        }
        foreach ($reference in $mcpAssembly.GetReferencedAssemblies()) {
            if ($reference.Name -like 'Topomatic.*' -and $reference.Name -ne 'Topomatic.ToolBridge') {
                if ($nativeReferences.Count) {
                    Require ($nativeReferences[$reference.Name] -eq $reference.FullName) "MCP/native SDK identity mismatch: $($reference.Name)"
                } else {
                    Require ($reference.Version -ge [Version]'16.0.62.12') 'Older SDK requires a verified compatible native bridge payload'
                }
            }
            if ($reference.Name -eq 'Newtonsoft.Json') {
                if ($nativeReferences.Count) {
                    Require ($nativeReferences[$reference.Name] -eq $reference.FullName) 'MCP/native Newtonsoft.Json identity mismatch'
                } else {
                    Require ($reference.Version.Major -ge 13) 'MCP packaging requires the original native bridge Newtonsoft.Json 13 dependency'
                }
            }
            if ($reference.Name -eq 'LAS_TERRAIN') {
                Require ($reference.FullName -eq $name.FullName) 'MCP extension references a different core identity'
            }
        }
        Require ((Get-FileHash -LiteralPath $mcpManifest).Hash -eq
            (Get-FileHash -LiteralPath (Join-Path $projectRoot 'Mcp/LAS_TERRAIN.MCP.plugin')).Hash) 'MCP manifest differs from source'
        [xml]$mcpXml = Get-Content -LiteralPath (Join-Path $projectRoot 'Mcp/LasTerrain.Mcp.csproj') -Raw
        foreach ($source in $mcpXml.SelectNodes('//*[local-name()="Compile"]')) {
            $sourcePath = Join-Path (Join-Path $projectRoot 'Mcp') $source.Include
            Require ((Get-Item -LiteralPath $sourcePath).LastWriteTimeUtc -le (Get-Item -LiteralPath $mcpDll).LastWriteTimeUtc) 'MCP build is older than its source'
        }
        $mcpFiles['bin/LAS_TERRAIN.MCP.dll']=$mcpDll
        $mcpFiles['plugins/LAS_TERRAIN.MCP.plugin']=$mcpManifest
    }

    if ($PackagePath) {
        Require (-not $Diagnostic) 'Diagnostic DLL must not be accepted as a release package'
        Add-Type -AssemblyName System.IO.Compression.FileSystem
        $package = (Resolve-Path -LiteralPath $PackagePath).Path
        $zip = [System.IO.Compression.ZipFile]::OpenRead($package)
        try {
            $entryNames = @($zip.Entries | ForEach-Object FullName)
            $allowed = @('package.json', 'bin/LAS_TERRAIN.dll', 'plugins/LAS_TERRAIN.plugin') +
                @($iconNames | ForEach-Object { 'icons/' + $_ })
            $pdb = Join-Path $buildRoot 'LAS_TERRAIN.pdb'
            if (Test-Path -LiteralPath $pdb -PathType Leaf) { $allowed += 'bin/LAS_TERRAIN.pdb' }
            $allowed += @($mcpFiles.Keys)
            Require ($entryNames.Count -eq $allowed.Count) 'Package entry count differs from the canonical layout'
            Require (($entryNames | Group-Object | Where-Object Count -gt 1).Count -eq 0) 'Duplicate package entries'
            foreach ($entryName in $entryNames) {
                Require ($allowed -ccontains $entryName) "Unexpected or noncanonical package path: $entryName"
            }
            Require ((Sha256 (ZipBytes $zip 'bin/LAS_TERRAIN.dll')) -eq
                (Sha256 ([System.IO.File]::ReadAllBytes($dll)))) 'Packaged DLL differs from verified build'
            Require ((Sha256 (ZipBytes $zip 'plugins/LAS_TERRAIN.plugin')) -eq
                (Sha256 ([System.IO.File]::ReadAllBytes($manifest)))) 'Packaged manifest differs from verified build'
            if (Test-Path -LiteralPath $pdb -PathType Leaf) {
                Require ((Sha256 (ZipBytes $zip 'bin/LAS_TERRAIN.pdb')) -eq
                    (Sha256 ([System.IO.File]::ReadAllBytes($pdb)))) 'Packaged PDB differs from verified build'
            }
            $packageInfo = [Text.Encoding]::UTF8.GetString((ZipBytes $zip 'package.json')) | ConvertFrom-Json
            Require ($packageInfo.name -eq 'LAS_TERRAIN' -and -not [string]::IsNullOrWhiteSpace($packageInfo.version)) 'Invalid package metadata'
            foreach ($icon in $iconNames) {
                Require ($entryNames -contains ('icons/' + $icon)) "Packaged icon is missing: $icon"
            }
            foreach ($entryName in $mcpFiles.Keys) {
                Require ((Sha256 (ZipBytes $zip $entryName)) -eq
                    (Sha256 ([IO.File]::ReadAllBytes($mcpFiles[$entryName])))) 'Packaged MCP payload differs from verified build'
            }
            Require (@($entryNames | Where-Object { $_ -like 'icons/*.png' }).Count -eq $iconFiles.Count) 'Packaged icon count differs from source'
        }
        finally { $zip.Dispose() }
    }

    if ($InstallerPath) {
        $installerExe = (Resolve-Path -LiteralPath $InstallerPath).Path
        $installerAssembly = [System.Reflection.Assembly]::ReflectionOnlyLoadFrom($installerExe)
        Require ($installerAssembly.ImageRuntimeVersion -eq 'v2.0.50727') `
            "Installer EXE targets an unexpected CLR: $($installerAssembly.ImageRuntimeVersion)"
        foreach ($reference in $installerAssembly.GetReferencedAssemblies()) {
            if ($reference.Name -eq 'mscorlib' -or $reference.Name -like 'System*') {
                Require ($reference.Version.Major -le 3) `
                    "Installer references a newer framework assembly: $($reference.FullName)"
            }
        }
    }

    Write-Host "PASS $(if ($Diagnostic) { 'diagnostic' } else { 'normal' }) build: $dll"
    Write-Host "  framework: .NET 3.5; CLR: $($assembly.ImageRuntimeVersion)"
    Write-Host "  compile items: $($compile.Count); icons: $($iconFiles.Count); IPC present: $hasIpcType"
    Write-Host "  managed projects verified: $($managedProjects.Count); only MCP extension may target .NET 4.8"
    if ($InstallerPath) { Write-Host "PASS installer CLR2: $installerExe" }
    if ($PackagePath) { Write-Host "PASS package: $PackagePath" }
    exit 0
}
catch {
    Write-Error ("RELEASE VERIFICATION FAILED: " + $_.Exception.Message)
    exit 1
}
