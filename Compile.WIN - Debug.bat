@SET CURPATH=%~dp0
@SET CSCPATH=%CURPATH%bin\roslyn\

@SET SRVPATH=%CURPATH%Server\

@SET EXENAME=ServUOX

@TITLE: %EXENAME% - https://www.servuox.com

::##########

@ECHO:
@ECHO: Compile %EXENAME% for Windows
@ECHO:

@PAUSE

@DEL "%CURPATH%%EXENAME%.exe"

@ECHO ON

"%CSCPATH%csc.exe" /win32icon:"%SRVPATH%servuox.ico" /r:"%CURPATH%Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll" /target:exe /out:"%CURPATH%%EXENAME%.exe" /recurse:"%SRVPATH%*.cs" /d:ServUOX /d:NEWTIMERS /d:NETFX_472 /d:DEBUG /nowarn:0618 /debug /nologo /unsafe

@ECHO OFF

@ECHO:
@ECHO: Done!
@ECHO:

@PAUSE

@CLS

::##########
:Ask
echo Would you like to use debug mode?(Y/N)
set INPUT=
set /P INPUT=Type input: %=%
If /I "%INPUT%"=="y" goto yes 
If /I "%INPUT%"=="n" goto no
echo Incorrect input & goto Ask

:yes
@ECHO:
@ECHO: Ready To Run! %EXENAME% will be started in DEBUG Mode (-debug)
@ECHO:

@PAUSE

@CLS

@ECHO OFF

"%CURPATH%%EXENAME%.exe" -debug

:no
@ECHO:
@ECHO: Ready To Run!
@ECHO:

@PAUSE

@CLS

@ECHO OFF

"%CURPATH%%EXENAME%.exe"

