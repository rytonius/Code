using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duck.Prefabs
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("\n\"I'm a Mallard Duck\"");
        }
    }
}