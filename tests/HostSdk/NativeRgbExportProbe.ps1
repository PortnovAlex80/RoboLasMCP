param([string]$HostCopyPath='D:/Development/Robolas/host-test/Rail16')
$ErrorActionPreference='Stop'
$repo=(Resolve-Path (Join-Path $PSScriptRoot '../..')).Path
$hostRoot=(Resolve-Path -LiteralPath $HostCopyPath).Path
$f2="$env:WINDIR/Microsoft.NET/Framework/v2.0.50727"
$f35="$env:WINDIR/Microsoft.NET/Framework/v3.5"
$core="${env:ProgramFiles(x86)}/Reference Assemblies/Microsoft/Framework/v3.5/System.Core.dll"
$base=@('tests/HostSdk/NativeRgbExportProbe.cs','Infrastructure/LasColoredPoint.cs','Infrastructure/LasRgbSourceReader.cs',
 'Infrastructure/RgbExportSession.cs','Infrastructure/LidarIntensity.cs','Infrastructure/BorrowedLidarSourceSnapshot.cs','Infrastructure/ColoredPointSpool.cs','Infrastructure/RgbExternalSort.cs',
 'Infrastructure/ColorAwareLasWriter.cs','Infrastructure/LasBatchStreamWriter.cs','Infrastructure/PreparedLasFile.cs',
 'Services/SamplingHelper.cs','Domain/Models/GraphGround3DOptions.cs','Domain/Filters/GraphGround3DFilter.cs') | ForEach-Object {Join-Path $repo $_}
$refs=@("/r:$f2/mscorlib.dll","/r:$f2/System.dll","/r:$f2/System.Drawing.dll","/r:$core","/r:$hostRoot/Topomatic.Cad.Foundation.dll","/r:$hostRoot/Topomatic.Stg.dll")
foreach($mode in @('SuppliedSource','LegacySdk')) {
 $output=Join-Path $hostRoot ("NativeRgbExportProbe-$mode.exe")
 if($mode -eq 'SuppliedSource') {
  $compile=$base+@((Join-Path $repo 'LidarBuffer.cs'),(Join-Path $repo 'tests/HostSdk/NativeRgbSourceStubs.cs'))
  & "$f35/csc.exe" /nologo /unsafe /noconfig /nostdlib+ /target:exe "/out:$output" $refs $compile
 } else {
  & "$f35/csc.exe" /nologo /noconfig /nostdlib+ /define:REAL_SDK /target:exe "/out:$output" $refs "/r:$hostRoot/Topomatic.Lidar.dll" $base
 }
 if($LASTEXITCODE -ne 0){throw "$mode RGB probe compilation failed"}
 & $output (Join-Path $repo "build/.verification/native-rgb-$mode")
 if($LASTEXITCODE -ne 0){throw "$mode RGB probe failed"}
}
