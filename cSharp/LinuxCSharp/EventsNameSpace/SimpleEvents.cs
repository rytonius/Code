using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleEvents
{
    public class Cat
    {
        private string _name = "bobby";
        public int ID { get; set; }
        public string Name { get => _name; set => _name = value; }
        private int _health;
        public event EventHandler<int>? OnHealthChanged;

        public int Health
        {
            get => this._health;
            set
            {
                this._health = value;
                this.OnHealthChanged?.Invoke(this, this._health);
                
            }
        }


    }

    public class DoIt
    {
        Cat cat = new Cat
        {
            ID = 1,
            Name = "Mr. BoJangles",
            Health = 100
        };
        Cat cat2 = new Cat
        {
            ID = 2,
            Name = "Mrs. BoMangles",
            Health = 100
        };
        public void RunIt()
        {
            cat.OnHealthChanged += (sender, _health) =>
            {
                Cat cat = (Cat)sender;
                if (cat.Health > 0)
                    Console.WriteLine($"ID: {(cat).ID} cat: {cat.Name} now has health: {cat.Health}");
            };
            cat2.OnHealthChanged += (sender, _health) =>
            {
                Cat cat = (Cat)sender;
                if (cat.Health > 0)
                    Console.WriteLine($"ID: {(cat).ID} cat: {cat.Name} now has health: {cat.Health}");
            };
            List<Cat> ListCats = new List<Cat>();
            ListCats.Add(cat);
            ListCats.Add(cat2);
            foreach (Cat c in ListCats)
            {
                c.OnHealthChanged += OnDead;
            }
            cat.Health = 200;

            cat.Health = 0;

            cat2.Health = 0;
            cat2.Health = -25;
            cat2.Health = 500;
        }

        private static void OnDead(object? sender, int _health)
        {

            Cat cat = (Cat)sender;
            if (cat.Health <= 0)
                Console.WriteLine($"ID: {(cat).ID} cat: {cat.Name} Health: {cat.Health} has perished");

        }


    }
}