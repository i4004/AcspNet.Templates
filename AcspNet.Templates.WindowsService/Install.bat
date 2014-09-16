@ECHO OFF

echo Installing $safeprojectname$...
c:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /LogFile= /LogToConsole=true $safeprojectname$.exe
pause