$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$f2 = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$core = 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll'
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
$outdir = Join-Path $PSScriptRoot 'bin\SectionProbe'
New-Item -ItemType Directory -Force -Path $outdir | Out-Null
$sources = @('Domain\Service\SectionDensity.cs','Automation\LasAutomation.SectionProbe.cs','tests\Net35\SectionProbeTests.cs') | ForEach-Object { Join-Path $repo $_ }
$exe = Join-Path $outdir 'SectionProbeTests.exe'
& $roslyn /nologo /noconfig /nostdlib+ /langversion:latest /target:exe "/out:$exe" "/r:$f2\mscorlib.dll" "/r:$f2\System.dll" "/r:$core" $sources
if ($LASTEXITCODE -ne 0) { throw 'Section probe compilation failed' }
& $exe
if ($LASTEXITCODE -ne 0) { throw 'Section probe tests failed' }
