using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericsChapter
{
    class AnimalAgain { public string? Name;}
    class DogAgain : AnimalAgain {};

    interface IMyIfc3<out T>
    {
        T GetFirst();
    }

    class SimpleReturn<T>: IMyIfc3<T>
    {
        public T[] items = new T[2];
        public T GetFirst() { return items[0]; }
    }

    public static class CovarianceInterface
    {
        static void DoSomething(IMyIfc3<AnimalAgain> returner)
        {
            Console.WriteLine( returner.GetFirst().Name );
        }
        public static void Main() 
        {
            SimpleReturn<DogAgain> dogReturner = new SimpleReturn<DogAgain>();
            dogReturner.items[0] = new DogAgain() { Name = "Avonlea"};

            IMyIfc3<AnimalAgain> animalReturner = dogReturner;

            DoSomething(dogReturner);
        }
    }
}