
function get-battle {
  # when you select 1. Fight, it will call this function which will select location and then monsters
  Param($location)

  

  if ($location -match "woods") {Generate-monsterWoods; Menu-Battle}
  if ($Location -match "caves") {Generate-monsterCaves; Menu-Battle}
  else {read-host "something went wrong"; menu}
}



function Battle-Options {
    #pretty pointless, function for your battle options, probably doesn't need to be a function?
    $script:battleMenu = @()
    $battlemenu += "1: [Attack] "
    $battlemenu += "2: [Magic] "
    $battlemenu += "3: [Item] "
    $battlemenu += "4: [Flee] "

    $battlemenu
}


function Menu-Battle {
    # the battle loop
    start-sleep -Milliseconds 100;
    if ($script:firstenterBattle -eq $true) {clear-host}    
    if ($script:firstenterBattle -eq $false) {start-sleep -Milliseconds 500}
    $script:firstenterBattle = $false
    
    while ($you.hp -gt 0 -and $monster.hp -gt 0) 
    {
        write-host ""
        $you, $monster |select-object name,lvl, hp, mp, att, def, agi, mag, XP|Format-Table
        write-host "(====={:::::;;;;;;;;;;;;;;>" -BackgroundColor black -ForegroundColor red
        write-host "Name: [ $($you.name) ]---------------[ $($monster.name) ]"
        write-host "LVL:  [ $($you.LVL) ]-------------------[ $($monster.LVL) ]"
        Write-Host "HP:   [ $($you.Hp) / $($you.hpMax) ]-----------[ $($monster.hp) / $($monster.hpmax) ]"
        Write-Host "MP:   [ $($you.MP) / $($you.mpMax) ]------------[ $($monster.MP) / $($monster.mpmax) ]"
        Write-Host "Att:  [ $($you.Att) ]------------------[ $($monster.ATT) ]"
        write-host "Def:  [ $($you.DEF) ]------------------[ $($monster.DEF) ]"
        write-host "AGI:  [ $($you.AGI) ]------------------[ $($monster.agi) ]"
        write-host "MAG:  [ $($you.MAG) ]------------------[ $($monster.MAG) ]"
        write-host "XP:   [ $($you.XP) ]------------------[ $($monster.XP) ]"
        write-host "0000000000000000[==========`n" -BackgroundColor black -ForegroundColor red
        write-host ""
        
        
        
        if ( $you.hp -gt 0)
        {
            Battle-Options
            [int]$battlechoice = read-host "`nchoose command"
            if ($battlechoice -match [int]1 -or $battlechoice -contains "") {
                clear-host
                write-host "`nyou chose to attack!`n" -ForegroundColor yellow; battle-turn -turn you -attacktype normal
                
            }
            if ($battlechoice -match [int]2)
            {
               Player-Magic
                
            }
            elseif ($battlechoice -match [int]3)
            {
                
                write-host "items doesn't exist";start-sleep 1; menu-battle
            }
            elseif ($battlechoice -match [int]4)
            {
                write-host "you ran away, and lost %50 health!";$you.hp = ($you.hp/2);start-sleep 1; menu
            }
        if ( $monster.hp -gt 0) {start-sleep -Milliseconds 800;monster-ai}

        }
    }
    if ( $you.hp -le 0) {write-host "you died";Menu}
    if ( $monster.hp -le 0) {write-host "monster died, you gained $($monster.xp) XP points!";$you.xp += $monster.xp
                            write-host "Gained Silver $($monster.silver)";$you.silver += $monster.silver ;read-host "hit enter to head back to town";
                            ;menu}
}

function Global:Battle-Turn {
    param (
        [string]$turn,
        [string]$AttackType,
        [boolean]$self
    )
    
    if ($turn -match "you")
    {
        $script:attacker = $you
        $script:defender = $monster
    }
    if ($turn -like "monster") 
    {  
        $script:attacker = $monster
        $script:defender = $you 
    }
    if ($attacktype -match "normal")
    {
        
        
        #roll the dice, 1-20 + attacker agi - defenger agi
        $diceroll = (1..20 | get-random) + ((1..$attacker.agi | get-random) - (1..$defender.agi | get-random))
        #damage calculations is 1..attack damage - 1..defender def / half of dice roll
        $halfattack = ($attack.att/2)
        $halfDefense = ($defender.def/2)
        write-host "DiceRoll: $diceroll"
        #dice roll under 0, then it's a miss
        if ($diceroll -le [int]0) {write-host "$($attacker.name) has missed!" -ForegroundColor red}
        #standard hit with the dice roll
        if ($diceroll -ge [int]1 -and $diceroll -le [int]19)
        {
            $damagecalc = ($halfAttack..$attacker.att | get-random) - (($halfDefense..$defender.def | get-random) / ($diceroll/6))
            write-host "$($attacker.name) has hit $($defender.name)" -ForegroundColor green 
            
            $damage = [system.math]::round($damagecalc, 0)
            
            if ($damage -le 0) {$damage = 0; write-host "$($defender.name) has blocked the attack!" -ForegroundColor red}
            if ($damage -ge 1) {$defender.hp -= $damage;write-host "Damage: $damage" -ForegroundColor green}
        }
        #critical damagage if the roll is over 20
        if ($diceroll -ge [int]20)
        {
            $damagecalc = ($halfAttack..$attacker.att | get-random) - (($halfDefense..$defender.def | get-random) / ($diceroll/4))
            write-host "$($attacker.name) has Crit $($defender.name)" -ForegroundColor green -BackgroundColor black
            $damagecalc = $damagecalc * 2
            
            $damage = [system.math]::round($damagecalc, 0)
            
            if ($damage -le 0) {$damage = 0; write-host "$($defender.name) has blocked the attack!" -ForegroundColor red}
            if ($damage -ge 1) {$defender.hp -= $damage;write-host "Damage: $damage !!!" -ForegroundColor green -BackgroundColor Black}

        }
    }
    if ($attacktype -match "magic")
    {
        if ($self -eq $true)
        {
            
            if ($attacker.mp -ge $skillMPcost) 
            {
                
                $attacker.mp -= $skillMPcost
                $halfSkillDamage = ($skilldamage/2)
                $healCalc = ($halfSkillDamage)..($skilldamage) | get-random; $you.hp += $healCalc
                if ($you.hp -gt $you.hpmax) {$you.hp = $you.hpmax}
                write-host "you healed $healcalc HP" -ForegroundColor green
            } else {write-host "not enough MP!" -ForegroundColor red}

        }
        if (!($self))
        {
            
            if ($attacker.mp -ge $skillMPcost) 
            {
                $attacker.mp -= $skillMPcost
                
                $halfSkillDamage = ($skilldamage/2)
                $halfDefenderMag = ($defender.mag/2)
                $MagicCalc = ((($halfSkillDamage..$skilldamage) |get-random) - (($halfDefenderMag..$defender.mag) | get-random))
                
             
                if ($magicCalc -ge 1)
                {   
                    $defender.hp -= $MagicCalc;
                    write-host "you did $magiccalc damage to $($defender.name)" -ForegroundColor green 
                } else {write-host "Not enough POWA, $($defender.name) Blocked it!" -ForegroundColor red}
                
                
            } else {write-host "not enough MP!" -ForegroundColor red}
            
        }
        
    }
}

   




function Monster-AI {
    #this is where the monster AI will end up, theory would be have the class retain monster skills, by using array inside of class

    $script:monsterSkills = "attack"
    if ($monsterskills -match "attack")
    {
        write-host "`nmonster chose to attack!`n" -ForegroundColor yellow ;battle-turn -turn monster -attacktype normal; menu-battle
    }
}