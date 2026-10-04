$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$drawing = Join-Path $f2 'System.Drawing.dll'
$serialization = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.0\System.Runtime.Serialization.dll'
$serviceWeb = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.ServiceModel.Web.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\PolygonFileCommands'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\PlanDrawCommandStubs.cs',
    'tests\Net35\PlanDrawCommandTests.cs',
    'tests\Net35\PolygonFileCommandTests.cs',
    'Domain\Models\PlanPolygonEntry.cs',
    'Domain\Persistence\PolygonScope.cs',
    'Domain\Persistence\ScopedPolygonRecord.cs',
    'Domain\Persistence\ScopedPolygonRepository.cs',
    'Domain\Persistence\PortablePolygonFile.cs',
    'Domain\Service\ScanlineFillPlanner.cs',
    'Domain\Service\CrsSectionAssociation.cs',
    'Domain\Service\CrsScopedSectionAssociation.cs',
    'Infrastructure\BorrowedLidarSourceSnapshot.cs',
    'Infrastructure\PolygonContextResolver.cs',
    'Infrastructure\ScopedPolygonOperationContext.cs',
    'Services\Layers\PlanOverlayLayer.cs',
    'UseCases\PlanDrawPolygonUseCase.cs',
    'UseCases\PolygonFileUseCase.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'PolygonFileCommandTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe /main:LAS_TERRAIN.Tests.PolygonFileCommandTests "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$f2\System.Xml.dll" "/r:$core" "/r:$drawing" "/r:$serialization" "/r:$serviceWeb" $sources
if ($LASTEXITCODE -ne 0) { throw "Polygon Save As command compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "Polygon Save As command checks failed: $LASTEXITCODE" }
