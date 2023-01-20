using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duck.Interfaces;

namespace Duck
{
    public class NoWingsNoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}