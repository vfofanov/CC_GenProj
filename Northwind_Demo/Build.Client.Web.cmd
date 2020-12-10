:: This file builds web client via webpack and places results into Build/ClientWeb folder
:: Parameter 1: 
::  pause - waits for user input after execution
::  nopause - do not wait for user input after execution

@ECHO OFF

ECHO Building web client ...

SET currentDir=%CD%

::Cleanup old files
if not exist "Build" mkdir Build
cd Build
if exist ClientWeb rmdir /s /q ClientWeb

:: Build Client
cd "%currentDir%\Sources\NorthWind.Web.Angular"
CALL npm run prod

if exist dist (
	ECHO Copy Web Client Files ...
	xcopy /s /i dist "%currentDir%\Build\ClientWeb" >NUL
	rmdir /s /q dist
	xcopy /s /i src\Web.config "%currentDir%\Build\ClientWeb" >NUL
)

cd "%currentDir%"

if NOT "%1" == "nopause" (
pause
)