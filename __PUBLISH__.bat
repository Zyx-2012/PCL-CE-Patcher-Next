@echo off
echo ==========================================
echo      PCL CE Patcher Build Script
echo ==========================================
echo.

set OUTPUT_DIR=bin\Publish\win-x64
if exist "%OUTPUT_DIR%" (
    echo Cleaning old build...
    rd /s /q "%OUTPUT_DIR%"
)

echo Publishing for win-x64 (SingleFile)...
echo.

dotnet publish -c Release -r win-x64 -o "%OUTPUT_DIR%" /p:PublishSingleFile=true /p:SelfContained=false /p:IncludeNativeLibrariesForSelfExtract=true /p:IncludeAllContentForSelfExtract=true

if %ERRORLEVEL% NEQ 0 (
    echo.
    echo [ERROR] Build failed!
    pause
    exit /b %ERRORLEVEL%
)

echo.
echo ==========================================
echo [SUCCESS] Build completed!
echo Output: %OUTPUT_DIR%\PCL_CE_Patcher.exe
echo ==========================================
pause
