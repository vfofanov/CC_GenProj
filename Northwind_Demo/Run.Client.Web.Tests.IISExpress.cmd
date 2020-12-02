:: Runs web client from Build\ClientWeb folder via IIS Express

@ECHO OFF

START Run.Client.Web.IISExpress.cmd

SET currentDir=%CD%
cd Sources
cd Northwind.Web.Angular

SET URL=http://localhost:9350

CALL npm run test

pause
