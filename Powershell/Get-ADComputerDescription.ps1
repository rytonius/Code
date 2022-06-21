function write-description {
    begin {
        $hostname = HOSTNAME.EXE
        $whoami = whoami.exe
        }
    process {
        write-output "$hostname=$whoami" | out-file -filepath \\kiazuredc03\C$\AdComputerDescription\HostUser\$hostname.txt -ErrorAction SilentlyContinue
    }    
}
write-description