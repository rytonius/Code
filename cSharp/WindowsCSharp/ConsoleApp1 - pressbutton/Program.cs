using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press A to Simulate a button click");
            var key = Console.ReadLine();

            Console.WriteLine(key);
            if (key == "a")
            {
                KeyPressed();
            }

            Console.WriteLine("end");
            Console.ReadLine();
        }

        static void KeyPressed()
        {
            Button button = new Button();
            button.ClickEvent += (s, args) =>
            {
                Console.WriteLine($"You clicked a button {args.Name} and {args.Value}" );
            };

            button.OnClick();
        }


    }

    public class Button
    {
        public EventHandler<MyCustomArguments> ClickEvent;
        public void OnClick()
        {
            MyCustomArguments myArgs = new MyCustomArguments();
            myArgs.Name = "Dante";
            myArgs.Value = "very nice";
            ClickEvent?.Invoke(this, myArgs);
        }
    }

    public class MyCustomArguments: EventArgs
    {
        public string Name { get; set; }
        public string Value { get; set; }


    }
    
}
