$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$drawing = Join-Path $f2 'System.Drawing.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\CrsDrawThicknessCommand'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\CrsDrawThicknessCommandStubs.cs',
    'tests\Net35\CrsDrawThicknessCommandTests.cs',
    'Domain\Models\CrsPolygonEntry.cs',
    'Domain\Persistence\PolygonScope.cs',
    'Domain\Persistence\ScopedPolygonRecord.cs',
    'Domain\Service\CrsDrawLineContext.cs',
    'tests\Net35\PolygonTestOwnerContext.cs',
    'Infrastructure\BorrowedLidarSourceSnapshot.cs',
    'UseCases\CrsDrawLineUseCase.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'CrsDrawThicknessCommandTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" "/r:$drawing" $sources
if ($LASTEXITCODE -ne 0) { throw "CRS draw thickness command compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "CRS draw thickness command checks failed: $LASTEXITCODE" }
