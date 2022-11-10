using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructorsIndexers
{
    partial class PartialClasses
    {
        public void Output1(int inVal) {Console.WriteLine("value: {0}", inVal);}
    }

    partial class PartialClasses {
        public void Output2(string name) { Console.WriteLine("name: {0}", name);}
    }
    public static class RunPartial {
        public static void RunThatClass() {
            PartialClasses PC = new PartialClasses();

            PC.Output1(5); 
            PC.Output2("berry");

            Console.WriteLine("Partial method class");

            var PMC = new PartialMethodClass();

            PMC.Add(5, 6);
        }
    }

    // Example of partial method, which are imlicitly private
    partial class PartialMethodClass {
        //Contextual keyword, must be void
        partial void PrintSum(int x, int y);  // defining partial method
        public void Add(int x, int y) {
            PrintSum(x, y);
        }

    }
    partial class PartialMethodClass {
        partial void PrintSum(int x, int y)
        {
            Console.WriteLine("Sum is {0}", x + y);
        }
    }
}