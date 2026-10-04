$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$f35 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v3.5\csc.exe'
if (-not (Test-Path -LiteralPath $f35)) { throw "NET 3.5 csc missing: $f35" }
$outdir = Join-Path $PSScriptRoot 'bin\PolygonContextResolver'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'tests\Net35\PolygonContextResolverStubs.cs',
    'tests\Net35\PolygonContextResolverTests.cs',
    'Domain\Persistence\PolygonScope.cs',
    'Infrastructure\PolygonContextResolver.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'PolygonContextResolverTests.exe'
& $f35 /nologo /noconfig /nostdlib+ /langversion:default /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" $sources
if ($LASTEXITCODE -ne 0) { throw "Polygon context compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "Polygon context checks failed: $LASTEXITCODE" }
