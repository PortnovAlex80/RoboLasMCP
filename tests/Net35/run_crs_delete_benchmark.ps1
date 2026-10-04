param([string]$CommandSource = '')
$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
if (-not $CommandSource) {
    $CommandSource = Join-Path $repo 'UseCases\CrsDeletePointsUseCase.cs'
}
$CommandSource = (Resolve-Path -LiteralPath $CommandSource).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
$outdir = Join-Path $PSScriptRoot 'bin\CrsDeleteBenchmark'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$exe = Join-Path $outdir 'CrsDeleteBenchmark.exe'
$sources = @(
    (Join-Path $repo 'tests\Net35\CrsDeleteCommandStubs.cs'),
    (Join-Path $repo 'tests\Net35\CrsDeleteCommandTests.cs'),
    (Join-Path $repo 'tests\Net35\CrsDeleteBenchmark.cs'),
    (Join-Path $repo 'Domain\Models\CrsPolygonEntry.cs'),
    (Join-Path $repo 'Domain\Service\CrsSectionAssociation.cs'),
    $CommandSource
)
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe /main:LAS_TERRAIN.Tests.CrsDeleteBenchmark "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $sources
if ($LASTEXITCODE -ne 0) { throw "CRS benchmark compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "CRS benchmark failed: $LASTEXITCODE" }
