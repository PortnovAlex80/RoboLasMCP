@echo off
setlocal
set "MSBUILD="
for %%E in (Community Professional Enterprise BuildTools) do if exist "%ProgramFiles%\Microsoft Visual Studio\2022\%%E\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\%%E\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD (
    echo Visual Studio 2022 MSBuild.exe not found.
    exit /b 1
)
"%MSBUILD%" "%~dp0RoboLasInstaller.csproj" /t:Build /p:Configuration=Release /v:minimal /nologo
if errorlevel 1 exit /b 1
if not exist "%~dp0..\dist" mkdir "%~dp0..\dist"
copy /y "%~dp0bin\Release\RoboLasInstaller.exe" "%~dp0..\dist\RoboLasInstaller.exe" >nul
if errorlevel 1 exit /b 1
echo Published CLR 2 / .NET Framework 3.5 installer: ..\dist\RoboLasInstaller.exe
