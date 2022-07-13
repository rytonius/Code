function Cylance-SubTemplate {

    begin {
        $MyKeys = #

        $Connection = #
        }
    
    try {
        import-module ConnectWiseManageAPI
        Connect-CWM @Connection -ErrorAction Stop
    }
    catch {
        write-host "`n$($_.Exception.Message)" -ForegroundColor red
        write-host "a value inside the connection variable is incorrect or you don't have the PS module: ConnectWiseManageAPI`n" -ForegroundColor yellow
        break
    }
        [string]$StartTime = [DateTime]::UTCNow | get-date -UFormat %Y-%m-%dT%R%:%SZ
        [string]$notes = @()   

        # PLEASE PUT IN DESCRIPTION
        [string]$Description = "description for the time entry itself"
        $notes = write-output "Script: $($MyInvocation.MyCommand),`n`nDescription: $Description`n"   
        $global:CompanyID = #
        $global:TicketID = #
    }
    
   
    process {
        # += into results that you want on the ticket
        $results = @()
        #######################     Script Start

            # Paste your Code here #

        #######################     Script End
        # example delete this 
        $results += write-output "this will pin information into the note itself`ntesting template that you can universally use for any script, start to finish"
    }
    
    
    end {
        $notes += write-output "`n`n$results`n`n"
        [string]$EndTime = [DateTime]::UTCNow.AddMinutes(1) | get-date -UFormat %Y-%m-%dT%R%:%SZ
        
        try{
            new-cwmtimeentry -id $CompanyID -chargeToId $TicketID -chargeToType ServiceTicket -timeStart "$StartTime" -timeEnd "$EndTime" -notes "$notes" -addToInternalAnalysisFlag $true -addToDetailDescriptionFlag $false -erroraction Stop
            write-host "`nSuccesfully posted time entry`n" -ForegroundColor green
        }
        catch{
            write-host "`n$($_.Exception.Message)" -ForegroundColor red
            break
        }
        Disconnect-CWM
    }
}

