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
            WriteLine($"arrint: {arrint.Rank}\narrint.Getlength(0): {arrint.GetLength(0)}"
            + $"\n arrint.Getlength(1): {arrint.GetLength(1)} ");

            // Print the values
            for (int i = 0; i < arrint.Rank ;i++) {
                for (int c = 0; c < arrint.GetLength(1); c++) {
                    WriteLine($"arrint[{i},{c}]: {arrint[i,c]}");
                }
            }

            for (int i = 0; i < arrstring.Length; i++) {
                WriteLine($"arrstring[{i}]: {arrstring[i]}");
            }
        }

        public void JaggedArraysAreSilly() {
            WriteLine("\nJaggedArraysAreSilly\n");
             int[][,] Jarray = new int[3][,];
             Jarray[0] = new int[,] { { 10,20 },
                                      { 40,50 } };
             Jarray[1] = new int[,] { { 100,200,300 },
                                      { 400, 500, 600 } };
             Jarray[2] = new int[,] { { 1000,2000,3000, 4000 },
                                      { 5000,6000,7000, 8000 } };

            for (int i = 0; i < Jarray.GetLength(0); i++) {
                for (int j = 0; j < Jarray[i].GetLength(0); j++) {
                    for (int k = 0; k < Jarray[i].GetLength(1); k++) {
                        WriteLine($"[{i}][{j},{k}] = {Jarray[i][j,k]}");
                    }
                    WriteLine("");
                }
                WriteLine("");
            }
        }
    }
}