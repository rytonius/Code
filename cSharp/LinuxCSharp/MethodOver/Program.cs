//signature of a method consists of the name, # of paramenters, Data types and order of params, param modifiers. 
// return type is not part, names of formal params are not part of signature

// long is not part of sig; the rest is 
// long AddValues(int a, out int b) {...}

class Program
{
    static void Main()
    {
        Console.WriteLine(AddValues(5, 6));
        Console.WriteLine(AddValues(1, 2, 3));
        
    }
    static long AddValues(int a, int b) { return a + b; }
    static long AddValues(int c, int d, int e) { return c + d + e; }
    static long AddValues(float a, float b) { return (long)(a + b); }
    static long AddValues(long a, long b) { return a + b; }
}







