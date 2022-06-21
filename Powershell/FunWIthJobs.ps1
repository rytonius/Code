    $x = 0
    $y = 0
    $z = 0
    $Final = 0
    $add = 0
    $addtojob = 0
    while ($Final -le 100)
    {
        
        if (((get-job).State -eq "running" | measure | select -expand count) -le 10) 
        {
            $addtojob = get-job | where {$_.state -eq "completed"} | foreach-object {$_.childjobs.output[9] | where {$_ -eq 1}}

            #write-host "currently have $addtojob completed`n" -ForegroundColor green

                #$failtojob = get-job | where {$_.state -eq "completed"} | foreach-object {$_.childjobs.output[9]} | where {$_ -ne 1}

                #write-host "currently have $failtojob that have failed`n"

            if ($addtojob -gt 0) {foreach ($add in $addtojob) {$Final += 1}; $addtojob = 0}
            
            get-job | where {$_.state -eq "completed"} | Remove-Job

            $jobname = "job # $final"

            write-host "new job made $final" -ForegroundColor yellow

            start-job -name $jobname -scriptblock {
                while ($y -le 10) {
                    if ($x -le 1) 
                        { 
                        write-output "x is $x"
                        $x += 1
                        start-sleep -seconds 1
                        }
                    else{
                        $Y += 1; write-output "Y is $Y"; $x = 0
                        }
                        if ($y -eq 3){$z += 1; write-output "$z"}
                          
                }
            }
                           
        }
    }

    
    
   
        
    