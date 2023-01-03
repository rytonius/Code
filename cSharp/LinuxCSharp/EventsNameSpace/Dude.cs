using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsDude
{
    internal class Dude
    {
        int _money;
        int _id = 0;
        public int ID { get => this._id; set => this._id = value; }
        public event EventHandler<int>? OnMoneyChange;
        public int Money
        {
            get => this._money;
            set
            {
                this._money = value;
                this.OnMoneyChange?.Invoke(this, this._money);
            }
        }

        public Dude() {
            this.OnMoneyChange += (source, e) => {
                Console.WriteLine($"ID: {this.ID} has ${e}");
                };
        }
    }

    public class Program
    {
        public void Main()
        {
            Dude dude1 = new Dude()
            {
                ID = 1,
                Money = 200
            };
            Dude dude2 = new Dude()
            {
                ID = 2,
                Money = 400
            };

            dude1.Money += 200;
            dude2.Money += 200;

        }


    }
}