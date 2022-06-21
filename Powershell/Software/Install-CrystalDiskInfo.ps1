function Install-CrystalDiskInfo {
    $path = "c:\temp\CrystalDiskInfo8_12_4"
    $uri = "https://ftp.halifax.rwth-aachen.de/osdn/crystaldiskinfo/76657/CrystalDiskInfo8_15_0.zip"
    if ([System.Net.ServicePointManager]::SecurityProtocol -like "*tls12*" -or [System.Net.ServicePointManager]::SecurityProtocol -like "SystemDefault" ) {write-host "`nTLS 1.2 is enabled for Powershell`n`n`n" -ForegroundColor green;} else {[System.Net.ServicePointManager]::SecurityProtocol += [System.Net.SecurityProtocolType]::tls12; Write-Warning "TLS 1.2 wasn't enabled on powershell, enabling now"; write-host "#$($attemptsTLS) checking again now Security Protocol: $([System.Net.ServicePointManager]::SecurityProtocol)";} 
    if (!(test-path $path)) {mkdir $path} else {write-host "$path already exists" -ForegroundColor green}
    if (test-path "$($path)\DiskInfo64.exe") {write-host "crystal disk info application detected, skipping download and unzip" -ForegroundColor green}
   
    else  {
        invoke-webrequest -uri $uri -outfile "$($path)\CrystalDiskInfo8_15_0.zip"
        $shell = new-object -com shell.application
        $zip = $shell.NameSpace("$path\CrystalDiskInfo8_15_0.zip")
        foreach($item in $zip.items()){$shell.Namespace($path).copyhere($item, 0x14)} 
        
    }
    . "$($path)\DiskInfo64.exe"
    
}
Install-CrystalDiskInfo
