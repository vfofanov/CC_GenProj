:: Runs windows client from folder Build\ClientWin.

@ECHO OFF
SET currentDir=%CD%

if not exist "Sources\NorthWind.Console" goto errorexit

if not exist "Build\ClientWin" CALL Build.Solution.cmd nopause

ECHO Starting win client ...

START /D "%currentDir%\Build\ClientWin" NorthWind.Console.exe

goto exit

:errorexit

ECHO Your code doesn't support win client!
pause

:exit