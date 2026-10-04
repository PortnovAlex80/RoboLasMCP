@echo off
REM LAS_TERRAIN Build Script for Topomatic
REM Usage: build.bat [TopomaticPath]
REM Example: build.bat "C:\Program Files\Topomatic Robur Rail 17.0"

setlocal enabledelayedexpansion

REM ========================================
REM Find MSBuild
REM ========================================
set "MSBUILD="

REM Try vswhere first (VS 2017+)
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" (
    for /f "usebackq tokens=*" %%i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe 2^>nul`) do (
        set "MSBUILD=%%i"
    )
)

REM Fallback: Try common VS paths
if not defined MSBUILD (
    if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\MSBuild.exe" (
        set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\MSBuild.exe"
    ) else if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\amd64\MSBuild.exe" (
        set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\amd64\MSBuild.exe"
    ) else if exist "%ProgramFiles%\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\amd64\MSBuild.exe" (
        set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\amd64\MSBuild.exe"
    ) else if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\amd64\MSBuild.exe" (
        set "MSBUILD=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\amd64\MSBuild.exe"
    ) else if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\amd64\MSBuild.exe" (
        set "MSBUILD=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\amd64\MSBuild.exe"
    )
)

REM Fallback: .NET Framework
if not defined MSBUILD (
    if exist "%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" (
        set "MSBUILD=%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
    )
)

if not defined MSBUILD (
    echo ERROR: MSBuild not found!
    echo Please install Visual Studio 2019/2022 or .NET Framework 4.0+
    exit /b 1
)

echo Found MSBuild: %MSBUILD%

REM ========================================
REM Find Topomatic
REM ========================================
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
        echo Usage: build.bat "C:\Program Files\Topomatic Robur Rail 16.0"
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
echo Building LAS_TERRAIN Plugin
echo SDK: !TOPOMATIC!
echo ========================================
echo.

"%MSBUILD%" "%~dp0..\LAS_TERRAIN.csproj" /p:Configuration=Release /p:TopomaticPath="!TOPOMATIC!" /v:minimal

if %ERRORLEVEL% EQU 0 (
    echo.
    echo ========================================
    echo Build SUCCESS!
    echo Output: %~dp0..\bin\Release\LAS_TERRAIN.dll
    echo ========================================
) else (
    echo.
    echo ========================================
    echo Build FAILED!
    echo ========================================
    exit /b 1
)

endlocal
