@echo off

call msharp-build --notools %1 %2

call M#\lib\net8.0\msharp /pangolin /output:"%CD%\Pangolin\AppTests"

if ERRORLEVEL 1 (    
	echo ##################################    
    set /p cont= Error occured. Press Enter to exit.
    exit /b -1
)
