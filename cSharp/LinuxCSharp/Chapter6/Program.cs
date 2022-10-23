namespace RP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine();
                //Console.WriteLine(args); this will just display System.String[]
                foreach (var s in args)
                {
                    Console.Write(s);
                    Console.Write(' ');
                }
                Console.WriteLine();

                string[] answers =
                    {
                    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
                    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
                    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
                    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
                    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
                    "As I see it, yes.",
                    "Most likely.",
                    "Outlook good.",
                    "Yes.",
                    "Signs point to yes.",
                };

                var index = new Random().Next(answers.Length - 1);
                Console.WriteLine("Magic 8 Ball Types:  " + answers[index]);
                Console.WriteLine();
            }

            MyClass a1 = new MyClass();
            int a2 = 10;

            MyMethod(ref a1, ref a2);       // Call the method
            Console.WriteLine($"a1.Val: {a1.Val}, a2: {a2}\n\n");

            // reference types as value and reference parameters

            MyClass b1 = new MyClass();
            Console.WriteLine($"Before method call:\t{b1.Val,10}");
            RefAsParameter(b1);
            Console.WriteLine($"After method call:\t{b1.Val,10}\n\n");

            MyClass c1 = new MyClass();
            Console.WriteLine($"Before method call:\t{c1.Val,10}");
            RefAsParameter2(ref c1);
            Console.WriteLine($"After method call:\t{c1.Val,10}");

        }


        static void MyMethod(ref MyClass f1, ref int f2)
        {
            f1.Val = f1.Val + 5; // add 5 to field of f1 param.
            f2 = f2 + 5;     // Add 5 to second param
            Console.WriteLine($"f1.Val: {f1.Val}, f2: {f2}");
        }

        static void RefAsParameter(MyClass f1)
        {
            // turn into 50 like a boss
            f1.Val = 50;
            Console.WriteLine($"After member assignment:\t{f1.Val}");
            // make a new class, cause why not
            f1 = new MyClass();
            Console.WriteLine($"After new object creation:\t{f1.Val}");
        }

        static void RefAsParameter2(ref MyClass f1)
        {
            // Assign to the object member
            f1.Val = 50;
            Console.WriteLine($"After member assignment:\t{f1.Val}");
            // Create a new object and assign it to the formal parameter.
            f1 = new MyClass();
            Console.WriteLine($"After new object creation:\t{f1.Val}");
        }

    }

    class MyClass
    {
        public int Val = 20;
    }

}