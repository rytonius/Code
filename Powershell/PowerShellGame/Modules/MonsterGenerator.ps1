#monster class needs a skill array, attack will be default; then skills specific to that monster would be added
class MonsterClass {
            
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
    [int]$silver
    [String]$Mskills

    MonsterClass(
        
        [string]$name,
        [int]$lvl,
        [int]$hpMax,
        [int]$mpMax,
        [int]$ATT,
        [int]$DEF,
        [int]$AGI,
        [int]$Mag,
        [int]$XP,
        [int]$silver
       
            
    ){
        # 10..30 |foreach {$_/10} | get-random
        $this.Name = $name
        $this.lvl = $lvl
        $this.hpMax = $hpMax * (0.9,1,1.1| get-random) + ([math]::round($lvl*(85..115 |foreach-object {$_/10} | get-random)))
        $this.Hp = $this.hpMax
        $this.mpMax = $mpMax * (0.9,1,1.1| get-random) + ([math]::round($lvl*(39..61 |foreach-object {$_/10}| get-random)))
        $this.Mp = $this.mpMax
        $this.Att = $ATT * (0.9,1,1.1| get-random) + ([math]::round($lvl*(0.7,0.8,0.9,1 | get-random)))
        $this.DEF = $DEF * (0.9,1,1.1| get-random) + ([math]::round($lvl*(0.7,0.8,0.9,1 | get-random)))
        $this.AGI = $AGI * (0.9,1,1.1| get-random) + ([math]::round($lvl*(0.7,0.8,0.9,1 | get-random)))
        $this.MAG = $mag * (0.9,1,1.1| get-random) + ([math]::round($lvl*(0.7,0.8,0.9,1 | get-random)))
        $this.XP = $XP * (0.9,1,1.1| get-random) + ([math]::round($lvl*(1,1.1,1.2| get-random)))
        $this.silver = $silver * (10..30 | foreach-object {$_/10}|get-random) + ([math]::round($lvl*(10..20 |foreach-object {$_/10} | get-random)))
    }
}

function Generate-monsterWoods {
    [int]$monsterlvl = ((1..2 | get-random) + [system.math]::Floor($you.Lvl/2))
    # Monsters                              (  Name,   Lvl,        HP, MP,ATT,DEF,AGI,Mag,XP, silver )
    $m = import-csv "./databases/monstersDatabase.csv" | Where-Object {$_.location -eq "woods"} | get-random
    $script:monster = [monsterclass]::new($m.name,$monsterlvl,$m.hpmax,$m.mpmax,$m.att,$m.def,$m.agi,$m.mag,$m.xp,$m.silver)
    
    
}

function generate-monsterCaves {
    [int]$monsterlvl = ((3..5 | get-random) + [system.math]::Floor($you.Lvl/2))
    # Monsters                              (  Name,   Lvl,        HP, MP,ATT,DEF,AGI,Mag,XP, silver )
    $m = import-csv "./databases/monstersDatabase.csv" | Where-Object {$_.location -eq "caves"} | get-random
    $script:monster = [monsterclass]::new($m.name,$monsterlvl,$m.hpmax,$m.mpmax,$m.att,$m.def,$m.agi,$m.mag,$m.xp,$m.silver)

}