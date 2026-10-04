@echo off
setlocal
set "MSBUILD="
for %%E in (Community Professional Enterprise BuildTools) do if exist "%ProgramFiles%\Microsoft Visual Studio\2022\%%E\MSBuild\Current\Bin\MSBuild.exe" set "MSBUILD=%ProgramFiles%\Microsoft Visual Studio\2022\%%E\MSBuild\Current\Bin\MSBuild.exe"
if not defined MSBUILD (
    echo Visual Studio 2022 MSBuild.exe not found.
    exit /b 1
)
"%MSBUILD%" "%~dp0RoboLasInstaller.csproj" /t:Build /p:Configuration=Debug /v:minimal /nologo
if errorlevel 1 exit /b 1
echo Built CLR 2 / .NET Framework 3.5 installer: bin\Debug\RoboLasInstaller.exe
