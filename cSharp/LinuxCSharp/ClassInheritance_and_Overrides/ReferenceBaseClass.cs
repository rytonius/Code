using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassInheritance_and_Overrides
{
    class MyBaseClass
    {
        public void Print() {
            Console.WriteLine("This is the base class.");
        }
    }

    class MyDerivedClass : MyBaseClass {
        public int var1;
        new public void Print() {
            Console.WriteLine("This is the derived class.");
        }
    }

    public static class RunIt{
        public static void RunMethod() {
            MyDerivedClass derived = new MyDerivedClass();
            MyBaseClass mybc = (MyBaseClass)derived;

            derived.Print();         //Call Print from derived portion.
            mybc.Print();            // Call Print from base portion
            // mybc.var1 = 5;        // Error: base class reference cannot access derived class members
        }
    }

}