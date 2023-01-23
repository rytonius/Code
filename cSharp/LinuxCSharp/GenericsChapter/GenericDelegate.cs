using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericsChapter
{
    delegate void MyDelegate<T>(T value);

    class SimpleC
    {
        static public void PrintString(string s)
        {
            Console.WriteLine(s);
        }
        static public void PrintUpperString(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }
    public static class GenericDelegate
    {
        public static void Main()
        {
            var myDel = // create inst of delegate
                new MyDelegate<string>(SimpleC.PrintString);
            myDel += SimpleC.PrintUpperString;

            myDel("Hi There");
        }
    }
}