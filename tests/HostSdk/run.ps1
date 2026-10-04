param(
    [Parameter(Mandatory = $true)][string]$HostCopyPath
)

$ErrorActionPreference = 'Stop'
$projectRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$hostRoot = (Resolve-Path -LiteralPath $HostCopyPath).Path
if ($hostRoot.StartsWith('C:\Program Files\', [StringComparison]::OrdinalIgnoreCase)) {
    throw 'Use a copied host directory. This probe writes an EXE beside the SDK DLLs.'
}

$compiler = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v3.5\csc.exe'
$framework = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$output = Join-Path $hostRoot 'SurfaceProbe.exe'
if (-not (Test-Path -LiteralPath $compiler)) { throw '.NET 3.5 compiler not found.' }

$references = @(
    (Join-Path $framework 'mscorlib.dll'),
    (Join-Path $framework 'System.dll'),
    (Join-Path $hostRoot 'Topomatic.Sfc.dll'),
    (Join-Path $hostRoot 'Topomatic.Cad.Foundation.dll'),
    (Join-Path $hostRoot 'Topomatic.FoundationClasses.dll'),
    (Join-Path $hostRoot 'Topomatic.Dwg.dll'),
    (Join-Path $hostRoot 'Topomatic.Stg.dll')
)
foreach ($reference in $references) {
    if (-not (Test-Path -LiteralPath $reference)) { throw "Missing reference: $reference" }
}
$args = @('/nologo', '/noconfig', '/nostdlib+', '/target:exe', "/out:$output")
$args += $references | ForEach-Object { "/r:$_" }
$args += @(
    (Join-Path $PSScriptRoot 'SurfaceProbe.cs'),
    (Join-Path $projectRoot 'Domain\Service\FastSurfaceBuilder.cs'),
    (Join-Path $projectRoot 'Infrastructure\MemoryStatus.cs')
)
& $compiler @args
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
& $output
exit $LASTEXITCODE
