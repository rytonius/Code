#!ps
#timeout=7200000
#maxlength=90000
Function Install-Office365 {
    # README
    # In the config.xml their is a AppSettings> <Setup Name="company" Value" " make sure to change this to the company your installing too
    begin {
        [string]$odt = "https://download.microsoft.com/download/2/7/A/27AF1BE6-DD20-4CB4-B154-EBAB8A7D4A7E/officedeploymenttool_14026-20306.exe"
        [string]$odtDestination ="#\"
        [string]$CheckOffice = (test-path "C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE")    
        [string]$os =(get-computerinfo).OsName

        if ($os -match "server") {"`noperating system is Server, exiting"; break} else {"`nOperating system is not server, proceeding"}

        #make config file
        if (!(test-path "$($odtDestination)\config.xml")) {New-Item "#\config.xml" -itemtype File}
        Set-Content #\config.xml '
        <Configuration ID="cd1047cc-8541-414f-a872-f43fbed48fb8">
        <Info Description="" />
        <Add OfficeClientEdition="64" Channel="Current">
            <Product ID="O365BusinessRetail">
            <Language ID="MatchOS" />
            <Language ID="MatchPreviousMSI" />
            <ExcludeApp ID="Groove" />
            <ExcludeApp ID="Lync" />
            </Product>
        </Add>
        <Property Name="SharedComputerLicensing" Value="0" />
        <Property Name="SCLCacheOverride" Value="0" />
        <Property Name="AUTOACTIVATE" Value="0" />
        <Property Name="FORCEAPPSHUTDOWN" Value="TRUE" />
        <Property Name="DeviceBasedLicensing" Value="0" />
        <Property Name="PinIconsToTaskbar" Value="TRUE"/>
        <Updates Enabled="TRUE" />
        <RemoveMSI />
        <AppSettings>
            <Setup Name="Company" Value="The Olive Oil Factory" />
        </AppSettings>
        <Display Level="None" AcceptEULA="TRUE" />
        </Configuration>
        '
    }

    process {
        
        if ($checkoffice -eq $true) {write-host "`noffice365 already exists"; break}

        else {
            write-host "`noffice365 not installed, downloading and installing"
            Set-Location $odtDestination
            if (test-path "$($odtDestination)\officedeploymenttool_14026-20306") {
                write-host "`noffice deployment tool already exists, skipping download"
            }
            else {
                if ($PSVersionTable.psversion.major -ge 5) {
                    $webclient=[System.Net.WebClient]::new();
                    $webclient.DownloadFile($odt, "$($odtdestination)\officedeploymenttool_14026-20306.exe");
                } else {$webclient = new-object (System.Net.WebClient).downloadfile($odt, "$($odtdestination)\officedeploymenttool_14026-20306.exe")}
                
                start-sleep -seconds 2;
                ./officedeploymenttool_14026-20306 /extract:./ /norestart /quiet
            }
            start-sleep -seconds 10

            if (!(test-path "$($odtDestination)\office")) {./setup.exe /download ./config.xml} else {"office files for installation already downloaded"}
            ./setup.exe /configure ./config.xml
            
            #(Get-ChildItem "C:\ProgramData\Microsoft\Windows\Start Menu\Programs") | ForEach-Object {if( $_.name -like "*2016*"){$_ | remove-item -recurse -Confirm:$false}}
            #(Get-ChildItem "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\") | %{if ($_.name -like "Microsoft office*"){remove-item -literalpath "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\$_" -recurse -confirm:$false -force}}
            Get-AppxPackage | Where-Object{$_.name -match "officehub"} | Remove-AppxPackage

        }
        
    }

    end {start-sleep 60; if ($checkOffice -eq $true) {write-host "`nOffice Installed"; remove-item "$($odtdestination)\office" -recurse -confirm:$false -force} else {Write-warning "Office not Installed"} }
}

Install-Office365


<#
#!ps
[string]$odtDestination ="#\"
remove-item "$($odtdestination)\office" -recurse -confirm:$false -force
#>