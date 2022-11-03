namespace OutputParams
{
    class MyClass {
        public int Val = 20;    // Initialize field
    }

    class Program {
        static void MyMethod(out MyClass f1, out int f2) {
            f1 = new MyClass(); // Create an object of the class.  since this isn't a reference it is 
                                // necessary to initalize before return
            f1.Val =  25;       // Assign to the class field.
            f2     =  15;       // Assign to the int param.
        }

        static void Main() {
            MyClass a1;
            int a2 = 10;
            Console.WriteLine($"Before: a2: {a2}");
            MyMethod(out a1, out a2); // Call the method

            Console.WriteLine($"after: a1: {a1.Val}\ta2: {a2}");
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