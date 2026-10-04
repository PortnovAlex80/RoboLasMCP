param([string]$HostCopyPath = 'D:\Development\Robolas\host-test\Rail16')

$ErrorActionPreference = 'Stop'
$hostRoot = (Resolve-Path -LiteralPath $HostCopyPath).Path
if ($hostRoot.StartsWith('C:\Program Files\', [StringComparison]::OrdinalIgnoreCase) -or
    $hostRoot.StartsWith('D:\Program Files\', [StringComparison]::OrdinalIgnoreCase)) {
    throw 'Use a copied Rail16 directory, not the installed host.'
}
$compiler = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v3.5\csc.exe'
$framework = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v2.0.50727'
$output = Join-Path $env:TEMP ('TopomaticParallelProbe-' + [Guid]::NewGuid().ToString('N') + '.exe')
try {
    & $compiler /nologo /noconfig /nostdlib+ /target:exe "/out:$output" "/r:$(Join-Path $framework 'mscorlib.dll')" "/r:$(Join-Path $framework 'System.dll')" (Join-Path $PSScriptRoot 'TopomaticParallelProbe.cs')
    if ($LASTEXITCODE -ne 0) { throw "Probe compile failed: $LASTEXITCODE" }
    $process = New-Object System.Diagnostics.Process
    $process.StartInfo.FileName = $output
    $process.StartInfo.Arguments = '"' + $hostRoot + '"'
    $process.StartInfo.UseShellExecute = $false
    $process.StartInfo.CreateNoWindow = $true
    $process.StartInfo.RedirectStandardOutput = $true
    $process.StartInfo.RedirectStandardError = $true
    [void]$process.Start()
    if (-not $process.WaitForExit(15000)) {
        $process.Kill()
        $process.WaitForExit()
        throw 'Copied SDK nested parallel probe exceeded 15 seconds.'
    }
    $standardOutput = $process.StandardOutput.ReadToEnd()
    $standardError = $process.StandardError.ReadToEnd()
    if ($standardOutput) { Write-Host $standardOutput.TrimEnd() }
    if ($standardError) { Write-Host $standardError.TrimEnd() }
    if ($process.ExitCode -ne 0) { throw "Probe failed: $($process.ExitCode)" }
}
finally {
    if (Test-Path -LiteralPath $output) { Remove-Item -LiteralPath $output -Force }
}
