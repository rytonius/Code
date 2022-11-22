using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : Stats
    {
        public string? Name { get; set; }
        public string? CharacterClass { get; set; }
        public int Level { get; set; }
        public float XPtillNextLvl { get; set; }
        
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        public int gold;
        public string GoldString 
        { 
            get { return String.Format("{0:C}", gold);}
        }
    }

    public class Stats 
    {
        public int HitPoints { get; set; }
        public int StamPoints { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Evade { get; set; }
        public int BonusAccuracy { get; set; }

    }

}
