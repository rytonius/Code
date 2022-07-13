#!ps
#timeout=699999
#maxlength=699999


function Get-SoftwareURL {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$true)][String]$URI,
        [Parameter(Mandatory=$true)][String]$FileName,
        [string]$Destination = "$env:USERPROFILE\Desktop\",
        [bool]$install = 1
    )
    
    #if (!(test-path $destination\$filename))  {invoke-webrequest -uri $uri -outfile $Destination\$fileName -verbose} else {"skipping download, file is already on computer"}
    invoke-webrequest -uri $uri -outfile $Destination\$fileName -verbose

    switch ($install){
        1 {
            "1"
            msiexec.exe /i $Destination\$FileName /q /log "C:\windows\temp\$($filename.split(".")[0]).txt"
            get-content "C:\windows\temp\$($filename.split(".")[0]).txt"  -Tail 20   
        }
        2 {
            "2"
            return "Skipping Install"; break
        }
        default {"default"; msiexec.exe /i $Destination\$FileName /q /log "C:\windows\temp\$($filename.split(".")[0]).txt"; get-content "C:\windows\temp\$($filename.split(".")[0]).txt"  -Tail 20 }
    }

}

Get-SoftwareURL -filename "elevate-uc.exe" -URI "https://serverdata.net/elevateapps/apps/elevate-uc.exe" -install 1 -destination "C:\windows\temp"