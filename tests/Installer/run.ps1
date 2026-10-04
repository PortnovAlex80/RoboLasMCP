param(
    [Parameter(Mandatory = $true)][string]$PackagePath,
    [string]$WorkPath = ''
)

$ErrorActionPreference = 'Stop'
$package = (Resolve-Path -LiteralPath $PackagePath).Path
$msbuild = @(
    'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe',
    'C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe',
    'C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe',
    'C:\Program Files\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe'
) | Where-Object { Test-Path -LiteralPath $_ } | Select-Object -First 1
if (-not $msbuild) { throw 'Visual Studio 2022 MSBuild.exe is required.' }
$project = Join-Path $PSScriptRoot 'PackageInstallPlanTests.csproj'
& $msbuild $project /t:Build /p:Configuration=Release /v:minimal /nologo
if ($LASTEXITCODE -ne 0) { throw 'Installer test build failed.' }
if (-not $WorkPath) {
    $WorkPath = Join-Path $env:TEMP ('RoboLasInstallerTests-' + [Guid]::NewGuid().ToString('N'))
}
$work = [IO.Path]::GetFullPath($WorkPath)
$exe = Join-Path $PSScriptRoot 'bin\Release\PackageInstallPlanTests.exe'
& $exe $work $package
if ($LASTEXITCODE -ne 0) { throw 'Installer CLR 2 tests failed.' }

# Independent extraction parity: PowerShell's ZIP reader checks every byte
# written by the CLR 2 installer against the package's corresponding entry.
Add-Type -AssemblyName System.IO.Compression
Add-Type -AssemblyName System.IO.Compression.FileSystem
$zip = [IO.Compression.ZipFile]::OpenRead($package)
$count = 0
try {
    foreach ($entry in $zip.Entries) {
        $entryName = $entry.FullName.Replace('\', '/')
        if ($entryName -eq 'package.json') { continue }
        if ($entryName.StartsWith('files/', [StringComparison]::Ordinal)) {
            $relative = $entryName.Substring(6)
            $root = Join-Path $work 'release-appdata'
        } elseif ($entryName.StartsWith('icons/', [StringComparison]::Ordinal)) {
            $relative = $entryName
            $root = Join-Path $work 'release-host'
        } else {
            $relative = $entryName.Substring($entryName.IndexOf('/') + 1)
            $root = Join-Path $work 'release-host'
        }
        $destination = Join-Path $root ($relative.Replace('/', [IO.Path]::DirectorySeparatorChar))
        $stream = $entry.Open()
        $sha = [Security.Cryptography.SHA256]::Create()
        try { $expected = [Convert]::ToBase64String($sha.ComputeHash($stream)) }
        finally { $sha.Dispose(); $stream.Dispose() }
        $actual = [Convert]::ToBase64String(([Security.Cryptography.SHA256]::Create()).ComputeHash([IO.File]::ReadAllBytes($destination)))
        if ($actual -ne $expected) { throw "Package byte mismatch: $($entry.FullName)" }
        $count++
    }
}
finally { $zip.Dispose() }
if ($count -ne 76) { throw "Expected 76 release files, got $count" }
Write-Host "PASS independent ZIP parity: $count files; $work"
