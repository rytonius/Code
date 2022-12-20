using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace ArraysChapter
{
    public class InstantiatingAndAccess
    {
        int[] intArr1 = new int[15];
        int[,] intArr2 = new int[5,10];

        int[] myIntArray = new int[4];

        int var1;
        int var2;

        public void InitArray() {
            intArr1[2] = 10;
            var1   = intArr1[2];

            intArr2[2,3] = 7;
            var2     = intArr2[2,3];
                        

            WriteLine($"myIntArray length: {myIntArray.Length}\tRank: {myIntArray.Rank}");
            for ( int i=0; i < myIntArray.GetLength(0); i++ ) {
                myIntArray[i] = i*10;
            }
        }

        public void WriteArrayValues() {
                        // Read and display the values of each element
            WriteLine($"\nvar1 from intArr1[2]: {var1}\nvar2 from intArr2[2,3]: {var2}");

            for ( int i=0; i < myIntArray.Length; i++) {
                WriteLine($"Value of element { i } = {myIntArray[i]}");
            }
        }


        public void PuttingItAllTogether() {
            WriteLine("");
            // declare implicitit and inferred typed array.
            var arrint    = new [,] {{0, 1, 2}, {10, 11, 12}};
            // shortcut syntax
            string[] arrstring = {"life", "liberty", "pursuit of hapiness"}; 

            // Print the values
            for (int i = 0; i < arrint.Rank ;i++) {
                for (int c = 0; c < arrint.GetLength(i); c++) {
                    WriteLine($"arrint[{i},{c}]: {arrint[i,c]}");
                }
            }

            for (int i = 0; i < arrstring.Length; i++) {
                WriteLine($"arrstring[{i}]: {arrstring[i]}");
            }
        }
    }
}