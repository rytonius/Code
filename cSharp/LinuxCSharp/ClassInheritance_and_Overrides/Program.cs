using ClassInheritance_and_Overrides;
class SomeClass {
    public string Field1 = "Base class field ";
    public string Field3 = "Base class field 3";
    public void Method1(string value) {
        Console.WriteLine($"Base class -- Method1: { value }");
    }

    public void Method3() {
        Console.WriteLine($"Base class -- Method3: {Field3}");
    }
}

class OtherClass: SomeClass {
    public string Field2 = "Derived class field";
    new public string Field3 = "Derived class field 3";  // this masks the original field 3
    public void Method2( string value) {
        Console.WriteLine($"Derived class -- Method2: { value }");
    }

    new public void Method3() {
        Console.WriteLine($"Derived class -- Method3: {Field3}");
        Console.WriteLine($"Derived class -- Method3: {base.Field3}"); // base.field will have it use base class 
    }
}

class Program {
    static void Main() {
        OtherClass oc = new OtherClass();

        Console.WriteLine("");      
        oc.Method1( oc.Field1);        
        oc.Method1( oc.Field2);
        oc.Method2( oc.Field1);
        oc.Method2( oc.Field2);

        Console.WriteLine("");
        oc.Method1( oc.Field3);
        oc.Method2( oc.Field3);
        oc.Method3();

        Console.WriteLine("\nReferenceBaseClass Examples:\n");
        
        RunIt.RunMethod();
    }
}