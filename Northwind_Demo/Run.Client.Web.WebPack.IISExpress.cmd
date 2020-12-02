:: Runs IIS Express for webpack in development mode.
:: Run this file after Run.Client.Web.WebPack.cmd.

@ECHO OFF
SET currentDir=%CD%

ECHO Starting Web Client via WebPack & IISExpress ...

cd "Sources\Northwind.Web.Angular"

START http://localhost:9350

CALL "%ProgramFiles%\IIS Express\iisexpress.exe" "/path:%currentDir%\Sources\Northwind.Web.Angular\Dist" /port:9350 /systray:true

pause

