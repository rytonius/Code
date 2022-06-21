function pyramidFactorial ([int]$n)
{
    
    $s = 1;
    while ($n -ne 1){  $s *= $n; $n = $n - 1}
    $n = $s
    write-host "$n" -foregroundcolor red -backgroundcolor black
    for ($i = 0; $i -le $n; $i++) 
    {
        for ($j =$i;$j -le $n; $j++) 
        {
            write-host -NoNewLine " "
        }
        for ($k =1; $k -le ((2*$i)-1);$k++)
        {
            write-host -NoNewLine "*"
        }
        write-host ""
    }
}

pyramidFactorial 5;
pause;