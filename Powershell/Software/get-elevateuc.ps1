#!ps
#timeout=9000000
#maxlength=90000
#this script is your macro level just run it and install if everything is a-ok, fire an forget
if ((Get-WmiObject -Class win32_operatingsystem).caption -notmatch "server" -and (Get-ChildItem "c:\windows\temp\elevate-uc.exe").length -ne 150348144 -and !(get-process "*elevate*")  ) 
{   $t = new-object System.Net.WebClient
    $t.DownloadFile("https://serverdata.net/elevateapps/apps/elevate-uc.exe", "c:\windows\temp\elevate-uc.exe")
    Get-ChildItem "c:\windows\temp\elevate-uc.exe" }    
else {"Make sure this isn't a Server";Get-ChildItem "c:\windows\temp\elevate-uc.exe"; get-process "*elevate*"}
if (!(get-process "*elevate*")) {cmd.exe /c "c:\windows\temp\elevate-uc.exe /S /ALLUSERS\ElevateInstallLog.txt";} else {"process running"}

#install the integration
#timeout=600000
"C:\Program Files\Elevate UC\OfficeIntegrationServer\ElevateOfficeIntegration.exe" -silentinstall


#!ps
#timeout=9000000
#maxlength=90000
# this is the install one, if you got the file on your computer just run this an install it
if (!(get-process "*elevate*")) {cmd.exe /c "c:\windows\temp\elevate-uc.exe /S /ALLUSERS\ElevateInstallLog.txt"} else {"process running"}


#i found some installs done on a local account.  no idea why.
#!ps
get-childitem "C:\users\" |Select-Object -expand name | ForEach-Object {get-childitem "C:\Users\$($_)\AppData\Local\Programs\Elevate UC\OfficeIntegrationServer\"}

$user =((Get-CimInstance -ClassName Win32_ComputerSystem).Username).split("\")[1]



#!ps
#timeout=9000000
#maxlength=90000
# if you find a local copy installed, then you can use this to re-download and then install over it with the install one
if ((Get-WmiObject -Class win32_operatingsystem).caption -notmatch "server" -and (Get-ChildItem "c:\windows\temp\elevate-uc.exe").length -ne 150348144 ) 
{   $t = new-object System.Net.WebClient
    $t.DownloadFile("https://serverdata.net/elevateapps/apps/elevate-uc.exe", "c:\windows\temp\elevate-uc.exe")
    Get-ChildItem "c:\windows\temp\elevate-uc.exe";
    cmd.exe /c "c:\windows\temp\elevate-uc.exe /S /ALLUSERS\ElevateInstallLog.txt";}    
else {"is a server, or has the file downloaded, or process is already running";Get-ChildItem "c:\windows\temp\elevate-uc.exe";}

#!ps
#timeout=9000000
#maxlength=90000
#to over write, just run this
cmd.exe /c "c:\windows\temp\elevate-uc.exe /S /ALLUSERS\ElevateInstallLog.txt" ;


#!ps
# make sure it's in the all user directory
get-childitem "C:\Program Files\Elevate UC\OfficeIntegrationServer\"


#install the integration
#timeout=600000
"C:\Program Files\Elevate UC\OfficeIntegrationServer\ElevateOfficeIntegration.exe" -silentinstall
