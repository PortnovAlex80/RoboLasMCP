param([string[]]$Sources=@())
$ErrorActionPreference='Stop'
$repo=(Resolve-Path (Join-Path $PSScriptRoot '../..')).Path
$out=Join-Path $repo 'build/.verification/rgb-roundtrip'
New-Item -ItemType Directory -Path $out -Force | Out-Null
$f2="$env:WINDIR\Microsoft.NET\Framework\v2.0.50727"
$f35="$env:WINDIR\Microsoft.NET\Framework\v3.5"
$core="${env:ProgramFiles(x86)}\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll"
if(!(Test-Path -LiteralPath $core)) { $core="$env:WINDIR\assembly\GAC_MSIL\System.Core\3.5.0.0__b77a5c561934e089\System.Core.dll" }
$compile=@('tests\Net35\CharacterizationStubs.cs','tests\Net35\LasRgbRoundtripTests.cs',
 'Infrastructure\LasColoredPoint.cs','Infrastructure\LasRgbSourceReader.cs',
 'Infrastructure\LasBatchStreamWriter.cs','Infrastructure\PreparedLasFile.cs')
$compile=@($compile | ForEach-Object { Join-Path $repo $_ })
& "$f35\csc.exe" /nologo /noconfig /nostdlib+ /target:exe "/out:$out/LasRgbRoundtripTests.exe" "/r:$f2/mscorlib.dll" "/r:$f2/System.dll" "/r:$core" $compile
if($LASTEXITCODE -ne 0) { throw 'RGB Net35 compilation failed' }
Push-Location $repo
try {
    & "$out/LasRgbRoundtripTests.exe" @Sources
    if($LASTEXITCODE -ne 0) { throw 'RGB tests failed' }
} finally { Pop-Location }
