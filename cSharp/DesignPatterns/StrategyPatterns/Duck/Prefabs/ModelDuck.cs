using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duck.Prefabs
{
    public class ModelDuck : Duck
    {
        public ModelDuck() 
        {
            flyBehavior = new NoWingsNoFly();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("\n\"I'm a Super Model Duck\"");
        }
    }
}