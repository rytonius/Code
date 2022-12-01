﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location : Notification
    {
        string _name;
        string _description;
        string _imageName;
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int ZCoordinate { get; set; }
        public string Name { get => _name; set { _name = value; OnPropertyChanged(nameof(Name));  } }
        public string Description { get => _description; set { _description = value; OnPropertyChanged(nameof(Description)); } }
        public string ImageName { get => _imageName; set { _imageName = value; OnPropertyChanged(nameof(ImageName)); } }
        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();
    }
}
