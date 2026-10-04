$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$f35 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v3.5'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\FilterChainBaseline'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\FilterChainBaselineStubs.cs',
    'tests\Net35\FilterChainBaselineTests.cs',
    'tests\fixtures\FixtureData.cs',
    'Domain\Models\FilterOperationSnapshot.cs',
    'Domain\Models\PlanSurfaceSettings.cs',
    'Domain\Models\LasSectionPoints.cs',
    'Domain\Models\LasFilterOptions.cs',
    'Domain\Models\PointKey2D.cs',
    'Domain\Models\PointKey3D.cs',
    'Domain\Filters\FilterAggregator.cs',
    'Domain\Filters\OrderByX.cs',
    'Domain\Filters\GraphGroundFilter.cs',
    'Domain\Filters\GraphGroundDebugInfo.cs',
    'Domain\Filters\BreakDetector.cs',
    'Domain\Filters\SegmentBoundary.cs',
    'Domain\Filters\RobustGroundSplineFilter.cs',
    'Domain\Filters\MinWeightedGroundLevelMedianFilter.cs',
    'Domain\Filters\SplitAndMergeAlgorithm.cs',
    'Domain\Service\LasFilterService.cs',
    'Services\GroundPointsCollector.cs',
    'Infrastructure\RuntimeConfig.cs',
    'Infrastructure\FilterSettingsSnapshotAdapter.cs',
    'Infrastructure\ParallelWorkRunner.cs',
    'Application\OperationResult.cs',
    'Application\SectionRequest.cs',
    'Application\SectionWorkflow.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'FilterChainBaselineTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $sources
if ($LASTEXITCODE -ne 0) { throw "Filter chain baseline compile failed: $LASTEXITCODE" }
& $exe @args
if ($LASTEXITCODE -ne 0) { throw "Filter chain baseline failed: $LASTEXITCODE" }
