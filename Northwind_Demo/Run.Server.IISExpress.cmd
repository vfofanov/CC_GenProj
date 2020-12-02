:: Runs server using folder Build\Server via IIS Express.

@ECHO OFF

SET currentDir=%CD%

if not exist "Build\Server\bin" CALL Build.Solution.cmd nopause

CD "%currentDir%\Build\Server\bin"

ECHO Starting server ...

CALL "%ProgramFiles%\IIS Express\iisexpress.exe" "/path:%currentDir%\Build\Server" /port:9351 /systray:true

pause