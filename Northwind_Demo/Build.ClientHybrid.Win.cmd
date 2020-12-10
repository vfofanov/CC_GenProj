@ECHO OFF

SET currentDir=%CD%
cd Sources
cd NorthWind.Web.Angular

CALL npm run electron:win

cd %currentDir%
if not exist "Build" mkdir Build
cd Build
if exist "WinClientHybrid" rmdir /s /q WinClientHybrid

ECHO Copy WinClientHybrid Files ...
cd "%currentDir%\Sources\NorthWind.Web.Angular"
xcopy /s /i NorthWind-win32-x64\*.* "%currentDir%\Build\WinClientHybrid" >NUL

if NOT "%1" == "nopause" (
pause
)