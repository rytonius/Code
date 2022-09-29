
 function scalevalues {
param ([int]$level,[int]$strvalue)

[float]$rounding = ($level * 0.25)

return ( 10  +  ( $strvalue * (9 + $rounding  ) ) )
 }
