:: This file deploys web client using settings from Sources\InitVariables.cmd.
:: Supports multi configuration (see Sources\InitVariables.cmd for details).
:: Parameter 1: 
::  pause - waits for user input after execution
::  nopause - do not wait for user input after execution
:: Parameter 2: 
::  multi configuration postfix

@ECHO OFF

SET currentDir=%CD%

cd "%currentDir%\Build"
if not exist "ClientWeb" (
  cd "%currentDir%"
  CALL Build.Client.Web.cmd nopause 
)

cd "%currentDir%\Sources"
CALL InitVariables.cmd
cd "%currentDir%"

ECHO Deploying web client ...

setlocal EnableDelayedExpansion

SET HostName=ClientHostName%2
SET PortNumber=ClientPortNumber%2
SET Protocol=ClientProtocol%2
SET UserName=ClientUserName%2
SET Password=ClientPassword%2
SET RemoteFolder=ClientRemoteFolder%2

CALL DeployTools\Uploader.exe cleanup "!%RemoteFolder%!" "!%HostName%!" "!%PortNumber%!" "!%Protocol%!" "!%UserName%!" "!%Password%!"
CALL DeployTools\Uploader.exe upload "Build\ClientWeb" "!%RemoteFolder%!" "!%HostName%!" "!%PortNumber%!" "!%Protocol%!" "!%UserName%!" "!%Password%!"

endlocal

if not "%1" == "nopause" (
pause
)