using static System.Console;

class Program {

    // Example of stack frames, order of the Frame being called and exiting
    // this would start 3 stack frames being pushed Main->MethodA->MethodB and then unwound or popped
    static void MethodA(int par1, int par2) {
        WriteLine($"Enter MethodA: { par1 }, { par2}");
        MethodB(11, 18);
        Console.WriteLine("Exit MethodA");
    }

    static void MethodB(int par1, int par2) {
        WriteLine($"Enter MethodB: { par1}, {par2}");
        WriteLine("Exit MethodB");
    }

    static void Main() {
        WriteLine("Enter Main");
        MethodA( 15, 30); 
        WriteLine("Exit Main");

        // recursion
        Count(3); // notice the output is not shown when it's pushed into the stack
        // but when it is popped from the stack, results are shown in reverse
    }

    // recursion
    static  public void Count(int inVal) {
        if (inVal == 0)
            return;
        Count(inVal - 1);   // Invoke this method again

        WriteLine($"{ inVal }");
    }

    
}

