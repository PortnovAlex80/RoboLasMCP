@echo off
REM Compile and run the IPC test client
REM Keep the diagnostic client on the same CLR 2 runtime as the plugin.

set "F2=%WINDIR%\Microsoft.NET\Framework\v2.0.50727"
set "CSC=%WINDIR%\Microsoft.NET\Framework\v3.5\csc.exe"
if not exist "%CSC%" (
    echo ERROR: .NET Framework 3.5 csc.exe not found at %CSC%
    exit /b 1
)

echo Compiling LasTerrainTestClient.exe ...
"%CSC%" /nologo /noconfig /nostdlib+ /target:exe /out:LasTerrainTestClient.exe LasTerrainTestClient.cs /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%F2%\System.Runtime.Remoting.dll"
if errorlevel 1 (
    echo ERROR: Compilation failed
    exit /b 1
)

echo.
echo Running tests ...
echo.
LasTerrainTestClient.exe %*
exit /b %errorlevel%
