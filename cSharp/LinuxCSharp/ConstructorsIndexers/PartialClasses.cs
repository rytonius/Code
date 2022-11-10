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
        }
    }
}