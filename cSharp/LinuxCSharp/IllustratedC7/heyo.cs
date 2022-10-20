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

        void GetCurrentDate() 
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
    
        }

        
    }

    public class ReferenceTesting 
    {
        public void ReferenceStuff(ref int x) 
        {
            Console.WriteLine($"reference: {x} adding 1 to it");
            x++;
            Console.WriteLine($"reference: {x}");
        }
    }
}