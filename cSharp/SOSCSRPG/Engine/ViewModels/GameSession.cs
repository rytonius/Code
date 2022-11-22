using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            { // start new game, so make a player
                CurrentPlayer = new Player()
                {
                    Name = "John Snow",
                    CharacterClass = "Fighter",
                    Level = 1,
                    Strength = 2,
                    Dexterity = 1,
                    Endurance = 2,
                    gold = 100_000_000

                };

                CurrentPlayer.HitPoints += 10 + (CurrentPlayer.Endurance * 2);
                CurrentPlayer.StamPoints += 10 + (CurrentPlayer.Dexterity + CurrentPlayer.Strength);
                CurrentPlayer.Attack += CurrentPlayer.Strength * 2 + CurrentPlayer.Dexterity;
                CurrentPlayer.Defense += CurrentPlayer.Dexterity + CurrentPlayer.Endurance * 2;
                CurrentPlayer.Evade += CurrentPlayer.Dexterity;
                CurrentPlayer.BonusAccuracy+= CurrentPlayer.Dexterity;
                CurrentPlayer.XPtillNextLvl = (float)Math.Round((CurrentPlayer.Level * 40f) * (1.1f), 0);
                
            }

        }
    }
}
