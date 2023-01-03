using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemovingEventhandlers
{
    class Publisher
    {
        public event EventHandler SimpleEvent;
        public void RaiseTheEvent() { SimpleEvent(this, null);}
    }

    class Subscriber {
        public void MethodA(object o, EventArgs e) {Console.WriteLine("AAA");}
        public void MethodB(object o, EventArgs e) {Console.WriteLine("BBB");}
    }

    public class Program {
        public void Main() {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();

            p.SimpleEvent += s.MethodA;
            p.SimpleEvent += s.MethodB;
            p.SimpleEvent += s.MethodA;
            p.RaiseTheEvent();

            Console.WriteLine("\r\nRemove MethodB");
            p.SimpleEvent -= s.MethodB;
            p.RaiseTheEvent();

        }
    }
}