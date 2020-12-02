@ECHO OFF

SET currentDir=%CD%
cd Sources
cd Northwind.Web.Angular

CALL npm run electron:linux

cd %currentDir%
if not exist "Build" mkdir Build
cd Build
if exist "LinuxClientHybrid" rmdir /s /q LinuxClientHybrid

ECHO Copy LinuxClientHybrid Files ...
cd "%currentDir%\Sources\Northwind.Web.Angular"
xcopy /s /i Northwind-linux-x64\*.* "%currentDir%\Build\LinuxClientHybrid" >NUL

if NOT "%1" == "nopause" (
pause
)