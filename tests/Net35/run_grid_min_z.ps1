$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\GridMinZAccumulator'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\GridFeatureDetectorStubs.cs',
    'tests\Net35\GridMinZAccumulatorTests.cs',
    'Domain\Service\GridCellIndex.cs',
    'Domain\Service\GridMinZAccumulator.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'GridMinZAccumulatorTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" $sources
if ($LASTEXITCODE -ne 0) { throw "Grid min-Z compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "Grid min-Z checks failed: $LASTEXITCODE" }
