
function global:Get-PlayerStats {
    $addItemTotal = {param($x, $y)$x + $y}
    
    
    write-host ""
    write-host "Name:   $($you.name)"
    Write-Host "HP:     $($you.Hp) / $($you.hpMax)"
    Write-Host "MP:     $($you.MP) / $($you.mpMax)"
    Write-Host "ATT:    $($you.Att)" +, (&$addItemTotal $($you.weapon.att) $($you.armor.att))
    write-host "DEF:    $($you.DEF)" +, (&$addItemTotal $($you.weapon.def) $($you.armor.def))
    write-host "AGI:    $($you.AGI)" +, (&$addItemTotal $($you.weapon.agi) $($you.armor.agi))
    Write-Host "Mag:    $($you.MAG)" +, (&$addItemTotal $($you.weapon.mag) $($you.armor.mag))
    write-host "LVL:    $($you.LVL)"
    write-host "XP:     $($you.XP) / $($you.xpmax)"
    write-host "Silver: $($you.silver)"
    ""
    write-host "Weapon: $($you.weapon.itemname)"  
    write-host "Armor: $($you.armor.itemname)"
}

function global:set-playerlevelup {
            
            $you.lvl += 1
            $you.hpMax += ([math]::round($($you.lvl)*(8.9,9.8,10.7 | get-random)))                
            $you.mpMax += ([math]::round($($you.lvl)*(4.1,5.2,6.3 | get-random)))                
            $you.Att += ([math]::round($($you.lvl)*(0.7,0.8,0.9 | get-random)))
            $you.DEf += ([math]::round($($you.lvl)*(0.7,0.8,0.9 | get-random)))
            $you.AGI += ([math]::round($($you.lvl)*(0.7,0.8,0.9 | get-random)))
            $you.MAG += ([math]::round($($you.lvl)*(0.7,0.8,0.9 | get-random)))
            $you.xpmax += ($you.lvl * 9)
            

            Get-PlayerStats
            
            $levelupchoice = 0
            while ($levelupchoice -eq 0){
                write-host "`nyou may now bump 1 stat of your choosing`n`.Level * `n1.HP +10,`n2. MP +5,`n3. Att +1,`n4. Def +1,`n5. Agi +1`n6. Mag +1"
                $menuLevelup = read-host "which stat to increase?"
                if ($menuLevelup -match [int]1) {$you.hpmax += ($you.lvl * 10); $levelupchoice = 1}
                if ($menuLevelup -match [int]2) {$you.mpmax += ($you.lvl * 5); $levelupchoice = 1}
                if ($menuLevelup -match [int]3) {$you.att += $you.lvl; $levelupchoice = 1}
                if ($menuLevelup -match [int]4) {$you.def += $you.lvl; $levelupchoice = 1}
                if ($menuLevelup -match [int]5) {$you.agi += $you.lvl; $levelupchoice = 1}
                if ($menuLevelup -match [int]6) {$you.mag += $you.lvl; $levelupchoice = 1}
                else {"`n... try again`n"}
            }
            

            $you.Hp = $you.hpMax
            $you.Mp = $you.mpMax
            
            Menu


}

function Player-Magic {
        begin {
            $script:playerSkill = import-csv "./Databases/playerMagic.csv"
             $castspell = 0
            }
       
        
               
        process {
            while ($castspell -eq 0){
                write-host "`nMagic Spells:`n" -ForegroundColor gray
                
                write-host "$($playerskill| select-object id, name, mpcost, power|out-string)"
                
                Write-host "`nEnter a number for your choice, any letter will go back" -ForegroundColor green -BackgroundColor black
                
                [string]$choice = read-host "Enter Choice "
                
                if ($choice -match '[a-zA-Z]')
                {
                    write-host "going back"; start-sleep 1; menu-battle                    
                    
                } else {[int]$choice -= 1
                    
                if ($choice -match '^\d{1}' -and $Playerskill.id[$choice])
                {
                    $castspell = 1
                    clear-host
                    [boolean]$script:self = [system.boolean]$playerskill.self[$choice]
                    [int]$script:skillDamage = $you.mag * $playerSkill.power[$choice]
                    [int]$script:SkillMPCost = $playerSkill.mpcost[$choice]
                    [string]$script:MagicName = $playerskill.name[$choice]
                    if ($self -eq $true) {write-host "You cast $MagicName on yourself!`n" -ForegroundColor yellow} else {write-host "You cast $magicName at $($monster.name)!`n" -ForegroundColor yellow}
                    battle-turn -turn you -AttackType magic -self $self
                    
                }
                else 
                {
                    write-host "No Magic Selected" -ForegroundColor red -BackgroundColor black; start-sleep 1;continue
                }  
            }    
        }    
    }
}        
            
function get-playerItem {
    $equippedItems = @()
    $equippeditemscolumns = new-object PSobject
    $equippeditemscolumns | add-member -type NoteProperty -name 'Itemname' -value 'itemname'
    $equippeditemscolumns | add-member -type NoteProperty -name 'hpMax' -value 'hpMax'
    $equippeditemscolumns | add-member -type NoteProperty -name 'mpMax' -value 'mpMax'
    $equippeditemscolumns | add-member -type NoteProperty -name 'ATT' -value 'Att'
    $equippeditemscolumns | add-member -type NoteProperty -name 'DEF' -value 'DEF'
    $equippeditemscolumns | add-member -type NoteProperty -name 'Agi' -value 'AGi'
    $equippeditemscolumns | add-member -type NoteProperty -name 'Mag' -value 'Mag'
    $equippeditems += $equippeditemscolumns
    $equippeditems += $you.Weapon
    $equippeditems += $you.Armor
    $equippeditems

}