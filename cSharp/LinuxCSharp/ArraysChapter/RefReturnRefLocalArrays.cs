using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace ArraysChapter
{
    public static class RefReturnRefLocalArrays
    {
        public static ref int PointerToHighestPositive(int[] numbers) 
        {
            int highest         = 0;
            int indexOfHighest  = 0;

            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > highest) {
                    indexOfHighest = i;
                    highest        = numbers[indexOfHighest];
                }
            }

            return ref numbers[indexOfHighest];
        }

        static public void RunIt() {
            int[] scores = { 5, 80};
            WriteLine($"Before: {scores[0]}, {scores[1]}");
            ref int locationOfHigher = ref PointerToHighestPositive(scores); // this references the index [1] since that has 80
            WriteLine(locationOfHigher); // returns the 80

            locationOfHigher = 0;       // Change the value through ref local
            WriteLine($"After : {scores[0]}, {scores[1]}"); // now 80 is over-written

        }
    }
}