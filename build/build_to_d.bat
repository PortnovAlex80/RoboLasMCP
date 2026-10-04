@echo off
call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat" -arch=amd64

echo.
echo ========================================
echo Building LAS_TERRAIN Plugin to D:\LAS_TERRAIN_BUILD
echo ========================================
echo.

msbuild "%~dp0..\LAS_TERRAIN.csproj" ^
  /p:Configuration=Release ^
  "/p:TopomaticPath=C:\Program Files\Topomatic Robur Rail 16.0" ^
  /p:OutputPath=D:\LAS_TERRAIN_BUILD ^
  /v:minimal

if %ERRORLEVEL% EQU 0 (
    echo.
    echo ========================================
    echo Build SUCCESS!
    echo Output: D:\LAS_TERRAIN_BUILD\LAS_TERRAIN.dll
    echo ========================================
) else (
    echo.
    echo ========================================
    echo Build FAILED!
    echo ========================================
    exit /b 1
)
