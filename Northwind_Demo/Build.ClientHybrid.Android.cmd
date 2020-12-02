@ECHO OFF

SET currentDir=%CD%
cd Sources
cd Northwind.Web.Angular

CALL npm run cordova:android

cd %currentDir%
if not exist "Build" mkdir Build
cd Build
if exist "AndroidClientHybrid" rmdir /s /q AndroidClientHybrid

ECHO Copy AndroidClientHybrid Files ...
cd "%currentDir%\Sources\Northwind.Web.Angular"
mkdir "%currentDir%\Build\AndroidClientHybrid"
xcopy cordova\platforms\android\app\build\outputs\apk\debug\app-debug.apk "%currentDir%\Build\AndroidClientHybrid"

if NOT "%1" == "nopause" (
pause
)