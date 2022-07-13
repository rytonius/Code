
Get-Event | Remove-Event
Get-EventSubscriber | Unregister-Event
$Query = 'SELECT * FROM Win32_ProcessStartTrace'            
$action = {            
    $e = $Event.SourceEventArgs.NewEvent
    $fmt = 'ProcessStarted: (SessionID={0,5}, ID={1,5}, Parent={2,5}, Time={3,20}, Name="{4}")'            
    $msg = $fmt -f $e.SessionID, $e.ProcessId, $e.ParentProcessId, $event.TimeGenerated, $e.ProcessName            
    Write-host -ForegroundColor Red $msg
    Write-host -ForegroundColor Green $e.User
}            
Register-WmiEvent -Query $Query -SourceIdentifier ProcessStart -Action $Action




Get-Event | Remove-Event
Get-EventSubscriber | Unregister-Event
$Query = 'SELECT * FROM Win32_ProcessStartTrace'            
$action = {
    $e = $Event.SourceEventArgs.NewEvent
    $fmt = 'ProcessStarted: (SessionID={0,5}, ID={1,5}, Parent={2,5}, Time={3,20}, Name="{4}")'            
    $msg = $fmt -f $e.SessionID, $e.ProcessId, $e.ParentProcessId, $event.TimeGenerated, $e.ProcessName            
    $proccess = Get-Process -Name $($e.ProcessName -replace "\.exe$", "")
    Write-host -ForegroundColor Red $msg
    Foreach($instance in $proccess) {
    Write-Host $instance.Path
    }
}            
Register-WmiEvent -Query $Query -SourceIdentifier ProcessStart -Action $Action