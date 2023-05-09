using FightClub.Interfaces;
using FightClub.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FightClub.Models
{
    public class NPCEnemy : ILivingEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;



        public PrimaryStats primaryStats { get; set; }
        public SecondaryStats secondaryStats { get; set; }

        public void Init()
        {

            secondaryStats = new SecondaryStats()
            {
                HealthPoints  = (10 + primaryStats.Level) * primaryStats.Endurance,
                StaminaPoints = (10 + primaryStats.Level) * primaryStats.Endurance,
                Attack        = (2 + primaryStats.Level) * primaryStats.Strength,
                Defense       = (2 + primaryStats.Level) * primaryStats.Strength,
                Dodge         = (1 + primaryStats.Level) * primaryStats.Wisdom,
                CritChance    = (10 + primaryStats.Level) * primaryStats.Wisdom

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
