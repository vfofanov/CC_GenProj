:: Runs deploy for server and both clients (web and win). Supports multi configuration (see Sources\InitVariables.cmd for details).
:: Parameter 1: 
::  multi configuration postfix

@ECHO OFF

SET currentDir=%CD%

CALL Deploy.Server.cmd nopause %1

cd "%currentDir%"

CALL Deploy.Client.Web.cmd nopause %1

cd "%currentDir%"

CALL Deploy.Client.Win.cmd nopause %1

pause