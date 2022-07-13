function global:Menu {
    # Main menu you end up between options
        clear-host
        $script:menuOptions = [System.Array]@()
        $menuOptions += "1:[Fight] "
        $menuOptions += "2:[Inn] "
        $menuOptions += "3:[Shop] "
        $menuOptions += "4:[Tower] "
        $menuOptions += "9:[Save] "
        $menuOptions += "0:[Exit] "

        #check if level up
        if ($you.xp -ge $you.xpmax) {
            $you.xp -= $you.xpmax
            write-host "`nyou leveled up!`n`n" -ForegroundColor yellow; start-sleep -Milliseconds 500
            set-playerlevelup
            write-host "now level: $($you.lvl)`n`n" -ForegroundColor Green -BackgroundColor White;
            
            }

        
        Get-PlayerStats
        $menuOptions | foreach-object {write-host $_}
        
        $selectMenu = read-host "`nPress one of the 3 values and hit enter"
        switch ($selectMenu) 
        {

            
        1   {
                [boolean]$script:firstenterBattle = $true;
                $travel = read-host "Travel to where?`n`n1: [woods] lvl: 1-5`n2: [caves] lvl: 5-10`nenter 1-9 and hit enter"
                if ($travel -contains "1") {write-host "`nheading outside the walls...";start-sleep 1; get-battle -location "woods"}
                if ($travel -contains "2") {write-host "`nheading outside the walls...";start-sleep 1; get-battle -location "caves"}
                else {"`nI don't know what you want"; start-sleep 1; menu}
            }

            
        2   {   
                [int]$costofInn = (($you.lvl * 5) + 5)
                $sleepinInn = read-host "`nresting will cost $costofInn silver, Sleep? 'y' to accept"
                if ($sleepinInn -contains "y" -and $you.silver -ge $costofinn)
                {
                    $you.silver -= $costofinn
                    write-host "`nheading to the local inn"
                    write-host "`nresting will heal you and restore mana";$you.hp = $you.hpmax;$you.mp = $you.mpmax; write-host "sleep well...";
                    start-sleep -Milliseconds 500;read-host "hit enter to wake up"; menu
                } else {write-host "guess your to cheap to sleep";start-sleep 1;menu}
                
            }
        3{write-host "`nComing Soon!" -ForegroundColor yellow; Menu}
        4{write-host "`nComingSoon!"-ForegroundColor yellow; menu }  
           
        9   {
                write-host "`nSaving Game`n"
                if (!(test-path ".\saves")) {mkdir ".\saves"}
                $you | export-csv -path ".\saves\$($you.name).csv" -NoTypeInformation
                if (!(test-path ".\saves\$($you.name).csv")) {write-host "save failed"} else {write-host "Save Complete"}
                start-sleep 1
                menu
            }

            
        0   {
                clear-host ; $confirmQuit = read-host "`nConfirm quit? (Y to Exit)";
                if ($confirmQuit -match "y") { start-sleep 2; exit}
                else {menu}
            }
        

        default {write-host "`nplease select a number from the menu`n" -ForegroundColor yellow ;start-sleep 1; Menu}
    }
}