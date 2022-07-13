#!ps
#timeout=600000
#maxlength=60000
function install-3cxapp {

    <#
    .SYNOPSIS
        Read the Description

    .DESCRIPTION
        Function to install 3cx app via downloading the file and running it
        will provide the log and if the install worked or not.  Error code 0 means all is good, 1603 means you must run as admin

        This will also work in screenconnect CLI
    .EXAMPLE
        PS> install-3cxapp

        Not much of an example, it's a very much self contained function.  you can add parameters if you want for example
        NOTE: You do not need to end -destination with a \.  i.e -destination c:\temp\ as the $log variable already adds that \ and it's not needed
        I put in: if ($Destination[-1] -eq "\") {$Destination = $Destination.trimend('\')} as I'm sure no one will actually read this so the script will fix the issue anyways

        PS> install-3cx -destination c:\temp -log c:\temp\3cx.txt

        that will install the file to that location, and log to that location
    #>

    [CmdletBinding()]
    param (
        [Parameter()]
        [string]$URL = "https://downloads-global.3cx.com/downloads/3CXPhoneforWindows16.msi",
        [Parameter()]
        [string]$Destination = "#",
        [Parameter()]
        [string]$Log = "$($Destination)\3cxlog.txt"
    )
    
    begin {
        if ($host.UI.rawUI.windowtitle -notmatch "administrator") {write-warning "not Administrator window, script won't work, ending"; break;}
        if ($host.version.major -le "4") {write-warning "powershell version is less than 5, certain cmdlets may not work properly so ending"; break}
        if ($Destination[-1] -eq "\") {$Destination = $Destination.trimend('\');}
        write-host "`nurl : $URL`nDestination : $Destination`nlog : $Log`n";
        if ((test-path "$($Destination)\3CXPhoneforWindows16.msi" -OlderThan (get-date).adddays(-365) -ErrorAction Ignore) -eq $true) {write-host "3cx software is old copy, removing it to download fresh copy";remove-item -confirm:$false -force "$($Destination)\3CXPhoneforWindows16.msi";}

    }
    
    process {
        if (!(test-path "$($Destination)\3CXPhoneforWindows16.msi" -ErrorAction Ignore)) {start-bitstransfer -source $URL -Destination $Destination;} else {write-host "3cx software already exists, skipping download"}
        if ("$($Destination)\3CXPhoneforWindows16.msi") {msiexec.exe /i "$($Destination)\3CXPhoneforWindows16.msi" /quiet /log $Log;} else {"`n$($Destination)\3CXPhoneforWindows16.msi software missing, URL may no longer be good; ending script"; break}
    }

    end {        
        #sometimes the log takes a bit to populate, unsure why but the 10 second wait should cover it
        start-sleep -seconds 10;
        if (test-path "C:\ProgramData\3CXPhone for Windows\PhoneApp") {write-host "`n3cx folder path exists, install most likely went through correctly`n";} else {write-warning "unable to find 3cx folder from install, may not of installed correctly, or folder path has changed since I wrote this script`n";}
        write-host "`nIf error 0 install completed, if error 1603 you're using a non admin powershell`n";
        return (get-content $Log | select-string -pattern "Windows Installer installed the product");
    }

}
install-3cxapp
