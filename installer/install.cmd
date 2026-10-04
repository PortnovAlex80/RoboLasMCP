@echo off
rem RoboLas + MCP adapter installer launcher.
rem ASCII-only on purpose; all user-facing text lives in the PowerShell script.
setlocal
echo Starting RoboLas installer (PowerShell)...
powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0Install-RoboLas.ps1" %*
set EC=%ERRORLEVEL%
echo.
if not "%EC%"=="0" echo Installer finished with code %EC%.
pause
exit /b %EC%
