$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
$outdir = Join-Path $PSScriptRoot 'bin\SectionDensity'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @('Domain\Service\SectionDensity.cs','Infrastructure\NativeLidarPointAdapter.cs','tests\Net35\SectionDensityTests.cs') | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'SectionDensityTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $sources
if ($LASTEXITCODE -ne 0) { throw 'Section density compilation failed' }
& $exe
if ($LASTEXITCODE -ne 0) { throw 'Section density tests failed' }
