using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericsChapter
{
    interface IMyIfc<T>
    {
        T ReturnIt(T inValue);
    }

    class SimpleI<S> : IMyIfc<S>
    {
        public S ReturnIt(S inValue) => inValue;
    }
    public static class GenericInterface
    {
        public static void Main() 
        {
            var trivInt     = new SimpleI<int>();
            var trivString  = new SimpleI<string>();

            Console.WriteLine($"{trivInt.ReturnIt(5)}");
            Console.WriteLine($"{trivString.ReturnIt("Hi There")}");

        }
    }
}