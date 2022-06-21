
#get your uninstall strings, not needed for the function to run.
REG QUERY HKLM\Software\Microsoft\Windows\CurrentVersion\Uninstall /s /f SOPHOS > C:\temp\Sophos_Uninstall_Strings.txt
REG QUERY HKLM\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall /s /f SOPHOS > C:\temp\Sophos_Uninstall_Strings64bit.txt

# this works too find .msi packages https://stackoverflow.com/questions/450027/uninstalling-an-msi-file-from-the-command-line-without-using-msiexec
get-wmiobject Win32_Product | Format-Table Name, LocalPackage -AutoSize

function uninstall-sophos {
    #make sure to resume-bitlocker when all is done
    suspend-bitlocker -RebootCount 3 -mountpoint c:
    net stop "SAVService"
    net stop "Sophos AutoUpdate Service"
    sc stop hmpalertsvc
    $path = "c:\temp";if (!(test-path $path)){mkdir $path}
    $UninstallKeys = "HKLM:\Software\Microsoft\Windows\CurrentVersion\Uninstall", "HKLM:\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
    $null = New-PSDrive -Name HKU -PSProvider Registry -Root Registry::HKEY_USERS
    $UninstallKeys += Get-ChildItem HKU: -ErrorAction SilentlyContinue | Where-Object { $_.Name -match 'S-\d-\d+-(\d+-){1,14}\d+$' } | ForEach-Object { "HKU:\$($_.PSChildName)\Software\Microsoft\Windows\CurrentVersion\Uninstall" }
    $key = @()
    foreach ($UninstallKey in $UninstallKeys) {
        
        $key += Get-ChildItem -Path $UninstallKey -ErrorAction SilentlyContinue | Where {$_.PSChildName -match '^{[A-Z0-9]{8}-([A-Z0-9]{4}-){3}[A-Z0-9]{12}}$'} | Select-Object @{n='GUID';e={$_.PSChildName}}, @{n='Name'; e={$_.GetValue('DisplayName')}}
        $key | ? {$_.name -like "*sophos*"} | select -expand guid | foreach-object {MsiExec.exe /X$($_) /qn REBOOT=SUPPRESS /L*v C:\Temp\$($_)_Log.txt;write-host "$($_)";start-sleep 15}
    }
}
    uninstall-sophos

<#>
######## original uninstall strings before I came up with the script

MsiExec.exe /X{4B1F9009-CD85-43C0-BCBD-D491908D5A52} /qn REBOOT=SUPPRESS /L*v C:\Temp\D491908D5A52_Log.txt
MsiExec.exe /X{2831282D-8519-4910-B339-2302840ABEF3} /qn REBOOT=SUPPRESS /L*v C:\Temp\2302840ABEF3_Log.txt
MsiExec.exe /X{1DE930DF-6191-4859-A97E-E37029B1EA08} /qn REBOOT=SUPPRESS /L*v C:\Temp\E37029B1EA08_Log.txt
MsiExec.exe /X{EB2A2F1B-6662-444E-8983-AB9B6E9DF6A6} /qn REBOOT=SUPPRESS /L*v C:\Temp\AB9B6E9DF6A6_Log.txt
MsiExec.exe /X{80D18B7B-8DF1-4BCA-901F-BEC86BAE2774} /qn REBOOT=SUPPRESS /L*v C:\Temp\BEC86BAE2774_Log.txt
MsiExec.exe /X{4EFCDD15-24A2-4D89-84A4-857D1BF68FA8} /qn REBOOT=SUPPRESS /L*v C:\Temp\857D1BF68FA8_Log.txt
MsiExec.exe /X{8D7BB12C-6854-46DF-A67D-F82D778D75C8} /qn REBOOT=SUPPRESS /L*v C:\Temp\F82D778D75C8_Log.txt
MsiExec.exe /X{CD39E739-F480-4AC4-B0C9-68CA731D8AC6} /qn REBOOT=SUPPRESS /L*v C:\Temp\68CA731D8AC6_Log.txt
MsiExec.exe /X{425063CE-9566-43B8-AC61-F8D182828634} /qn REBOOT=SUPPRESS /L*v C:\Temp\F8D182828634_Log.txt
MsiExec.exe /X{2C14E1A2-C4EB-466E-8374-81286D723D3A} /qn REBOOT=SUPPRESS /L*v C:\Temp\81286D723D3A_Log.txt

:LAST ONE diagnositic
MsiExec.exe /X{8078549C-CFF0-48C5-9B77-6BA48A14673D} /qn REBOOT=SUPPRESS /L*v C:\Temp\6BA48A14673D_Log.txt
#>
#!ps
#timeout=600000
#maxlength=900000
    




<#
    Next part is to run in CMD CLI
    
    "C:\Program Files\Sophos\Sophos Endpoint Agent\uninstallcli.exe"
    "C:\Program Files\Sophos\Sophos AMSI Protection\Uninstall.exe"
    "C:\Program Files\Sophos\Sophos ML Engine\SophosSMEUninstall.exe"

    "C:\Program Files (x86)\Sophos\Clean\uninstall.exe" 
    "C:\Program Files\Sophos\Sophos File Scanner\Uninstall.exe" 
    "C:\Program Files\Sophos\Sophos ML Engine\Uninstall.exe"  
    "C:\Program Files (x86)\Sophos\Management Communications System\Endpoint\uninstall" 
    "C:\Program Files\Sophos\Sophos Endpoint Agent\uninstallgui.exe" 
    "C:\Program Files\Sophos\Live Terminal\Uninstall.exe" 
    "C:\Program Files\Sophos\Endpoint Defense\SEDuninstall.exe" 
    "C:\Program Files\Sophos\Sophos Standalone Engine\SophosSSEUninstall.exe" 
    :must be restarted
     
    "C:\Program Files (x86)\HitmanPro.Alert\hmpalert.exe" /uninstall /quiet
    "C:\Program Files (x86)\HitmanPro.Alert\uninstall.exe" --quiet
    "C:\Program Files\HitmanPro\HitmanPro.exe" /uninstall /quiet


    sc stop hmpalertsvc

    "C:\Program Files (x86)\HitmanPro.Alert\hmpalert.exe" /uninstall /quiet
    "C:\Program Files (x86)\HitmanPro.Alert\uninstall.exe" --quiet
    "C:\Program Files\HitmanPro\HitmanPro.exe" /uninstall /quiet


#>

<#
####Using Notepad or any text editor, copy and paste the uninstall string for each component, and make sure to observe the following order:

Sophos Remote Management System
Sophos Network Threat Protection
Sophos Client Firewall
Sophos Anti-Virus 
Sophos AutoUpdate <--
Sophos Diagnostic Utility
Sophos Exploit Prevention
Sophos Clean
Sophos Patch Agent
Sophos Endpoint Defense

#>