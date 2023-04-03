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

        
        public void foreachArrays() {
            WriteLine("\nForeach Arrays\n");
            int[] Arrrg1 = {10, 11, 12, 130};
            foreach (int lilarrrg in Arrrg1) {
                WriteLine($"Item Value: {lilarrrg}");
            }

            MyClass[] mcArray = new MyClass[4]; //Create Array
            for (int i = 0; i < 4; i++) {
                mcArray[i] = new MyClass();     // Create Class Objects
                mcArray[i].MyField = i;         // Set Field
            }

            foreach (MyClass item in mcArray) {
                item.MyField += 10;             // Change the data since it's data from the reference
                WriteLine($"{ item.MyField}");
            }
                
            
        }

        public void ForeachRectangleArray(int x, int y, int a, int b) {
            int total = 0;
            int[,] arr1 = { {x, y}, {a,b}};

            foreach( int element in arr1 ) {
                total += element;
                WriteLine($"ELement: { element}, Current Total: { total }");
            }
        }

        public void ExampleJaggedArrayForEach() {
            int total       = 0;
            int[][] arr1    = new int[2][];
            arr1[0]         = new int[] {10, 11};
            arr1[1]         = new int[] {100,110,120};

            foreach (int[] array in arr1) //proccess the top level
            {
                WriteLine("\nStarting new array: {0}", array);
                foreach (int item in array) //process the second level 
                {
                    total += item;
                    WriteLine($"  Item: {item}, Current Total: {total}");
                }
            }

            var result = Array.Find<int>( arr1[0], element => element == 10);
            WriteLine(result);
        }
    }
    class MyClass {
            public int MyField = 0;
        }

    public class ArrayMembers {
        public static void PrintArray(int[] a ) {
            foreach (var x in a)
                Write($"{x} ");
            WriteLine("");
        }

        public void runit() 
        {
            int[] arr = new int[] {15 , 20, 5, 25, 10 };
            PrintArray(arr);
            Array.Sort(arr);
            PrintArray(arr);
            Array.Reverse(arr);
            PrintArray(arr);

            WriteLine();
            WriteLine($"Rank = {arr.Rank}, Length = {arr.Length}");
            WriteLine($"GetLength(0)    = { arr.GetLength(0) }");
            WriteLine($"GetType()       = {arr.GetType() }");

            WriteLine("\nClone Method\n");
            CloneValueMethod(arr);
            CloneReferenceMethod();
        }

        public void CloneValueMethod(int[] arr1) {
            int[] intArray = (int[]) arr1.Clone();

            PrintArray(intArray); // value based, will have duplicate entries
        }

        public void CloneReferenceMethod() {
            MyClass[] AArray1 = new MyClass[3] { new MyClass(), new MyClass(),new MyClass() };
            MyClass[] AArray2 = (MyClass[]) AArray1.Clone(); // array2 is just a pointer to array1

            for (int i = 0; i < AArray2.Length; i++) {
                AArray2[i].MyField = (1 + i) * 100; 
            }
            int k = 0;
            foreach (MyClass element in AArray2) {
                WriteLine($"MyClass.MyField[{k++}]: {element.MyField}");
            }

        }
    }
}