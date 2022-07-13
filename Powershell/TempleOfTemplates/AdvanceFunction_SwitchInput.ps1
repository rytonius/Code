Function Get-TestNumber {
<#
.SYNOPSIS
Input a $number that you can then add, subtract, multiply, divide itself into
.DESCRIPTION
This is a template to show off example of do-while and switch read-host input
.EXAMPLE
        PS> TestNumber -number 5
        press 1 to add, 2 to subtract, 3 multiply, 4 divide your number
        press [1-4]: 1
        answer for 5 when adding itself = 10
.EXAMPLE
        PS> TestNumber -number 3
        press 1 to add, 2 to subtract, 3 multiply, 4 divide your number
        press [1-4]: 3
        answer for 3 when Multiplying itself = 9
        
#>
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory=$true)]
        [int] $number,
        [Parameter(DontShow)]
        [string]$choice
        )
    
    Begin{
        try {$number -eq [int]} catch {throw "Number isn't an integer"}
    }

    Process{
        $numberPlus = $number + $number;
        write-host "press a single number then hit enter>`n[1] to add, [2] to subtract, [3] to multiply, [4] divide your number" -foreground Green
     
        do {
        $choice = Read-Host "press 1-4"; 
        if ($choice -notmatch "[1-4]"){"what is wrong with you`n"}
       
        } while ($choice -NotIn 1..4)

         switch -Wildcard ($choice)
            {
                1 {$numberPlus = $number + $number;$choice = "Adding";}
                2 {$numberPlus = $number - $number;$choice = "Subtracting";}
                3 {$numberPlus = $number * $number;$choice = "Multiplying";}
                4 {$numberPlus = $number / $number;$choice = "Dividing";}
                Default {write-warning "that was not an option, choose between 1-4"}
            }
    
    }

    End{Write-Output "answer for $number when $choice itself = $numberPlus"}
}