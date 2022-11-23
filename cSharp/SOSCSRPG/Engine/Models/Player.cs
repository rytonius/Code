using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace Engine.Models
{
    public class Player : Stats
    {

        int _level;
        int _xpTillNextLVL;
        int _str;
        int _dex;
        int _end;
        decimal _gold;

        public string? Name { get; set; }
        public string? CharacterClass { get; set; }
        public int Level
        {
            get => _level;
            set { _level = value; OnPropertyChanged("Level"); }
        }
        public int XPtillNextLvl
        {
            get =>_xpTillNextLVL; 
            set { _xpTillNextLVL = value; OnPropertyChanged("XPtillNextLvl"); }
        }

        public int Strength
        {
            get => _str;
            set { _str = value; OnPropertyChanged("Strength"); }
        }
        public int Dexterity
        {
            get => _dex; 
            set { _dex = value; OnPropertyChanged("Dexterity"); }
        }
        public int Endurance
        {
            get => _end; 
            set { _end = value; OnPropertyChanged("Endurance"); }
        }

        public string GoldString
        {
            get { return String.Format("{0:C2}", _gold); }
            set { _gold = Convert.ToDecimal(value); }
        }

    }

    public class Stats : Notification
    {
        int _hp;
        int _sp;
        int _att;
        int _def;
        int _ev;
        int _ba;

        public int HitPoints
        {
            get => _hp;
            set { _hp = value; OnPropertyChanged("Hitpoints"); }
        }
        public int StamPoints {
            get => _sp; 
            set { _sp = value; OnPropertyChanged("StamPoints"); } 
        }
        public int Attack { 
            get => _att; 
            set { _att = value; OnPropertyChanged("Attack"); } 
        }
        public int Defense {
            get => _def; 
            set { _def = value; OnPropertyChanged("Defense"); } 
        }
        public int Evade { 
            get => _ev; 
            set { _ev = value; OnPropertyChanged("Evade"); } 
        }
        public int BonusAccuracy { 
            get => _ba; 
            set { _ba = value; OnPropertyChanged("BonusAccuracy"); } 
        }

    }

    public class Notification : INotifyPropertyChanged
    {   // required to notify when a value changes to update the WPFUI
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
