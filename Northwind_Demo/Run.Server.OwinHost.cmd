:: Runs server using folder Build\Server via OwinHost.

@ECHO OFF
SET currentDir=%CD%

if not exist "Build\Server\bin" CALL Build.Solution.cmd nopause

CD "%currentDir%\Build\Server\bin"

ECHO Starting server ...

"%currentDir%\packages\OwinHost.4.0.0\tools\OwinHost.exe" -u http://localhost:9351

pause