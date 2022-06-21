function get-DomainUsers {
    $stopwatch = [system.diagnostics.stopwatch]::new() 
    $stopwatch.start()
    <# 
        requirements for the script to work, will check for active directory module 
        RSAT is required for ActiveDirectory Module to work.
        I believe Rsat.ActiveDirectory.DS-LDS.Tools~~~~0.0.1.0 is the only one of the RSAT toolbox that you need.
    #>
    Set-Variable -name "CheckSM" -value (get-module -name servermanager)
    Set-Variable -name "CheckAD" -value (get-module -name activedirectory)
    Set-Variable -name "CheckRSAT" -value (get-windowscapability -name Rsat* -Online)
    set-variable -name "StopWatch" -value (new-object -typename system.diagnostics.stopwatch)

    write-host "`none moment, checking for RSAT Feature and ActiveDirectory Module, Takes about"
    if ($CheckRSAT = $false) {
        write-host "RSAT is missing, downloading now" -foregroundcolor 'red'
        Get-WindowsCapability -Name RSAT.activedirectory* -Online | Add-WindowsCapability -Online
    }

    if ($CheckAD = $false) {
        write-host "ActiveDirectory Module is missing, downloading ActiveDirectory" -foregroundcolor 'red'
        import-module activedirectory
    }

    if ($CheckRSAT = $true) {
        write-host "Rsat Windows Feature on Demand is installed" -foregroundcolor 'green'
    }
    if ($checkAd = $true) {
        write-host "ActiveDirectory module is installed" -foregroundcolor 'green'
    }


    <# 
        Domain User Script itself, Sets 2 variables.
        Dusers which the script will prompt for, this is AD domain User name.
        Properties which is what the script will display out of the get-aduser cmdlet
    #>      
    Set-Variable -Name "Dusers" -value (read-host "Enter name of Domain Users to pull from, wildcard * is acceptable")
    Set-Variable -Name "Properties" -value 'Name', 'samaccountname', 'mail', 'proxyaddresses', 'passwordlastset', 'whencreated', 'lastlogondate', 'Description'
    if ($Dusers -is [string]) {
        get-aduser -identity $dusers -properties $properties | format-list $properties
    }

    $stopwatch.stop()

    $stopwatch
    #################################################
}
function get-adusersfromad {

    [CmdletBinding(defaultParameterSetName = 'Display')]
    param (
        [Parameter(Mandatory = $false, ParameterSetName = 'Display'
        )]
        [Switch]$Display,
       
        [Parameter(Mandatory = $true, ParameterSetName = 'Export'
        )]
        [Switch]$export
        
    )
        
    <#
    This will grab users determined by the searchbase, which is set up for OU location
    Edit $props = to determine what you want to pull property-wise.
    #>
    $readuser = read-host "input name of user, wildcard is acceptable"
    $props = 'Name', 'samaccountname', 'mail', 'proxyaddresses', 'whencreated', 'lastlogondate', 'PasswordNeverExpires', 'passwordlastset', 'Description', 'enabled'
    $runit = Get-ADUser -Properties $props -Filter {Name -like $readuser -and enabled -eq $true -and Lastlogondate -le 90}
    if ($display = $true) { $runit | select-object $props | format-table $props }
    if ($export = $true) {
        if (!(test-path C:\temp)) { mkdir C:\temp }
        $runit | select-object 'Name', 'samaccountname', 'mail', 'whencreated', 'lastlogondate', 'PasswordNeverExpires', 'passwordlastset', 'Description', 'enabled', @{L = "ProxyAddresses"; E = { $_.ProxyAddresses -join ";" } } | export-csv $ENV:userprofile\desktop\ADUser.csv
        
    }
    else { "broke" }
}
##################################################



<#
$tenant = (get-addomain).RIDMaster ; $datetime = [System.DateTime]::now.ToString("MM-dd-yyyy")
$props = 'DisplayName','UserPrincipalName','Title','LastLogonDate','PasswordLastSet','PasswordNeverExpires','Created','Modified','Enabled'
get-aduser -filter {name -like "*"} -properties $props | select $props |Export-Csv $env:USERPROFILE\Desktop\$($tenant)AD-USER_$($datetime).csv -NoTypeInformation

$compProps= "name", "lastlogondate", "Created","modified", "OperatingSystem","IPv4Address","DNSHostName", "Enabled"
get-adcomputer -filter {name -like "*"} -properties $compProps | select $compProps | Export-Csv $env:USERPROFILE\Desktop\$($tenant)AD-COMPUTERS_$($datetime).csv -NoTypeInformation
#>