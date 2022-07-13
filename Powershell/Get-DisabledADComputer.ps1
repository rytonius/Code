$loginDate = (get-date).adddays(-365)
$modifiedDate = (get-date).adddays(-365)
$props = "name", "lastlogondate", "Created","modified", "OperatingSystem", "IPv4Address","DNSHostName", "Enabled"
get-adcomputer -property $props -filter {lastlogondate -gt $loginDate -and name -notlike '*dc*' -and modified -gt $modifiedDate -and -enabled -eq $false } | select $props


