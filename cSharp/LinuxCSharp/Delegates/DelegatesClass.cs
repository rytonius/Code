using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void PrintFunction();
    delegate int MyDel();
    delegate void Delly(int value);
    delegate double DoubleDel(int par);
    
    class Test {
        public void Print1() => Console.WriteLine("Print1 -- instance");
        public static void Print2() => Console.WriteLine("Print2 -- static");   


    }

    class MyClass{
        int IntValue = 5;
        public int Add2() {IntValue += 2; return IntValue;}
        public int Add3() {IntValue += 3; return IntValue;}
    }
    public class DelegatesClass
    {
        void PrintLow(int value) => Console.WriteLine($"{value } - Low Value");
        void PrintHigh(int value) => Console.WriteLine($"{value } - High Value");
        
        public void RunIt(){
            Test t = new Test();
            PrintFunction PF;       // create a null delegate

            PF = t.Print1;
            PF += Test.Print2;
            PF += t.Print1;
            PF += Test.Print2;
            // delegate contains 4 methods

            if ( null != PF) // make sure the delegate isn't null
                PF();
            else 
                Console.WriteLine("Delegate is empty");

            MyClass mc = new MyClass();
            MyDel mDel = mc.Add2;
            mDel += mc.Add3;
            mDel += mc.Add2;
            Console.WriteLine($"Value : { mDel() }");


            Random rand = new Random();
            int randomValue = rand.Next( 99 );
            Delly del;
            del = randomValue < 50 ? new Delly(PrintLow) : new Delly(PrintHigh);

            del(randomValue);

            // Lambda Expression Anonymous
            DoubleDel DD = x => x + 1 ;
            Console.WriteLine($"DD: = {DD(12)}");

        }
    }
}