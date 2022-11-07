class MyClass {
    public int Calc( int a, int b, int c ) {
        return (a + b ) * c; 
    }

                        // int b is a default value
    public int OptionalCalc( int a, int b = 3) {
        return a+b;
    }

    static void Main() {
        MyClass mc = new MyClass(); 

        int r0 = mc.Calc( 4 , 3 , 2);
        int r1 = mc.Calc( a: 4, b: 3, c:2);
        int r2 = mc.Calc( c:2, a: 4, b: 3); // switch order works
        int r3 = mc.Calc( 4, b: 1 + 2, c: 1 + 1); // expressions
        Console.WriteLine($"{ r0 }, {r1}, {r2}, {r3}\n MyClassCylinder: ");

        MyClassCylinder MCC = new MyClassCylinder();

        double volume;

        volume = MCC.GetCylindervolume(radius: 3.0, height: 4.0); //replace both defaults
        Console.WriteLine($"radius 3.0 and height of 4.0 has a volume of: {volume}");

        volume = MCC.GetCylindervolume(radius: 3.0); //use just height default
        
        Console.WriteLine($"radius 3.0 and height of 10.0 has a volume of: {volume}");

        volume = MCC.GetCylindervolume(height: 3.0); // use just the radius default
        Console.WriteLine($"radius 10.0 and height of 3.0 has a volume of: {volume}");

        volume = MCC.GetCylindervolume();  //use default values
        Console.WriteLine($"radius 10.0 and height of 10.0 has a volume of: {volume}");

        Console.WriteLine($"3 + 3 = {mc.OptionalCalc(3)}");


    }
}

class MyClassCylinder {
    public double GetCylindervolume( double radius = 10.0 , double height = 10.0 ) {
        return 3.1416 * radius * radius * height;
    }
}

