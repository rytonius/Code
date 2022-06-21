function New-LogFile
{
    #Variables
        # Pulls script name from currently running script and trims to bare name.
        $ScriptName = $MyInvocation.PSCommandPath.Trim($MyInvocation.PSScriptRoot)
        $ScriptName = $ScriptName.TrimEnd(".ps1")
    # Desired Folder for logs
        $LogsFolder = "C:\ErrorLogs\$ScriptName"
    # Desired file name
        $FileName = "$($ScriptName)_$(get-date -UFormat "%m_%d_%Y").log"
    # If the folder doesn't exist, create it.
        If (!(Test-Path $LogsFolder))
        {
            New-Item -ItemType Directory -Path "$LogsFolder" > $null
            Write-Host -ForegroundColor Green ("$LogsFolder does not exist! Creating Directory.")
        }
        Else 
        {
            Write-Host -ForegroundColor Green ("$LogsFolder already exists.")
        }
    # If the Logfile doesn't exist, Create it.
        If (!(Test-Path "$LogsFolder\$FileName"))
        {
            New-Item -Path $LogsFolder -ItemType File -Name $FileName > $null
            Write-Host -ForegroundColor Green ("$LogsFolder\$Filename Created.")
        }
    # If the logfile does exist, rename the old one and create a new one.
        else 
        {
            Write-Host -ForegroundColor green ("logfile already exists")
        }
}

function Add-LogEntry ($Message) 
{
    #Variables
        # Pulls script name from currently running script and trims to bare name.
            $ScriptName = $MyInvocation.PSCommandPath.Trim($MyInvocation.PSScriptRoot)
            $ScriptName = $ScriptName.TrimEnd(".ps1")
        # Desired Folder for logs
            $LogsFolder = "C:\ErrorLogs\$ScriptName"
        # Desired file name
            $FileName = "$($ScriptName)_$(get-date -UFormat "%m_%d_%Y").rtf"
        # Full Logfile Path
            $LogPath = "$LogsFolder\$FileName"
    
            #check if logfile exists
    if (!(Test-Path $LogPath))
    {
        
        write-host ("Logfile does not exist")    
    }
    $TimeStamp = Get-Date -UFormat "%r - %D"
    Write-Host -ForegroundColor Blue ("$($TimeStamp) -- $Message --") out-file $LogPath
}


function test {
    new-logfile
    $message = Get-Process
    add-logentry($message)
}

test