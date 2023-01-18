using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Duck
{
    public abstract class Duck
    {
        public IFlyBehavior? flyBehavior;
        public IQuackBehavior? quackBehavior;
        public abstract void display();

        public void performFly() {
            if (flyBehavior is not null)
                flyBehavior.fly();
        }

        public void performQuack() {
            if (quackBehavior is not null)
                quackBehavior.quack();
        }

        public void swim() {
            WriteLine("All ducks float, even decoys");
        }

    }
}