#!ps
#timeout=1000000
#maxlength=60000
function Install-SaneAgent {
    [CmdletBinding()]
    param (
        [Parameter()]
        [string]$url = "https://saner.secpod.com/download.jsp?tgtuid=c5027a1c-41f9-4aea-a9a7-fb9d57367ad5&type=windows-exe-noui&arch=x86",
        [Parameter()]
        [string]$dir = "#"
    )
    begin {
        if (get-process "*sane*") {write-warning "Sane Agent already exists, breaking"; break} else {write-host "`nno sane agent, continue`n";}
        if (test-path #) {write-host "packages dir exists"} else {New-Item -ItemType Directory "#"}
        #tls must be 1.2 for start-bitstransfer to work
        write-host "`nchecking Security Protocol: $([System.Net.ServicePointManager]::SecurityProtocol) `n`n" ;
        
        if ([System.Net.ServicePointManager]::SecurityProtocol -like "*tls12*" -or [System.Net.ServicePointManager]::SecurityProtocol -like "SystemDefault" ) {write-host "`nTLS 1.2 is enabled for Powershell`n`n`n" -ForegroundColor green;} else {[System.Net.ServicePointManager]::SecurityProtocol += [System.Net.SecurityProtocolType]::tls12; Write-Warning "TLS 1.2 wasn't enabled on powershell, enabling now"; write-host "#$($attemptsTLS) checking again now Security Protocol: $([System.Net.ServicePointManager]::SecurityProtocol)";}
        
        #you must update the URL for the tenant
        
        
    }
    
    process {

        try {Start-BitsTransfer -Source $url -Destination $dir} 
        catch {
            $dir = "#"
            (new-object net.webclient).downloadfile($url,$dir)
        }
        start-process $dir -ArgumentList "/S" -wait
    }
    
    end { get-process "*sane*" }
    
}
Install-SaneAgent