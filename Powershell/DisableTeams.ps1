#!ps
#disable teams
set-itemproperty "HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\run" -name com.squirrel.teams.teams -value ([byte[]](0x03,0x00,0x00,0x00,0x9D,0X78,0X3B,0XB9,0x0D,0x9D,0xD6,0x01))


#enable teams
set-itemproperty "HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\run" -name com.squirrel.teams.teams -value ([byte[]](0x02))