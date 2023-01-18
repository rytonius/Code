using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Duck
{
    public class Quack : IQuackBehavior
    {
        public void quack() {
            WriteLine("Quack");
        }
    }
}