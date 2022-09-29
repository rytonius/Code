using System;

namespace IllustratedC7 
{
    class heyo 
    {

        public static void formatStrings(float f) 
        {
            Console.WriteLine("{0,10:P}", f);
            Console.WriteLine("{0,10:F3}", f);
            Console.WriteLine("{0,10:C3}", f);
            Console.WriteLine("{0,10 :E3}", f);

            Console.WriteLine($"{f, 10:G}");

        }
        public static void howdy() 
        {
            Console.WriteLine($"{0.122472:P1}" );
        }

        public void PV() 
        {
            int var1 = 2, var2 = 4;
            Console.WriteLine($"{var1} + {var2} = {var1+var2}");
        }
    }
}