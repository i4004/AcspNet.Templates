@ECHO OFF

echo Uninstalling $safeprojectname$...
c:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u /LogFile= /LogToConsole=true $safeprojectname$.exe
pause