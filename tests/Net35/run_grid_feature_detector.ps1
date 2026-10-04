$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\GridFeatureDetector'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\GridFeatureDetectorStubs.cs',
    'tests\Net35\GridFeatureDetectorTests.cs',
    'Domain\Service\GridCellIndex.cs',
    'Domain\Service\GridFeatureDetector.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'GridFeatureDetectorTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" $sources
if ($LASTEXITCODE -ne 0) { throw "Grid feature detector compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "Grid feature detector checks failed: $LASTEXITCODE" }
