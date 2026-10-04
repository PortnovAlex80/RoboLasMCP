param(
    [string]$HostCopyPath = 'D:\Development\Robolas\host-test\Rail16'
)

$ErrorActionPreference = 'Stop'
$hostRoot = (Resolve-Path -LiteralPath $HostCopyPath).Path
if ($hostRoot.StartsWith('C:\Program Files\', [StringComparison]::OrdinalIgnoreCase) -or
    $hostRoot.StartsWith('D:\Program Files\', [StringComparison]::OrdinalIgnoreCase)) {
    throw 'Use a copied Rail16 directory, not the installed host.'
}
$compiler = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v3.5\csc.exe'
$framework = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
if (-not (Test-Path -LiteralPath $compiler)) { throw '.NET 3.5 compiler not found.' }

$output = Join-Path $env:TEMP ('ProjectIdentityProbe-' + [Guid]::NewGuid().ToString('N') + '.exe')
try {
    & $compiler /nologo /noconfig /nostdlib+ /target:exe "/out:$output" "/r:$(Join-Path $framework 'mscorlib.dll')" "/r:$(Join-Path $framework 'System.dll')" (Join-Path $PSScriptRoot 'ProjectIdentityProbe.cs')
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
    & $output $hostRoot
    exit $LASTEXITCODE
}
finally {
    if (Test-Path -LiteralPath $output) { Remove-Item -LiteralPath $output -Force }
}
