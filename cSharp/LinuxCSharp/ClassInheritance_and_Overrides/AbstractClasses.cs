using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassInheritance_and_Overrides
{
    abstract class MyBase
    {
        public void IdentifyBase()
        {
            Console.WriteLine("I am MyBase");
        }
        abstract public void IdentifyDerived();

        public int SideLength       =10;
        const int TriangleSideCount = 3;
        abstract public void PrintStuff( string s); // abstract method
        abstract public int MyInt { get; set;}  // abstract property

        public int PerimeterLength() {          // Regular, nonabstract method
            return TriangleSideCount * SideLength;
        }
    }

    class MyClass : MyBase
    {
        override public void IdentifyDerived()
        {
            Console.WriteLine("I am MyClass");
        }

        public override void PrintStuff(string s)   // Override abstract method
        {
            Console.WriteLine(s);
        }

        private int _myInt;     // override abstract property
        public override int MyInt {
            get { return _myInt; }
            set { _myInt = value; }
        }
    }
    public class AbstractClasses
    {
        // ABClass a = new ABClass():  //Error.  Cannot instantiate an abstract class.
        public void AbstractRunIt() {
            MyClass mc = new MyClass();
            mc.IdentifyBase();
            mc.IdentifyDerived();

            mc.PrintStuff("This is a string.");
            mc.MyInt = 28;
            Console.WriteLine( mc.MyInt);
            Console.WriteLine($"Perimeter Length: { mc.PerimeterLength() }");
        }
        
    }
}