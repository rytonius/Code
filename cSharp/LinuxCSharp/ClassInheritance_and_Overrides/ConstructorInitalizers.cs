using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassInheritance_and_Overrides
{
    class ConstructorClass {
        readonly int    firstVar;
        readonly double secondVar;
        public string? Username;
        public int UserIdNumber = 10;

        private ConstructorClass() { // Private constructor performs initializations 
            firstVar = 20;           // common to the other consturctors
            secondVar = 30.5;
        }



        public ConstructorClass( string firstName ) : this() // Use constructor initializer
        {
            Username     = firstName;
            UserIdNumber -= 1;
        }

        public ConstructorClass( int idNumber): this() // use constructor initializer
        {
            Username     = "Anonymous";
            UserIdNumber = idNumber;
        }
    }
    static public class ConstructorInitalizers
    {
        static public void ConstructorRun() {
            ConstructorClass CCstring = new ConstructorClass("billy");
            ConstructorClass CCint = new ConstructorClass(7);
            int textlength = ("CCstring(\"billy\"):").Length;
            Console.WriteLine("CCstring(\"billy\"): {0} [{1}]", CCstring.Username, CCstring.UserIdNumber);
            Console.WriteLine("CCint(7): {0,18} [{1}]", CCint.Username, CCint.UserIdNumber);

        }
    }
}