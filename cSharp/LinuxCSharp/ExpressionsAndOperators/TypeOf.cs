using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
namespace ExpressionsAndOperators
{
    class SomeClass {
        public int Field1;
        public int Field2;

        public void Method1() { }
        public int Method2() { return 1;}

        public void NameOfMethod(string value) {
            Console.WriteLine(nameof (value));

        }
    }

    static public class TypeOf
    {
        public static void RunIt() {
            Type t = typeof(SomeClass);
            FieldInfo[]  fi = t.GetFields();
            MethodInfo[] mi = t.GetMethods();

            foreach (FieldInfo f in fi)
                Console.WriteLine($"Field : { f.Name }");
            foreach (MethodInfo m in mi)
                Console.WriteLine($"Method: {m.Name}");

            Console.WriteLine($"GetType mi: {mi.GetType()}  --  {mi.GetType().Name}");

            Console.WriteLine("nameof operator\n");
            string var1 = "Local Variable";
            SomeClass SC = new SomeClass();
            SC.NameOfMethod(var1);
            Console.WriteLine(nameof (var1));
            Console.WriteLine(nameof (MyType));
            Console.WriteLine(nameof (mi));
            Console.WriteLine(nameof (t));
            Console.WriteLine(nameof (System.Math));
            


        }

        
    }
}