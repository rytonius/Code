using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace Statements
{
    public static class ContinueStatement
    {
        public static void Method() {
            for (int x = 0; x < 5; x++) 
            {
                if (x < 3) 
                    WriteLine($"x: {x} no continue"); //for loop moves on to the next line

                if (x < 3) {
                    WriteLine($"x: {x} yes continue"); 
                    continue;                           // this brings it back to the top of the loop and stops 
                                                        //the statement
                }
                WriteLine($"only reached after neither conditions match (less that 3) x: {x}");
                
            }
        }
    }
}