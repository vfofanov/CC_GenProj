:: Runs webpack for web client in development mode.
:: In addition call Run.Client.Web.WebPack.IISExpress.cmd to start up a web server.

@ECHO OFF

ECHO Starting Web Client via WebPack ...

cd "Sources\Northwind.Web.Angular"

CALL npm run dev

pause