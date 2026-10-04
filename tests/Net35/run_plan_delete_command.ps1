$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\PlanDeleteCommand'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\RgbExportNonColorStubs.cs',
    'tests\Net35\CrsDeleteCommandStubs.cs',
    'tests\Net35\CrsDeleteCommandTests.cs',
    'tests\Net35\PlanDeleteCommandTests.cs',
    'Domain\Models\CrsPolygonEntry.cs',
    'Domain\Models\PlanPolygonEntry.cs',
    'Domain\Persistence\PolygonScope.cs',
    'Domain\Persistence\ScopedPolygonRecord.cs',
    'Domain\Service\CrsSectionAssociation.cs',
    'Domain\Service\CrsScopedSectionAssociation.cs',
    'UseCases\PlanPolygonScanState.cs',
    'Infrastructure\ParallelWorkRunner.cs',
    'tests\Net35\PolygonTestOwnerContext.cs',
    'Infrastructure\BorrowedLidarSourceSnapshot.cs',
    'UseCases\CrsDeletePointsUseCase.cs',
    'UseCases\PlanDeletePointsUseCase.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'PlanDeleteCommandTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest '/define:PLAN_DELETE_TESTS;DELETE_RGB_STUBS' /target:exe /main:LAS_TERRAIN.Tests.PlanDeleteCommandTests "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $sources
if ($LASTEXITCODE -ne 0) { throw "Plan delete command compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "Plan delete command checks failed: $LASTEXITCODE" }
$realExe = Join-Path $outdir 'PlanDeleteRealLasTests.exe'
$realSources = $sources + @(
    (Join-Path $repo 'tests\Net35\PlanDeleteRealLasTests.cs'),
    (Join-Path $repo 'Infrastructure\PreparedLasFile.cs'),
    (Join-Path $repo 'Infrastructure\LasBatchStreamWriter.cs'),
    (Join-Path $repo 'Infrastructure\LasColoredPoint.cs')
)
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest '/define:PLAN_DELETE_TESTS;REAL_LAS_WRITER;DELETE_RGB_STUBS' /target:exe /main:LAS_TERRAIN.Tests.PlanDeleteRealLasTests "/out:$realExe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $realSources
if ($LASTEXITCODE -ne 0) { throw "Plan real LAS integration compile failed: $LASTEXITCODE" }
& $realExe
if ($LASTEXITCODE -ne 0) { throw "Plan real LAS integration checks failed: $LASTEXITCODE" }
