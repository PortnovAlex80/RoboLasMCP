@echo off
setlocal
if "%~1"=="" (
  echo Usage: run_filter_snapshot_adapter.cmd ^<plugin-dll^>
  exit /b 2
)
set "PLUGIN=%~f1"
set "SDK=%TOPOMATIC_PATH%"
if "%SDK%"=="" set "SDK=C:\Program Files\Topomatic Robur Rail 16.0"
set "F2=%WINDIR%\Microsoft.NET\Framework\v2.0.50727"
set "F35=%WINDIR%\Microsoft.NET\Framework\v3.5"

if not exist "%PLUGIN%" (
  echo ERROR: Production plugin DLL not found: %PLUGIN%
  exit /b 2
)
if not exist "%SDK%\Topomatic.Cad.Foundation.dll" (
  echo ERROR: Rail SDK not found: %SDK%
  exit /b 2
)
if not exist "%F35%\csc.exe" (
  echo ERROR: .NET Framework 3.5 compiler not found.
  exit /b 2
)

set "TEST_EXE=%TEMP%\FilterSettingsSnapshotAdapterTests-%RANDOM%-%RANDOM%.exe"
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /target:exe /out:"%TEST_EXE%" /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" "%~dp0FilterSettingsSnapshotAdapterTests.cs"
if errorlevel 1 exit /b %ERRORLEVEL%

"%TEST_EXE%" "%PLUGIN%" "%SDK%"
set "RESULT=%ERRORLEVEL%"
del /q "%TEST_EXE%" >nul 2>&1
exit /b %RESULT%
