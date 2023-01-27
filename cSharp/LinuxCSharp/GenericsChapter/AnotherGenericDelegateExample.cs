using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericsChapter
{
    // TR is delegate return type
    public delegate TR Func<T1, T2, TR>(T1 p1, T2 p2); // Generic Delegate

    class SimpleSimple
    {
        static public string PrintString(int p1, int p2) // method matches delegate
        {
            int total = p1 + p2;
            return total.ToString();
        }
    }

    public static class AnotherGenericDelegateExample
    {
        public static void Main()
        {
            var myDel = new Func<int, int, string>(SimpleSimple.PrintString); // Create inst of delegate
            Console.WriteLine($"Total: { myDel(15, 13) }");
        }
    }
}