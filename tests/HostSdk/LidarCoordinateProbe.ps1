param(
    [Parameter(Mandatory = $true)][string]$HostCopyPath,
    [Parameter(Mandatory = $true)][string]$LdrPath
)

$ErrorActionPreference = 'Stop'
$hostRoot = (Resolve-Path -LiteralPath $HostCopyPath).Path
$ldr = (Resolve-Path -LiteralPath $LdrPath).Path
foreach ($installRoot in @($env:ProgramFiles, ${env:ProgramFiles(x86)})) {
    if ($installRoot -and
        ($hostRoot.Equals($installRoot.TrimEnd('\'), [StringComparison]::OrdinalIgnoreCase) -or
         $hostRoot.StartsWith($installRoot.TrimEnd('\') + '\', [StringComparison]::OrdinalIgnoreCase))) {
        throw 'Use a copied host directory. This probe writes an EXE beside the SDK DLLs.'
    }
}
if (-not $ldr.EndsWith('.ldr', [StringComparison]::OrdinalIgnoreCase)) {
    throw 'The input must be an existing LDR file.'
}

$compiler = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v3.5\csc.exe'
$framework = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$output = Join-Path $hostRoot 'LidarCoordinateProbe.exe'
$references = @(
    (Join-Path $framework 'mscorlib.dll'),
    (Join-Path $framework 'System.dll'),
    (Join-Path $hostRoot 'Topomatic.Lidar.dll'),
    (Join-Path $hostRoot 'Topomatic.Cad.Foundation.dll')
)
foreach ($reference in @($compiler) + $references) {
    if (-not (Test-Path -LiteralPath $reference)) { throw "Missing compiler/reference: $reference" }
}
$compileArgs = @('/nologo', '/noconfig', '/nostdlib+', '/target:exe', "/out:$output")
$compileArgs += $references | ForEach-Object { "/r:$_" }
$compileArgs += (Join-Path $PSScriptRoot 'LidarCoordinateProbe.cs')
$compileArgs += (Join-Path $PSScriptRoot '../../Infrastructure/LidarCacheHeader.cs')
& $compiler @compileArgs
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
& $output $ldr
exit $LASTEXITCODE
