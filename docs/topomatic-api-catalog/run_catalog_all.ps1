<#
.SYNOPSIS
    Batch DLL Catalog Generator for Topomatic API
.DESCRIPTION
    Auto-detects Topomatic installation and processes ALL Topomatic.*.dll files
    generating comprehensive API documentation with progress reporting.
.PARAMETER TopomaticPath
    Optional: Path to Topomatic installation. Auto-detects if not specified.
.PARAMETER OutputDir
    Optional: Output directory for generated markdown files.
    Default: .\dlls\
.PARAMETER Pattern
    DLL file name pattern. Default: Topomatic.*.dll
.EXAMPLE
    .\run_catalog_all.ps1
.EXAMPLE
    .\run_catalog_all.ps1 -TopomaticPath "C:\Program Files\Topomatic Robur Rail 16.0"
.EXAMPLE
    .\run_catalog_all.ps1 -OutputDir "C:\ApiDocs\Topomatic"
.EXAMPLE
    .\run_catalog_all.ps1 -Pattern "Topomatic.*.dll" -Verbose
#>

[CmdletBinding()]
param(
    [string]$TopomaticPath = "",
    [string]$OutputDir = "",
    [string]$Pattern = "Topomatic.*.dll"
)

$ErrorActionPreference = "Continue"
$ProgressPreference = "Continue"

# Script location
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$CatalogScript = Join-Path $ScriptDir "catalog_dll_enhanced.ps1"

# Default output directory
if (-not $OutputDir) {
    $OutputDir = Join-Path $ScriptDir "dlls"
}

# Create output directory if it doesn't exist
if (-not (Test-Path $OutputDir)) {
    New-Item -ItemType Directory -Path $OutputDir -Force | Out-Null
    Write-Host "Created output directory: $OutputDir" -ForegroundColor Cyan
}

# Function to detect Topomatic installation
function Find-TopomaticPath {
    Write-Host "`nSearching for Topomatic installation..." -ForegroundColor Cyan

    # Possible paths to check (in order of preference)
    $possiblePaths = @(
        "C:\Program Files\Topomatic Robur Rail 16.0",
        "C:\Program Files\Topomatic Robur Rail 17.0",
        "C:\Program Files\Topomatic Robur Rail 15.0",
        "C:\Program Files\Topomatic Robur Road 16.0",
        "C:\Program Files\Topomatic Robur Road 17.0",
        "C:\Program Files\Topomatic Robur Road 15.0",
        "C:\Program Files\Topomatic Robur Rail 14.0",
        "C:\Program Files (x86)\Topomatic Robur Rail 16.0",
        "C:\Program Files (x86)\Topomatic Robur Rail 17.0"
    )

    foreach ($path in $possiblePaths) {
        if (Test-Path $path) {
            Write-Host "Found Topomatic at: $path" -ForegroundColor Green
            return $path
        }
    }

    Write-Host "Topomatic installation not found in standard locations." -ForegroundColor Yellow
    return $null
}

# Get or detect Topomatic path
if (-not $TopomaticPath) {
    $TopomaticPath = Find-TopomaticPath
    if (-not $TopomaticPath) {
        Write-Host "ERROR: Cannot find Topomatic installation. Please specify -TopomaticPath" -ForegroundColor Red
        exit 1
    }
} elseif (-not (Test-Path $TopomaticPath)) {
    Write-Host "ERROR: Specified path does not exist: $TopomaticPath" -ForegroundColor Red
    exit 1
}

Write-Host "`nTopomatic Path: $TopomaticPath" -ForegroundColor Cyan
Write-Host "Output Directory: $OutputDir" -ForegroundColor Cyan
Write-Host "Pattern: $Pattern`n" -ForegroundColor Cyan

# Check if catalog script exists
if (-not (Test-Path $CatalogScript)) {
    Write-Host "ERROR: Catalog script not found: $CatalogScript" -ForegroundColor Red
    exit 1
}

# Get all DLLs matching pattern
$dllFiles = Get-ChildItem -Path $TopomaticPath -Filter $Pattern -File

if ($dllFiles.Count -eq 0) {
    Write-Host "WARNING: No DLLs found matching pattern: $Pattern" -ForegroundColor Yellow
    Write-Host "Searched in: $TopomaticPath" -ForegroundColor Gray
    exit 0
}

Write-Host "Found $($dllFiles.Count) DLL(s) to process`n" -ForegroundColor Cyan

# Statistics tracking
$stats = @{
    Total = $dllFiles.Count
    Processed = 0
    Skipped = 0
    Failed = 0
    StartTime = Get-Date
    FailedList = @()
}

# Process each DLL
$dllFiles | ForEach-Object -Begin {
    Write-Host ("=" * 80) -ForegroundColor Gray
    Write-Host "Batch DLL Catalog Generation" -ForegroundColor Cyan
    Write-Host ("=" * 80) -ForegroundColor Gray
    Write-Host ""
} -Process {
    $dll = $_
    $name = $dll.Name
    $outFile = Join-Path $OutputDir "$($dll.BaseName).md"

    $currentNum = $stats.Processed + 1
    $percent = [math]::Round(($currentNum / $stats.Total) * 100, 1)

    Write-Host "[$currentNum/$($stats.Total)] ($percent%) Processing: $name" -ForegroundColor Cyan

    try {
        # Run catalog script
        $proc = Start-Process -FilePath "powershell.exe" `
                             -ArgumentList "-NoProfile", "-ExecutionPolicy", "Bypass", "-File", "`"$CatalogScript`"", "-DllPath", "`"$($dll.FullName)`"", "-OutPath", "`"$outFile`"" `
                             -Wait -NoNewWindow -PassThru

        if ($proc.ExitCode -eq 0) {
            $stats.Processed++
            Write-Host "  SUCCESS -> $outFile" -ForegroundColor Green
        } else {
            $stats.Failed++
            $stats.FailedList += $name
            Write-Host "  FAILED (exit code: $($proc.ExitCode))" -ForegroundColor Red
        }
    } catch {
        $stats.Failed++
        $stats.FailedList += $name
        Write-Host "  ERROR: $_" -ForegroundColor Red
    }

    Write-Host ""
} -End {
    # Calculate duration
    $duration = (Get-Date) - $stats.StartTime

    Write-Host ("=" * 80) -ForegroundColor Gray
    Write-Host "Coverage Report" -ForegroundColor Cyan
    Write-Host ("=" * 80) -ForegroundColor Gray
    Write-Host ""
    Write-Host "Total DLLs Found:     $($stats.Total)" -ForegroundColor White
    Write-Host "Successfully Processed: $($stats.Processed)" -ForegroundColor Green
    Write-Host "Skipped:              $($stats.Skipped)" -ForegroundColor Yellow
    Write-Host "Failed:               $($stats.Failed)" -ForegroundColor Red
    Write-Host ""
    Write-Host "Duration:             $($duration.ToString('mm\:ss'))" -ForegroundColor Gray
    Write-Host "Output Directory:     $OutputDir" -ForegroundColor Gray
    Write-Host ""

    # List failed files
    if ($stats.FailedList.Count -gt 0) {
        Write-Host "Failed DLLs:" -ForegroundColor Red
        foreach ($failed in $stats.FailedList) {
            Write-Host "  - $failed" -ForegroundColor Red
        }
        Write-Host ""
    }

    # Generate coverage report file
    $reportFile = Join-Path $OutputDir "_coverage_report.md"
    $report = @"
# Topomatic API Catalog Coverage Report

**Generated**: $(Get-Date -Format "yyyy-MM-dd HH:mm:ss")
**Topomatic Path**: `$TopomaticPath
**Pattern**: `$Pattern

## Summary

| Metric | Count |
|--------|-------|
| Total DLLs Found | $($stats.Total) |
| Successfully Processed | $($stats.Processed) |
| Failed | $($stats.Failed) |
| Success Rate | $([math]::Round(($stats.Processed / $stats.Total) * 100, 1))% |

## Processed DLLs

$($dllFiles | Where-Object { $stats.FailedList -notcontains $_.Name } | ForEach-Object { "- ``$($_.Name)`` -> [$($_.BaseName).md]($($_.BaseName).md)" } | Out-String)

$(
    if ($stats.FailedList.Count -gt 0) {
        @"

## Failed DLLs

$($stats.FailedList | ForEach-Object { "- ``$_``" } | Out-String)

**Note**: Some DLLs may fail to load due to missing dependencies or native dependencies.
"@
    } else {
        @"

## All DLLs Processed Successfully

No errors encountered during batch processing.
"@
    }
)

## Output Directory

All generated API documentation files are located in:
```
$OutputDir
```
"@

    $report | Out-File -FilePath $reportFile -Encoding UTF8 -Force
    Write-Host "Coverage report saved to: $reportFile" -ForegroundColor Gray

    # Generate index file
    $indexFile = Join-Path $OutputDir "_index.md"
    $index = @"
# Topomatic API Catalog Index

**Generated**: $(Get-Date -Format "yyyy-MM-dd HH:mm:ss")
**Topomatic Version**: $TopomaticPath
**Total DLLs Cataloged**: $($stats.Processed)

## Available API Documentation

$(
    $processedDlls = $dllFiles | Where-Object { $stats.FailedList -notcontains $_.Name } | Sort-Object Name
    foreach ($dll in $processedDlls) {
        $mdFile = "$($dll.BaseName).md"
        "- [$($dll.Name)]($mdFile) - $(if (Test-Path (Join-Path $OutputDir $mdFile)) { 'API Reference' } else { 'Missing' })"
    }
)

## Statistics

| Metric | Value |
|--------|-------|
| Total DLLs | $($stats.Total) |
| Cataloged | $($stats.Processed) |
| Processing Time | $($duration.ToString('mm\:ss')) |

---

*Generated by [run_catalog_all.ps1](../run_catalog_all.ps1) using [catalog_dll_enhanced.ps1](../catalog_dll_enhanced.ps1)*
"@

    $index | Out-File -FilePath $indexFile -Encoding UTF8 -Force
    Write-Host "Index file saved to: $indexFile" -ForegroundColor Gray

    Write-Host "`nBatch processing complete!" -ForegroundColor Green
    Write-Host "Start browsing: $indexFile" -ForegroundColor Gray
}

exit $($stats.Failed)
