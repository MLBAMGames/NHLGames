@ECHO OFF
ECHO Reset NHLGames to its default settings.
ECHO If you continue, it will remove all user settings from any NHLGames current or older versions on your system.
PAUSE
DEL /S /q "%userprofile%\AppData\Local\NHLGames\*"
PAUSE
