$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { throw "Roslyn csc missing: $roslyn" }
$outdir = Join-Path $PSScriptRoot 'bin\LidarBufferService'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @(
    'Infrastructure\NativeLidarPointAdapter.cs',
    'tests\Net35\LidarBufferServiceStubs.cs',
    'tests\Net35\LidarBufferServiceTests.cs',
    'Services\LidarBufferService.cs'
) | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'LidarBufferServiceTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$f2\System.Windows.Forms.dll" "/r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll" $sources
if ($LASTEXITCODE -ne 0) { throw "LiDAR buffer service compile failed: $LASTEXITCODE" }
& $exe
if ($LASTEXITCODE -ne 0) { throw "LiDAR buffer service checks failed: $LASTEXITCODE" }
