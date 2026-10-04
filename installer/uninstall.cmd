@echo off
rem RoboLas uninstaller launcher.
setlocal
echo Starting RoboLas uninstall (PowerShell)...
powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0Install-RoboLas.ps1" -Uninstall %*
set EC=%ERRORLEVEL%
echo.
if not "%EC%"=="0" echo Uninstaller finished with code %EC%.
pause
exit /b %EC%
