using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericsChapter
{
        interface IMyIfc2<T>
    {
        T ReturnIt(T inValue);
    }

    class SimpleIn : IMyIfc<int>, IMyIfc2<string>
    {
        public int ReturnIt(int inValue) => inValue;
        public string ReturnIt(string inValue) => inValue;

    }

    public static class AnotherGenericInterface
    {
       public static void Main() 
        {
            SimpleIn trivial     = new SimpleIn();
        
            Console.WriteLine($"{trivial.ReturnIt(15)}");
            Console.WriteLine($"{trivial.ReturnIt("Bye now")}");

        } 
    }
}