$genericList = [System.Collections.Generic.List[system.object]]::new()





measure-command { 
    
    $dataPoint = 1..10000
    $toby = "toby"
    $genericList = foreach ($data in $datapoint) {
        [PSCustomObject]@{
            value = $data
            name = $toby
        } 
    }    
}

measure-command {
    $dataPoint = 1..10000
    $arraylist = [System.Collections.ArrayList]@()
    foreach ($data in $datapoint) {$null = $arraylist.add($data)}
}

measure-command{
    $dataPoint = 1..10000
    $systemArray = @()
    foreach ($data in $datapoint) {$systemArray+=$data}
}

measure-command{
    $dataPoint = 1..10000
    $toby = "toby"
    $datapoint2 = 10001..20000
    $bobby = "bobby"
    $CustomObject =@(
        foreach ($data in $datapoint) {
            [pscustomobject]@{
                value = $data
                name = $toby
    
            }
        }
        
        foreach ($data2 in $datapoint2) {
            [pscustomobject]@{
                value = $data2
                name = $bobby
            }
        }
    ) 
}

measure-command { 
    $hashtable = $null
    $dataPoint = 1..10000
    $I=0
    $hashtable = [System.Collections.Hashtable]::new()
    
        foreach($data in $dataPoint){
            $hashtable.add(
                ++$i,$data
                
            )  
        }
        
}



function Get-ArrayRowIndex{
    param(
    [parameter(mandatory=$true)]$Property,
    [parameter(mandatory=$true)]$Value
    )
    $index = 0
    # Loop through array, incrementing index until value is found.
        while($index -lt ($gsmain.$Property.count)){
            if($gsmain.rows[$index].$Property -eq $Value){break}
            $index++
            }
            return $index
    }