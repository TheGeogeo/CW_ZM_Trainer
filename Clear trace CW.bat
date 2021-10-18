@echo off
goto check_Permissions

:check_Permissions
    net session >nul 2>&1
    if %errorLevel% == 0 (
        echo Success: Administrative permissions confirmed.
        goto next
    ) else (
        echo Failure: Start it in administrator.
        goto end
    )

:next
taskkill /F /IM Battle.net.exe
reg query "HKEY_LOCAL_MACHINE\Software\WOW6432Node\Blizzard Entertainment"
if %ERRORLEVEL% EQU 0 reg delete "HKEY_LOCAL_MACHINE\Software\WOW6432Node\Blizzard Entertainment" /f
reg query "HKEY_CURRENT_USER\Software\Blizzard Entertainment\Battle.net\Identity"
if %ERRORLEVEL% EQU 0 reg delete "HKEY_CURRENT_USER\Software\Blizzard Entertainment\Battle.net\Identity" /f

if exist %localappdata%\Battle.net\ (
  RMDIR /S /Q "%localappdata%\Battle.net\"
)
if exist %localappdata%\CrashDumps\ (
  RMDIR /S /Q "%localappdata%\CrashDumps\"
) 
if exist %localappdata%\Blizzard Entertainment\ (
  RMDIR /S /Q "%localappdata%\Blizzard Entertainment\"
) 
if exist %appdata%\Battle.net\ (
  RMDIR /S /Q "%appdata%\Battle.net\" 
) 
if exist %programdata%\Battle.net\ (
  RMDIR /S /Q "%programdata%\Battle.net\" 
) 
if exist %programdata%\Blizzard Entertainment\ (
  RMDIR /S /Q "%programdata%\Blizzard Entertainment\"
) 
if exist %UserProfile%\documents\Call Of Duty Black Ops Cold War\ (
  RMDIR /S /Q "%UserProfile%\documents\Call Of Duty Black Ops Cold War\"
)
if exist %UserProfile%\documents\Call of Duty Modern Warfare\ (
RMDIR /S /Q "%UserProfile%\documents\Call of Duty Modern Warfare\"
)

cls
echo --------------------------------------
echo .
echo .
echo Go on battle.net and repair your game.
echo May you need to reconnect at your account.
echo Shadow ban can be removed not 100% sure.
echo Do this again if you change for another account.
echo .
echo .
echo --------------------------------------

:end
pause