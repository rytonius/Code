using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace GenericsChapter
{
    class Simple    // Non-generic class
    {
        static public void ReverseThenPrint<T>(T[] arr) // Generic method
        {
            bool skipFirstComma = false; // just for formatting
            Array.Reverse(arr);
            foreach (T item in arr) // Use type argument T.
            {
                if (skipFirstComma == true)
                    Write(", ");
                if (item is not null)
                    Write($"{item.ToString()}");
                    skipFirstComma = true;
            }
            WriteLine("");

        }
    }
    public static class ReverseAndPrint
    {
        // Create arrays of various types
        public static void Main() 
        {
            var intArray    = new int[] {3, 5, 7, 9, 11, 13};
            var stringArray = new string[] {"Bobby", "Fletcher", "Thomas", "President Commanche"};
            var doubleArray = new double[] { 3.567, 11.293, 22.39, 1.1};

            Simple.ReverseThenPrint<int>(intArray);     // invoke method

            Simple.ReverseThenPrint(stringArray);       // Infer type and invoke

            Simple.ReverseThenPrint<double>(doubleArray); // invoke method
            Simple.ReverseThenPrint(doubleArray);         // Infer type and invoke, either works in this case
        }
    }
}