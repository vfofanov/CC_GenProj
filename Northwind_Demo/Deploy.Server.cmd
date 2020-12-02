:: This file deploys server using settings from Sources\InitVariables.cmd.
:: Supports multi configuration (see Sources\InitVariables.cmd for details).
:: Parameter 1: 
::  pause - waits for user input after execution
::  nopause - do not wait for user input after execution
:: Parameter 2: 
::  multi configuration postfix

@ECHO OFF

SET currentDir=%CD%

cd "%currentDir%\Build"
if not exist "Server" (
  cd "%currentDir%"
  CALL Build.Solution.cmd nopause
)

cd "%currentDir%\Sources"
CALL InitVariables.cmd
cd "%currentDir%"

ECHO Deploying server ...

setlocal EnableDelayedExpansion

SET HostName=ServerHostName%2
SET PortNumber=ServerPortNumber%2
SET Protocol=ServerProtocol%2
SET UserName=ServerUserName%2
SET Password=ServerPassword%2
SET RemoteFolder=ServerRemoteFolder%2

SET oDBName=DBName%2
SET oDBServer=DBServer%2
SET oDBPassword=DBPassword%2
SET oDBUserName=DBUserName%2

CALL DeployTools\Uploader.exe cleanup "!%RemoteFolder%!" "!%HostName%!" "!%PortNumber%!" "!%Protocol%!" "!%UserName%!" "!%Password%!"
CALL DeployTools\Uploader.exe upload "Build\Server" "!%RemoteFolder%!" "!%HostName%!" "!%PortNumber%!" "!%Protocol%!" "!%UserName%!" "!%Password%!"

ECHO Running CCSystemInitialization.sql ...
sqlcmd -U "!%oDBUserName%!" -P "!%oDBPassword%!" -S "!%oDBServer%!" -d "!%oDBName%!" -i DatabaseScripts\CCSystemInitialization.sql
ECHO Running DomainInitialization.sql ...
sqlcmd -U "!%oDBUserName%!" -P "!%oDBPassword%!" -S "!%oDBServer%!" -d "!%oDBName%!" -i DatabaseScripts\DomainInitialization.sql

endlocal

if not "%1" == "nopause" (
pause
)