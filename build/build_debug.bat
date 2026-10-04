@echo off
REM LAS_TERRAIN Debug Build Script for Topomatic
REM Usage: build_debug.bat [TopomaticPath]

setlocal enabledelayedexpansion

if "%~1"=="" (
    echo No Topomatic path specified. Auto-detecting...

    if exist "C:\Program Files\Topomatic Robur Rail 17.0" (
        set TOPOMATIC=C:\Program Files\Topomatic Robur Rail 17.0
        echo Found: Topomatic Robur Rail 17.0
    ) else if exist "C:\Program Files\Topomatic Robur Road 17.0" (
        set TOPOMATIC=C:\Program Files\Topomatic Robur Road 17.0
        echo Found: Topomatic Robur Road 17.0
    ) else if exist "C:\Program Files\Topomatic Robur Rail 16.0" (
        set TOPOMATIC=C:\Program Files\Topomatic Robur Rail 16.0
        echo Found: Topomatic Robur Rail 16.0
    ) else if exist "C:\Program Files\Topomatic Robur Road 16.0" (
        set TOPOMATIC=C:\Program Files\Topomatic Robur Road 16.0
        echo Found: Topomatic Robur Road 16.0
    ) else if exist "C:\Program Files\Topomatic Robur Rail 15.0" (
        set TOPOMATIC=C:\Program Files\Topomatic Robur Rail 15.0
        echo Found: Topomatic Robur Rail 15.0
    ) else if exist "C:\Program Files\Topomatic Robur Road 15.0" (
        set TOPOMATIC=C:\Program Files\Topomatic Robur Road 15.0
        echo Found: Topomatic Robur Road 15.0
    ) else (
        echo ERROR: No Topomatic installation found!
        echo Usage: build_debug.bat "C:\Program Files\Topomatic Robur Rail 16.0"
        exit /b 1
    )
) else (
    set TOPOMATIC=%~1
    echo Using: %TOPOMATIC%
)

if not exist "!TOPOMATIC!" (
    echo ERROR: Topomatic path does not exist: !TOPOMATIC!
    exit /b 1
)

echo.
echo ========================================
echo Building LAS_TERRAIN Plugin (DEBUG)
echo SDK: !TOPOMATIC!
echo ========================================
echo.

msbuild "%~dp0..\LAS_TERRAIN.csproj" /p:Configuration=Debug /p:TopomaticPath="!TOPOMATIC!" /v:minimal

if %ERRORLEVEL% EQU 0 (
    echo.
    echo ========================================
    echo Debug Build SUCCESS!
    echo Output: %~dp0..\bin\Debug\LAS_TERRAIN.dll
    echo ========================================
) else (
    echo.
    echo ========================================
    echo Debug Build FAILED!
    echo ========================================
    exit /b 1
)

endlocal
