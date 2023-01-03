using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace AnotherEvent
{

    internal class Button {
        public event EventHandler<MyCustomArguments> ClickEvent;
        public void OnClick() {
            MyCustomArguments myArgs = new MyCustomArguments();
            myArgs.Name = "What";
            ClickEvent?.Invoke(this, myArgs);
        }
    }

    public class MyCustomArguments: EventArgs {
        public string Name {get; set;}
    }
    
    public class DoIt
    {

        public void RunIt()
        {
            WriteLine("Press 'A' to simulate a button click\n");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.A) {
                KeyPressed();
            }
        }

        static void KeyPressed(){
            Button button = new Button();
            button.ClickEvent += (s, args) => {
                WriteLine("You clicked button:  " + args.Name);
            };
            
            button.OnClick();
            WriteLine("End of Event");
        }
    }

}