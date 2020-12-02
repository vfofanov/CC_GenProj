:: Runs web client from Build\ClientWeb folder via IIS Express

@ECHO OFF

SET currentDir=%CD%

if not exist "Build\ClientWeb" CALL Build.Client.Web.cmd nopause

CD "%currentDir%\Build\Server\bin"

ECHO Starting web client ...

START http://localhost:9350

CALL "%ProgramFiles%\IIS Express\iisexpress.exe" "/path:%currentDir%\Build\ClientWeb" /port:9350 /systray:true

pause

