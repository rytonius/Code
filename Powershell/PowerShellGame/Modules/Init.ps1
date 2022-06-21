<#
changes needed, classes have STR and INT that will give a bonus to ATT+DEF and MAG+WIS (physical,magical attack/defense)
STR = bonus to Attack and Defense, items would give the majority to these stats
INT = bonus to Magic attack and magic defense (WIS?)

Player class needs to hold items and skills ala magic
Monster class needs array for skills that each monster may have (attack default)
#>

function global:Get-Init {
    
    begin {
        class PlayerItem {
            [string]$itemname
            [int]$hpMax             
            [int]$mpMax            
            [int]$ATT
            [int]$DEF 
            [int]$AGI
            [int]$Mag

            PlayerItem(){
                $this.itemname = 'none'
                $this.hpMax = 0             
                $this.mpMax = 0           
                $this.ATT = 0
                $this.DEF = 0
                $this.AGI = 0
                $this.Mag = 0   

            }
            PlayerItem(
                [string]$itemname,
                [int]$hpMax,      
                [int]$mpMax,    
                [int]$ATT,
                [int]$DEF,
                [int]$AGI,
                [int]$Mag
            ){
                $this.itemname = $itemname
                $this.hpMax = $hpMax    
                $this.mpMax = $mpMax
                $this.att = $ATT
                $this.def = $DEF
                $this.agi = $AGI
                $this.mag = $mag
            }
        }
        
        class PlayerClass {
            
            [string]$name
            [int]$LVL
            [int]$hpMax
            [int]$HP 
            [int]$mpMax
            [int]$MP
            [int]$ATT
            [int]$DEF 
            [int]$AGI
            [int]$Mag
            [int]$XP
            [int]$XPmax
            [int]$Silver
            [string[]]$skills= @()
            [PlayerItem]$Weapon = [PlayerItem]::new()
            [PlayerItem]$Armor = [PlayerItem]::new()

            playerClass(){
                $this.Name = 'NoName'
                $this.lvl = 1
                $this.hpMax = ([math]::round(10 * (84..126 | foreach-object {$_/10} | get-random)))
                $this.Hp = $this.hpMax
                $this.mpMax = ([math]::round(5 * (84..126 | foreach-object {$_/10} | get-random)))
                $this.Mp = $this.mpMax
                $this.Att = ([math]::round(0 + (84..126 | foreach-object {$_/10} | get-random)))
                $this.DEF = ([math]::round(0 + (84..126 | foreach-object {$_/10} | get-random)))
                $this.AGI = ([math]::round(0 + (84..126 | foreach-object {$_/10} | get-random))) 
                $this.MAG = ([math]::round(0 + (84..126 | foreach-object {$_/10} | get-random))) 
                $this.XP = 0
                $this.XPmax = 50
                $this.silver = 10

            }

            PlayerClass(
                
                [string]$name,
                [int]$lvl,
                [int]$hpMax,
                [int]$hp,
                [int]$mpMax,
                [int]$mp,
                [int]$ATT,
                [int]$DEF,
                [int]$AGI,
                [int]$Mag,
                [int]$XP,
                [int]$XPmax,
                [int]$Silver
                
              #  [playeritem]$armor
                  
            ){
                
                $this.Name = $name
                $this.lvl = $lvl
                $this.hpMax = $hpMax 
                $this.Hp = $hp
                $this.mpMax = $mpMax 
                $this.Mp = $mp
                $this.Att = $ATT 
                $this.DEF = $DEF 
                $this.AGI = $AGI 
                $this.MAG = $mag 
                $this.XP = $XP
                $this.XPmax = $XPmax
                $this.silver = $Silver                
            }
        }
                
        $initcheck = 0
        
    }

    
    process 
    {
        # you                           (  Name, Lvl, HP, MP, ATT, DEF, AGI, MAG)
        $script:You = [PlayerClass]::new()
        
        
        while ($initcheck -eq 0)
            {
                $NeworLoad = Read-host "`nNew Game or loading?`n`n1. [New Game]`n2. [Load Game]`n`nChoice"
                if ($neworload -match "1") 
                {                   
                    [string]$script:youname = read-host "`nName Your Character"
                    $you.name = $($youname)
                    
                    $initcheck = 1

                }
                if ($neworload -match "2")
                {                    
                    $savedgames = @(get-childitem ./saves | select -expand name) 
                    write-host "`nhere are the saved game files :"
                    $savedgames
                    $loadgame = read-host "`ntype in name of save game (you will need the .csv in name)"
                    if ($savedgames -contains $loadgame) {
                        $loadgame = import-csv ./saves/$loadgame
                        # you                           (  Name, Lvl, HP, MP, ATT, DEF, AGI, MAG)
                        $script:You = [PlayerClass]::new("$($loadgame.name)", $($loadgame.lvl) , $($loadgame.hpMax), $($loadgame.hp), $($loadgame.mpMax), $($loadgame.mp), $($loadgame.att), $($loadgame.def),$($loadgame.agi),$($loadgame.mag),$($loadgame.xp),$($loadgame.xpmax),$($loadgame.silver))
                        $script:you.name = $loadgame.Name
                        $script:you.lvl = $loadgame.Lvl
                        $script:you.hpmax = $loadgame.hpmax
                        $script:you.hp = $loadgame.hp
                        $script:you.mpmax = $loadgame.mpmax
                        $script:you.mp = $loadgame.mp
                        $script:you.att = $loadgame.att
                        $script:you.def = $loadgame.def 
                        $script:you.agi = $loadgame.agi 
                        $script:you.mag = $loadgame.mag 
                        $script:you.xp = $loadgame.xp 
                        $script:you.xpmax = $loadgame.xpmax 
                        $script:you.silver = $loadgame.silver
                        #$script:you.weapon.itemname = $loadgame.weaponname
                        #$script:you.armor.itemname = $loadgame.armorname
                        $initcheck = 1
                    } else {clear-host}
                                      
                }
            }
        [playerclass]::new()
        

       
    }
    
}
