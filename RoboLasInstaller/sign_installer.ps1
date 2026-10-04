# ============================================================================
# RoboLasInstaller Signing Script
# ============================================================================
#
# INPUT:  ..\dist\RoboLasInstaller.exe (built by publish.bat)
# OUTPUT: ..\dist\RoboLasInstaller.exe (signed, same location)
#
# Signs the installer EXE with Windows Authenticode signature.
# Requires Windows SDK (signtool.exe) and code signing certificate.
#
# ============================================================================

param(
    [string]$ExePath = "..\dist\RoboLasInstaller.exe"
)

$ErrorActionPreference = "Stop"

Write-Host "Signing RoboLasInstaller..." -ForegroundColor Cyan

# Check if exe exists
if (-not (Test-Path $ExePath)) {
    Write-Host "ERROR: Installer not found at $ExePath" -ForegroundColor Red
    Write-Host "Please run publish.bat first" -ForegroundColor Yellow
    exit 1
}

Write-Host "Input:  $ExePath" -ForegroundColor Gray

# Find signtool
$signToolPaths = @(
    "C:\Program Files (x86)\Windows Kits\10\bin\10.0.22621.0\x64\signtool.exe",
    "C:\Program Files (x86)\Windows Kits\10\bin\x64\signtool.exe",
    "${env:ProgramFiles(x86)}\Windows Kits\10\bin\x64\signtool.exe"
)

$signTool = $null
foreach ($path in $signToolPaths) {
    if (Test-Path $path) {
        $signTool = $path
        break
    }
}

if (-not $signTool) {
    Write-Host "ERROR: signtool.exe not found" -ForegroundColor Red
    Write-Host "Please install Windows SDK" -ForegroundColor Yellow
    exit 1
}

Write-Host "Using signtool: $signTool" -ForegroundColor Gray

# Sign the file
$result = & $signTool sign /fd sha256 /tr http://timestamp.digicert.com /td sha256 /d "RoboLas DTM Lidar Plugin" $ExePath 2>&1

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "Signing completed!" -ForegroundColor Green

    # Verify
    $sig = Get-AuthenticodeSignature -FilePath $ExePath
    Write-Host ""
    Write-Host "Signature Status: $($sig.Status)" -ForegroundColor Cyan

} else {
    Write-Host "Signing failed with exit code: $LASTEXITCODE" -ForegroundColor Red
    Write-Host $result -ForegroundColor Red
    exit 1
}
