using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession : Notification
    {
        private Location _currentLocation;
        public World CurrentWorld { get; set; }
        
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation
        {
            get => _currentLocation;
            set {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToSouth");
                OnPropertyChanged("HasLocationToUp");
                OnPropertyChanged("HasLocationToDown");
                }
        }
       
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
                // init world factory and create world
                WorldFactory factory = new WorldFactory();
                CurrentWorld = factory.CreateWorld();

                CurrentLocation = CurrentWorld.LocationAt(xCoordinate: 0, yCoordinate: -1, zCoordinate: 0);


            }

        }

        public bool HasLocationToNorth => CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate +1, CurrentLocation.ZCoordinate) != null;
        public bool HasLocationToWest => CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate) != null;
        public bool HasLocationToEast => CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate) != null;
        public bool HasLocationToSouth => CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1, CurrentLocation.ZCoordinate) != null;
        public bool HasLocationToUp => CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate + 1) != null;
        public bool HasLocationToDown => CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate - 1) != null;
        public void MoveNorth()
        {

            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1, CurrentLocation.ZCoordinate);
            
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate);
            
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate);
            
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1, CurrentLocation.ZCoordinate);
            
        }
        public void MoveUp()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate + 1);
           
        }
        public void MoveDown()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate, CurrentLocation.ZCoordinate - 1);
            
        }



    }
}
