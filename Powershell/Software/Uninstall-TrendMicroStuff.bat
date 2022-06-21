::For a 32-bit operating system, go to the HKEY_LOCAL_MACHINE\SOFTWARE\TrendMicro\PC-cillinNTCorp\CurrentVersion\Misc registry hive.
::For a 64-bit operating system, go to the HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\TrendMicro\PC-cillinNTCorp\CurrentVersion\Misc registry hive.
::Misc seems to have a . at the end of it, need to confirm is this is regular, and if so, what a bunch of a holes.
reg query HKLM\SOFTWARE\TrendMicro\PC-cillinNTCorp\CurrentVersion\Misc. /s /f "Allow Uninstall"
reg query SOFTWARE\Wow6432Node\TrendMicro\PC-cillinNTCorp\CurrentVersion\Misc\ /s /f "Allow Uninstall"

reg add "SOFTWARE\Wow6432Node\TrendMicro\PC-cillinNTCorp\CurrentVersion\Misc" /v "Allow Uninstall" /d 1 /t REG_DWORD


REG QUERY HKLM\Software\Microsoft\Windows\CurrentVersion\Uninstall /s /f SOPHOS > C:\temp\Sophos_Uninstall_Strings.txt
REG QUERY HKLM\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall /s /f SOPHOS > C:\temp\Sophos_Uninstall_Strings64bit.txt