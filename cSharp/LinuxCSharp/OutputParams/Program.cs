namespace OutputParams
{
    class MyClass
    {
        public int Val = 20;    // Initialize field
    }

    class Program
    {
        static void MyMethod(out MyClass f1, out int f2)
        {  // every possible path must assign a value to every 
           // output param before method exit
            f1 = new MyClass(); // Create an object of the class.  since this isn't a reference it is 
                                // necessary to initalize before return
            f1.Val = 25;       // Assign to the class field.
            f2 = 15;       // Assign to the int param.
        }

        static void Main()
        {
            MyClass a1;
            int a2 = 10;    // since this will be used as an output param, you do NOT need to initialize
            Console.WriteLine($"Before: a2: {a2}"); // this is just an example to show the change
            MyMethod(out a1, out a2); // Call the method

            Console.WriteLine($"after: a1: {a1.Val}\ta2: {a2}");

            // you can admit declared variables entirely when used as out params
            MyMethod(out MyClass b1, out int b2);
            Console.WriteLine($"after: b1: {b1.Val}\tb2+5: {b2 + 5}");
        }
    }



}

// ref keyword	
// It is necessary the parameters should initialize before it pass to ref.	
// It is not necessary to initialize the value of a parameter before returning to the calling method.	
// The passing of value through ref parameter is useful when the called method also need to change the value of passed parameter.	
// When ref keyword is used the data may pass in bi-directional.	

// out keyword
// It is not necessary to initialize parameters before it pass to out.
// It is necessary to initialize the value of a parameter before returning to the calling method.
// The declaring of parameter through out parameter is useful when a method return multiple values.
// When out keyword is used the data only passed in unidirectional.