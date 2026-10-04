$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\StationOnePass'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'Infrastructure\NativeLidarPointAdapter.cs',
    'tests\Net35\CollectionStatusStubs.cs',
    'tests\Net35\StationOnePassTests.cs',
    'Domain\Models\LasSectionPoints.cs',
    'Domain\Models\LasFilterOptions.cs',
    'Domain\Models\PointKey3D.cs',
    'Domain\Service\LasSectionPointsCollectorService.cs',
    'Services\GroundPointsCollector.OnePass.cs',
    'Infrastructure\ParallelWorkRunner.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'StationOnePassTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $sources
if ($LASTEXITCODE -ne 0) { throw "OnePass station parity compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "OnePass station parity failed: $LASTEXITCODE" }
