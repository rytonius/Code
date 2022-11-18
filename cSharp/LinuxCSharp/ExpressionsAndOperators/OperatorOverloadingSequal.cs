using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace ExpressionsAndOperators
{
    public class MyType // Run twice, once as a struct and again as a class.
    {
        public int X;
        public MyType( int x) {
            X = x;
        }

        public static MyType operator ++(MyType m) {
            m.X++;
            return m;
        }
    }

    static class Test {
        static public void Show( string message, MyType tv){
            WriteLine($"{message} {tv.X}");
        }
    }
    public class OperatorOverloadingSequal
    {
        public void RunIt() {
            MyType tv = new MyType(10);
            Console.WriteLine("Pre-increment");

            Test.Show("Before   ", tv);
            Test.Show("Returned ", ++tv);
            Test.Show("After    ", tv);

            tv = new MyType(10);
            Console.WriteLine("Post-increment");

            Test.Show("Before   ", tv);
            Console.WriteLine(@"    Depending if it's class or struct this output is different
    a struct will have 10 since it's a value, class is referenced so 11.");
            Test.Show("Returned (overloaded operator) ", tv++ );
            Test.Show("After    ", tv);
        }
       

    }
} 