:: This file deploys (to web folder) win client using settings from Sources\InitVariables.cmd.
:: Supports multi configuration (see Sources\InitVariables.cmd for details).
:: Parameter 1: 
::  pause - waits for user input after execution
::  nopause - do not wait for user input after execution
:: Parameter 2: 
::  multi configuration postfix


@ECHO OFF

SET currentDir=%CD%

cd "%currentDir%\Build"
if not exist "ClientWin" (
  cd "%currentDir%"
  CALL Build.Solution.cmd nopause
)

cd "%currentDir%\Build"
if exist client-win.zip del client-win.zip

:: calculate remote folder
cd "%currentDir%\Sources"
CALL InitVariables.cmd
cd "%currentDir%"

SET HostName=ClientHostName%2
SET PortNumber=ClientPortNumber%2
SET Protocol=ClientProtocol%2
SET UserName=ClientUserName%2
SET Password=ClientPassword%2
SET RemoteFolder=ClientRemoteFolder%2

:: pack client win
cd "%currentDir%"
CALL DeployTools\Uploader.exe pack "Build\ClientWin" "Build\client-win.zip"

setlocal EnableDelayedExpansion

SET DeployFolder=DeployWebFolder%2

CALL DeployTools\Uploader.exe inject-settings "Build\client-win.zip" "!%RemoteFolder%!" "!%HostName%!" "!%PortNumber%!" "!%Protocol%!" "!%UserName%!" "!%Password%!"
ECHO Deploying win client ...
CALL DeployTools\Uploader.exe upload "Build\client-win.zip" "!%RemoteFolder%!" "!%HostName%!" "!%PortNumber%!" "!%Protocol%!" "!%UserName%!" "!%Password%!"

endlocal

if not "%1" == "nopause" (
pause
)