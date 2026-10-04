$ErrorActionPreference='Stop'
$repo=(Resolve-Path (Join-Path $PSScriptRoot '../..')).Path
$out=Join-Path $repo 'build/.verification/tree-cache'
New-Item -ItemType Directory -Path $out -Force | Out-Null
$f2="$env:WINDIR\Microsoft.NET\Framework\v2.0.50727"
$f35="$env:WINDIR\Microsoft.NET\Framework\v3.5"
& "$f35/csc.exe" /nologo /noconfig /nostdlib+ /target:exe "/out:$out/LidarCacheHeaderTests.exe" "/r:$f2/mscorlib.dll" "/r:$f2/System.dll" (Join-Path $repo 'Infrastructure/LidarCacheHeader.cs') (Join-Path $PSScriptRoot 'LidarCacheHeaderTests.cs')
if($LASTEXITCODE -ne 0) { throw 'Tree header test compilation failed' }
& "$out/LidarCacheHeaderTests.exe"
if($LASTEXITCODE -ne 0) { throw 'Tree header tests failed' }
