@echo off
set sourceDir=%~dp0
set targetDir=%temp%

xcopy "%sourceDir%sound\*.mp3" "%targetDir%" /Y /I