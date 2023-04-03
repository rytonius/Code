using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duck.Interfaces;

namespace Duck
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with rockets! To the moon Baby!\nOh No a Plane Ahhhhhh....");
        }
    }
}