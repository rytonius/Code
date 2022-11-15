using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassInheritance_and_Overrides
{
    class MyData
    {
        private double D1;
        private double D2;
        private double D3;

        public MyData(double d1, double d2, double d3)
        {
            D1 = d1; D2 = d2; D3 = d3;
        }

        public double Sum()
        {
            return D1 + D2 + D3;
        }
    }

    static class ExtendMyData {
                                    // instance of MyData Class
        public static double Average(MyData md ) {
            return md.Sum() / 3;
        }
    }
    static public class ExtensionMethods
    {
        public static void RunIt() {
            MyData md = new MyData(3, 4, 5);                // Instance of MyData
            Console.WriteLine("Average: {0}", ExtendMyData.Average(md));

            SealedMyData Smd = new SealedMyData( 5, 6 ,7);
            Console.WriteLine($"Sum:\t {Smd.Sum()}");
            Console.WriteLine("Average: {0}", Smd.Average()); // Invoke as an instance member of the class
        }
    }

    // another example with Instance Invocation 

    sealed class SealedMyData {
        private double D1, D2, D3;
        public SealedMyData(double d1, double d2, double d3)
        { D1 = d1; D2 = d2; D3 = d3;}

        public double Sum() {return D1 + D2 + D3; }
    }

    static class ExtendSealedMyData {
                                    // keyword and type, use 'this'
        public static double Average(this SealedMyData Smd) {
            return Smd.Sum() / 3;
        }
    }
}