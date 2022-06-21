set-location $PSScriptRoot
$console = $host.UI.RawUI
$size = $console.WindowSize
$size.Width = 80
$size.Height = 40
$console.WindowSize = $size
$buffer = $console.BufferSize
$buffer.Width = 80
$buffer.Height = 40
$console.BufferSize = $buffer
# https://www.itprotoday.com/powershell/powershell-basics-console-configuration



function new-game {
    
    .".\modules\init.ps1"
    .".\modules\menus.ps1"
    .".\modules\player.ps1"
    .".\modules\battle.ps1"
    .".\modules\monstergenerator.ps1"
    # this will initialize the game, by doing it this way all functions and scripts should load properly
    Write-host "`nInitializing game`n`nLoading...."
    Get-Init
    Write-host "`nLoading Complete!`n`n"
    Write-Host "    Welcome $($you.name), you lived in an orphanage all your life,
            which really really sucked. Only to grow up 
            and become the town of Eaglewood's only guard.  
            You must set out each day and defend the town
            from any monsters that may lurk nearby.  
            Also slay bad grammar. 

            note, super early alpha, nothing works except for [Fight],
            [Rest], [quit], [save]; and in battle only [attack]. 
            you will level up every 50 XP points * LvL,
            monsters will also level up at 1 + you.level / 2
            as you level up you will get natural increase of stats, 
            you will also get to select
            one stat to boost even further for that level.  
            Monsters will be worth more xp as they lvl

            Good luck!`n`n"
    write-host "Current Version 0.04 = Magic Components are in" -ForegroundColor green
    
    read-host "`nhit enter to start game, CTRL+C to exit game or exit powershell window"
    
    menu
    
}

new-game

