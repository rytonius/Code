using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacesChapter
{
    class MyClass : IComparable             // Class implements interface
    {
        public int TheValue;
        public int CompareTo(object? obj)    // Implement the method
        {
            if (null != obj) {
                MyClass mc = (MyClass)obj;
                if (this.TheValue < mc.TheValue) return -1;
                if (this.TheValue > mc.TheValue) return 1;
            }
            return 0;
        }
    }
    public class SortCustomClass
    {
        static void PrintOut(string s, MyClass[] mc)
        {
            Console.Write(s);
            foreach (MyClass m in mc)
                Console.Write($"{m.TheValue} ");
            Console.WriteLine("");
        }

        public void RunIt()
        {
            var myInt = new [] {20, 4, 16, 9, 2 };
            MyClass[] mcArr = new MyClass[5];   // Create array of MyClass objs.
            

            for (int i = 0; i < mcArr.Length; i++) {
                mcArr[i] = new MyClass();
                mcArr[i].TheValue = myInt[i];
            }
            PrintOut("Initial Order: ", mcArr);
            Array.Sort(mcArr);
            PrintOut("Sorted Order:  ", mcArr);
        }
    }

}