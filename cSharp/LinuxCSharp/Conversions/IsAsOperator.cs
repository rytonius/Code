using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Conversions
{
    class Employee : Person { }

    class Person
    {
        public string Name = "Anonymous";
        public int Age = 25;
    }
    public class IsAsOperator
    {
        public void Main() {
            Employee bill = new Employee();

            // check if varaible bill can be converted to type Person
            if( bill is Person) // use is operator to check whether a conversion would complete succesfully.
            {
                Person p = bill;
                WriteLine($"Person Info: {p.Name}, {p.Age}");
            }

            Employee Will = new Employee();
            Person b;

            b = Will as Person; // as operator is like the cast operator, does not raise an exception though.
            //  returns null if fails
            if( b != null)
                WriteLine($"Person Info: { b.Name }, {b. Age}");
        }

    }
}