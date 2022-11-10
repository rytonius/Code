// Set accessor always has the following:
// - args single, implicit value parameter named value, of the same type as the property
// - a return type of void

// get accessor always has the folowing
// - no parameters
// - a return type of the same type as the property

using static System.Console;
using static StaticProps.Trivial; // This is for an example of allowing access to static properties
class C1 {
    private int theRealValue = 10; // Camel Casing, could use _ also for private
    public int MyValue { // Pascal Casing
        set { theRealValue = value;}
        get { return theRealValue;}
    }

    public int Get10 {
        set {}
        get {return 5;}  // you can technically return anything
    }

    int _possibleValue = 50;
    public int PossibleValue {
        set => _possibleValue = value < 100 ? 100 : value;  // can set up conditional operator
        // you must SET before this is ran in the code sequence somewhere.
        get => _possibleValue; // alternative way, expression bodies (lambda expressions)
        
    }

    public int AllocateMemory { set ; get;} // this will have a value of 0 until set 

}


namespace StaticProps {
    class Trivial {
        public static int MyValue { get; set;}
        public void PrintValue() {
            WriteLine(" Value from inside: {0}", MyValue);  // accessed from inside the class
        }
    }

    class Prog {
        public static void RunProg() {
            // first writeline shows accessing from inside the class
            WriteLine("Init Value: {0}", Trivial.MyValue);
            Trivial.MyValue = 10; // accessed from outside the class
            WriteLine("New Value: {0}", Trivial.MyValue);

            MyValue = 20;   // this will work if you set up a 'using static StaticProps.Trivial'
            WriteLine("New Value: {0}", MyValue);

            Trivial tr = new Trivial();
            tr.PrintValue();

        }
        

    }
}

class RightTriangle {
    public double A = 3;
    public double B =4;
    public double Hypotenuse { // read-only property
        get{ return Math.Sqrt((A*A)+(B*B));} // calculate return value

        // it has two public fields that are set,  then the property itself is a read-only property
        // It isn't stored i na field, computes the correct value on demand for the values A+B
    }
}


class ConstantExample {
    public const double PI = 3.1416;  // don't need an instance of this class to use
}

class Program {
    static void Main() {
        C1 c = new C1();
        WriteLine("My Value:  {0}", c.MyValue);

        c.MyValue = 20;  // this will SET the property
        WriteLine("My Value:  {0}", c.MyValue);

        WriteLine("Member constant PI = {0}", ConstantExample.PI);

        WriteLine("possible value:  {0}", c.PossibleValue);
        c.PossibleValue = 50;
        WriteLine("possible value:  {0}", c.PossibleValue);

        RightTriangle rt = new RightTriangle();

        WriteLine($"Hypotenuse: { rt.Hypotenuse }");


        StaticProps.Prog.RunProg();
    }
}

