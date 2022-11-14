using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClassInheritance_and_Overrides
{
    class GetBaseClass {
        virtual public void Print() { // virtual is required for override BABY
            Console.WriteLine("This is the base class."); 
        }

        private int _myInt = 5;  // intial value
        virtual public int MyProperty { // virtual so we can override
            get { return _myInt ;}
        }
    }

    class GetDerivedClass : GetBaseClass {
        public override void Print() { // we gonna override this too!
                Console.WriteLine("This is the derived class.");
            }

        private int _myInt = 10; //going to override with this value witth our public property
        override public int MyProperty { // override the virtual MyProperty
            get { return _myInt; }
        }
        
    }

    class GetSecondDerived : GetDerivedClass {
        public override void Print()
        {
            Console.WriteLine("This is the second derived class");
            
        }
    }
    static public class OverridingMethod
    {
        public static void GetRunIt() {
            GetSecondDerived SecondDerived = new GetSecondDerived();
            GetBaseClass GBC = (GetBaseClass)SecondDerived;

            SecondDerived.Print();
            GBC.Print();

            GetDerivedClass  GDC = new GetDerivedClass();
            GetBaseClass GBC2 = (GetBaseClass)GDC;

            Console.WriteLine( GDC.MyProperty);
            Console.WriteLine( GBC2.MyProperty);
        }
    }
}