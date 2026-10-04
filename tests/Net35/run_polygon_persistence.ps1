$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\PolygonPersistenceFocused'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\Stubs.cs',
    'tests\Net35\PolygonPersistenceTests.cs',
    'Domain\Models\PlanPolygonEntry.cs',
    'Domain\Models\CrsPolygonEntry.cs',
    'Domain\Service\PlanPolygonCollection.cs',
    'Domain\Service\CrsPolygonCollection.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'PolygonPersistenceTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/main:LAS_TERRAIN.Tests.PolygonPersistenceTests" "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $sources
if ($LASTEXITCODE -ne 0) { throw "Polygon persistence compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "Polygon persistence checks failed: $LASTEXITCODE" }
