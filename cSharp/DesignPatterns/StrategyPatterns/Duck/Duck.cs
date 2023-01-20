using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using Duck.Interfaces;

namespace Duck
{
    public abstract class Duck
    {
        public IFlyBehavior? flyBehavior;
        public IQuackBehavior? quackBehavior;
        public abstract void display();

        //static methods on new
        public void performFly() {
            if (flyBehavior is not null)
                flyBehavior.Fly();
        }

        public void performQuack() {
            if (quackBehavior is not null)
                quackBehavior.quack();
        }

        // Setter methods, dynamic
        public void setFlyBehavior(IFlyBehavior fb) {
            flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb) {
            quackBehavior = qb;
        }

        public void swim() {
            WriteLine("All ducks float, even decoys");
        }

    }
}