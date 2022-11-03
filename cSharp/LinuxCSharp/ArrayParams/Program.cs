

namespace ArrayLesson
{
    class Arrays
    {
        static void Main()
        {
            int first = 1, second = 2, third = 3;
            int[] intArray = { first, second, third };
            MyArrayClass MAC = new MyArrayClass();

            Console.WriteLine($"\nIntArray starts with: {intArray[0]} {intArray[1]} {intArray[2]}\n");
            MAC.ListInts(intArray);
            Console.WriteLine($"IntArray ends with:\t {intArray[0]} {intArray[1]} {intArray[2]}");
            Console.WriteLine("first second third {0} {1} {2}", first, second, third);
            
        }

        

    }

    class MyArrayClass {
        public void ListInts(params int[] inVals)
        {
            
            if ((inVals != null) && (inVals.Length != 0))
            {
                Console.WriteLine("For Loop");
                for (int i = 0; i < inVals.Length; i++)  // Process the array
                {
                    inVals[i] = inVals[i] * 10;
                    Console.WriteLine($"{inVals[i]}");  // display new value
                }
                Console.WriteLine("Foreach");
                foreach (int value in inVals)
                {
                    Console.Write($"{value} ");
                }

                Console.WriteLine("\nArray.Foreach<t>");
                Array.ForEach(inVals, Console.WriteLine);  // another way to do it
                Console.WriteLine("");
            }
            else 
                Console.WriteLine("\nnull value\n\n");
            
        }
    }


}