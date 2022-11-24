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
        public Location? CurrentLocation { get; set; }
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
                    GoldString = "10.00"

                };
                // initialize secondary stats
                CurrentPlayer.HitPoints += 10 + (CurrentPlayer.Endurance * 2);
                CurrentPlayer.StamPoints += 10 + (CurrentPlayer.Dexterity + CurrentPlayer.Strength);
                CurrentPlayer.Attack += CurrentPlayer.Strength * 2 + CurrentPlayer.Dexterity;
                CurrentPlayer.Defense += CurrentPlayer.Dexterity + CurrentPlayer.Endurance * 2;
                CurrentPlayer.Evade += CurrentPlayer.Dexterity;
                CurrentPlayer.BonusAccuracy+= CurrentPlayer.Dexterity;
                CurrentPlayer.XPtillNextLvl = (int)Math.Round((CurrentPlayer.Level * 40f) * (1.1f), 0);

                // Location start
                CurrentLocation = new Location();
                CurrentLocation.Name = "Home Sweet Home";
                
                CurrentLocation.XCoordinate = 0;
                CurrentLocation.YCoordinate = -1;
                CurrentLocation.Description = "This is your home, you have 17 kids from a woman named MARTHA";
                CurrentLocation.ImageName = "pack://application:,,,/Engine;component/Images/Locations/Home.jpg";
                //pack://application:,,,/Engine;component/Images/Locations/Home.jpg
                //{Binding CurrentLocation.ImageName}

            }

        }
    }
}
