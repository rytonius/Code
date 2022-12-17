function diceroll ([int]$dice, [int]$roll) {
    $total = 0
    for ($i = 1; $i -le $dice; $i++) {
        write-host "i $($i)" 
        $r = get-random -Minimum 1 -Maximum $roll
        write-host "roll: " + $r
        $total += get-random -Minimum 1 -Maximum $roll
        
    }

    $total
}

function random ($min, $max) {
    
    [byte[]]$byte = 1
    write-host "byte" + $byte
    [System.Security.Cryptography.RandomNumberGenerator]::create().GetBytes($byte)
    write-host "after byte" + $byte
    [double]$ascii = [convert]::ToDouble($byte[0]);
    write-host "ascii" + $ascii
    [double]$multi = [Math]::Max(0, ($ascii / [double]255.0) - [double]0.00000000001)
    write-host "multi" + $multi
    [int]$range = $max - $min +1
    write-host "range" + $range
    [double]$randomValue = [Math]::Floor($multi * $range)
    write-host "randomvalue" + $randomValue
}