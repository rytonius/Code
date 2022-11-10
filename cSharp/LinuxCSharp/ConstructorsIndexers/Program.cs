using static System.Console;
using ConstructorsIndexers;
class Class1
{
    int Id;
    string Name;

    public Class1() { Id = 28; Name = "Nemo"; } //Constructor 0
    public Class1(int val) { Id = val; Name = "Nemo"; } //Constructer 1
    public Class1(string name) { Name = name; } // Constructor 2

    public void SoundOff()
    {
        Console.WriteLine($"Name {Name},  ID {Id}\t DateTime: {DateTime.Now}");
    }
}

class PrivatePerson { // example of a private accessor/ Access modifier on Accessor
    public string Name { get; private set;}
    public PrivatePerson( string name) {Name = name;}
}

class PrivatePersonRun {
    static public void RunIt() {
        PrivatePerson p = new PrivatePerson(" Capt. Ernest Evans");
        WriteLine("Person's name is {0}", p.Name);  // this ony got set during instance of class
        // p.Name = "change me";   this will error out
    }
}

class RandomNumberClass {
    private static Random _RandomKey; // private static field

    static RandomNumberClass() { // static constructor
        _RandomKey = new Random(); // initalzie randomkey
    }

    public string GetRandomNumber() {
        return (string.Format("{0:0.00}", _RandomKey.Next() * 0.0001));
    }
}

// Object Initializers

public class Point {
    public int X = 1;
    public int Y = 2;
}

// this keyword example

class ThisClass {
    int Var1 = 10;
    public int ReturnMaxSum(int value) {
        return value > this.Var1    // ?: operator = conditial operator
                     ? value        // parameter
                     : this.Var1;   // field
    }
}

class Program {
    static void Main() {
        Class1  a = new Class1(),   // call cons 0
                b = new Class1(7),  // call cons 1
                c = new Class1("Bill");//call cons 2

        a.SoundOff();
        b.SoundOff();
        c.SoundOff();

        // Random Number class
        WriteLine("\nRandom Number Example\n");

        RandomNumberClass RNC1 = new RandomNumberClass();
        RandomNumberClass RNC2 = new RandomNumberClass();

        WriteLine("Next Random #: {0}", RNC1.GetRandomNumber());
        WriteLine("Next Random #: {0}", RNC1.GetRandomNumber());
        WriteLine("Next Random #: {0}", RNC2.GetRandomNumber());
        WriteLine("Next Random #: {0}", RNC2.GetRandomNumber());

        // Object Initializer example
        WriteLine("\nObject Initializer Example\n");

        Point pt1 = new Point();
        Point pt2 = new Point { X= 5, Y = 6 };  // this is the example of Object Initializer
        WriteLine("pt1: x:{0}, y:{1}", pt1.X, pt1.Y);
        WriteLine($"pt2: x:{pt2.X}, y:{pt2.Y}");

        WriteLine("\nthis class example\n");
        ThisClass TC = new ThisClass();
        WriteLine($"Max: {TC.ReturnMaxSum(30)}");
        WriteLine($"Max: {TC.ReturnMaxSum(5)}");

        //Indexer Example
        DoStuff.NewEmployees();

        // Partial Examples
        WriteLine("\nPartial Classes Example\n");
        RunPartial.RunThatClass();
    }
}