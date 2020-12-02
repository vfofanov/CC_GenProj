:: This file builds solution that contains server side and optionally windows client and places results into Build/Server (Build/ClientWin) folder
:: Parameter 1: 
::  pause - waits for user input after execution
::  nopause - do not wait for user input after execution

@ECHO OFF

ECHO Building server (win client) ...

SET currentDir=%CD%

:: Ask for build option
set waitMins=7
echo DEBUG BUILD WILL START IN %waitMins% SECONDS: Press D for [D]ebug or R for [R]elease build
choice /c dr /d d /t %waitMins%
:: [D]ebug = 1; [R]elease = 2
goto Label%errorlevel%
:Label1
set config="Debug"
goto :Start
:Label2 
set config="Release"
:Start

:: Restore NuGet packages
.\BuildTools\nuget.exe restore .\Sources\Northwind.sln 

:: Define Microsoft (R) Build Engine environtment

set VS_WHERE=\Microsoft Visual Studio\Installer\vswhere.exe

if "%ProgramFiles(x86)%" == "" (
	set VS_WHERE="ProgramFiles%%VS_WHERE%"
) else (
	set VS_WHERE="%ProgramFiles(x86)%%VS_WHERE%"
)

for /f "usebackq tokens=*" %%i in (`%VS_WHERE% -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe`) do (
	set MS_BUILD=%%i
)

if "%MS_BUILD:~0,5%" == "Error" (
	for /f "usebackq tokens=*" %%i in (`%VS_WHERE% -latest -products * -requires Microsoft.Component.MSBuild -property installationPath`) do (
		set MS_BUILD=%%i\MSBuild\15.0\Bin\MSBuild.exe
	)
)

for /f "usebackq tokens=*" %%i in (`%VS_WHERE% -latest -products * -requires Microsoft.Component.MSBuild -property installationPath`) do (
	set MS_BUILD_EXTENSIONS=%%i\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\Microsoft.NET.Build.Extensions.targets
)

:: Definition of Microsoft (R) Build Engine environtment done

cd "%currentDir%\Sources"
call "%MS_BUILD%" Northwind.sln /ds /verbosity:m /p:Configuration=%config% /p:Platform="Any CPU" "/t:Clean,Build" "/p:CustomAfterMicrosoftCSharpTargets=%MS_BUILD_EXTENSIONS%"

::Cleanup old files
cd %currentDir%
if not exist "Build" mkdir Build
cd Build
if exist Server rmdir /s /q Server
if exist ClientWin rmdir /s /q ClientWin

:: Copy Server
ECHO Copy Server Files ...
cd "%currentDir%\Sources\Northwind.WebApiServer"
if not exist "%currentDir%\Build\Server\bin" mkdir "%currentDir%\Build\Server\bin"
xcopy /i bin\*.* "%currentDir%\Build\Server\bin" >NUL
xcopy /i bin\ru\*.* "%currentDir%\Build\Server\bin\ru" >NUL
xcopy /i Reports\*.* "%currentDir%\Build\Server\bin\Reports" >NUL
xcopy /i Web.config "%currentDir%\Build\Server" >NUL
xcopy /i web.db.connections.config "%currentDir%\Build\Server" >NUL
xcopy /i web.filestorages.config "%currentDir%\Build\Server" >NUL
xcopy /i web.notifiers.config "%currentDir%\Build\Server" >NUL
xcopy /i web.azure.connections.config "%currentDir%\Build\Server" >NUL
xcopy /i web.diagnostics.config "%currentDir%\Build\Server" >NUL
xcopy /i Status\*.* "%currentDir%\Build\Server" >NUL

:: Copy Client
if exist "%currentDir%\Sources\Northwind.Console\bin\%config%" (
  ECHO Copy Win Client Files ...
  cd "%currentDir%\Sources\Northwind.Console\bin\%config%"
  if not exist "%currentDir%\Build\ClientWin" mkdir "%currentDir%\Build\ClientWin"
  xcopy /i *.* "%currentDir%\Build\ClientWin" >NUL
  xcopy /i ru\*.* "%currentDir%\Build\ClientWin\ru" >NUL
)

if not "%1" == "nopause" (
pause
)