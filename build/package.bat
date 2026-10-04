@echo off
REM LAS_TERRAIN Package Script
REM Usage: package.bat [version] [build-path]
REM Example: package.bat 1.0.0 D:\LAS_TERRAIN_BUILD

setlocal

set VERSION=%1
set "BUILD_PATH=%~2"

if "%VERSION%"=="" set VERSION=1.0.0
if "%BUILD_PATH%"=="" set "BUILD_PATH=D:\LAS_TERRAIN_BUILD"

echo.
echo Package version: %VERSION%
echo Build path: %BUILD_PATH%
echo.

powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0package.ps1" -Version "%VERSION%" -BuildPath "%BUILD_PATH%"
if errorlevel 1 exit /b 1

endlocal
