﻿using FightClub.Interfaces;
using FightClub.Structures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FightClub.Models
{
	public class Player : ILivingEntity
	{
		public int Id { get; set; }

		public string Name {
			get; set;
		}


		PrimaryStats primaryStats;
		SecondaryStats secondaryStats;

		public Player(int ID, string NAME)
		{
			Id = ID;
			Name = NAME;
			primaryStats = new PrimaryStats()
			{
				Endurance = 1,
				Strength = 1,
				Agility = 1,
				Wisdom = 1
			};
			secondaryStats = new SecondaryStats() 
			{
				HealthPoints = 100,
				StaminaPoints = 100,
				ExperiencePoints = 0,
				Attack = 10,
				Defense = 10,
				Dodge = 10,
				CritChance = 10,
				Gold = 10,
				Level = 1
			};

		}

		public void GetStats()
		{

			Console.WriteLine("Id: " + Id);
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Primary Stats:");
			// Print out all the properties of primaryStats using a foreach loop
			foreach (FieldInfo prop in primaryStats.GetType().GetFields())
			{
                Console.WriteLine(prop.Name + ": " + prop.GetValue(primaryStats));
			}
			// Print out all the properties of secondaryStats using a foreach loop
			Console.WriteLine("Secondary Stats:");
			foreach (FieldInfo prop in typeof(SecondaryStats).GetFields())
			{
				Console.WriteLine(prop.Name + ": " + prop.GetValue(secondaryStats));
			}
		}

		
	}
}
