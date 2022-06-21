#!ps
#timeout=699999
#maxlength=60000
if ((Get-WmiObject -Class win32_operatingsystem).caption -notmatch "server" -and !(get-process "*open*" -erroraction ignore)) {
    $t = new-object System.Net.WebClient
    $t.DownloadFile("https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.5-I602-amd64.msi", "c:\windows\temp\OpenVPN-2.5.5-I602-amd64.msi")
    #invoke-webrequest -uri "https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.5-I602-amd64.msi" -outfile "c:\windows\temp\OpenVPN-2.5.5-I602-amd64.msi" -verbose
    MsiExec.exe /i "c:\windows\temp\OpenVPN-2.5.5-I602-amd64.msi" /qn /log "c:\windows\temp\openvpn-log.txt"
    start-sleep 60
    get-content "c:\windows\temp\openvpn-log.txt" -tail 20 }

else {"server, skipping and or openvpn process running"; get-process "*open*"}


#!ps
#timeout=699999
#maxlength=60000
if ((Get-WmiObject -Class win32_operatingsystem).caption -match "7") {
$t = new-object System.Net.WebClient
$t.DownloadFile("https://swupdate.openvpn.org/community/releases/openvpn-install-2.4.11-I602-Win7.exe", "c:\windows\temp\openvpn-install-2.4.11-I602-Win7.exe")
MsiExec.exe /i "c:\windows\temp\openvpn-install-2.4.11-I602-Win7.exe" /qn /log "c:\windows\temp\openvpn-log.txt"
start-sleep 60
get-process "*open*" 
}

else {"not a windows 7 machine"}
